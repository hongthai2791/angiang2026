Imports System.Threading
Imports System.Web
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.Entities.Users
Imports System.Web.UI.WebControls

Public Class flFunction
    Shared ObjControler As New Kengcontroller
    Shared objCTLApp As New AppController
    Shared arrTemp, arr1 As New ArrayList
    Shared sAtr() As String

    Public Shared Function addNotify(pid As Integer, fromApp As String, toApp As String, idKey As String, toLink As String, flags As String, contents As String) As CMS_NotifyInfo
        addNotify = New CMS_NotifyInfo
        addNotify.FromApp = fromApp
        addNotify.ToApp = toApp
        addNotify.Contents = contents
        addNotify.ToLink = toLink
        addNotify.IdKey = idKey
        addNotify.Flags = flags
        addNotify.CreatedDate = Now
        ObjControler.CMS_Notify_Add(pid, addNotify)
    End Function
    Public Shared Function addFrNotify(pid As Integer, uID As Integer, fromApp As String, toApp As String, idKey As String, toLink As String, flags As String, contents As String, allPublic As Boolean) As CMS_Fr_NotifyInfo
        addFrNotify = New CMS_Fr_NotifyInfo
        addFrNotify.UID = uID
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
    Private Shared Sub DepParentData(drGroup As DropDownList, PortalID As Integer, ParentID As Integer, bID As Integer, str As String)
        If IsNothing(flCache.GetCache("CMS_Department_List_BID_Parent" & PortalID & "_" & bID & "_" & ParentID)) = True Then
            arr1 = ObjControler.CMS_Department_List_BID_Parent(PortalID, bID, ParentID)
            flCache.SetCache("CMS_Department_List_BID_Parent" & PortalID & "_" & bID & "_" & ParentID, arr1)
        Else
            arr1 = CType(flCache.GetCache("CMS_Department_List_BID_Parent" & PortalID & "_" & bID & "_" & ParentID), ArrayList)
        End If
        For Each Cr1 As CMS_DepartmentInfo In arr1
            drGroup.Items.Add(New ListItem(str & "[" & Cr1.DepartmentCode & "] " & flReg.RemoveScript(Cr1.DepartmentName, False), Cr1.DepartmentCode))
            Call DepParentData(drGroup, PortalID, Cr1.DepartmentID, bID, str & "|--- ")
        Next
    End Sub
    Public Shared Sub LoadDepartment(PortalId As Integer, bID As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        If IsNothing(flCache.GetCache("CMS_Department_List_BID_Parent" & PortalId & "_" & bID)) = True Then
            arrTemp = ObjControler.CMS_Department_List_BID_Parent(PortalId, bID, 0)
            flCache.SetCache("CMS_Department_List_BID_Parent" & PortalId & "_" & bID, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Department_List_BID_Parent" & PortalId & "_" & bID), ArrayList)
        End If
        For Each Ck As CMS_DepartmentInfo In arrTemp
            drGroup.Items.Add(New ListItem("[" & Ck.DepartmentCode & "] " & flReg.RemoveScript(Ck.DepartmentName, False), Ck.DepartmentCode))
            Call DepParentData(drGroup, PortalId, Ck.DepartmentID, bID, "|--- ")
        Next
    End Sub
    Public Shared Sub LoadGroup(PortalId As Integer, bID As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, "0"))
        If IsNothing(flCache.GetCache("CMS_Group_List_UID_" & PortalId & "_" & bID)) = True Then
            arrTemp = ObjControler.CMS_Group_List_UID(PortalId, bID)
            flCache.SetCache("CMS_Group_List_UID_" & PortalId & "_" & bID, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Group_List_UID_" & PortalId & "_" & bID), ArrayList)
        End If
        For Each Ck As CMS_GroupInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.Name, False), Ck.ID))
        Next
    End Sub
    Public Shared Sub LoadTypeZoom(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, "0"))
        If IsNothing(flCache.GetCache("CMS_TypeZoom_List_" & PortalId)) = True Then
            arrTemp = ObjControler.CMS_TypeZoom_List(PortalId)
            flCache.SetCache("CMS_TypeZoom_List_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_TypeZoom_List_" & PortalId), ArrayList)
        End If
        For Each Ck As CMS_TypeZoomInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.name, False), Ck.iD))
        Next
    End Sub
    Public Shared Sub LoadTienIch(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        If IsNothing(flCache.GetCache("CMS_Utility_List_" & PortalId)) = True Then
            arrTemp = ObjControler.CMS_Utility_List(PortalId)
            flCache.SetCache("CMS_Utility_List_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Utility_List_" & PortalId), ArrayList)
        End If
        For Each Ck As CMS_UtilityInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ck.name, False), Ck.iD))
        Next
    End Sub
    Public Shared Sub LoadSex(drPages As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drPages.Items.Clear()
        If text <> "" Then drPages.Items.Add(New ListItem(text, -1))
        drPages.Items.Add(New ListItem("2--Tất cả", "2"))
        drPages.Items.Add(New ListItem("1--Nam", "1"))
        drPages.Items.Add(New ListItem("0--Nữ", "0"))
    End Sub
    Public Shared Sub LoadXe(PortalId As Integer, UID As Integer, drXe As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drXe.Items.Clear()
        If text <> "" Then drXe.Items.Add(New ListItem(text, "0"))
        If IsNothing(flCache.GetCache("CMS_MissionCar_List_UID_" & PortalId & "_" & UID)) = True Then
            arrTemp = ObjControler.CMS_MissionCar_List_UID(PortalId, UID)
            flCache.SetCache("CMS_MissionCar_List_UID_" & PortalId & "_" & UID, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_MissionCar_List_UID_" & PortalId & "_" & UID), ArrayList)
        End If
        For Each Ck As CMS_MissionCarInfo In arrTemp
            drXe.Items.Add(New ListItem(flReg.RemoveScript(Ck.Car_Name, False), Ck.Car_ID))
        Next
    End Sub
    Public Shared Sub LoadMeetingRoom(PortalId As Integer, UID As Integer, drGr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGr.Items.Clear()
        If text <> "" Then drGr.Items.Add(New ListItem(text, "0"))
        If IsNothing(flCache.GetCache("CMS_MeetingRoom_List_UID_" & PortalId & "_" & UID)) = True Then
            arrTemp = ObjControler.CMS_MeetingRoom_List(PortalId, UID)
            flCache.SetCache("CMS_MeetingRoom_List_UID_" & PortalId & "_" & UID, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_MeetingRoom_List_UID_" & PortalId & "_" & UID), ArrayList)
        End If
        For Each Ck As CMS_MeetingRoomInfo In arrTemp
            drGr.Items.Add(New ListItem(flReg.RemoveScript(Ck.MR_Name, False), Ck.MR_ID))
        Next
    End Sub
    Public Shared Sub WebNoti(pid As Integer, sendKey As String, uID As Integer, idKey As String, hoten As String, dienthoai As String, contents As String,
                               flags As String, Optional ByVal logo As String = "0:NP,1:CC,2:TL,3:ĐX")
        Try
            Dim nobj As New CMS_NotiSendInfo
            sAtr = flReg.SettingValue(flConnect.DmConnect(0), "keng-manager", "WEB_NOTI_" & sendKey.ToUpper().Trim() & "_" & uID, "setting-noti").Split(",")
            For i As Integer = 0 To sAtr.Length - 1
                If sAtr(i) & "" <> "" Then
                    nobj.NotiSend_ID = flReg.GenKey()
                    nobj.AppID = sAtr(i).Replace(vbTab, "").Trim()
                    nobj.Notify_ID = "tbaoa926-a769-4442-aaa0-5e98a688e999"
                    nobj.Titles = "KENG - Thông báo"
                    nobj.Contents = contents
                    nobj.HoVaTen = hoten
                    nobj.DienThoai = dienthoai
                    nobj.Logo = logo
                    nobj.IdKey = idKey
                    nobj.TinhTrang = APP.appNotiSend.Send
                    nobj.CreatedDate = Now
                    nobj.SendDate = Now
                    nobj.Flags = flags
                    nobj.AppType = "Web_DN"
                    objCTLApp.CMS_NotiSend_Add(pid, nobj)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Function SendNoti(flag As String, pid As Integer, appID As String, emCode As String,
                               contents As String, idKey As String, sendApp As Boolean, logo As String,
                               Optional ByVal trangThai As Integer = appNotiSend.Errors,
                               Optional ByVal fwSend As String = "") As CMS_NotiSendInfo
        Dim sbj As New CMS_NotiSendInfo
        Try
            sbj.NotiSend_ID = flReg.GenKey()
            sbj.Notify_ID = "tbaoa926-a769-4442-aaa0-5e98a688e999"
            sbj.Titles = "KENG - Thông báo"
            sbj.Contents = contents
            sbj.AppID = appID
            sbj.IdKey = idKey
            sbj.Logo = logo
            sbj.DienThoai = appID
            sbj.HoVaTen = emCode
            sbj.TinhTrang = trangThai
            sbj.CreatedDate = Now
            If trangThai = appNotiSend.Errors Then
                sbj.SendDate = flReg.DateNull()
            Else
                sbj.SendDate = Now
            End If
            sbj.ReadDate = flReg.DateNull()
            sbj.AppType = "Keng_DN"
            sbj.FwSend = fwSend
            sbj.Flags = flag
            objCTLApp.CMS_NotiSend_Add(pid, sbj)
            If sendApp = True Then
                If flNotify.SendNotification(sbj.Notify_ID, sbj.AppID, flReg.notiDecode(sbj.Titles), flReg.notiDecode(sbj.Contents), sbj.AppType) Then
                    objCTLApp.CMS_NotiSend_Update_TinhTrang(pid, sbj.NotiSend_ID, APP.appNotiSend.Send)
                Else
                    flNotify.SendNotification(sbj.Notify_ID, sbj.AppID, flReg.notiDecode(sbj.Titles), flReg.notiDecode(sbj.Contents), sbj.AppType)
                    objCTLApp.CMS_NotiSend_Update_TinhTrang(pid, sbj.NotiSend_ID, APP.appNotiSend.News)
                End If
            End If
        Catch ex As Exception

        End Try
        Return sbj
    End Function
    Public Shared Function getToken(uID As Integer, str As String) As ArrayList
        sAtr = str.Split(",")
        getToken = New ArrayList
        Dim nobj As New fcmTokenInfo
        For i As Integer = 0 To sAtr.Length - 1
            nobj = New fcmTokenInfo
            nobj.appID = Keng.flCheck.Employee_AppID(0, sAtr(i), uID)
            nobj.token = APP.flCheck.getFcmToken(nobj.appID, "Keng_DN")
            getToken.Add(nobj)
        Next
    End Function
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