Imports System.Web.UI.WebControls
Imports DotNetNuke.EPORTAL

Public Class flFunction

	Shared arrTemp, arrTemp1 As New ArrayList
    Shared ObjControler As New MapController

    Public Shared Function ReadLocation(PageLoca_ID As String) As String
        ReadLocation = flCache.GetCache("ReadLocation" & PageLoca_ID) & ""
        If ReadLocation & "" = "" Then
            Dim objInfo As CMS_PageLocalInfo = ObjControler.CMS_PageLocal_Get(flConnect.PortalId, PageLoca_ID)
            If IsNothing(objInfo) = False Then
                flCache.SetCache("ReadLocation" & PageLoca_ID, objInfo.PageLocal_Name)
                Return objInfo.PageLocal_Name
            Else
                Return ""
            End If
        End If
    End Function
    Public Shared Sub LoadLocation(dr As DropDownList, Optional ByVal isText As String = "")
        dr.Items.Clear()
        arrTemp = ObjControler.CMS_PageLocal_List(flConnect.PortalId)
        If isText <> "" Then dr.Items.Add(New ListItem(isText, "0"))
        For Each Cr As CMS_PageLocalInfo In arrTemp
            dr.Items.Add(New ListItem(Cr.PageLocal_Name, Cr.PageLocalID))
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

    Public Shared Sub LoadColors(PortalId As Integer, drp As DropDownList, Optional ByVal isText As String = "")

        arrTemp = ObjControler.MauSac_List(PortalId)
        If isText <> "" Then drp.Items.Add(New ListItem(isText, "0"))
        For Each Ci As MauSacInfo In arrTemp
            drp.Items.Add(New ListItem(flReg.RemoveScript(Ci.TenMauSac, False), Ci.ThuocTinh))
        Next
    End Sub
    Private Shared Sub LoadTargets(PortalId As Integer, Targets_ID As Integer, strO As String)

        Dim strOld As String
        For Each Cis As CMS_TargetsInfo In ObjControler.CMS_Targets_Get_By_CMS_Targets(PortalId, Targets_ID)
            If strO = "" Then strO = "|--- "
            strOld = strO & "|--- "
            Cis.Targets_Name = strOld & " " & Cis.Targets_Name
            arrTemp1.Add(Cis)
            Call LoadTargets(PortalId, Cis.Targets_ID, strOld)
        Next
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
    Public Shared Sub LoadMenu(ByVal drGroup As DropDownList, PortalID As Integer)
        drGroup.Items.Clear()
        If IsNothing(flCache.GetCache("LoadMenu" & PortalID)) = True Then
            arrTemp = ObjControler.CMS_Menu_List(PortalID, PortalID)
            flCache.SetCache("LoadMenu" & PortalID, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("LoadMenu" & PortalID), ArrayList)
        End If
        For Each Cr As CMS_MenuInfo In arrTemp
            drGroup.Items.Add(New ListItem(Cr.MenuName, Cr.MenuID))
        Next
    End Sub
    'Public Shared Sub LoadDocGroup_Parent_Null(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
    '    dr.Items.Clear()

    '    If IsNothing(flCache.GetCache("CMS_DocGroup_List_Parent_NULL_" & PortalId)) Then
    '        arrTemp1 = ObjControler.CMS_DocGroup_List_Parent_NULL(PortalId)
    '        flCache.SetCache("CMS_DocGroup_List_Parent_NULL_" & PortalId, arrTemp1)
    '    Else
    '        arrTemp1 = CType(flCache.GetCache("CMS_DocGroup_List_Parent_NULL_" & PortalId), ArrayList)
    '    End If
    '    If text <> "" Then dr.Items.Add(New ListItem(text, ""))
    '    For Each Ci As CMS_DocGroupInfo In arrTemp1
    '        dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.DocGroup_Name, False), Ci.DocGroupID))
    '    Next
    'End Sub
    'Public Shared Sub LoadDocGroup_Parent_ID(PortalId As Integer, dr As DropDownList, Parent_ID As String, Optional ByVal text As String = "- - - Chọn - - -")
    '    dr.Items.Clear()
    '    If IsNothing(flCache.GetCache("CMS_DocGroup_Get_By_CMS_DocGroup_" & PortalId & "_" & Parent_ID)) Then
    '        arrTemp1 = ObjControler.CMS_DocGroup_Get_By_CMS_DocGroup(PortalId, Parent_ID)
    '        flCache.SetCache("CMS_DocGroup_Get_By_CMS_DocGroup_" & PortalId & "_" & Parent_ID, arrTemp1)
    '    Else
    '        arrTemp1 = CType(flCache.GetCache("CMS_DocGroup_Get_By_CMS_DocGroup_" & PortalId & "_" & Parent_ID), ArrayList)
    '    End If
    '    If text <> "" Then dr.Items.Add(New ListItem(text, ""))
    '    For Each Ci As CMS_DocGroupInfo In arrTemp1
    '        dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.DocGroup_Name, False), Ci.DocGroupID))
    '    Next
    'End Sub
    'Public Shared Sub LoadDocField(PortalConnect As String, dr As DropDownList, Optional ByVal isText As String = "")
    '    dr.Items.Clear()
    '    arrTemp = ObjControler.CMS_DocField_List(PortalConnect, PortalConnect)
    '    If isText <> "" Then dr.Items.Add(New ListItem(isText, ""))
    '    For Each Cr As CMS_DocFieldInfo In arrTemp
    '        dr.Items.Add(New ListItem(Cr.DocField_Name, Cr.DocField_ID))
    '    Next
    'End Sub
    'Public Shared Sub LoadDocUnit(PortalConnect As String, dr As DropDownList, Optional ByVal isText As String = "")
    '    dr.Items.Clear()
    '    arrTemp = ObjControler.CMS_DocUnit_List(PortalConnect, PortalConnect)
    '    If isText <> "" Then dr.Items.Add(New ListItem(isText, ""))
    '    For Each Cr As CMS_DocUnitInfo In arrTemp
    '        dr.Items.Add(New ListItem(Cr.DocUnit_Name, Cr.DocUnit_ID))
    '    Next
    'End Sub
    'Public Shared Sub LoadRssSource(PortalConnect As String, dr As DropDownList, Optional ByVal isText As String = "")
    '    dr.Items.Clear()
    '    arrTemp = ObjControler.NewsSource_List(PortalConnect, PortalConnect)
    '    If isText <> "" Then dr.Items.Add(New ListItem(isText, ""))
    '    For Each Cr As NewsSourceInfo In arrTemp
    '        dr.Items.Add(New ListItem(Cr.Name, Cr.NewsSourceID))
    '    Next
    'End Sub
    'Public Shared Sub LoadDocType(PortalConnect As String, dr As DropDownList, Optional ByVal isText As String = "")
    '    dr.Items.Clear()
    '    arrTemp = ObjControler.CMS_DocType_List(PortalConnect, PortalConnect)
    '    If isText <> "" Then dr.Items.Add(New ListItem(isText, ""))
    '    For Each Cr As CMS_DocTypeInfo In arrTemp
    '        dr.Items.Add(New ListItem(Cr.DocType_Name, Cr.DocType_ID))
    '    Next
    'End Sub
    Public Shared Sub LoadUserRole(PortalConnect As String, UserName As String, RoleName As String, dr As DropDownList, Optional ByVal isText As String = "")
        dr.Items.Clear()
        dr.Items.Add(New ListItem(isText, ""))
        arrTemp = flDnn.DNN_User_List_By_Role(PortalConnect, RoleName, UserName)
        For Each Cr As DnnInfo In arrTemp
            dr.Items.Add(New ListItem(Cr.DisplayName.Replace("  ", " "), Cr.Username))
        Next
    End Sub
    Public Shared Sub LoadYears(dr As DropDownList)
        ' Define the range of years you want to display
        Dim startYear As Integer = 2020 ' Start year
        Dim endYear As Integer = DateTime.Now.AddYears(3).Year ' Current year

        ' Populate DropDownList with years
        For year As Integer = endYear To startYear Step -1
            dr.Items.Add(New ListItem(year.ToString(), year.ToString()))
        Next
        ' Optionally, set the default selected year
        dr.SelectedValue = DateTime.Now.Year.ToString()
    End Sub
    Public Shared Sub LoadStatus(ByVal drList As DropDownList)
		drList.Items.Clear()
		drList.Items.Add(New ListItem("- - Tất cả trạng thái - - ", -1))
		drList.Items.Add(New ListItem("Đang biên soạn", NewsStatus.DangBienSoan))
		drList.Items.Add(New ListItem("Đã xuất bản", NewsStatus.DaXuatBan))
		drList.Items.Add(New ListItem("Ngừng xuất bản", NewsStatus.HuyXuatBan))
	End Sub
	Public Shared Sub LoadCategoryType(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem(("News"), CategoryType.News))
        drGroup.Items.Add(New ListItem(("Video"), CategoryType.Video))
        drGroup.Items.Add(New ListItem(("Audio"), CategoryType.Audio))
        drGroup.Items.Add(New ListItem(("Album"), CategoryType.Album))
        drGroup.Items.Add(New ListItem(("Document"), CategoryType.VanBan))
        drGroup.Items.Add(New ListItem(("Menu"), CategoryType.Menu))
    End Sub
    'Public Shared Sub LoadUserDepart(PortalConnect As String, UserName As String, dr As DropDownList, Optional ByVal isText As String = "")
    '    dr.Items.Clear()
    '    dr.Items.Add(New ListItem(isText, ""))
    '    arrTemp = ObjControler.CMS_Departments_NguoiDung_Get_By_UserId(PortalConnect, UserName, PortalConnect)
    '    For Each Cr As CMS_Departments_NguoiDungInfo In arrTemp
    '        dr.Items.Add(New ListItem(flReg.GetUserName(Cr.UserId), Cr.UserId))
    '    Next
    'End Sub
    'Public Shared Function ReadLocation(PageLoca_ID As String) As String
    '    ReadLocation = flCache.GetCache("ReadLocation" & PageLoca_ID) & ""
    '    If ReadLocation & "" = "" Then
    '        Dim objInfo As CMS_PageLocalInfo = ObjControler.CMS_PageLocal_Get(flConnect.PortalId, PageLoca_ID)
    '        If IsNothing(objInfo) = False Then
    '            flCache.SetCache("ReadLocation" & PageLoca_ID, objInfo.PageLocal_Name)
    '            Return objInfo.PageLocal_Name
    '        Else
    '            Return ""
    '        End If
    '    End If
    'End Function
    'Public Shared Sub LoadLocation(dr As DropDownList, Optional ByVal isText As String = "")
    '    dr.Items.Clear()
    '    arrTemp = ObjControler.CMS_PageLocal_List(flConnect.PortalId)
    '    If isText <> "" Then dr.Items.Add(New ListItem(isText, "0"))
    '    For Each Cr As CMS_PageLocalInfo In arrTemp
    '        dr.Items.Add(New ListItem(Cr.PageLocal_Name, Cr.PageLocalID))
    '    Next
    'End Sub
    Public Shared Sub LoadWebLinkType(ByVal drList As DropDownList)
        drList.Items.Clear()
        drList.Items.Add(New ListItem("- - - Chọn liên kết - - - ", 0))
        drList.Items.Add(New ListItem("Liên kết nội bộ ", WebLinkType.NoiBo))
        drList.Items.Add(New ListItem("Liên kết website", WebLinkType.Website))
        drList.Items.Add(New ListItem("Liên kết khác", WebLinkType.Khac))
    End Sub
    'Public Shared Sub BindddlCategories(ByVal drGroup As DropDownList, PortalID As Integer, ParentID As Integer, UserID As String, str As String, Optional ByVal intType As Integer = 1)
    '    If IsNothing(flCache.GetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType & ParentID)) = True Then
    '        arrTemp1 = ObjControler.CMS_NewsCategories_Get_By_ParentId(PortalID, PortalID, flConnect.IsLang, UserID, intType, ParentID)
    '        flCache.SetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType & ParentID, arrTemp1)
    '    Else
    '        arrTemp1 = CType(flCache.GetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType & ParentID), ArrayList)

    '    End If
    '    For Each Cr1 As CMS_NewsCategoriesInfo In arrTemp1
    '        drGroup.Items.Add(New ListItem(str & flReg.RemoveScript(Cr1.CategoryName, False), Cr1.CategoryID))
    '        Call BindddlCategories(drGroup, PortalID, Cr1.CategoryID, UserID, str & "|--- ", intType)
    '    Next
    'End Sub
    'Public Shared Sub LoadCategories(ByVal drGroup As DropDownList, PortalID As Integer, UserID As String, Optional ByVal intType As Integer = 1, Optional ByVal searchText As String = "- - - Chọn chuyên mục - - -", Optional ByVal val As String = "0")
    '    drGroup.Items.Clear()
    '    drGroup.Items.Add(New ListItem(searchText, val))
    '    If IsNothing(flCache.GetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType)) = True Then
    '        arrTemp = ObjControler.CMS_NewsCategories_Get_By_ParentId(PortalID, PortalID, flConnect.IsLang, UserID, intType, 0)
    '        flCache.SetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType, arrTemp)
    '    Else
    '        arrTemp = CType(flCache.GetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType), ArrayList)
    '    End If
    '    For Each Cr As CMS_NewsCategoriesInfo In arrTemp
    '        drGroup.Items.Add(New ListItem(flReg.RemoveScript(Cr.CategoryName, False), Cr.CategoryID))
    '        Call BindddlCategories(drGroup, PortalID, Cr.CategoryID, UserID, "|--- ", intType)
    '    Next
    'End Sub
    'Public Shared Sub LoadCategoriesFrontend(ByVal drGroup As DropDownList, PortalID As Integer, UserID As String, Optional ByVal intType As Integer = 1, Optional ByVal searchText As String = "- - - Chọn chuyên mục - - -")
    '    drGroup.Items.Clear()
    '    If IsNothing(flCache.GetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType)) = True Then
    '        arrTemp = ObjControler.CMS_NewsCategories_Get_By_ParentId(PortalID, PortalID, flConnect.IsLang, UserID, intType, 0)
    '        flCache.SetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType, arrTemp)
    '    Else
    '        arrTemp = CType(flCache.GetCache("NewsCategories_Get_By_ParentId" & PortalID & UserID & intType), ArrayList)
    '    End If
    '    For Each Cr As CMS_NewsCategoriesInfo In arrTemp
    '        drGroup.Items.Add(New ListItem(flReg.RemoveScript(Cr.CategoryName, False), Cr.CategoryID))
    '        Call BindddlCategories(drGroup, PortalID, Cr.CategoryID, UserID, "|--- ", intType)
    '    Next
    'End Sub
    'Public Shared Sub LoadMenu(ByVal drGroup As DropDownList, PortalID As Integer)
    '    drGroup.Items.Clear()
    '    If IsNothing(flCache.GetCache("LoadMenu" & PortalID)) = True Then
    '        arrTemp = ObjControler.CMS_Menu_List(PortalID, PortalID)
    '        flCache.SetCache("LoadMenu" & PortalID, arrTemp)
    '    Else
    '        arrTemp = CType(flCache.GetCache("LoadMenu" & PortalID), ArrayList)
    '    End If
    '    For Each Cr As CMS_MenuInfo In arrTemp
    '        drGroup.Items.Add(New ListItem(Cr.MenuName, Cr.MenuID))
    '    Next
    'End Sub
    'Public Shared Sub LoadPhienGiaoLuu(ByVal drGroup As DropDownList, PortalID As Integer)
    '    drGroup.Items.Clear()
    '    arrTemp = ObjControler.CMS_FAQ_List(PortalID, PortalID)
    '    For Each Cr As CMS_FAQInfo In arrTemp
    '        drGroup.Items.Add(New ListItem(flReg.RemoveScript(Cr.Name, False), Cr.Id))
    '    Next
    'End Sub
    'Public Shared Sub LoadPhienGiaoLuuQuest(ByVal drGroup As DropDownList, PortalID As Integer, FaqId As String)
    '    drGroup.Items.Clear()
    '    arrTemp = ObjControler.CMS_FAQQuestions_List_Search(PortalID, "", FaqId, 1, 1, 1000, "", 0)
    '    For Each Cr As CMS_FAQQuestionsInfo In arrTemp
    '        drGroup.Items.Add(New ListItem(flReg.RemoveScript(Cr.Name, False), Cr.Id))
    '    Next
    'End Sub
    'Public Shared Sub SaveSetup(PortalID As Integer, SettingName As String, SettingValue As String, UserName As String)
    '    Try
    '        Dim obj As New CMS_SetupsInfo
    '        obj.ID = flReg.GenKey()
    '        obj.PortalID = PortalID
    '        obj.SettingName = SettingName
    '        obj.SettingValue = SettingValue
    '        obj.CreatedBy = Now
    '        obj.UserName = UserName
    '        obj.UpdatedBy = Now
    '        obj.UpdatedUser = UserName
    '        ObjControler.CMS_Setups_Add(PortalID, obj)
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Public Class Response
        Public Property Data As Object
        Public Property Status As Int16
        Public Property Message As String
    End Class
End Class
