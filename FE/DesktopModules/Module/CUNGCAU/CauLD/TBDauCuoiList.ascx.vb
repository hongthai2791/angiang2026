Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU
Imports OfficeOpenXml

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New CauController()
        Dim arrTemp As New ArrayList
        Dim obj As New BC_TBCuoiKyInfo
        Dim str(), sColor As String
        Dim _dem As Integer = 0
        Private Sub InitControls()
            ThongBaoID.Value = Request.Item("itemid")
            DoanhNghiepID.Value = Request.Item("bus")
        End Sub
        Private Sub LoadValues()
            arrTemp = objController.BC_TBCuoiKy_Get_By_BC_ThongBao(Me.PortalId, ThongBaoID.Value)
            litRow.Text = "" : sColor = "dddddd"
            For Each Cr As BC_TBCuoiKyInfo In arrTemp
                litRow.Text += "<tr style='background-color: #" & sColor & "'>"
                litRow.Text += "<td>" & Cr.ThoiDiem & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.TongSoLD & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.TongSoNu & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.CNKT & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.CCN & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.SoCap & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.TrungCap & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.CaoDang & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.DaiHoc & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.HD_0T & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.HD_36T & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.HD_12T & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.HD_3T & "</td>"
                litRow.Text += "<td style='text-align: center'>" & Cr.BHTN & "</td>"
                litRow.Text += "</tr>"
                If sColor = "dddddd" Then
                    sColor = "ffffff"
                Else
                    sColor = "dddddd"
                End If
                _dem += 1
                TrangThai.Value = Cr.TrangThai
            Next
            If TrangThai.Value = "1" Then
                cmdNew.Visible = False
                cmdImport.Visible = False
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Private Sub BackEnd()
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/tb-them/bus/" & Request.Item("bus") & "/itemid/" & Request.Item("itemid"), True)
        End Sub
        Private Function textBoolean(val As Boolean) As String
            If val = True Then
                Return "x"
            Else
                Return "&nbsp;"
            End If
        End Function
        Private Function getBoolean(val As String) As Boolean
            Try
                If IsNothing(val) = False Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function
        Private Function getDateTime(val As String) As DateTime
            Try
                If val = "" Then
                    Return flReg.DateNull
                Else
                    str = val.Split("/")
                    Return New Date(str(2), str(1), str(0))
                End If
            Catch ex As Exception
                Return flReg.DateNull
            End Try
        End Function
        Private Function getDouble(val As String) As Double
            Try
                Return CType(val, Double)
            Catch ex As Exception
                Return 0
            End Try
        End Function
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click
            Try
                For i As Integer = 0 To Request.Files.Count - 1
                    pathTemp.Value = Server.MapPath("\DATA\" & Me.PortalId & "\TEMPS") & "\" & flReg.GenKey() & "." & flReg.GetFileType(Request.Files(i).FileName, ".")
                    Request.Files(i).SaveAs(pathTemp.Value)
                    Exit For
                Next
                Dim exCel As ExcelPackage = New ExcelPackage(OpenFile(pathTemp.Value))
                Dim worksheet As ExcelWorksheet = exCel.Workbook.Worksheets.First()
                If worksheet.Cells("B13").Value & "" = "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', 'File excel không có dữ liệu, vui lòng kiểm tra lại', 'Thông báo', false);", True)
                    Exit Sub
                Else
                    _dem = 0
                    objController.BC_TBCuoiKy_Delete_By_BC_ThongBao(Me.PortalId, ThongBaoID.Value)
                    For i = 13 To 1048576
                        If worksheet.Cells("B" & i).Value & "" = "" Then Exit For
                        Try
                            obj = New BC_TBCuoiKyInfo
                            obj.TBCuoiKy_ID = flReg.GenKey()
                            obj.ThongBao_ID = ThongBaoID.Value
                            obj.DoanhNghiep_ID = DoanhNghiepID.Value
                            obj.NgayNop = flReg.DateNull
                            obj.IsOrder = _dem
                            obj.ThoiDiem = (worksheet.Cells("A" & i).Value & "").ToString.Trim()
                            obj.TongSoLD = getDouble(worksheet.Cells("B" & i).Value)
                            obj.TongSoNu = getDouble(worksheet.Cells("C" & i).Value)
                            obj.CNKT = getDouble(worksheet.Cells("D" & i).Value)
                            obj.CCN = getDouble(worksheet.Cells("E" & i).Value)
                            obj.SoCap = getDouble(worksheet.Cells("F" & i).Value)
                            obj.TrungCap = getDouble(worksheet.Cells("G" & i).Value)
                            obj.CaoDang = getDouble(worksheet.Cells("H" & i).Value)
                            obj.DaiHoc = getDouble(worksheet.Cells("I" & i).Value)
                            obj.HD_0T = getDouble(worksheet.Cells("J" & i).Value)
                            obj.HD_36T = getDouble(worksheet.Cells("K" & i).Value)
                            obj.HD_12T = getDouble(worksheet.Cells("L" & i).Value)
                            obj.HD_3T = getDouble(worksheet.Cells("M" & i).Value)
                            obj.BHTN = getDouble(worksheet.Cells("N" & i).Value)
                            obj.TrangThai = 0
                            obj.CreatedDate = Now
                            obj.CreatedUser = Me.UserInfo.Username
                            obj.UpdatedDate = Now
                            obj.UpdatedUser = Me.UserInfo.Username
                            obj.PortalId = Me.PortalId

                            objController.BC_TBCuoiKy_Add(Me.PortalId, obj)
                            _dem += 1
                        Catch ex As Exception
                            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', 'File excel lỗi dòng (" & i & "), không thể import' , 'Thông báo',false);", True)
                            Exit For
                        End Try
                    Next
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã import thành công " & _dem & " bản ghi' , 'Thông báo',false);", True)
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('error', 'File excel lỗi, không thể import' , 'Thông báo',false);", True)
            End Try
        End Sub

    End Class

End Namespace
