Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New CauController()
        Dim obj As New BC_BusinessInfo
        Dim dicInfo As New WORK.CMS_BusinessInfo
        Dim arrTemp As New ArrayList
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    If ItemID.Value <> "" Then
                        Call LoadValue()
                    Else
                        Call GenBusCode()
                    End If
                End If
            Catch ex As Exception
                litUpdate.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub InitControls()
            ItemID.Value = Request.Item("bus") & ""

            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            If flReg.WriteNumber(flCache.GetCache("BC_KyNhapLieu_Years_" & TinhTP.SelectedValue)) > 0 Then
                KyNhapLieu.Text = flCache.GetCache("BC_KyNhapLieu_Years_" & TinhTP.SelectedValue)
            Else
                KyNhapLieu.Text = Request.Item("nam")
            End If

            Call flDic.LoadRegionalTP(Me.PortalId, TinhTP, "", "TP")
            If Request.Item("tp") <> "" Then
                TinhTP.SelectedValue = Request.Item("tp")
            Else
                If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            End If


            Call flDic.LoadRegionalXP(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "", "XP")
            XaPhuong.SelectedValue = flReg.WriteNumber(Request.Item("xa"))

            Call flFunction.LoadKhuCongNghiep(Me.PortalId, KhuCN_ID, TinhTP.SelectedValue, 0, "")
            If Request.Item("kcn") <> "" Then
                KhuCN_ID.SelectedValue = Request.Item("kcn")
            End If

            Call flFunction.LoadNganhNghe(Me.PortalId, NganhNghe)
            Call flFunction.LoadLoaiHinhDN(Me.PortalId, LoaiHinh_ID)
            Call flFunction.LoadQuyMo(QuyMoLaoDong)
            QuyMoLaoDong.SelectedValue = 2

            'Call flFunction.LoadThanhThi(TT_NT)
            Call flFunction.LoadTinhTrang(TinhTrang)
            TinhTrang.SelectedValue = 1
            cmdReset.Attributes.Add("onclick", "return confirm('Bạn có chắc chắn muốn thực hiện thao tác này không?');")
            cmdCancel.Attributes.Add("onclick", "return confirm('Bạn có chắc chắn muốn thực hiện thao tác này không?');")
            cmdDelete.Attributes.Add("onclick", "return confirm('Bạn có muốn xóa dữ liệu này không?');")

        End Sub
        Private Sub BackEnd()
            Dim strURL As String = ""

            If TinhTP.SelectedValue <> "0" Then strURL += "/tp/" & TinhTP.SelectedValue
            If XaPhuong.SelectedValue <> "0" Then strURL += "/px/" & XaPhuong.SelectedValue
            If KhuCN_ID.SelectedValue <> "" Then strURL += "/kcn/" & KhuCN_ID.SelectedValue
            If Request.Item("page") <> "" Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/nam/" & KyNhapLieu.Text & strURL, True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/nam/" & KyNhapLieu.Text & strURL, True)
            End If
        End Sub
        Private Function BackUrl() As String
            BackUrl = ""
            Dim strURL As String = ""
            If TinhTP.SelectedValue <> "0" Then strURL += "/tp/" & TinhTP.SelectedValue
            If XaPhuong.SelectedValue <> "0" Then strURL += "/px/" & XaPhuong.SelectedValue
            If KhuCN_ID.SelectedValue <> "" Then strURL += "/kcn/" & KhuCN_ID.SelectedValue
            If Request.Item("page") <> "" Then
                BackUrl = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/nam/" & KyNhapLieu.Text & strURL
            Else
                BackUrl = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/nam/" & KyNhapLieu.Text & strURL
            End If

        End Function

        Private Sub LoadValue()
            obj = objController.BC_Business_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                MaDoanhNghiep.Text = obj.MaDoanhNghiep
                TenDoanhNghiep.Text = flReg.RemoveScript(obj.TenDoanhNghiep, False)
                TaxCode.Text = obj.TaxCode
                Mobile.Text = obj.Mobile
                Fax.Text = obj.Fax
                Email.Text = obj.Email
                Website.Text = obj.Website
                TinhTrang.SelectedValue = obj.TinhTrang
                TinhTP.SelectedValue = obj.TinhTP

                Call flDic.LoadRegionalXP(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "", "XP")
                XaPhuong.SelectedValue = obj.XaPhuong

                Call flFunction.LoadKhuCongNghiep(Me.PortalId, KhuCN_ID, TinhTP.SelectedValue, 0, "")
                KhuCN_ID.SelectedValue = obj.KhuCN_ID

                TT_NT.SelectedValue = obj.TT_NT
                SoNha.Text = obj.SoNha
                LoaiHinh_ID.SelectedValue = obj.LoaiHinh_ID
                NganhNghe.SelectedValue = IIf(obj.NganhNghe = 0, "", obj.NganhNghe)
                LD_TongSo.Text = obj.LD_TongSo
                LD_NgoaiTinh.Text = obj.LD_NgoaiTinh
                LD_TrucTiep.Text = obj.LD_TrucTiep
                LD_Nu.Text = obj.LD_Nu
                LD_HD_Tong.Text = obj.LD_HD_Tong
                LD_HD_Nu.Text = obj.LD_HD_Nu
                LD_NuocNgoai_Tong.Text = obj.LD_NuocNgoai_Tong
                LD_NuocNgoai_Nu.Text = obj.LD_NuocNgoai_Nu
                LD_PhoThong.Text = obj.LD_PhoThong
                CMKT_Khong.Text = obj.CMKT_Khong
                CMKT_BangCap.Text = obj.CMKT_BangCap
                CMKT_DaoTao.Text = obj.CMKT_DaoTao
                CMKT_SoCap.Text = obj.CMKT_SoCap
                CMKT_TrungCap.Text = obj.CMKT_TrungCap
                CMKT_CaoDang.Text = obj.CMKT_CaoDang
                CMKT_DaiHoc.Text = obj.CMKT_DaiHoc
                GDDT_KTXH.Text = obj.GDDT_KTXH
                GDDT_KHTN.Text = obj.GDDT_KHTN
                GDDT_KTCN.Text = obj.GDDT_KTCN
                GDDT_NongNghiep.Text = obj.GDDT_NongNghiep
                GDDT_YTe.Text = obj.GDDT_YTe
                GDDT_Khac.Text = obj.GDDT_Khac
                Nhom_LanhDao.Text = obj.Nhom_LanhDao
                Nhom_ChuyenMon.Text = obj.Nhom_ChuyenMon
                Nhom_TroLy.Text = obj.Nhom_TroLy
                Nhom_DichVu.Text = obj.Nhom_DichVu
                Nhom_NongNghiep.Text = obj.Nhom_NongNghiep
                Nhom_ThuCong.Text = obj.Nhom_ThuCong
                Nhom_Tho.Text = obj.Nhom_Tho
                Nhom_DonGian.Text = obj.Nhom_DonGian
                TL_BinhQuan.Text = obj.TL_BinhQuan
                TL_ThapNhat.Text = obj.TL_ThapNhat
                TL_CaoNhat.Text = obj.TL_CaoNhat
                Chia_Khong.Text = obj.Chia_Khong
                Chia_BangCap.Text = obj.Chia_BangCap
                Chia_DaoTao.Text = obj.Chia_DaoTao
                Chia_SoCap.Text = obj.Chia_SoCap
                Chia_TrungCap.Text = obj.Chia_TrungCap
                Chia_CaoDang.Text = obj.Chia_CaoDang
                Chia_DaiHoc.Text = obj.Chia_DaiHoc
                SanPhamChinh.Text = obj.SanPhamChinh
                QuyMoLaoDong.SelectedValue = obj.QuyMoLaoDong
                LD_NgoaiTinh_Nu.Text = obj.LD_NgoaiTinh_Nu
                LD_TrucTiep_Nu.Text = obj.LD_TrucTiep_Nu
                LD_GianTiep.Text = obj.LD_GianTiep
                LD_GianTiep_Nu.Text = obj.LD_GianTiep_Nu
                LD_BHXH.Text = obj.LD_BHXH
                LD_BHXH_Nu.Text = obj.LD_BHXH_Nu
                LD_TREN35.Text = obj.LD_TREN35
                LD_TREN35_Nu.Text = obj.LD_TREN35_Nu
                LD_PhoThong_Nu.Text = obj.LD_PhoThong_Nu
                VT_NhaQuanLy.Text = obj.VT_NhaQuanLy
                VT_NhaQuanLy_Nu.Text = obj.VT_NhaQuanLy_Nu
                VT_CMKT_Cao.Text = obj.VT_CMKT_Cao
                VT_CMKT_Cao_Nu.Text = obj.VT_CMKT_Cao_Nu
                VT_CMKT_Trung.Text = obj.VT_CMKT_Trung
                VT_CMKT_Trung_Nu.Text = obj.VT_CMKT_Trung_Nu
                VT_CMKT_Khac.Text = obj.VT_CMKT_Khac
                VT_CMKT_Khac_Nu.Text = obj.VT_CMKT_Khac_Nu
                CMKT_Khong_Nu.Text = obj.CMKT_Khong_Nu
                CMKT_BangCap_Nu.Text = obj.CMKT_BangCap_Nu
                CMKT_DaoTao_Nu.Text = obj.CMKT_DaoTao_Nu
                CMKT_SoCap_Nu.Text = obj.CMKT_SoCap_Nu
                CMKT_TrungCap_Nu.Text = obj.CMKT_TrungCap_Nu
                CMKT_CaoDang_Nu.Text = obj.CMKT_CaoDang_Nu
                CMKT_DaiHoc_Nu.Text = obj.CMKT_DaiHoc_Nu
                GDDT_KTXH_Nu.Text = obj.GDDT_KTXH_Nu
                GDDT_KHTN_Nu.Text = obj.GDDT_KHTN_Nu
                GDDT_KTCN_Nu.Text = obj.GDDT_KTCN_Nu
                GDDT_NongNghiep_Nu.Text = obj.GDDT_NongNghiep_Nu
                GDDT_YTe_Nu.Text = obj.GDDT_YTe_Nu
                GDDT_Khac_Nu.Text = obj.GDDT_Khac_Nu
                C8_17.Text = obj.C8_17
                C8_21.Text = obj.C8_21
                C8_22.Text = obj.C8_22
                C8_23.Text = obj.C8_23
                C8_24.Text = obj.C8_24
                C8_25.Text = obj.C8_25
                C8_26.Text = obj.C8_26
                C8_31.Text = obj.C8_31
                C8_32.Text = obj.C8_32
                C8_33.Text = obj.C8_33
                C8_34.Text = obj.C8_34
                C8_35.Text = obj.C8_35
                C8_36.Text = obj.C8_36
                C8_41.Text = obj.C8_41
                C8_42.Text = obj.C8_42
                C8_43.Text = obj.C8_43
                C8_44.Text = obj.C8_44
                C8_51.Text = obj.C8_51
                C8_52.Text = obj.C8_52
                C8_53.Text = obj.C8_53
                C8_54.Text = obj.C8_54
                C8_61.Text = obj.C8_61
                C8_62.Text = obj.C8_62
                C8_63.Text = obj.C8_63
                C8_71.Text = obj.C8_71
                C8_72.Text = obj.C8_72
                C8_73.Text = obj.C8_73
                C8_74.Text = obj.C8_74
                C8_75.Text = obj.C8_75
                C8_81.Text = obj.C8_81
                C8_82.Text = obj.C8_82
                C8_83.Text = obj.C8_83
                C8_91.Text = obj.C8_91
                C8_92.Text = obj.C8_92
                C8_93.Text = obj.C8_93
                C8_94.Text = obj.C8_94
                C8_95.Text = obj.C8_95
                C8_96.Text = obj.C8_96
                C8_17_Nu.Text = obj.C8_17_Nu
                C8_21_Nu.Text = obj.C8_21_Nu
                C8_22_Nu.Text = obj.C8_22_Nu
                C8_23_Nu.Text = obj.C8_23_Nu
                C8_24_Nu.Text = obj.C8_24_Nu
                C8_25_Nu.Text = obj.C8_25_Nu
                C8_26_Nu.Text = obj.C8_26_Nu
                C8_31_Nu.Text = obj.C8_31_Nu
                C8_32_Nu.Text = obj.C8_32_Nu
                C8_33_Nu.Text = obj.C8_33_Nu
                C8_34_Nu.Text = obj.C8_34_Nu
                C8_35_Nu.Text = obj.C8_35_Nu
                C8_36_Nu.Text = obj.C8_36_Nu
                C8_41_Nu.Text = obj.C8_41_Nu
                C8_42_Nu.Text = obj.C8_42_Nu
                C8_43_Nu.Text = obj.C8_43_Nu
                C8_44_Nu.Text = obj.C8_44_Nu
                C8_51_Nu.Text = obj.C8_51_Nu
                C8_52_Nu.Text = obj.C8_52_Nu
                C8_53_Nu.Text = obj.C8_53_Nu
                C8_54_Nu.Text = obj.C8_54_Nu
                C8_61_Nu.Text = obj.C8_61_Nu
                C8_62_Nu.Text = obj.C8_62_Nu
                C8_63_Nu.Text = obj.C8_63_Nu
                C8_71_Nu.Text = obj.C8_71_Nu
                C8_72_Nu.Text = obj.C8_72_Nu
                C8_73_Nu.Text = obj.C8_73_Nu
                C8_74_Nu.Text = obj.C8_74_Nu
                C8_75_Nu.Text = obj.C8_75_Nu
                C8_81_Nu.Text = obj.C8_81_Nu
                C8_82_Nu.Text = obj.C8_82_Nu
                C8_83_Nu.Text = obj.C8_83_Nu
                C8_91_Nu.Text = obj.C8_91_Nu
                C8_92_Nu.Text = obj.C8_92_Nu
                C8_93_Nu.Text = obj.C8_93_Nu
                C8_94_Nu.Text = obj.C8_94_Nu
                C8_95_Nu.Text = obj.C8_95_Nu
                C8_96_Nu.Text = obj.C8_96_Nu
                C11_17.Text = obj.C11_17
                C11_21.Text = obj.C11_21
                C11_22.Text = obj.C11_22
                C11_23.Text = obj.C11_23
                C11_24.Text = obj.C11_24
                C11_25.Text = obj.C11_25
                C11_26.Text = obj.C11_26
                C11_31.Text = obj.C11_31
                C11_32.Text = obj.C11_32
                C11_33.Text = obj.C11_33
                C11_34.Text = obj.C11_34
                C11_35.Text = obj.C11_35
                C11_36.Text = obj.C11_36
                C11_41.Text = obj.C11_41
                C11_42.Text = obj.C11_42
                C11_43.Text = obj.C11_43
                C11_44.Text = obj.C11_44
                C11_51.Text = obj.C11_51
                C11_52.Text = obj.C11_52
                C11_53.Text = obj.C11_53
                C11_54.Text = obj.C11_54
                C11_61.Text = obj.C11_61
                C11_62.Text = obj.C11_62
                C11_63.Text = obj.C11_63
                C11_71.Text = obj.C11_71
                C11_72.Text = obj.C11_72
                C11_73.Text = obj.C11_73
                C11_74.Text = obj.C11_74
                C11_75.Text = obj.C11_75
                C11_81.Text = obj.C11_81
                C11_82.Text = obj.C11_82
                C11_83.Text = obj.C11_83
                C11_91.Text = obj.C11_91
                C11_92.Text = obj.C11_92
                C11_93.Text = obj.C11_93
                C11_94.Text = obj.C11_94
                C11_95.Text = obj.C11_95
                C11_96.Text = obj.C11_96
                C11_17_Nu.Text = obj.C11_17_Nu
                C11_21_Nu.Text = obj.C11_21_Nu
                C11_22_Nu.Text = obj.C11_22_Nu
                C11_23_Nu.Text = obj.C11_23_Nu
                C11_24_Nu.Text = obj.C11_24_Nu
                C11_25_Nu.Text = obj.C11_25_Nu
                C11_26_Nu.Text = obj.C11_26_Nu
                C11_31_Nu.Text = obj.C11_31_Nu
                C11_32_Nu.Text = obj.C11_32_Nu
                C11_33_Nu.Text = obj.C11_33_Nu
                C11_34_Nu.Text = obj.C11_34_Nu
                C11_35_Nu.Text = obj.C11_35_Nu
                C11_36_Nu.Text = obj.C11_36_Nu
                C11_41_Nu.Text = obj.C11_41_Nu
                C11_42_Nu.Text = obj.C11_42_Nu
                C11_43_Nu.Text = obj.C11_43_Nu
                C11_44_Nu.Text = obj.C11_44_Nu
                C11_51_Nu.Text = obj.C11_51_Nu
                C11_52_Nu.Text = obj.C11_52_Nu
                C11_53_Nu.Text = obj.C11_53_Nu
                C11_54_Nu.Text = obj.C11_54_Nu
                C11_61_Nu.Text = obj.C11_61_Nu
                C11_62_Nu.Text = obj.C11_62_Nu
                C11_63_Nu.Text = obj.C11_63_Nu
                C11_71_Nu.Text = obj.C11_71_Nu
                C11_72_Nu.Text = obj.C11_72_Nu
                C11_73_Nu.Text = obj.C11_73_Nu
                C11_74_Nu.Text = obj.C11_74_Nu
                C11_75_Nu.Text = obj.C11_75_Nu
                C11_81_Nu.Text = obj.C11_81_Nu
                C11_82_Nu.Text = obj.C11_82_Nu
                C11_83_Nu.Text = obj.C11_83_Nu
                C11_91_Nu.Text = obj.C11_91_Nu
                C11_92_Nu.Text = obj.C11_92_Nu
                C11_93_Nu.Text = obj.C11_93_Nu
                C11_94_Nu.Text = obj.C11_94_Nu
                C11_95_Nu.Text = obj.C11_95_Nu
                C11_96_Nu.Text = obj.C11_96_Nu
                C10_LaoDong.Text = obj.C10_LaoDong
                Chia_Khong_Nu.Text = obj.Chia_Khong_Nu
                Chia_BangCap_Nu.Text = obj.Chia_BangCap_Nu
                Chia_DaoTao_Nu.Text = obj.Chia_DaoTao_Nu
                Chia_SoCap_Nu.Text = obj.Chia_SoCap_Nu
                Chia_TrungCap_Nu.Text = obj.Chia_TrungCap_Nu
                Chia_CaoDang_Nu.Text = obj.Chia_CaoDang_Nu
                Chia_DaiHoc_Nu.Text = obj.Chia_DaiHoc_Nu
                litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo: " & flReg.ReadDate(obj.CreatedDate)
                litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                If obj.UpdatedUser <> "" Then
                    litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                    litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                End If
            Else
                cmdExport.Visible = False
                cmdDelete.Visible = False
                dicInfo = New WORK.WorkController().CMS_Business_Get(Me.PortalId, ItemID.Value)
                If IsNothing(dicInfo) = False Then
                    TenDoanhNghiep.Text = flReg.RemoveScript(dicInfo.Business_Vn, False)
                    TaxCode.Text = dicInfo.TaxCode
                    Mobile.Text = dicInfo.Mobile
                    Fax.Text = dicInfo.Fax
                    Email.Text = dicInfo.Email
                    Website.Text = dicInfo.Website
                End If
                GenBusCode()
            End If
            'ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub
        Private Function CheckCode() As String
            CheckCode = objController.BC_Business_Check_Code(Me.PortalId, TinhTP.SelectedValue, XaPhuong.SelectedValue, 0)
            If CheckCode.Length = 4 Then
                Return "0" & CheckCode
            ElseIf CheckCode.Length = 3 Then
                Return "00" & CheckCode
            ElseIf CheckCode.Length = 2 Then
                Return "000" & CheckCode
            ElseIf CheckCode.Length = 1 Then
                Return "0000" & CheckCode
            Else
                Return CheckCode
            End If
        End Function
        Private Sub GenBusCode()
            MaDoanhNghiep.Text = flDic.RegionalTP_Code(Me.PortalId, TinhTP.SelectedValue)
            MaDoanhNghiep.Text &= "." & flDic.RegionalQH_Code(Me.PortalId, XaPhuong.SelectedValue)
            If KhuCN_ID.SelectedValue <> "" Then
                MaDoanhNghiep.Text &= ".01." & CheckCode()
            Else
                MaDoanhNghiep.Text &= ".00." & CheckCode()
            End If
        End Sub
