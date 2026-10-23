Imports System.Text
Imports System.Web.Script.Serialization
Imports DotNetNuke.CAU
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.DTNGHE_ThongKeView
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CauController

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call InitControls()
                Call LoadChartData()
            End If
        End Sub
        Private Sub InitControls()
            Call flDic.LoadRegionalXP(Me.PortalId, PhuongXa, flReg.WebConfig("TinhTP"), "--- Xã phường ---", "XP")
            PhuongXa.SelectedValue = flReg.WriteNumber(Request.Item("xa"))
            LoadTrangThai()
            drYear.Items.Clear()
            For Each Cr As BC_SendMailInfo In New CauController().BC_SendMail_Get_Years(Me.PortalId, flReg.WebConfig("TinhTP"), Me.PortalId)
                drYear.Items.Add(Cr.Years_ID)
            Next
            If Request.Item("nam") <> "" Then
                drYear.SelectedValue = Request.Item("nam")
            Else
                If flReg.WriteNumber(flCache.GetCache("BC_KyNhapLieu_Years_" & flReg.WebConfig("TinhTP"))) > 0 Then
                    drYear.SelectedValue = flCache.GetCache("BC_KyNhapLieu_Years_" & flReg.WebConfig("TinhTP"))
                Else
                    drYear.SelectedValue = Now.Year
                End If
            End If
            flDic.ListUserName(Me.PortalId, drUserName, "a", Me.PortalSettings.ActiveTab.TabName, "")
            drUserName.Items.Add(New ListItem("SuperUser Account", "host"))
        End Sub
        Private Sub LoadTrangThai()
            TrangThai.Items.Clear()
            TrangThai.Items.Add(New ListItem("--- Tất cả ---", 0))
            TrangThai.Items.Add(New ListItem("Thêm mới", 1))
            TrangThai.Items.Add(New ListItem("Sửa", 2))
            TrangThai.Items.Add(New ListItem("Xóa", 3))
        End Sub
        'Private Sub LoadType()
        '    drType.Items.Clear()
        '    drType.Items.Add(New ListItem("--- Tất cả ---", 0))
        '    drType.Items.Add(New ListItem("Số thêm mới", 1))
        '    drType.Items.Add(New ListItem("Số cập nhật", 2))
        'End Sub
        Private Sub LoadChartData()
            Dim thongKeData As ArrayList = ObjController.ThongKe_DN_TheoNguoiNhapTin(flReg.WriteNumber(PhuongXa.SelectedValue), TrangThai.SelectedValue, drYear.SelectedValue, drUserName.SelectedValue)

            Dim highchartsData As New List(Of Object)

            For Each item As ThongKeInfo In thongKeData
                highchartsData.Add(New With {
                    .name = item.Ten,
                    .y = item.SoLuong
                })
            Next
            Dim serializer As New JavaScriptSerializer()
            Dim jsonString As String = serializer.Serialize(highchartsData)
            Dim script As String = "var chartData = " & jsonString & ";"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "ChartDataScript", script, True)
        End Sub

        Private Sub drUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drUserName.SelectedIndexChanged, drYear.SelectedIndexChanged, PhuongXa.SelectedIndexChanged, TrangThai.SelectedIndexChanged
            LoadChartData()
        End Sub
    End Class
End Namespace