Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports DotNetNuke.WORK
Imports OfficeOpenXml
Imports System.IO
Namespace DesktopModules.PDK
    Public MustInherit Class ND23_PLI_List
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
            arrTemp = ObjController.ND23_PLI_List_Search(ddlPortal.SelectedValue, CMS.flCheck.DecodeSearch(txtKey.Text.Trim), 0, CurrentPage.Value, 35, "", drYear.SelectedValue)
            For Each Cr As ND23_PLIInfo In arrTemp
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
            If ddlPortal.SelectedValue <> Me.PortalId Then str += "/pid/" & ddlPortal.SelectedValue
            If drYear.SelectedValue <> 0 Then str += "/yid/" & drYear.SelectedValue
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
            liter.Text = "<a title='" & DataBinder.Eval(e.Item.DataItem, "HoTen") & "' href='" & strURL & "'> " & DataBinder.Eval(e.Item.DataItem, "HoTen") & "</a>"

            liter = e.Item.FindControl("Col2")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "CMND")

            liter = e.Item.FindControl("Col3")
            liter.Text = flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "NgaySinh"), False)

            liter = e.Item.FindControl("Col4")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "SoDienThoai")

            liter = e.Item.FindControl("Col5")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Email")

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
        Private Function CheckNgaySinhGT(str As String, str2 As String) As Integer
            Dim _Type = -1
            If String.IsNullOrEmpty(str) And String.IsNullOrEmpty(str2) Then Return _Type
            If flReg.WriteDate(str, False).Year > 1900 Then
                _Type = 1
            ElseIf flReg.WriteDate(str2).Year > 1900 Then
                _Type = 0
            Else
                _Type = -1
            End If
            Return _Type
        End Function

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
                Case IMPORTLogEr.DanToc
                    If String.IsNullOrEmpty(str) Then Return -1
                    Return GetDanTocId(str.ToUpper)
                Case IMPORTLogEr.TonGiao
                    If String.IsNullOrEmpty(str) Then Return -1
                    Return GetTonGiaoId(str.ToUpper)
                Case IMPORTLogEr.TinhTP
                    If String.IsNullOrEmpty(str) Then Return -1
                    Return GetTinhTPId(str.ToUpper)
                'Case IMPORTLogEr.QuanHuyen
                '    If String.IsNullOrEmpty(str) Then Return -1
                '    Return GetQuanHuyenId(str.ToUpper)
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

        Private Function GetDanTocId(str As String) As Integer
            Dim dr = drDanToc.Items.Cast(Of ListItem)().
    FirstOrDefault(Function(i) i.Text.Equals(str.ToString().ToUpper(), StringComparison.InvariantCultureIgnoreCase))
            If IsNothing(dr) = False Then
                Return dr.Value
            Else
                Return -1
            End If
        End Function
        Private Function GetTonGiaoId(str As String) As Integer
            Dim dr = drTonGiao.Items.Cast(Of ListItem)().
    FirstOrDefault(Function(i) i.Text.Equals(str.ToString().ToUpper(), StringComparison.InvariantCultureIgnoreCase))
            If IsNothing(dr) = False Then
                Return dr.Value
            Else
                Return -1
            End If
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
        '    Private Function GetQuanHuyenId(str As String) As Integer
        '        Dim dr = QuanHuyen.Items.Cast(Of ListItem)().
        'FirstOrDefault(Function(i) flDic.ReplaceDiaDanh(i.Text).Equals(flDic.ReplaceDiaDanh(str).ToString().ToUpper(), StringComparison.InvariantCultureIgnoreCase))
        '        If IsNothing(dr) = False Then
        '            Return dr.Value
        '        Else
        '            Return -1
        '        End If
        '    End Function
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
        Dim objData As New ND23_PLIInfo
        Dim objData2 As New ND23_PLIAInfo
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
                            objData = New ND23_PLIInfo()
                            objData.Code = flReg.GenKey
                            objData.YearId = drYear.SelectedValue
                            objData.HoTen = ws.Cells("B" & i).Value & ""
                            objData.CMND = ws.Cells("C" & i).Value & ""
                            objData.SoBHXH = ws.Cells("D" & i).Value & ""
                            objData.NgaySinh = IIf(CheckNgaySinhGT(ws.Cells("E" & i).Value & "", ws.Cells("F" & i).Value & "") > 0, flReg.WriteDate(ws.Cells("E" & i).Value & "", False), flReg.WriteDate(ws.Cells("F" & i).Value & "", False))
                            objData.GioiTinh = CheckNgaySinhGT(ws.Cells("E" & i).Value & "", ws.Cells("F" & i).Value & "")
                            objData.DanToc = CheckData(ws.Cells("G" & i).Value & "", IMPORTLogEr.DanToc)
                            objData.TonGiao = CheckData(ws.Cells("H" & i).Value & "", IMPORTLogEr.TonGiao)
                            objData.MaTinh_TT = CheckData(ws.Cells("I" & i).Value & "", IMPORTLogEr.TinhTP)
                            'objData.MaHuyen_TT = CheckData(ws.Cells("J" & i).Value & "", IMPORTLogEr.QuanHuyen)
                            ''Load danh mục phường xã
                            LoadPhuongXa(objData.MaTinh_TT)
                            objData.MaXa_TT = CheckData(ws.Cells("J" & i).Value & "", IMPORTLogEr.PhuongXa)
                            objData.DiaChi_TT = ws.Cells("K" & i).Value & ""
                            objData.MaTinh_HN = CheckData(ws.Cells("L" & i).Value & "", IMPORTLogEr.TinhTP)
                            'objData.MaHuyen_HN = CheckData(ws.Cells("N" & i).Value & "", IMPORTLogEr.QuanHuyen)
                            ''Load danh mục phường xã
                            LoadPhuongXa(objData.MaTinh_TT)
                            objData.MaXa_HN = CheckData(ws.Cells("M" & i).Value & "", IMPORTLogEr.PhuongXa)
                            objData.DiaChi_HN = ws.Cells("N" & i).Value & ""

                            objData.SoDienThoai = ws.Cells("FR" & i).Value & ""
                            objData.Email = ws.Cells("FS" & i).Value & ""
                            objData.LienHeKhac = ws.Cells("FT" & i).Value & ""

                            objData.DTUT_NKT = IIf(String.IsNullOrEmpty(ws.Cells("Q" & i).Value & ""), False, True)
                            'objData.DTUT_DTTS = DTUT_DTTS.Checked
                            objData.DTUT_HN = IIf(String.IsNullOrEmpty(ws.Cells("R" & i).Value & ""), False, True)
                            'objData.DTUT_BODOI = DTUT_BODOI.Checked
                            objData.DTUT_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("U" & i).Value & ""), False, True)
                            objData.DTUT_KHAC_TEXT = ws.Cells("U" & i).Value & ""
                            objData.TDHV_CTH = IIf(String.IsNullOrEmpty(ws.Cells("V" & i).Value & ""), False, True)
                            objData.TDHV_TH = IIf(String.IsNullOrEmpty(ws.Cells("W" & i).Value & ""), False, True)
                            objData.TDHV_THCS = IIf(String.IsNullOrEmpty(ws.Cells("X" & i).Value & ""), False, True)
                            objData.TDHV_THPT = IIf(String.IsNullOrEmpty(ws.Cells("Y" & i).Value & ""), False, True)
                            objData.TDCM_CQDT = IIf(String.IsNullOrEmpty(ws.Cells("Z" & i).Value & ""), False, True)
                            objData.TDCM_CNKTKB = IIf(String.IsNullOrEmpty(ws.Cells("AA" & i).Value & ""), False, True)
                            objData.TDCM_SOCAP = IIf(String.IsNullOrEmpty(ws.Cells("AC" & i).Value & ""), False, True)
                            objData.TDCM_TRUNGCAP = IIf(String.IsNullOrEmpty(ws.Cells("AD" & i).Value & ""), False, True)
                            objData.TDCM_CAODANG = IIf(String.IsNullOrEmpty(ws.Cells("AE" & i).Value & ""), False, True)
                            objData.TDCM_DH = IIf(String.IsNullOrEmpty(ws.Cells("AF" & i).Value & ""), False, True)
                            objData.TDCM_THS = IIf(String.IsNullOrEmpty(ws.Cells("AG" & i).Value & ""), False, True)
                            objData.TDCM_TS = IIf(String.IsNullOrEmpty(ws.Cells("AH" & i).Value & ""), False, True)
                            'objData.TDCM_KHAC = TDCM_KHAC.Text
                            objData.TDCMK_CQDT = IIf(String.IsNullOrEmpty(ws.Cells("AJ" & i).Value & ""), False, True)
                            objData.TDCMK_CNKTKB = IIf(String.IsNullOrEmpty(ws.Cells("AK" & i).Value & ""), False, True)
                            objData.TDCMK_SOCAP = IIf(String.IsNullOrEmpty(ws.Cells("AM" & i).Value & ""), False, True)
                            objData.TDCMK_TRUNGCAP = IIf(String.IsNullOrEmpty(ws.Cells("AN" & i).Value & ""), False, True)
                            objData.TDCMK_CAODANG = IIf(String.IsNullOrEmpty(ws.Cells("AO" & i).Value & ""), False, True)
                            objData.TDCMK_DH = IIf(String.IsNullOrEmpty(ws.Cells("AP" & i).Value & ""), False, True)
                            objData.TDCMK_THS = IIf(String.IsNullOrEmpty(ws.Cells("AQ" & i).Value & ""), False, True)
                            objData.TDCMK_TS1 = IIf(String.IsNullOrEmpty(ws.Cells("AR" & i).Value & ""), False, True)
                            'objData.TDCMK_KHAC = TDCMK_KHAC.Text
                            objData.TDCM_KHAC1 = ws.Cells("AT" & i).Value & ""
                            objData.TDCM_KHAC2 = ws.Cells("AU" & i).Value & ""
                            objData.TDKNN = ws.Cells("AV" & i).Value & ""
                            objData.BAC_NGHE = ws.Cells("AW" & i).Value & ""
                            objData.TDNN1 = ws.Cells("AX" & i).Value & ""
                            objData.TDNN1_CC = ws.Cells("AY" & i).Value & ""
                            objData.TDNN1_MUCDO = CheckMucDo(ws.Cells("AZ" & i).Value & "", ws.Cells("BA" & i).Value & "", ws.Cells("BB" & i).Value & "")
                            objData.TDNN2 = ws.Cells("BC" & i).Value & ""
                            objData.TDNN2_CC = ws.Cells("BD" & i).Value & ""
                            objData.TDNN2_MUCDO = CheckMucDo(ws.Cells("BE" & i).Value & "", ws.Cells("BF" & i).Value & "", ws.Cells("BG" & i).Value & "")
                            objData.TDTH = IIf(String.IsNullOrEmpty(ws.Cells("BH" & i).Value & ""), False, True)
                            objData.TDTH_CC = ws.Cells("BI" & i).Value & ""
                            objData.TDTH_MUCDO = CheckMucDo(ws.Cells("BJ" & i).Value & "", ws.Cells("BK" & i).Value & "", ws.Cells("BL" & i).Value & "")
                            objData.TDTHK = IIf(String.IsNullOrEmpty(ws.Cells("BM" & i).Value & ""), False, True)
                            'objData.TDTHK_CC = TDTHK_CC.Text
                            objData.TDTHK_MUCDO = CheckMucDo(ws.Cells("BN" & i).Value & "", ws.Cells("BO" & i).Value & "", ws.Cells("BP" & i).Value & "")
                            objData.KNM_GT = IIf(String.IsNullOrEmpty(ws.Cells("BQ" & i).Value & ""), False, True)
                            objData.KNM_TT = IIf(String.IsNullOrEmpty(ws.Cells("BR" & i).Value & ""), False, True)
                            objData.KNM_QLTG = IIf(String.IsNullOrEmpty(ws.Cells("BS" & i).Value & ""), False, True)
                            objData.KNM_QLNS = IIf(String.IsNullOrEmpty(ws.Cells("BT" & i).Value & ""), False, True)
                            objData.KNM_THBC = IIf(String.IsNullOrEmpty(ws.Cells("BU" & i).Value & ""), False, True)
                            objData.KNM_THICHUNG = IIf(String.IsNullOrEmpty(ws.Cells("BV" & i).Value & ""), False, True)
                            objData.KNM_LVNHOM = IIf(String.IsNullOrEmpty(ws.Cells("BW" & i).Value & ""), False, True)
                            objData.KNM_LVDOCLAP = IIf(String.IsNullOrEmpty(ws.Cells("BX" & i).Value & ""), False, True)
                            objData.KNM_CHIUAPLUC = IIf(String.IsNullOrEmpty(ws.Cells("BY" & i).Value & ""), False, True)
                            objData.KNM_THEODOI = IIf(String.IsNullOrEmpty(ws.Cells("BZ" & i).Value & ""), False, True)
                            objData.KNM_TUDUYPB = IIf(String.IsNullOrEmpty(ws.Cells("CA" & i).Value & ""), False, True)
                            objData.KNM_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("CB" & i).Value & ""), False, True)
                            objData.KNM_KHAC_TEXT = ws.Cells("CB" & i).Value & ""
                            objData.KNLV1_TENDV = ws.Cells("CC" & i).Value & ""
                            objData.KNLV1_CHUCVU = ws.Cells("CD" & i).Value & ""
                            objData.KNLV1_CV = ws.Cells("CE" & i).Value & ""
                            objData.KNLV1_TG = ws.Cells("CF" & i).Value & ""
                            objData.KNLV2_TENDV = ws.Cells("CG" & i).Value & ""
                            objData.KNLV2_CHUCVU = ws.Cells("CH" & i).Value & ""
                            objData.KNLV2_CV = ws.Cells("CI" & i).Value & ""
                            objData.KNLV2_TG = ws.Cells("CJ" & i).Value & ""
                            'objData.KNLV3_TENDV = KNLV3_TENDV.Text
                            'objData.KNLV3_CHUCVU = KNLV3_CHUCVU.Text
                            'objData.KNLV3_CV = KNLV3_CV.Text
                            'objData.KNLV3_TG = KNLV3_TG.Text
                            'objData.LVNN = LVNN.Checked
                            'objData.LVNN_TEXT = LVNN_TEXT.Text
                            'objData.DKDV_CSPL = DKDV_CSPL.Checked
                            'objData.DKDV_TVVL = DKDV_TVVL.Checked
                            'objData.DKDV_TVDTN = DKDV_TVDTN.Checked
                            'objData.DKDV_TVL = DKDV_TVL.Checked
                            objData.DKDV_TVL = True
                            'objData.DKDV_KHAC = DKDV_KHAC.Checked
                            'objData.DKDV_KHAC_TEXT = DKDV_KHAC_TEXT.Text
                            objData.ThoiGianDangKy = flReg.DateNull
                            objData.CreatedDate = DateTime.Now
                            objData.CreatedUser = "GUEST"
                            objData.UpdatedDate = flReg.DateNull
                            objData.UpdatedUser = ""

                            If objData.DKDV_TVL Then
                                objData2 = New ND23_PLIAInfo
                                objData2.ID = objData.ID
                                objData2.Code = flReg.GenKey
                                objData2.CMND = objData.CMND
                                'objData2.VLMM = VLMM.Text
                                objData2.LHDN_NN = IIf(String.IsNullOrEmpty(ws.Cells("CK" & i).Value & ""), False, True)
                                objData2.LHDN_NGNN = IIf(String.IsNullOrEmpty(ws.Cells("CL" & i).Value & ""), False, True)
                                objData2.LHDN_VDTNN = IIf(String.IsNullOrEmpty(ws.Cells("CM" & i).Value & ""), False, True)
                                objData2.TenCongViec = ws.Cells("CN" & i).Value & ""
                                objData2.MoTaCongViec = ws.Cells("CO" & i).Value & ""
                                'objData2.MaNghe = ""
                                objData2.MN_CAP1 = ws.Cells("CP" & i).Value & ""
                                objData2.MN_CAP2 = ws.Cells("CQ" & i).Value & ""
                                objData2.MN_CAP3 = ws.Cells("CR" & i).Value & ""
                                objData2.MN_CAP4 = ws.Cells("CS" & i).Value & ""
                                objData2.CV_NV = IIf(String.IsNullOrEmpty(ws.Cells("CT" & i).Value & ""), False, True)
                                objData2.CV_QL = IIf(String.IsNullOrEmpty(ws.Cells("CU" & i).Value & ""), False, True)
                                objData2.CV_LD = IIf(String.IsNullOrEmpty(ws.Cells("CV" & i).Value & ""), False, True)
                                objData2.CV_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("CW" & i).Value & ""), False, True)
                                objData2.CV_KHAC_TEXT = ws.Cells("CW" & i).Value & ""
                                objData2.KN_KC = IIf(String.IsNullOrEmpty(ws.Cells("CX" & i).Value & ""), False, True)
                                objData2.KN_DUOI1NAM = IIf(String.IsNullOrEmpty(ws.Cells("CY" & i).Value & ""), False, True)
                                objData2.KN_1DEN2NAM = IIf(String.IsNullOrEmpty(ws.Cells("CZ" & i).Value & ""), False, True)
                                objData2.KN_2DEN5NAM = IIf(String.IsNullOrEmpty(ws.Cells("DA" & i).Value & ""), False, True)
                                objData2.KN_TREN5NAM = IIf(String.IsNullOrEmpty(ws.Cells("DB" & i).Value & ""), False, True)
                                objData2.NLVUT1_TINH = ws.Cells("DC" & i).Value & ""
                                objData2.NLVUT1_QHKCN = ws.Cells("DD" & i).Value & ""
                                objData2.NLVUT2_TINH = ws.Cells("DE" & i).Value & ""
                                objData2.NLVUT2_QHKCN = ws.Cells("DF" & i).Value & ""
                                objData2.LHD_KXD = IIf(String.IsNullOrEmpty(ws.Cells("DG" & i).Value & ""), False, True)
                                'objData2.LHD_DUOI12T = LHD_DUOI12T.Checked
                                'objData2.LHD_12DEN36 = LHD_12DEN36.Checked
                                objData2.KNDU_LC = IIf(String.IsNullOrEmpty(ws.Cells("DJ" & i).Value & ""), False, True)
                                objData2.KNDU_CT = IIf(String.IsNullOrEmpty(ws.Cells("DK" & i).Value & ""), False, True)
                                objData2.KNDU_BP = IIf(String.IsNullOrEmpty(ws.Cells("DL" & i).Value & ""), False, True)
                                objData2.HTLV_TTG = IIf(String.IsNullOrEmpty(ws.Cells("DM" & i).Value & ""), False, True)
                                objData2.HTLV_BTG = IIf(String.IsNullOrEmpty(ws.Cells("DN" & i).Value & ""), False, True)
                                objData2.MDLV_LD = IIf(String.IsNullOrEmpty(ws.Cells("DO" & i).Value & ""), False, True)
                                objData2.MDLV_TT = IIf(String.IsNullOrEmpty(ws.Cells("DP" & i).Value & ""), False, True)
                                objData2.MDLV_LT = IIf(String.IsNullOrEmpty(ws.Cells("DQ" & i).Value & ""), False, True)
                                objData2.ML_DUOI5 = IIf(String.IsNullOrEmpty(ws.Cells("DR" & i).Value & ""), False, True)
                                objData2.ML_5DEN10 = IIf(String.IsNullOrEmpty(ws.Cells("DS" & i).Value & ""), False, True)
                                objData2.ML_10DEN20 = IIf(String.IsNullOrEmpty(ws.Cells("DT" & i).Value & ""), False, True)
                                objData2.ML_20DEN50 = IIf(String.IsNullOrEmpty(ws.Cells("DU" & i).Value & ""), False, True)
                                objData2.ML_TREN50 = IIf(String.IsNullOrEmpty(ws.Cells("DV" & i).Value & ""), False, True)
                                objData2.ML_NGAY = IIf(String.IsNullOrEmpty(ws.Cells("DW" & i).Value & ""), False, True)
                                objData2.ML_NGAY_TEXT = ws.Cells("DW" & i).Value & ""
                                objData2.ML_GIO = IIf(String.IsNullOrEmpty(ws.Cells("DX" & i).Value & ""), False, True)
                                objData2.ML_GIO_TEXT = ws.Cells("DX" & i).Value & ""
                                objData2.ML_THOATHUAN = IIf(String.IsNullOrEmpty(ws.Cells("DY" & i).Value & ""), False, True)
                                objData2.ML_HOAHONG = IIf(String.IsNullOrEmpty(ws.Cells("DZ" & i).Value & ""), False, True)
                                objData2.HTA_1BUA = IIf(String.IsNullOrEmpty(ws.Cells("EA" & i).Value & ""), False, True)
                                objData2.HTA_2BUA = IIf(String.IsNullOrEmpty(ws.Cells("EB" & i).Value & ""), False, True)
                                objData2.HTA_3BUA = IIf(String.IsNullOrEmpty(ws.Cells("EC" & i).Value & ""), False, True)
                                objData2.HTA_TIEN = IIf(String.IsNullOrEmpty(ws.Cells("ED" & i).Value & ""), False, True)
                                objData2.PC_BHXH = IIf(String.IsNullOrEmpty(ws.Cells("EE" & i).Value & ""), False, True)
                                objData2.PC_BHNT = IIf(String.IsNullOrEmpty(ws.Cells("EF" & i).Value & ""), False, True)
                                objData2.PC_THOIVIEC = IIf(String.IsNullOrEmpty(ws.Cells("EG" & i).Value & ""), False, True)
                                objData2.PC_NHATRE = IIf(String.IsNullOrEmpty(ws.Cells("EH" & i).Value & ""), False, True)
                                objData2.PC_XE = IIf(String.IsNullOrEmpty(ws.Cells("EI" & i).Value & ""), False, True)
                                objData2.PC_HOTRODILAI = IIf(String.IsNullOrEmpty(ws.Cells("EJ" & i).Value & ""), False, True)
                                objData2.PC_KTXH = IIf(String.IsNullOrEmpty(ws.Cells("EK" & i).Value & ""), False, True)
                                objData2.PC_HTNO = IIf(String.IsNullOrEmpty(ws.Cells("EL" & i).Value & ""), False, True)
                                objData2.PC_DAOTAO = IIf(String.IsNullOrEmpty(ws.Cells("EM" & i).Value & ""), False, True)
                                objData2.PC_NKT = IIf(String.IsNullOrEmpty(ws.Cells("EN" & i).Value & ""), False, True)
                                objData2.PC_CHTT = IIf(String.IsNullOrEmpty(ws.Cells("EO" & i).Value & ""), False, True)
                                objData2.PC_KHAC = IIf(String.IsNullOrEmpty(ws.Cells("EP" & i).Value & ""), False, True)
                                objData2.PC_KHAC_TEXT = ws.Cells("EP" & i).Value & ""
                                objData2.NLV_TN = IIf(String.IsNullOrEmpty(ws.Cells("EQ" & i).Value & ""), False, True)
                                objData2.NLV_NT = IIf(String.IsNullOrEmpty(ws.Cells("ER" & i).Value & ""), False, True)
                                objData2.NLV_HH = IIf(String.IsNullOrEmpty(ws.Cells("ES" & i).Value & ""), False, True)
                                objData2.TLN_DUOI5 = IIf(String.IsNullOrEmpty(ws.Cells("ET" & i).Value & ""), False, True)
                                objData2.TLN_5DEN20 = IIf(String.IsNullOrEmpty(ws.Cells("EU" & i).Value & ""), False, True)
                                objData2.TLN_TREN20 = IIf(String.IsNullOrEmpty(ws.Cells("EV" & i).Value & ""), False, True)
                                objData2.DILAI_KC = IIf(String.IsNullOrEmpty(ws.Cells("EW" & i).Value & ""), False, True)
                                objData2.DILAI_TB = IIf(String.IsNullOrEmpty(ws.Cells("EX" & i).Value & ""), False, True)
                                objData2.DILAI_NHIEU = IIf(String.IsNullOrEmpty(ws.Cells("EY" & i).Value & ""), False, True)
                                objData2.NGHENOI_KCT = IIf(String.IsNullOrEmpty(ws.Cells("EZ" & i).Value & ""), False, True)
                                objData2.NGHENOI_CB = IIf(String.IsNullOrEmpty(ws.Cells("FA" & i).Value & ""), False, True)
                                objData2.NGHENOI_QT = IIf(String.IsNullOrEmpty(ws.Cells("FB" & i).Value & ""), False, True)
                                objData2.THILUC_BT = IIf(String.IsNullOrEmpty(ws.Cells("FC" & i).Value & ""), False, True)
                                objData2.THILUC_CHITIET = IIf(String.IsNullOrEmpty(ws.Cells("FD" & i).Value & ""), False, True)
                                objData2.THAOTACTAY_VL = IIf(String.IsNullOrEmpty(ws.Cells("FE" & i).Value & ""), False, True)
                                objData2.THAOTACTAY_VN = IIf(String.IsNullOrEmpty(ws.Cells("FF" & i).Value & ""), False, True)
                                objData2.THAOTACTAY_VRN = IIf(String.IsNullOrEmpty(ws.Cells("FG" & i).Value & ""), False, True)
                                objData2.DUNGTAY_2TAY = IIf(String.IsNullOrEmpty(ws.Cells("FH" & i).Value & ""), False, True)
                                objData2.DUNGTAY_DKC2TAY = IIf(String.IsNullOrEmpty(ws.Cells("FI" & i).Value & ""), False, True)
                                objData2.DUNGTAY_1TAY = IIf(String.IsNullOrEmpty(ws.Cells("FJ" & i).Value & ""), False, True)
                                'objData2.DUNGTAY_TRAI = DUNGTAY_TRAI.Checked
                                'objData2.DUNGTAY_PHAI = DUNGTAY_PHAI.Checked
                                objData2.SANSANG_LVN = IIf(String.IsNullOrEmpty(ws.Cells("FL" & i).Value & ""), False, True)
                                objData2.SANSANG_LVS = IIf(String.IsNullOrEmpty(ws.Cells("FM" & i).Value & ""), False, True)
                                objData2.SANSANG_LVS_TEXT = ws.Cells("FM" & i).Value & ""
                                objData2.HTTD_TT = IIf(String.IsNullOrEmpty(ws.Cells("FN" & i).Value & ""), False, True)
                                objData2.HTTD_DT = IIf(String.IsNullOrEmpty(ws.Cells("FO" & i).Value & ""), False, True)
                                objData2.HTTD_PV = IIf(String.IsNullOrEmpty(ws.Cells("FP" & i).Value & ""), False, True)
                                objData2.HTTD_CV = IIf(String.IsNullOrEmpty(ws.Cells("FQ" & i).Value & ""), False, True)
                                objData2.CreatedDate = DateTime.Now
                                objData2.CreatedUser = "GUEST"
                                objData2.UpdatedDate = flReg.DateNull
                                objData2.UpdatedUser = ""
                            End If

                            Dim idPLI = ObjController.ND23_PLI_Add(Me.PortalId, objData)

                            If idPLI <= 0 Then
                                'ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('warning', 'Số CCCD/CMND đã tồn tại trong thời gian đăng ký', 'Thông báo', false);", True)
                                strError += i & "; "
                            Else
                                If objData.DKDV_TVL Then
                                    objData2.IDPLI = idPLI
                                    Call ObjController.ND23_PLIA_Add(Me.PortalId, objData2)
                                End If
                                'ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('success', 'Thêm mới dữ liệu thành công', 'Thông báo', false);", True)
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



        ' ... (Các code cũ giữ nguyên) ...

