Imports System.Web.UI.WebControls
Imports DotNetNuke.EPORTAL

Public Class flFunction
    Shared strOld, str() As String
    Shared ObjControler As New CauController
    Shared arrTemp As New ArrayList
    Public Shared Sub LoadTrangThaiTB(ByVal dr As DropDownList)
        dr.Items.Clear()
        dr.Items.Add(New ListItem("Tất cả doanh nghiệp", "0"))
        dr.Items.Add(New ListItem("Đã gửi thông báo cho doanh nghiệp", "1"))
        dr.Items.Add(New ListItem("Chưa gửi thông báo doanh nghiệp", "2"))
    End Sub
    Public Shared Sub LoadTrangThaiBC(ByVal dr As DropDownList)
        dr.Items.Clear()
        dr.Items.Add(New ListItem("Tất cả doanh nghiệp", "0"))
        dr.Items.Add(New ListItem("Đã cập nhật thông tin DN", "1"))
        dr.Items.Add(New ListItem("Chưa cập nhật thông tin DN", "2"))
    End Sub
    Public Shared Sub LoadPeriod(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - Chọn kỳ báo cáo - -", 0))
        drGroup.Items.Add(New ListItem("6 tháng đầu năm", 1))
        drGroup.Items.Add(New ListItem("6 tháng cuối năm", 2))
    End Sub
    Public Shared Sub LoadLoaiHinhDN(PortalConnect As Integer, ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - - Chọn - - -", "0"))
        For Each Ci As BC_CompanyTypeInfo In ObjControler.BC_CompanyType_List(PortalConnect)
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.TenLoaiHinh, False), Ci.ID))
        Next
    End Sub
    Public Shared Sub LoadThanhThi(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - - Chọn - - -", "0"))
        drGroup.Items.Add(New ListItem("Thành thị", "1"))
        drGroup.Items.Add(New ListItem("Nông thôn", "2"))
    End Sub
    Public Shared Sub LoadTinhTrang(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - - Chọn - - -", "0"))
        drGroup.Items.Add(New ListItem("1. Đang hoạt động", "1"))
        drGroup.Items.Add(New ListItem("2. Không hoạt động", "2"))
        drGroup.Items.Add(New ListItem("3. Không tìm thấy", "3"))
    End Sub
    Public Shared Sub LoadQuyMo(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - - Chọn - - -", "0"))
        drGroup.Items.Add(New ListItem("< 10", "1"))
        drGroup.Items.Add(New ListItem("10 - 50", "2"))
        drGroup.Items.Add(New ListItem("51 - 100", "3"))
        drGroup.Items.Add(New ListItem("101 - 200", "4"))
        drGroup.Items.Add(New ListItem("201 - 500", "5"))
        drGroup.Items.Add(New ListItem("501 - 1.000", "6"))
        drGroup.Items.Add(New ListItem("1.001 - 3.000", "7"))
        drGroup.Items.Add(New ListItem("3.001 - 10.000", "8"))
        drGroup.Items.Add(New ListItem("> 10.000", "9"))
    End Sub
    Public Shared Sub LoadKhuCongNghiep(PortalConnect As Integer, drGroup As DropDownList, tinhTP As Integer, quanHuyen As Integer, Parent_ID As String, Optional ByVal stext As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If stext <> "" Then drGroup.Items.Add(New ListItem(stext, ""))
        For Each Ci As BC_IndustrialZoneInfo In ObjControler.BC_IndustrialZone_List_ByTP(PortalConnect, tinhTP, quanHuyen, Parent_ID)
            drGroup.Items.Add(New ListItem(Ci.IndustrialZone_Name, Ci.IndustrialZone_ID))
        Next
    End Sub
    Private Shared Sub CareerChild(PortalConnect As Integer, Career_ID As String, strO As String)
        For Each Cis As BC_CareerInfo In ObjControler.BC_Career_Get_By_BC_Career(PortalConnect, Career_ID)
            If strO = "" Then strO = "--"
            strOld = strO & "--"
            Cis.Career_Name = strOld & " " & Cis.Career_Name
            arrTemp.Add(Cis)
            Call CareerChild(PortalConnect, Cis.Career_ID, strOld)
        Next
    End Sub
    Public Shared Sub LoadCareerBC(PortalConnect As Integer, drGroup As DropDownList, Optional ByVal sText As String = "- - - Chọn - - -")
        arrTemp = New ArrayList
        For Each Ci As BC_CareerInfo In ObjControler.BC_Career_List_Parent_Null(PortalConnect)
            arrTemp.Add(Ci)
            Call CareerChild(PortalConnect, Ci.Career_ID, "")
        Next
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem(sText, ""))
        For Each Ci As BC_CareerInfo In arrTemp
            drGroup.Items.Add(New ListItem(Ci.Career_Name, Ci.Career_ID))
        Next
    End Sub
    Public Shared Sub LoadNganhNghe(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        If IsNothing(flCache.GetCache("LoadNganhNghe_" & PortalId)) Then
            arrTemp = ObjControler.BC_Career_Get_By_BC_Career(PortalId, 0)
            flCache.SetCache("LoadNganhNghe_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("LoadNganhNghe_" & PortalId), ArrayList)
        End If
        dr.Items.Clear()
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As BC_CareerInfo In arrTemp
            dr.Items.Add(New ListItem(Ci.Career_ID & "." & flReg.RemoveScript(Ci.Career_Name, False), Ci.Career_ID))
        Next
    End Sub
    Public Shared Sub LoadCareer_Parent_Null(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        If IsNothing(flCache.GetCache("BC_Career_List_Parent_Null_" & PortalId)) Then
            arrTemp = ObjControler.BC_Career_List_Parent_Null(PortalId)
            flCache.SetCache("BC_Career_List_Parent_Null_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("BC_Career_List_Parent_Null_" & PortalId), ArrayList)
        End If
        dr.Items.Clear()
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As BC_CareerInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Career_Name, False), Ci.Career_ID))
        Next

    End Sub
    Public Shared Sub LoadCareer_Parent_ID(PortalId As Integer, dr As DropDownList, Parent_ID As String, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal Types As String = "[QH][XP][THON]")
        Parent_ID = flReg.WriteNumber(Parent_ID)
        If IsNothing(flCache.GetCache("BC_Career_Get_By_BC_Career_" & PortalId & "_" & Parent_ID)) Then
            arrTemp = ObjControler.BC_Career_Get_By_BC_Career(PortalId, Parent_ID)
            flCache.SetCache("BC_Career_Get_By_BC_Career_" & PortalId & "_" & Parent_ID, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("BC_Career_Get_By_BC_Career_" & PortalId & "_" & Parent_ID), ArrayList)
        End If
        dr.Items.Clear()
        dr.Items.Add(New ListItem(text, ""))
        For Each Ci As BC_CareerInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Career_Name, False), Ci.Career_ID))
        Next
    End Sub

End Class
