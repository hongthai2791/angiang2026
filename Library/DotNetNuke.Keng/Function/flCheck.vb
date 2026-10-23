Imports DotNetNuke.VBN
Public Class flCheck
    Shared ObjControler As New Kengcontroller
    Shared str() As String

    Public Shared Function myLike(pid As Integer, postID As String, appID As String) As Boolean
        If IsNothing(flCache.GetCache("myLike_" & pid & "_" & postID & "_" & appID)) = True Then
            If ObjControler.CMS_Likes_Count_ByPostID(pid, postID, appID) > 0 Then
                flCache.SetCache("myLike_" & pid & "_" & postID & "_" & appID, True)
                Return True
            Else
                Return False
            End If
        Else
            Return flReg.ToBoolean(flCache.GetCache("myLike_" & pid & "_" & postID & "_" & appID))
        End If
    End Function
    Public Shared Function endCodeSearch(keywords As String) As String
        If keywords <> "" Then
            keywords = keywords.Replace("'", "''")
            keywords = keywords.Replace("""", """""")
            Dim sbKeyWordsFilter As New System.Text.StringBuilder()
            Dim splitedKeyWords As String() = keywords.Trim().Split(" ")
            For i As Integer = 0 To splitedKeyWords.Length - 2

                sbKeyWordsFilter.Append("""")
                sbKeyWordsFilter.Append(splitedKeyWords(i))
                sbKeyWordsFilter.Append("*"" & ")
            Next
            sbKeyWordsFilter.Append("""")
            sbKeyWordsFilter.Append(splitedKeyWords(splitedKeyWords.Length - 1))
            sbKeyWordsFilter.Append("*""")
            Return sbKeyWordsFilter.ToString()
        End If
        Return ""
    End Function
    Public Shared Function FullTextSearch(keywords As String, Optional ByVal toUrl As Boolean = True) As String
        If toUrl = True Then
            FullTextSearch = flReg.NameUrl(keywords).Replace("-", " ")
            FullTextSearch = endCodeSearch(FullTextSearch)
            'FullTextSearch = FullTextSearch.Replace("*", "")
        Else
            FullTextSearch = endCodeSearch(keywords)
            'FullTextSearch = FullTextSearch.Replace("*", "")
        End If
    End Function
    Public Shared Function myShare(pid As Integer, postID As String, appID As String) As Boolean
        If IsNothing(flCache.GetCache("myShare_" & pid & "_" & postID & "_" & appID)) = True Then
            If ObjControler.CMS_SharePost_Count_ByPostID(pid, postID, appID) > 0 Then
                flCache.SetCache("myShare_" & pid & "_" & postID & "_" & appID, True)
                Return True
            Else
                Return False
            End If
        Else
            Return flReg.ToBoolean(flCache.GetCache("myShare_" & pid & "_" & postID & "_" & appID))
        End If
    End Function
    Public Shared Function getMyFriend(statusID As Integer) As String
        If statusID = RelationShipStatus.Accepted Then
            Return "Bạn bè"
        ElseIf statusID = RelationShipStatus.Declined Then
            Return "Từ chối"
        ElseIf statusID = RelationShipStatus.Blocked Then
            Return "Chặn kết bạn"
        Else
            Return "Đồng ý"
        End If
    End Function
    Public Shared Function getFriend(statusID As Integer)
        If statusID = RelationShipStatus.Accepted Then
            Return "Đã là bạn bè"
        ElseIf statusID = RelationShipStatus.Declined Then
            Return "Bị từ chối"
        ElseIf statusID = RelationShipStatus.Blocked Then
            Return "Đã bị chặn"
        Else
            Return "Đã kết bạn"
        End If
    End Function
    Public Shared Function getAppFriend(pid As Integer, appID As String, appFriend As String) As Boolean
        If IsNothing(flCache.GetCache("getAppFriend_" & pid & "_" & appID & "_" & appFriend)) = True Then
            If appID = appFriend Then
                flCache.SetCache("getAppFriend_" & pid & "_" & appID & "_" & appFriend, True)
                Return True
            Else
                If ObjControler.CMS_RelationShip_Get_By_App(pid, appID, appFriend) >= 0 Then
                    flCache.SetCache("getAppFriend_" & pid & "_" & appID & "_" & appFriend, True)
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return flReg.ToBoolean(flCache.GetCache("getAppFriend_" & pid & "_" & appID & "_" & appFriend))
        End If
    End Function
    Public Shared Function TinhTuVi(ngay As Integer, thang As Integer) As String
        TinhTuVi = ""
        Select Case thang
            Case 1
                If ngay > 0 And ngay < 20 Then
                    Return "Cung Ma Kết"
                ElseIf ngay > 19 And ngay <= 31 Then
                    Return "Cung Bảo Bình"
                End If
            Case 2
                If ngay > 0 And ngay < 19 Then
                    Return "Cung Bảo Bình"
                ElseIf ngay > 18 And ngay <= 29 Then
                    Return "Cung Song Ngư"
                End If
            Case 3
                If ngay > 0 And ngay < 21 Then
                    Return "Cung Song Ngư"
                ElseIf ngay > 20 And ngay <= 31 Then
                    Return "Cung Bạch Dương"
                End If
            Case 4
                If ngay > 0 And ngay < 22 Then
                    Return "Cung Bạch Dương"
                ElseIf ngay > 21 And ngay <= 30 Then
                    Return "Cung Kim Ngưu"
                ElseIf ngay > 30 Then
                    Return "Không hợp lệ"
                End If
            Case 5
                If ngay > 0 And ngay < 21 Then
                    Return "Cung Kim Ngưu"
                ElseIf ngay > 20 And ngay <= 31 Then
                    Return "Cung Song Tử"
                End If
            Case 6
                If ngay > 0 And ngay < 22 Then
                    Return "Cung Song Tử"
                ElseIf ngay > 21 And ngay <= 30 Then
                    Return "Cung Cự giải"
                ElseIf ngay > 30 Then
                    Return "Không hợp lệ"
                End If
            Case 7
                If ngay > 0 And ngay < 23 Then
                    Return "Cung Cự giải"
                ElseIf ngay > 22 And ngay <= 31 Then
                    Return "Cung Sư Tử"
                End If
            Case 8
                If ngay > 0 And ngay < 23 Then
                    Return "Cung Sư Tử"
                ElseIf ngay > 21 And ngay <= 31 Then
                    Return "Cung Sử Nữ"
                ElseIf ngay > 31 Then
                    Return "Không hợp lệ"
                End If
            Case 9
                If ngay > 0 And ngay < 23 Then
                    Return "Cung Sử Nữ"
                ElseIf ngay > 22 And ngay <= 30 Then
                    Return "Cung Thiên Bình"
                End If
            Case 10
                If ngay > 0 And ngay < 24 Then
                    Return "Cung Thiên Bình"
                ElseIf ngay > 23 And ngay <= 31 Then
                    Return "Cung Bọ Cạp"
                End If
            Case 11
                If ngay > 0 And ngay < 23 Then
                    Return "Cung Bọ Cạp"
                ElseIf ngay > 22 And ngay <= 30 Then
                    Return "Cung Nhân Mã"
                ElseIf ngay > 30 Then
                    Return "Không hợp lệ"
                End If
            Case 12
                If ngay > 0 And ngay < 22 Then
                    Return "Cung Nhân Mã"
                ElseIf ngay > 21 And ngay <= 31 Then
                    Return "Cung Ma Kết"
                End If
        End Select
    End Function
    Public Shared Function Utility_Name(pid As Integer, ID As Integer) As String
        Utility_Name = flCache.GetCache("Utility_Name_" & pid & "_" & ID) & ""
        If Utility_Name = "" Then
            Dim obj As CMS_UtilityInfo = ObjControler.CMS_Utility_Get(pid, ID)
            If IsNothing(obj) = False Then
                Utility_Name = obj.name
                flCache.SetCache("Utility_Name_" & pid & "_" & ID, Utility_Name)
            End If
        End If
    End Function
    Public Shared Function TypeZoom_Name(pid As Integer, ID As Integer) As String
        TypeZoom_Name = flCache.GetCache("TypeZoom_Name_" & pid & "_" & ID) & ""
        If TypeZoom_Name = "" Then
            Dim obj As CMS_TypeZoomInfo = ObjControler.CMS_TypeZoom_Get(pid, ID)
            If IsNothing(obj) = False Then
                TypeZoom_Name = obj.name
                flCache.SetCache("TypeZoom_Name_" & pid & "_" & ID, TypeZoom_Name)
            End If
        End If
    End Function
    Public Shared Function CateDetail_Name(pid As Integer, CateDetail_ID As Integer) As String
        CateDetail_Name = flCache.GetCache("CateDetail_Name_" & pid & "_" & CateDetail_ID) & ""
        If CateDetail_Name = "" Then
            Dim obj As CMS_CateDetailInfo = ObjControler.CMS_CateDetail_Get(pid, CateDetail_ID)
            If IsNothing(obj) = False Then
                CateDetail_Name = obj.CateDetail_Name
                flCache.SetCache("CateDetail_Name_" & pid & "_" & CateDetail_ID, CateDetail_Name)
            End If
        End If
    End Function
    Public Shared Function CateDetailName(pid As Integer, CateDetailID As String) As String
        CateDetailName = flCache.GetCache("CateDetailName_" & pid & "_" & CateDetailID) & ""
        If CateDetailName = "" Then
            str = CateDetailID.Split(",")
            Dim obj As New CMS_CateDetailInfo
            For i As Integer = 0 To str.Length - 1
                obj = ObjControler.CMS_CateDetail_Get(pid, flReg.WriteNumber(str(i)))
                If IsNothing(obj) = False Then
                    CateDetailName += obj.CateDetail_Name & ", "
                End If

            Next
            If CateDetailName <> "" Then CateDetailName = CateDetailName.Substring(0, CateDetailName.LastIndexOf(",")).Trim()
            flCache.SetCache("CateDetailName_" & pid & "_" & CateDetailID, CateDetailName)
        End If
    End Function
    Public Shared Function getHeartFullName(pid As Integer, appID As String) As String
        getHeartFullName = flCache.GetCache("getHeartFullName_" & pid & "_" & appID) & ""
        If getHeartFullName = "" Then
            Dim obj As CMS_UserHeartInfo = ObjControler.CMS_UserHeart_Get_App(pid, appID)
            If IsNothing(obj) = False Then
                If obj.HoTen <> "" Then
                    getHeartFullName = obj.HoTen
                    flCache.SetCache("getHeartFullName_" & pid & "_" & appID, getHeartFullName)
                Else
                    getHeartFullName = APP.flCheck.getAppFullName(pid, appID)
                End If
            Else
                getHeartFullName = APP.flCheck.getAppFullName(pid, appID)
            End If
        End If
    End Function
    Public Shared Function LyDo_Name(pid As Integer, ID As String) As String
        ID = flReg.WriteNumber(ID)
        LyDo_Name = flCache.GetCache("LyDo_Name_" & pid & "_" & ID) & ""
        If LyDo_Name = "" Then
            Dim obj As CMS_LyDoInfo = ObjControler.CMS_LyDo_Get(pid, ID)
            If IsNothing(obj) = False Then
                LyDo_Name = obj.lyDo
                flCache.SetCache("LyDo_Name_" & pid & "_" & ID, LyDo_Name)
            End If
        End If
    End Function
    Public Shared Function getCarName(pid As Integer, ID As Integer) As String
        getCarName = flCache.GetCache("getCarName_" & pid & "_" & ID) & ""
        If getCarName = "" Then
            Dim obj As CMS_MissionCarInfo = ObjControler.CMS_MissionCar_Get(pid, ID)
            If IsNothing(obj) = False Then
                getCarName = obj.Car_Name
                flCache.SetCache("getCarName_" & pid & "_" & ID, getCarName)
            End If
        End If
    End Function
    Public Shared Function getAppAvatarForWeb(pid As Integer, appID As String, Optional ByVal width As Integer = 50, Optional ByVal heigh As Integer = 50) As String
        getAppAvatarForWeb = flCache.GetCache("getAppAvatarForWeb_" & pid & "_" & appID) & ""
        If getAppAvatarForWeb = "" Then
            Dim obj As APP.CMS_AppInfo
            If IsNothing(flCache.GetCache("CMS_App_Get_AppID_" & pid & "_" & appID)) = True Then
                obj = New APP.AppController().CMS_App_Get_AppID(pid, appID)
                If IsNothing(obj) = False Then flCache.SetCache("CMS_App_Get_AppID_" & pid & "_" & appID, obj)
            Else
                obj = CType(flCache.GetCache("CMS_App_Get_AppID_" & pid & "_" & appID), APP.CMS_AppInfo)
            End If

            If IsNothing(obj) = False Then
                If obj.Avatar <> "" Then
                    getAppAvatarForWeb = "http://app.keng.com.vn" & obj.Avatar.ToLower() & "?dpi=150&quality=100&w=" & width
                    flCache.SetCache("getAppAvatarForWeb_" & pid & "_" & appID, getAppAvatarForWeb)
                Else
                    getAppAvatarForWeb = "/image/images/noavatar.png?h=48&w=48"
                End If
            Else
                getAppAvatarForWeb = "/image/images/noavatar.png?h=48&w=48"
            End If
        End If
    End Function
    Public Shared Function Employee_Name(pid As Integer, uID As Integer, emCode As String, Optional ByVal getCD As Boolean = False) As String
        Employee_Name = flCache.GetCache("Employee_Name_" & pid & "_" & uID & "_" & emCode & "_" & getCD)
        If Employee_Name = "" Then
            Dim obj As New CMS_EmployeeInfo
            If IsNothing(flCache.GetCache("CMS_Employee_GetByCode_" & uID & "_" & emCode)) Then
                obj = ObjControler.CMS_Employee_GetByCode(pid, uID, emCode)
            Else
                obj = CType(flCache.GetCache("CMS_Employee_GetByCode_" & uID & "_" & emCode), CMS_EmployeeInfo)
            End If
            If IsNothing(obj) = False Then
                flCache.SetCache("CMS_Employee_GetByCode_" & uID & "_" & emCode, obj, SecondCache.M10)
                If getCD = True Then
                    Employee_Name = (obj.ChucDanh & " " & obj.EmployeeName).Trim()
                Else
                    Employee_Name = obj.EmployeeName
                End If
                flCache.SetCache("Employee_Name_" & pid & "_" & uID & "_" & emCode & "_" & getCD, Employee_Name)
            End If
        End If
    End Function
    Public Shared Function Employee_DID(pid As Integer, uID As Integer, emCode As String) As String
        Employee_DID = flCache.GetCache("Employee_DID_" & pid & "_" & uID & "_" & emCode)
        If Employee_DID = "" Then
            Dim obj As New CMS_EmployeeInfo
            If IsNothing(flCache.GetCache("CMS_Employee_GetByCode_" & uID & "_" & emCode)) Then
                obj = ObjControler.CMS_Employee_GetByCode(pid, uID, emCode)
            Else
                obj = CType(flCache.GetCache("CMS_Employee_GetByCode_" & uID & "_" & emCode), CMS_EmployeeInfo)
            End If
            If IsNothing(obj) = False Then
                flCache.SetCache("CMS_Employee_GetByCode_" & uID & "_" & emCode, obj, SecondCache.M10)
                Employee_DID = obj.DepartmentCode
                flCache.SetCache("Employee_DID_" & pid & "_" & uID & "_" & emCode, Employee_DID)
            End If
        End If
    End Function
    Public Shared Function Employee_AppID(pid As Integer, emCode As String, uid As Integer) As String
        Employee_AppID = flCache.GetCache("Employee_AppID_" & pid & "_" & emCode & "_" & uid)
        If Employee_AppID = "" Then
            Dim obj As New CMS_EmployeeInfo
            If IsNothing(flCache.GetCache("CMS_Employee_GetByCode_" & uid & "_" & emCode)) Then
                obj = ObjControler.CMS_Employee_GetByCode(pid, uid, emCode)
            Else
                obj = CType(flCache.GetCache("CMS_Employee_GetByCode_" & uid & "_" & emCode), CMS_EmployeeInfo)
            End If
            If IsNothing(obj) = False Then
                flCache.SetCache("CMS_Employee_GetByCode_" & uid & "_" & emCode, obj, SecondCache.M10)

                Employee_AppID = obj.AppID
                flCache.SetCache("Employee_AppID_" & pid & "_" & emCode & "_" & uid, Employee_AppID)
            End If
        End If
    End Function
    Public Shared Function Employee_Code(pid As Integer, appID As String, uid As Integer) As String
        Employee_Code = flCache.GetCache("Employee_Code_" & pid & "_" & appID & "_" & uid)
        If Employee_Code = "" Then
            Dim obj As CMS_EmployeeInfo = ObjControler.CMS_Employee_Get_By_AppID(pid, uid, appID)
            If IsNothing(obj) = False Then
                Employee_Code = obj.EmployeeCode
                flCache.SetCache("Employee_Code_" & pid & "_" & appID & "_" & uid, Employee_Code)
            End If
        End If
    End Function
    Public Shared Function HappyBrith(pid As Integer, appID As String, uid As Integer) As String
        HappyBrith = flCache.GetCache("HappyBrith_" & pid & "_" & appID & "_" & uid)
        If HappyBrith = "" Then
            Dim obj As CMS_EmployeeInfo = ObjControler.CMS_Employee_Get_By_AppID(pid, uid, appID)
            If IsNothing(obj) = False Then
                HappyBrith = "<div class=""text-hbd-1"">Hôm nay là sinh nhật của<b>&nbsp;" & obj.EmployeeCode & " - " & obj.ChucDanh & " " & obj.EmployeeName & "</b>, hãy gửi đến <b>" & obj.EmployeeCode & "</b> những lời chúc tốt đẹp nhất!</div>"
                flCache.SetCache("HappyBrith_" & pid & "_" & appID & "_" & uid, HappyBrith)
            End If
        End If
    End Function
    Public Shared Function getHeartAvatar(pid As Integer, appID As String) As String
        getHeartAvatar = flCache.GetCache("getHeartAvatar_" & pid & "_" & appID) & ""
        If getHeartAvatar = "" Then
            Dim obj As CMS_UserHeartInfo = ObjControler.CMS_UserHeart_Get_App(pid, appID)
            If IsNothing(obj) = False Then
                If obj.AnhDaiDien <> "" Then
                    getHeartAvatar = "http://app.keng.com.vn" & obj.AnhDaiDien.ToLower() & "?dpi=150&quality=100&w=70"
                    flCache.SetCache("getHeartAvatar_" & pid & "_" & appID, getHeartAvatar)
                Else
                    getHeartAvatar = APP.flCheck.getAppAvatar(pid, appID)
                End If
            Else
                getHeartAvatar = APP.flCheck.getAppAvatar(pid, appID)
            End If
        End If
    End Function
    Public Shared Function getToAppID(pid As Integer, idKey As String, table As String) As String
        getToAppID = flCache.GetCache("getToAppID_" & pid & "_" & idKey & "_" & table) & ""
        If getToAppID = "" Then
            If table = "POST" Then
                Dim obj As CMS_PostInfo = ObjControler.CMS_Post_Get(pid, idKey)
                If IsNothing(obj) = False Then getToAppID = obj.AppID
            End If
            flCache.SetCache("getToAppID_" & pid & "_" & idKey & "_" & table, getToAppID)
        End If
    End Function
    Public Shared Function getImgTop(pid As Integer, idKey As String, table As String) As String
        getImgTop = flCache.GetCache("getImgTop_" & pid & "_" & idKey & "_" & table) & ""
        If getImgTop = "" Then
            If table = "POST" Then
                For Each Cr As CMS_FileAttachInfo In ObjControler.CMS_FileAttach_List_ByIdKey(pid, idKey, 0, 1)
                    getImgTop = "http://app.keng.com.vn" & Cr.FileAttach.ToLower() & "?dpi=150&quality=100&w=70"
                    flCache.SetCache("getImgTop_" & pid & "_" & idKey & "_" & table, getImgTop)
                    Return getImgTop
                Next
            End If
        End If
    End Function
    Public Shared Function getToContent(pid As Integer, idKey As String, table As String) As String
        getToContent = flCache.GetCache("getToContent_" & pid & "_" & idKey & "_" & table) & ""
        If getToContent = "" Then
            If table = "POST" Then
                Dim obj As CMS_PostInfo = ObjControler.CMS_Post_Get(pid, idKey)
                If IsNothing(obj) = False Then getToContent = flReg.Trimstr(flReg.RemoveHTML(obj.Contents), 50)
            End If
            flCache.SetCache("getToContent_" & pid & "_" & idKey & "_" & table, getToContent)
        End If
    End Function
    Public Shared Function Department_Name(PortalConnect As Integer, Department_ID As Integer) As String
        Department_Name = flCache.GetCache("Department_Name_" & Department_ID) & ""
        If Department_Name = "" Then
            Dim obj As CMS_DepartmentInfo = ObjControler.CMS_Department_Get(PortalConnect, Department_ID)
            If IsNothing(obj) = False Then
                flCache.SetCache("Department_Name_" & Department_ID, flReg.RemoveScript(obj.DepartmentName, False))
                Return flReg.RemoveScript(obj.DepartmentName, False)
            End If
        End If
    End Function
    Public Shared Function MeetingRoom_Name(PortalConnect As Integer, ID As Integer) As String
        MeetingRoom_Name = flCache.GetCache("MeetingRoom_Name_" & ID) & ""
        If MeetingRoom_Name = "" Then
            Dim obj As CMS_MeetingRoomInfo = ObjControler.CMS_MeetingRoom_Get(PortalConnect, ID)
            If IsNothing(obj) = False Then
                flCache.SetCache("MeetingRoom_Name_" & ID, flReg.RemoveScript(obj.MR_Name, False))
                Return flReg.RemoveScript(obj.MR_Name, False)
            End If
        End If
    End Function
    Public Shared Function getAppIdByEmCode(PortalConnect As Integer, uid As Integer, empCode As String) As String
        getAppIdByEmCode = flCache.GetCache("getAppIdByEmCode_" & uid & "_" & empCode) & ""
        If getAppIdByEmCode = "" Then
            Dim obj As CMS_EmployeeInfo = ObjControler.CMS_Employee_GetByCode(PortalConnect, uid, empCode)
            If IsNothing(obj) = False Then
                flCache.SetCache("getAppIdByEmCode_" & "_" & empCode, obj.AppID)
                Return obj.AppID
            End If
        End If
    End Function
    Public Shared Function MissionCar_Name(PortalConnect As Integer, carID As Integer) As String
        MissionCar_Name = flCache.GetCache("MissionCar_Name_" & carID) & ""
        If MissionCar_Name = "" Then
            Dim obj As CMS_MissionCarInfo = ObjControler.CMS_MissionCar_Get(PortalConnect, carID)
            If IsNothing(obj) = False Then
                flCache.SetCache("MissionCar_Name_" & carID, flReg.RemoveScript(obj.Car_Name, False))
                Return flReg.RemoveScript(obj.Car_Name, False)
            End If
        End If
    End Function
    Public Shared Function Department_ID(PortalConnect As Integer, DepartmentCode As String) As String
        Department_ID = flCache.GetCache("Department_Code_" & DepartmentCode) & ""
        If Department_ID = "" Then
            Dim obj As CMS_DepartmentInfo = ObjControler.CMS_Department_Get_ID(PortalConnect, DepartmentCode)
            If IsNothing(obj) = False Then
                flCache.SetCache("Department_Code_" & DepartmentCode, flReg.RemoveScript(obj.DepartmentID, False))
                Return flReg.RemoveScript(obj.DepartmentID, False)
            End If
        End If
    End Function
    Public Shared Function getFrToAppID(pid As Integer, idKey As String, table As String) As String
        getFrToAppID = flCache.GetCache("getFrToAppID_" & pid & "_" & idKey & "_" & table) & ""
        If getFrToAppID = "" Then
            If table = "POST" Then
                Dim obj As CMS_Fr_PostInfo = ObjControler.CMS_Fr_Post_Get(pid, idKey)
                If IsNothing(obj) = False Then getFrToAppID = obj.AppID
            ElseIf table = "ROOM" Then
                Dim obj As CMS_RoomInfo = ObjControler.CMS_Room_Get(pid, idKey)
                If IsNothing(obj) = False Then getFrToAppID = obj.AppID
            End If
            flCache.SetCache("getFrToAppID_" & pid & "_" & idKey & "_" & table, getFrToAppID)
        End If
    End Function
    Public Shared Function getFrImgTop(pid As Integer, idKey As String, table As String, Optional ByVal width As Integer = 70) As String
        getFrImgTop = flCache.GetCache("getFrImgTop_" & pid & "_" & idKey & "_" & table & "_" & width) & ""
        If getFrImgTop = "" Then
            If table = "POST" Then
                For Each Cr As CMS_Fr_FileAttachInfo In ObjControler.CMS_Fr_FileAttach_List_ByIdKey(pid, idKey, 0, 1)
                    getFrImgTop = "http://app.keng.com.vn" & Cr.FileAttach.ToLower() & "?dpi=150&quality=100&w=" & width
                    flCache.SetCache("getFrImgTop_" & pid & "_" & idKey & "_" & table & "_" & width, getFrImgTop)
                    Return getFrImgTop
                Next
            End If
        End If
    End Function
    Public Shared Function getFrToContent(pid As Integer, idKey As String, table As String) As String
        getFrToContent = flCache.GetCache("getFrToContent_" & pid & "_" & idKey & "_" & table) & ""
        If getFrToContent = "" Then
            If table = "POST" Then
                Dim obj As CMS_Fr_PostInfo = ObjControler.CMS_Fr_Post_Get(pid, idKey)
                If IsNothing(obj) = False Then getFrToContent = flReg.Trimstr(flReg.RemoveHTML(obj.Contents), 50)
            ElseIf table = "ROOM" Then
                Dim obj As CMS_RoomInfo = ObjControler.CMS_Room_Get(pid, idKey)
                If IsNothing(obj) = False Then getFrToContent = flReg.Trimstr(flReg.RemoveHTML(obj.TieuDe), 50)
            End If
            flCache.SetCache("getFrToContent_" & pid & "_" & idKey & "_" & table, getFrToContent)
        End If
    End Function
    Public Shared Function frMyLike(pid As Integer, postID As String, appID As String) As Boolean
        If IsNothing(flCache.GetCache("frMyLike_" & pid & "_" & postID & "_" & appID)) = True Then
            If ObjControler.CMS_Fr_Likes_Count_ByPostID(pid, postID, appID) > 0 Then
                flCache.SetCache("frMyLike_" & pid & "_" & postID & "_" & appID, True)
                Return True
            Else
                Return False
            End If
        Else
            Return flReg.ToBoolean(flCache.GetCache("frMyLike_" & pid & "_" & postID & "_" & appID))
        End If
    End Function
    Public Shared Function frMyShare(pid As Integer, postID As String, appID As String) As Boolean
        If IsNothing(flCache.GetCache("frMyShare_" & pid & "_" & postID & "_" & appID)) = True Then
            If ObjControler.CMS_Fr_SharePost_Count_ByPostID(pid, postID, appID) > 0 Then
                flCache.SetCache("frMyShare_" & pid & "_" & postID & "_" & appID, True)
                Return True
            Else
                Return False
            End If
        Else
            Return flReg.ToBoolean(flCache.GetCache("frMyShare_" & pid & "_" & postID & "_" & appID))
        End If
    End Function
End Class