#Region "Validate"
        Dim sRes As String = ""
        Private Function ValidateTSLD() As String
            sRes = ""
            Dim tLD_TongSo = flReg.WriteNumber(LD_TongSo.Text)
            Dim nLD_Nu = flReg.WriteNumber(LD_Nu.Text)
            If nLD_Nu > tLD_TongSo Then sRes = "Mục 3. Tổng số lao động"
            Return sRes
        End Function
        Private Function ValidatePLLD() As String
            sRes = ""
            Dim tLD_BHXH = flReg.WriteNumber(LD_BHXH.Text)
            Dim nLD_BHXH_Nu = flReg.WriteNumber(LD_BHXH_Nu.Text)
            Dim tLD_TREN35 = flReg.WriteNumber(LD_TREN35.Text)
            Dim nLD_TREN35_Nu = flReg.WriteNumber(LD_TREN35_Nu.Text)

            If nLD_BHXH_Nu > tLD_BHXH Then sRes = "Mục 3.1 - Số lao động tham gia BHXH bắt buộc"
            If nLD_TREN35_Nu > tLD_TREN35 Then sRes = "Mục 3.1 - Số lao động trên 35 tuổi"
            Return sRes
        End Function
        Private Function ValidateVTVL() As String
            sRes = ""
            Dim tVT_NhaQuanLy = flReg.WriteNumber(VT_NhaQuanLy.Text)
            Dim nVT_NhaQuanLy_Nu = flReg.WriteNumber(VT_NhaQuanLy_Nu.Text)
            If nVT_NhaQuanLy_Nu > tVT_NhaQuanLy Then sRes = "Mục 3.2 - Số lao động tham gia BHXH bắt buộc"

            Dim tVT_CMKT_Cao = flReg.WriteNumber(VT_CMKT_Cao.Text)
            Dim nVT_CMKT_Cao_Nu = flReg.WriteNumber(VT_CMKT_Cao_Nu.Text)
            If nVT_CMKT_Cao_Nu > tVT_CMKT_Cao Then sRes = "Mục 3.2 - Chuyên môn kỹ thuật bậc cao"

            Dim tVT_CMKT_Trung = flReg.WriteNumber(VT_CMKT_Trung.Text)
            Dim nVT_CMKT_Trung_Nu = flReg.WriteNumber(VT_CMKT_Trung_Nu.Text)
            If nVT_CMKT_Trung_Nu > tVT_CMKT_Trung Then sRes = "Mục 3.2 - Chuyên môn kỹ thuật bậc trung"

            Dim tVT_CMKT_Khac = flReg.WriteNumber(VT_CMKT_Khac.Text)
            Dim nVT_CMKT_Khac_Nu = flReg.WriteNumber(VT_CMKT_Khac_Nu.Text)
            If nVT_CMKT_Khac_Nu > tVT_CMKT_Khac Then sRes = "Mục 3.2 - Khác"

            Return sRes
        End Function
        Private Function InputValidateMuc4() As String
            Dim tC11_17 = flReg.WriteNumber(C11_17.Text)
            Dim nC11_17 = flReg.WriteNumber(C11_17_Nu.Text)
            Dim tC11_21 = flReg.WriteNumber(C11_21.Text)
            Dim nC11_21 = flReg.WriteNumber(C11_21_Nu.Text)
            Dim tC11_22 = flReg.WriteNumber(C11_22.Text)
            Dim nC11_22 = flReg.WriteNumber(C11_22_Nu.Text)
            Dim tC11_23 = flReg.WriteNumber(C11_23.Text)
            Dim nC11_23 = flReg.WriteNumber(C11_23_Nu.Text)
            Dim tC11_24 = flReg.WriteNumber(C11_24.Text)
            Dim nC11_24 = flReg.WriteNumber(C11_24_Nu.Text)
            Dim tC11_25 = flReg.WriteNumber(C11_25.Text)
            Dim nC11_25 = flReg.WriteNumber(C11_25_Nu.Text)
            Dim tC11_26 = flReg.WriteNumber(C11_26.Text)
            Dim nC11_26 = flReg.WriteNumber(C11_26_Nu.Text)
            Dim tC11_36 = flReg.WriteNumber(C11_36.Text)
            Dim nC11_36 = flReg.WriteNumber(C11_36_Nu.Text)
            Dim tC11_35 = flReg.WriteNumber(C11_35.Text)
            Dim nC11_35 = flReg.WriteNumber(C11_35_Nu.Text)
            Dim tC11_34 = flReg.WriteNumber(C11_34.Text)
            Dim nC11_34 = flReg.WriteNumber(C11_34_Nu.Text)
            Dim tC11_33 = flReg.WriteNumber(C11_33.Text)
            Dim nC11_33 = flReg.WriteNumber(C11_33_Nu.Text)
            Dim tC11_32 = flReg.WriteNumber(C11_32.Text)
            Dim nC11_32 = flReg.WriteNumber(C11_32_Nu.Text)
            Dim tC11_31 = flReg.WriteNumber(C11_31.Text)
            Dim nC11_31 = flReg.WriteNumber(C11_31_Nu.Text)
            Dim tC11_41 = flReg.WriteNumber(C11_41.Text)
            Dim nC11_41 = flReg.WriteNumber(C11_41_Nu.Text)
            Dim tC11_42 = flReg.WriteNumber(C11_42.Text)
            Dim nC11_42 = flReg.WriteNumber(C11_42_Nu.Text)
            Dim tC11_43 = flReg.WriteNumber(C11_43.Text)
            Dim nC11_43 = flReg.WriteNumber(C11_43_Nu.Text)
            Dim tC11_44 = flReg.WriteNumber(C11_44.Text)
            Dim nC11_44 = flReg.WriteNumber(C11_44_Nu.Text)
            Dim tC11_51 = flReg.WriteNumber(C11_51.Text)
            Dim nC11_51 = flReg.WriteNumber(C11_51_Nu.Text)
            Dim tC11_52 = flReg.WriteNumber(C11_52.Text)
            Dim nC11_52 = flReg.WriteNumber(C11_52_Nu.Text)
            Dim tC11_53 = flReg.WriteNumber(C11_53.Text)
            Dim nC11_53 = flReg.WriteNumber(C11_53_Nu.Text)
            Dim tC11_54 = flReg.WriteNumber(C11_54.Text)
            Dim nC11_54 = flReg.WriteNumber(C11_54_Nu.Text)
            Dim tC11_61 = flReg.WriteNumber(C11_61.Text)
            Dim nC11_61 = flReg.WriteNumber(C11_61_Nu.Text)
            Dim tC11_62 = flReg.WriteNumber(C11_62.Text)
            Dim nC11_62 = flReg.WriteNumber(C11_62_Nu.Text)
            Dim tC11_63 = flReg.WriteNumber(C11_63.Text)
            Dim nC11_63 = flReg.WriteNumber(C11_63_Nu.Text)
            Dim tC11_71 = flReg.WriteNumber(C11_71.Text)
            Dim nC11_71 = flReg.WriteNumber(C11_71_Nu.Text)
            Dim tC11_72 = flReg.WriteNumber(C11_72.Text)
            Dim nC11_72 = flReg.WriteNumber(C11_72_Nu.Text)
            Dim tC11_73 = flReg.WriteNumber(C11_73.Text)
            Dim nC11_73 = flReg.WriteNumber(C11_73_Nu.Text)
            Dim tC11_74 = flReg.WriteNumber(C11_74.Text)
            Dim nC11_74 = flReg.WriteNumber(C11_74_Nu.Text)
            Dim tC11_75 = flReg.WriteNumber(C11_75.Text)
            Dim nC11_75 = flReg.WriteNumber(C11_75_Nu.Text)
            Dim tC11_81 = flReg.WriteNumber(C11_81.Text)
            Dim nC11_81 = flReg.WriteNumber(C11_81_Nu.Text)
            Dim tC11_82 = flReg.WriteNumber(C11_82.Text)
            Dim nC11_82 = flReg.WriteNumber(C11_82_Nu.Text)
            Dim tC11_83 = flReg.WriteNumber(C11_83.Text)
            Dim nC11_83 = flReg.WriteNumber(C11_83_Nu.Text)
            Dim tC11_91 = flReg.WriteNumber(C11_91.Text)
            Dim nC11_91 = flReg.WriteNumber(C11_91_Nu.Text)
            Dim tC11_92 = flReg.WriteNumber(C11_92.Text)
            Dim nC11_92 = flReg.WriteNumber(C11_92_Nu.Text)
            Dim tC11_93 = flReg.WriteNumber(C11_93.Text)
            Dim nC11_93 = flReg.WriteNumber(C11_93_Nu.Text)
            Dim tC11_94 = flReg.WriteNumber(C11_94.Text)
            Dim nC11_94 = flReg.WriteNumber(C11_94_Nu.Text)
            Dim tC11_95 = flReg.WriteNumber(C11_95.Text)
            Dim nC11_95 = flReg.WriteNumber(C11_95_Nu.Text)
            Dim tC11_96 = flReg.WriteNumber(C11_96.Text)
            Dim nC11_96 = flReg.WriteNumber(C11_96_Nu.Text)
            If nC11_17 > tC11_17 Then sRes = "Mục 4 - Mã nghề 17."
            If nC11_21 > tC11_21 Then sRes = "Mục 4 - Mã nghề 21."
            If nC11_22 > tC11_22 Then sRes = "Mục 4 - Mã nghề 22."
            If nC11_23 > tC11_23 Then sRes = "Mục 4 - Mã nghề 23."
            If nC11_24 > tC11_24 Then sRes = "Mục 4 - Mã nghề 24."
            If nC11_25 > tC11_25 Then sRes = "Mục 4 - Mã nghề 25."
            If nC11_26 > tC11_26 Then sRes = "Mục 4 - Mã nghề 26."
            If nC11_31 > tC11_31 Then sRes = "Mục 4 - Mã nghề 31."
            If nC11_32 > tC11_32 Then sRes = "Mục 4 - Mã nghề 32."
            If nC11_33 > tC11_33 Then sRes = "Mục 4 - Mã nghề 33."
            If nC11_34 > tC11_34 Then sRes = "Mục 4 - Mã nghề 34."
            If nC11_35 > tC11_35 Then sRes = "Mục 4 - Mã nghề 35."
            If nC11_36 > tC11_36 Then sRes = "Mục 4 - Mã nghề 36."
            If nC11_41 > tC11_41 Then sRes = "Mục 4 - Mã nghề 41."
            If nC11_42 > tC11_42 Then sRes = "Mục 4 - Mã nghề 42."
            If nC11_43 > tC11_43 Then sRes = "Mục 4 - Mã nghề 43."
            If nC11_44 > tC11_44 Then sRes = "Mục 4 - Mã nghề 44."
            If nC11_51 > tC11_51 Then sRes = "Mục 4 - Mã nghề 51."
            If nC11_52 > tC11_52 Then sRes = "Mục 4 - Mã nghề 52."
            If nC11_53 > tC11_53 Then sRes = "Mục 4 - Mã nghề 53."
            If nC11_54 > tC11_54 Then sRes = "Mục 4 - Mã nghề 54."
            If nC11_61 > tC11_61 Then sRes = "Mục 4 - Mã nghề 61."
            If nC11_62 > tC11_62 Then sRes = "Mục 4 - Mã nghề 62."
            If nC11_63 > tC11_63 Then sRes = "Mục 4 - Mã nghề 63."
            If nC11_71 > tC11_71 Then sRes = "Mục 4 - Mã nghề 71."
            If nC11_72 > tC11_72 Then sRes = "Mục 4 - Mã nghề 72."
            If nC11_73 > tC11_73 Then sRes = "Mục 4 - Mã nghề 73."
            If nC11_74 > tC11_74 Then sRes = "Mục 4 - Mã nghề 74."
            If nC11_75 > tC11_75 Then sRes = "Mục 4 - Mã nghề 75."
            If nC11_81 > tC11_81 Then sRes = "Mục 4 - Mã nghề 81."
            If nC11_82 > tC11_82 Then sRes = "Mục 4 - Mã nghề 82."
            If nC11_91 > tC11_91 Then sRes = "Mục 4 - Mã nghề 91."
            If nC11_92 > tC11_92 Then sRes = "Mục 4 - Mã nghề 92."
            If nC11_93 > tC11_93 Then sRes = "Mục 4 - Mã nghề 93."
            If nC11_94 > tC11_94 Then sRes = "Mục 4 - Mã nghề 94."
            If nC11_95 > tC11_95 Then sRes = "Mục 4 - Mã nghề 95."
            If nC11_96 > tC11_96 Then sRes = "Mục 4 - Mã nghề 96."
            Return sRes
        End Function

