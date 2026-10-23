Imports DevExpress.XtraReports.UI

Public Class BCPhanTichTTLD
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel32 As XRLabel
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DsReport1 As dsReport
    Friend WithEvents XrChart2 As XRChart
    Friend WithEvents XrLabel34 As XRLabel
    Friend WithEvents XrLabel33 As XRLabel
    Friend WithEvents XrChart3 As XRChart
    Friend WithEvents XrLabel35 As XRLabel
    Friend WithEvents XrLabel36 As XRLabel
    Friend WithEvents XrChart4 As XRChart
    Friend WithEvents XrChart5 As XRChart
    Friend WithEvents XrLabel41 As XRLabel
    Friend WithEvents XrLabel40 As XRLabel
    Friend WithEvents XrLabel39 As XRLabel
    Friend WithEvents XrLabel37 As XRLabel
    Friend WithEvents XrLabel38 As XRLabel
    Friend WithEvents XrLabel48 As XRLabel
    Friend WithEvents XrChart7 As XRChart
    Friend WithEvents XrLabel47 As XRLabel
    Friend WithEvents XrLabel45 As XRLabel
    Friend WithEvents XrLabel53 As XRLabel
    Friend WithEvents XrLabel54 As XRLabel
    Friend WithEvents XrChart8 As XRChart
    Friend WithEvents XrLabel52 As XRLabel
    Friend WithEvents XrLabel51 As XRLabel
    Friend WithEvents XrChart10 As XRChart
    Friend WithEvents XrLabel61 As XRLabel
    Friend WithEvents XrLabel59 As XRLabel
    Friend WithEvents XrLabel60 As XRLabel
    Friend WithEvents XrChart9 As XRChart
    Friend WithEvents XrLabel58 As XRLabel
    Friend WithEvents XrLabel57 As XRLabel
    Friend WithEvents XrLabel56 As XRLabel
    Friend WithEvents XrLabel55 As XRLabel
    Friend WithEvents XrTable1 As XRTable
    Friend WithEvents XrTableRow1 As XRTableRow
    Friend WithEvents XrTableCell1 As XRTableCell
    Friend WithEvents XrTableCell2 As XRTableCell
    Friend WithEvents XrTableCell3 As XRTableCell
    Friend WithEvents XrTableCell4 As XRTableCell
    Friend WithEvents XrTableCell5 As XRTableCell
    Friend WithEvents XrLabel67 As XRLabel
    Friend WithEvents XrLabel66 As XRLabel
    Friend WithEvents XrLabel65 As XRLabel
    Friend WithEvents XrLabel64 As XRLabel
    Friend WithEvents XrLabel63 As XRLabel
    Friend WithEvents XrLabel62 As XRLabel
    Friend WithEvents XrChart11 As XRChart
    Friend WithEvents XrLabel74 As XRLabel
    Friend WithEvents XrLabel73 As XRLabel
    Friend WithEvents XrLabel72 As XRLabel
    Friend WithEvents XrLabel71 As XRLabel
    Friend WithEvents XrLabel70 As XRLabel
    Friend WithEvents XrLabel69 As XRLabel
    Friend WithEvents XrLabel68 As XRLabel
    Friend WithEvents XrLabel83 As XRLabel
    Friend WithEvents XrTable2 As XRTable
    Friend WithEvents XrTableRow3 As XRTableRow
    Friend WithEvents XrTableCell11 As XRTableCell
    Friend WithEvents XrTableCell12 As XRTableCell
    Friend WithEvents XrTableCell13 As XRTableCell
    Friend WithEvents XrTableCell14 As XRTableCell
    Friend WithEvents XrTableCell15 As XRTableCell
    Friend WithEvents XrTableCell16 As XRTableCell
    Friend WithEvents XrTableCell17 As XRTableCell
    Friend WithEvents XrTableCell18 As XRTableCell
    Friend WithEvents XrTableRow4 As XRTableRow
    Friend WithEvents XrTableCell19 As XRTableCell
    Friend WithEvents XrTableCell20 As XRTableCell
    Friend WithEvents XrTableCell21 As XRTableCell
    Friend WithEvents XrTableCell22 As XRTableCell
    Friend WithEvents XrTableCell23 As XRTableCell
    Friend WithEvents XrTableCell24 As XRTableCell
    Friend WithEvents XrTableCell25 As XRTableCell
    Friend WithEvents XrTableCell26 As XRTableCell
    Friend WithEvents XrLabel82 As XRLabel
    Friend WithEvents XrLabel81 As XRLabel
    Friend WithEvents XrLabel80 As XRLabel
    Friend WithEvents XrLabel75 As XRLabel
    Friend WithEvents XrLabel76 As XRLabel
    Friend WithEvents XrLabel77 As XRLabel
    Friend WithEvents XrLabel78 As XRLabel
    Friend WithEvents XrChart12 As XRChart
    Friend WithEvents XrLabel79 As XRLabel
    Friend WithEvents XrLabel88 As XRLabel
    Friend WithEvents XrLabel87 As XRLabel
    Friend WithEvents XrLabel86 As XRLabel
    Friend WithEvents XrLabel85 As XRLabel
    Friend WithEvents XrLabel84 As XRLabel
    Friend WithEvents XrLabel25 As XRLabel
    Friend WithEvents XrLabel49 As XRLabel
    Friend WithEvents XrLabel43 As XRLabel
    Friend WithEvents XrChart6 As XRChart
    Friend WithEvents XrLabel44 As XRLabel
    Friend WithEvents XrLabel50 As XRLabel
    Friend WithEvents XrLabel46 As XRLabel
    Friend WithEvents XrTableRow14 As XRTableRow
    Friend WithEvents XrTableCell72 As XRTableCell
    Friend WithEvents XrTableCell73 As XRTableCell
    Friend WithEvents XrTableCell74 As XRTableCell
    Friend WithEvents XrTableCell75 As XRTableCell
    Friend WithEvents XrTableCell76 As XRTableCell
    Friend WithEvents XrTableCell77 As XRTableCell
    Friend WithEvents XrTableCell78 As XRTableCell
    Friend WithEvents XrTableCell79 As XRTableCell
    Friend WithEvents XrTableRow15 As XRTableRow
    Friend WithEvents XrTableCell80 As XRTableCell
    Friend WithEvents XrTableCell81 As XRTableCell
    Friend WithEvents XrTableCell82 As XRTableCell
    Friend WithEvents XrTableCell83 As XRTableCell
    Friend WithEvents XrTableCell84 As XRTableCell
    Friend WithEvents XrTableCell85 As XRTableCell
    Friend WithEvents XrTableCell86 As XRTableCell
    Friend WithEvents XrTableCell87 As XRTableCell
    Friend WithEvents XrTableRow16 As XRTableRow
    Friend WithEvents XrTableCell88 As XRTableCell
    Friend WithEvents XrTableCell89 As XRTableCell
    Friend WithEvents XrTableCell90 As XRTableCell
    Friend WithEvents XrTableCell91 As XRTableCell
    Friend WithEvents XrTableCell92 As XRTableCell
    Friend WithEvents XrTableCell93 As XRTableCell
    Friend WithEvents XrTableCell94 As XRTableCell
    Friend WithEvents XrTableCell95 As XRTableCell
    Friend WithEvents XrTableRow17 As XRTableRow
    Friend WithEvents XrTableCell96 As XRTableCell
    Friend WithEvents XrTableCell97 As XRTableCell
    Friend WithEvents XrTableCell98 As XRTableCell
    Friend WithEvents XrTableCell99 As XRTableCell
    Friend WithEvents XrTableCell100 As XRTableCell
    Friend WithEvents XrTableCell101 As XRTableCell
    Friend WithEvents XrTableCell102 As XRTableCell
    Friend WithEvents XrTableCell103 As XRTableCell
    Friend WithEvents XrTableRow18 As XRTableRow
    Friend WithEvents XrTableCell104 As XRTableCell
    Friend WithEvents XrTableCell105 As XRTableCell
    Friend WithEvents XrTableCell106 As XRTableCell
    Friend WithEvents XrTableCell107 As XRTableCell
    Friend WithEvents XrTableCell108 As XRTableCell
    Friend WithEvents XrTableCell109 As XRTableCell
    Friend WithEvents XrTableCell110 As XRTableCell
    Friend WithEvents XrTableCell111 As XRTableCell
    Friend WithEvents XrTableRow19 As XRTableRow
    Friend WithEvents XrTableCell112 As XRTableCell
    Friend WithEvents XrTableCell113 As XRTableCell
    Friend WithEvents XrTableCell114 As XRTableCell
    Friend WithEvents XrTableCell115 As XRTableCell
    Friend WithEvents XrTableCell116 As XRTableCell
    Friend WithEvents XrTableCell117 As XRTableCell
    Friend WithEvents XrTableCell118 As XRTableCell
    Friend WithEvents XrTableCell119 As XRTableCell
    Friend WithEvents XrTableRow20 As XRTableRow
    Friend WithEvents XrTableCell120 As XRTableCell
    Friend WithEvents XrTableCell121 As XRTableCell
    Friend WithEvents XrTableCell122 As XRTableCell
    Friend WithEvents XrTableCell123 As XRTableCell
    Friend WithEvents XrTableCell124 As XRTableCell
    Friend WithEvents XrTableCell125 As XRTableCell
    Friend WithEvents XrTableCell126 As XRTableCell
    Friend WithEvents XrTableCell127 As XRTableCell
    Friend WithEvents XrTableRow21 As XRTableRow
    Friend WithEvents XrTableCell128 As XRTableCell
    Friend WithEvents XrTableCell129 As XRTableCell
    Friend WithEvents XrTableCell130 As XRTableCell
    Friend WithEvents XrTableCell131 As XRTableCell
    Friend WithEvents XrTableCell132 As XRTableCell
    Friend WithEvents XrTableCell133 As XRTableCell
    Friend WithEvents XrTableCell134 As XRTableCell
    Friend WithEvents XrTableCell135 As XRTableCell
    Friend WithEvents XrTableRow5 As XRTableRow
    Friend WithEvents XrTableCell27 As XRTableCell
    Friend WithEvents XrTableCell28 As XRTableCell
    Friend WithEvents XrTableCell29 As XRTableCell
    Friend WithEvents XrTableCell30 As XRTableCell
    Friend WithEvents XrTableCell31 As XRTableCell
    Friend WithEvents XrTableRow6 As XRTableRow
    Friend WithEvents XrTableCell32 As XRTableCell
    Friend WithEvents XrTableCell33 As XRTableCell
    Friend WithEvents XrTableCell34 As XRTableCell
    Friend WithEvents XrTableCell35 As XRTableCell
    Friend WithEvents XrTableCell36 As XRTableCell
    Friend WithEvents XrTableRow7 As XRTableRow
    Friend WithEvents XrTableCell37 As XRTableCell
    Friend WithEvents XrTableCell38 As XRTableCell
    Friend WithEvents XrTableCell39 As XRTableCell
    Friend WithEvents XrTableCell40 As XRTableCell
    Friend WithEvents XrTableCell41 As XRTableCell
    Friend WithEvents XrTableRow8 As XRTableRow
    Friend WithEvents XrTableCell42 As XRTableCell
    Friend WithEvents XrTableCell43 As XRTableCell
    Friend WithEvents XrTableCell44 As XRTableCell
    Friend WithEvents XrTableCell45 As XRTableCell
    Friend WithEvents XrTableCell46 As XRTableCell
    Friend WithEvents XrTableRow9 As XRTableRow
    Friend WithEvents XrTableCell47 As XRTableCell
    Friend WithEvents XrTableCell48 As XRTableCell
    Friend WithEvents XrTableCell49 As XRTableCell
    Friend WithEvents XrTableCell50 As XRTableCell
    Friend WithEvents XrTableCell51 As XRTableCell
    Friend WithEvents XrTableRow10 As XRTableRow
    Friend WithEvents XrTableCell52 As XRTableCell
    Friend WithEvents XrTableCell53 As XRTableCell
    Friend WithEvents XrTableCell54 As XRTableCell
    Friend WithEvents XrTableCell55 As XRTableCell
    Friend WithEvents XrTableCell56 As XRTableCell
    Friend WithEvents XrTableRow11 As XRTableRow
    Friend WithEvents XrTableCell57 As XRTableCell
    Friend WithEvents XrTableCell58 As XRTableCell
    Friend WithEvents XrTableCell59 As XRTableCell
    Friend WithEvents XrTableCell60 As XRTableCell
    Friend WithEvents XrTableCell61 As XRTableCell
    Friend WithEvents XrTableRow12 As XRTableRow
    Friend WithEvents XrTableCell62 As XRTableCell
    Friend WithEvents XrTableCell63 As XRTableCell
    Friend WithEvents XrTableCell64 As XRTableCell
    Friend WithEvents XrTableCell65 As XRTableCell
    Friend WithEvents XrTableCell66 As XRTableCell
    Friend WithEvents XrTableRow13 As XRTableRow
    Friend WithEvents XrTableCell67 As XRTableCell
    Friend WithEvents XrTableCell68 As XRTableCell
    Friend WithEvents XrTableCell69 As XRTableCell
    Friend WithEvents XrTableCell70 As XRTableCell
    Friend WithEvents XrTableCell71 As XRTableCell
    Friend WithEvents XrRichText1 As XRRichText
    Friend WithEvents XrLabel11 As XRLabel
    Friend WithEvents XrLabel10 As XRLabel
    Friend WithEvents XrLabel42 As XRLabel
    Friend WithEvents XrLabel13 As XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BCPhanTichTTLD))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim RadarLineSeriesView1 As DevExpress.XtraCharts.RadarLineSeriesView = New DevExpress.XtraCharts.RadarLineSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim RadarLineSeriesView2 As DevExpress.XtraCharts.RadarLineSeriesView = New DevExpress.XtraCharts.RadarLineSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram4 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagram5 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagram6 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagram7 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagram8 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagram9 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel86 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell83 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell84 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell87 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell88 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell102 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell103 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell104 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell105 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell106 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell107 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell109 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell110 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell111 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell112 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell113 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell114 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell115 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell116 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell117 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell118 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell119 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell120 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell121 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell122 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell123 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell124 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell125 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell126 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell127 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell128 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell129 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell130 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell131 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell132 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell133 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell134 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell135 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel81 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel75 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel76 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel77 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel78 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart12 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart11 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel72 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel68 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart10 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart9 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart8 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart7 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart6 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart5 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart4 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart3 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrChart2 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DsReport1 = New DotNetNuke.REPORT.dsReport()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 37.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 55.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel42, Me.XrLabel13, Me.XrLabel11, Me.XrLabel10, Me.XrRichText1, Me.XrLabel88, Me.XrLabel87, Me.XrLabel86, Me.XrLabel85, Me.XrLabel84, Me.XrLabel83, Me.XrTable2, Me.XrLabel82, Me.XrLabel81, Me.XrLabel80, Me.XrLabel75, Me.XrLabel76, Me.XrLabel77, Me.XrLabel78, Me.XrChart12, Me.XrLabel79, Me.XrChart11, Me.XrLabel74, Me.XrLabel73, Me.XrLabel72, Me.XrLabel71, Me.XrLabel70, Me.XrLabel69, Me.XrLabel68, Me.XrTable1, Me.XrLabel67, Me.XrLabel66, Me.XrLabel65, Me.XrLabel64, Me.XrLabel63, Me.XrLabel62, Me.XrChart10, Me.XrLabel61, Me.XrLabel59, Me.XrLabel60, Me.XrChart9, Me.XrLabel58, Me.XrLabel57, Me.XrLabel56, Me.XrLabel55, Me.XrLabel53, Me.XrLabel54, Me.XrChart8, Me.XrLabel52, Me.XrLabel51, Me.XrLabel50, Me.XrLabel49, Me.XrLabel48, Me.XrChart7, Me.XrLabel47, Me.XrLabel46, Me.XrLabel45, Me.XrLabel43, Me.XrChart6, Me.XrLabel44, Me.XrChart5, Me.XrLabel41, Me.XrLabel40, Me.XrLabel39, Me.XrLabel37, Me.XrLabel38, Me.XrLabel36, Me.XrChart4, Me.XrLabel35, Me.XrLabel34, Me.XrLabel33, Me.XrChart3, Me.XrChart2, Me.XrLabel32, Me.XrLabel31, Me.XrLabel30, Me.XrLabel29, Me.XrLabel28, Me.XrLabel27, Me.XrLabel26, Me.XrChart1, Me.XrLabel25, Me.XrLabel24, Me.XrLabel23, Me.XrLabel15, Me.XrLabel9, Me.XrLabel12, Me.XrLabel16, Me.XrLabel17, Me.XrLabel14, Me.XrLabel18, Me.XrLabel19, Me.XrLabel20, Me.XrLabel21, Me.XrLabel22})
        Me.Detail.HeightF = 9404.761!
        Me.Detail.Name = "Detail"
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 201.4583!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(124.5834!, 25.08331!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "* Bảng số 01: "
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0!, 176.375!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(738.8337!, 25.08331!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "a) Nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText1
        '
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(3.99998!, 25.08334!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(734.8337!, 100.0!)
        '
        'XrLabel88
        '
        Me.XrLabel88.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel88.LocationFloat = New DevExpress.Utils.PointFloat(353.8333!, 9269.09!)
        Me.XrLabel88.Multiline = True
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel88.SizeF = New System.Drawing.SizeF(357.0418!, 48.0!)
        Me.XrLabel88.StylePriority.UseFont = False
        Me.XrLabel88.StylePriority.UseTextAlignment = False
        Me.XrLabel88.Text = "KT. GIÁM ĐỐC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PHÓ GIÁM ĐỐC"
        Me.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel87
        '
        Me.XrLabel87.Font = New System.Drawing.Font("Times New Roman", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(23.27161!, 9269.09!)
        Me.XrLabel87.Multiline = True
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(243.6249!, 27.16602!)
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "Nơi nhận:"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel86
        '
        Me.XrLabel86.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.XrLabel86.LocationFloat = New DevExpress.Utils.PointFloat(6.875499!, 9347.303!)
        Me.XrLabel86.Multiline = True
        Me.XrLabel86.Name = "XrLabel86"
        Me.XrLabel86.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel86.SizeF = New System.Drawing.SizeF(240.4583!, 57.45801!)
        Me.XrLabel86.StylePriority.UseFont = False
        Me.XrLabel86.StylePriority.UseTextAlignment = False
        Me.XrLabel86.Text = "- Giám đốc, PGĐ TT(B/c)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Lưu: VT." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel85
        '
        Me.XrLabel85.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel85.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9007.456!)
        Me.XrLabel85.Multiline = True
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel85.SizeF = New System.Drawing.SizeF(731.6667!, 186.625!)
        Me.XrLabel85.StylePriority.UseFont = False
        Me.XrLabel85.StylePriority.UseTextAlignment = False
        Me.XrLabel85.Text = resources.GetString("XrLabel85.Text")
        Me.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel84
        '
        Me.XrLabel84.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel84.LocationFloat = New DevExpress.Utils.PointFloat(0.16644!, 8980.29!)
        Me.XrLabel84.Multiline = True
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel84.SizeF = New System.Drawing.SizeF(731.6667!, 27.16602!)
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        Me.XrLabel84.Text = "IV. Phương hướng, nhiệm vụ trọng tâm năm [dtMaster.KyBCSau]"
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel83
        '
        Me.XrLabel83.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel83.LocationFloat = New DevExpress.Utils.PointFloat(616.7629!, 8490.558!)
        Me.XrLabel83.Multiline = True
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel83.SizeF = New System.Drawing.SizeF(99.61108!, 25.08301!)
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        Me.XrLabel83.Text = "Đơn vị %"
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 8515.641!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4, Me.XrTableRow14, Me.XrTableRow15, Me.XrTableRow16, Me.XrTableRow17, Me.XrTableRow18, Me.XrTableRow19, Me.XrTableRow20, Me.XrTableRow21})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(726.9996!, 439.5676!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UsePadding = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18})
        Me.XrTableRow3.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.StylePriority.UseBackColor = False
        Me.XrTableRow3.StylePriority.UseFont = False
        Me.XrTableRow3.Weight = 3.25R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Multiline = True
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Text = "Nhóm tuổi/Nguyên nhân thất nghiệp"
        Me.XrTableCell11.Weight = 0.28818713499414772R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Multiline = True
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Text = "Do DN, tổ chức giải thể, phá sản, thay đổi cơ cấu,..."
        Me.XrTableCell12.Weight = 0.25909342092825277R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Multiline = True
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Text = "Hết hạn HĐ lao động, HĐ làm việc"
        Me.XrTableCell13.Weight = 0.26318406663668625R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Multiline = True
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Text = "Chấm dứt HĐ lao động, HĐ làm việc trước thời hạn"
        Me.XrTableCell14.Weight = 0.26748144288729292R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Multiline = True
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Text = "Bị xử lý kỷ luật, sa thải"
        Me.XrTableCell15.Weight = 0.26123787095360035R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Multiline = True
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Text = "Do đơn phương chấm dứt HĐ lao động, HĐ làm việc trái pháp luật"
        Me.XrTableCell16.Weight = 0.30041888673403205R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Multiline = True
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Text = "Mất việc làm do nguyên nhân khác"
        Me.XrTableCell17.Weight = 0.26589244597791151R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Multiline = True
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Text = "Tổng"
        Me.XrTableCell18.Weight = 0.22144453309511925R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.BackColor = System.Drawing.Color.White
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26})
        Me.XrTableRow4.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.StylePriority.UseBackColor = False
        Me.XrTableRow4.StylePriority.UseFont = False
        Me.XrTableRow4.Weight = 0.70451610153934907R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Multiline = True
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Text = "19-25"
        Me.XrTableCell19.Weight = 0.28818713499414772R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Multiline = True
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Text = "0"
        Me.XrTableCell20.Weight = 0.25909342092825277R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Multiline = True
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Text = "0"
        Me.XrTableCell21.Weight = 0.26318406663668625R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Multiline = True
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Text = "0"
        Me.XrTableCell22.Weight = 0.26748144288729292R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Multiline = True
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Text = "0"
        Me.XrTableCell23.Weight = 0.26123787095360035R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Multiline = True
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Text = "0"
        Me.XrTableCell24.Weight = 0.30041888673403205R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Multiline = True
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Text = "0"
        Me.XrTableCell25.Weight = 0.26589244597791151R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Multiline = True
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Text = "100"
        Me.XrTableCell26.Weight = 0.22144453309511925R
        '
        'XrTableRow14
        '
        Me.XrTableRow14.BackColor = System.Drawing.Color.White
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell72, Me.XrTableCell73, Me.XrTableCell74, Me.XrTableCell75, Me.XrTableCell76, Me.XrTableCell77, Me.XrTableCell78, Me.XrTableCell79})
        Me.XrTableRow14.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.StylePriority.UseBackColor = False
        Me.XrTableRow14.StylePriority.UseFont = False
        Me.XrTableRow14.Weight = 0.70451610153934907R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.Multiline = True
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.Text = "26-30"
        Me.XrTableCell72.Weight = 0.28818713499414772R
        '
        'XrTableCell73
        '
        Me.XrTableCell73.Multiline = True
        Me.XrTableCell73.Name = "XrTableCell73"
        Me.XrTableCell73.Text = "0"
        Me.XrTableCell73.Weight = 0.25909342092825277R
        '
        'XrTableCell74
        '
        Me.XrTableCell74.Multiline = True
        Me.XrTableCell74.Name = "XrTableCell74"
        Me.XrTableCell74.Text = "0"
        Me.XrTableCell74.Weight = 0.26318406663668625R
        '
        'XrTableCell75
        '
        Me.XrTableCell75.Multiline = True
        Me.XrTableCell75.Name = "XrTableCell75"
        Me.XrTableCell75.Text = "0"
        Me.XrTableCell75.Weight = 0.26748144288729292R
        '
        'XrTableCell76
        '
        Me.XrTableCell76.Multiline = True
        Me.XrTableCell76.Name = "XrTableCell76"
        Me.XrTableCell76.Text = "0"
        Me.XrTableCell76.Weight = 0.26123787095360035R
        '
        'XrTableCell77
        '
        Me.XrTableCell77.Multiline = True
        Me.XrTableCell77.Name = "XrTableCell77"
        Me.XrTableCell77.Text = "0"
        Me.XrTableCell77.Weight = 0.30041888673403205R
        '
        'XrTableCell78
        '
        Me.XrTableCell78.Multiline = True
        Me.XrTableCell78.Name = "XrTableCell78"
        Me.XrTableCell78.Text = "0"
        Me.XrTableCell78.Weight = 0.26589244597791151R
        '
        'XrTableCell79
        '
        Me.XrTableCell79.Multiline = True
        Me.XrTableCell79.Name = "XrTableCell79"
        Me.XrTableCell79.Text = "100"
        Me.XrTableCell79.Weight = 0.22144453309511925R
        '
        'XrTableRow15
        '
        Me.XrTableRow15.BackColor = System.Drawing.Color.White
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell80, Me.XrTableCell81, Me.XrTableCell82, Me.XrTableCell83, Me.XrTableCell84, Me.XrTableCell85, Me.XrTableCell86, Me.XrTableCell87})
        Me.XrTableRow15.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.StylePriority.UseBackColor = False
        Me.XrTableRow15.StylePriority.UseFont = False
        Me.XrTableRow15.Weight = 0.70451610153934907R
        '
        'XrTableCell80
        '
        Me.XrTableCell80.Multiline = True
        Me.XrTableCell80.Name = "XrTableCell80"
        Me.XrTableCell80.Text = "31-35"
        Me.XrTableCell80.Weight = 0.28818713499414772R
        '
        'XrTableCell81
        '
        Me.XrTableCell81.Multiline = True
        Me.XrTableCell81.Name = "XrTableCell81"
        Me.XrTableCell81.Text = "0"
        Me.XrTableCell81.Weight = 0.25909342092825277R
        '
        'XrTableCell82
        '
        Me.XrTableCell82.Multiline = True
        Me.XrTableCell82.Name = "XrTableCell82"
        Me.XrTableCell82.Text = "0"
        Me.XrTableCell82.Weight = 0.26318406663668625R
        '
        'XrTableCell83
        '
        Me.XrTableCell83.Multiline = True
        Me.XrTableCell83.Name = "XrTableCell83"
        Me.XrTableCell83.Text = "0"
        Me.XrTableCell83.Weight = 0.26748144288729292R
        '
        'XrTableCell84
        '
        Me.XrTableCell84.Multiline = True
        Me.XrTableCell84.Name = "XrTableCell84"
        Me.XrTableCell84.Text = "0"
        Me.XrTableCell84.Weight = 0.26123787095360035R
        '
        'XrTableCell85
        '
        Me.XrTableCell85.Multiline = True
        Me.XrTableCell85.Name = "XrTableCell85"
        Me.XrTableCell85.Text = "0"
        Me.XrTableCell85.Weight = 0.30041888673403205R
        '
        'XrTableCell86
        '
        Me.XrTableCell86.Multiline = True
        Me.XrTableCell86.Name = "XrTableCell86"
        Me.XrTableCell86.Text = "0"
        Me.XrTableCell86.Weight = 0.26589244597791151R
        '
        'XrTableCell87
        '
        Me.XrTableCell87.Multiline = True
        Me.XrTableCell87.Name = "XrTableCell87"
        Me.XrTableCell87.Text = "100"
        Me.XrTableCell87.Weight = 0.22144453309511925R
        '
        'XrTableRow16
        '
        Me.XrTableRow16.BackColor = System.Drawing.Color.White
        Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell88, Me.XrTableCell89, Me.XrTableCell90, Me.XrTableCell91, Me.XrTableCell92, Me.XrTableCell93, Me.XrTableCell94, Me.XrTableCell95})
        Me.XrTableRow16.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow16.Name = "XrTableRow16"
        Me.XrTableRow16.StylePriority.UseBackColor = False
        Me.XrTableRow16.StylePriority.UseFont = False
        Me.XrTableRow16.Weight = 0.70451610153934907R
        '
        'XrTableCell88
        '
        Me.XrTableCell88.Multiline = True
        Me.XrTableCell88.Name = "XrTableCell88"
        Me.XrTableCell88.Text = "36-40"
        Me.XrTableCell88.Weight = 0.28818713499414772R
        '
        'XrTableCell89
        '
        Me.XrTableCell89.Multiline = True
        Me.XrTableCell89.Name = "XrTableCell89"
        Me.XrTableCell89.Text = "0"
        Me.XrTableCell89.Weight = 0.25909342092825277R
        '
        'XrTableCell90
        '
        Me.XrTableCell90.Multiline = True
        Me.XrTableCell90.Name = "XrTableCell90"
        Me.XrTableCell90.Text = "0"
        Me.XrTableCell90.Weight = 0.26318406663668625R
        '
        'XrTableCell91
        '
        Me.XrTableCell91.Multiline = True
        Me.XrTableCell91.Name = "XrTableCell91"
        Me.XrTableCell91.Text = "0"
        Me.XrTableCell91.Weight = 0.26748144288729292R
        '
        'XrTableCell92
        '
        Me.XrTableCell92.Multiline = True
        Me.XrTableCell92.Name = "XrTableCell92"
        Me.XrTableCell92.Text = "0"
        Me.XrTableCell92.Weight = 0.26123787095360035R
        '
        'XrTableCell93
        '
        Me.XrTableCell93.Multiline = True
        Me.XrTableCell93.Name = "XrTableCell93"
        Me.XrTableCell93.Text = "0"
        Me.XrTableCell93.Weight = 0.30041888673403205R
        '
        'XrTableCell94
        '
        Me.XrTableCell94.Multiline = True
        Me.XrTableCell94.Name = "XrTableCell94"
        Me.XrTableCell94.Text = "0"
        Me.XrTableCell94.Weight = 0.26589244597791151R
        '
        'XrTableCell95
        '
        Me.XrTableCell95.Multiline = True
        Me.XrTableCell95.Name = "XrTableCell95"
        Me.XrTableCell95.Text = "100"
        Me.XrTableCell95.Weight = 0.22144453309511925R
        '
        'XrTableRow17
        '
        Me.XrTableRow17.BackColor = System.Drawing.Color.White
        Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell96, Me.XrTableCell97, Me.XrTableCell98, Me.XrTableCell99, Me.XrTableCell100, Me.XrTableCell101, Me.XrTableCell102, Me.XrTableCell103})
        Me.XrTableRow17.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow17.Name = "XrTableRow17"
        Me.XrTableRow17.StylePriority.UseBackColor = False
        Me.XrTableRow17.StylePriority.UseFont = False
        Me.XrTableRow17.Weight = 0.70451610153934907R
        '
        'XrTableCell96
        '
        Me.XrTableCell96.Multiline = True
        Me.XrTableCell96.Name = "XrTableCell96"
        Me.XrTableCell96.Text = "41-45"
        Me.XrTableCell96.Weight = 0.28818713499414772R
        '
        'XrTableCell97
        '
        Me.XrTableCell97.Multiline = True
        Me.XrTableCell97.Name = "XrTableCell97"
        Me.XrTableCell97.Text = "0"
        Me.XrTableCell97.Weight = 0.25909342092825277R
        '
        'XrTableCell98
        '
        Me.XrTableCell98.Multiline = True
        Me.XrTableCell98.Name = "XrTableCell98"
        Me.XrTableCell98.Text = "0"
        Me.XrTableCell98.Weight = 0.26318406663668625R
        '
        'XrTableCell99
        '
        Me.XrTableCell99.Multiline = True
        Me.XrTableCell99.Name = "XrTableCell99"
        Me.XrTableCell99.Text = "0"
        Me.XrTableCell99.Weight = 0.26748144288729292R
        '
        'XrTableCell100
        '
        Me.XrTableCell100.Multiline = True
        Me.XrTableCell100.Name = "XrTableCell100"
        Me.XrTableCell100.Text = "0"
        Me.XrTableCell100.Weight = 0.26123787095360035R
        '
        'XrTableCell101
        '
        Me.XrTableCell101.Multiline = True
        Me.XrTableCell101.Name = "XrTableCell101"
        Me.XrTableCell101.Text = "0"
        Me.XrTableCell101.Weight = 0.30041888673403205R
        '
        'XrTableCell102
        '
        Me.XrTableCell102.Multiline = True
        Me.XrTableCell102.Name = "XrTableCell102"
        Me.XrTableCell102.Text = "0"
        Me.XrTableCell102.Weight = 0.26589244597791151R
        '
        'XrTableCell103
        '
        Me.XrTableCell103.Multiline = True
        Me.XrTableCell103.Name = "XrTableCell103"
        Me.XrTableCell103.Text = "100"
        Me.XrTableCell103.Weight = 0.22144453309511925R
        '
        'XrTableRow18
        '
        Me.XrTableRow18.BackColor = System.Drawing.Color.White
        Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell104, Me.XrTableCell105, Me.XrTableCell106, Me.XrTableCell107, Me.XrTableCell108, Me.XrTableCell109, Me.XrTableCell110, Me.XrTableCell111})
        Me.XrTableRow18.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow18.Name = "XrTableRow18"
        Me.XrTableRow18.StylePriority.UseBackColor = False
        Me.XrTableRow18.StylePriority.UseFont = False
        Me.XrTableRow18.Weight = 0.70451610153934907R
        '
        'XrTableCell104
        '
        Me.XrTableCell104.Multiline = True
        Me.XrTableCell104.Name = "XrTableCell104"
        Me.XrTableCell104.Text = "46-50"
        Me.XrTableCell104.Weight = 0.28818713499414772R
        '
        'XrTableCell105
        '
        Me.XrTableCell105.Multiline = True
        Me.XrTableCell105.Name = "XrTableCell105"
        Me.XrTableCell105.Text = "0"
        Me.XrTableCell105.Weight = 0.25909342092825277R
        '
        'XrTableCell106
        '
        Me.XrTableCell106.Multiline = True
        Me.XrTableCell106.Name = "XrTableCell106"
        Me.XrTableCell106.Text = "0"
        Me.XrTableCell106.Weight = 0.26318406663668625R
        '
        'XrTableCell107
        '
        Me.XrTableCell107.Multiline = True
        Me.XrTableCell107.Name = "XrTableCell107"
        Me.XrTableCell107.Text = "0"
        Me.XrTableCell107.Weight = 0.26748144288729292R
        '
        'XrTableCell108
        '
        Me.XrTableCell108.Multiline = True
        Me.XrTableCell108.Name = "XrTableCell108"
        Me.XrTableCell108.Text = "0"
        Me.XrTableCell108.Weight = 0.26123787095360035R
        '
        'XrTableCell109
        '
        Me.XrTableCell109.Multiline = True
        Me.XrTableCell109.Name = "XrTableCell109"
        Me.XrTableCell109.Text = "0"
        Me.XrTableCell109.Weight = 0.30041888673403205R
        '
        'XrTableCell110
        '
        Me.XrTableCell110.Multiline = True
        Me.XrTableCell110.Name = "XrTableCell110"
        Me.XrTableCell110.Text = "0"
        Me.XrTableCell110.Weight = 0.26589244597791151R
        '
        'XrTableCell111
        '
        Me.XrTableCell111.Multiline = True
        Me.XrTableCell111.Name = "XrTableCell111"
        Me.XrTableCell111.Text = "100"
        Me.XrTableCell111.Weight = 0.22144453309511925R
        '
        'XrTableRow19
        '
        Me.XrTableRow19.BackColor = System.Drawing.Color.White
        Me.XrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell112, Me.XrTableCell113, Me.XrTableCell114, Me.XrTableCell115, Me.XrTableCell116, Me.XrTableCell117, Me.XrTableCell118, Me.XrTableCell119})
        Me.XrTableRow19.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow19.Name = "XrTableRow19"
        Me.XrTableRow19.StylePriority.UseBackColor = False
        Me.XrTableRow19.StylePriority.UseFont = False
        Me.XrTableRow19.Weight = 0.70451610153934907R
        '
        'XrTableCell112
        '
        Me.XrTableCell112.Multiline = True
        Me.XrTableCell112.Name = "XrTableCell112"
        Me.XrTableCell112.Text = "51-55"
        Me.XrTableCell112.Weight = 0.28818713499414772R
        '
        'XrTableCell113
        '
        Me.XrTableCell113.Multiline = True
        Me.XrTableCell113.Name = "XrTableCell113"
        Me.XrTableCell113.Text = "0"
        Me.XrTableCell113.Weight = 0.25909342092825277R
        '
        'XrTableCell114
        '
        Me.XrTableCell114.Multiline = True
        Me.XrTableCell114.Name = "XrTableCell114"
        Me.XrTableCell114.Text = "0"
        Me.XrTableCell114.Weight = 0.26318406663668625R
        '
        'XrTableCell115
        '
        Me.XrTableCell115.Multiline = True
        Me.XrTableCell115.Name = "XrTableCell115"
        Me.XrTableCell115.Text = "0"
        Me.XrTableCell115.Weight = 0.26748144288729292R
        '
        'XrTableCell116
        '
        Me.XrTableCell116.Multiline = True
        Me.XrTableCell116.Name = "XrTableCell116"
        Me.XrTableCell116.Text = "0"
        Me.XrTableCell116.Weight = 0.26123787095360035R
        '
        'XrTableCell117
        '
        Me.XrTableCell117.Multiline = True
        Me.XrTableCell117.Name = "XrTableCell117"
        Me.XrTableCell117.Text = "0"
        Me.XrTableCell117.Weight = 0.30041888673403205R
        '
        'XrTableCell118
        '
        Me.XrTableCell118.Multiline = True
        Me.XrTableCell118.Name = "XrTableCell118"
        Me.XrTableCell118.Text = "0"
        Me.XrTableCell118.Weight = 0.26589244597791151R
        '
        'XrTableCell119
        '
        Me.XrTableCell119.Multiline = True
        Me.XrTableCell119.Name = "XrTableCell119"
        Me.XrTableCell119.Text = "100"
        Me.XrTableCell119.Weight = 0.22144453309511925R
        '
        'XrTableRow20
        '
        Me.XrTableRow20.BackColor = System.Drawing.Color.White
        Me.XrTableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell120, Me.XrTableCell121, Me.XrTableCell122, Me.XrTableCell123, Me.XrTableCell124, Me.XrTableCell125, Me.XrTableCell126, Me.XrTableCell127})
        Me.XrTableRow20.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow20.Name = "XrTableRow20"
        Me.XrTableRow20.StylePriority.UseBackColor = False
        Me.XrTableRow20.StylePriority.UseFont = False
        Me.XrTableRow20.Weight = 0.70451610153934907R
        '
        'XrTableCell120
        '
        Me.XrTableCell120.Multiline = True
        Me.XrTableCell120.Name = "XrTableCell120"
        Me.XrTableCell120.Text = "56-60"
        Me.XrTableCell120.Weight = 0.28818713499414772R
        '
        'XrTableCell121
        '
        Me.XrTableCell121.Multiline = True
        Me.XrTableCell121.Name = "XrTableCell121"
        Me.XrTableCell121.Text = "0"
        Me.XrTableCell121.Weight = 0.25909342092825277R
        '
        'XrTableCell122
        '
        Me.XrTableCell122.Multiline = True
        Me.XrTableCell122.Name = "XrTableCell122"
        Me.XrTableCell122.Text = "0"
        Me.XrTableCell122.Weight = 0.26318406663668625R
        '
        'XrTableCell123
        '
        Me.XrTableCell123.Multiline = True
        Me.XrTableCell123.Name = "XrTableCell123"
        Me.XrTableCell123.Text = "0"
        Me.XrTableCell123.Weight = 0.26748144288729292R
        '
        'XrTableCell124
        '
        Me.XrTableCell124.Multiline = True
        Me.XrTableCell124.Name = "XrTableCell124"
        Me.XrTableCell124.Text = "0"
        Me.XrTableCell124.Weight = 0.26123787095360035R
        '
        'XrTableCell125
        '
        Me.XrTableCell125.Multiline = True
        Me.XrTableCell125.Name = "XrTableCell125"
        Me.XrTableCell125.Text = "0"
        Me.XrTableCell125.Weight = 0.30041888673403205R
        '
        'XrTableCell126
        '
        Me.XrTableCell126.Multiline = True
        Me.XrTableCell126.Name = "XrTableCell126"
        Me.XrTableCell126.Text = "0"
        Me.XrTableCell126.Weight = 0.26589244597791151R
        '
        'XrTableCell127
        '
        Me.XrTableCell127.Multiline = True
        Me.XrTableCell127.Name = "XrTableCell127"
        Me.XrTableCell127.Text = "100"
        Me.XrTableCell127.Weight = 0.22144453309511925R
        '
        'XrTableRow21
        '
        Me.XrTableRow21.BackColor = System.Drawing.Color.White
        Me.XrTableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell128, Me.XrTableCell129, Me.XrTableCell130, Me.XrTableCell131, Me.XrTableCell132, Me.XrTableCell133, Me.XrTableCell134, Me.XrTableCell135})
        Me.XrTableRow21.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTableRow21.Name = "XrTableRow21"
        Me.XrTableRow21.StylePriority.UseBackColor = False
        Me.XrTableRow21.StylePriority.UseFont = False
        Me.XrTableRow21.Weight = 0.70451610153934907R
        '
        'XrTableCell128
        '
        Me.XrTableCell128.Multiline = True
        Me.XrTableCell128.Name = "XrTableCell128"
        Me.XrTableCell128.Text = "61-69"
        Me.XrTableCell128.Weight = 0.28818713499414772R
        '
        'XrTableCell129
        '
        Me.XrTableCell129.Multiline = True
        Me.XrTableCell129.Name = "XrTableCell129"
        Me.XrTableCell129.Text = "0"
        Me.XrTableCell129.Weight = 0.25909342092825277R
        '
        'XrTableCell130
        '
        Me.XrTableCell130.Multiline = True
        Me.XrTableCell130.Name = "XrTableCell130"
        Me.XrTableCell130.Text = "0"
        Me.XrTableCell130.Weight = 0.26318406663668625R
        '
        'XrTableCell131
        '
        Me.XrTableCell131.Multiline = True
        Me.XrTableCell131.Name = "XrTableCell131"
        Me.XrTableCell131.Text = "0"
        Me.XrTableCell131.Weight = 0.26748144288729292R
        '
        'XrTableCell132
        '
        Me.XrTableCell132.Multiline = True
        Me.XrTableCell132.Name = "XrTableCell132"
        Me.XrTableCell132.Text = "0"
        Me.XrTableCell132.Weight = 0.26123787095360035R
        '
        'XrTableCell133
        '
        Me.XrTableCell133.Multiline = True
        Me.XrTableCell133.Name = "XrTableCell133"
        Me.XrTableCell133.Text = "0"
        Me.XrTableCell133.Weight = 0.30041888673403205R
        '
        'XrTableCell134
        '
        Me.XrTableCell134.Multiline = True
        Me.XrTableCell134.Name = "XrTableCell134"
        Me.XrTableCell134.Text = "0"
        Me.XrTableCell134.Weight = 0.26589244597791151R
        '
        'XrTableCell135
        '
        Me.XrTableCell135.Multiline = True
        Me.XrTableCell135.Name = "XrTableCell135"
        Me.XrTableCell135.Text = "100"
        Me.XrTableCell135.Weight = 0.22144453309511925R
        '
        'XrLabel82
        '
        Me.XrLabel82.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(0.16644!, 8955.208!)
        Me.XrLabel82.Multiline = True
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(731.6668!, 25.08203!)
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        Me.XrLabel82.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel81
        '
        Me.XrLabel81.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel81.LocationFloat = New DevExpress.Utils.PointFloat(0!, 8463.392!)
        Me.XrLabel81.Multiline = True
        Me.XrLabel81.Name = "XrLabel81"
        Me.XrLabel81.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel81.SizeF = New System.Drawing.SizeF(730.1664!, 27.16602!)
        Me.XrLabel81.StylePriority.UseFont = False
        Me.XrLabel81.StylePriority.UseTextAlignment = False
        Me.XrLabel81.Text = "Bảng 2: Nguyên nhân thất nghiệp "
        Me.XrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel80
        '
        Me.XrLabel80.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(0!, 8215.31!)
        Me.XrLabel80.Multiline = True
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(730.1664!, 248.0825!)
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.StylePriority.UseTextAlignment = False
        Me.XrLabel80.Text = resources.GetString("XrLabel80.Text")
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel75
        '
        Me.XrLabel75.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel75.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7486.17!)
        Me.XrLabel75.Multiline = True
        Me.XrLabel75.Name = "XrLabel75"
        Me.XrLabel75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel75.SizeF = New System.Drawing.SizeF(730.9999!, 27.1665!)
        Me.XrLabel75.StylePriority.UseFont = False
        Me.XrLabel75.StylePriority.UseTextAlignment = False
        Me.XrLabel75.Text = "2.2. Xét theo trình độ chuyên môn kỹ thuật"
        Me.XrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel76
        '
        Me.XrLabel76.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel76.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7513.337!)
        Me.XrLabel76.Multiline = True
        Me.XrLabel76.Name = "XrLabel76"
        Me.XrLabel76.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel76.SizeF = New System.Drawing.SizeF(730.9999!, 318.9165!)
        Me.XrLabel76.StylePriority.UseFont = False
        Me.XrLabel76.StylePriority.UseTextAlignment = False
        Me.XrLabel76.Text = resources.GetString("XrLabel76.Text")
        Me.XrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel77
        '
        Me.XrLabel77.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel77.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7832.253!)
        Me.XrLabel77.Multiline = True
        Me.XrLabel77.Name = "XrLabel77"
        Me.XrLabel77.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel77.SizeF = New System.Drawing.SizeF(730.9999!, 27.1665!)
        Me.XrLabel77.StylePriority.UseFont = False
        Me.XrLabel77.StylePriority.UseTextAlignment = False
        Me.XrLabel77.Text = "Hình 11. Tỷ lệ lao động thất nghiệp phân theo trình độ CMKT"
        Me.XrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel78
        '
        Me.XrLabel78.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel78.LocationFloat = New DevExpress.Utils.PointFloat(618.2632!, 7859.42!)
        Me.XrLabel78.Multiline = True
        Me.XrLabel78.Name = "XrLabel78"
        Me.XrLabel78.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel78.SizeF = New System.Drawing.SizeF(98.94421!, 25.0835!)
        Me.XrLabel78.StylePriority.UseFont = False
        Me.XrLabel78.StylePriority.UseTextAlignment = False
        Me.XrLabel78.Text = "Đơn vị %"
        Me.XrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart12
        '
        Me.XrChart12.BorderColor = System.Drawing.Color.Black
        Me.XrChart12.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart12.Diagram = XyDiagram1
        Me.XrChart12.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart12.Legend.Name = "Default Legend"
        Me.XrChart12.LocationFloat = New DevExpress.Utils.PointFloat(32.91637!, 7884.503!)
        Me.XrChart12.Name = "XrChart12"
        Me.XrChart12.PaletteName = "Palette 1"
        Me.XrChart12.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart12.SeriesDataMember = "ChartBHTN2_2.CYear"
        Me.XrChart12.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart12.SeriesTemplate.ArgumentDataMember = "ChartBHTN2_2.CName"
        Me.XrChart12.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart12.SeriesTemplate.SeriesDataMember = "ChartBHTN2_2.CYear"
        Me.XrChart12.SeriesTemplate.ShowInLegend = False
        Me.XrChart12.SeriesTemplate.ValueDataMembersSerializable = "ChartBHTN2_2.CValue"
        Me.XrChart12.SeriesTemplate.View = LineSeriesView1
        Me.XrChart12.SizeF = New System.Drawing.SizeF(673.9583!, 305.7236!)
        '
        'XrLabel79
        '
        Me.XrLabel79.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(0!, 8190.226!)
        Me.XrLabel79.Multiline = True
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel79.SizeF = New System.Drawing.SizeF(730.1666!, 25.0835!)
        Me.XrLabel79.StylePriority.UseFont = False
        Me.XrLabel79.StylePriority.UseTextAlignment = False
        Me.XrLabel79.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart11
        '
        Me.XrChart11.BorderColor = System.Drawing.Color.Black
        Me.XrChart11.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart11.Diagram = XyDiagram2
        Me.XrChart11.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart11.Legend.Name = "Default Legend"
        Me.XrChart11.LocationFloat = New DevExpress.Utils.PointFloat(32.91637!, 7155.363!)
        Me.XrChart11.Name = "XrChart11"
        Me.XrChart11.PaletteName = "Palette 1"
        Me.XrChart11.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart11.SeriesDataMember = "ChartBHTN2_1.CYear"
        Me.XrChart11.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart11.SeriesTemplate.ArgumentDataMember = "ChartBHTN2_1.CName"
        Me.XrChart11.SeriesTemplate.SeriesDataMember = "ChartBHTN2_1.CYear"
        Me.XrChart11.SeriesTemplate.ValueDataMembersSerializable = "ChartBHTN2_1.CValue"
        Me.XrChart11.SeriesTemplate.View = LineSeriesView2
        Me.XrChart11.SizeF = New System.Drawing.SizeF(673.9583!, 305.7236!)
        '
        'XrLabel74
        '
        Me.XrLabel74.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel74.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7461.087!)
        Me.XrLabel74.Multiline = True
        Me.XrLabel74.Name = "XrLabel74"
        Me.XrLabel74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel74.SizeF = New System.Drawing.SizeF(731.0001!, 25.0835!)
        Me.XrLabel74.StylePriority.UseFont = False
        Me.XrLabel74.StylePriority.UseTextAlignment = False
        Me.XrLabel74.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel73
        '
        Me.XrLabel73.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel73.LocationFloat = New DevExpress.Utils.PointFloat(619.0964!, 7130.28!)
        Me.XrLabel73.Multiline = True
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel73.SizeF = New System.Drawing.SizeF(101.9445!, 25.0835!)
        Me.XrLabel73.StylePriority.UseFont = False
        Me.XrLabel73.StylePriority.UseTextAlignment = False
        Me.XrLabel73.Text = "Đơn vị %"
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel72
        '
        Me.XrLabel72.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel72.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7103.113!)
        Me.XrLabel72.Multiline = True
        Me.XrLabel72.Name = "XrLabel72"
        Me.XrLabel72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel72.SizeF = New System.Drawing.SizeF(732.4998!, 27.1665!)
        Me.XrLabel72.StylePriority.UseFont = False
        Me.XrLabel72.StylePriority.UseTextAlignment = False
        Me.XrLabel72.Text = "Hình 10. Tỷ lệ thất nghiệp phân theo nhóm tuổi"
        Me.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel71
        '
        Me.XrLabel71.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel71.LocationFloat = New DevExpress.Utils.PointFloat(0!, 6907.113!)
        Me.XrLabel71.Multiline = True
        Me.XrLabel71.Name = "XrLabel71"
        Me.XrLabel71.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel71.SizeF = New System.Drawing.SizeF(732.4998!, 184.541!)
        Me.XrLabel71.StylePriority.UseFont = False
        Me.XrLabel71.StylePriority.UseTextAlignment = False
        Me.XrLabel71.Text = resources.GetString("XrLabel71.Text")
        Me.XrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel70
        '
        Me.XrLabel70.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(0!, 6879.947!)
        Me.XrLabel70.Multiline = True
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(732.4999!, 27.1665!)
        Me.XrLabel70.StylePriority.UseFont = False
        Me.XrLabel70.StylePriority.UseTextAlignment = False
        Me.XrLabel70.Text = "2.1. Xét theo nhóm tuổi "
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel69
        '
        Me.XrLabel69.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel69.LocationFloat = New DevExpress.Utils.PointFloat(0!, 6852.78!)
        Me.XrLabel69.Multiline = True
        Me.XrLabel69.Name = "XrLabel69"
        Me.XrLabel69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel69.SizeF = New System.Drawing.SizeF(732.4999!, 27.1665!)
        Me.XrLabel69.StylePriority.UseFont = False
        Me.XrLabel69.StylePriority.UseTextAlignment = False
        Me.XrLabel69.Text = "2. Một số đặc điểm của lao động thất nghiệp."
        Me.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel68
        '
        Me.XrLabel68.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel68.LocationFloat = New DevExpress.Utils.PointFloat(0!, 6827.697!)
        Me.XrLabel68.Multiline = True
        Me.XrLabel68.Name = "XrLabel68"
        Me.XrLabel68.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel68.SizeF = New System.Drawing.SizeF(732.5!, 25.0835!)
        Me.XrLabel68.StylePriority.UseFont = False
        Me.XrLabel68.StylePriority.UseTextAlignment = False
        Me.XrLabel68.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(4.00006!, 6552.697!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow5, Me.XrTableRow6, Me.XrTableRow7, Me.XrTableRow8, Me.XrTableRow9, Me.XrTableRow10, Me.XrTableRow11, Me.XrTableRow12, Me.XrTableRow13})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(730.1664!, 250.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRow1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBackColor = False
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "STT"
        Me.XrTableCell1.Weight = 0.18930131073510736R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Chỉ tiêu"
        Me.XrTableCell2.Weight = 1.3773838938432941R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "ĐVT"
        Me.XrTableCell3.Weight = 0.35958944737291476R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "[dtMaster.KyBCTruoc]"
        Me.XrTableCell4.Weight = 0.5701222698296583R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "[dtMaster.KyBC]"
        Me.XrTableCell5.Weight = 0.5036030782190255R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell31})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Multiline = True
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Text = "1"
        Me.XrTableCell27.Weight = 0.18930131073510736R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Multiline = True
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.Text = "Số nộp hồ sơ hưởng TCTN"
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell28.Weight = 1.3773838938432941R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell29.Multiline = True
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.Text = "Người"
        Me.XrTableCell29.Weight = 0.35958944737291476R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Multiline = True
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Text = "0"
        Me.XrTableCell30.Weight = 0.5701222698296583R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Multiline = True
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Text = "0"
        Me.XrTableCell31.Weight = 0.5036030782190255R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell32, Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell36})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Multiline = True
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Text = "2"
        Me.XrTableCell32.Weight = 0.18930131073510736R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Multiline = True
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        Me.XrTableCell33.Text = "Số người có quyết định hưởng trợ cấp thất nghiệp"
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell33.Weight = 1.3773838938432941R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell34.Multiline = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.Text = "Người"
        Me.XrTableCell34.Weight = 0.35958944737291476R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Multiline = True
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Text = "0"
        Me.XrTableCell35.Weight = 0.5701222698296583R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Multiline = True
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Text = "0"
        Me.XrTableCell36.Weight = 0.5036030782190255R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Multiline = True
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Text = "3"
        Me.XrTableCell37.Weight = 0.18930131073510736R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Multiline = True
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        Me.XrTableCell38.Text = "Số người được chi trả TCTN"
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell38.Weight = 1.3773838938432941R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell39.Multiline = True
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.Text = "Người"
        Me.XrTableCell39.Weight = 0.35958944737291476R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Multiline = True
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Text = "0"
        Me.XrTableCell40.Weight = 0.5701222698296583R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Multiline = True
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.Text = "0"
        Me.XrTableCell41.Weight = 0.5036030782190255R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell42, Me.XrTableCell43, Me.XrTableCell44, Me.XrTableCell45, Me.XrTableCell46})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.Multiline = True
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.Text = "4"
        Me.XrTableCell42.Weight = 0.18930131073510736R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.Multiline = True
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseTextAlignment = False
        Me.XrTableCell43.Text = "Số người tạm dừng TCTN"
        Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell43.Weight = 1.3773838938432941R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell44.Multiline = True
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StylePriority.UseFont = False
        Me.XrTableCell44.Text = "Người"
        Me.XrTableCell44.Weight = 0.35958944737291476R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.Multiline = True
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.Text = "0"
        Me.XrTableCell45.Weight = 0.5701222698296583R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.Multiline = True
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.Text = "0"
        Me.XrTableCell46.Weight = 0.5036030782190255R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell47, Me.XrTableCell48, Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell51})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.Multiline = True
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.Text = "5"
        Me.XrTableCell47.Weight = 0.18930131073510736R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.Multiline = True
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.StylePriority.UseTextAlignment = False
        Me.XrTableCell48.Text = "Số người tiếp tục hưởng TCTN"
        Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell48.Weight = 1.3773838938432941R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell49.Multiline = True
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StylePriority.UseFont = False
        Me.XrTableCell49.Text = "Người"
        Me.XrTableCell49.Weight = 0.35958944737291476R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.Multiline = True
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.Text = "0"
        Me.XrTableCell50.Weight = 0.5701222698296583R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.Multiline = True
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.Text = "0"
        Me.XrTableCell51.Weight = 0.5036030782190255R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell52, Me.XrTableCell53, Me.XrTableCell54, Me.XrTableCell55, Me.XrTableCell56})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.Multiline = True
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.Text = "6"
        Me.XrTableCell52.Weight = 0.18930131073510736R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.Multiline = True
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.StylePriority.UseTextAlignment = False
        Me.XrTableCell53.Text = "Số quyết định bị hủy hưởng TCTN"
        Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell53.Weight = 1.3773838938432941R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell54.Multiline = True
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.StylePriority.UseFont = False
        Me.XrTableCell54.Text = "QĐ"
        Me.XrTableCell54.Weight = 0.35958944737291476R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.Multiline = True
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.Text = "0"
        Me.XrTableCell55.Weight = 0.5701222698296583R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.Multiline = True
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.Text = "0"
        Me.XrTableCell56.Weight = 0.5036030782190255R
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell57, Me.XrTableCell58, Me.XrTableCell59, Me.XrTableCell60, Me.XrTableCell61})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 1.0R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.Multiline = True
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.Text = "7"
        Me.XrTableCell57.Weight = 0.18930131073510736R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.Multiline = True
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.StylePriority.UseTextAlignment = False
        Me.XrTableCell58.Text = "Số người được hỗ trợ học nghề"
        Me.XrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell58.Weight = 1.3773838938432941R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell59.Multiline = True
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.StylePriority.UseFont = False
        Me.XrTableCell59.Text = "Người"
        Me.XrTableCell59.Weight = 0.35958944737291476R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.Multiline = True
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.Text = "0"
        Me.XrTableCell60.Weight = 0.5701222698296583R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.Multiline = True
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.Text = "0"
        Me.XrTableCell61.Weight = 0.5036030782190255R
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell62, Me.XrTableCell63, Me.XrTableCell64, Me.XrTableCell65, Me.XrTableCell66})
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Weight = 1.0R
        '
        'XrTableCell62
        '
        Me.XrTableCell62.Multiline = True
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.Text = "8"
        Me.XrTableCell62.Weight = 0.18930131073510736R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.Multiline = True
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.StylePriority.UseTextAlignment = False
        Me.XrTableCell63.Text = "Số người hưởng TCTN được tư vấn giới thiệu việc làm"
        Me.XrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell63.Weight = 1.3773838938432941R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell64.Multiline = True
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.StylePriority.UseFont = False
        Me.XrTableCell64.Text = "Lượt người"
        Me.XrTableCell64.Weight = 0.35958944737291476R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.Multiline = True
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.Text = "0"
        Me.XrTableCell65.Weight = 0.5701222698296583R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.Multiline = True
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.Text = "0"
        Me.XrTableCell66.Weight = 0.5036030782190255R
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell67, Me.XrTableCell68, Me.XrTableCell69, Me.XrTableCell70, Me.XrTableCell71})
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Weight = 1.0R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.Multiline = True
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.Text = "9"
        Me.XrTableCell67.Weight = 0.18930131073510736R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.Multiline = True
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.StylePriority.UseTextAlignment = False
        Me.XrTableCell68.Text = "Số người nhận được việc làm khi đang hưởng TCTN"
        Me.XrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell68.Weight = 1.3773838938432941R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Italic)
        Me.XrTableCell69.Multiline = True
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.StylePriority.UseFont = False
        Me.XrTableCell69.Text = "Người"
        Me.XrTableCell69.Weight = 0.35958944737291476R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.Multiline = True
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.Text = "0"
        Me.XrTableCell70.Weight = 0.5701222698296583R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.Multiline = True
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.Text = "0"
        Me.XrTableCell71.Weight = 0.5036030782190255R
        '
        'XrLabel67
        '
        Me.XrLabel67.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(1.666542!, 6525.531!)
        Me.XrLabel67.Multiline = True
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(732.4999!, 27.1665!)
        Me.XrLabel67.StylePriority.UseFont = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "Bảng 1: Kết quả thực hiện chính sách Bảo hiểm thất nghiệp"
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel66
        '
        Me.XrLabel66.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(3.999995!, 6432.447!)
        Me.XrLabel66.Multiline = True
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(730.9995!, 93.0835!)
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = resources.GetString("XrLabel66.Text")
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel65
        '
        Me.XrLabel65.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(4.00006!, 6405.28!)
        Me.XrLabel65.Multiline = True
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(730.9995!, 27.16699!)
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.Text = "1. Kết quả thực hiện chính sách Bảo hiểm thất nghiệp"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel64
        '
        Me.XrLabel64.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(3.999995!, 6378.114!)
        Me.XrLabel64.Multiline = True
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(730.9995!, 27.1665!)
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.StylePriority.UseTextAlignment = False
        Me.XrLabel64.Text = "III. Thực trạng lao động thất nghiệp"
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel63
        '
        Me.XrLabel63.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(3.999995!, 6104.822!)
        Me.XrLabel63.Multiline = True
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(730.9999!, 273.2915!)
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        Me.XrLabel63.Text = resources.GetString("XrLabel63.Text")
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel62
        '
        Me.XrLabel62.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(3.999995!, 6079.739!)
        Me.XrLabel62.Multiline = True
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(731.0001!, 25.0835!)
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.Text = "Đánh giá thực trạng"
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrChart10
        '
        Me.XrChart10.BorderColor = System.Drawing.Color.Black
        Me.XrChart10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart10.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart10.Legend.Name = "Default Legend"
        Me.XrChart10.LocationFloat = New DevExpress.Utils.PointFloat(372.4478!, 5618.3!)
        Me.XrChart10.Name = "XrChart10"
        Me.XrChart10.PaletteName = "Palette 1"
        Me.XrChart10.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart10.SeriesDataMember = "dtChart2_3.CYear"
        Me.XrChart10.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart10.SeriesTemplate.ArgumentDataMember = "dtChart2_3.CName"
        Me.XrChart10.SeriesTemplate.SeriesDataMember = "dtChart2_3.CYear"
        Me.XrChart10.SeriesTemplate.ValueDataMembersSerializable = "dtChart2_3.CValue"
        Me.XrChart10.SeriesTemplate.View = RadarLineSeriesView1
        Me.XrChart10.SizeF = New System.Drawing.SizeF(355.5938!, 436.3545!)
        ChartTitle1.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        ChartTitle1.Text = "Nhu cầu tìm việc"
        ChartTitle1.WordWrap = True
        Me.XrChart10.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'XrLabel61
        '
        Me.XrLabel61.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(3.999995!, 6054.655!)
        Me.XrLabel61.Multiline = True
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(731.0001!, 25.0835!)
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel59
        '
        Me.XrLabel59.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(1.666493!, 5547.3!)
        Me.XrLabel59.Multiline = True
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(729.3334!, 45.9165!)
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = "Hình 9. Năm kỹ năng mềm của người tìm việc và yêu cầu kỹ năng mềm của doanh nghiệ" &
    "p đối với Người lao động."
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel60
        '
        Me.XrLabel60.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(633.7223!, 5593.216!)
        Me.XrLabel60.Multiline = True
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(97.27734!, 25.0835!)
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "Đơn vị %"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart9
        '
        Me.XrChart9.BorderColor = System.Drawing.Color.Black
        Me.XrChart9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart9.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart9.Legend.Name = "Default Legend"
        Me.XrChart9.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 5618.3!)
        Me.XrChart9.Name = "XrChart9"
        Me.XrChart9.PaletteName = "Palette 1"
        Me.XrChart9.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart9.SeriesDataMember = "dtChart3_3.CYear"
        Me.XrChart9.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart9.SeriesTemplate.ArgumentDataMember = "dtChart3_3.CName"
        Me.XrChart9.SeriesTemplate.SeriesDataMember = "dtChart3_3.CYear"
        Me.XrChart9.SeriesTemplate.ValueDataMembersSerializable = "dtChart3_3.CValue"
        Me.XrChart9.SeriesTemplate.View = RadarLineSeriesView2
        Me.XrChart9.SizeF = New System.Drawing.SizeF(362.4479!, 436.355!)
        ChartTitle2.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        ChartTitle2.Text = "Nhu cầu tuyển dụng"
        ChartTitle2.WordWrap = True
        Me.XrChart9.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'XrLabel58
        '
        Me.XrLabel58.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(3.999995!, 5522.216!)
        Me.XrLabel58.Multiline = True
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(727.0!, 25.0835!)
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.Text = "Xét theo kỹ năng mềm"
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel57
        '
        Me.XrLabel57.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(0.8333365!, 5108.3!)
        Me.XrLabel57.Multiline = True
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(730.1666!, 413.9165!)
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = resources.GetString("XrLabel57.Text")
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel56
        '
        Me.XrLabel56.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(0.8333401!, 5083.217!)
        Me.XrLabel56.Multiline = True
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(730.1666!, 25.0835!)
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel55
        '
        Me.XrLabel55.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 4416.284!)
        Me.XrLabel55.Multiline = True
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(729.3333!, 25.0835!)
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel53
        '
        Me.XrLabel53.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(0.8333365!, 4704.41!)
        Me.XrLabel53.Multiline = True
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(733.3331!, 48.0!)
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "Hình 8. Mười nhóm ngành/ nghề người tìm việc và doanh nghiệp tuyển dụng nhiều nhấ" &
    "t."
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel54
        '
        Me.XrLabel54.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(632.222!, 4752.41!)
        Me.XrLabel54.Multiline = True
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(102.7776!, 25.0835!)
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "Đơn vị %"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart8
        '
        Me.XrChart8.BorderColor = System.Drawing.Color.Black
        Me.XrChart8.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram3.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram3.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram3.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram3.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart8.Diagram = XyDiagram3
        Me.XrChart8.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart8.Legend.Name = "Default Legend"
        Me.XrChart8.LocationFloat = New DevExpress.Utils.PointFloat(36.91675!, 4777.493!)
        Me.XrChart8.Name = "XrChart8"
        Me.XrChart8.PaletteName = "Palette 1"
        Me.XrChart8.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart8.SeriesDataMember = "dtChart3A.CYear"
        Me.XrChart8.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart8.SeriesTemplate.ArgumentDataMember = "dtChart3A.CName"
        Me.XrChart8.SeriesTemplate.SeriesDataMember = "dtChart3A.CYear"
        Me.XrChart8.SeriesTemplate.ValueDataMembersSerializable = "dtChart3A.CValue"
        Me.XrChart8.SizeF = New System.Drawing.SizeF(673.9583!, 305.7236!)
        ChartTitle3.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        ChartTitle3.Text = "Mười ngành nghề có nhu cầu tìm việc nhiều nhất ứng với mười ngành nghề có nhu cầu" &
    " tuyển dụng"
        ChartTitle3.WordWrap = True
        Me.XrChart8.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'XrLabel52
        '
        Me.XrLabel52.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(0.8333401!, 4491.535!)
        Me.XrLabel52.Multiline = True
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(733.3331!, 212.875!)
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = resources.GetString("XrLabel52.Text")
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel51
        '
        Me.XrLabel51.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(0.8333075!, 4466.451!)
        Me.XrLabel51.Multiline = True
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(733.3331!, 25.0835!)
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.Text = "Xét theo ngành/nghề tuyển dụng nhiều nhất."
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel50
        '
        Me.XrLabel50.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(0.8333401!, 4441.368!)
        Me.XrLabel50.Multiline = True
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(733.3331!, 25.0835!)
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "3. Kết nối cung- cầu"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel49
        '
        Me.XrLabel49.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 3870.841!)
        Me.XrLabel49.Multiline = True
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(731.0001!, 25.08325!)
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel48
        '
        Me.XrLabel48.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(631.3887!, 4085.477!)
        Me.XrLabel48.Multiline = True
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(103.6109!, 25.0835!)
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "Đơn vị %"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart7
        '
        Me.XrChart7.BorderColor = System.Drawing.Color.Black
        Me.XrChart7.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram4.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram4.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram4.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram4.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram4.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart7.Diagram = XyDiagram4
        Me.XrChart7.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart7.Legend.Name = "Default Legend"
        Me.XrChart7.LocationFloat = New DevExpress.Utils.PointFloat(36.91675!, 4110.561!)
        Me.XrChart7.Name = "XrChart7"
        Me.XrChart7.PaletteName = "Palette 1"
        Me.XrChart7.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart7.SeriesDataMember = "dtChart2_3.CYear"
        Me.XrChart7.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart7.SeriesTemplate.ArgumentDataMember = "dtChart2_3.CName"
        Me.XrChart7.SeriesTemplate.SeriesDataMember = "dtChart2_3.CYear"
        Me.XrChart7.SeriesTemplate.ValueDataMembersSerializable = "dtChart2_3.CValue"
        Me.XrChart7.SizeF = New System.Drawing.SizeF(673.9583!, 305.7236!)
        '
        'XrLabel47
        '
        Me.XrLabel47.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(0.0001385681!, 4060.394!)
        Me.XrLabel47.Multiline = True
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(734.1663!, 25.0835!)
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = "Hình 7. Kỹ năng mềm chủ yếu của người lao động có trình độ Đại học."
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel46
        '
        Me.XrLabel46.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(2.333681!, 3921.007!)
        Me.XrLabel46.Multiline = True
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(730.9997!, 125.8445!)
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = resources.GetString("XrLabel46.Text")
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel45
        '
        Me.XrLabel45.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(0.8333401!, 3895.924!)
        Me.XrLabel45.Multiline = True
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(734.1663!, 25.0835!)
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "Kỹ năng mềm"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(0!, 3531.617!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(731.0!, 25.08325!)
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "Hình 6: Mức lương mong muốn của người lao động có trình độ Đại học "
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrChart6
        '
        Me.XrChart6.BorderColor = System.Drawing.Color.Black
        Me.XrChart6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart6.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart6.Legend.Name = "Default Legend"
        Me.XrChart6.LocationFloat = New DevExpress.Utils.PointFloat(32.91637!, 3581.783!)
        Me.XrChart6.Name = "XrChart6"
        Me.XrChart6.PaletteName = "Palette 1"
        Me.XrChart6.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart6.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart6.SizeF = New System.Drawing.SizeF(677.9587!, 289.0571!)
        '
        'XrLabel44
        '
        Me.XrLabel44.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(634.5555!, 3556.7!)
        Me.XrLabel44.Multiline = True
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(100.4446!, 25.08325!)
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "Đơn vị %"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart5
        '
        Me.XrChart5.BorderColor = System.Drawing.Color.Black
        Me.XrChart5.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram5.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram5.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram5.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram5.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram5.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram5.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart5.Diagram = XyDiagram5
        Me.XrChart5.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart5.Legend.Name = "Default Legend"
        Me.XrChart5.LocationFloat = New DevExpress.Utils.PointFloat(36.91675!, 3214.352!)
        Me.XrChart5.Name = "XrChart5"
        Me.XrChart5.PaletteName = "Palette 1"
        Me.XrChart5.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart5.SeriesDataMember = "dtChart2_2.CYear"
        Me.XrChart5.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart5.SeriesTemplate.ArgumentDataMember = "dtChart2_2.CName"
        Me.XrChart5.SeriesTemplate.SeriesDataMember = "dtChart2_2.CYear"
        Me.XrChart5.SeriesTemplate.ValueDataMembersSerializable = "dtChart2_2.CValue"
        Me.XrChart5.SizeF = New System.Drawing.SizeF(673.9583!, 292.1819!)
        '
        'XrLabel41
        '
        Me.XrLabel41.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(3.999995!, 3506.533!)
        Me.XrLabel41.Multiline = True
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(731.0001!, 25.0835!)
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel40
        '
        Me.XrLabel40.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(630.5558!, 3189.268!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(104.4442!, 25.08325!)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Đơn vị %"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(0!, 3164.185!)
        Me.XrLabel39.Multiline = True
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(734.9996!, 25.08325!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Hình 5: Mức lương mong muốn của người lao động "
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel37
        '
        Me.XrLabel37.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2951.227!)
        Me.XrLabel37.Multiline = True
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(734.9996!, 25.08325!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "Xét theo mức lương mong muốn"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel38
        '
        Me.XrLabel38.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2976.31!)
        Me.XrLabel38.Multiline = True
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(734.9996!, 187.8748!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = resources.GetString("XrLabel38.Text")
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel36
        '
        Me.XrLabel36.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(630.5555!, 2595.337!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(100.4442!, 25.08325!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "Đơn vị %"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart4
        '
        Me.XrChart4.BorderColor = System.Drawing.Color.Black
        Me.XrChart4.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram6.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram6.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram6.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram6.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram6.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram6.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart4.Diagram = XyDiagram6
        Me.XrChart4.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart4.Legend.Name = "Default Legend"
        Me.XrChart4.LocationFloat = New DevExpress.Utils.PointFloat(36.91675!, 2620.42!)
        Me.XrChart4.Name = "XrChart4"
        Me.XrChart4.PaletteName = "Palette 1"
        Me.XrChart4.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart4.SeriesDataMember = "dtChart2_1.CYear"
        Me.XrChart4.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart4.SeriesTemplate.ArgumentDataMember = "dtChart2_1.CName"
        Me.XrChart4.SeriesTemplate.SeriesDataMember = "dtChart2_1.CYear"
        Me.XrChart4.SeriesTemplate.ValueDataMembersSerializable = "dtChart2_1.CValue"
        Me.XrChart4.SizeF = New System.Drawing.SizeF(673.9583!, 305.7236!)
        '
        'XrLabel35
        '
        Me.XrLabel35.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 2376.92!)
        Me.XrLabel35.Multiline = True
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(727.8331!, 25.08325!)
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel34
        '
        Me.XrLabel34.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(627.5975!, 2046.114!)
        Me.XrLabel34.Multiline = True
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(100.4442!, 25.08325!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "Đơn vị %"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel33
        '
        Me.XrLabel33.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(630.5556!, 1458.349!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(104.4442!, 25.0835!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Đơn vị %"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart3
        '
        Me.XrChart3.BorderColor = System.Drawing.Color.Black
        Me.XrChart3.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram7.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram7.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram7.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram7.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram7.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram7.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart3.Diagram = XyDiagram7
        Me.XrChart3.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart3.Legend.Name = "Default Legend"
        Me.XrChart3.LocationFloat = New DevExpress.Utils.PointFloat(36.91675!, 2071.197!)
        Me.XrChart3.Name = "XrChart3"
        Me.XrChart3.PaletteName = "Palette 1"
        Me.XrChart3.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart3.SeriesDataMember = "dtChart1_3.CYear"
        Me.XrChart3.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart3.SeriesTemplate.ArgumentDataMember = "dtChart1_3.CName"
        Me.XrChart3.SeriesTemplate.SeriesDataMember = "dtChart1_3.CYear"
        Me.XrChart3.SeriesTemplate.ValueDataMembersSerializable = "dtChart1_3.CValue"
        Me.XrChart3.SizeF = New System.Drawing.SizeF(673.9583!, 305.7236!)
        '
        'XrChart2
        '
        Me.XrChart2.BorderColor = System.Drawing.Color.Black
        Me.XrChart2.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram8.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram8.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram8.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram8.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram8.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram8.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart2.Diagram = XyDiagram8
        Me.XrChart2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.XrChart2.Legend.Name = "Default Legend"
        Me.XrChart2.LocationFloat = New DevExpress.Utils.PointFloat(36.91675!, 1483.432!)
        Me.XrChart2.Name = "XrChart2"
        Me.XrChart2.PaletteName = "Palette 1"
        Me.XrChart2.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart2.SeriesDataMember = "dtChart1_2.CYear"
        Me.XrChart2.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart2.SeriesTemplate.ArgumentDataMember = "dtChart1_2.CName"
        Me.XrChart2.SeriesTemplate.SeriesDataMember = "dtChart1_2.CYear"
        Me.XrChart2.SeriesTemplate.ValueDataMembersSerializable = "dtChart1_2.CValue"
        Me.XrChart2.SizeF = New System.Drawing.SizeF(673.9583!, 305.7236!)
        '
        'XrLabel32
        '
        Me.XrLabel32.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(620.5556!, 765.0834!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(104.4446!, 25.08337!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Đơn vị %"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2926.144!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(734.9996!, 25.0835!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(0.00002445319!, 2570.254!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(730.9996!, 25.08325!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Hình 4: Người lao động tìm việc với số năm kinh nghiệm"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2452.17!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(730.9996!, 118.0833!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = resources.GetString("XrLabel29.Text")
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(0.00004075531!, 2427.087!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(730.9996!, 25.08325!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "Xét theo số năm kinh nghiệm"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2402.004!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(730.9996!, 25.0835!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "2. Nhu cầu tìm việc làm"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1789.156!)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(730.9996!, 25.08325!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram9.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram9.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram9.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram9.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram9.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram9.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart1.Diagram = XyDiagram9
        Me.XrChart1.Legend.Name = "Default Legend"
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(36.91675!, 790.1667!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.PaletteName = "Palette 1"
        Me.XrChart1.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer)))}))
        Me.XrChart1.SeriesDataMember = "dtChart1_1.CYear"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart1.SeriesTemplate.ArgumentDataMember = "dtChart1_1.CName"
        Me.XrChart1.SeriesTemplate.SeriesDataMember = "dtChart1_1.CYear"
        Me.XrChart1.SeriesTemplate.ValueDataMembersSerializable = "dtChart1_1.CValue"
        Me.XrChart1.SizeF = New System.Drawing.SizeF(673.9583!, 305.7236!)
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2021.03!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(730.9996!, 25.08325!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "   Hình 3: Nhu cầu tuyển dụng phân theo số năm kinh nghiệm "
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(4.000092!, 1839.322!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(730.9995!, 142.1246!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = resources.GetString("XrLabel24.Text")
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(3.999979!, 1814.239!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(730.9996!, 25.08337!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Xét theo số năm kinh nghiệm"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.00002445319!, 620.1251!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(735.0001!, 25.08331!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Xét theo vị trí"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(734.9999!, 25.08334!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "I. TÌNH HÌNH CHUNG TRONG NĂM [dtMaster.KyBC]"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0!, 126.2084!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(738.8337!, 25.08333!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "II. PHÂN TÍCH TÌNH HÌNH THỊ TRƯỜNG LAO ĐỘNG"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 645.2084!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(735.0001!, 94.79175!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = resources.GetString("XrLabel16.Text")
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 740.0001!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(735.0001!, 25.08331!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "    Hình 1. Cơ cấu nhu cầu tuyển dụng phân theo chức vụ"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0!, 151.2917!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(738.8337!, 25.08331!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "1. Nhu cầu tuyển dụng lao động của doanh nghiệp"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(3.999979!, 1095.89!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(730.9997!, 25.08337!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Nguồn: Trung tâm DVVL [dtMaster.TinhTP], Số liệu cập nhật năm [dtMaster.KyBC]"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1120.973!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(734.9998!, 25.08337!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Xét theo trình độ Chuyên môn kỹ thuật"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1146.057!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(734.9999!, 162.875!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = resources.GetString("XrLabel20.Text")
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1308.932!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(734.9999!, 124.3333!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = resources.GetString("XrLabel21.Text")
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel22
        '
        Me.XrLabel22.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1433.265!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(734.9997!, 25.08337!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "   Hình 2: Cơ cấu nhu cầu tuyển dụng phân theo trình độ CMKT"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(307.2917!, 25.08334!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "SỞ LAO ĐỘNG – TB VÀ XH [dtMaster.TinhTP]"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 24.54166!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(307.2916!, 25.08334!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "TRUNG TÂM DỊCH VỤ VIỆC LÀM"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(394.375!, 0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(340.625!, 25.08334!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(417.7084!, 24.54166!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(307.2916!, 25.08334!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Độc lập - Tự do - Hạnh phúc"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 64.375!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(307.2916!, 25.08334!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Số:       /BC-TTDVVL"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(384.1046!, 64.37502!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(350.8955!, 25.08334!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "[dtMaster.TinhTP], ngày [dtMaster.Ngay] tháng  [dtMaster.Thang]  năm [dtMaster.Na" &
    "m]"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(88.45837!, 41.37497!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(100.0!, 8.250015!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(477.7917!, 41.37497!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(192.7083!, 8.250015!)
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(201.2917!, 108.9167!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(307.2916!, 25.08334!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "BÁO CÁO"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0.00001589457!, 134.0!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(735.0!, 74.04169!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Phân tích thị trường lao động năm [dtMaster.KyBC] " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "và dự báo tình hình Cung - Cầ" &
    "u lao động năm 2024 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "trên địa bàn tỉnh [dtMaster.TinhTP]"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel7, Me.XrLine2, Me.XrLine1, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel1, Me.XrLabel2})
        Me.ReportHeader.HeightF = 233.2916!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'DsReport1
        '
        Me.DsReport1.DataSetName = "dsReport"
        Me.DsReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(124.5834!, 201.4583!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(614.2502!, 49.04163!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Nhu cầu tuyển dụng lao động theo nhóm ngành kinh tế trong năm 2023 và dự kiến tuy" &
    "ển thêm trong năm 2024:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel42
        '
        Me.XrLabel42.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(598.2086!, 250.4999!)
        Me.XrLabel42.Multiline = True
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(140.6251!, 27.16663!)
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "ĐVT: Người"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BCPhanTichTTLD
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DsReport1})
        Me.DataSource = Me.DsReport1
        Me.DataSourceSchema = Nothing
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(39, 44, 37, 55)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "19.1"
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub XrLabel1_EvaluateBinding(sender As Object, e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrLabel1.EvaluateBinding
        e.Value = e.Value.ToUpper()
    End Sub

    Private Sub BCPhanTichTTLD_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint

    End Sub

    Private Sub XrLabel1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrLabel1.BeforePrint
        CType(sender, XRLabel).Text = CType(sender, XRLabel).Text.ToUpper()
    End Sub

#End Region

End Class