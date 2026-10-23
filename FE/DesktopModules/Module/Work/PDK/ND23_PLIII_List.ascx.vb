Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports DotNetNuke.WORK
Imports OfficeOpenXml
Namespace DesktopModules.PDK
    Public MustInherit Class ND23_PLIII_List
        Inherits Entities.Modules.PortalModuleBase
#Region "Variable"
        Dim arr, arrTemp, arrTemp1 As New ArrayList
        Dim ObjController As New WorkController
        Dim liter As Literal
        Dim cbDelete As CheckBox
        Dim itemID, strURL As String
#End Region
#Region "Function"
        Private Sub InitControl()
            Call BindLoadPortal()
            txtKey.Attributes.Add("onkeypress", "return clickButton(event,'" + lbtFind.ClientID + "')")
            txtKey.Text = CMS.flCheck.DecodeSearch(Request.QueryString("key") & "")
            CurrentPage.Value = flReg.WriteNumber(Request.Item("p"))
            If CurrentPage.Value = 0 Then CurrentPage.Value = 1
            EPORTAL.flDic.LoadYear(drYear, Now.Year - 5, Now.Year, False)
            If flReg.WriteNumber(Request.Item("yid")) = 0 Then
                drYear.SelectedValue = Now.Year - 1
            Else
                drYear.SelectedValue = flReg.WriteNumber(Request.Item("yid"))
            End If
        End Sub
        Private Sub LoadValue()
            cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung đã chọn không?');"
            arrTemp = ObjController.ND23_PLIII_List_Search(ddlPortal.SelectedValue, CMS.flCheck.DecodeSearch(txtKey.Text.Trim), 0, CurrentPage.Value, 35, "", drYear.SelectedValue)
            For Each Cr As ND23_PLIIIInfo In arrTemp
                lbTotal.Text = flReg.FormatPrice(Cr.Total)
                If Cr.Total > 35 Then
                    litPage.Text = flReg.NextPage(Cr.Total, 35, CurrentPage.Value, 5, RedirectURL() & "/p/")
                End If
                Exit For
            Next
            grdData.DataSource = arrTemp
            grdData.DataKeyField = "ID"
            grdData.DataBind()
        End Sub
        Private Function RedirectURL() As String
            Dim str As String = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If drYear.SelectedValue <> 0 Then str += "/yid/" & drYear.SelectedValue
            If ddlPortal.SelectedValue <> Me.PortalId Then str += "/pid/" & ddlPortal.SelectedValue
            If txtKey.Text.Trim <> "" Then str += "/key/" & CMS.flCheck.EncodeSearch(txtKey.Text.Trim)
            Return str
        End Function

        Private Sub BindLoadPortal()

            ddlPortal.DataSource = CMS.Ultis.UserPortal(Me.UserInfo.Username)
            ddlPortal.DataTextField = "PortalName"
            ddlPortal.DataValueField = "PortalId"
            ddlPortal.DataBind()
            If Request.Item("pid") & "" <> "" Then
                ddlPortal.SelectedValue = Request.Item("pid")
            Else
                ddlPortal.SelectedValue = Me.PortalId
            End If
        End Sub


