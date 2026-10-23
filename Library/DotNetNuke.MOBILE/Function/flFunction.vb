Imports System.Threading
Imports System.Web
Imports System.Web.UI.WebControls
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.Entities.Users
Imports DotNetNuke.VBN

Public Class flFunction
    Shared ObjControler As New MobileController
    Shared arr, arr1 As New ArrayList
    Shared ndp As New lichNgayInfo
    Shared staDay As Integer
    Public Shared Sub LoadVanChuyen(PortalConnect As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        If IsNothing(flCache.GetCache("CMS_VanChuyen_List_" & PortalConnect)) = True Then
            arr = ObjControler.CMS_VanChuyen_List(PortalConnect)
            flCache.SetCache("CMS_VanChuyen_List_" & PortalConnect, arr)
        Else
            arr = CType(flCache.GetCache("CMS_VanChuyen_List_" & PortalConnect), ArrayList)
        End If
        For Each Ck As CMS_VanChuyenInfo In arr
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.TenDonVi, False), Ck.ID))
        Next
    End Sub
    Public Shared Sub LoadHoiNhom(drList As DropDownList, Optional ByVal isAll As Boolean = True)
        drList.Items.Clear()
        If isAll Then drList.Items.Add(New ListItem("- - Chọn - - ", 0))
        drList.Items.Add(New ListItem("Bé cùng tuổi", hoiNhom.CungTuoi))
        drList.Items.Add(New ListItem("Làm mẹ thông thái", hoiNhom.LamMe))
        drList.Items.Add(New ListItem("Sức khỏe & sắc đẹp", hoiNhom.SucKhoe))
        drList.Items.Add(New ListItem("Tâm sự thầm kín", hoiNhom.TamSu))
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
    Public Shared Sub LoadFrGroup(PortalId As Integer, drList As DropDownList, isType As Integer)
        drList.Items.Clear()
        drList.Items.Add(New ListItem("- - Chọn - - ", 0))
        For Each cr As CMS_Fr_GroupInfo In ObjControler.CMS_Fr_Group_List_ByIsType(PortalId, isType)
            drList.Items.Add(New ListItem(cr.Name, cr.ID))
        Next
    End Sub
    Public Shared Sub LoadSex(drList As DropDownList)
        drList.Items.Clear()
        drList.Items.Add(New ListItem("- - Chọn - - ", 0))
        drList.Items.Add(New ListItem("Nam", 1))
        drList.Items.Add(New ListItem("Nữ", 2))
    End Sub
    Public Shared Sub LoadAppID(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        If IsNothing(flCache.GetCache("CMS_App_List_" & PortalId)) = True Then
            arr = ObjControler.CMS_App_List(PortalId)
            flCache.SetCache("CMS_App_List_" & PortalId, arr)
        Else
            arr = CType(flCache.GetCache("CMS_App_List_" & PortalId), ArrayList)
        End If
        For Each Ck As CMS_AppInfo In arr
            If Ck.HoVaTen <> "" Then
                drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.HoVaTen, False), flReg.RemoveScript(Ck.AppID, False)))
            End If
        Next
    End Sub
    Public Shared Function IconRandom() As Integer
        Return New Random().Next(1, 80)
    End Function
    Public Shared Function addFrNotify(pid As Integer, mID As Integer, fromApp As String, toApp As String, idKey As String, toLink As String, flags As String, contents As String, allPublic As Boolean) As CMS_Fr_NotifyInfo
        addFrNotify = New CMS_Fr_NotifyInfo
        addFrNotify.PortalID = mID
        addFrNotify.FromApp = fromApp
        addFrNotify.ToApp = toApp
        addFrNotify.Contents = contents
        addFrNotify.ToLink = toLink
        addFrNotify.IdKey = idKey
        addFrNotify.Flags = flags
        addFrNotify.AllPublic = allPublic
        addFrNotify.CreatedDate = Now
        ObjControler.CMS_Fr_Notify_Add(pid, addFrNotify)
    End Function
    Public Shared Sub LoadStoryC(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, "-1"))
        If IsNothing(flCache.GetCache("CMS_StoryC_List_" & PortalId)) = True Then
            arr = ObjControler.CMS_StoryC_List(PortalId, 0)
            flCache.SetCache("CMS_StoryC_List_" & PortalId, arr)
        Else
            arr = CType(flCache.GetCache("CMS_StoryC_List_" & PortalId), ArrayList)
        End If
        For Each Ck As CMS_StoryCInfo In arr
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.Name, False), Ck.ID))
        Next
    End Sub
    Public Shared Sub LoadFoodC(PortalId As Integer, mID As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, "-1"))
        If IsNothing(flCache.GetCache("CMS_FoodC_List_" & PortalId & "_" & mID)) = True Then
            arr = ObjControler.CMS_FoodC_List(PortalId, mID)
            flCache.SetCache("CMS_FoodC_List_" & PortalId & "_" & mID, arr)
        Else
            arr = CType(flCache.GetCache("CMS_FoodC_List_" & PortalId & "_" & mID), ArrayList)
        End If
        For Each Ck As CMS_FoodCInfo In arr
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.Name, False), Ck.ID))
        Next
    End Sub
    Public Shared Sub LoadCookingC(PortalId As Integer, mID As Integer, ID As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If ID = "0" Then
            If text <> "" Then drGroup.Items.Add(New ListItem(text, "-1"))
            If IsNothing(flCache.GetCache("CMS_CookingC_List_" & PortalId & "_" & mID)) = True Then
                arr = ObjControler.CMS_CookingC_List(PortalId, mID)
                flCache.SetCache("CMS_CookingC_List_" & PortalId & "_" & mID, arr)
            Else
                arr = CType(flCache.GetCache("CMS_CookingC_List_" & PortalId & "_" & mID), ArrayList)
            End If
            For Each Ck As CMS_CookingCInfo In arr
                drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.Name, False), Ck.ID))
            Next
        Else
            If text <> "" Then drGroup.Items.Add(New ListItem(text, "-1"))
            If IsNothing(flCache.GetCache("CMS_CookingO_List_Cooking_" & PortalId & "_" & ID)) = True Then
                arr = ObjControler.CMS_CookingO_List_Cooking(PortalId, ID)
                flCache.SetCache("CMS_CookingO_List_Cooking_" & PortalId & "_" & ID, arr)
            Else
                arr = CType(flCache.GetCache("CMS_CookingO_List_Cooking_" & PortalId & "_" & ID), ArrayList)
            End If
            For Each Ck As CMS_CookingOInfo In arr
                drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.CateName, False), Ck.CateID))
            Next
        End If

    End Sub
    Public Shared Sub LoadCookingD(PortalId As Integer, isType As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        If IsNothing(flCache.GetCache("CMS_CookingD_List_By_Type_" & PortalId & "_" & isType)) = True Then
            arr = ObjControler.CMS_CookingD_List_By_Type(PortalId, isType)
            flCache.SetCache("CMS_CookingD_List_By_Type_" & PortalId & "_" & isType, arr)
        Else
            arr = CType(flCache.GetCache("CMS_CookingD_List_By_Type_" & PortalId & "_" & isType), ArrayList)
        End If
        For Each Ck As CMS_CookingDInfo In arr
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.Name, False), flReg.RemoveScript(Ck.Name, False)))
        Next
    End Sub
    Public Shared Sub LoadStoryAuthor(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        If IsNothing(flCache.GetCache("CMS_Story_List_By_Author_" & PortalId)) = True Then
            arr = ObjControler.CMS_Story_List_By_Author(PortalId)
            flCache.SetCache("CMS_Story_List_By_Author_" & PortalId, arr)
        Else
            arr = CType(flCache.GetCache("CMS_Story_List_By_Author_" & PortalId), ArrayList)
        End If
        For Each Ck As CMS_StoryInfo In arr
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.Author, False), Ck.Author))
        Next
    End Sub
    Public Shared Sub LoadTinhTrangTruyen(ByVal drGroup As DropDownList, Optional ByVal fristText As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If fristText <> "" Then drGroup.Items.Add(New ListItem(fristText, "-1"))
        drGroup.Items.Add(New ListItem("Đang viết", StoryIndex.DangViet))
        drGroup.Items.Add(New ListItem("Đang dịch", StoryIndex.DangDich))
        drGroup.Items.Add(New ListItem("Hoàn thành", StoryIndex.HoanThanh))
    End Sub
    Public Shared Sub LoadAppStatus(drList As DropDownList)
        drList.Items.Clear()
        drList.Items.Add(New ListItem("- - Tất cả - - ", 0))
        drList.Items.Add(New ListItem("Đang hoạt động", AppStatus.Active))
        drList.Items.Add(New ListItem("Đã tạm dừng ứng dụng", AppStatus.Pause))
        drList.Items.Add(New ListItem("Đang bị khóa ứng dụng", AppStatus.Lock))
        drList.Items.Add(New ListItem("Đã gỡ bỏ ứng dụng", AppStatus.Remove))
        drList.Items.Add(New ListItem("Đã thay đổi số đăng ký", AppStatus.Change))
    End Sub
    Public Shared Sub LoadAppSystem(drList As DropDownList)
        drList.Items.Clear()
        drList.Items.Add(New ListItem("- - Tất cả hệ điều hành - - ", -1))
        drList.Items.Add(New ListItem("Hệ điều hành IOS", AppSystem.iOS))
        drList.Items.Add(New ListItem("Hệ điều hành Android", AppSystem.Android))
    End Sub
    Public Shared Sub BindddlCategories(PortalConnect As Integer, drGroup As DropDownList, PortalID As Integer, ParentID As Integer, str As String, Optional ByVal intType As Integer = 1)
        If IsNothing(flCache.GetCache("mobile_Category_Get_By_ParentId_" & PortalID & intType & ParentID)) = True Then
            arr1 = ObjControler.CMS_Category_Get_By_ParentId(PortalConnect, PortalID, intType, ParentID)
            flCache.SetCache("mobile_Category_Get_By_ParentId_" & PortalID & intType & ParentID, arr1)
        Else
            arr1 = CType(flCache.GetCache("mobile_Category_Get_By_ParentId_" & PortalID & intType & ParentID), ArrayList)

        End If
        For Each Cr1 As CMS_CategoryInfo In arr1
            drGroup.Items.Add(New ListItem(str & flReg.RemoveScript(Cr1.CategoryName, False), Cr1.CategoryID))
            Call BindddlCategories(PortalConnect, drGroup, PortalID, Cr1.CategoryID, str & "|--- ", intType)
        Next
    End Sub
    Public Shared Sub LoadCategories(PortalConnect As Integer, drGroup As DropDownList, PortalID As Integer, Optional ByVal intType As Integer = 1, Optional ByVal searchText As String = "- - - Chọn chuyên mục - - -", Optional ByVal val As String = "0")
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem(searchText, val))
        If IsNothing(flCache.GetCache("mobile_Category_Get_By_ParentId_Null_" & PortalID & intType)) = True Then
            arr = ObjControler.CMS_Category_Get_By_ParentId_Null(PortalConnect, PortalID, intType)
            flCache.SetCache("mobile_Category_Get_By_ParentId_Null_" & PortalID & intType, arr)
        Else
            arr = CType(flCache.GetCache("mobile_Category_Get_By_ParentId_Null_" & PortalID & intType), ArrayList)
        End If
        For Each Cr As CMS_CategoryInfo In arr
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Cr.CategoryName, False), Cr.CategoryID))
            Call BindddlCategories(PortalConnect, drGroup, PortalID, Cr.CategoryID, "|--- ", intType)
        Next
    End Sub
    Public Shared Sub LoadGender(drGroup As DropDownList, Optional ByVal fristText As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If fristText <> "" Then drGroup.Items.Add(New ListItem(fristText, ""))
        drGroup.Items.Add(New ListItem("Không yêu cầu", GenderType.KhongYeuCau))
        drGroup.Items.Add(New ListItem("Nam", GenderType.Nam))
        drGroup.Items.Add(New ListItem("Nữ", GenderType.Nu))
    End Sub
    Public Shared Sub LoadPortal(PortalConnect As Integer, dr As DropDownList, Optional ByVal all As Boolean = False)
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Portals_List_" & PortalConnect)) Then
            arr = ObjControler.CMS_Portals_List(PortalConnect)
            flCache.SetCache("CMS_Portals_List_" & PortalConnect, arr)
        Else
            arr = CType(flCache.GetCache("CMS_Portals_List_" & PortalConnect), ArrayList)
        End If
        If all = True Then dr.Items.Add(New ListItem("- - - Tất cả app - - ", 0))
        For Each Ci As CMS_PortalsInfo In arr
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Names, False), Ci.ID))
        Next
    End Sub
    Public Shared Sub LoadGroup(PortalConnect As Integer, dr As DropDownList, PortalId As Integer, Optional ByVal all As Boolean = False)
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Group_List_" & PortalConnect & "_" & PortalId)) Then
            arr = ObjControler.CMS_Group_List(PortalConnect, PortalId)
            flCache.SetCache("CMS_Group_List_" & PortalConnect & "_" & PortalId, arr)
        Else
            arr = CType(flCache.GetCache("CMS_Group_List_" & PortalConnect & "_" & PortalId), ArrayList)
        End If
        If all = True Then dr.Items.Add(New ListItem("- - - Tất cả nhóm - - ", 0))
        For Each Ci As CMS_GroupInfo In arr
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Name, False), Ci.ID))
        Next
    End Sub
    Public Shared Function FormatLink(PortalConnect As Integer, CategoryId As Integer, Id As Integer, toUrl As String) As String
        Return TabPath(PortalConnect, CategoryId) & toUrl & "-" & Id & ".html"
    End Function
    Public Shared Function FormatLink(PortalConnect As Integer, CategoryId As Integer) As String
        Return TabPath(PortalConnect, CategoryId)
    End Function
    Private Shared Function TabPath(PortalConnect As Integer, CategoryID As Integer) As String
        TabPath = flCache.GetCache("tabPath_" & PortalConnect & "_" & CategoryID) & ""
        If TabPath = "" Or TabPath = "/" Then
            Dim Obj As CMS_CategoryInfo = ObjControler.CMS_Category_Get_TabPath(PortalConnect, CategoryID)
            If IsNothing(Obj) = False Then
                If Obj.ParentId = 0 Then
                    TabPath = flConnect.WebDomain(PortalConnect) & Obj.TabPath.Replace("//", "/") & "/"
                Else
                    Dim objc As CMS_CategoryInfo = ObjControler.CMS_Category_Get(PortalConnect, Obj.ParentId)
                    TabPath = flConnect.WebDomain(PortalConnect) & objc.TabPath.Replace("//", "/") & "/cate" & Obj.TabPath.Replace("//", "/") & "/"
                End If
            End If
            flCache.SetCache("tabPath_" & PortalConnect & "_" & CategoryID, TabPath)
        End If
    End Function
    Public Shared Function GetRequestId(surl As String) As Integer
        surl = surl.Replace(".html", "").Substring(surl.LastIndexOf("-") + 1)
        If surl.Contains("?") Then surl = surl.Substring(0, surl.LastIndexOf("?"))
        Return flReg.WriteNumber(surl)
    End Function
    Public Shared Sub SaveSetup(PortalID As Integer, SettingName As String, SettingValue As String, UserName As String)
        Try
            Dim obj As New CMS_SetupsInfo
            obj.ID = flReg.GenKey()
            obj.PortalID = 2
            obj.SettingName = SettingName
            obj.SettingValue = SettingValue
            obj.CreatedBy = Now
            obj.UserName = UserName
            obj.UpdatedBy = Now
            obj.UpdatedUser = UserName
            ObjControler.CMS_Setups_Add(PortalID, obj)
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Function UserPortal(Username As String) As ArrayList
        If IsNothing(flCache.GetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username)) = True Then
            UserPortal = flDnn.DNN_Portal_Get_By_UserID(Username)
            flCache.SetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username, UserPortal)
        Else
            UserPortal = CType(flCache.GetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username), ArrayList)
        End If
    End Function
    Public Shared Sub BindProductGroup(PortalConnect As Integer, drGroup As DropDownList, PortalID As Integer, ParentID As Integer, str As String)
        If IsNothing(flCache.GetCache("MB_CMS_ProductGroup_List_By_ParentID_" & PortalID & ParentID)) = True Then
            arr1 = ObjControler.CMS_ProductGroup_List_By_ParentID(PortalConnect, PortalID, ParentID)
            flCache.SetCache("MB_CMS_ProductGroup_List_By_ParentID_" & PortalID & ParentID, arr1)
        Else
            arr1 = CType(flCache.GetCache("MB_CMS_ProductGroup_List_By_ParentID_" & PortalID & ParentID), ArrayList)
        End If
        For Each Cr1 As CMS_ProductGroupInfo In arr1
            drGroup.Items.Add(New ListItem(str & flReg.RemoveScript(Cr1.TenNhom, False), Cr1.ID))
            Call BindProductGroup(PortalConnect, drGroup, PortalID, Cr1.ID, str & "|--- ")
        Next
    End Sub
    Public Shared Sub LoadProductBrand(PortalConnect As Integer, drGroup As DropDownList, PortalID As Integer, Optional ByVal searchText As String = "- - - Chọn - - -", Optional ByVal val As String = "0")
        drGroup.Items.Clear()
        If searchText <> "" Then drGroup.Items.Add(New ListItem(searchText, val))
        If IsNothing(flCache.GetCache("CMS_ProductBrand_List_" & PortalID)) = True Then
            arr1 = ObjControler.CMS_ProductBrand_List(PortalConnect, PortalID)
            flCache.SetCache("CMS_ProductBrand_List_" & PortalID, arr1)
        Else
            arr1 = CType(flCache.GetCache("CMS_ProductBrand_List_" & PortalID), ArrayList)
        End If
        For Each Cr As CMS_ProductBrandInfo In arr1
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Cr.ThuongHieu, False) & " (" & flReg.RemoveScript(Cr.XuatXu, False) & ")", Cr.ID))
        Next
    End Sub
    Public Shared Sub LoadProductGroup(PortalConnect As Integer, drGroup As DropDownList, PortalID As Integer, Optional ByVal searchText As String = "- - - Chọn - - -", Optional ByVal val As String = "0")
        drGroup.Items.Clear()
        If searchText <> "" Then drGroup.Items.Add(New ListItem(searchText, val))
        If IsNothing(flCache.GetCache("MB_CMS_ProductGroup_List_By_ParentID_" & PortalID)) = True Then
            arr = ObjControler.CMS_ProductGroup_List_By_ParentID(PortalConnect, PortalID, 0)
            flCache.SetCache("MB_CMS_ProductGroup_List_By_ParentID_" & PortalID, arr)
        Else
            arr = CType(flCache.GetCache("MB_CMS_ProductGroup_List_By_ParentID_" & PortalID), ArrayList)
        End If
        For Each Cr As CMS_ProductGroupInfo In arr
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Cr.TenNhom, False), Cr.ID))
            Call BindProductGroup(PortalConnect, drGroup, PortalID, Cr.ID, "|--- ")
        Next
    End Sub
    Public Shared Sub LoadMenu(ByVal drGroup As DropDownList, PortalID As Integer)
        Dim arrTemp As New ArrayList
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
    Public Shared Sub LoadShopByStatus(drGroup As DropDownList, Optional ByVal text As String = "- - - Tất cả - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, -1))
        drGroup.Items.Add(New ListItem("Mới gửi", statusShopBy.DonMoiGui))
        drGroup.Items.Add(New ListItem("Khách hủy", statusShopBy.KhachHuyDon))
        drGroup.Items.Add(New ListItem("Từ chối", statusShopBy.TuChoiDon))
        drGroup.Items.Add(New ListItem("Nhận đơn", statusShopBy.TiepNhanDon))
        drGroup.Items.Add(New ListItem("Xuất kho", statusShopBy.XuatKho))
        drGroup.Items.Add(New ListItem("Đang giao", statusShopBy.GiaoVanChuyen))
        drGroup.Items.Add(New ListItem("Đã giao", statusShopBy.KhachNhanHang))
        drGroup.Items.Add(New ListItem("Bom hàng", statusShopBy.KhachNhanHang))
    End Sub
    Public Shared Sub LoadWebLinkType(ByVal drList As DropDownList, Optional ByVal text As String = "- - - Tất cả - - -")
        drList.Items.Clear()
        If text <> "" Then drList.Items.Add(New ListItem("- - - Chọn liên kết - - - ", 0))
        drList.Items.Add(New ListItem("Liên kết bên trái trang", WebLinkType.BenTrai))
        drList.Items.Add(New ListItem("Liên kết bên phải trang", WebLinkType.BenPhai))
        drList.Items.Add(New ListItem("Liên kết khác", WebLinkType.Khac))
    End Sub
    Public Shared Function calenderDay(months As Integer, years As Integer) As ArrayList
        If IsNothing(flCache.GetCache("calenderDay_" & months & "_" & years)) Then
            staDay = 0
            calenderDay = New ArrayList
            For days As Integer = 1 To DateTime.DaysInMonth(years, months)
                If staDay = 0 Then
                    ndp = New lichNgayInfo
                    Call addCalender(ndp, New DateTime(years, months, days))
                    calenderDay.Add(ndp)
                Else
                    Call addCalender(ndp, New DateTime(years, months, days))
                End If
                If days = DateTime.DaysInMonth(years, months) Then staDay = 0
            Next
            flCache.SetCache("calenderDay_" & months & "_" & years, calenderDay)
        Else
            calenderDay = CType(flCache.GetCache("calenderDay_" & months & "_" & years), ArrayList)
        End If
    End Function
    Private Shared Sub addCalender(sj As lichNgayInfo, fDate As DateTime)
        staDay = 1
        Select Case fDate.DayOfWeek
            Case 1
                sj.t2 = fDate.Day()
            Case 2
                sj.t3 = fDate.Day()
            Case 3
                sj.t4 = fDate.Day()
            Case 4
                sj.t5 = fDate.Day()
            Case 5
                sj.t6 = fDate.Day()
            Case 6
                sj.t7 = fDate.Day()
            Case Else
                sj.cn = fDate.Day()
                staDay = 0
        End Select
    End Sub

End Class

Public Module Moduler
    Public ReadOnly Property UserInfo As UserInfo
        Get
            Dim user As UserInfo
            If (HttpContext.Current Is Nothing) Then
                If Not Thread.CurrentPrincipal.Identity.IsAuthenticated Then
                    Return New UserInfo()
                End If
                Dim portalSettings = PortalController.Instance.GetCurrentPortalSettings()
                If portalSettings IsNot Nothing Then
                    user = UserController.GetCachedUser(portalSettings.PortalId, Thread.CurrentPrincipal.Identity.Name)
                    Return If(user, New UserInfo())
                End If
                Return New UserInfo()
            ElseIf HttpContext.Current.Items("UserInfo") Is Nothing Then
                If HttpContext.Current.Request.IsAuthenticated Then
                    user = UserController.GetCachedUser(PortalSettings.Current.PortalId, HttpContext.Current.User.Identity.Name)
                    HttpContext.Current.Items("UserInfo") = user
                End If
            End If
            user = DirectCast(HttpContext.Current.Items("UserInfo"), UserInfo)
            Return If(user, New UserInfo())
        End Get
    End Property

End Module