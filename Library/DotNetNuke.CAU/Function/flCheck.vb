Imports DotNetNuke.EPORTAL
Public Class flCheck
    Public Shared Function activeYear(tinhTp As String) As Integer
        activeYear = flReg.WriteNumber(flCache.GetCache("activeYear_" & tinhTp))
        If activeYear = 0 Then
            tinhTp = flReg.WriteNumber(tinhTp)
            Dim obj As BC_SendMailInfo = New CauController().BC_SendMail_List_Years(0, tinhTp, 0)
            If IsNothing(obj) = False Then activeYear = obj.Years_ID
            flCache.SetCache("activeYear_" & tinhTp, activeYear)
        End If
    End Function
    Public Shared Function MaDoanhNghiep(id As String) As String
        Select Case id.Length
            Case 0
                MaDoanhNghiep = "00000"
            Case 1
                MaDoanhNghiep = "0000" & id
            Case 2
                MaDoanhNghiep = "000" & id
            Case 3
                MaDoanhNghiep = "00" & id
            Case 4
                MaDoanhNghiep = "0" & id
            Case Else
                MaDoanhNghiep = id
        End Select
    End Function
    Public Shared Function MaDoanhNghiep(PortalConnect As Integer, tinhTp As String, quanHuyen As String, xaPhuong As String) As String
        MaDoanhNghiep = New CauController().BC_Business_Check_Code(PortalConnect, tinhTp, quanHuyen, xaPhuong)
        Select Case MaDoanhNghiep.Length
            Case 1
                MaDoanhNghiep = "0000" & MaDoanhNghiep
            Case 2
                MaDoanhNghiep = "000" & MaDoanhNghiep
            Case 3
                MaDoanhNghiep = "00" & MaDoanhNghiep
            Case 4
                MaDoanhNghiep = "0" & MaDoanhNghiep
            Case Else
                MaDoanhNghiep = MaDoanhNghiep
        End Select
    End Function
    Public Shared Function KCN_Code(PortalConnect As Integer, KCN_ID As String) As String
        KCN_Code = flCache.GetCache("KCN_Code" & KCN_ID) & ""
        If KCN_Code = "" Then
            Dim obj As BC_IndustrialZoneInfo = New CauController().BC_IndustrialZone_Get(PortalConnect, KCN_ID)
            If IsNothing(obj) = False Then KCN_Code = flReg.RemoveScript(obj.IndustrialZone_Code, False)
            flCache.SetCache("KCN_Code" & KCN_ID, KCN_Code)
        End If
    End Function
    Public Shared Function KCN_Name(PortalConnect As Integer, KCN_ID As String) As String
        KCN_Name = flCache.GetCache("KCN_Name" & KCN_ID) & ""
        If KCN_Name = "" Then
            Dim obj As BC_IndustrialZoneInfo = New CauController().BC_IndustrialZone_Get(PortalConnect, KCN_ID)
            If IsNothing(obj) = False Then KCN_Name = flReg.RemoveScript(obj.IndustrialZone_Name, False)
            flCache.SetCache("KCN_Name" & KCN_ID, KCN_Name)
        End If
    End Function
    Public Shared Function LoaiHinh_Name(PortalConnect As Integer, LH_ID As String) As String
        LoaiHinh_Name = flCache.GetCache("LoaiHinh_Name" & LH_ID) & ""
        If LoaiHinh_Name = "" Then
            Dim obj As BC_CompanyTypeInfo = New CauController().BC_CompanyType_Get(PortalConnect, LH_ID)
            If IsNothing(obj) = False Then LoaiHinh_Name = flReg.RemoveScript(obj.TenLoaiHinh, False)
            flCache.SetCache("LoaiHinh_Name" & LH_ID, LoaiHinh_Name)
        End If
    End Function
    Public Shared Function NganhNghe_Name(PortalConnect As Integer, NN_ID As Integer) As String
        NganhNghe_Name = flCache.GetCache("NganhNghe_Name" & NN_ID) & ""
        If NganhNghe_Name = "" Then
            Dim obj As BC_CareerInfo = New CauController().BC_Career_Get(PortalConnect, NN_ID)
            If IsNothing(obj) = False Then NganhNghe_Name = flReg.RemoveScript(obj.Career_Name, False)
            flCache.SetCache("NganhNghe_Name" & NN_ID, NganhNghe_Name)
        End If
    End Function
    Public Shared Function Period_Name(Period_ID As Integer) As String
        If Period_ID = 1 Then
            Return "6 tháng đầu năm"
        ElseIf Period_ID = 2 Then
            Return "6 tháng cuối năm"
        Else
            Return ""
        End If
    End Function

End Class

