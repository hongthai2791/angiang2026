Imports System.Web.UI.WebControls
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.EPORTAL

Public Class flFunction
    Shared strOld, str() As String
    Shared ObjControler As New WorkController
    Shared arrTemp, arrTemp1, arrNgheCV As New ArrayList

    Public Shared Sub LoadparentJobPlace(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("1CMS_JobPlace_List_parent_" & PortalId)) Then
            arrTemp = ObjControler.CMS_JobPlace_List_parent(PortalId)
            flCache.SetCache("1CMS_JobPlace_List_parent_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("1CMS_JobPlace_List_parent_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_JobPlaceInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.JobPlace_Name, False), Ci.JobPlace_Code))
        Next
    End Sub
    Public Shared Sub LoadCareer(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Career_List_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Career_List(PortalId)
            flCache.SetCache("CMS_Career_List_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Career_List_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_CareerInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Career_Name, False), Ci.Career_ID))
        Next
    End Sub
    Public Shared Sub LoadTypeOf(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_TypeOf_List_" & PortalId)) Then
            arrTemp = ObjControler.CMS_TypeOf_List(PortalId)
            flCache.SetCache("CMS_TypeOf_List_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_TypeOf_List_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TypeOfInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.TypeOf_Name, False), Ci.TypeOf_ID))
        Next
    End Sub
    Public Shared Sub LoadSalary(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Salary_List_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Salary_List(PortalId)
            flCache.SetCache("CMS_Salary_List_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Salary_List_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_SalaryInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Salary_Name, False), Ci.Salary_ID))
        Next
    End Sub

    Public Shared Sub LoadNgheCongViec(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_NgheCongViec_List_" & PortalId)) Then
            arrNgheCV = ObjControler.CMS_NgheCongViec_List(PortalId)
            flCache.SetCache("CMS_NgheCongViec_List_" & PortalId, arrNgheCV)
        Else
            arrNgheCV = CType(flCache.GetCache("CMS_NgheCongViec_List_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        'For Each Ci As CMS_CareerInfo In arrTemp
        '    dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Career_Name, False), Ci.Career_ID))
        'Next
        LoadRecusiveCareer(dr)
    End Sub

    Public Shared Function GetAllParents(careerId As String, lst As List(Of CMS_NgheCongViecInfo)) As List(Of Tuple(Of CMS_NgheCongViecInfo, Integer))
        Dim parents As New List(Of Tuple(Of CMS_NgheCongViecInfo, Integer))
        Dim currentCareerId As String = careerId
        Dim level As Integer = 0

        parents.Add(New Tuple(Of CMS_NgheCongViecInfo, Integer)(lst.Where(Function(item) item.Id = careerId).FirstOrDefault(), 0))

        While Not String.IsNullOrEmpty(currentCareerId)
            Dim parentCareerId As String = GetParentCareerId(currentCareerId, lst)
            If Not String.IsNullOrEmpty(parentCareerId) Then
                level += 1
                Dim parentInfo = lst.Where(Function(item) item.Id = parentCareerId).FirstOrDefault()
                parents.Add(New Tuple(Of CMS_NgheCongViecInfo, Integer)(parentInfo, level))
                currentCareerId = parentCareerId
            Else
                Exit While
            End If
        End While

        Return parents
    End Function

    Private Shared Function GetParentCareerId(careerId As String, lst As List(Of CMS_NgheCongViecInfo)) As String
        For Each Ci As CMS_NgheCongViecInfo In lst
            If Ci.Id = careerId Then
                Return Ci.Parent_ID
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub LoadRecusiveCareer(dr As DropDownList, Optional ByVal parentId As String = "", Optional ByVal level As Integer = 0)
        For Each Ci As CMS_NgheCongViecInfo In arrNgheCV
            If Ci.Parent_ID = parentId Then
                Dim prefix As String = String.Concat(Enumerable.Repeat("|--", level))
                dr.Items.Add(New ListItem($"{prefix} [{Ci.Career_Code}] {flReg.RemoveScript(Ci.Career_Name, False)}", Ci.Id))
                LoadRecusiveCareer(dr, Ci.Id, level + 1)
            End If
        Next
    End Sub
    Public Shared Sub LoadJobPlace(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        arrTemp = ObjControler.CMS_JobPlace_List_parent(PortalId)
        If text <> "" Then dr.Items.Add(New ListItem(text, "0"))
        For Each Cr As CMS_JobPlaceInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Cr.JobPlace_Name, False), Cr.JobPlace_Code))
            For Each Ci As CMS_JobPlaceInfo In ObjControler.CMS_JobPlace_List_parent_ID(PortalId, Cr.JobPlace_Code)
                dr.Items.Add(New ListItem(flReg.RemoveScript(" - - " & Ci.JobPlace_Name, False), Ci.JobPlace_Code))
            Next
        Next
    End Sub
    Public Shared Sub LoadJobPlaceID(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        arrTemp = ObjControler.CMS_JobPlace_List_parent(PortalId)
        If text <> "" Then dr.Items.Add(New ListItem(text, "0"))
        For Each Cr As CMS_JobPlaceInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Cr.JobPlace_Name, False), Cr.JobPlace_ID))
            For Each Ci As CMS_JobPlaceInfo In ObjControler.CMS_JobPlace_List_parent_ID(PortalId, Cr.JobPlace_Code)
                dr.Items.Add(New ListItem(flReg.RemoveScript(" - - " & Ci.JobPlace_Name, False), Ci.JobPlace_ID))
            Next
        Next
    End Sub
    Public Shared Sub LoadExperience(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Experience_List_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Experience_List(PortalId)
            flCache.SetCache("CMS_Experience_List_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Experience_List_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_ExperienceInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Experience_Name, False), Ci.Experience_ID))
        Next
    End Sub
    Public Shared Sub LoadNeeds(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Needs_List_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Needs_List(PortalId)
            flCache.SetCache("CMS_Needs_List_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Needs_List_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_NeedsInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Needs_Name, False), Ci.Needs_ID))
        Next
    End Sub
    Public Shared Sub LoadGender(ByVal drGroup As DropDownList, Optional ByVal fristText As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If fristText <> "" Then drGroup.Items.Add(New ListItem(fristText, ""))
        drGroup.Items.Add(New ListItem("Không yêu cầu", GenderType.KhongYeuCau))
        drGroup.Items.Add(New ListItem("Nam", GenderType.Nam))
        drGroup.Items.Add(New ListItem("Nữ", GenderType.Nu))
    End Sub
    Public Shared Sub LoadBusiness(PortalConnect As Integer, drGroup As DropDownList, Optional ByVal UserAdmin As String = "")
        drGroup.Items.Clear()
        If UserAdmin = "" Then
            drGroup.Items.Add(New ListItem("- - - Chọn doanh nghiệp - - -", ""))
            For Each Ci As CMS_BusinessInfo In ObjControler.CMS_Business_List(PortalConnect, PortalConnect)
                drGroup.Items.Add(New ListItem(Ci.Business_Vn, Ci.Business_ID))
            Next
        Else
            Dim busInfo As CMS_BusinessInfo = ObjControler.CMS_Business_Get_UserAdmin(PortalConnect, UserAdmin)
            If IsNothing(busInfo) = False Then
                drGroup.Items.Add(New ListItem(busInfo.Business_Vn, busInfo.Business_ID))
            Else
                drGroup.Items.Add(New ListItem("- - - Chọn doanh nghiệp - - -", ""))
            End If
        End If
    End Sub
    Public Shared Sub LoadBusiness(PortalConnect As Integer, drGroup As DropDownList, tinhTP As String, quanHuyen As String, Optional ByVal UserAdmin As String = "")
        drGroup.Items.Clear()
        If UserAdmin = "" Then
            drGroup.Items.Add(New ListItem("- - - Chọn doanh nghiệp - - -", ""))
            For Each Ci As CMS_BusinessInfo In ObjControler.CMS_Business_List_By_TinhTP(PortalConnect, PortalConnect, tinhTP, quanHuyen, 1, 5000)
                drGroup.Items.Add(New ListItem(flReg.RemoveHTML(Ci.Business_Vn), Ci.Business_ID))
            Next
        Else
            Dim busInfo As CMS_BusinessInfo = ObjControler.CMS_Business_Get_UserAdmin(PortalConnect, UserAdmin)
            If IsNothing(busInfo) = False Then
                drGroup.Items.Add(New ListItem(flReg.RemoveHTML(busInfo.Business_Vn), busInfo.Business_ID))
            Else
                drGroup.Items.Add(New ListItem("- - - Chọn doanh nghiệp - - -", ""))
            End If
        End If
    End Sub
    Public Shared Sub LoadBusinessToApp(drGroup As DropDownList, tinhTP As String, quanHuyen As String)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("- - - Chọn doanh nghiệp - - -", ""))
        For Each Ci As CMS_BusinessInfo In ObjControler.CMS_Business_List_By_TinhTP_ToApp(tinhTP, quanHuyen)
            drGroup.Items.Add(New ListItem(Ci.Business_Vn, Ci.Business_ID))
        Next
    End Sub
    Public Shared Sub ListUserName(drUser As DropDownList, UserName As String, tabName As String, Optional ByVal viewBus As Integer = StatusBus.TatCa)
        drUser.Items.Clear()
        If viewBus = StatusBus.DoanhNghiep Then 'Tài khoản doanh nghiệp
            arrTemp = flDnn.DNN_UserConfig_List_By_Search(0, tabName, "", 1, 10000, flReg.GetRolesID(tabName, "Doanh nghiep"), 0, 0, 0)
            drUser.Items.Add(New ListItem(("- - - Chọn - - -"), ""))
            For Each Cr As DnnInfo In arrTemp
                If Cr.IsDeleted = False Then
                    drUser.Items.Add(New ListItem(Cr.DisplayName & " (" & Cr.Username & ")", Cr.Username))
                End If
            Next
        ElseIf viewBus = StatusBus.NguoiTimViec Then 'Tài khoản người tìm việc
            arrTemp = flDnn.DNN_UserConfig_List_By_Search(0, tabName, "", 1, 10000, flReg.GetRolesID(tabName, "Nguoi lao dong"), 0, 0, 0)
            drUser.Items.Add(New ListItem(("- - - Chọn - - -"), ""))
            For Each Cr As DnnInfo In arrTemp
                If Cr.IsDeleted = False Then
                    drUser.Items.Add(New ListItem(Cr.DisplayName & " (" & Cr.Username & ")", Cr.Username))
                End If
            Next
        Else 'Tất cả
            If UserName = "host" Or UserName = "admin" Or UserName = "true" Then
                drUser.Items.Add(New ListItem(("- - - Chọn - - -"), ""))
                arrTemp = flDnn.DNN_User_List_By_UserName(0, "")
            Else
                arrTemp = flDnn.DNN_User_List_By_UserName(0, UserName)
            End If
            For Each Cr As DnnInfo In arrTemp
                drUser.Items.Add(New ListItem(Cr.DisplayName & " (" & Cr.Username & ")", Cr.Username))
            Next
        End If
    End Sub
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

    ''' <summary>
    ''' Hàm lưu các item được chọn vào DB, dùng chung cho các DropdownList trên giao diện
    ''' </summary>
    ''' <typeparam name="T">Mapping class kế thừa từ IMappingInfo (VD: MAP_MucDichInfo, MAP_SalaryMonthInfo...)</typeparam>
    ''' <param name="PortalId"></param>
    ''' <param name="userName">[Table]_Id từ các bảng cần map (VD: Work_Id từ CMS_Work, JobUser_ID từ CMS_JobUser...)</param>
    ''' <param name="values">Danh sách Id, phân tách bởi dấu ","</param>
    ''' <param name="customTableName">Tên bảng (dùng trong trường hợp bảng trong db và Entity class trong WorkInfo.vb không trùng nhau)</param>
    Public Shared Sub SaveSelectedItems(Of T As {IMappingInfo})(PortalId As Integer, userName As String, values As String, Optional customTableName As String = "")
        arrTemp = New ArrayList()
        If Not String.IsNullOrEmpty(values) Then
            'Chuyển chuỗi thành mảng
            Dim lstStr = values.Split(CType(",", Char()), StringSplitOptions.RemoveEmptyEntries).ToList()
            For Each _str In lstStr
                If _str <> "" Then
                    'Khởi tạo instance động từ t, gán giá trị bằng các properties trong IMappingInfo
                    Dim _temp As T = Activator.CreateInstance(Of T)()
                    _temp.UserName = userName
                    _temp.SetId(_str)
                    arrTemp.Add(_temp)
                End If
            Next
        End If
        If arrTemp.Count > 0 Then
            'Gọi hàm thêm vào DB
            ObjControler.MAPWork_Add(Of T)(PortalId, Ultis.ConvertArrayListToDataTable(arrTemp), customTableName)
        Else
            'Nếu không có item nào được chọn thì xóa hết
            ObjControler.MAPWork_Delete(Of T)(PortalId, userName, customTableName)
        End If
    End Sub

    ''' <summary>
    ''' Hàm lưu các item được chọn vào DB, dùng chung cho các DropdownList trên giao diện
    ''' </summary>
    ''' <typeparam name="T">Mapping class kế thừa từ IMappingInfo (VD: MAP_MucDichInfo, MAP_SalaryMonthInfo...)</typeparam>
    ''' <param name="PortalId"></param>
    ''' <param name="userName">[Table]_Id từ các bảng cần map (VD: Work_Id từ CMS_Work, JobUser_ID từ CMS_JobUser...)</param>
    ''' <param name="values">Danh sách Id, phân tách bởi dấu ","</param>
    ''' <param name="customTableName">Tên bảng (dùng trong trường hợp bảng trong db và Entity class trong WorkInfo.vb không trùng nhau)</param>
    Public Shared Sub SaveSelectedItems(Of T As {IMappingInfo})(PortalId As Integer, userName As String, values As IEnumerable(Of T), Optional customTableName As String = "")
        If values.Any Then
            'Gọi hàm thêm vào DB
            ObjControler.MAPWork_Add(Of T)(PortalId, Ultis.ConvertArrayListToDataTable(Of T)(values), customTableName)
        Else
            'Nếu không có item nào được chọn thì xóa hết
            ObjControler.MAPWork_Delete(Of T)(PortalId, userName, customTableName)
        End If
    End Sub
End Class
