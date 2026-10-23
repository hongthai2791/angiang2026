Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class SearchAdv
        Inherits Entities.Modules.PortalModuleBase
        Public SoNhaTuyenDung As Integer = 700
        Public SoTinTuyenDung As Integer = 2.0
        Public SoHoSo As Integer = 500

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                'If flReg.WriteNumber(flReg.WebConfig("TinhTP")) = 0 Then
                Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "Tất cả các Tỉnh")
                    'Else
                    '    Call flDic.LoadRegional_Parent_ID(Me.PortalId, TinhTP, flReg.WebConfig("TinhTP"), "Tất cả các Huyện")
                    'End If
                    Call flFunction.LoadCareer(Me.PortalId, NganhNghe, "Tất cả Ngành nghề")
            Catch ex As Exception
                flReg.BugLog(Me.PortalId, ex.Message, "work")
            End Try
        End Sub
        Private Sub LoadOther()
            Try
                'Dim obStatic As WORK.CMS_SysStatisticInfo = New WORK.WorkController().CMS_System_Statistic(Me.PortalId, 0, flReg.DateNull, flReg.DateNull, True)
                'If obStatic IsNot Nothing Then
                '    SoNhaTuyenDung = obStatic.NhaTuyenDung
                '    SoTinTuyenDung = obStatic.HoSoTimViec
                '    SoHoSo = obStatic.TinTuyenDung
                'End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
            Try
                Dim ctl As New WorkController
                Dim obj As New CMS_SearchInfo
                obj = New CMS_SearchInfo
                obj.TinhTP = TinhTP.SelectedValue
                obj.NganhNghe = NganhNghe.SelectedValue
                obj.TuKhoa = txtSearch.Text.Trim
                Response.Redirect("/viec-lam/search/" & ctl.CMS_Search_Add(Me.PortalId, obj), True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
    End Class
End Namespace