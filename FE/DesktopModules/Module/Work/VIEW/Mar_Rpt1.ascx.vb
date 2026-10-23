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
                Call LoadChartData()
            End If
        End Sub

        Private Sub LoadChartData()
            Dim phienInfo As CMS_PhienGiaoDichInfo = ObjController.CMS_PhienGiaoDich_Get(Me.PortalId, Request.Item("pgd"))
            If IsNothing(phienInfo) = False Then
                lblSanViecLam.Text = phienInfo.TenPhien
            End If
            Dim thongKeData As ArrayList = ObjController.SVL_ThongKe_DN_TheoNghe(Request.Item("pgd"))

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