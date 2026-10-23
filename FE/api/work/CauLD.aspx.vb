Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU
Imports Aspose.Cells
Imports System.Threading

Partial Class Download
	Inherits System.Web.UI.Page
	Dim pathSave, pathOpen As String
	Dim tinhTP, cotDuocChon, idKey As String
	Dim workbook As New Workbook

	Dim r As IDataReader
	Dim cell As Cell, val As Object
	Dim nambc As Integer
	Dim arr As New ArrayList
	Dim objController As New CAUController()
	Private Sub SaveFileName(ByVal FilePath As String, ByVal FileName As String)
		Response.ContentType = "application/octet-stream"
		Response.AddHeader("Content-Disposition", "attachment; filename=" & FileName)
		Response.WriteFile(FilePath)
		Response.End()
	End Sub
	Private Sub ViewPDF(paths As String)
		If IO.File.Exists(Server.MapPath(paths)) = False Then
			lbMsg.Text = "<div style='text-align:center;padding-top:40px;font-size:16px;'>Không tìm thấy đường dẫn file trên máy chủ theo yêu cầu!</div>"
		Else
			Dim fileDateVersion As String = IO.File.GetLastWriteTime(Server.MapPath(paths)).ToString("dd-MM-yyyy-hh-mm-ss")
			lbMsg.Text = String.Format("<object data='{0}' type='application/pdf' width='100%' height='300px'></object>", paths & "?v=" & fileDateVersion)
		End If
	End Sub
	Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
		Try
			If Not Page.IsPostBack Then
				Dim di1 = New IO.DirectoryInfo(Server.MapPath("\data\0\tempexport"))
				If Not di1.Exists Then di1.Create()
				flReg.DeleteAllFiles("\data\0\tempexport")
				idKey = Request.Item("id") & ""
				nambc = flReg.WriteNumber(Request.Item("nam"))
				tinhTP = Request.Item("tinh")
				pathSave = "\data\0\tempexport\" & tinhTP & "-" & idKey & "-" & nambc & "-" & Now.Day & "-" & Now.Second & ".xls"  ' & Request.Item("key")

				Select Case idKey
					Case "DN01"
						Call DN01("LoaiHinhDN,TongSo,Duoi10Nguoi,Tu10Den50Nguoi,Tu51Den100Nguoi,Tu100NguoiTroLen", 8)
					Case "DN02"
						Call DN02("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10,cot11,cot12,cot13,cot14", 8)
					Case "DN03"
						Call DN03("cot2,cot3,cot4,cot5,cot6,cot7", 8)
					Case "DN04"
						Call DN04("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10,cot11,cot12,cot13,cot14", 8)
					Case "DN05"
						Call DN05("cot2,cot3,cot4,cot5,cot6", 8)
					Case "DN06"
						Call DN06("cot2,cot3,cot4,cot5,cot6,cot7", 8)
					Case "DN07"
						Call DN07("cot2,cot3,cot4,cot5,cot6,cot7", 8)
					Case "DN08"
						Call DN08("cot2,cot3,cot4,cot5,cot6,cot7,cot8", 8)
					Case "NLD01"
						Call NLD01("cot2,cot3,cot4,cot5,cot6,cot7,cot8", 8)
					Case "NLD02"
						Call NLD02("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10", 8)
					Case "NLD03"
						Call NLD03("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9", 8)
					Case "NLD04"
						Call NLD04("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9", 8)
					Case "NLD05"
						Call NLD05("cot2,cot3,cot4,cot5,cot6,cot7", 8)
					Case "NLD06"
						Call NLD06("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10", 8)
					Case "NLD07"
						Call NLD07("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9", 8)
					Case "NLD08"
						Call NLD08("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10,cot11", 8)
					Case "NLD09"
						Call NLD09("cot2,cot3,cot4,cot5,cot6,cot7", 8)
					Case "NLD10"
						Call NLD10("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10", 8)
					Case "NLD11"
						Call NLD11("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9", 8)
					Case "NLD12"
						Call NLD12("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10,cot11", 8)
					Case "NLD13"
						Call NLD13("cot2,cot3,cot4,cot5,cot6,cot7", 8)
					Case "NLD14"
						Call NLD14("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9", 8)
					Case "NLD15"
						Call NLD15("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10", 8)
					Case "NLD16"
						Call NLD16("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10,cot11", 8)
					Case "NLD17"
						Call NLD17("cot2,cot3,cot4,cot5,cot6,cot7", 8)
					Case "NLD18"
						Call NLD18("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10", 8)
					Case "NLD19"
						Call NLD19("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9", 8)
					Case "NLD20"
						Call NLD20("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10,cot11", 8)
					Case "NLD21"
						Call NLD21("cot2,cot3,cot4,cot5,cot6,cot7,cot8,cot9,cot10", 8)
					Case "NLD22"
						Call NLD22("cot2,cot3,cot4,cot5,cot6", 8)
					Case "TT271"
						Call TT271("TenXa,TongsoDN,SoLDTrucTiep,SoLDGianTiep,LDQuaDT,LDKyHD", 8)
				End Select

			End If
		Catch exc As Exception
			lbMsg.Text = exc.Message
		End Try
	End Sub
	Private Sub DN01(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\DN01.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_DN01A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub DN02(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\DN02.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_DN02A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub DN03(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\DN03.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_DN03A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub DN04(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\DN04.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_DN04A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub DN05(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\DN05.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_DN05A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub DN06(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\DN06.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_DN06A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub DN07(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\DN07.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_DN07A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub DN08(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\DN08.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_DN08A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD01(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD01.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD01A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD02(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD02.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD02A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD03(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD03.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD03A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
    End Sub
	Private Sub NLD04(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD04.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD04A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
    End Sub
	Private Sub NLD05(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD05.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD05A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD06(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD06.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD06A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD07(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD07.xls"))

		r = New CAU.SqlDataProvider().RPT_Run_NLD07A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD08(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD08.xls"))

		r = New CAU.SqlDataProvider().RPT_Run_NLD08A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD09(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD09.xls"))

		r = New CAU.SqlDataProvider().RPT_Run_NLD09A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD10(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD10.xls"))

		r = New CAU.SqlDataProvider().RPT_Run_NLD10A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD11(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD11.xls"))

		r = New CAU.SqlDataProvider().RPT_Run_NLD11A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD12(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD12.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD12A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD13(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD13.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD13A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
    Private Sub NLD14(cotDuocChon As String, xuatdong As Integer)
        workbook.Open(Server.MapPath("\data\template\cauld\NLD14.xls"))
        r = New CAU.SqlDataProvider().RPT_Run_NLD14A(0, tinhTP, nambc)
        Call ExData(cotDuocChon, xuatdong, r)
    End Sub
    Private Sub NLD15(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD15.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD15A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD16(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD16.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD16A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD17(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD17.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD17A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD18(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD18.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD18A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD19(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD19.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD19A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD20(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD20.xls"))
		r = New CAU.SqlDataProvider().RPT_Run_NLD20A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD21(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD21.xls"))

		r = New CAU.SqlDataProvider().RPT_Run_NLD21A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub NLD22(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\NLD22.xls"))

		r = New CAU.SqlDataProvider().RPT_Run_NLD22A(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub TT271(cotDuocChon As String, xuatdong As Integer)
		workbook.Open(Server.MapPath("\data\template\cauld\TT271.xls"))

		r = New CAU.SqlDataProvider().RPT_Run_TT271(0, tinhTP, nambc)
		Call ExData(cotDuocChon, xuatdong, r)
	End Sub
	Private Sub ExData(cotDuocChon As String, xuatdong As Integer, r As IDataReader)
		Dim worksheet As Worksheet = workbook.Worksheets.GetSheetByCodeName("Sheet1")
		Dim cacCot() = cotDuocChon.Split(",")
		Dim startRow As Integer = xuatdong
		Dim row As Integer = startRow, col As Integer = 1
		startRow = startRow - 1

		cell = worksheet.Cells(2, 0)
		cell.PutValue("Tỉnh: " & flDic.Regional_Name(0, tinhTP) & " - Năm: " & nambc)

		While r.Read
			cell = worksheet.Cells(row, 0)
			cell.PutValue(row - startRow)
			cell.Style.Borders(BorderType.BottomBorder).LineStyle = CellBorderType.Thin
			cell.Style.Borders(BorderType.TopBorder).LineStyle = CellBorderType.Thin
			cell.Style.Borders(BorderType.LeftBorder).LineStyle = CellBorderType.Thin
			cell.Style.Borders(BorderType.RightBorder).LineStyle = CellBorderType.Thin

			For Each tenCot In cacCot
				cell = worksheet.Cells(row, col)
				val = r(tenCot)
				If TypeOf val Is Date Then
					cell.PutValue(CType(val, DateTime).ToString("dd/MM/yyyy"))
				Else
					cell.PutValue(Convert.ChangeType(val, val.GetType()))
				End If
				cell.Style.Borders(BorderType.BottomBorder).LineStyle = CellBorderType.Thin
				cell.Style.Borders(BorderType.TopBorder).LineStyle = CellBorderType.Thin
				cell.Style.Borders(BorderType.LeftBorder).LineStyle = CellBorderType.Thin
				cell.Style.Borders(BorderType.RightBorder).LineStyle = CellBorderType.Thin
				col += 1
			Next
			col = 1
			row += 1
		End While
		r.Close()
		If Request.Item("key") = "pdf" Then
			workbook.Save(Server.MapPath(pathSave), FileFormatType.Pdf)
			Call ViewPDF(pathSave)
			'workbook.Save(Server.MapPath(pathSave), FileFormatType.Excel2003)
			'Response.Redirect("https://docs.google.com/gview?url=" & flReg.UrlAlias & pathSave)
		Else
			workbook.Save(Server.MapPath(pathSave), FileFormatType.Excel2003)
			Call SaveFileName(Server.MapPath(pathSave), idKey & "_" & tinhTP & "_NAM" & nambc & ".xls")
		End If
	End Sub
End Class



