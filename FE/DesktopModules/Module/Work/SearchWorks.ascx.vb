Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Work
    Partial Class SearchWorks
        Inherits Entities.Modules.PortalModuleBase
        Dim ctl As New WorkController
        Dim obj As New CMS_SearchInfo
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                'If flReg.WriteNumber(flReg.WebConfig("TinhTP")) = 0 Then
                Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "Tất cả Tỉnh thành")
                    'Else
                    '    Call flDic.LoadRegional_Parent_ID(Me.PortalId, TinhTP, flReg.WebConfig("TinhTP"), "Tất cả các Huyện")
                    'End If

                    Call flFunction.LoadCareer(Me.PortalId, NganhNghe, "Tất cả Ngành nghề")
                Call flDic.LoadSex(GioiTinh, "Tất cả Giới tính")
                Call flDic.LoadEducation(Me.PortalId, TrinhDo, "Tất cả Trình độ")
                Call flFunction.LoadJobPlace(Me.PortalId, ViTri, "Tất cả Vị trí")
                Call flFunction.LoadSalary(Me.PortalId, MucLuong, "Tất cả Mức lương")
                Call flFunction.LoadExperience(Me.PortalId, KinhNghiem, "Tất cả Kinh nghiệm")

                If Request.Item("nganh-nghe") & "" <> "" Then
                    Dim sId As Integer = CMS.Ultis.GetRequestId(Request.Item("nganh-nghe"))
                    Dim cInfo As New CMS_CareerInfo
                    cInfo = ctl.CMS_Career_Get_ID(Me.PortalId, sId)
                    If IsNothing(cInfo) = False Then
                        NganhNghe.SelectedValue = cInfo.Career_ID
                    End If
                Else
                    If flReg.WriteNumber(Request.Item("search")) > 0 Then
                        obj = ctl.CMS_Search_Get(Me.PortalId, Request.Item("search"))
                        If IsNothing(obj) = False Then
                            NganhNghe.SelectedValue = obj.NganhNghe
                            TinhTP.SelectedValue = obj.TinhTP
                            TrinhDo.SelectedValue = obj.TrinhDo
                            GioiTinh.SelectedValue = obj.GioiTinh
                            ViTri.SelectedValue = obj.ViTri
                            MucLuong.SelectedValue = obj.MucLuong
                            KinhNghiem.SelectedValue = obj.KinhNghiem
                            txtSearch.Text = obj.TuKhoa
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
            Try
                obj = New CMS_SearchInfo
                obj.TinhTP = TinhTP.SelectedValue
                obj.TrinhDo = TrinhDo.SelectedValue
                obj.GioiTinh = GioiTinh.SelectedValue
                obj.ViTri = ViTri.SelectedValue
                obj.MucLuong = MucLuong.SelectedValue
                obj.KinhNghiem = KinhNghiem.SelectedValue
                obj.NganhNghe = NganhNghe.SelectedValue
                obj.TuKhoa = txtSearch.Text.Trim
                Response.Redirect("/viec-lam/search/" & ctl.CMS_Search_Add(Me.PortalId, obj), True)
            Catch ex As Exception
                flReg.BugLog(Me.PortalId, ex.Message, "works")
            End Try
        End Sub
    End Class
End Namespace