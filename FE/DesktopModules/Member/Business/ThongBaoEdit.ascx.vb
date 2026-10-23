Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU
Imports OfficeOpenXml

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim objController As New CauController()
        Dim obj As New BC_ThongBaoInfo
        Dim busInfo As New BC_BusinessInfo
        Dim ndInfo, gndInfo As New BC_NoiDungInfo
        Dim liter As Literal, strURL As String
        Dim _dem As Integer = 0
        Dim str(), sColor, strError As String
        Private Sub LoadNoiDung()
            ndInfo = New BC_NoiDungInfo
            ndInfo.BaoCaoID = BaoCaoDinhKy.TBDauKy
            ndInfo.Links = "tb-lan-dau"
            ndInfo.TenBaoCao = "Mẫu 28 - Thông báo ban đầu về số lao động đang làm việc tại đơn vị"
            gndInfo = objController.BC_ThongBao_Get_TinhTrang(Me.PortalId, ItemID.Value, BaoCaoDinhKy.TBDauKy)
            If IsNothing(gndInfo) = False Then
                ndInfo.CreatedDate = gndInfo.CreatedDate
                ndInfo.UpdatedDate = gndInfo.UpdatedDate
                ndInfo.NgayNop = gndInfo.NgayNop
                Msg00.Text = ""

                strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & ndInfo.Links & "/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
                Msg00.Text = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"
            End If

            ndInfo = New BC_NoiDungInfo
            ndInfo.BaoCaoID = BaoCaoDinhKy.TBCuoiKy
            ndInfo.Links = "tb-dau-cuoi"
            ndInfo.TenBaoCao = "Mẫu 29 - I. Thông tin về số lao động đầu kỳ - cuối kỳ"
            gndInfo = objController.BC_ThongBao_Get_TinhTrang(Me.PortalId, ItemID.Value, BaoCaoDinhKy.TBCuoiKy)
            If IsNothing(gndInfo) = False Then
                ndInfo.CreatedDate = gndInfo.CreatedDate
                ndInfo.UpdatedDate = gndInfo.UpdatedDate
                ndInfo.NgayNop = gndInfo.NgayNop

                strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & ndInfo.Links & "/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
                Msg01.Text = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"

            End If

            ndInfo = New BC_NoiDungInfo
            ndInfo.BaoCaoID = BaoCaoDinhKy.LDGiam
            ndInfo.Links = "tb-ld-giam"
            ndInfo.TenBaoCao = "Mẫu 29 - II. Danh sách lao động giảm"
            gndInfo = objController.BC_ThongBao_Get_TinhTrang(Me.PortalId, ItemID.Value, BaoCaoDinhKy.LDGiam)
            If IsNothing(gndInfo) = False Then
                ndInfo.CreatedDate = gndInfo.CreatedDate
                ndInfo.UpdatedDate = gndInfo.UpdatedDate
                ndInfo.NgayNop = gndInfo.NgayNop

                strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & ndInfo.Links & "/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
                Msg02.Text = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"

            End If

            ndInfo = New BC_NoiDungInfo
            ndInfo.BaoCaoID = BaoCaoDinhKy.LDTang
            ndInfo.Links = "tb-ld-tang"
            ndInfo.TenBaoCao = "Mẫu 29 - III. Danh sách lao động tăng"
            gndInfo = objController.BC_ThongBao_Get_TinhTrang(Me.PortalId, ItemID.Value, BaoCaoDinhKy.LDTang)
            If IsNothing(gndInfo) = False Then
                ndInfo.CreatedDate = gndInfo.CreatedDate
                ndInfo.UpdatedDate = gndInfo.UpdatedDate
                ndInfo.NgayNop = gndInfo.NgayNop

                strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & ndInfo.Links & "/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
                Msg03.Text = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"

            End If

            ndInfo = New BC_NoiDungInfo
            ndInfo.BaoCaoID = BaoCaoDinhKy.LDHoan
            ndInfo.Links = "tb-ld-hoan"
            ndInfo.TenBaoCao = "Mẫu 29 - IV. Tạm hoãn thực hiện hợp đồng lao động"
            gndInfo = objController.BC_ThongBao_Get_TinhTrang(Me.PortalId, ItemID.Value, BaoCaoDinhKy.LDHoan)
            If IsNothing(gndInfo) = False Then
                ndInfo.CreatedDate = gndInfo.CreatedDate
                ndInfo.UpdatedDate = gndInfo.UpdatedDate
                ndInfo.NgayNop = gndInfo.NgayNop

                strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & ndInfo.Links & "/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
                Msg04.Text = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"

            End If

        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                    Call LoadNoiDung()
                End If
            Catch ex As Exception
                litUpdate.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', 'Đường truyền không ổn định.', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub InitControls()
            ItemID.Value = Request.Item("itemid")
            DoanhNghiepID.Value = Request.Item("bus")
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP)
			'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
			Dim di1 = New IO.DirectoryInfo(Server.MapPath("\DATA\" & Me.PortalId & "\TEMPEXPORT"))
            If Not di1.Exists Then di1.Create()
            flReg.DeleteAllFiles("\DATA\" & Me.PortalId & "\TEMPEXPORT")
            Call flReg.GetYear(Years_ID)
            Years_ID.SelectedValue = Now.Year
            Call flFunction.LoadPeriod(Period_ID)
            NgayThongBao.Text = Now.ToString("dd/MM/yyyy")
            cmdDelete.Attributes.Add("onClick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
        End Sub
        Private Sub BackEnd()
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit"), True)
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
        Private Sub LoadValue()
            cmdNext.Visible = True
            cmdDelete.Visible = True

            obj = objController.BC_ThongBao_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                DoanhNghiepID.Value = obj.DoanhNghiep_ID
                TenDoanhNghiep.Text = obj.Business_Vn
                TinhTP.SelectedValue = obj.TinhTP
                Years_ID.SelectedValue = obj.Years_ID
                Period_ID.SelectedValue = obj.Period_ID

				Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - - Chọn - - -", "QH")
				QuanHuyen.SelectedValue = obj.QuanHuyen

				Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, QuanHuyen.SelectedValue, "- - - Chọn - - -", "XP")
				XaPhuong.SelectedValue = obj.XaPhuong
                SoNha.Text = obj.SoNha

                NgayThongBao.Text = flReg.ReadDate(obj.NgayThongBao, False)
                litUpdate.Text = ""

                If obj.NgayNop.Year > 1900 Then
                    cmdDelete.Visible = False
                    cmdUpdate.Visible = False
                    cmdNext.Visible = False
                    cup0.Visible = False
                    cup1.Visible = False
                    cup2.Visible = False
                    cup3.Visible = False
                    cup4.Visible = False

                    litUpdate.Text += "<div class=""cmsUpdate"">Ngày nộp thông báo: " & flReg.ReadDate(obj.NgayNop) & "</div>"
                Else
                    cup0.Visible = True
                    cup1.Visible = True
                    cup2.Visible = True
                    cup3.Visible = True
                    cup4.Visible = True
                End If

                litUpdate.Text += "<div class=""cmsUpdate"">Ngày tạo: " & flReg.ReadDate(obj.CreatedDate)
                litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                If obj.UpdatedUser <> "" Then
                    litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                    litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                End If
            Else
                cmdDelete.Visible = False
                cmdNext.Visible = False
                busInfo = objController.BC_Business_Get(Me.PortalId, Request.Item("bus"))
                If IsNothing(busInfo) = False Then
                    TenDoanhNghiep.Text = busInfo.TenDoanhNghiep
                    TinhTP.SelectedValue = busInfo.TinhTP

                    Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
                    QuanHuyen.SelectedValue = busInfo.QuanHuyen

                    Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, QuanHuyen.SelectedValue)
                    XaPhuong.SelectedValue = busInfo.XaPhuong
                    SoNha.Text = busInfo.SoNha

                    cup0.Visible = False
                    cup1.Visible = False
                    cup2.Visible = False
                    cup3.Visible = False
                    cup4.Visible = False
                End If
            End If
        End Sub
        Private Sub UpdateFile0()
            Try
                Dim exCel As ExcelPackage = New ExcelPackage(OpenFile(pathTemp.Value))
				Dim wsh As ExcelWorksheet = exCel.Workbook.Worksheets.First()
				If wsh.Cells("B13").Value & "" = "" Then
					Msg00.Text = "<span style='color:red'>File excel không có dữ liệu</span>"
					Exit Sub
				Else
					_dem = 0 : strError = ""
					Dim obj As New BC_TBDauKyInfo
					objController.BC_TBDauKy_Delete_By_BC_ThongBao(Me.PortalId, ItemID.Value)
					For i = 13 To 1048576
						If wsh.Cells("B" & i).Value & "" = "" Then Exit For
						Try
							obj = New BC_TBDauKyInfo
							obj.TBDauKy_ID = flReg.GenKey()
							obj.ThongBao_ID = ItemID.Value
							obj.DoanhNghiep_ID = DoanhNghiepID.Value
							obj.NgayNop = flReg.DateNull
							obj.IsOrder = _dem
							obj.HoTen = (wsh.Cells("B" & i).Value & "").ToString.Trim()

							obj.NgaySinh = (wsh.Cells("D" & i).Value & "").ToString.Trim()
							obj.GioiTinh = False 'Nữ

							If wsh.Cells("C" & i).Value & "" <> "" Then
								obj.NgaySinh = (wsh.Cells("C" & i).Value & "").ToString.Trim()
								obj.GioiTinh = True 'Nam
							End If
							obj.DanToc = (wsh.Cells("E" & i).Value & "").ToString.Trim()
							obj.CMND = (wsh.Cells("F" & i).Value & "").ToString.Trim()
							obj.BHXH = (wsh.Cells("G" & i).Value & "").ToString.Trim()
							obj.CNKT = getBoolean(wsh.Cells("H" & i).Value)
							obj.CCN = getBoolean(wsh.Cells("I" & i).Value)
							obj.SoCap = getBoolean(wsh.Cells("J" & i).Value)
							obj.TrungCap = getBoolean(wsh.Cells("K" & i).Value)
							obj.CaoDang = getBoolean(wsh.Cells("L" & i).Value)
							obj.DaiHoc = getBoolean(wsh.Cells("M" & i).Value)
							obj.HD_0T = getBoolean(wsh.Cells("N" & i).Value)
							obj.HD_36T = getBoolean(wsh.Cells("O" & i).Value)
							obj.HD_12T = getBoolean(wsh.Cells("P" & i).Value)
							obj.HD_3T = getBoolean(wsh.Cells("Q" & i).Value)
							obj.NgayHD = getDateTime(wsh.Cells("R" & i).Value)
							obj.ViTri = wsh.Cells("S" & i).Value
							obj.BHTN = getDouble(wsh.Cells("T" & i).Value)
							obj.TG_BHTN = getDouble(wsh.Cells("U" & i).Value)
							obj.TrangThai = 0
							obj.CreatedDate = Now
							obj.CreatedUser = Me.UserInfo.Username
							obj.UpdatedDate = Now
							obj.UpdatedUser = Me.UserInfo.Username
							obj.PortalId = Me.PortalId

							objController.BC_TBDauKy_Add(Me.PortalId, obj)
							_dem += 1
						Catch ex As Exception
							strError += i & "; "
						End Try
					Next
					If strError <> "" Then
						Msg00.Text = "<span style='color:red'>File excel lỗi dòng: " & strError & "</span>"
					Else
						Msg00.Text = "Đã import thành công " & _dem & " lao động"
					End If
					strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/tb-lan-dau/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
					strURL = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"
					Msg00.Text = strURL & Msg00.Text
				End If
			Catch ex As Exception
				Msg00.Text = "<span style='color:red'>File excel lỗi, không thể import </span>"
				Msg00.Text += ex.Message
			End Try
		End Sub
		Private Sub UpdateFile1()
			Try
				Dim exCel As ExcelPackage = New ExcelPackage(OpenFile(pathTemp.Value))
				Dim wsh As ExcelWorksheet = exCel.Workbook.Worksheets.First()
				If wsh.Cells("B13").Value & "" = "" Then
					Msg01.Text = "<span style='color:red'>File excel không có dữ liệu</span>"
					Exit Sub
				Else
					Dim obj As New BC_TBCuoiKyInfo
					_dem = 0 : strError = ""
					objController.BC_TBCuoiKy_Delete_By_BC_ThongBao(Me.PortalId, ItemID.Value)
					For i = 13 To 1048576
						If wsh.Cells("B" & i).Value & "" = "" Then Exit For
						Try
							obj = New BC_TBCuoiKyInfo
							obj.TBCuoiKy_ID = flReg.GenKey()
							obj.ThongBao_ID = ItemID.Value
							obj.DoanhNghiep_ID = DoanhNghiepID.Value
							obj.NgayNop = flReg.DateNull
							obj.IsOrder = _dem
							obj.ThoiDiem = (wsh.Cells("A" & i).Value & "").ToString.Trim()
							obj.TongSoLD = getDouble(wsh.Cells("B" & i).Value)
							obj.TongSoNu = getDouble(wsh.Cells("C" & i).Value)
							obj.CNKT = getDouble(wsh.Cells("D" & i).Value)
							obj.CCN = getDouble(wsh.Cells("E" & i).Value)
							obj.SoCap = getDouble(wsh.Cells("F" & i).Value)
							obj.TrungCap = getDouble(wsh.Cells("G" & i).Value)
							obj.CaoDang = getDouble(wsh.Cells("H" & i).Value)
							obj.DaiHoc = getDouble(wsh.Cells("I" & i).Value)
							obj.HD_0T = getDouble(wsh.Cells("J" & i).Value)
							obj.HD_36T = getDouble(wsh.Cells("K" & i).Value)
							obj.HD_12T = getDouble(wsh.Cells("L" & i).Value)
							obj.HD_3T = getDouble(wsh.Cells("M" & i).Value)
							obj.BHTN = getDouble(wsh.Cells("N" & i).Value)
							obj.TrangThai = 0
							obj.CreatedDate = Now
							obj.CreatedUser = Me.UserInfo.Username
							obj.UpdatedDate = Now
							obj.UpdatedUser = Me.UserInfo.Username
							obj.PortalId = Me.PortalId

							objController.BC_TBCuoiKy_Add(Me.PortalId, obj)
							_dem += 1
						Catch ex As Exception
							strError += i & "; "
						End Try
					Next
					If strError <> "" Then
						Msg01.Text = "<span style='color:red'>File excel lỗi dòng: " & strError & "</span>"
					Else
						Msg01.Text = "Đã import thành công " & _dem & " thông tin"
					End If
					strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/tb-dau-cuoi/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
					strURL = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"
					Msg01.Text = strURL & Msg01.Text
				End If
			Catch ex As Exception
				Msg01.Text = "<span style='color:red'>File excel lỗi, không thể import </span>"
				Msg01.Text += ex.Message
			End Try
		End Sub
		Private Sub UpdateFile2()
			Try
				Dim exCel As ExcelPackage = New ExcelPackage(OpenFile(pathTemp.Value))
				Dim wsh As ExcelWorksheet = exCel.Workbook.Worksheets.First()
				If wsh.Cells("B7").Value & "" = "" Then
					Msg02.Text = "<span style='color:red'>File excel không có dữ liệu</span>"
					Exit Sub
				Else
					_dem = 0 : strError = ""
					Dim obj As New BC_LDGiamInfo
					objController.BC_LDGiam_Delete_By_BC_ThongBao(Me.PortalId, ItemID.Value)
					For i = 7 To 1048576
						If wsh.Cells("B" & i).Value & "" = "" Then Exit For
						Try
							obj = New BC_LDGiamInfo
							obj.LDGiam_ID = flReg.GenKey()
							obj.ThongBao_ID = ItemID.Value
							obj.DoanhNghiep_ID = DoanhNghiepID.Value
							obj.NgayNop = flReg.DateNull
							obj.IsOrder = _dem
							obj.HoTen = (wsh.Cells("B" & i).Value & "").ToString.Trim()

							obj.NgaySinh = (wsh.Cells("D" & i).Value & "").ToString.Trim()
							obj.GioiTinh = False 'Nữ

							If wsh.Cells("C" & i).Value & "" <> "" Then
								obj.NgaySinh = (wsh.Cells("C" & i).Value & "").ToString.Trim()
								obj.GioiTinh = True 'Nam
							End If
							obj.DanToc = (wsh.Cells("E" & i).Value & "").ToString.Trim()
							obj.CMND = (wsh.Cells("F" & i).Value & "").ToString.Trim()
							obj.BHXH = (wsh.Cells("G" & i).Value & "").ToString.Trim()
							obj.CNKT = getBoolean(wsh.Cells("H" & i).Value)
							obj.CCN = getBoolean(wsh.Cells("I" & i).Value)
							obj.SoCap = getBoolean(wsh.Cells("J" & i).Value)
							obj.TrungCap = getBoolean(wsh.Cells("K" & i).Value)
							obj.CaoDang = getBoolean(wsh.Cells("L" & i).Value)
							obj.DaiHoc = getBoolean(wsh.Cells("M" & i).Value)
							obj.HD_0T = getBoolean(wsh.Cells("N" & i).Value)
							obj.HD_36T = getBoolean(wsh.Cells("O" & i).Value)
							obj.HD_12T = getBoolean(wsh.Cells("P" & i).Value)
							obj.HD_3T = getBoolean(wsh.Cells("Q" & i).Value)
							obj.NgayHD = getDateTime(wsh.Cells("R" & i).Value)
							obj.NgayChamDut = getDateTime(wsh.Cells("S" & i).Value)
							obj.BHTN = getBoolean(wsh.Cells("T" & i).Value)
							obj.LD_NghiHuu = getBoolean(wsh.Cells("U" & i).Value)
							obj.LD_DonPhuong = getBoolean(wsh.Cells("V" & i).Value)
							obj.LD_CoCau = getBoolean(wsh.Cells("W" & i).Value)
							obj.LD_ChamDut = getBoolean(wsh.Cells("X" & i).Value)
							obj.LD_Khac = getBoolean(wsh.Cells("Y" & i).Value)
							obj.TrangThai = 0
							obj.CreatedDate = Now
							obj.CreatedUser = Me.UserInfo.Username
							obj.UpdatedDate = Now
							obj.UpdatedUser = Me.UserInfo.Username
							obj.PortalId = Me.PortalId

							objController.BC_LDGiam_Add(Me.PortalId, obj)
							_dem += 1
						Catch ex As Exception
							strError += i & "; "
						End Try
					Next
					If strError <> "" Then
						Msg02.Text = "<span style='color:red'>File excel lỗi dòng: " & strError & "</span>"
					Else
						Msg02.Text = "Đã import thành công " & _dem & " lao động"
					End If
					strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/tb-ld-giam/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
					strURL = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"
					Msg02.Text = strURL & Msg02.Text
				End If
			Catch ex As Exception
				Msg02.Text = "<span style='color:red'>File excel lỗi, không thể import </span>"
				Msg02.Text += ex.Message
			End Try
		End Sub
		Private Sub UpdateFile3()
			Try
				Dim exCel As ExcelPackage = New ExcelPackage(OpenFile(pathTemp.Value))
				Dim wsh As ExcelWorksheet = exCel.Workbook.Worksheets.First()
				If wsh.Cells("B7").Value & "" = "" Then
					Msg03.Text = "<span style='color:red'>File excel không có dữ liệu</span>"
					Exit Sub
				Else
					Dim obj As New BC_LDTangInfo
					_dem = 0 : strError = ""
					objController.BC_LDTang_Delete_By_BC_ThongBao(Me.PortalId, ItemID.Value)
					For i = 7 To 1048576
						If wsh.Cells("B" & i).Value & "" = "" Then Exit For
						Try
							obj = New BC_LDTangInfo
							obj.LDTang_ID = flReg.GenKey()
							obj.ThongBao_ID = ItemID.Value
							obj.DoanhNghiep_ID = DoanhNghiepID.Value
							obj.NgayNop = flReg.DateNull
							obj.IsOrder = _dem
							obj.HoTen = (wsh.Cells("B" & i).Value & "").ToString.Trim()

							obj.NgaySinh = (wsh.Cells("D" & i).Value & "").ToString.Trim()
							obj.GioiTinh = False 'Nữ

							If wsh.Cells("C" & i).Value & "" <> "" Then
								obj.NgaySinh = (wsh.Cells("C" & i).Value & "").ToString.Trim()
								obj.GioiTinh = True 'Nam
							End If
							obj.DanToc = (wsh.Cells("E" & i).Value & "").ToString.Trim()
							obj.CMND = (wsh.Cells("F" & i).Value & "").ToString.Trim()
							obj.BHXH = (wsh.Cells("G" & i).Value & "").ToString.Trim()
							obj.CNKT = getBoolean(wsh.Cells("H" & i).Value)
							obj.CCN = getBoolean(wsh.Cells("I" & i).Value)
							obj.SoCap = getBoolean(wsh.Cells("J" & i).Value)
							obj.TrungCap = getBoolean(wsh.Cells("K" & i).Value)
							obj.CaoDang = getBoolean(wsh.Cells("L" & i).Value)
							obj.DaiHoc = getBoolean(wsh.Cells("M" & i).Value)
							obj.HD_0T = getBoolean(wsh.Cells("N" & i).Value)
							obj.HD_36T = getBoolean(wsh.Cells("O" & i).Value)
							obj.HD_12T = getBoolean(wsh.Cells("P" & i).Value)
							obj.HD_3T = getBoolean(wsh.Cells("Q" & i).Value)
							obj.NgayHD = getDateTime(wsh.Cells("R" & i).Value)
							obj.ViTri = wsh.Cells("S" & i).Value
							obj.BHTN = getDouble(wsh.Cells("T" & i).Value)
							obj.TG_BHTN = getDouble(wsh.Cells("U" & i).Value)
							obj.TrangThai = 0
							obj.CreatedDate = Now
							obj.CreatedUser = Me.UserInfo.Username
							obj.UpdatedDate = Now
							obj.UpdatedUser = Me.UserInfo.Username
							obj.PortalId = Me.PortalId

							objController.BC_LDTang_Add(Me.PortalId, obj)
							_dem += 1
						Catch ex As Exception
							strError += i & "; "
						End Try
					Next
					If strError <> "" Then
						Msg03.Text = "<span style='color:red'>File excel lỗi dòng: " & strError & "</span>"
					Else
						Msg03.Text = "Đã import thành công " & _dem & " lao động"
					End If
					strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/tb-ld-tang/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
					strURL = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"
					Msg03.Text = strURL & Msg03.Text
				End If
			Catch ex As Exception
				Msg03.Text = "<span style='color:red'>File excel lỗi, không thể import </span>"
				Msg03.Text += ex.Message
			End Try
		End Sub
		Private Sub UpdateFile4()
			Try
				Dim exCel As ExcelPackage = New ExcelPackage(OpenFile(pathTemp.Value))
				Dim wsh As ExcelWorksheet = exCel.Workbook.Worksheets.First()
				If wsh.Cells("B7").Value & "" = "" Then
					Msg04.Text = "<span style='color:red'>File excel không có dữ liệu</span>"
					Exit Sub
				Else
					Dim obj As New BC_LDHoanInfo
					_dem = 0 : strError = ""
					objController.BC_LDHoan_Delete_By_BC_ThongBao(Me.PortalId, ItemID.Value)
					For i = 7 To 1048576
						If wsh.Cells("B" & i).Value & "" = "" Then Exit For
						Try
							obj = New BC_LDHoanInfo
							obj.LDHoan_ID = flReg.GenKey()
							obj.ThongBao_ID = ItemID.Value
							obj.DoanhNghiep_ID = DoanhNghiepID.Value
							obj.NgayNop = flReg.DateNull
							obj.IsOrder = _dem
							obj.HoTen = (wsh.Cells("B" & i).Value & "").ToString.Trim()

							obj.NgaySinh = (wsh.Cells("D" & i).Value & "").ToString.Trim()
							obj.GioiTinh = False 'Nữ

							If wsh.Cells("C" & i).Value & "" <> "" Then
								obj.NgaySinh = (wsh.Cells("C" & i).Value & "").ToString.Trim()
								obj.GioiTinh = True 'Nam
							End If
							obj.DanToc = (wsh.Cells("E" & i).Value & "").ToString.Trim()
							obj.CMND = (wsh.Cells("F" & i).Value & "").ToString.Trim()
							obj.BHXH = (wsh.Cells("G" & i).Value & "").ToString.Trim()
							obj.CNKT = getBoolean(wsh.Cells("H" & i).Value)
							obj.CCN = getBoolean(wsh.Cells("I" & i).Value)
							obj.SoCap = getBoolean(wsh.Cells("J" & i).Value)
							obj.TrungCap = getBoolean(wsh.Cells("K" & i).Value)
							obj.CaoDang = getBoolean(wsh.Cells("L" & i).Value)
							obj.DaiHoc = getBoolean(wsh.Cells("M" & i).Value)
							obj.HD_0T = getBoolean(wsh.Cells("N" & i).Value)
							obj.HD_36T = getBoolean(wsh.Cells("O" & i).Value)
							obj.HD_12T = getBoolean(wsh.Cells("P" & i).Value)
							obj.HD_3T = getBoolean(wsh.Cells("Q" & i).Value)
							obj.NgayHD = getDateTime(wsh.Cells("R" & i).Value)
							obj.BHTN = getBoolean(wsh.Cells("S" & i).Value)
							obj.HoanTu = getDateTime(wsh.Cells("T" & i).Value)
							obj.HoanDen = getDateTime(wsh.Cells("U" & i).Value)
							obj.TrangThai = 0
                            obj.CreatedDate = Now
                            obj.CreatedUser = Me.UserInfo.Username
                            obj.UpdatedDate = Now
                            obj.UpdatedUser = Me.UserInfo.Username
                            obj.PortalId = Me.PortalId

                            objController.BC_LDHoan_Add(Me.PortalId, obj)
                            _dem += 1
                        Catch ex As Exception
                            strError += i & "; "
                        End Try
                    Next
                    If strError <> "" Then
                        Msg04.Text = "<span style='color:red'>File excel lỗi dòng: " & strError & "</span>"
                    Else
                        Msg04.Text = "Đã import thành công " & _dem & " lao động"
                    End If
                    strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/tb-ld-hoan/itemid/" & ItemID.Value & "/bus/" & DoanhNghiepID.Value
                    strURL = "<span class=""cbta""><a href=""" & strURL & """ title=""Xem thông tin""><img src=""/image/images/folder-h.png"" alt=""Xem"">&nbsp;Xem kết quả</a></span>"
                    Msg04.Text = strURL & Msg04.Text
                End If
            Catch ex As Exception
                Msg04.Text = "<span style='color:red'>File excel lỗi, không thể import </span>"
                Msg04.Text += ex.Message
            End Try
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                obj = New BC_ThongBaoInfo
                obj.DoanhNghiep_ID = DoanhNghiepID.Value
                obj.Business_Vn = TenDoanhNghiep.Text
                obj.TinhTP = TinhTP.Text
                obj.QuanHuyen = QuanHuyen.Text
                obj.XaPhuong = XaPhuong.Text
                obj.TT_NT = ""
                obj.SoNha = SoNha.Text
                obj.NgayThongBao = flReg.WriteDate(NgayThongBao.Text, False)
                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                obj.PortalId = Me.PortalId
                obj.Years_ID = Years_ID.SelectedValue
                obj.Period_ID = Period_ID.SelectedValue

                If ItemID.Value <> "" Then
                    obj.ThongBao_ID = ItemID.Value
                    obj.UpdatedDate = Now
                    obj.UpdatedUser = Me.UserInfo.Username
                    objController.BC_ThongBao_Update(Me.PortalId, obj)
                Else 'Insert
                    ItemID.Value = flReg.GenKey()
                    obj.ThongBao_ID = ItemID.Value
                    obj.UpdatedDate = flReg.DateNull
                    obj.UpdatedUser = ""
                    objController.BC_ThongBao_Add(Me.PortalId, obj)
                End If
                Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã cập nhật thông tin thông báo thành công.', 'Thông báo', false);", True)

            Catch ex As Exception
                litUpdate.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Yêu cầu của bạn hệ thống chưa kịp xử lý, vui lòng thử lại sau.', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.BC_ThongBao_Delete(Me.PortalId, ItemID.Value)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting(); notify('success','Dữ liệu đã được xóa thành công.', 'Thông báo', false);backend('/" & Me.PortalSettings.ActiveTab.TabName & "/edit/thong-bao-bien-dong/bus/" & Request.Item("bus") & "');", True)
            Catch exc As SqlClient.SqlException
                If exc.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('error', '" & flReg.BugLog(Me.PortalId, exc.Message, "work") & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Private Sub cmdUpfile_Click(sender As Object, e As EventArgs) Handles cmdUpfile.Click
            For i As Integer = 0 To Request.Files.Count - 1
                pathTemp.Value = Server.MapPath("\DATA\" & Me.PortalId & "\TEMPEXPORT") & "\" & flReg.GenKey() & "." & flReg.GetFileType(Request.Files(i).FileName, ".")
                Request.Files(i).SaveAs(pathTemp.Value)
                Exit For
            Next
            If FileFlag.Value = "0" Then
                Call UpdateFile0()
            ElseIf FileFlag.Value = "1" Then
                Call UpdateFile1()
            ElseIf FileFlag.Value = "2" Then
                Call UpdateFile2()
            ElseIf FileFlag.Value = "3" Then
                Call UpdateFile3()
            ElseIf FileFlag.Value = "4" Then
                Call UpdateFile4()
            End If

        End Sub
        Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
            Try
                objController.BC_TBDauKy_NopThongBao(Me.PortalId, ItemID.Value, Now)
                objController.BC_TBCuoiKy_NopThongBao(Me.PortalId, ItemID.Value, Now)
                objController.BC_LDTang_NopThongBao(Me.PortalId, ItemID.Value, Now)
                objController.BC_LDHoan_NopThongBao(Me.PortalId, ItemID.Value, Now)
                objController.BC_LDGiam_NopThongBao(Me.PortalId, ItemID.Value, Now)

                objController.BC_ThongBao_NopThongBao(Me.PortalId, ItemID.Value)

                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã nộp thông báo thành công.' , 'Thông báo',false);", True)
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', 'Đường truyền không ổn định, vui lòng thử lại sau' , 'Thông báo',false);", True)
            End Try
        End Sub
    End Class

End Namespace
