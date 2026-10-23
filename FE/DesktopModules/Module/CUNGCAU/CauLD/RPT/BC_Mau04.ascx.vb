Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CAU

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New CauController()
        Dim arrKTR, arrKBC As New ArrayList

        Private Sub InitControls()
            Call flDic.LoadRegionalTP(Me.PortalId, drTinhTP, "", "TP")
            If Request.Item("tp") <> "" Then
                drTinhTP.SelectedValue = Request.Item("tp")
            Else
                If flReg.WebConfig("TinhTP") <> "0" Then drTinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            End If
            Call flDic.LoadYear(drYear, Now.Year - 5, Now.Year, False)
            If Request.Item("nam") <> "" Then
                drYear.SelectedValue = Request.Item("nam")
            Else
                If flReg.WriteNumber(flCache.GetCache("BC_KyNhapLieu_Years_" & drTinhTP.SelectedValue)) > 0 Then
                    drYear.SelectedValue = flCache.GetCache("BC_KyNhapLieu_Years_" & drTinhTP.SelectedValue)
                Else
                    drYear.SelectedValue = Now.Year
                End If
            End If

            Call flDic.LoadRegionalXP(Me.PortalId, drPhuongXa, drTinhTP.SelectedValue, "--- Xã phường ---", "XP")
            drPhuongXa.SelectedValue = flReg.WriteNumber(Request.Item("xa"))
        End Sub
        Private Sub LoadValues()
            flCache.SetCache("BC_KyNhapLieu_Years_" & drTinhTP.SelectedValue, drYear.SelectedValue)

            arrKTR = objController.BC_CauLD_Mau_04_KyTruoc(Me.PortalId, drTinhTP.SelectedValue, flReg.WriteNumber(drPhuongXa.SelectedValue), flReg.WriteNumber(drYear.SelectedValue) - 1)
            For Each Cr As BC_BusinessInfo In arrKTR
                KT_TongSoDN.Text = Cr.KT_TongSoDN
                KT_LD_TongSo.Text = Cr.KT_LD_TongSo
                KT_LD_Nu.Text = Cr.KT_LD_Nu
                KT_LD_TREN35.Text = Cr.KT_LD_TREN35
                KT_LD_BHXH.Text = Cr.KT_LD_BHXH
                KT_VT_NhaQuanLy.Text = Cr.KT_VT_NhaQuanLy
                KT_VT_CMKT_Cao.Text = Cr.KT_VT_CMKT_Cao
                KT_VT_CMKT_Trung.Text = Cr.KT_VT_CMKT_Trung
                KT_VT_CMKT_Khac.Text = Cr.KT_VT_CMKT_Khac
                KT_C10_LaoDong.Text = Cr.KT_C10_LaoDong
                KT_C10_LaoDong_NhaNuoc.Text = Cr.KT_C10_LaoDong_NhaNuoc
                KT_C10_LaoDong_NgoaiNuoc.Text = Cr.KT_C10_LaoDong_NgoaiNuoc
                KT_C10_LaoDong_VonNN.Text = Cr.KT_C10_LaoDong_VonNN
                KT_C10_LaoDong_DonViNN.Text = Cr.KT_C10_LaoDong_DonViNN
                KT_C10_LaoDong_HoKD.Text = Cr.KT_C10_LaoDong_HoKD
                KT_C10_LaoDong_CaNhan.Text = Cr.KT_C10_LaoDong_CaNhan
                KT_C11_17.Text = Cr.KT_C11_17
                KT_C11_21.Text = Cr.KT_C11_21
                KT_C11_22.Text = Cr.KT_C11_22
                KT_C11_23.Text = Cr.KT_C11_23
                KT_C11_24.Text = Cr.KT_C11_24
                KT_C11_25.Text = Cr.KT_C11_25
                KT_C11_26.Text = Cr.KT_C11_26
                KT_C11_31.Text = Cr.KT_C11_31
                KT_C11_32.Text = Cr.KT_C11_32
                KT_C11_33.Text = Cr.KT_C11_33
                KT_C11_34.Text = Cr.KT_C11_34
                KT_C11_35.Text = Cr.KT_C11_35
                KT_C11_36.Text = Cr.KT_C11_36
                KT_C11_41.Text = Cr.KT_C11_41
                KT_C11_42.Text = Cr.KT_C11_42
                KT_C11_43.Text = Cr.KT_C11_43
                KT_C11_44.Text = Cr.KT_C11_44
                KT_C11_51.Text = Cr.KT_C11_51
                KT_C11_52.Text = Cr.KT_C11_52
                KT_C11_53.Text = Cr.KT_C11_53
                KT_C11_54.Text = Cr.KT_C11_54
                KT_C11_61.Text = Cr.KT_C11_61
                KT_C11_62.Text = Cr.KT_C11_62
                KT_C11_63.Text = Cr.KT_C11_63
                KT_C11_71.Text = Cr.KT_C11_71
                KT_C11_72.Text = Cr.KT_C11_72
                KT_C11_73.Text = Cr.KT_C11_73
                KT_C11_74.Text = Cr.KT_C11_74
                KT_C11_75.Text = Cr.KT_C11_75
                KT_C11_81.Text = Cr.KT_C11_81
                KT_C11_82.Text = Cr.KT_C11_82
                KT_C11_83.Text = Cr.KT_C11_83
                KT_C11_91.Text = Cr.KT_C11_91
                KT_C11_92.Text = Cr.KT_C11_92
                KT_C11_93.Text = Cr.KT_C11_93
                KT_C11_94.Text = Cr.KT_C11_94
                KT_C11_95.Text = Cr.KT_C11_95
                KT_C11_96.Text = Cr.KT_C11_96
                KT_LD_NuocNgoai_Tong.Text = Cr.KT_LD_NuocNgoai_Tong
            Next

            arrKBC = objController.BC_CauLD_Mau_04_KyBC(Me.PortalId, drTinhTP.SelectedValue, flReg.WriteNumber(drPhuongXa.SelectedValue), flReg.WriteNumber(drYear.SelectedValue))
            For Each Cr As BC_BusinessInfo In arrKBC
                TongSoDN.Text = Cr.TongSoDN
                LD_TongSo.Text = Cr.LD_TongSo
                LD_Nu.Text = Cr.LD_Nu
                LD_TREN35.Text = Cr.LD_TREN35
                LD_BHXH.Text = Cr.LD_BHXH
                VT_NhaQuanLy.Text = Cr.VT_NhaQuanLy
                VT_CMKT_Cao.Text = Cr.VT_CMKT_Cao
                VT_CMKT_Trung.Text = Cr.VT_CMKT_Trung
                VT_CMKT_Khac.Text = Cr.VT_CMKT_Khac
                C10_LaoDong.Text = Cr.C10_LaoDong
                C10_LaoDong_NhaNuoc.Text = Cr.C10_LaoDong_NhaNuoc
                C10_LaoDong_NgoaiNuoc.Text = Cr.C10_LaoDong_NgoaiNuoc
                C10_LaoDong_VonNN.Text = Cr.C10_LaoDong_VonNN
                C10_LaoDong_DonViNN.Text = Cr.C10_LaoDong_DonViNN
                C10_LaoDong_HoKD.Text = Cr.C10_LaoDong_HoKD
                C10_LaoDong_CaNhan.Text = Cr.C10_LaoDong_CaNhan
                C11_17.Text = Cr.C11_17
                C11_21.Text = Cr.C11_21
                C11_22.Text = Cr.C11_22
                C11_23.Text = Cr.C11_23
                C11_24.Text = Cr.C11_24
                C11_25.Text = Cr.C11_25
                C11_26.Text = Cr.C11_26
                C11_31.Text = Cr.C11_31
                C11_32.Text = Cr.C11_32
                C11_33.Text = Cr.C11_33
                C11_34.Text = Cr.C11_34
                C11_35.Text = Cr.C11_35
                C11_36.Text = Cr.C11_36
                C11_41.Text = Cr.C11_41
                C11_42.Text = Cr.C11_42
                C11_43.Text = Cr.C11_43
                C11_44.Text = Cr.C11_44
                C11_51.Text = Cr.C11_51
                C11_52.Text = Cr.C11_52
                C11_53.Text = Cr.C11_53
                C11_54.Text = Cr.C11_54
                C11_61.Text = Cr.C11_61
                C11_62.Text = Cr.C11_62
                C11_63.Text = Cr.C11_63
                C11_71.Text = Cr.C11_71
                C11_72.Text = Cr.C11_72
                C11_73.Text = Cr.C11_73
                C11_74.Text = Cr.C11_74
                C11_75.Text = Cr.C11_75
                C11_81.Text = Cr.C11_81
                C11_82.Text = Cr.C11_82
                C11_83.Text = Cr.C11_83
                C11_91.Text = Cr.C11_91
                C11_92.Text = Cr.C11_92
                C11_93.Text = Cr.C11_93
                C11_94.Text = Cr.C11_94
                C11_95.Text = Cr.C11_95
                C11_96.Text = Cr.C11_96
                LD_NuocNgoai_Tong.Text = Cr.LD_NuocNgoai_Tong

            Next

            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();", True)
        End Sub
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
        Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
            Call LoadValues()
        End Sub
    End Class

End Namespace
