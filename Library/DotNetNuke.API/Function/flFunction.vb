Imports System.Web.UI.WebControls
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.VBN

Public Class flFunction
    Shared strOld, str() As String
    Shared ObjControler As New APIController
    Shared arrTemp, arrTemp1 As New ArrayList
    Public Shared Sub LoadStatusWork(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - Trạng thái- -", "0"))
        drGroup.Items.Add(New ListItem("Đã duyệt", StatusWork.DaDuyet))
        drGroup.Items.Add(New ListItem("Tuyển gấp", StatusWork.TuyenGap))
        drGroup.Items.Add(New ListItem("Tuyển nhanh", StatusWork.TuyenNhanh))
        drGroup.Items.Add(New ListItem("Tin nổi bật", StatusWork.TinNoiBat))
    End Sub
    Public Shared Sub LoadMucDoSuDung(ByVal drGroup As DropDownList, Optional ByVal text As String = "Chọn khả năng sử dụng")
        drGroup.Items.Clear()
        If text <> "" Then
            drGroup.Items.Add(New ListItem(text, 0))
        End If
        drGroup.Items.Add(New ListItem("Tốt", 1))
        drGroup.Items.Add(New ListItem("Trung bình", 2))
        drGroup.Items.Add(New ListItem("Khá", 3))
    End Sub
    Public Shared Sub LoadStatusType(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - Trạng thái- -", "-1"))
        drGroup.Items.Add(New ListItem("Đã xem", StatusType.DaXem))
        drGroup.Items.Add(New ListItem("Đã liên hệ", StatusType.DaLienHe))
        drGroup.Items.Add(New ListItem("Đã phỏng vấn", StatusType.DaPhongVan))
        drGroup.Items.Add(New ListItem("Đã test ứng viên", StatusType.DaTest))
        drGroup.Items.Add(New ListItem("Trúng tuyển", StatusType.TrungTuyen))
        drGroup.Items.Add(New ListItem("Từ chối tuyển", StatusType.TuChoi))
    End Sub
    Public Shared Sub LoadStatus(ByVal drGroup As DropDownList, Optional ByVal full As Boolean = True)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - - Chọn - - -", "-1"))
        If full = True Then
            drGroup.Items.Add(New ListItem("Đã xem", StatusType.DaXem))
            drGroup.Items.Add(New ListItem("Đã liên hệ", StatusType.DaLienHe))
            drGroup.Items.Add(New ListItem("Đã phỏng vấn", StatusType.DaPhongVan))
            drGroup.Items.Add(New ListItem("Đã test", StatusType.DaTest))
            drGroup.Items.Add(New ListItem("Trúng tuyển", StatusType.TrungTuyen))
            drGroup.Items.Add(New ListItem("Từ chối", StatusType.TuChoi))
        Else
            drGroup.Items.Add(New ListItem("Đã liên hệ", StatusType.DaLienHe))
            drGroup.Items.Add(New ListItem("Đã phỏng vấn", StatusType.DaPhongVan))
            drGroup.Items.Add(New ListItem("Đã test", StatusType.DaTest))
            drGroup.Items.Add(New ListItem("Trúng tuyển", StatusType.TrungTuyen))
        End If
    End Sub

End Class
