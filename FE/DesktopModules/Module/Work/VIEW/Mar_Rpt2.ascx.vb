Imports System.Text
Imports System.Web.Script.Serialization
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.DTNGHE_ThongKeView
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New WorkController

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                InitData()
                Call LoadChartData()
            End If
        End Sub
        Private Sub InitData()
            Call flDic.LoadDropList(QuyMoLaoDong, flDnn.CMS_DanhMuc_List(Me.PortalId, "CMS_QuyMoLaoDong"))
        End Sub
        Private Sub LoadChartData()
            Dim phienInfo As CMS_PhienGiaoDichInfo = ObjController.CMS_PhienGiaoDich_Get(Me.PortalId, Request.Item("pgd"))
            If IsNothing(phienInfo) = False Then
                lblSanViecLam.Text = phienInfo.TenPhien
            End If
            Dim obRpt As ReportInfo
            Dim thongKeData As New ArrayList
            For Each item As ListItem In QuyMoLaoDong.Items
                obRpt = New ReportInfo
                obRpt.Ten = item.Text
                obRpt.SoLuong = ObjController.SVL_ThongKe_DN_TheoQuyMo(Request.Item("pgd"), item.Value)
                thongKeData.Add(obRpt)
            Next

            Dim highchartsData As New List(Of Object)

            For Each item As ReportInfo In thongKeData
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

    End Class
End Namespace