#End Region
#Region "Event"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not IsPostBack Then
                Call InitControl()
                Call LoadValue()
            End If
        End Sub

        Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue, True)
        End Sub

        Private Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            strURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & DataBinder.Eval(e.Item.DataItem, "ID") & "/pid/" & ddlPortal.SelectedValue

            liter = e.Item.FindControl("STT")
            liter.Text = grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1

            liter = e.Item.FindControl("Code")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Code")

            liter = e.Item.FindControl("Col1")
            liter.Text = "<a title='" & DataBinder.Eval(e.Item.DataItem, "TenTapThe") & "' href='" & strURL & "'> " & DataBinder.Eval(e.Item.DataItem, "TenTapThe") & "</a>"

            liter = e.Item.FindControl("Col2")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "MST")

            liter = e.Item.FindControl("Col3")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "NLH_HOTEN")

            liter = e.Item.FindControl("Col4")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "NLH_SDT")

            liter = e.Item.FindControl("Col5")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "NLH_CHUCVU")

            liter = e.Item.FindControl("Col6")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ThoiGianDangKy"), False)

        End Sub

        Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            Try
                Dim icount As Integer = 0

                For i As Integer = 0 To grdData.Items.Count - 1
                    cbDelete = grdData.Items(i).FindControl("chkItems")
                    If cbDelete.Checked = True Then
                        itemID = grdData.DataKeys(i)
                        ObjController.ND23_PLI_Delete(ddlPortal.SelectedValue, itemID)
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã xóa dữ liệu thành công.', 'Thông báo', false);", True)
                    Call LoadValue()
                End If
            Catch exc As SqlClient.SqlException
                If exc.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('warning', 'Lỗi có dữ liệu liên kết, không thể xóa được!.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, exc.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub

        Private Sub lbtFind_Click(sender As Object, e As EventArgs) Handles lbtFind.Click, ddlPortal.SelectedIndexChanged, drYear.SelectedIndexChanged
            Response.Redirect(RedirectURL(), True)
        End Sub
#End Region

#Region "Kiểm tra hợp lệ"
#Region "Enum"
        Private Enum IMPORTLogEr
            DanToc = 1
            TonGiao
            TinhTP
            QuanHuyen
            PhuongXa
            NganhDT
            ViTriCV
        End Enum

        Private Enum IMPORTDTUT
            LK1 = 1
            LK2
            LK3
            LK4
            LK5
        End Enum
        Private Enum IMPORTKinhNghiem
            LK1 = 0
            LK2
            LK3
            LK4
            LK5
        End Enum
        Private Enum IMPORTTrinhDo
            LK1 = 16
            LK2
            LK3
            LK4
            LK5 = 22
            LK6 = 24
            LK7
        End Enum
        Private Enum IMPORTKyNang
            LK1 = 1
            LK2
            LK3
            LK4
            LK5
            LK6
            LK7
            LK8
            LK9
        End Enum
#End Region
        Private Function CheckMucDo(str As String, str2 As String, str3 As String) As Integer
            Dim _Type = 0
            If String.IsNullOrEmpty(str) And String.IsNullOrEmpty(str2) And String.IsNullOrEmpty(str3) Then Return _Type
            If String.IsNullOrEmpty(str) = False Then
                Return 1 ''Tốt
            End If
            If String.IsNullOrEmpty(str2) = False Then
                Return 3 ''Khá
            End If
            If String.IsNullOrEmpty(str3) = False Then
                Return 2 ''Trung bình
            End If
            Return _Type
        End Function
        Private Function CheckData(str As String, type As Integer, Optional ByVal line As Integer = 0) As Object
            Select Case type
                Case IMPORTLogEr.TinhTP
                    If String.IsNullOrEmpty(str) Then Return -1
                    Return GetTinhTPId(str.ToUpper)
                Case IMPORTLogEr.QuanHuyen
                    If String.IsNullOrEmpty(str) Then Return -1
                    Return GetQuanHuyenId(str.ToUpper)
                Case IMPORTLogEr.PhuongXa
                    If String.IsNullOrEmpty(str) Then Return -1
                    Return GetPhuongXaId(str.ToUpper)
                    'Case IMPORTLogEr.NganhDT
                    '    If String.IsNullOrEmpty(str) Then Return -1
                    '    Return GetNganhDTId(str.ToUpper)
                    'Case IMPORTLogEr.ViTriCV
                    '    If String.IsNullOrEmpty(str) Then Return -1
                    '    Return GetViTriCVId(str.ToUpper)
                Case Else
                    Return -1
            End Select
        End Function

        Private Function GetTinhTPId(str As String) As Integer
            Dim dr = TinhTP.Items.Cast(Of ListItem)().
    FirstOrDefault(Function(i) flDic.ReplaceDiaDanh(i.Text).Equals(flDic.ReplaceDiaDanh(str).ToString().ToUpper(), StringComparison.InvariantCultureIgnoreCase))
            If IsNothing(dr) = False Then
                Return dr.Value
            Else
                Return -1
            End If
        End Function
        Private Function GetQuanHuyenId(str As String) As Integer
            Dim dr = QuanHuyen.Items.Cast(Of ListItem)().
    FirstOrDefault(Function(i) flDic.ReplaceDiaDanh(i.Text).Equals(flDic.ReplaceDiaDanh(str).ToString().ToUpper(), StringComparison.InvariantCultureIgnoreCase))
            If IsNothing(dr) = False Then
                Return dr.Value
            Else
                Return -1
            End If
        End Function
        Private Function GetPhuongXaId(str As String) As Integer
            Dim dr = PhuongXa.Items.Cast(Of ListItem)().
    FirstOrDefault(Function(i) flDic.ReplaceDiaDanh(i.Text).Equals(flDic.ReplaceDiaDanh(str).ToString().ToUpper(), StringComparison.InvariantCultureIgnoreCase))
            If IsNothing(dr) = False Then
                Return dr.Value
            Else
                Return -1
            End If
        End Function
        '    Private Function GetNganhDTId(str As String) As Integer
        '        Dim dr = drNganhDT.Items.Cast(Of ListItem)().
        'FirstOrDefault(Function(i) i.Text.Equals(str.ToString().ToUpper(), StringComparison.InvariantCultureIgnoreCase))
        '        If IsNothing(dr) = False Then
        '            Return dr.Value
        '        Else
        '            Return -1
        '        End If
        '    End Function
        '    Private Function GetViTriCVId(str As String) As Integer
        '        Dim dr = drViTriCV.Items.Cast(Of ListItem)().
        'FirstOrDefault(Function(i) i.Text.Equals(str.ToString().ToUpper(), StringComparison.InvariantCultureIgnoreCase))
        '        If IsNothing(dr) = False Then
        '            Return dr.Value
        '        Else
        '            Return -1
        '        End If
        '    End Function
#End Region


        Dim objData As New ND23_PLIIIInfo
        Dim objData2 As New ND23_PLIIIAInfo
        Dim intI As Integer
        Private Sub LoadPhuongXa(Optional ByVal idT As String = "")
            TinhTP.SelectedValue = idT
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, PhuongXa, TinhTP.SelectedValue, "--- Phường/xã ---", "XP")
        End Sub
        Private Sub cmdUpfile_Click(sender As Object, e As EventArgs) Handles cmdUpfile.Click
            Try
                For i As Integer = 0 To Request.Files.Count - 1
                    pathTemp.Value = Server.MapPath("\DATA\temps") & "\" & flReg.GenKey() & "." & flReg.GetFileType(Request.Files(i).FileName, ".")
                    Request.Files(i).SaveAs(pathTemp.Value)
                    Exit For
                Next
                Dim _dem As Integer = 0
                Dim strError As String = ""
                Dim exCel As ExcelPackage = New ExcelPackage(OpenFile(pathTemp.Value))
                Dim ws As ExcelWorksheet = exCel.Workbook.Worksheets.First()
                If ws.Cells("C10").Value & "" = "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "info", "removewaiting();notify('info', 'File excel không hợp lệ', 'Thông báo', false);", True)
                    Exit Sub
                Else
                    strError = ""
                    intI = 1
                    For i = 11 To ws.Cells.Count
                        If ws.Cells("B" & i).Value & "" = "" And ws.Cells("C" & i).Value & "" = "" Then Exit For
                        Try
                            objData = New ND23_PLIIIInfo()
                            objData.Code = flReg.GenKey
                            objData.YearId = drYear.SelectedValue
                            objData.TenTapThe = ws.Cells("B" & i).Value & ""
                            objData.CANHAN = IIf(String.IsNullOrEmpty(ws.Cells("H" & i).Value & "") Or String.IsNullOrEmpty(ws.Cells("I" & i).Value & ""), False, True)
                            objData.DOANHNGHIEP = IIf(String.IsNullOrEmpty(ws.Cells("D" & i).Value & "") Or String.IsNullOrEmpty(ws.Cells("E" & i).Value & "") Or String.IsNullOrEmpty(ws.Cells("F" & i).Value & "") Or String.IsNullOrEmpty(ws.Cells("G" & i).Value & ""), False, True)
                            objData.MST = ws.Cells("C" & i).Value & ""
                            objData.LHDN_NN = IIf(String.IsNullOrEmpty(ws.Cells("D" & i).Value & ""), False, True)
                            objData.LHDN_NGNN = IIf(String.IsNullOrEmpty(ws.Cells("E" & i).Value & ""), False, True)
                            objData.LHDN_VDTNN = IIf(String.IsNullOrEmpty(ws.Cells("F" & i).Value & ""), False, True)
                            objData.MaTinh = CheckData(ws.Cells("J" & i).Value & "", IMPORTLogEr.TinhTP)
                            objData.MaHuyen = CheckData(ws.Cells("K" & i).Value & "", IMPORTLogEr.QuanHuyen)
                            ''Load danh mục phường xã
                            LoadPhuongXa(objData.MaHuyen)
                            objData.MaXa = CheckData(ws.Cells("L" & i).Value & "", IMPORTLogEr.PhuongXa)
                            objData.DiaChi = ws.Cells("M" & i).Value & ""
                            objData.KCN = IIf(String.IsNullOrEmpty(ws.Cells("N" & i).Value & ""), False, True)
                            objData.KCN_TEN = ws.Cells("N" & i).Value & ""
                            objData.SDT = ws.Cells("O" & i).Value & ""
                            objData.EMAIL = ws.Cells("FT" & i).Value & ""

                            objData.NGANH_NLNN = IIf(String.IsNullOrEmpty(ws.Cells("P" & i).Value & ""), False, True)
                            objData.NGANH_KHAIKHOANG = IIf(String.IsNullOrEmpty(ws.Cells("Q" & i).Value & ""), False, True)
                            objData.NGANH_CNCHEBIEN = IIf(String.IsNullOrEmpty(ws.Cells("R" & i).Value & ""), False, True)
                            objData.NGANH_XAYDUNG = IIf(String.IsNullOrEmpty(ws.Cells("S" & i).Value & ""), False, True)
                            objData.NGANH_SXPP = IIf(String.IsNullOrEmpty(ws.Cells("T" & i).Value & ""), False, True)
                            objData.NGANH_CCNUOC = IIf(String.IsNullOrEmpty(ws.Cells("U" & i).Value & ""), False, True)
                            objData.NGANH_VANTAI = IIf(String.IsNullOrEmpty(ws.Cells("V" & i).Value & ""), False, True)
                            objData.NGANH_DVLTANUONG = IIf(String.IsNullOrEmpty(ws.Cells("W" & i).Value & ""), False, True)
                            objData.NGANH_TTTT = IIf(String.IsNullOrEmpty(ws.Cells("X" & i).Value & ""), False, True)
                            objData.NGANH_TCBHNH = IIf(String.IsNullOrEmpty(ws.Cells("Y" & i).Value & ""), False, True)
                            objData.NGANH_BDS = IIf(String.IsNullOrEmpty(ws.Cells("Z" & i).Value & ""), False, True)
                            objData.NGANH_KHCN = IIf(String.IsNullOrEmpty(ws.Cells("AA" & i).Value & ""), False, True)
                            objData.NGANH__HCDV = IIf(String.IsNullOrEmpty(ws.Cells("AB" & i).Value & ""), False, True)
                            objData.NGANH_GDDT = IIf(String.IsNullOrEmpty(ws.Cells("AC" & i).Value & ""), False, True)
                            objData.NGANH_YTE = IIf(String.IsNullOrEmpty(ws.Cells("AD" & i).Value & ""), False, True)
                            objData.NGANH_NGHETHUAT = IIf(String.IsNullOrEmpty(ws.Cells("AE" & i).Value & ""), False, True)
                            objData.NGANH_BANLE = IIf(String.IsNullOrEmpty(ws.Cells("AF" & i).Value & ""), False, True)
                            objData.NGANH_DANGDOAN = IIf(String.IsNullOrEmpty(ws.Cells("AG" & i).Value & ""), False, True)
                            objData.NGANH_GIUPVIEC = IIf(String.IsNullOrEmpty(ws.Cells("AH" & i).Value & ""), False, True)
                            objData.NGANH_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("AI" & i).Value & ""), False, True)
                            objData.NGANH_QUOCTE = IIf(String.IsNullOrEmpty(ws.Cells("AJ" & i).Value & ""), False, True)
                            'objData.SANPHAMCHINH = SANPHAMCHINH.Text
                            'objData.QUYMO_DUOI10 = QUYMO_DUOI10.Checked
                            'objData.QUYMO_10DEN50 = QUYMO_10DEN50.Checked
                            'objData.QUYMO_51DEN100 = QUYMO_51DEN100.Checked
                            'objData.QUYMO_101DEN200 = QUYMO_101DEN200.Checked
                            'objData.QUYMO_202DEN500 = QUYMO_202DEN500.Checked
                            'objData.QUYMO_500DEN1K = QUYMO_500DEN1K.Checked
                            'objData.QUYMO_1KDEN3K = QUYMO_1KDEN3K.Checked
                            'objData.QUYMO_3KDEN10K = QUYMO_3KDEN10K.Checked
                            'objData.QUYMO_TREN10K = QUYMO_TREN10K.Checked
                            'objData.SOLD_6THANGTOI = flReg.WriteNumber(SOLD_6THANGTOI.Text)
                            objData.NLH_HOTEN = ws.Cells("FO" & i).Value & ""
                            objData.NLH_CHUCVU = ws.Cells("FP" & i).Value & ""
                            objData.NLH_SDT = ws.Cells("FQ" & i).Value & ""
                            'objData.NLH_LHK = NLH_LHK.Text
                            'objData.DKDV_CSPL = DKDV_CSPL.Checked
                            'objData.DKDV_TVTUYENLD = DKDV_TVTUYENLD.Checked
                            'objData.DKDV_TVSDLD = DKDV_TVSDLD.Checked
                            objData.DKDV_DKGTCULD = True
                            'objData.DKDV_KHAC = DKDV_KHAC.Checked
                            'objData.DKDV_KHAC_TEXT = DKDV_KHAC_TEXT.Text
                            objData.ThoiGianDangKy = flReg.DateNull

                            objData.CreatedDate = DateTime.Now
                            objData.CreatedUser = "GUEST"
                            objData.UpdatedDate = flReg.DateNull
                            objData.UpdatedUser = ""

                            If objData.DKDV_DKGTCULD Then
                                objData2 = New ND23_PLIIIAInfo
                                objData2.Code = flReg.GenKey
                                objData2.MST = ws.Cells("C" & i).Value & ""
                                objData2.TenCongViec = ws.Cells("AK" & i).Value & ""
                                objData2.SoLuong = flReg.WriteNumber(ws.Cells("AL" & i).Value & "")
                                objData2.MoTaCongViec = ws.Cells("AM" & i).Value & ""
                                'objData2.MaNghe = ""
                                objData2.MN_CAP1 = ws.Cells("AN" & i).Value & ""
                                objData2.MN_CAP2 = ws.Cells("AO" & i).Value & ""
                                objData2.MN_CAP3 = ws.Cells("AP" & i).Value & ""
                                objData2.MN_CAP4 = ws.Cells("AQ" & i).Value & ""
                                objData2.CV_NV = IIf(String.IsNullOrEmpty(ws.Cells("AR" & i).Value & ""), False, True)
                                objData2.CV_QL = IIf(String.IsNullOrEmpty(ws.Cells("AS" & i).Value & ""), False, True)
                                objData2.CV_LD = IIf(String.IsNullOrEmpty(ws.Cells("AT" & i).Value & ""), False, True)
                                objData2.CV_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("AU" & i).Value & ""), False, True)
                                objData2.CV_KHAC_TEXT = ws.Cells("AU" & i).Value & ""
                                objData2.TDHV_CTH = IIf(String.IsNullOrEmpty(ws.Cells("AV" & i).Value & ""), False, True)
                                objData2.TDHV_TH = IIf(String.IsNullOrEmpty(ws.Cells("AW" & i).Value & ""), False, True)
                                objData2.TDHV_THCS = IIf(String.IsNullOrEmpty(ws.Cells("AX" & i).Value & ""), False, True)
                                objData2.TDHV_THPT = IIf(String.IsNullOrEmpty(ws.Cells("AY" & i).Value & ""), False, True)

                                objData2.TDCM_CQDT = IIf(String.IsNullOrEmpty(ws.Cells("AZ" & i).Value & ""), False, True)
                                objData2.TDCM_CNKTKB = IIf(String.IsNullOrEmpty(ws.Cells("BA" & i).Value & ""), False, True)
                                objData2.TDCM_SOCAP = IIf(String.IsNullOrEmpty(ws.Cells("BC" & i).Value & ""), False, True)
                                objData2.TDCM_TRUNGCAP = IIf(String.IsNullOrEmpty(ws.Cells("BD" & i).Value & ""), False, True)
                                objData2.TDCM_CAODANG = IIf(String.IsNullOrEmpty(ws.Cells("BE" & i).Value & ""), False, True)
                                objData2.TDCM_DH = IIf(String.IsNullOrEmpty(ws.Cells("BF" & i).Value & ""), False, True)
                                objData2.TDCM_THS = IIf(String.IsNullOrEmpty(ws.Cells("BG" & i).Value & ""), False, True)
                                objData2.TDCM_TS = IIf(String.IsNullOrEmpty(ws.Cells("BH" & i).Value & ""), False, True)
                                objData2.TDCM_KHAC = ws.Cells("BJ" & i).Value & ""
                                'objData2.TDCM_KHAC1 = TDCM_KHAC1.Text
                                'objData2.TDCM_KHAC2 = TDCM_KHAC2.Text
                                objData2.TDKNN = ws.Cells("BK" & i).Value & ""
                                objData2.BAC_NGHE = ws.Cells("BL" & i).Value & ""
                                objData2.TDNN1 = ws.Cells("BM" & i).Value & ""
                                objData2.TDNN1_CC = ws.Cells("BN" & i).Value & ""
                                objData2.TDNN1_MUCDO = CheckMucDo(ws.Cells("BO" & i).Value & "", ws.Cells("BP" & i).Value & "", ws.Cells("BQ" & i).Value & "")
                                objData2.TDNN2 = ws.Cells("BR" & i).Value & ""
                                objData2.TDNN2_CC = ws.Cells("BS" & i).Value & ""
                                objData2.TDNN2_MUCDO = CheckMucDo(ws.Cells("BT" & i).Value & "", ws.Cells("BU" & i).Value & "", ws.Cells("BV" & i).Value & "")
                                objData2.TDTH = IIf(String.IsNullOrEmpty(ws.Cells("BW" & i).Value & ""), False, True)
                                'objData2.TDTH_CC = TDTH_CC.Text
                                objData2.TDTH_MUCDO = CheckMucDo(ws.Cells("BX" & i).Value & "", ws.Cells("BY" & i).Value & "", ws.Cells("BZ" & i).Value & "")
                                objData2.TDTHK = IIf(String.IsNullOrEmpty(ws.Cells("CA" & i).Value & ""), False, True)
                                'objData2.TDTHK_CC = TDTHK_CC.Text
                                objData2.TDTHK_MUCDO = CheckMucDo(ws.Cells("CB" & i).Value & "", ws.Cells("CC" & i).Value & "", ws.Cells("CD" & i).Value & "")
                                objData2.KNM_GT = IIf(String.IsNullOrEmpty(ws.Cells("CE" & i).Value & ""), False, True)
                                objData2.KNM_TT = IIf(String.IsNullOrEmpty(ws.Cells("CF" & i).Value & ""), False, True)
                                objData2.KNM_QLTG = IIf(String.IsNullOrEmpty(ws.Cells("CG" & i).Value & ""), False, True)
                                objData2.KNM_QLNS = IIf(String.IsNullOrEmpty(ws.Cells("CH" & i).Value & ""), False, True)
                                objData2.KNM_THBC = IIf(String.IsNullOrEmpty(ws.Cells("CI" & i).Value & ""), False, True)
                                objData2.KNM_THICHUNG = IIf(String.IsNullOrEmpty(ws.Cells("CJ" & i).Value & ""), False, True)
                                objData2.KNM_LVNHOM = IIf(String.IsNullOrEmpty(ws.Cells("CK" & i).Value & ""), False, True)
                                objData2.KNM_LVDOCLAP = IIf(String.IsNullOrEmpty(ws.Cells("CL" & i).Value & ""), False, True)
                                objData2.KNM_CHIUAPLUC = IIf(String.IsNullOrEmpty(ws.Cells("CM" & i).Value & ""), False, True)
                                objData2.KNM_THEODOI = IIf(String.IsNullOrEmpty(ws.Cells("CN" & i).Value & ""), False, True)
                                objData2.KNM_TUDUYPB = IIf(String.IsNullOrEmpty(ws.Cells("CO" & i).Value & ""), False, True)
                                objData2.KNM_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("CP" & i).Value & ""), False, True)
                                objData2.KNM_KHAC_TEXT = ws.Cells("CP" & i).Value & ""
                                objData2.KN_KC = IIf(String.IsNullOrEmpty(ws.Cells("CQ" & i).Value & ""), False, True)
                                objData2.KN_DUOI1NAM = IIf(String.IsNullOrEmpty(ws.Cells("CR" & i).Value & ""), False, True)
                                objData2.KN_1DEN2NAM = IIf(String.IsNullOrEmpty(ws.Cells("CS" & i).Value & ""), False, True)
                                objData2.KN_2DEN5NAM = IIf(String.IsNullOrEmpty(ws.Cells("CR" & i).Value & ""), False, True)
                                objData2.KN_TREN5NAM = IIf(String.IsNullOrEmpty(ws.Cells("CU" & i).Value & ""), False, True)
                                objData2.NLVUT_TINH = ws.Cells("CV" & i).Value & ""
                                objData2.NLVUT_QHKCN = ws.Cells("CW" & i).Value & ""
                                objData2.LHD_KXD = IIf(String.IsNullOrEmpty(ws.Cells("CX" & i).Value & ""), False, True)
                                objData2.LHD_DUOI12T = IIf(String.IsNullOrEmpty(ws.Cells("CY" & i).Value & ""), False, True)
                                objData2.LHD_12DEN36 = IIf(String.IsNullOrEmpty(ws.Cells("CZ" & i).Value & ""), False, True)
                                objData2.KNDU_LC = IIf(String.IsNullOrEmpty(ws.Cells("DA" & i).Value & ""), False, True)
                                objData2.KNDU_CT = IIf(String.IsNullOrEmpty(ws.Cells("DB" & i).Value & ""), False, True)
                                objData2.KNDU_BP = IIf(String.IsNullOrEmpty(ws.Cells("DC" & i).Value & ""), False, True)
                                objData2.HTLV_TTG = IIf(String.IsNullOrEmpty(ws.Cells("DD" & i).Value & ""), False, True)
                                objData2.HTLV_BTG = IIf(String.IsNullOrEmpty(ws.Cells("DE" & i).Value & ""), False, True)
                                objData2.MDLV_LD = IIf(String.IsNullOrEmpty(ws.Cells("DF" & i).Value & ""), False, True)
                                objData2.MDLV_TT = IIf(String.IsNullOrEmpty(ws.Cells("DG" & i).Value & ""), False, True)
                                objData2.MDLV_LT = IIf(String.IsNullOrEmpty(ws.Cells("DH" & i).Value & ""), False, True)
                                'objData2.ML_THANG = ML_THANG.Text
                                objData2.ML_DUOI5 = IIf(String.IsNullOrEmpty(ws.Cells("DI" & i).Value & ""), False, True)
                                objData2.ML_5DEN10 = IIf(String.IsNullOrEmpty(ws.Cells("DJ" & i).Value & ""), False, True)
                                objData2.ML_10DEN20 = IIf(String.IsNullOrEmpty(ws.Cells("DK" & i).Value & ""), False, True)
                                objData2.ML_20DEN50 = IIf(String.IsNullOrEmpty(ws.Cells("DL" & i).Value & ""), False, True)
                                objData2.ML_TREN50 = IIf(String.IsNullOrEmpty(ws.Cells("DM" & i).Value & ""), False, True)
                                objData2.ML_NGAY = IIf(String.IsNullOrEmpty(ws.Cells("DN" & i).Value & ""), False, True)
                                objData2.ML_NGAY_TEXT = ws.Cells("DN" & i).Value & ""
                                objData2.ML_GIO = IIf(String.IsNullOrEmpty(ws.Cells("DO" & i).Value & ""), False, True)
                                objData2.ML_GIO_TEXT = ws.Cells("DO" & i).Value & ""
                                objData2.ML_THOATHUAN = IIf(String.IsNullOrEmpty(ws.Cells("DP" & i).Value & ""), False, True)
                                objData2.ML_HOAHONG = IIf(String.IsNullOrEmpty(ws.Cells("DQ" & i).Value & ""), False, True)
                                objData2.HTA_1BUA = IIf(String.IsNullOrEmpty(ws.Cells("DR" & i).Value & ""), False, True)
                                objData2.HTA_2BUA = IIf(String.IsNullOrEmpty(ws.Cells("DS" & i).Value & ""), False, True)
                                objData2.HTA_3BUA = IIf(String.IsNullOrEmpty(ws.Cells("DT" & i).Value & ""), False, True)
                                objData2.HTA_TIEN = IIf(String.IsNullOrEmpty(ws.Cells("DU" & i).Value & ""), False, True)
                                objData2.PC_BHXH = IIf(String.IsNullOrEmpty(ws.Cells("DW" & i).Value & ""), False, True)
                                objData2.PC_BHNT = IIf(String.IsNullOrEmpty(ws.Cells("DX" & i).Value & ""), False, True)
                                objData2.PC_THOIVIEC = IIf(String.IsNullOrEmpty(ws.Cells("DY" & i).Value & ""), False, True)
                                objData2.PC_NHATRE = IIf(String.IsNullOrEmpty(ws.Cells("DZ" & i).Value & ""), False, True)
                                objData2.PC_XE = IIf(String.IsNullOrEmpty(ws.Cells("EA" & i).Value & ""), False, True)
                                objData2.PC_HOTRODILAI = IIf(String.IsNullOrEmpty(ws.Cells("EB" & i).Value & ""), False, True)
                                objData2.PC_KTXH = IIf(String.IsNullOrEmpty(ws.Cells("EC" & i).Value & ""), False, True)
                                objData2.PC_HTNO = IIf(String.IsNullOrEmpty(ws.Cells("ED" & i).Value & ""), False, True)
                                objData2.PC_DAOTAO = IIf(String.IsNullOrEmpty(ws.Cells("EE" & i).Value & ""), False, True)
                                objData2.PC_NKT = IIf(String.IsNullOrEmpty(ws.Cells("EF" & i).Value & ""), False, True)
                                objData2.PC_CHTT = IIf(String.IsNullOrEmpty(ws.Cells("EG" & i).Value & ""), False, True)
                                objData2.PC_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("EH" & i).Value & ""), False, True)
                                objData2.PC_KHAC_TEXT = ws.Cells("EH" & i).Value & ""
                                objData2.NLV_TN = IIf(String.IsNullOrEmpty(ws.Cells("EI" & i).Value & ""), False, True)
                                objData2.NLV_NT = IIf(String.IsNullOrEmpty(ws.Cells("EJ" & i).Value & ""), False, True)
                                objData2.NLV_HH = IIf(String.IsNullOrEmpty(ws.Cells("EK" & i).Value & ""), False, True)
                                objData2.TLN_DUOI5 = IIf(String.IsNullOrEmpty(ws.Cells("EL" & i).Value & ""), False, True)
                                objData2.TLN_5DEN20 = IIf(String.IsNullOrEmpty(ws.Cells("EM" & i).Value & ""), False, True)
                                objData2.TLN_TREN20 = IIf(String.IsNullOrEmpty(ws.Cells("EN" & i).Value & ""), False, True)
                                objData2.DILAI_KC = IIf(String.IsNullOrEmpty(ws.Cells("EO" & i).Value & ""), False, True)
                                objData2.DILAI_TB = IIf(String.IsNullOrEmpty(ws.Cells("EP" & i).Value & ""), False, True)
                                objData2.DILAI_NHIEU = IIf(String.IsNullOrEmpty(ws.Cells("EQ" & i).Value & ""), False, True)
                                objData2.NGHENOI_KCT = IIf(String.IsNullOrEmpty(ws.Cells("ER" & i).Value & ""), False, True)
                                objData2.NGHENOI_CB = IIf(String.IsNullOrEmpty(ws.Cells("ES" & i).Value & ""), False, True)
                                objData2.NGHENOI_QT = IIf(String.IsNullOrEmpty(ws.Cells("ET" & i).Value & ""), False, True)
                                objData2.THILUC_BT = IIf(String.IsNullOrEmpty(ws.Cells("EU" & i).Value & ""), False, True)
                                objData2.THILUC_CHITIET = IIf(String.IsNullOrEmpty(ws.Cells("EV" & i).Value & ""), False, True)
                                objData2.THAOTACTAY_VL = IIf(String.IsNullOrEmpty(ws.Cells("EW" & i).Value & ""), False, True)
                                objData2.THAOTACTAY_VN = IIf(String.IsNullOrEmpty(ws.Cells("EX" & i).Value & ""), False, True)
                                objData2.THAOTACTAY_VRN = IIf(String.IsNullOrEmpty(ws.Cells("EY" & i).Value & ""), False, True)
                                objData2.DUNGTAY_2TAY = IIf(String.IsNullOrEmpty(ws.Cells("EZ" & i).Value & ""), False, True)
                                objData2.DUNGTAY_DKC2TAY = IIf(String.IsNullOrEmpty(ws.Cells("FA" & i).Value & ""), False, True)
                                objData2.DUNGTAY_1TAY = IIf(String.IsNullOrEmpty(ws.Cells("FB" & i).Value & ""), False, True)
                                objData2.DUNGTAY_TRAI = IIf(String.IsNullOrEmpty(ws.Cells("FC" & i).Value & ""), False, True)
                                objData2.DUNGTAY_PHAI = IIf(String.IsNullOrEmpty(ws.Cells("FD" & i).Value & ""), False, True)
                                objData2.DTUT_NKT = IIf(String.IsNullOrEmpty(ws.Cells("FE" & i).Value & ""), False, True)
                                objData2.DTUT_DTTS = IIf(String.IsNullOrEmpty(ws.Cells("FF" & i).Value & ""), False, True)
                                objData2.DTUT_HN = IIf(String.IsNullOrEmpty(ws.Cells("FG" & i).Value & ""), False, True)
                                objData2.DTUT_BODOI = IIf(String.IsNullOrEmpty(ws.Cells("FH" & i).Value & ""), False, True)
                                objData2.DTUT_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("FI" & i).Value & ""), False, True)
                                objData2.DTUT_KHAC_TEXT = ws.Cells("FI" & i).Value & ""
                                objData2.HTTD_TT = IIf(String.IsNullOrEmpty(ws.Cells("FJ" & i).Value & ""), False, True)
                                objData2.HTTD_DT = IIf(String.IsNullOrEmpty(ws.Cells("FK" & i).Value & ""), False, True)
                                objData2.HTTD_PV = IIf(String.IsNullOrEmpty(ws.Cells("FL" & i).Value & ""), False, True)
                                objData2.HTTD_CV = IIf(String.IsNullOrEmpty(ws.Cells("FM" & i).Value & ""), False, True)
                                objData2.ThoiHanTD = flReg.WriteDate(ws.Cells("FN" & i).Value & "", False)
                                'objData2.MongMuon_TV = MongMuon_TV.Checked
                                'objData2.MongMuon_GTVL = MongMuon_GTVL.Checked
                                'objData2.MongMuon_CULD = MongMuon_CULD.Checked
                                objData2.NLHTD_HOTEN = ws.Cells("FO" & i).Value & ""
                                objData2.NLHTD_CHUCVU = ws.Cells("FP" & i).Value & ""
                                objData2.NLHTD_SDT = ws.Cells("FQ" & i).Value & ""
                                objData2.NLHTD_EMAIL = ws.Cells("FT" & i).Value & ""
                                objData2.NLHTD_LHK = ws.Cells("FW" & i).Value & ""
                                objData2.PUSH_SMS = IIf(String.IsNullOrEmpty(ws.Cells("FR" & i).Value & ""), False, True)
                                objData2.PUSH_EMAIL = IIf(String.IsNullOrEmpty(ws.Cells("FU" & i).Value & ""), False, True)
                                objData2.CreatedDate = DateTime.Now
                                objData2.CreatedUser = "GUEST"
                                objData2.UpdatedDate = flReg.DateNull
                                objData2.UpdatedUser = ""
                            End If
                            Dim idPLI = ObjController.ND23_PLIII_Add(Me.PortalId, objData)
                            If idPLI <= 0 Then
                                strError += i & "; "
                            Else
                                If objData.DKDV_DKGTCULD Then
                                    objData2.IDPLIII = idPLI
                                    Call ObjController.ND23_PLIIIA_Add(Me.PortalId, objData2)
                                End If
                            End If

                            _dem += 1
                        Catch ex As Exception
                            strError += i & "; "
                        End Try
                        intI += 1
                    Next
                    If strError <> "" Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "info", "removewaiting();notify('warning', 'File excel lỗi dòng: " & strError & "', 'Thông báo', false);", True)
                    Else
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success", "removewaiting();notify('success', 'Đã import thành công " & _dem & " bản ghi', 'Thông báo', false);", True)
                    End If
                    Call LoadValue()
                    txtKey.Focus()
                End If
            Catch ex As Exception
                'XoaFileUpload()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace
