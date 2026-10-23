Imports System.Web.UI.WebControls
Imports DotNetNuke.EPORTAL

Public Class flFunction
    Shared strOld As String
    Shared arrTemp, arrTemp1 As New ArrayList
    Shared ObjControler As New AnalyController
    Shared trgInfo As New CMS_TargetsInfo

    Private Shared Sub LoadTargets(PortalId As Integer, Targets_ID As Integer, strO As String)
        For Each Cis As CMS_TargetsInfo In ObjControler.CMS_Targets_Get_By_CMS_Targets(PortalId, Targets_ID)
            If strO = "" Then strO = "|--- "
            strOld = strO & "|--- "
            Cis.Targets_Name = strOld & " " & Cis.Targets_Name
            arrTemp1.Add(Cis)
            Call LoadTargets(PortalId, Cis.Targets_ID, strOld)
        Next
    End Sub

    Public Shared Sub LoadUnitType(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Đơn vị tính - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_UnitTypeInfo In ObjControler.CMS_UnitType_List(PortalId)
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.UnitType_Name, False), Ci.UnitType_ID))
        Next
    End Sub
    Public Shared Sub LoadGroup(PortalId As Integer, drGroup As DropDownList, ASXH_ID As Integer, Optional ByVal Targets_ID As Integer = 0, Optional ByVal text As String = "- - - Nhóm chỉ tiêu - - -", Optional ByVal paName As Boolean = False)
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        If paName = True Then
            For Each Ci As CMS_GroupInfo In ObjControler.CMS_Group_List_By_ParentID(PortalId, ASXH_ID, "-1")
                drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Group_Name, False), Ci.Group_ID))
                For Each Ci2 As CMS_GroupInfo In ObjControler.CMS_Group_List_By_ParentID(PortalId, "-1", Ci.Group_ID)
                    drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Group_Name, False) & " |--> " & flReg.RemoveScript(Ci2.Group_Name, False), Ci2.Group_ID))
                Next
            Next
        Else
            For Each Ci As CMS_GroupInfo In ObjControler.CMS_Group_List_By_ParentID(PortalId, ASXH_ID, "-1")
                drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Group_Name, False), Ci.Group_ID))
                For Each Ci2 As CMS_GroupInfo In ObjControler.CMS_Group_List_By_ParentID(PortalId, "-1", Ci.Group_ID)
                    drGroup.Items.Add(New ListItem("|--- " & flReg.RemoveScript(Ci2.Group_Name, False), Ci2.Group_ID))
                Next
            Next
        End If
    End Sub
    Public Shared Sub LoadTargets(PortalId As Integer, TinhTp As Integer, drp As DropDownList, group_ID As Integer, Optional ByVal text As String = "- - - Chọn - - -")
        arrTemp = ObjControler.CMS_Targets_List_Parent_Null(PortalId, TinhTp, group_ID)
        arrTemp1.Clear()
        For Each Ci As CMS_TargetsInfo In arrTemp
            arrTemp1.Add(Ci)
            Call LoadTargets(PortalId, Ci.Targets_ID, "")
        Next
        drp.Items.Clear()
        If text <> "" Then drp.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TargetsInfo In arrTemp1
            drp.Items.Add(New ListItem(flReg.RemoveScript(Ci.Targets_Name, False), Ci.Targets_ID))
        Next
    End Sub
    Public Shared Sub LoadTargetsByCateTar(PortalId As Integer, drp As DropDownList, group_ID As Integer, Optional ByVal text As String = "- - - Chọn - - -")
        arrTemp = ObjControler.CMS_Targets_List_ByCateTar(PortalId, group_ID)
        arrTemp1.Clear()
        For Each Ci As CMS_TargetsInfo In arrTemp
            arrTemp1.Add(Ci)
            Call LoadTargets(PortalId, Ci.Targets_ID, "")
        Next
        drp.Items.Clear()
        If text <> "" Then drp.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TargetsInfo In arrTemp1
            drp.Items.Add(New ListItem(flReg.RemoveScript(Ci.Targets_Name, False), Ci.Targets_ID))
        Next
    End Sub
    Public Shared Sub LoadCateTar(PortalId As Integer, drp As DropDownList, target_ID As Integer, Optional ByVal text As String = "- - - Chọn - - -")
        arrTemp = ObjControler.CMS_CateTar_List_ByTarget(PortalId, target_ID)
        drp.Items.Clear()
        If text <> "" Then drp.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_CateTarInfo In arrTemp
            drp.Items.Add(New ListItem(flReg.RemoveScript(Ci.CateName, False), Ci.CodeCateTar))
        Next
    End Sub

    Public Shared Sub LoadTargets_Parent_Null(PortalId As Integer, TinhTp As Integer, drGroup As DropDownList, group_ID As Integer, Optional ByVal text As String = "- - - Chọn - - -")
        arrTemp = ObjControler.CMS_Targets_List_Parent_Null(PortalId, TinhTp, group_ID)
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TargetsInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Targets_Name, False), Ci.Targets_ID))
        Next
    End Sub
    Public Shared Sub LoadTypeScene(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        arrTemp = ObjControler.CMS_TypeScene_List(PortalId)
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TypeSceneInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.TypeScene_Name, False), Ci.TypeScene_ID))
        Next
    End Sub
    Public Shared Sub LoadGroup_Parent_Null(PortalId As Integer, drGroup As DropDownList, asxh_ID As Integer, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal GroupType As Int16 = 0)
        arrTemp = ObjControler.CMS_Group_List_Parent_Null(PortalId, asxh_ID, GroupType)
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_GroupInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Group_Name, False), Ci.Group_ID))
        Next
    End Sub
    Public Shared Sub LoadTargets_ForAnalytic(PortalId As Integer, drGroup As DropDownList, tinhTP As Integer, quanhuyen As Integer, phuongxa As Integer, asxh_id As Integer, GroupID As Integer, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TargetsInfo In ObjControler.CMS_Targets_Parent_Search_ID(PortalId, tinhTP, quanhuyen, phuongxa, "", asxh_id, GroupID, "-1", 1, -1)
            strOld = Ci.Targets_Name
            If Ci.IsHome Then
                If Ci.Parent_ID > 0 Then
                    strOld = flCheck.Target_Name(PortalId, Ci.Parent_ID) & " --> " & strOld
                End If
                drGroup.Items.Add(New ListItem(flReg.RemoveScript(strOld, False), Ci.Targets_ID))
            ElseIf Ci.IsChild Then
                trgInfo = ObjControler.CMS_Targets_Get(PortalId, Ci.Parent_ID)
                If IsNothing(trgInfo) = False Then
                    strOld = trgInfo.Targets_Name & " --> " & Ci.Targets_Name

                    If trgInfo.Parent_ID > 0 Then
                        strOld = flCheck.Target_Name(PortalId, trgInfo.Parent_ID) & " --> " & strOld
                    End If
                End If
                drGroup.Items.Add(New ListItem(flReg.RemoveScript(strOld, False), Ci.Targets_ID))
            End If
        Next
    End Sub
    Public Shared Sub LoadTinhTrang(drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, "-1"))
        drGroup.Items.Add(New ListItem("Chưa nhập", TinhTrang.ChuaNhap))
        drGroup.Items.Add(New ListItem("Đang nhập", TinhTrang.DangNhap))
        drGroup.Items.Add(New ListItem("Đã nộp", TinhTrang.DaNop))
        drGroup.Items.Add(New ListItem("Trả lại", TinhTrang.TraLai))
    End Sub
    Public Shared Sub LoadFlagAnalytic(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Mức cảnh báo - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        drGroup.Items.Add(New ListItem("Bình thường", FlagAnalytic.BinhThuong))
        drGroup.Items.Add(New ListItem("Tốt", FlagAnalytic.Tot))
        drGroup.Items.Add(New ListItem("Xấu", FlagAnalytic.Xau))
        drGroup.Items.Add(New ListItem("Rất xấu", FlagAnalytic.RatXau))
    End Sub

    Public Shared Sub LoadChartType(drGroup As DropDownList, isFlag As Integer, Optional ByVal text As String = "- - - Loại biểu đồ - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        If isFlag = 0 Then
            drGroup.Items.Add(New ListItem("Biểu đồ cột", ChartType.Cot))
            drGroup.Items.Add(New ListItem("Biểu đồ đường", ChartType.Duong))
            drGroup.Items.Add(New ListItem("Biểu đồ đường khu vực", ChartType.DuongKhuVuc))
        Else
            drGroup.Items.Add(New ListItem("Biểu đồ cột", ChartType.Cot))
            drGroup.Items.Add(New ListItem("Biểu đồ đường", ChartType.Duong))
        End If
    End Sub
    Public Shared Sub LoadMagazine_Type(drGroup As DropDownList, Optional ByVal text As String = "- - - Loại loại ấn phẩm - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        drGroup.Items.Add(New ListItem("Biểu đồ", MagazineType.BieuDo))
        drGroup.Items.Add(New ListItem("Bảng dữ liệu", MagazineType.BangDuLieu))
        drGroup.Items.Add(New ListItem("Phân tích", MagazineType.PhanTich))
        drGroup.Items.Add(New ListItem("Hỗn hợp", MagazineType.HonHop))
    End Sub
End Class
