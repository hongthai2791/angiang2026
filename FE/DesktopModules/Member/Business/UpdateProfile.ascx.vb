Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim objController As New CauController()
        Dim obj As New BC_BusinessInfo
        Dim dicInfo As New WORK.CMS_BusinessInfo
        Dim str() As String
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Public Shared Sub LoadThanhThi(ByVal drGroup As DropDownList)
            drGroup.Items.Clear()
            drGroup.Items.Add(New ListItem("- - - Chọn - - -", "0"))
            drGroup.Items.Add(New ListItem("Thành thị", "1"))
            drGroup.Items.Add(New ListItem("Nông thôn", "2"))
        End Sub
        Private Sub InitControls()
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP)
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue)
            Call flFunction.LoadKhuCongNghiep(Me.PortalId, KhuCN_ID, flReg.WriteNumber(TinhTP.SelectedValue), 0, "")
            Call flFunction.LoadCareer_Parent_Null(Me.PortalId, NganhNghe)
            Call flFunction.LoadLoaiHinhDN(Me.PortalId, LoaiHinh_ID)
            Call flFunction.LoadTinhTrang(TinhTrang)
            Call LoadThanhThi(TT_NT)
            Business_ID.Value = WORK.flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
        End Sub
        Private Sub BackEnd()
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName, True)
        End Sub
        Private Sub LoadValue()
            obj = objController.BC_Business_Get(Me.PortalId, Business_ID.Value)
            If IsNothing(obj) = False Then
                Try
                    str = obj.MaDoanhNghiep.Split("-")
                    MaDN1.Text = str(0)
                    MaDN2.Text = str(1)
                    MaDN3.Text = str(2)
                    MaDN4.Text = str(3)
                Catch ex As Exception
                    MaDN1.Text = obj.TinhTP
                    MaDN2.Text = obj.QuanHuyen
                    MaDN3.Text = obj.XaPhuong
                    MaDN4.Text = str(0)
                End Try

                TenDoanhNghiep.Text = obj.TenDoanhNghiep
                TaxCode.Text = obj.TaxCode
                Mobile.Text = obj.Mobile
                Fax.Text = obj.Fax
                Email.Text = obj.Email
                Website.Text = obj.Website
                TinhTrang.SelectedValue = obj.TinhTrang
                TinhTP.SelectedValue = obj.TinhTP


                Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue)
                XaPhuong.SelectedValue = obj.XaPhuong

                Call flFunction.LoadKhuCongNghiep(Me.PortalId, KhuCN_ID, flReg.WriteNumber(TinhTP.SelectedValue), 0, "")
                KhuCN_ID.SelectedValue = obj.KhuCN_ID

                TT_NT.SelectedValue = obj.TT_NT
                SoNha.Text = obj.SoNha
                LoaiHinh_ID.SelectedValue = obj.LoaiHinh_ID
                NganhNghe.SelectedValue = obj.NganhNghe
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

                litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo: " & flReg.ReadDate(obj.CreatedDate)
                litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                If obj.UpdatedUser <> "" Then
                    litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                    litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                End If
            Else
                dicInfo = New WORK.WorkController().CMS_Business_Get(Me.PortalId, Business_ID.Value)
                If IsNothing(dicInfo) = False Then
                    TenDoanhNghiep.Text = dicInfo.Business_Vn
                    TaxCode.Text = dicInfo.TaxCode
                    Mobile.Text = dicInfo.ContactMobile
                    Fax.Text = dicInfo.Fax
                    Email.Text = dicInfo.ContactEmail
                    Website.Text = dicInfo.Website

                    TinhTP.SelectedValue = dicInfo.TinhTP

                    Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
                    QuanHuyen.SelectedValue = dicInfo.QuanHuyen

                    Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, QuanHuyen.SelectedValue)

                    MaDN1.Text = flCheck.MaDoanhNghiep(dicInfo.TinhTP)
                    MaDN2.Text = flCheck.MaDoanhNghiep(dicInfo.QuanHuyen)
                    MaDN3.Text = "00000"
                    MaDN4.Text = flCheck.MaDoanhNghiep(Me.PortalId, TinhTP.SelectedValue, QuanHuyen.SelectedValue, "")
                End If
            End If
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                obj = New BC_BusinessInfo
                obj.DoanhNghiep_ID = Business_ID.Value
                obj.MaDoanhNghiep = MaDN1.Text.Trim & "-" & MaDN2.Text.Trim & "-" & MaDN3.Text.Trim & "-" & MaDN4.Text.Trim
                obj.TenDoanhNghiep = TenDoanhNghiep.Text
                obj.TaxCode = TaxCode.Text
                obj.Mobile = Mobile.Text
                obj.Fax = Fax.Text
                obj.Email = Email.Text
                obj.Website = Website.Text
                obj.TinhTrang = flReg.WriteNumber(TinhTrang.SelectedValue)
                obj.TinhTP = TinhTP.SelectedValue
                obj.QuanHuyen = QuanHuyen.SelectedValue
                obj.XaPhuong = XaPhuong.SelectedValue
                obj.TT_NT = TT_NT.SelectedValue
                obj.SoNha = SoNha.Text
                obj.KhuCN_ID = KhuCN_ID.SelectedValue
                obj.LoaiHinh_ID = LoaiHinh_ID.SelectedValue
                obj.NganhNghe = NganhNghe.SelectedValue
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
                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username
                obj.UpdatedDate = Now
                obj.UpdatedUser = Me.UserInfo.Username
                obj.PortalId = Me.PortalId
                objController.BC_Business_Add(Me.PortalId, obj)
                Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_success", "removewaiting();notify('success', 'Đã cập nhật thông tin đơn vị báo cáo thành công.', 'Thông báo', false);", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue)
            Call flFunction.LoadKhuCongNghiep(Me.PortalId, KhuCN_ID, flReg.WriteNumber(TinhTP.SelectedValue), 0, "")
            MaDN1.Text = flCheck.MaDoanhNghiep(TinhTP.SelectedValue)
            MaDN2.Text = "00000"
            MaDN3.Text = "00000"
            MaDN4.Text = flCheck.MaDoanhNghiep(Me.PortalId, TinhTP.SelectedValue, "", "")
        End Sub

        Private Sub XaPhuong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles XaPhuong.SelectedIndexChanged
            MaDN3.Text = flCheck.MaDoanhNghiep(XaPhuong.SelectedValue)
            MaDN4.Text = flCheck.MaDoanhNghiep(Me.PortalId, TinhTP.SelectedValue, 0, XaPhuong.SelectedValue)
        End Sub
    End Class



End Namespace
