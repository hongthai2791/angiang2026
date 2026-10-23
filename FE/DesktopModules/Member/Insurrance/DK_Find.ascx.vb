Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU

Namespace DesktopModules.Modules
    Partial Class TIMKIEM
        Inherits PortalModuleBase
        Dim objController As New InsuController
        Dim pInfo As New EXE_ProSubsiInfo
        Dim sInfo As New EXE_AdvisoryInfo
        Dim aInfo As New EXE_ApprenticeInfo
        Dim nInfo As New EXE_NotificationInfo
        Private Sub KetQuaTimKiem(obj As Object, page As String, idKey As String)
            If IsNothing(obj) = False Then
                If obj.TrangThai = TrangThaiHS.TraLai Then
                    tl_qrCode.Text = "<img src=""" & bigCode.QRCode(obj.NoCode, flReg.UrlAlias & "/tra-cuu-ho-so/ma-hs/" & obj.NoCode) & """ alt=""Mã hồ sơ"">"
                    tl_ngayTra.Text = flReg.ReadDate(obj.ReturnDate)
                    tl_lyDo.Text = obj.ReturnDes
                    tl_Mobile.Value = obj.DienThoai
                    tl_page.Value = "/nop-ho-so/pid/" & obj.PortalID & "/hs/" & page & "/itemid/" & idKey
                    ptraLai.Visible = True
                ElseIf obj.TrangThai = TrangThaiHS.DaNop Then
                    cn_qrCode.Text = "<img src=""" & bigCode.QRCode(obj.NoCode, flReg.UrlAlias & "/tra-cuu-ho-so/ma-hs/" & obj.NoCode) & """ alt=""Mã hồ sơ"">"
                    cn_ngayNop.Text = flReg.ReadDate(obj.NgayNopHS)
                    pchoNhan.Visible = True
                Else
                    tn_qrCode.Text = "<img src=""" & bigCode.QRCode(obj.NoCode, flReg.UrlAlias & "/tra-cuu-ho-so/ma-hs/" & obj.NoCode) & """ alt=""Mã hồ sơ"">"
                    tn_ngayNhan.Text = flReg.ReadDate(obj.NgayTiepNhan)
                    ptiepNhan.Visible = True
                End If
            Else
                pkhongKQ.Visible = True
            End If
        End Sub
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    txtSearch.Text = Request.Item("ma-hs")
                    If txtSearch.Text <> "" Then
                        Select Case flReg.WriteNumber(txtSearch.Text.Trim().Substring(0, 2))
                            Case ProType.TCTN
                                pInfo = objController.EXE_ProSubsi_Find(Me.PortalId, txtSearch.Text.Trim())
                                Call KetQuaTimKiem(pInfo, "tro-cap-that-nghiep", pInfo.ProSubsi_ID)
                            Case ProType.TVGT
                                sInfo = objController.EXE_Advisory_Find(Me.PortalId, txtSearch.Text.Trim())
                                Call KetQuaTimKiem(sInfo, "tu-van-gioi-thieu", sInfo.Advisory_ID)
                            Case ProType.HTHN
                                aInfo = objController.EXE_Apprentice_Find(Me.PortalId, txtSearch.Text.Trim())
                                Call KetQuaTimKiem(aInfo, "ho-tro-hoc-nghe", aInfo.Apprentice_ID)
                            Case ProType.KBVL
                                nInfo = objController.EXE_Notification_Find(Me.PortalId, txtSearch.Text.Trim())
                                Call KetQuaTimKiem(nInfo, "khai-bao-viec-lam", nInfo.Notification_ID)
                            Case Else
                                pkhongKQ.Visible = True
                        End Select
                    End If
                End If
            Catch ex As Exception
            End Try
        End Sub

        Private Sub tl_buttom_Click(sender As Object, e As EventArgs) Handles tl_buttom.Click
            If tl_DienThoai.Text.Trim() = tl_Mobile.Value.Trim() Then
                Response.Redirect(tl_page.Value, True)
            Else
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', 'Số điện thoại không đúng với số <b style=""color:yellow"">đã đăng ký trên hồ sơ</b>, vui lòng kiểm tra lại', 'Thông báo', false);", True)
            End If

        End Sub
        Private Sub cmSearch_Click(sender As Object, e As EventArgs) Handles cmSearch.Click
            If (txtSearch.Text.Trim & "" = "") Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "warning_box", ";notify('info', 'Nhập mã số hồ sơ để tìm kiếm', 'Thông báo', false);", True)
            Else
                Response.Redirect("/tra-cuu-ho-so/ma-hs/" & txtSearch.Text.Trim(), True)
            End If
        End Sub
    End Class
End Namespace

