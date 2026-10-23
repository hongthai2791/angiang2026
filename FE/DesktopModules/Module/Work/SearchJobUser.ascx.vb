Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Work
    Partial Class SearchJobUser
        Inherits Entities.Modules.PortalModuleBase
        Dim ctl As New WorkController
        Dim obj As New CMS_SearchInfo

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                If flReg.WriteNumber(flReg.WebConfig("TinhTP")) = 0 Then
                    Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "Tất cả Tỉnh thành")
                Else
                    Call flDic.LoadRegional_Parent_ID(Me.PortalId, TinhTP, flReg.WebConfig("TinhTP"), "Tất cả các Huyện")
                End If
                Call flFunction.LoadCareer(Me.PortalId, NganhNghe, "Tất cả Ngành nghề")
                Call flDic.LoadEducation(Me.PortalId, TrinhDo, "Tất cả Trình độ")
                Call flDic.LoadPosition(Me.PortalId, ChucVu, "Tất cả Chức vụ")
                Call flFunction.LoadSalary(Me.PortalId, MucLuong, "Tất cả Mức lương")
                Call flFunction.LoadExperience(Me.PortalId, KinhNghiem, "Tất cả Kinh nghiệm")
                If flReg.WriteNumber(Request.Item("search")) > 0 Then
                    obj = ctl.CMS_Search_Get(Me.PortalId, Request.Item("search"))
                    If IsNothing(obj) = False Then
                        NganhNghe.SelectedValue = obj.NganhNghe
                        TinhTP.SelectedValue = obj.TinhTP
                        TrinhDo.SelectedValue = obj.TrinhDo
                        ChucVu.SelectedValue = obj.ChucVu
                        MucLuong.SelectedValue = obj.MucLuong
                        KinhNghiem.SelectedValue = obj.KinhNghiem
                        KinhNghiem.SelectedValue = obj.KinhNghiem
                        txtSearch.Text = obj.TuKhoa
                    End If
                End If
            End If
        End Sub

        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
            Try
                obj = New CMS_SearchInfo
                obj.TinhTP = TinhTP.SelectedValue
                obj.TrinhDo = TrinhDo.SelectedValue
                obj.ChucVu = ChucVu.SelectedValue
                obj.MucLuong = MucLuong.SelectedValue
                obj.KinhNghiem = KinhNghiem.SelectedValue
                obj.NganhNghe = NganhNghe.SelectedValue
                obj.TuKhoa = txtSearch.Text.Trim
                Response.Redirect("/ho-so-xin-viec/search/" & ctl.CMS_Search_Add(Me.PortalId, obj), True)
            Catch ex As Exception
                flReg.BugLog(Me.PortalId, ex.Message, "works")
            End Try
        End Sub
    End Class
End Namespace