#Region "Export Excel Full Columns"

        Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
            Try
                ' 1. LẤY DỮ LIỆU
                ' Lưu ý: PageSize để số lớn (ví dụ 100,000) để lấy hết dữ liệu
                Dim pageSize As Integer = 100000
                Dim arrExport As ArrayList = ObjController.ND23_PLI_List_Search(ddlPortal.SelectedValue, CMS.flCheck.DecodeSearch(txtKey.Text.Trim), 0, 1, pageSize, "", drYear.SelectedValue)

                Dim fileSave = flReg.GenKey() & ".xlsx"
                Dim pathTemp = Server.MapPath("/data/temps/" & fileSave)
                If arrExport Is Nothing OrElse arrExport.Count = 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "alert", "notify('warning', 'Không có dữ liệu để xuất.', 'Thông báo', false);", True)
                    Exit Sub
                End If

                Using p As New ExcelPackage()
                    ' Tạo sheet
                    Dim file As FileInfo = New FileInfo(Server.MapPath("/api/analy/TemplatePKS_NLD.xlsx"))
                    Dim package As ExcelPackage = New ExcelPackage(file)
                    Dim ws As OfficeOpenXml.ExcelWorksheet = package.Workbook.Worksheets.First()

                    ' Set Header cơ bản (Bạn nên dùng file Template mẫu có sẵn Header thì đẹp hơn)
                    ' Ở đây tôi chỉ map dữ liệu vào đúng dòng/cột
                    Dim r As Integer = 11 ' Bắt đầu ghi từ dòng 11 theo logic Import [cite: 53]

                    For Each item As ND23_PLIInfo In arrExport
                        ' =========================================================
                        ' PHẦN 1: THÔNG TIN CÁ NHÂN (ND23_PLIInfo)
                        ' =========================================================
                        ws.Cells("B" & r).Value = item.HoTen ' [cite: 54]
                        ws.Cells("C" & r).Value = item.CMND  ' [cite: 55]
                        ws.Cells("D" & r).Value = item.SoBHXH ' [cite: 55]

                        ' Ngày sinh & Giới tính [cite: 55-56]
                        ' Import logic: E=Nam, F=Nữ. 
                        If item.GioiTinh = 1 Then
                            ws.Cells("E" & r).Value = flReg.ReadDate(item.NgaySinh, False) ' Nam
                        ElseIf item.GioiTinh = 0 Then
                            ws.Cells("F" & r).Value = flReg.ReadDate(item.NgaySinh, False) ' Nữ
                        End If

                        ' Dân tộc, Tôn giáo, Địa chỉ [cite: 56-61]
                        ' Lưu ý: Cần hàm lấy Tên từ ID. Ở đây tôi dùng hàm helper GetDDLText
                        ws.Cells("G" & r).Value = GetDDLText(drDanToc, item.DanToc)
                        ws.Cells("H" & r).Value = GetDDLText(drTonGiao, item.TonGiao)

                        ' Thường trú
                        ws.Cells("I" & r).Value = GetDDLText(TinhTP, item.MaTinh_TT)
                        ws.Cells("J" & r).Value = item.MaXa_TT ' Cột J import là Mã Xã[cite: 58]. Nếu muốn hiện tên Xã phải query DB vì DDL Xã load động.
                        ws.Cells("K" & r).Value = item.DiaChi_TT

                        ' Ở hiện nay
                        ws.Cells("L" & r).Value = GetDDLText(TinhTP, item.MaTinh_HN)
                        ws.Cells("M" & r).Value = item.MaXa_HN ' [cite: 60]
                        ws.Cells("N" & r).Value = item.DiaChi_HN

                        ' Thông tin liên lạc (Nằm ở cột xa tít) [cite: 61-62]
                        ws.Cells("FR" & r).Value = item.SoDienThoai
                        ws.Cells("FS" & r).Value = item.Email
                        ws.Cells("FT" & r).Value = item.LienHeKhac

                        ' Đối tượng ưu tiên (Checkboxes) [cite: 62-63]
                        SetCellBool(ws, "Q" & r, item.DTUT_NKT)
                        SetCellBool(ws, "R" & r, item.DTUT_HN)
                        SetCellBool(ws, "U" & r, item.DTUT_KHAC)
                        ws.Cells("U" & r).Value = item.DTUT_KHAC_TEXT ' Ghi đè text nếu có [cite: 64]

                        ' =========================================================
                        ' PHẦN 2: TRÌNH ĐỘ HỌC VẤN & CHUYÊN MÔN (ND23_PLIInfo)
                        ' =========================================================
                        ' Học vấn phổ thông [cite: 64-65]
                        SetCellBool(ws, "V" & r, item.TDHV_CTH)
                        SetCellBool(ws, "W" & r, item.TDHV_TH)
                        SetCellBool(ws, "X" & r, item.TDHV_THCS)
                        SetCellBool(ws, "Y" & r, item.TDHV_THPT)

                        ' Chuyên môn cao nhất [cite: 65-68]
                        SetCellBool(ws, "Z" & r, item.TDCM_CQDT)
                        SetCellBool(ws, "AA" & r, item.TDCM_CNKTKB)
                        SetCellBool(ws, "AC" & r, item.TDCM_SOCAP)
                        SetCellBool(ws, "AD" & r, item.TDCM_TRUNGCAP)
                        SetCellBool(ws, "AE" & r, item.TDCM_CAODANG)
                        SetCellBool(ws, "AF" & r, item.TDCM_DH)
                        SetCellBool(ws, "AG" & r, item.TDCM_THS)
                        SetCellBool(ws, "AH" & r, item.TDCM_TS)

                        ' Chuyên môn khác [cite: 69-71]
                        SetCellBool(ws, "AJ" & r, item.TDCMK_CQDT)
                        SetCellBool(ws, "AK" & r, item.TDCMK_CNKTKB)
                        SetCellBool(ws, "AM" & r, item.TDCMK_SOCAP)
                        SetCellBool(ws, "AN" & r, item.TDCMK_TRUNGCAP)
                        SetCellBool(ws, "AO" & r, item.TDCMK_CAODANG)
                        SetCellBool(ws, "AP" & r, item.TDCMK_DH)
                        SetCellBool(ws, "AQ" & r, item.TDCMK_THS)
                        SetCellBool(ws, "AR" & r, item.TDCMK_TS1)

                        ws.Cells("AT" & r).Value = item.TDCM_KHAC1 ' [cite: 72]
                        ws.Cells("AU" & r).Value = item.TDCM_KHAC2

                        ' Kỹ năng nghề & Ngoại ngữ [cite: 73-77]
                        ws.Cells("AV" & r).Value = item.TDKNN
                        ws.Cells("AW" & r).Value = item.BAC_NGHE
                        ws.Cells("AX" & r).Value = item.TDNN1
                        ws.Cells("AY" & r).Value = item.TDNN1_CC

                        ' Map Mức độ ngoại ngữ 1 (Đảo logic CheckMucDo: 1=Tốt, 3=Khá, 2=TB)
                        SetCellMucDo(ws, r, "AZ", "BA", "BB", item.TDNN1_MUCDO)

                        ws.Cells("BC" & r).Value = item.TDNN2
                        ws.Cells("BD" & r).Value = item.TDNN2_CC
                        ' Map Mức độ ngoại ngữ 2 (BE=Tốt, BF=Khá, BG=TB) [cite: 75]
                        SetCellMucDo(ws, r, "BE", "BF", "BG", item.TDNN2_MUCDO)

                        ' Tin học
                        SetCellBool(ws, "BH" & r, item.TDTH)
                        ws.Cells("BI" & r).Value = item.TDTH_CC
                        ' Map Mức độ tin học (BJ=Tốt, BK=Khá, BL=TB) [cite: 76]
                        SetCellMucDo(ws, r, "BJ", "BK", "BL", item.TDTH_MUCDO)

                        SetCellBool(ws, "BM" & r, item.TDTHK)
                        ' Map Mức độ tin học khác (BN=Tốt, BO=Khá, BP=TB) [cite: 77]
                        SetCellMucDo(ws, r, "BN", "BO", "BP", item.TDTHK_MUCDO)

                        ' Kỹ năng mềm [cite: 78-82]
                        SetCellBool(ws, "BQ" & r, item.KNM_GT)
                        SetCellBool(ws, "BR" & r, item.KNM_TT)
                        SetCellBool(ws, "BS" & r, item.KNM_QLTG)
                        SetCellBool(ws, "BT" & r, item.KNM_QLNS)
                        SetCellBool(ws, "BU" & r, item.KNM_THBC)
                        SetCellBool(ws, "BV" & r, item.KNM_THICHUNG)
                        SetCellBool(ws, "BW" & r, item.KNM_LVNHOM)
                        SetCellBool(ws, "BX" & r, item.KNM_LVDOCLAP)
                        SetCellBool(ws, "BY" & r, item.KNM_CHIUAPLUC)
                        SetCellBool(ws, "BZ" & r, item.KNM_THEODOI)
                        SetCellBool(ws, "CA" & r, item.KNM_TUDUYPB)
                        SetCellBool(ws, "CB" & r, item.KNM_KHAC)
                        If item.KNM_KHAC Then ws.Cells("CB" & r).Value = item.KNM_KHAC_TEXT

                        ' Kinh nghiệm làm việc (Text) [cite: 82-85]
                        ws.Cells("CC" & r).Value = item.KNLV1_TENDV
                        ws.Cells("CD" & r).Value = item.KNLV1_CHUCVU
                        ws.Cells("CE" & r).Value = item.KNLV1_CV
                        ws.Cells("CF" & r).Value = item.KNLV1_TG

                        ws.Cells("CG" & r).Value = item.KNLV2_TENDV
                        ws.Cells("CH" & r).Value = item.KNLV2_CHUCVU
                        ws.Cells("CI" & r).Value = item.KNLV2_CV
                        ws.Cells("CJ" & r).Value = item.KNLV2_TG

                        ' =========================================================
                        ' PHẦN 3: NHU CẦU TÌM VIỆC (ND23_PLIAInfo)
                        ' =========================================================
                        ' Logic: Chỉ lấy dữ liệu nếu DKDV_TVL = True [cite: 88, 90]
                        If item.DKDV_TVL Then
                            ' !!! QUAN TRỌNG: Bạn cần gọi hàm lấy chi tiết PLIA từ DB dựa trên PLI_ID !!!
                            ' Giả sử hàm đó là ObjController.ND23_PLIA_GetByPliId(item.ID)
                            ' Bạn cần thay thế dòng dưới bằng hàm thực tế của bạn.
                            Dim item2 As ND23_PLIAInfo = ObjController.ND23_PLIA_Get_ByPLID(Me.PortalId, item.ID)

                            If item2 IsNot Nothing Then
                                ' Loại hình doanh nghiệp [cite: 93]
                                SetCellBool(ws, "CK" & r, item2.LHDN_NN)
                                SetCellBool(ws, "CL" & r, item2.LHDN_NGNN)
                                SetCellBool(ws, "CM" & r, item2.LHDN_VDTNN)

                                ws.Cells("CN" & r).Value = item2.TenCongViec ' [cite: 94]
                                ws.Cells("CO" & r).Value = item2.MoTaCongViec

                                ' Mã nghề cấp 1-4 [cite: 95-96]
                                ws.Cells("CP" & r).Value = item2.MN_CAP1
                                ws.Cells("CQ" & r).Value = item2.MN_CAP2
                                ws.Cells("CR" & r).Value = item2.MN_CAP3
                                ws.Cells("CS" & r).Value = item2.MN_CAP4

                                ' Chức vụ mong muốn [cite: 96-98]
                                SetCellBool(ws, "CT" & r, item2.CV_NV)
                                SetCellBool(ws, "CU" & r, item2.CV_QL)
                                SetCellBool(ws, "CV" & r, item2.CV_LD)
                                SetCellBool(ws, "CW" & r, item2.CV_KHAC)
                                If item2.CV_KHAC Then ws.Cells("CW" & r).Value = item2.CV_KHAC_TEXT

                                ' Kinh nghiệm làm việc [cite: 98-100]
                                SetCellBool(ws, "CX" & r, item2.KN_KC)
                                SetCellBool(ws, "CY" & r, item2.KN_DUOI1NAM)
                                SetCellBool(ws, "CZ" & r, item2.KN_1DEN2NAM)
                                SetCellBool(ws, "DA" & r, item2.KN_2DEN5NAM)
                                SetCellBool(ws, "DB" & r, item2.KN_TREN5NAM)

                                ' Nơi làm việc ưu tiên [cite: 100-102]
                                ws.Cells("DC" & r).Value = item2.NLVUT1_TINH
                                ws.Cells("DD" & r).Value = item2.NLVUT1_QHKCN
                                ws.Cells("DE" & r).Value = item2.NLVUT2_TINH
                                ws.Cells("DF" & r).Value = item2.NLVUT2_QHKCN

                                ' Loại hợp đồng, Khả năng đáp ứng [cite: 102-104]
                                SetCellBool(ws, "DG" & r, item2.LHD_KXD)
                                SetCellBool(ws, "DJ" & r, item2.KNDU_LC)
                                SetCellBool(ws, "DK" & r, item2.KNDU_CT)
                                SetCellBool(ws, "DL" & r, item2.KNDU_BP)

                                ' Hình thức, Mục đích [cite: 104-106]
                                SetCellBool(ws, "DM" & r, item2.HTLV_TTG)
                                SetCellBool(ws, "DN" & r, item2.HTLV_BTG)
                                SetCellBool(ws, "DO" & r, item2.MDLV_LD)
                                SetCellBool(ws, "DP" & r, item2.MDLV_TT)
                                SetCellBool(ws, "DQ" & r, item2.MDLV_LT)

                                ' Mức lương [cite: 106-110]
                                SetCellBool(ws, "DR" & r, item2.ML_DUOI5)
                                SetCellBool(ws, "DS" & r, item2.ML_5DEN10)
                                SetCellBool(ws, "DT" & r, item2.ML_10DEN20)
                                SetCellBool(ws, "DU" & r, item2.ML_20DEN50)
                                SetCellBool(ws, "DV" & r, item2.ML_TREN50)

                                SetCellBool(ws, "DW" & r, item2.ML_NGAY)
                                If item2.ML_NGAY Then ws.Cells("DW" & r).Value = item2.ML_NGAY_TEXT

                                SetCellBool(ws, "DX" & r, item2.ML_GIO)
                                If item2.ML_GIO Then ws.Cells("DX" & r).Value = item2.ML_GIO_TEXT

                                SetCellBool(ws, "DY" & r, item2.ML_THOATHUAN)
                                SetCellBool(ws, "DZ" & r, item2.ML_HOAHONG)

                                ' Hỗ trợ ăn [cite: 110-112]
                                SetCellBool(ws, "EA" & r, item2.HTA_1BUA)
                                SetCellBool(ws, "EB" & r, item2.HTA_2BUA)
                                SetCellBool(ws, "EC" & r, item2.HTA_3BUA)
                                SetCellBool(ws, "ED" & r, item2.HTA_TIEN)

                                ' Phúc lợi [cite: 112-117]
                                SetCellBool(ws, "EE" & r, item2.PC_BHXH)
                                SetCellBool(ws, "EF" & r, item2.PC_BHNT)
                                SetCellBool(ws, "EG" & r, item2.PC_THOIVIEC)
                                SetCellBool(ws, "EH" & r, item2.PC_NHATRE)
                                SetCellBool(ws, "EI" & r, item2.PC_XE)
                                SetCellBool(ws, "EJ" & r, item2.PC_HOTRODILAI)
                                SetCellBool(ws, "EK" & r, item2.PC_KTXH)
                                SetCellBool(ws, "EL" & r, item2.PC_HTNO)
                                SetCellBool(ws, "EM" & r, item2.PC_DAOTAO)
                                SetCellBool(ws, "EN" & r, item2.PC_NKT)
                                SetCellBool(ws, "EO" & r, item2.PC_CHTT)
                                SetCellBool(ws, "EP" & r, item2.PC_KHAC)
                                If item2.PC_KHAC Then ws.Cells("EP" & r).Value = item2.PC_KHAC_TEXT

                                ' Môi trường & Điều kiện [cite: 117-119]
                                SetCellBool(ws, "EQ" & r, item2.NLV_TN)
                                SetCellBool(ws, "ER" & r, item2.NLV_NT)
                                SetCellBool(ws, "ES" & r, item2.NLV_HH)
                                SetCellBool(ws, "ET" & r, item2.TLN_DUOI5)
                                SetCellBool(ws, "EU" & r, item2.TLN_5DEN20)
                                SetCellBool(ws, "EV" & r, item2.TLN_TREN20)

                                ' Đi lại, Nghe nói, Thị lực [cite: 120-123]
                                SetCellBool(ws, "EW" & r, item2.DILAI_KC)
                                SetCellBool(ws, "EX" & r, item2.DILAI_TB)
                                SetCellBool(ws, "EY" & r, item2.DILAI_NHIEU)
                                SetCellBool(ws, "EZ" & r, item2.NGHENOI_KCT)
                                SetCellBool(ws, "FA" & r, item2.NGHENOI_CB)
                                SetCellBool(ws, "FB" & r, item2.NGHENOI_QT)
                                SetCellBool(ws, "FC" & r, item2.THILUC_BT)
                                SetCellBool(ws, "FD" & r, item2.THILUC_CHITIET)

                                ' Thao tác tay [cite: 123-125]
                                SetCellBool(ws, "FE" & r, item2.THAOTACTAY_VL)
                                SetCellBool(ws, "FF" & r, item2.THAOTACTAY_VN)
                                SetCellBool(ws, "FG" & r, item2.THAOTACTAY_VRN)
                                SetCellBool(ws, "FH" & r, item2.DUNGTAY_2TAY)
                                SetCellBool(ws, "FI" & r, item2.DUNGTAY_DKC2TAY)
                                SetCellBool(ws, "FJ" & r, item2.DUNGTAY_1TAY)

                                ' Sẵn sàng & Tuyển dụng [cite: 126-128]
                                SetCellBool(ws, "FL" & r, item2.SANSANG_LVN)
                                SetCellBool(ws, "FM" & r, item2.SANSANG_LVS)
                                If item2.SANSANG_LVS Then ws.Cells("FM" & r).Value = item2.SANSANG_LVS_TEXT

                                SetCellBool(ws, "FN" & r, item2.HTTD_TT)
                                SetCellBool(ws, "FO" & r, item2.HTTD_DT)
                                SetCellBool(ws, "FP" & r, item2.HTTD_PV)
                                SetCellBool(ws, "FQ" & r, item2.HTTD_CV)
                            End If
                        End If

                        r += 1
                    Next
                    package.SaveAs(New FileInfo(pathTemp))
                    package.Dispose()
                    flReg.SaveFileName("/data/temps/" & fileSave, "PDK_NLD_" & Now.ToString("_dd_MM_yy") & ".xlsx")
                End Using
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "alert", "notify('warning', 'Lỗi: " & ex.Message & "', 'Thông báo', false);", True)
            End Try
        End Sub

        ' --- CÁC HÀM HELPER HỖ TRỢ EXPORT ---

        ' Hàm điền dấu "x" nếu True
        Private Sub SetCellBool(ws As ExcelWorksheet, cellAddress As String, value As Boolean)
            If value Then ws.Cells(cellAddress).Value = "x"
        End Sub

        ' Hàm lấy Text từ DropDownList (Nếu không tìm thấy thì trả về giá trị gốc)
        Private Function GetDDLText(ddl As DropDownList, val As Object) As String
            Dim strVal As String = val.ToString()
            Dim item As ListItem = ddl.Items.FindByValue(strVal)
            If item IsNot Nothing Then
                Return item.Text
            End If
            Return strVal
        End Function

        ' Hàm xử lý logic Mức độ (Tốt/Khá/TB) ngược lại với hàm CheckMucDo [cite: 27-28]
        Private Sub SetCellMucDo(ws As ExcelWorksheet, row As Integer, colTot As String, colKha As String, colTB As String, val As Integer)
            ' Logic import: Tốt=1, Khá=3, TB=2
            If val = 1 Then ws.Cells(colTot & row).Value = "x"      ' Tốt
            If val = 3 Then ws.Cells(colKha & row).Value = "x"      ' Khá
            If val = 2 Then ws.Cells(colTB & row).Value = "x"       ' TB
        End Sub

#End Region
    End Class
End Namespace
