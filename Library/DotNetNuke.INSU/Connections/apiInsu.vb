Public Class PortalInfo

    Public Property portalID As Integer
    Public Property portalName As String
    Public Property total As Integer
End Class
Public Class SettingDoorInfo

    Public Property iD As Integer
    Public Property satellite_ID As String
    Public Property portal_ID As Integer
    Public Property flagType As Integer
    Public Property dateSetting As Integer
    Public Property monthSetting As Integer
    Public Property yearSetting As Integer
    Public Property numDoor As Integer
    Public Property saWelcome As Integer
    Public Property chWelcome As Integer
    Public Property totalWelcome As Integer
    Public Property saRegister As Integer
    Public Property chRegister As Integer
    Public Property totalRegister As Integer
    Public Property sumExist As Integer
    Public Property notes As String
    Public Property dayText As String
    Public Property saNumber As Integer
    Public Property chNumber As Integer
End Class
Public Class DoorYearInfo
    Public Property monthSetting As Integer
    Public Property yearSetting As Integer
    Public Property monthActive As Integer
    Public Property yearActive As Integer
    Public Property notes As String
End Class
Public Class SatelliteInfo

    Public Property satellite_ID As String
    Public Property satellite_Name As String
    Public Property total As Integer

End Class
Public Class ServicesInfo

    Public Property dichVuID As Integer
    Public Property dichVuName As String
    Public Property total As Integer
End Class
Public Class NumberAutoInfo
    Public Property numberAuto_ID As String
    Public Property noCode As String
    Public Property qRCode As String
    Public Property hoTen As String
    Public Property dienThoai As String
    Public Property soBHXH As String
    Public Property ngayNghiViec As String
    Public Property dichVu As String
    Public Property thuTu As Integer
    Public Property portalID As Integer
    Public Property veTinhID As String
    Public Property gioDangKy As String
    Public Property ngayDangKy As String
    Public Property tinhTrang As Integer
    Public Property total As Integer
End Class
Public Class NotificationInfo
    Public Property notification_ID As String
    Public Property noCode As String
    Public Property thangHuong As Integer
    Public Property hoTen As String
    Public Property ngaySinh As String
    Public Property gioiTinh As Integer
    Public Property soCMND As String
    Public Property dienThoai As String
    Public Property cO_TinhTP As String
    Public Property qD_So As String
    Public Property qD_Ngay As String
    Public Property qD_ThangHuong As Integer
    Public Property qD_TuNgay As String
    Public Property qD_DenNgay As String
    Public Property qD_TinhTP As String
    Public Property qD_VeTinh As String
    Public Property tinhTrang As Integer
    Public Property neuCoVL As String
    Public Property tT_Khac As String
    Public Property portalID As Integer
    Public Property trangThai As Integer
    Public Property ngayNopHS As String
    Public Property ngayTiepNhan As String
    Public Property nguoiTiepNhan As String
    Public Property decide_ID As String
    Public Property total As Integer
    Public Property notiD As NotificationDInfo
    Public Property notiF As ArrayList
End Class
Public Class NotificationDInfo

    Public Property notiD_ID As String
    Public Property tenDonVi As String
    Public Property diaChi As String
    Public Property nguoiLienHe As String
    Public Property viTriDuTuyen As String
    Public Property ketQua As String
    Public Property isOrder As Integer
    Public Property total As Integer

End Class
Public Class FileAttchInfo

    Public Property iD As String
    Public Property idKey As String
    Public Property filePaths As String
    Public Property fileName As String
    Public Property isOrder As Integer
End Class
