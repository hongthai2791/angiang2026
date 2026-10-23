Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU

Namespace DesktopModules.Modules
    Partial Class HomePage
        Inherits PortalModuleBase
        Dim objController As New InsuController()
        Dim obj As New EXE_NumberAutoInfo
        Dim kqDangKy As Integer = 0

        Private Sub InnitController()
            Call flFunction.LoadPortals(0, drPortal)
            drPortal.SelectedValue = flReg.WebConfig("TinhTP")

            Call flFunction.LoadSatellite(drPortal.SelectedValue, VeTinh, "")

            NgayDangKy.Text = Now.ToString("dd-MM-yyyy")

            HoTen.Text = Me.UserInfo.DisplayName
            Email.Text = Me.UserInfo.Email
            DienThoai.Text = Me.UserInfo.Profile.Telephone
        End Sub
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                Call InnitController()
            End If
        End Sub
        Private Function SaveData(dichVu As Integer) As Integer
            Try
                SaveData = 0
                obj = New EXE_NumberAutoInfo
                obj.NumberAuto_ID = flReg.GenKey()
                obj.NoCode = flCheck.NoCode(drPortal.SelectedValue, ProType.DKXH)
                obj.HoTen = flReg.RemoveScript(HoTen.Text.ToUpper.Trim())
                obj.DienThoai = flReg.RemoveScript(DienThoai.Text.Trim())
                obj.NgayDangKy = Now
                obj.DichVu = dichVu
                obj.PortalID = drPortal.SelectedValue
                obj.VeTinhID = VeTinh.SelectedValue
                obj.CreatedDate = Now
                obj.CreatedUser = Me.UserInfo.Username

                Try
                    If Request.Cookies("xh_Online_" & obj.DienThoai & "_" & obj.PortalID & "_" & obj.DichVu) Is Nothing Then
                        objController.EXE_NumberAuto_Add_Lite(drPortal.SelectedValue, obj)

                        Dim myCookie As New HttpCookie("xh_Online_" & obj.DienThoai & "_" & obj.PortalID & "_" & obj.DichVu)
                        myCookie.Values.Add("tel", obj.DienThoai)
                        myCookie.Expires = DateTime.Now.AddHours(1)
                        Response.Cookies.Add(myCookie)
                        SaveData = 1
                    Else
                        SaveData = 2
                    End If
                Catch ex As Exception
                    objController.EXE_NumberAuto_Add(drPortal.SelectedValue, obj)

                    Dim myCookie As New HttpCookie("xh_Online_" & obj.DienThoai & "_" & obj.PortalID & "_" & obj.DichVu)
                    myCookie.Values.Add("tel", obj.DienThoai)
                    myCookie.Expires = DateTime.Now.AddHours(1)
                    Response.Cookies.Add(myCookie)
                    SaveData = 1
                End Try

            Catch ex As Exception
                SaveData = 0
            End Try
        End Function
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect("/users/view/lay-so-truc-tuyen", True)
        End Sub
        Private Sub cmdDK1_Click(sender As Object, e As EventArgs) Handles cmdDK1.Click
            kqDangKy = SaveData(1)
            If kqDangKy = 1 Then
                lbThongBao.Text = "<p>Lấy số thành công</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            ElseIf kqDangKy = 0 Then

                lbThongBao.Text = "<p>Lấy số thất bại, vui lòng thử lại hoặc liên hệ quản trị hệ thống!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            ElseIf kqDangKy = 3 Then
                lbThongBao.Text = "<p>Bạn chưa chọn xác thực bảo mật, vui lòng chọn xác thực bảo mật trước khi lấy số!</p><p>Trân trọng!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            Else
                lbThongBao.Text = "<p>Bạn đã đăng ký lấy số dịch vụ: <b style='color:green'>Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp</b></p><p>Vui lòng kiểm tra lại, Trân trọng!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao", "thongbao();", True)
            End If
        End Sub
        Private Sub cmdDK2_Click(sender As Object, e As EventArgs) Handles cmdDK2.Click
            kqDangKy = SaveData(2)
            If kqDangKy = 1 Then
                lbThongBao.Text = "<p>Lấy số thành công</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            ElseIf kqDangKy = 0 Then

                lbThongBao.Text = "<p>Lấy số thất bại, vui lòng thử lại hoặc liên hệ quản trị hệ thống!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            ElseIf kqDangKy = 3 Then
                lbThongBao.Text = "<p>Bạn chưa chọn xác thực bảo mật, vui lòng chọn xác thực bảo mật trước khi lấy số!</p><p>Trân trọng!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            Else
                lbThongBao.Text = "<p>Bạn đã đăng ký lấy số dịch vụ: <b style='color:green'>Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp</b></p><p>Vui lòng kiểm tra lại, Trân trọng!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao", "thongbao();", True)
            End If
        End Sub
        Private Sub cmdDK3_Click(sender As Object, e As EventArgs) Handles cmdDK3.Click
            kqDangKy = SaveData(3)
            If kqDangKy = 1 Then
                lbThongBao.Text = "<p>Lấy số thành công</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            ElseIf kqDangKy = 0 Then

                lbThongBao.Text = "<p>Lấy số thất bại, vui lòng thử lại hoặc liên hệ quản trị hệ thống!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            ElseIf kqDangKy = 3 Then
                lbThongBao.Text = "<p>Bạn chưa chọn xác thực bảo mật, vui lòng chọn xác thực bảo mật trước khi lấy số!</p><p>Trân trọng!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            Else
                lbThongBao.Text = "<p>Bạn đã đăng ký lấy số dịch vụ: <b style='color:green'>Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp</b></p><p>Vui lòng kiểm tra lại, Trân trọng!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao", "thongbao();", True)
            End If
        End Sub
        Private Sub cmdDK4_Click(sender As Object, e As EventArgs) Handles cmdDK4.Click
            kqDangKy = SaveData(4)
            If kqDangKy = 1 Then
                lbThongBao.Text = "<p>Lấy số thành công</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            ElseIf kqDangKy = 0 Then

                lbThongBao.Text = "<p>Lấy số thất bại, vui lòng thử lại hoặc liên hệ quản trị hệ thống!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            ElseIf kqDangKy = 3 Then
                lbThongBao.Text = "<p>Bạn chưa chọn xác thực bảo mật, vui lòng chọn xác thực bảo mật trước khi lấy số!</p><p>Trân trọng!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao1", "thongbao();", True)
            Else
                lbThongBao.Text = "<p>Bạn đã đăng ký lấy số dịch vụ: <b style='color:green'>Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp</b></p><p>Vui lòng kiểm tra lại, Trân trọng!</p>"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thonBao", "thongbao();", True)
            End If
        End Sub
    End Class
End Namespace

