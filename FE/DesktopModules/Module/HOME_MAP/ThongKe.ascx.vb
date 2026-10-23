Imports DotNetNuke.EPORTAL
Imports DotNetNuke.MAP

Namespace DesktopModules.Modules.Home
    Partial Class ThongKe
        Inherits Entities.Modules.PortalModuleBase
        Public CoViecLam = 0, LucLuongLD = 0, HoatDongKte = 0, DanSo15 = 0, DoanhNghiep = 1109
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                Dim objCtl As New MapController
                CoViecLam = flReg.FormatPrice(objCtl.MAP_DATA_GetData(Me.PortalId, flReg.WebConfig("TinhTP"), 0, 0, 0, 0, "LD01.01", TypesData.CapTinh))
                LucLuongLD = flReg.FormatPrice(objCtl.MAP_DATA_GetData(Me.PortalId, flReg.WebConfig("TinhTP"), 0, 0, 0, 0, "LL01.01", TypesData.CapTinh))
                HoatDongKte = flReg.FormatPrice(objCtl.MAP_DATA_GetData(Me.PortalId, flReg.WebConfig("TinhTP"), 0, 0, 0, 0, "HDKT01.01", TypesData.CapTinh))
                DanSo15 = flReg.FormatPrice(objCtl.MAP_DATA_GetData(Me.PortalId, flReg.WebConfig("TinhTP"), 0, 0, 0, 0, "DS01.01", TypesData.CapTinh))
            End If
        End Sub
    End Class
End Namespace