#End Region
        Private Sub cmdMDN_Click(sender As Object, e As EventArgs) Handles cmdMDN.Click
            Call GenBusCode()
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                Dim validateStr As String = ""

                validateStr = ValidateTSLD()
                If validateStr <> "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('warning', 'Số lượng Nữ không thể lớn hơn Tổng số lượng. {0}', 'Thông báo', false);", validateStr), True)
                    Return
                End If

                validateStr = ValidatePLLD()
                If validateStr <> "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('warning', 'Số lượng Nữ không thể lớn hơn Tổng số lượng. {0}', 'Thông báo', false);", validateStr), True)
                    Return
                End If
                validateStr = ValidateVTVL()
                If validateStr <> "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('warning', 'Số lượng Nữ không thể lớn hơn Tổng số lượng. {0}', 'Thông báo', false);", validateStr), True)
                    Return
                End If

                validateStr = InputValidateMuc4()
                If validateStr <> "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('warning', 'Số lượng Nữ không thể lớn hơn Tổng số lượng. {0}', 'Thông báo', false);", validateStr), True)
                    Return
                End If

                If ItemID.Value = "" Then ItemID.Value = flReg.GenKey()

                obj = New BC_BusinessInfo
                obj.TenDoanhNghiep = flReg.RemoveScript(TenDoanhNghiep.Text)
                obj.TaxCode = flReg.RemoveScript(TaxCode.Text)
                obj.MaDoanhNghiep = flReg.RemoveScript(MaDoanhNghiep.Text)
                obj.Mobile = flReg.RemoveScript(Mobile.Text)
                obj.Fax = flReg.RemoveScript(Fax.Text)
                obj.Email = flReg.RemoveScript(Email.Text)
                obj.Website = flReg.RemoveScript(Website.Text)
                obj.TinhTrang = flReg.WriteNumber(TinhTrang.SelectedValue)
                obj.TinhTP = TinhTP.SelectedValue
                obj.QuanHuyen = 0
                obj.XaPhuong = XaPhuong.SelectedValue
                obj.TT_NT = TT_NT.SelectedValue
                obj.SoNha = flReg.RemoveScript(SoNha.Text)
                obj.KhuCN_ID = KhuCN_ID.SelectedValue
                obj.LoaiHinh_ID = LoaiHinh_ID.SelectedValue
                obj.NganhNghe = flReg.WriteNumber(NganhNghe.SelectedValue)
                obj.LD_TongSo = flReg.WriteNumber(LD_TongSo.Text)
                obj.LD_NgoaiTinh = flReg.WriteNumber(LD_NgoaiTinh.Text)
                obj.LD_TrucTiep = flReg.WriteNumber(LD_TrucTiep.Text)
                obj.LD_Nu = flReg.WriteNumber(LD_Nu.Text)
                obj.LD_HD_Tong = flReg.WriteNumber(LD_HD_Tong.Text)
                obj.LD_HD_Nu = flReg.WriteNumber(LD_HD_Nu.Text)
                obj.LD_NuocNgoai_Tong = flReg.WriteNumber(LD_NuocNgoai_Tong.Text)
                obj.LD_NuocNgoai_Nu = flReg.WriteNumber(LD_NuocNgoai_Nu.Text)
                obj.LD_PhoThong = flReg.WriteNumber(LD_PhoThong.Text)
                obj.CMKT_Khong = flReg.WriteNumber(CMKT_Khong.Text)
                obj.CMKT_BangCap = flReg.WriteNumber(CMKT_BangCap.Text)
                obj.CMKT_DaoTao = flReg.WriteNumber(CMKT_DaoTao.Text)
                obj.CMKT_SoCap = flReg.WriteNumber(CMKT_SoCap.Text)
                obj.CMKT_TrungCap = flReg.WriteNumber(CMKT_TrungCap.Text)
                obj.CMKT_CaoDang = flReg.WriteNumber(CMKT_CaoDang.Text)
                obj.CMKT_DaiHoc = flReg.WriteNumber(CMKT_DaiHoc.Text)
                obj.GDDT_KTXH = flReg.WriteNumber(GDDT_KTXH.Text)
                obj.GDDT_KHTN = flReg.WriteNumber(GDDT_KHTN.Text)
                obj.GDDT_KTCN = flReg.WriteNumber(GDDT_KTCN.Text)
                obj.GDDT_NongNghiep = flReg.WriteNumber(GDDT_NongNghiep.Text)
                obj.GDDT_YTe = flReg.WriteNumber(GDDT_YTe.Text)
                obj.GDDT_Khac = flReg.WriteNumber(GDDT_Khac.Text)
                obj.Nhom_LanhDao = flReg.WriteNumber(Nhom_LanhDao.Text)
                obj.Nhom_ChuyenMon = flReg.WriteNumber(Nhom_ChuyenMon.Text)
                obj.Nhom_TroLy = flReg.WriteNumber(Nhom_TroLy.Text)
                obj.Nhom_DichVu = flReg.WriteNumber(Nhom_DichVu.Text)
                obj.Nhom_NongNghiep = flReg.WriteNumber(Nhom_NongNghiep.Text)
                obj.Nhom_ThuCong = flReg.WriteNumber(Nhom_ThuCong.Text)
                obj.Nhom_Tho = flReg.WriteNumber(Nhom_Tho.Text)
                obj.Nhom_DonGian = flReg.WriteNumber(Nhom_DonGian.Text)
                obj.TL_BinhQuan = flReg.WriteNumber(TL_BinhQuan.Text)
                obj.TL_ThapNhat = flReg.WriteNumber(TL_ThapNhat.Text)
                obj.TL_CaoNhat = flReg.WriteNumber(TL_CaoNhat.Text)
                obj.Chia_Khong = flReg.WriteNumber(Chia_Khong.Text)
                obj.Chia_BangCap = flReg.WriteNumber(Chia_BangCap.Text)
                obj.Chia_DaoTao = flReg.WriteNumber(Chia_DaoTao.Text)
                obj.Chia_SoCap = flReg.WriteNumber(Chia_SoCap.Text)
                obj.Chia_TrungCap = flReg.WriteNumber(Chia_TrungCap.Text)
                obj.Chia_CaoDang = flReg.WriteNumber(Chia_CaoDang.Text)
                obj.Chia_DaiHoc = flReg.WriteNumber(Chia_DaiHoc.Text)
                obj.SanPhamChinh = flReg.RemoveScript(SanPhamChinh.Text.Trim)
                obj.QuyMoLaoDong = flReg.WriteNumber(QuyMoLaoDong.Text)
                obj.LD_NgoaiTinh_Nu = flReg.WriteNumber(LD_NgoaiTinh_Nu.Text)
                obj.LD_TrucTiep_Nu = flReg.WriteNumber(LD_TrucTiep_Nu.Text)
                obj.LD_GianTiep = flReg.WriteNumber(LD_GianTiep.Text)
                obj.LD_GianTiep_Nu = flReg.WriteNumber(LD_GianTiep_Nu.Text)
                obj.LD_BHXH = flReg.WriteNumber(LD_BHXH.Text)
                obj.LD_BHXH_Nu = flReg.WriteNumber(LD_BHXH_Nu.Text)
                obj.LD_TREN35 = flReg.WriteNumber(LD_TREN35.Text)
                obj.LD_TREN35_Nu = flReg.WriteNumber(LD_TREN35_Nu.Text)
                obj.LD_PhoThong_Nu = flReg.WriteNumber(LD_PhoThong_Nu.Text)
                obj.VT_NhaQuanLy = flReg.WriteNumber(VT_NhaQuanLy.Text)
                obj.VT_NhaQuanLy_Nu = flReg.WriteNumber(VT_NhaQuanLy_Nu.Text)
                obj.VT_CMKT_Cao = flReg.WriteNumber(VT_CMKT_Cao.Text)
                obj.VT_CMKT_Cao_Nu = flReg.WriteNumber(VT_CMKT_Cao_Nu.Text)
                obj.VT_CMKT_Trung = flReg.WriteNumber(VT_CMKT_Trung.Text)
                obj.VT_CMKT_Trung_Nu = flReg.WriteNumber(VT_CMKT_Trung_Nu.Text)
                obj.VT_CMKT_Khac = flReg.WriteNumber(VT_CMKT_Khac.Text)
                obj.VT_CMKT_Khac_Nu = flReg.WriteNumber(VT_CMKT_Khac_Nu.Text)
                obj.CMKT_Khong_Nu = flReg.WriteNumber(CMKT_Khong_Nu.Text)
                obj.CMKT_BangCap_Nu = flReg.WriteNumber(CMKT_BangCap_Nu.Text)
                obj.CMKT_DaoTao_Nu = flReg.WriteNumber(CMKT_DaoTao_Nu.Text)
                obj.CMKT_SoCap_Nu = flReg.WriteNumber(CMKT_SoCap_Nu.Text)
                obj.CMKT_TrungCap_Nu = flReg.WriteNumber(CMKT_TrungCap_Nu.Text)
                obj.CMKT_CaoDang_Nu = flReg.WriteNumber(CMKT_CaoDang_Nu.Text)
                obj.CMKT_DaiHoc_Nu = flReg.WriteNumber(CMKT_DaiHoc_Nu.Text)
                obj.GDDT_KTXH_Nu = flReg.WriteNumber(GDDT_KTXH_Nu.Text)
                obj.GDDT_KHTN_Nu = flReg.WriteNumber(GDDT_KHTN_Nu.Text)
                obj.GDDT_KTCN_Nu = flReg.WriteNumber(GDDT_KTCN_Nu.Text)
                obj.GDDT_NongNghiep_Nu = flReg.WriteNumber(GDDT_NongNghiep_Nu.Text)
                obj.GDDT_YTe_Nu = flReg.WriteNumber(GDDT_YTe_Nu.Text)
                obj.GDDT_Khac_Nu = flReg.WriteNumber(GDDT_Khac_Nu.Text)
                obj.C8_17 = flReg.WriteNumber(C8_17.Text)
                obj.C8_21 = flReg.WriteNumber(C8_21.Text)
                obj.C8_22 = flReg.WriteNumber(C8_22.Text)
                obj.C8_23 = flReg.WriteNumber(C8_23.Text)
                obj.C8_24 = flReg.WriteNumber(C8_24.Text)
                obj.C8_25 = flReg.WriteNumber(C8_25.Text)
                obj.C8_26 = flReg.WriteNumber(C8_26.Text)
                obj.C8_31 = flReg.WriteNumber(C8_31.Text)
                obj.C8_32 = flReg.WriteNumber(C8_32.Text)
                obj.C8_33 = flReg.WriteNumber(C8_33.Text)
                obj.C8_34 = flReg.WriteNumber(C8_34.Text)
                obj.C8_35 = flReg.WriteNumber(C8_35.Text)
                obj.C8_36 = flReg.WriteNumber(C8_36.Text)
                obj.C8_41 = flReg.WriteNumber(C8_41.Text)
                obj.C8_42 = flReg.WriteNumber(C8_42.Text)
                obj.C8_43 = flReg.WriteNumber(C8_43.Text)
                obj.C8_44 = flReg.WriteNumber(C8_44.Text)
                obj.C8_51 = flReg.WriteNumber(C8_51.Text)
                obj.C8_52 = flReg.WriteNumber(C8_52.Text)
                obj.C8_53 = flReg.WriteNumber(C8_53.Text)
                obj.C8_54 = flReg.WriteNumber(C8_54.Text)
                obj.C8_61 = flReg.WriteNumber(C8_61.Text)
                obj.C8_62 = flReg.WriteNumber(C8_62.Text)
                obj.C8_63 = flReg.WriteNumber(C8_63.Text)
                obj.C8_71 = flReg.WriteNumber(C8_71.Text)
                obj.C8_72 = flReg.WriteNumber(C8_72.Text)
                obj.C8_73 = flReg.WriteNumber(C8_73.Text)
                obj.C8_74 = flReg.WriteNumber(C8_74.Text)
                obj.C8_75 = flReg.WriteNumber(C8_75.Text)
                obj.C8_81 = flReg.WriteNumber(C8_81.Text)
                obj.C8_82 = flReg.WriteNumber(C8_82.Text)
                obj.C8_83 = flReg.WriteNumber(C8_83.Text)
                obj.C8_91 = flReg.WriteNumber(C8_91.Text)
                obj.C8_92 = flReg.WriteNumber(C8_92.Text)
                obj.C8_93 = flReg.WriteNumber(C8_93.Text)
                obj.C8_94 = flReg.WriteNumber(C8_94.Text)
                obj.C8_95 = flReg.WriteNumber(C8_95.Text)
                obj.C8_96 = flReg.WriteNumber(C8_96.Text)
                obj.C8_17_Nu = flReg.WriteNumber(C8_17_Nu.Text)
                obj.C8_21_Nu = flReg.WriteNumber(C8_21_Nu.Text)
                obj.C8_22_Nu = flReg.WriteNumber(C8_22_Nu.Text)
                obj.C8_23_Nu = flReg.WriteNumber(C8_23_Nu.Text)
                obj.C8_24_Nu = flReg.WriteNumber(C8_24_Nu.Text)
                obj.C8_25_Nu = flReg.WriteNumber(C8_25_Nu.Text)
                obj.C8_26_Nu = flReg.WriteNumber(C8_26_Nu.Text)
                obj.C8_31_Nu = flReg.WriteNumber(C8_31_Nu.Text)
                obj.C8_32_Nu = flReg.WriteNumber(C8_32_Nu.Text)
                obj.C8_33_Nu = flReg.WriteNumber(C8_33_Nu.Text)
                obj.C8_34_Nu = flReg.WriteNumber(C8_34_Nu.Text)
                obj.C8_35_Nu = flReg.WriteNumber(C8_35_Nu.Text)
                obj.C8_36_Nu = flReg.WriteNumber(C8_36_Nu.Text)
                obj.C8_41_Nu = flReg.WriteNumber(C8_41_Nu.Text)
                obj.C8_42_Nu = flReg.WriteNumber(C8_42_Nu.Text)
                obj.C8_43_Nu = flReg.WriteNumber(C8_43_Nu.Text)
                obj.C8_44_Nu = flReg.WriteNumber(C8_44_Nu.Text)
                obj.C8_51_Nu = flReg.WriteNumber(C8_51_Nu.Text)
                obj.C8_52_Nu = flReg.WriteNumber(C8_52_Nu.Text)
                obj.C8_53_Nu = flReg.WriteNumber(C8_53_Nu.Text)
                obj.C8_54_Nu = flReg.WriteNumber(C8_54_Nu.Text)
                obj.C8_61_Nu = flReg.WriteNumber(C8_61_Nu.Text)
                obj.C8_62_Nu = flReg.WriteNumber(C8_62_Nu.Text)
                obj.C8_63_Nu = flReg.WriteNumber(C8_63_Nu.Text)
                obj.C8_71_Nu = flReg.WriteNumber(C8_71_Nu.Text)
                obj.C8_72_Nu = flReg.WriteNumber(C8_72_Nu.Text)
                obj.C8_73_Nu = flReg.WriteNumber(C8_73_Nu.Text)
                obj.C8_74_Nu = flReg.WriteNumber(C8_74_Nu.Text)
                obj.C8_75_Nu = flReg.WriteNumber(C8_75_Nu.Text)
                obj.C8_81_Nu = flReg.WriteNumber(C8_81_Nu.Text)
                obj.C8_82_Nu = flReg.WriteNumber(C8_82_Nu.Text)
                obj.C8_83_Nu = flReg.WriteNumber(C8_83_Nu.Text)
                obj.C8_91_Nu = flReg.WriteNumber(C8_91_Nu.Text)
                obj.C8_92_Nu = flReg.WriteNumber(C8_92_Nu.Text)
                obj.C8_93_Nu = flReg.WriteNumber(C8_93_Nu.Text)
                obj.C8_94_Nu = flReg.WriteNumber(C8_94_Nu.Text)
                obj.C8_95_Nu = flReg.WriteNumber(C8_95_Nu.Text)
                obj.C8_96_Nu = flReg.WriteNumber(C8_96_Nu.Text)
                obj.C11_17 = flReg.WriteNumber(C11_17.Text)
                obj.C11_21 = flReg.WriteNumber(C11_21.Text)
                obj.C11_22 = flReg.WriteNumber(C11_22.Text)
                obj.C11_23 = flReg.WriteNumber(C11_23.Text)
                obj.C11_24 = flReg.WriteNumber(C11_24.Text)
                obj.C11_25 = flReg.WriteNumber(C11_25.Text)
                obj.C11_26 = flReg.WriteNumber(C11_26.Text)
                obj.C11_31 = flReg.WriteNumber(C11_31.Text)
                obj.C11_32 = flReg.WriteNumber(C11_32.Text)
                obj.C11_33 = flReg.WriteNumber(C11_33.Text)
                obj.C11_34 = flReg.WriteNumber(C11_34.Text)
                obj.C11_35 = flReg.WriteNumber(C11_35.Text)
                obj.C11_36 = flReg.WriteNumber(C11_36.Text)
                obj.C11_41 = flReg.WriteNumber(C11_41.Text)
                obj.C11_42 = flReg.WriteNumber(C11_42.Text)
                obj.C11_43 = flReg.WriteNumber(C11_43.Text)
                obj.C11_44 = flReg.WriteNumber(C11_44.Text)
                obj.C11_51 = flReg.WriteNumber(C11_51.Text)
                obj.C11_52 = flReg.WriteNumber(C11_52.Text)
                obj.C11_53 = flReg.WriteNumber(C11_53.Text)
                obj.C11_54 = flReg.WriteNumber(C11_54.Text)
                obj.C11_61 = flReg.WriteNumber(C11_61.Text)
                obj.C11_62 = flReg.WriteNumber(C11_62.Text)
                obj.C11_63 = flReg.WriteNumber(C11_63.Text)
                obj.C11_71 = flReg.WriteNumber(C11_71.Text)
                obj.C11_72 = flReg.WriteNumber(C11_72.Text)
                obj.C11_73 = flReg.WriteNumber(C11_73.Text)
                obj.C11_74 = flReg.WriteNumber(C11_74.Text)
                obj.C11_75 = flReg.WriteNumber(C11_75.Text)
                obj.C11_81 = flReg.WriteNumber(C11_81.Text)
                obj.C11_82 = flReg.WriteNumber(C11_82.Text)
                obj.C11_83 = flReg.WriteNumber(C11_83.Text)
                obj.C11_91 = flReg.WriteNumber(C11_91.Text)
                obj.C11_92 = flReg.WriteNumber(C11_92.Text)
                obj.C11_93 = flReg.WriteNumber(C11_93.Text)
                obj.C11_94 = flReg.WriteNumber(C11_94.Text)
                obj.C11_95 = flReg.WriteNumber(C11_95.Text)
                obj.C11_96 = flReg.WriteNumber(C11_96.Text)
                obj.C11_17_Nu = flReg.WriteNumber(C11_17_Nu.Text)
                obj.C11_21_Nu = flReg.WriteNumber(C11_21_Nu.Text)
                obj.C11_22_Nu = flReg.WriteNumber(C11_22_Nu.Text)
                obj.C11_23_Nu = flReg.WriteNumber(C11_23_Nu.Text)
                obj.C11_24_Nu = flReg.WriteNumber(C11_24_Nu.Text)
                obj.C11_25_Nu = flReg.WriteNumber(C11_25_Nu.Text)
                obj.C11_26_Nu = flReg.WriteNumber(C11_26_Nu.Text)
                obj.C11_31_Nu = flReg.WriteNumber(C11_31_Nu.Text)
                obj.C11_32_Nu = flReg.WriteNumber(C11_32_Nu.Text)
                obj.C11_33_Nu = flReg.WriteNumber(C11_33_Nu.Text)
                obj.C11_34_Nu = flReg.WriteNumber(C11_34_Nu.Text)
                obj.C11_35_Nu = flReg.WriteNumber(C11_35_Nu.Text)
                obj.C11_36_Nu = flReg.WriteNumber(C11_36_Nu.Text)
                obj.C11_41_Nu = flReg.WriteNumber(C11_41_Nu.Text)
                obj.C11_42_Nu = flReg.WriteNumber(C11_42_Nu.Text)
                obj.C11_43_Nu = flReg.WriteNumber(C11_43_Nu.Text)
                obj.C11_44_Nu = flReg.WriteNumber(C11_44_Nu.Text)
                obj.C11_51_Nu = flReg.WriteNumber(C11_51_Nu.Text)
                obj.C11_52_Nu = flReg.WriteNumber(C11_52_Nu.Text)
                obj.C11_53_Nu = flReg.WriteNumber(C11_53_Nu.Text)
                obj.C11_54_Nu = flReg.WriteNumber(C11_54_Nu.Text)
                obj.C11_61_Nu = flReg.WriteNumber(C11_61_Nu.Text)
                obj.C11_62_Nu = flReg.WriteNumber(C11_62_Nu.Text)
                obj.C11_63_Nu = flReg.WriteNumber(C11_63_Nu.Text)
                obj.C11_71_Nu = flReg.WriteNumber(C11_71_Nu.Text)
                obj.C11_72_Nu = flReg.WriteNumber(C11_72_Nu.Text)
                obj.C11_73_Nu = flReg.WriteNumber(C11_73_Nu.Text)
                obj.C11_74_Nu = flReg.WriteNumber(C11_74_Nu.Text)
                obj.C11_75_Nu = flReg.WriteNumber(C11_75_Nu.Text)
                obj.C11_81_Nu = flReg.WriteNumber(C11_81_Nu.Text)
                obj.C11_82_Nu = flReg.WriteNumber(C11_82_Nu.Text)
                obj.C11_83_Nu = flReg.WriteNumber(C11_83_Nu.Text)
                obj.C11_91_Nu = flReg.WriteNumber(C11_91_Nu.Text)
                obj.C11_92_Nu = flReg.WriteNumber(C11_92_Nu.Text)
                obj.C11_93_Nu = flReg.WriteNumber(C11_93_Nu.Text)
                obj.C11_94_Nu = flReg.WriteNumber(C11_94_Nu.Text)
                obj.C11_95_Nu = flReg.WriteNumber(C11_95_Nu.Text)
                obj.C11_96_Nu = flReg.WriteNumber(C11_96_Nu.Text)
                obj.C10_LaoDong = flReg.WriteNumber(C10_LaoDong.Text)
                obj.Chia_Khong_Nu = flReg.WriteNumber(Chia_Khong_Nu.Text)
                obj.Chia_BangCap_Nu = flReg.WriteNumber(Chia_BangCap_Nu.Text)
                obj.Chia_DaoTao_Nu = flReg.WriteNumber(Chia_DaoTao_Nu.Text)
                obj.Chia_SoCap_Nu = flReg.WriteNumber(Chia_SoCap_Nu.Text)
                obj.Chia_TrungCap_Nu = flReg.WriteNumber(Chia_TrungCap_Nu.Text)
                obj.Chia_CaoDang_Nu = flReg.WriteNumber(Chia_CaoDang_Nu.Text)
                obj.Chia_DaiHoc_Nu = flReg.WriteNumber(Chia_DaiHoc_Nu.Text)

                obj.PortalId = Me.PortalId
                obj.DoanhNghiep_ID = ItemID.Value

                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                obj.UpdatedDate = Now
                obj.UpdatedUser = Me.UserInfo.Username

                objController.BC_Business_Add(Me.PortalId, obj)
                Dim objSend = objController.BC_SendMail_Send_Years(Me.PortalId, TinhTP.SelectedValue, Me.PortalId)

                If IsNothing(objSend) = False Then
                    Call objController.BC_Business_Update_Tbao(Me.PortalId, obj.DoanhNghiep_ID, objSend.FromDate, objSend.ToDate)
                    Call SaveBusForWork(obj)
                    Call LoadValue()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã cập nhật thông tin doanh nghiệp thành công.', 'Thông báo', false);", True)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('info', 'Bạn cần tạo kỳ dữ liệu trước khi cập nhật.', 'Thông báo', false);", True)
                End If

            Catch ex As Exception
                litUpdate.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdUpdateClose_Click(sender As Object, e As EventArgs) Handles cmdUpdateClose.Click
            Try
                Dim validateStr As String = ""

                validateStr = ValidateTSLD()
                If validateStr <> "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('warning', 'Số lượng Nữ không thể lớn hơn Tổng số lượng. {0}', 'Thông báo', false);", validateStr), True)
                    Return
                End If

                validateStr = ValidatePLLD()
                If validateStr <> "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('warning', 'Số lượng Nữ không thể lớn hơn Tổng số lượng. {0}', 'Thông báo', false);", validateStr), True)
                    Return
                End If
                validateStr = ValidateVTVL()
                If validateStr <> "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('warning', 'Số lượng Nữ không thể lớn hơn Tổng số lượng. {0}', 'Thông báo', false);", validateStr), True)
                    Return
                End If

                validateStr = InputValidateMuc4()
                If validateStr <> "" Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('warning', 'Số lượng Nữ không thể lớn hơn Tổng số lượng. {0}', 'Thông báo', false);", validateStr), True)
                    Return
                End If
                If ItemID.Value = "" Then ItemID.Value = flReg.GenKey()

                obj = New BC_BusinessInfo
                obj.TenDoanhNghiep = flReg.RemoveScript(TenDoanhNghiep.Text)
                obj.TaxCode = TaxCode.Text
                obj.MaDoanhNghiep = MaDoanhNghiep.Text
                obj.Mobile = Mobile.Text
                obj.Fax = Fax.Text
                obj.Email = Email.Text
                obj.Website = Website.Text
                obj.TinhTrang = flReg.WriteNumber(TinhTrang.SelectedValue)
                obj.TinhTP = TinhTP.SelectedValue
                obj.QuanHuyen = 0
                obj.XaPhuong = XaPhuong.SelectedValue
                obj.TT_NT = TT_NT.SelectedValue
                obj.SoNha = SoNha.Text
                obj.KhuCN_ID = KhuCN_ID.SelectedValue
                obj.LoaiHinh_ID = LoaiHinh_ID.SelectedValue
                obj.NganhNghe = flReg.WriteNumber(NganhNghe.SelectedValue)
                obj.LD_TongSo = flReg.WriteNumber(LD_TongSo.Text)
                obj.LD_NgoaiTinh = flReg.WriteNumber(LD_NgoaiTinh.Text)
                obj.LD_TrucTiep = flReg.WriteNumber(LD_TrucTiep.Text)
                obj.LD_Nu = flReg.WriteNumber(LD_Nu.Text)
                obj.LD_HD_Tong = flReg.WriteNumber(LD_HD_Tong.Text)
                obj.LD_HD_Nu = flReg.WriteNumber(LD_HD_Nu.Text)
                obj.LD_NuocNgoai_Tong = flReg.WriteNumber(LD_NuocNgoai_Tong.Text)
                obj.LD_NuocNgoai_Nu = flReg.WriteNumber(LD_NuocNgoai_Nu.Text)
                obj.LD_PhoThong = flReg.WriteNumber(LD_PhoThong.Text)
                obj.CMKT_Khong = flReg.WriteNumber(CMKT_Khong.Text)
                obj.CMKT_BangCap = flReg.WriteNumber(CMKT_BangCap.Text)
                obj.CMKT_DaoTao = flReg.WriteNumber(CMKT_DaoTao.Text)
                obj.CMKT_SoCap = flReg.WriteNumber(CMKT_SoCap.Text)
                obj.CMKT_TrungCap = flReg.WriteNumber(CMKT_TrungCap.Text)
                obj.CMKT_CaoDang = flReg.WriteNumber(CMKT_CaoDang.Text)
                obj.CMKT_DaiHoc = flReg.WriteNumber(CMKT_DaiHoc.Text)
                obj.GDDT_KTXH = flReg.WriteNumber(GDDT_KTXH.Text)
                obj.GDDT_KHTN = flReg.WriteNumber(GDDT_KHTN.Text)
                obj.GDDT_KTCN = flReg.WriteNumber(GDDT_KTCN.Text)
                obj.GDDT_NongNghiep = flReg.WriteNumber(GDDT_NongNghiep.Text)
                obj.GDDT_YTe = flReg.WriteNumber(GDDT_YTe.Text)
                obj.GDDT_Khac = flReg.WriteNumber(GDDT_Khac.Text)
                obj.Nhom_LanhDao = flReg.WriteNumber(Nhom_LanhDao.Text)
                obj.Nhom_ChuyenMon = flReg.WriteNumber(Nhom_ChuyenMon.Text)
                obj.Nhom_TroLy = flReg.WriteNumber(Nhom_TroLy.Text)
                obj.Nhom_DichVu = flReg.WriteNumber(Nhom_DichVu.Text)
                obj.Nhom_NongNghiep = flReg.WriteNumber(Nhom_NongNghiep.Text)
                obj.Nhom_ThuCong = flReg.WriteNumber(Nhom_ThuCong.Text)
                obj.Nhom_Tho = flReg.WriteNumber(Nhom_Tho.Text)
                obj.Nhom_DonGian = flReg.WriteNumber(Nhom_DonGian.Text)
                obj.TL_BinhQuan = flReg.WriteNumber(TL_BinhQuan.Text)
                obj.TL_ThapNhat = flReg.WriteNumber(TL_ThapNhat.Text)
                obj.TL_CaoNhat = flReg.WriteNumber(TL_CaoNhat.Text)
                obj.Chia_Khong = flReg.WriteNumber(Chia_Khong.Text)
                obj.Chia_BangCap = flReg.WriteNumber(Chia_BangCap.Text)
                obj.Chia_DaoTao = flReg.WriteNumber(Chia_DaoTao.Text)
                obj.Chia_SoCap = flReg.WriteNumber(Chia_SoCap.Text)
                obj.Chia_TrungCap = flReg.WriteNumber(Chia_TrungCap.Text)
                obj.Chia_CaoDang = flReg.WriteNumber(Chia_CaoDang.Text)
                obj.Chia_DaiHoc = flReg.WriteNumber(Chia_DaiHoc.Text)
                obj.SanPhamChinh = SanPhamChinh.Text.Trim
                obj.QuyMoLaoDong = flReg.WriteNumber(QuyMoLaoDong.Text)
                obj.LD_NgoaiTinh_Nu = flReg.WriteNumber(LD_NgoaiTinh_Nu.Text)
                obj.LD_TrucTiep_Nu = flReg.WriteNumber(LD_TrucTiep_Nu.Text)
                obj.LD_GianTiep = flReg.WriteNumber(LD_GianTiep.Text)
                obj.LD_GianTiep_Nu = flReg.WriteNumber(LD_GianTiep_Nu.Text)
                obj.LD_BHXH = flReg.WriteNumber(LD_BHXH.Text)
                obj.LD_BHXH_Nu = flReg.WriteNumber(LD_BHXH_Nu.Text)
                obj.LD_TREN35 = flReg.WriteNumber(LD_TREN35.Text)
                obj.LD_TREN35_Nu = flReg.WriteNumber(LD_TREN35_Nu.Text)
                obj.LD_PhoThong_Nu = flReg.WriteNumber(LD_PhoThong_Nu.Text)
                obj.VT_NhaQuanLy = flReg.WriteNumber(VT_NhaQuanLy.Text)
                obj.VT_NhaQuanLy_Nu = flReg.WriteNumber(VT_NhaQuanLy_Nu.Text)
                obj.VT_CMKT_Cao = flReg.WriteNumber(VT_CMKT_Cao.Text)
                obj.VT_CMKT_Cao_Nu = flReg.WriteNumber(VT_CMKT_Cao_Nu.Text)
                obj.VT_CMKT_Trung = flReg.WriteNumber(VT_CMKT_Trung.Text)
                obj.VT_CMKT_Trung_Nu = flReg.WriteNumber(VT_CMKT_Trung_Nu.Text)
                obj.VT_CMKT_Khac = flReg.WriteNumber(VT_CMKT_Khac.Text)
                obj.VT_CMKT_Khac_Nu = flReg.WriteNumber(VT_CMKT_Khac_Nu.Text)
                obj.CMKT_Khong_Nu = flReg.WriteNumber(CMKT_Khong_Nu.Text)
                obj.CMKT_BangCap_Nu = flReg.WriteNumber(CMKT_BangCap_Nu.Text)
                obj.CMKT_DaoTao_Nu = flReg.WriteNumber(CMKT_DaoTao_Nu.Text)
                obj.CMKT_SoCap_Nu = flReg.WriteNumber(CMKT_SoCap_Nu.Text)
                obj.CMKT_TrungCap_Nu = flReg.WriteNumber(CMKT_TrungCap_Nu.Text)
                obj.CMKT_CaoDang_Nu = flReg.WriteNumber(CMKT_CaoDang_Nu.Text)
                obj.CMKT_DaiHoc_Nu = flReg.WriteNumber(CMKT_DaiHoc_Nu.Text)
                obj.GDDT_KTXH_Nu = flReg.WriteNumber(GDDT_KTXH_Nu.Text)
                obj.GDDT_KHTN_Nu = flReg.WriteNumber(GDDT_KHTN_Nu.Text)
                obj.GDDT_KTCN_Nu = flReg.WriteNumber(GDDT_KTCN_Nu.Text)
                obj.GDDT_NongNghiep_Nu = flReg.WriteNumber(GDDT_NongNghiep_Nu.Text)
                obj.GDDT_YTe_Nu = flReg.WriteNumber(GDDT_YTe_Nu.Text)
                obj.GDDT_Khac_Nu = flReg.WriteNumber(GDDT_Khac_Nu.Text)
                obj.C8_17 = flReg.WriteNumber(C8_17.Text)
                obj.C8_21 = flReg.WriteNumber(C8_21.Text)
                obj.C8_22 = flReg.WriteNumber(C8_22.Text)
                obj.C8_23 = flReg.WriteNumber(C8_23.Text)
                obj.C8_24 = flReg.WriteNumber(C8_24.Text)
                obj.C8_25 = flReg.WriteNumber(C8_25.Text)
                obj.C8_26 = flReg.WriteNumber(C8_26.Text)
                obj.C8_31 = flReg.WriteNumber(C8_31.Text)
                obj.C8_32 = flReg.WriteNumber(C8_32.Text)
                obj.C8_33 = flReg.WriteNumber(C8_33.Text)
                obj.C8_34 = flReg.WriteNumber(C8_34.Text)
                obj.C8_35 = flReg.WriteNumber(C8_35.Text)
                obj.C8_36 = flReg.WriteNumber(C8_36.Text)
                obj.C8_41 = flReg.WriteNumber(C8_41.Text)
                obj.C8_42 = flReg.WriteNumber(C8_42.Text)
                obj.C8_43 = flReg.WriteNumber(C8_43.Text)
                obj.C8_44 = flReg.WriteNumber(C8_44.Text)
                obj.C8_51 = flReg.WriteNumber(C8_51.Text)
                obj.C8_52 = flReg.WriteNumber(C8_52.Text)
                obj.C8_53 = flReg.WriteNumber(C8_53.Text)
                obj.C8_54 = flReg.WriteNumber(C8_54.Text)
                obj.C8_61 = flReg.WriteNumber(C8_61.Text)
                obj.C8_62 = flReg.WriteNumber(C8_62.Text)
                obj.C8_63 = flReg.WriteNumber(C8_63.Text)
                obj.C8_71 = flReg.WriteNumber(C8_71.Text)
                obj.C8_72 = flReg.WriteNumber(C8_72.Text)
                obj.C8_73 = flReg.WriteNumber(C8_73.Text)
                obj.C8_74 = flReg.WriteNumber(C8_74.Text)
                obj.C8_75 = flReg.WriteNumber(C8_75.Text)
                obj.C8_81 = flReg.WriteNumber(C8_81.Text)
                obj.C8_82 = flReg.WriteNumber(C8_82.Text)
                obj.C8_83 = flReg.WriteNumber(C8_83.Text)
                obj.C8_91 = flReg.WriteNumber(C8_91.Text)
                obj.C8_92 = flReg.WriteNumber(C8_92.Text)
                obj.C8_93 = flReg.WriteNumber(C8_93.Text)
                obj.C8_94 = flReg.WriteNumber(C8_94.Text)
                obj.C8_95 = flReg.WriteNumber(C8_95.Text)
                obj.C8_96 = flReg.WriteNumber(C8_96.Text)
                obj.C8_17_Nu = flReg.WriteNumber(C8_17_Nu.Text)
                obj.C8_21_Nu = flReg.WriteNumber(C8_21_Nu.Text)
                obj.C8_22_Nu = flReg.WriteNumber(C8_22_Nu.Text)
                obj.C8_23_Nu = flReg.WriteNumber(C8_23_Nu.Text)
                obj.C8_24_Nu = flReg.WriteNumber(C8_24_Nu.Text)
                obj.C8_25_Nu = flReg.WriteNumber(C8_25_Nu.Text)
                obj.C8_26_Nu = flReg.WriteNumber(C8_26_Nu.Text)
                obj.C8_31_Nu = flReg.WriteNumber(C8_31_Nu.Text)
                obj.C8_32_Nu = flReg.WriteNumber(C8_32_Nu.Text)
                obj.C8_33_Nu = flReg.WriteNumber(C8_33_Nu.Text)
                obj.C8_34_Nu = flReg.WriteNumber(C8_34_Nu.Text)
                obj.C8_35_Nu = flReg.WriteNumber(C8_35_Nu.Text)
                obj.C8_36_Nu = flReg.WriteNumber(C8_36_Nu.Text)
                obj.C8_41_Nu = flReg.WriteNumber(C8_41_Nu.Text)
                obj.C8_42_Nu = flReg.WriteNumber(C8_42_Nu.Text)
                obj.C8_43_Nu = flReg.WriteNumber(C8_43_Nu.Text)
                obj.C8_44_Nu = flReg.WriteNumber(C8_44_Nu.Text)
                obj.C8_51_Nu = flReg.WriteNumber(C8_51_Nu.Text)
                obj.C8_52_Nu = flReg.WriteNumber(C8_52_Nu.Text)
                obj.C8_53_Nu = flReg.WriteNumber(C8_53_Nu.Text)
                obj.C8_54_Nu = flReg.WriteNumber(C8_54_Nu.Text)
                obj.C8_61_Nu = flReg.WriteNumber(C8_61_Nu.Text)
                obj.C8_62_Nu = flReg.WriteNumber(C8_62_Nu.Text)
                obj.C8_63_Nu = flReg.WriteNumber(C8_63_Nu.Text)
                obj.C8_71_Nu = flReg.WriteNumber(C8_71_Nu.Text)
                obj.C8_72_Nu = flReg.WriteNumber(C8_72_Nu.Text)
                obj.C8_73_Nu = flReg.WriteNumber(C8_73_Nu.Text)
                obj.C8_74_Nu = flReg.WriteNumber(C8_74_Nu.Text)
                obj.C8_75_Nu = flReg.WriteNumber(C8_75_Nu.Text)
                obj.C8_81_Nu = flReg.WriteNumber(C8_81_Nu.Text)
                obj.C8_82_Nu = flReg.WriteNumber(C8_82_Nu.Text)
                obj.C8_83_Nu = flReg.WriteNumber(C8_83_Nu.Text)
                obj.C8_91_Nu = flReg.WriteNumber(C8_91_Nu.Text)
                obj.C8_92_Nu = flReg.WriteNumber(C8_92_Nu.Text)
                obj.C8_93_Nu = flReg.WriteNumber(C8_93_Nu.Text)
                obj.C8_94_Nu = flReg.WriteNumber(C8_94_Nu.Text)
                obj.C8_95_Nu = flReg.WriteNumber(C8_95_Nu.Text)
                obj.C8_96_Nu = flReg.WriteNumber(C8_96_Nu.Text)
                obj.C11_17 = flReg.WriteNumber(C11_17.Text)
                obj.C11_21 = flReg.WriteNumber(C11_21.Text)
                obj.C11_22 = flReg.WriteNumber(C11_22.Text)
                obj.C11_23 = flReg.WriteNumber(C11_23.Text)
                obj.C11_24 = flReg.WriteNumber(C11_24.Text)
                obj.C11_25 = flReg.WriteNumber(C11_25.Text)
                obj.C11_26 = flReg.WriteNumber(C11_26.Text)
                obj.C11_31 = flReg.WriteNumber(C11_31.Text)
                obj.C11_32 = flReg.WriteNumber(C11_32.Text)
                obj.C11_33 = flReg.WriteNumber(C11_33.Text)
                obj.C11_34 = flReg.WriteNumber(C11_34.Text)
                obj.C11_35 = flReg.WriteNumber(C11_35.Text)
                obj.C11_36 = flReg.WriteNumber(C11_36.Text)
                obj.C11_41 = flReg.WriteNumber(C11_41.Text)
                obj.C11_42 = flReg.WriteNumber(C11_42.Text)
                obj.C11_43 = flReg.WriteNumber(C11_43.Text)
                obj.C11_44 = flReg.WriteNumber(C11_44.Text)
                obj.C11_51 = flReg.WriteNumber(C11_51.Text)
                obj.C11_52 = flReg.WriteNumber(C11_52.Text)
                obj.C11_53 = flReg.WriteNumber(C11_53.Text)
                obj.C11_54 = flReg.WriteNumber(C11_54.Text)
                obj.C11_61 = flReg.WriteNumber(C11_61.Text)
                obj.C11_62 = flReg.WriteNumber(C11_62.Text)
                obj.C11_63 = flReg.WriteNumber(C11_63.Text)
                obj.C11_71 = flReg.WriteNumber(C11_71.Text)
                obj.C11_72 = flReg.WriteNumber(C11_72.Text)
                obj.C11_73 = flReg.WriteNumber(C11_73.Text)
                obj.C11_74 = flReg.WriteNumber(C11_74.Text)
                obj.C11_75 = flReg.WriteNumber(C11_75.Text)
                obj.C11_81 = flReg.WriteNumber(C11_81.Text)
                obj.C11_82 = flReg.WriteNumber(C11_82.Text)
                obj.C11_83 = flReg.WriteNumber(C11_83.Text)
                obj.C11_91 = flReg.WriteNumber(C11_91.Text)
                obj.C11_92 = flReg.WriteNumber(C11_92.Text)
                obj.C11_93 = flReg.WriteNumber(C11_93.Text)
                obj.C11_94 = flReg.WriteNumber(C11_94.Text)
                obj.C11_95 = flReg.WriteNumber(C11_95.Text)
                obj.C11_96 = flReg.WriteNumber(C11_96.Text)
                obj.C11_17_Nu = flReg.WriteNumber(C11_17_Nu.Text)
                obj.C11_21_Nu = flReg.WriteNumber(C11_21_Nu.Text)
                obj.C11_22_Nu = flReg.WriteNumber(C11_22_Nu.Text)
                obj.C11_23_Nu = flReg.WriteNumber(C11_23_Nu.Text)
                obj.C11_24_Nu = flReg.WriteNumber(C11_24_Nu.Text)
                obj.C11_25_Nu = flReg.WriteNumber(C11_25_Nu.Text)
                obj.C11_26_Nu = flReg.WriteNumber(C11_26_Nu.Text)
                obj.C11_31_Nu = flReg.WriteNumber(C11_31_Nu.Text)
                obj.C11_32_Nu = flReg.WriteNumber(C11_32_Nu.Text)
                obj.C11_33_Nu = flReg.WriteNumber(C11_33_Nu.Text)
                obj.C11_34_Nu = flReg.WriteNumber(C11_34_Nu.Text)
                obj.C11_35_Nu = flReg.WriteNumber(C11_35_Nu.Text)
                obj.C11_36_Nu = flReg.WriteNumber(C11_36_Nu.Text)
                obj.C11_41_Nu = flReg.WriteNumber(C11_41_Nu.Text)
                obj.C11_42_Nu = flReg.WriteNumber(C11_42_Nu.Text)
                obj.C11_43_Nu = flReg.WriteNumber(C11_43_Nu.Text)
                obj.C11_44_Nu = flReg.WriteNumber(C11_44_Nu.Text)
                obj.C11_51_Nu = flReg.WriteNumber(C11_51_Nu.Text)
                obj.C11_52_Nu = flReg.WriteNumber(C11_52_Nu.Text)
                obj.C11_53_Nu = flReg.WriteNumber(C11_53_Nu.Text)
                obj.C11_54_Nu = flReg.WriteNumber(C11_54_Nu.Text)
                obj.C11_61_Nu = flReg.WriteNumber(C11_61_Nu.Text)
                obj.C11_62_Nu = flReg.WriteNumber(C11_62_Nu.Text)
                obj.C11_63_Nu = flReg.WriteNumber(C11_63_Nu.Text)
                obj.C11_71_Nu = flReg.WriteNumber(C11_71_Nu.Text)
                obj.C11_72_Nu = flReg.WriteNumber(C11_72_Nu.Text)
                obj.C11_73_Nu = flReg.WriteNumber(C11_73_Nu.Text)
                obj.C11_74_Nu = flReg.WriteNumber(C11_74_Nu.Text)
                obj.C11_75_Nu = flReg.WriteNumber(C11_75_Nu.Text)
                obj.C11_81_Nu = flReg.WriteNumber(C11_81_Nu.Text)
                obj.C11_82_Nu = flReg.WriteNumber(C11_82_Nu.Text)
                obj.C11_83_Nu = flReg.WriteNumber(C11_83_Nu.Text)
                obj.C11_91_Nu = flReg.WriteNumber(C11_91_Nu.Text)
                obj.C11_92_Nu = flReg.WriteNumber(C11_92_Nu.Text)
                obj.C11_93_Nu = flReg.WriteNumber(C11_93_Nu.Text)
                obj.C11_94_Nu = flReg.WriteNumber(C11_94_Nu.Text)
                obj.C11_95_Nu = flReg.WriteNumber(C11_95_Nu.Text)
                obj.C11_96_Nu = flReg.WriteNumber(C11_96_Nu.Text)
                obj.C10_LaoDong = flReg.WriteNumber(C10_LaoDong.Text)
                obj.Chia_Khong_Nu = flReg.WriteNumber(Chia_Khong_Nu.Text)
                obj.Chia_BangCap_Nu = flReg.WriteNumber(Chia_BangCap_Nu.Text)
                obj.Chia_DaoTao_Nu = flReg.WriteNumber(Chia_DaoTao_Nu.Text)
                obj.Chia_SoCap_Nu = flReg.WriteNumber(Chia_SoCap_Nu.Text)
                obj.Chia_TrungCap_Nu = flReg.WriteNumber(Chia_TrungCap_Nu.Text)
                obj.Chia_CaoDang_Nu = flReg.WriteNumber(Chia_CaoDang_Nu.Text)
                obj.Chia_DaiHoc_Nu = flReg.WriteNumber(Chia_DaiHoc_Nu.Text)

                obj.PortalId = Me.PortalId
                obj.DoanhNghiep_ID = ItemID.Value

                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                obj.UpdatedDate = Now
                obj.UpdatedUser = Me.UserInfo.Username

                objController.BC_Business_Add(Me.PortalId, obj)
                Dim objSend = objController.BC_SendMail_Send_Years(Me.PortalId, TinhTP.SelectedValue, Me.PortalId)

                If IsNothing(objSend) = False Then
                    Call objController.BC_Business_Update_Tbao(Me.PortalId, obj.DoanhNghiep_ID, objSend.FromDate, objSend.ToDate)
                    'Call SaveBusForWork(obj)
                    Call LoadValue()
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", String.Format("removewaiting();notify('success', 'Đã cập nhật thông tin doanh nghiệp thành công.', 'Thông báo', false);backend('{0}')", BackUrl()), True)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('info', 'Bạn cần tạo kỳ dữ liệu trước khi cập nhật.', 'Thông báo', false);", True)
                End If

            Catch ex As Exception
                litUpdate.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub SaveBusForWork(obj As BC_BusinessInfo)
            Dim objBus = New WORK.CMS_BusinessInfo
            Dim objCTLBus = New WORK.WorkController
            objBus.Business_ID = obj.DoanhNghiep_ID
            objBus.Business_Vn = obj.TenDoanhNghiep
            objBus.Business_En = ""
            objBus.Business_Sort = ""
            objBus.TinhTP = obj.TinhTP
            objBus.QuanHuyen = obj.QuanHuyen
            objBus.Logo = ""
            objBus.Description = ""
            objBus.TaxCode = obj.TaxCode
            objBus.Mobile = obj.Mobile
            objBus.Fax = obj.Fax
            objBus.Website = obj.Website
            objBus.Email = obj.Email
            objBus.Address = obj.SoNha
            objBus.Scale = ""
            objBus.ContactUser = ""
            objBus.ContactMobile = ""
            objBus.ContactEmail = ""
            objBus.IsApproval = True
            objBus.ApprovalUser = UserInfo.Username
            objBus.ApprovalDate = Now
            objBus.PortalId = Me.PortalId
            objBus.CreatedDate = Now
            objBus.UpdatedUser = UserInfo.Username
            objBus.UpdatedDate = Now
            objBus.CreatedUser = UserInfo.Username
            objCTLBus.CMS_Business_Add(Me.PortalId, objBus)
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
            arrTemp = New CauController().BC_Business_List_Search(Me.PortalId, txtkey.Text.Trim, 1, 1, TinhTP.SelectedValue, "", "", "", "", 0, flReg.WriteNumber(KyNhapLieu.Text), flReg.WriteNumber(NganhNghe.SelectedValue), False)
            If arrTemp.Count > 0 Then
                For Each Cr As BC_BusinessInfo In arrTemp
                    If Request.Item("page") <> "" Then
                        Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("page") & "/bus/" & Cr.DoanhNghiep_ID & "/nam/" & KyNhapLieu.Text, True)
                    Else
                        Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit") & "/bus/" & Cr.DoanhNghiep_ID & "/nam/" & KyNhapLieu.Text, True)
                    End If
                Next
            End If
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call GenBusCode()
            Call flDic.LoadRegionalXP(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "", "XP")
            Call flFunction.LoadKhuCongNghiep(Me.PortalId, KhuCN_ID, TinhTP.SelectedValue, 0, "")
            XaPhuong.Focus()
        End Sub

        Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
            Response.Redirect(String.Format("/work/edit/de-updated/nam/{0}/tp/{1}/qh", KyNhapLieu.Text, TinhTP.SelectedValue))
        End Sub

        Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
            Response.Redirect(String.Format("/work/edit/de-updated/nam/{0}/tp/{1}/qh", KyNhapLieu.Text, TinhTP.SelectedValue))
        End Sub

        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.BC_Business_Update_IsDelete(Me.PortalId, ItemID.Value, True)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, String.Format("removewaiting();notify('success', 'Xóa dữ liệu thành công!', 'Thông báo', false);backend('{0}')", BackUrl()), True)
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting();notify('error', 'Lỗi có dữ liệu liên kết, không thể xóa được!', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey, "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub

        Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName)

        End Sub
    End Class



End Namespace
