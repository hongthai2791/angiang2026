Imports DotNetNuke.VBN

Public Class flCheck
    Shared objController As New MobileController
    Shared str() As String, i As Integer
    Shared a1 As String() = New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Shared a2 As String() = New String() {"yZ", "xN", "vR", "kj", "cE", "dw", "up", "hB", "iq", "tA"}

    Public Shared Function toID(id As Integer) As String
        toID = id.ToString()
        For i As Integer = 0 To a1.Length - 1
            toID = toID.Replace(a1(i), a2(i))
        Next
    End Function
    Public Shared Function getID(id As String) As Integer
        For j As Integer = 0 To (id.Length - 1) / 2
            For i As Integer = 0 To a1.Length - 1
                id = id.Replace(a2(i), a1(i))
            Next
        Next
        Return flReg.WriteNumber(id)
    End Function
    Public Shared Function maDonHang(portalID As Integer) As String
        Return Now.ToString("MMdd.") & flReg.ReadNumber(objController.CMS_ShopBy_Count(0, portalID))
    End Function
    Public Shared Function shopByStatus(tinhTrang As Integer, Optional ByVal app As Boolean = False) As String
        If app = False Then
            Select Case tinhTrang
                Case statusShopBy.DonMoiGui
                    Return "<i class=""fa fa-star-half-o"" aria-hidden=""true""></i>Mới gửi"
                Case statusShopBy.KhachHuyDon
                    Return "<i class=""fa fa-reply"" aria-hidden=""true""></i>Khách hủy"
                Case statusShopBy.TuChoiDon
                    Return "<i class=""fa fa-reply-all"" aria-hidden=""true""></i>Từ chối"
                Case statusShopBy.TiepNhanDon
                    Return "<i class=""fa fa-inbox"" aria-hidden=""true""></i>Nhận đơn"
                Case statusShopBy.XuatKho
                    Return "<i class=""fa fa-hourglass-half"" aria-hidden=""true""></i>Xuất kho"
                Case statusShopBy.GiaoVanChuyen
                    Return "<i class=""fa fa-car"" aria-hidden=""true""></i>Đang giao"
                Case statusShopBy.KhachNhanHang
                    Return "<i class=""fa fa-cart-arrow-down"" aria-hidden=""true""></i>Đã giao"
                Case statusShopBy.KhachBomHang
                    Return "<i class=""fa fa-bomb"" aria-hidden=""true""></i>Khách bom"
                Case Else
                    Return ""
            End Select
        Else 'Hiện thị trên app
            Select Case tinhTrang
                Case statusShopBy.DonMoiGui
                    Return "Đã gửi đơn"
                Case statusShopBy.KhachHuyDon
                    Return "Đã hủy đơn"
                Case statusShopBy.TuChoiDon
                    Return "Bị từ chối"
                Case statusShopBy.TiepNhanDon, statusShopBy.XuatKho
                    Return "Đang xử lý"
                Case statusShopBy.GiaoVanChuyen
                    Return "Đang giao hàng"
                Case statusShopBy.KhachNhanHang
                    Return "Đã giao hàng"
                Case statusShopBy.KhachBomHang
                    Return "Không nhận hàng"
                Case Else
                    Return ""
            End Select
        End If


    End Function
    Public Shared Function genMaSanPham(pid As Integer, brandID As Integer, ID As Integer) As String
        i = objController.CMS_Product_Get_ByCount(pid, brandID, ID)
        If i < 10 Then
            genMaSanPham = quyUocThuongHieu(pid, brandID) & "00" & i
        ElseIf i < 100 Then
            genMaSanPham = quyUocThuongHieu(pid, brandID) & "0" & i
        Else
            genMaSanPham = quyUocThuongHieu(pid, brandID) & i
        End If
    End Function
    Public Shared Function getNhomSP(pid As Integer, ID As Integer) As Integer
        getNhomSP = flReg.WriteNumber(flCache.GetCache("getNhomSP_" & ID) & "")
        If getNhomSP = 0 Then
            Dim obj As CMS_ProductInfo = objController.CMS_Product_Get(pid, ID)
            If IsNothing(obj) = False Then
                getNhomSP = obj.NhomSP
                flCache.SetCache("getNhomSP_" & ID, obj.NhomSP)
            End If
        End If
    End Function
    Public Shared Function quyUocThuongHieu(pid As Integer, ID As Integer) As String
        quyUocThuongHieu = flCache.GetCache("quyUocThuongHieu_" & pid & "_" & ID) & ""
        If quyUocThuongHieu = "" Then
            Dim obj As CMS_ProductBrandInfo = objController.CMS_ProductBrand_Get(pid, ID)
            If IsNothing(obj) = False Then
                quyUocThuongHieu = flReg.RemoveScript(obj.QuiUoc, False)
                flCache.SetCache("quyUocThuongHieu_" & pid & "_" & ID, quyUocThuongHieu)
            End If
        End If
    End Function
    Public Shared Function tenNhomSP(pid As Integer, ID As Integer) As String
        tenNhomSP = flCache.GetCache("tenNhomSP_" & pid & "_" & ID) & ""
        If tenNhomSP = "" Then
            Dim obj As CMS_ProductGroupInfo = objController.CMS_ProductGroup_Get(pid, ID)
            If IsNothing(obj) = False Then
                tenNhomSP = flReg.RemoveScript(obj.TenNhom, False)
                flCache.SetCache("tenNhomSP_" & pid & "_" & ID, tenNhomSP)
            End If
        End If
    End Function
    Public Shared Function tenThuongHieu(pid As Integer, ID As Integer, Optional ByVal xXu As Boolean = False) As String
        tenThuongHieu = flCache.GetCache("tenThuongHieu_" & pid & "_" & ID & "_" & xXu) & ""
        If tenThuongHieu = "" Then
            Dim obj As CMS_ProductBrandInfo = objController.CMS_ProductBrand_Get(pid, ID)
            If IsNothing(obj) = False Then
                If xXu = False Then
                    tenThuongHieu = flReg.RemoveScript(obj.ThuongHieu, False)
                Else
                    tenThuongHieu = flReg.RemoveScript(obj.ThuongHieu, False) & " (" & flReg.RemoveScript(obj.XuatXu, False) & ")"
                End If
                flCache.SetCache("tenThuongHieu_" & pid & "_" & ID & "_" & xXu, tenThuongHieu)
            End If
        End If
    End Function
    Public Shared Function FoodC_Name(pid As Integer, ID As Integer) As String
        FoodC_Name = flCache.GetCache("FoodC_Name_" & pid & "_" & ID) & ""
        If FoodC_Name = "" Then
            Dim obj As CMS_FoodCInfo = objController.CMS_FoodC_Get(pid, ID)
            If IsNothing(obj) = False Then
                FoodC_Name = obj.Name
                flCache.SetCache("FoodC_Name_" & pid & "_" & ID, flReg.RemoveScript(FoodC_Name, False))
            End If
        End If
    End Function
    Public Shared Function StoryC_Name(pid As Integer, ID As Integer) As String
        StoryC_Name = flCache.GetCache("StoryC_Name_" & pid & "_" & ID) & ""
        If StoryC_Name = "" Then
            Dim obj As CMS_StoryCInfo = objController.CMS_StoryC_Get(pid, ID)
            If IsNothing(obj) = False Then
                StoryC_Name = obj.Name
                flCache.SetCache("StoryC_Name_" & pid & "_" & ID, flReg.RemoveScript(StoryC_Name, False))
            End If
        End If
    End Function
    Public Shared Function StoryCateName(pid As Integer, ID As Integer) As String
        StoryCateName = flCache.GetCache("StoryCateName_" & pid & "_" & ID) & ""
        If StoryCateName = "" Then
            For Each Cr As CMS_StoryDInfo In objController.CMS_StoryD_Get_By_CMS_Story(pid, ID)
                StoryCateName += StoryC_Name(pid, Cr.CateID) & ", "
            Next
            If StoryCateName <> "" Then
                StoryCateName = StoryCateName.Substring(0, StoryCateName.LastIndexOf(",")).Trim()
                flCache.SetCache("StoryCateName_" & pid & "_" & ID, flReg.RemoveScript(StoryCateName, False))
            End If
        End If
    End Function
    Public Shared Function tenHoiNhom(hNhom As Integer) As String
        Select Case hNhom
            Case hoiNhom.CungTuoi
                Return "Bé cùng tuổi"
            Case hoiNhom.LamMe
                Return "Làm mẹ thông thái"
            Case hoiNhom.SucKhoe
                Return "Sức khỏe & sắc đẹp"
            Case hoiNhom.TamSu
                Return "Tâm sự thầm kín"
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function TinhTrangTruyen(tinhTrang As Integer) As String
        Select Case tinhTrang
            Case StoryIndex.HoanThanh
                Return "Hoàn thành"
            Case StoryIndex.DangDich
                Return "Đang dịch"
            Case Else
                Return "Đang viết"
        End Select
    End Function
    Public Shared Function getFcmToken(appID As String, portalID As Integer) As String
        getFcmToken = flCache.GetCache("getFcmToken_" & appID & "_" & portalID) & ""
        If getFcmToken = "" Then
            Dim obj As CMS_FCMInfo = objController.CMS_FCM_Get(0, appID, portalID)
            If IsNothing(obj) = False Then
                getFcmToken = obj.Token
                flCache.SetCache("getFcmToken_" & appID & "_" & portalID, getFcmToken)
            End If
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
    Public Shared Function ReadCode(id As Integer) As String
        If id < 10 Then
            ReadCode = "0000" & id
        ElseIf id < 100 Then
            ReadCode = "000" & id
        ElseIf id < 1000 Then
            ReadCode = "00" & id
        Else
            ReadCode = id
        End If
    End Function
    Public Shared Function NotiSendStatus(tinhtrang As Integer) As String
        If tinhtrang = appNotiSend.Send Then
            Return "Đã gửi"
        ElseIf tinhtrang = appNotiSend.Read Then
            Return "Đã đọc"
        ElseIf tinhtrang = appNotiSend.Errors Then
            Return "Gửi lỗi"
        Else
            Return "Chưa gửi"
        End If
    End Function
    Public Shared Function GetSystem(IsSystem As Integer) As String
        If IsSystem = AppSystem.iOS Then
            Return "iOS"
        ElseIf IsSystem = AppSystem.Android Then
            Return "Android"
        Else
            Return "Khác"
        End If
    End Function
    Public Shared Function GetAppStatus(isStatus As Integer) As String
        Select Case isStatus
            Case AppStatus.Pause
                Return "Tạm dừng"
            Case AppStatus.Lock
                Return "Bị khóa"
            Case AppStatus.Remove
                Return "Gỡ bỏ"
            Case AppStatus.Change
                Return "Thay đổi"
            Case Else
                Return "Hoạt động"
        End Select
    End Function
    Public Shared Function getLogTime(logTime As Integer) As String
        Dim time As TimeSpan = TimeSpan.FromSeconds(logTime)
        getLogTime = "<span class='s-h'>" & time.ToString("hh") & "</span>h"
        getLogTime += "<span class='s-m'>" & time.ToString("mm") & "</span>'"
        getLogTime += "<span class='s-s'>" & time.ToString("ss") & "</span>"
    End Function
    Public Shared Function GioiTinh(Gender As Integer) As String
        If Gender = GenderType.Nam Then
            Return "Nam"
        ElseIf Gender = GenderType.Nu Then
            Return "Nữ"
        Else
            Return "Không yêu cầu"
        End If
    End Function
    Public Shared Function RequestItem(RawUrl As String, Optional ByVal idex As Integer = 1) As String
        str = RawUrl.Split("/")
        Return str(str.Length - idex).Replace(".html", "")
    End Function
    Public Shared Function RequestItem(ToUrl As String, Item As String) As String
        ToUrl = ToUrl.Substring(ToUrl.LastIndexOf("/" & Item & "/") + Item.Length + 2)
        str = ToUrl.Split("/")
        Return str(0)
    End Function
    Public Shared Function getAppFullName(pid As Integer, appID As String, Optional ByVal getFull As Boolean = False) As String
        Try
            getAppFullName = flCache.GetCache("getAppFullName_" & pid & "_" & appID & "_" & getFull) & ""
            If getAppFullName = "" Then
                Dim obj As CMS_AppInfo
                If IsNothing(flCache.GetCache("CMS_App_Get_By_AppID_" & pid & "_" & appID)) = True Then
                    obj = objController.CMS_App_Get_By_AppID(0, pid, appID)
                    If IsNothing(obj) = False Then flCache.SetCache("CMS_App_Get_By_AppID_" & pid & "_" & appID, obj)
                Else
                    obj = CType(flCache.GetCache("CMS_App_Get_By_AppID_" & pid & "_" & appID), CMS_AppInfo)
                End If
                If IsNothing(obj) = False Then
                    If obj.HoVaTen <> "" Then
                        getAppFullName = obj.HoVaTen
                        flCache.SetCache("getAppFullName_" & pid & "_" & appID, getAppFullName)
                    ElseIf getFull = False Then
                        getAppFullName = flDic.hideString(appID, 3, "C")
                    Else
                        getAppFullName = appID
                    End If
                ElseIf getFull = False Then
                    getAppFullName = flDic.hideString(appID, 3, "C")
                Else
                    getAppFullName = appID
                End If
            End If
        Catch ex As Exception
            getAppFullName = appID
        End Try
    End Function
    Public Shared Function GetCateID_WebTabID(PortalID As Integer, tabid As Integer) As Integer
        GetCateID_WebTabID = flReg.WriteNumber(flCache.GetCache("GetCateID_WebTabID_" & PortalID & "_" & tabid))
        If GetCateID_WebTabID = 0 Then
            Dim obj As CMS_CategoryInfo = objController.CMS_Category_Get_By_TabID(PortalID, tabid, flReg.WebConfig("PortalWpm"))
            If Not obj Is Nothing Then
                GetCateID_WebTabID = obj.CategoryID
                flCache.SetCache("GetCateID_WebTabID_" & PortalID & "_" & tabid, GetCateID_WebTabID)
            End If
        End If
    End Function
    Public Shared Function GetCateID_WebTabpath(PortalID As Integer, tabpath As String, tabID As Integer) As Integer
        GetCateID_WebTabpath = flReg.WriteNumber(flCache.GetCache("GetCateID_WebTabID_" & PortalID & "_" & tabpath))
        If GetCateID_WebTabpath = 0 Then
            Dim obj As CMS_CategoryInfo = objController.CMS_Category_Get_By_TabPath(PortalID, tabpath, tabID, flReg.WebConfig("PortalWpm"))
            If Not obj Is Nothing Then
                GetCateID_WebTabpath = obj.CategoryID
                flCache.SetCache("GetCateID_WebTabID_" & PortalID & "_" & tabID, GetCateID_WebTabpath)
            End If
        End If
    End Function
    Public Shared Function getAppAvatar(pid As Integer, appID As String) As String
        Try
            getAppAvatar = flCache.GetCache("getAppAvatar_" & pid & "_" & appID) & ""
            If getAppAvatar = "" Then
                Dim obj As CMS_AppInfo
                If IsNothing(flCache.GetCache("CMS_App_Get_AppID_" & pid & "_" & appID)) = True Then
                    obj = objController.CMS_App_Get_By_AppID(0, pid, appID)
                    If IsNothing(obj) = False Then flCache.SetCache("CMS_App_Get_AppID_" & pid & "_" & appID, obj)
                Else
                    obj = CType(flCache.GetCache("CMS_App_Get_AppID_" & pid & "_" & appID), CMS_AppInfo)
                End If

                If IsNothing(obj) = False Then
                    If obj.Avatar <> "" Then
                        getAppAvatar = "http://media.izilife.vn" & obj.Avatar.ToLower() & "?dpi=150&quality=100&w=120"
                        flCache.SetCache("getAppAvatar_" & pid & "_" & appID, getAppAvatar)
                    Else
                        getAppAvatar = "/assets/images/noimage.png"
                    End If
                Else
                    getAppAvatar = "/assets/images/noimage.png"
                End If
            End If

        Catch ex As Exception
            getAppAvatar = "/assets/images/noimage.png"
        End Try
    End Function
    Public Shared Function getAppAvatarToEmp(pid As Integer, appID As String) As String
        getAppAvatarToEmp = flCache.GetCache("getAppAvatarToEmp_" & pid & "_" & appID) & ""
        If getAppAvatarToEmp = "" Then
            Dim obj As CMS_AppInfo
            If IsNothing(flCache.GetCache("CMS_App_Get_AppID_" & pid & "_" & appID)) = True Then
                obj = objController.CMS_App_Get_By_AppID(0, pid, appID)
                If IsNothing(obj) = False Then flCache.SetCache("CMS_App_Get_AppID_" & pid & "_" & appID, obj)
            Else
                obj = CType(flCache.GetCache("CMS_App_Get_AppID_" & pid & "_" & appID), CMS_AppInfo)
            End If
            If IsNothing(obj) = False Then
                getAppAvatarToEmp = "http://media.izilife.vn" & obj.Avatar.ToLower() & "?dpi=150&quality=100&w=120"
                flCache.SetCache("getAppAvatarToEmp_" & pid & "_" & appID, getAppAvatarToEmp)
            End If
        End If
    End Function
    Public Shared Function SetupValue(PortalID As Integer, strName As String) As String
        SetupValue = flCache.GetCache("SetupValue" & PortalID & strName) & ""
        If SetupValue = "" Then
            Dim obj As CMS_SetupsInfo = objController.CMS_Setups_Get_By_Name(PortalID, strName)
            If IsNothing(obj) = False Then
                SetupValue = obj.SettingValue
                flCache.SetCache("SetupValue" & PortalID & strName, SetupValue)
            End If
        End If
    End Function
    Public Shared Function frMyLike(pid As Integer, postID As String, appID As String) As Boolean
        If IsNothing(flCache.GetCache("MB:frMyLike_" & pid & "_" & postID & "_" & appID)) = True Then
            If objController.CMS_Fr_Likes_Count_ByPostID(pid, postID, appID) > 0 Then
                flCache.SetCache("MB:frMyLike_" & pid & "_" & postID & "_" & appID, True)
                Return True
            Else
                Return False
            End If
        Else
            Return flReg.ToBoolean(flCache.GetCache("MB:frMyLike_" & pid & "_" & postID & "_" & appID))
        End If
    End Function
    Public Shared Function frMyShare(pid As Integer, postID As String, appID As String) As Boolean
        If IsNothing(flCache.GetCache("MB:frMyShare_" & pid & "_" & postID & "_" & appID)) = True Then
            If objController.CMS_Fr_SharePost_Count_ByPostID(pid, postID, appID) > 0 Then
                flCache.SetCache("MB:frMyShare_" & pid & "_" & postID & "_" & appID, True)
                Return True
            Else
                Return False
            End If
        Else
            Return flReg.ToBoolean(flCache.GetCache("MB:frMyShare_" & pid & "_" & postID & "_" & appID))
        End If
    End Function
    Public Shared Function HappyBrith(pid As Integer, appID As String, uid As Integer) As String
        HappyBrith = flCache.GetCache("MB:HappyBrith_" & pid & "_" & appID & "_" & uid)
        If HappyBrith = "" Then
            'Dim obj As CMS_EmployeeInfo = objController.CMS_Employee_Get_By_AppID(pid, uid, appID)
            'If IsNothing(obj) = False Then
            '    HappyBrith = "<div class=""text-hbd-1"">Hôm nay là sinh nhật của<b>&nbsp;" & obj.EmployeeCode & " - " & obj.ChucDanh & " " & obj.EmployeeName & "</b>, hãy gửi đến <b>" & obj.EmployeeCode & "</b> những lời chúc tốt đẹp nhất!</div>"
            '    flCache.SetCache("MB:HappyBrith_" & pid & "_" & appID & "_" & uid, HappyBrith)
            'End If
        End If
    End Function
    Public Shared Function getFrToAppID(pid As Integer, idKey As String, table As String) As String
        getFrToAppID = flCache.GetCache("MB:getFrToAppID_" & pid & "_" & idKey & "_" & table) & ""
        If getFrToAppID = "" Then
            If table = "POST" Then
                Dim obj As CMS_Fr_PostInfo = objController.CMS_Fr_Post_Get(pid, idKey)
                If IsNothing(obj) = False Then getFrToAppID = obj.AppID
            End If
            flCache.SetCache("MB:getFrToAppID_" & pid & "_" & idKey & "_" & table, getFrToAppID)
        End If
    End Function
    Public Shared Function getFrImgTop(pid As Integer, idKey As String, table As String, Optional ByVal width As Integer = 70) As String
        getFrImgTop = flCache.GetCache("MB:getFrImgTop_" & pid & "_" & idKey & "_" & table & "_" & width) & ""
        If getFrImgTop = "" Then
            If table = "POST" Then
                For Each Cr As CMS_Fr_FileAttachInfo In objController.CMS_Fr_FileAttach_List_ByIdKey(pid, idKey, 0, 1)
                    getFrImgTop = "http://media.izilife.vn" & Cr.FileAttach.ToLower() & "?dpi=150&quality=100&w=" & width
                    flCache.SetCache("MB:getFrImgTop_" & pid & "_" & idKey & "_" & table & "_" & width, getFrImgTop)
                    Return getFrImgTop
                Next
            End If
        End If
    End Function
    Public Shared Function getFrToContent(pid As Integer, idKey As String, table As String) As String
        getFrToContent = flCache.GetCache("MB:getFrToContent_" & pid & "_" & idKey & "_" & table) & ""
        If getFrToContent = "" Then
            If table = "POST" Then
                Dim obj As CMS_Fr_PostInfo = objController.CMS_Fr_Post_Get(pid, idKey)
                If IsNothing(obj) = False Then getFrToContent = flReg.Trimstr(flReg.RemoveHTML(obj.Contents), 50)
            End If
            flCache.SetCache("MB:getFrToContent_" & pid & "_" & idKey & "_" & table, getFrToContent)
        End If
    End Function
    Public Shared Function GetFrGroup_Name(pid As Integer, groupID As Integer) As Integer
        GetFrGroup_Name = flReg.WriteNumber(flCache.GetCache("GetFrGroup_Name_" & groupID))
        If GetFrGroup_Name = 0 Then
            Dim obj As CMS_Fr_GroupInfo = objController.CMS_Fr_Group_Get(pid, groupID)
            If Not obj Is Nothing Then
                GetFrGroup_Name = obj.Name
                flCache.SetCache("GetFrGroup_Name_" & groupID, GetFrGroup_Name)
            End If
        End If
    End Function
    Public Shared Function GetCategoryName(PortalId As Integer, categoryId As Integer) As String
        GetCategoryName = flCache.GetCache("GetCategoryName_" & PortalId & "_" & categoryId) & ""
        If GetCategoryName = "" Then
            Dim obj As CMS_CategoryInfo = objController.CMS_Category_Get(PortalId, categoryId)
            If Not obj Is Nothing Then
                flCache.SetCache("GetCategoryName_" & PortalId & "_" & categoryId, obj.CategoryName)
                Return obj.CategoryName
            End If
            Return "--"
        End If
    End Function
    Public Shared Function WebLink(linkType As Integer) As String
        Select Case linkType
            Case WebLinkType.BenTrai
                Return "Bên trái trang"

            Case WebLinkType.BenPhai
                Return "Bên phải trang"

            Case Else 'WebLinkType.Khac
                Return "Khác"
        End Select
    End Function

#Region "search"
    Public Shared Function DecodeSearch(ToUrl As String) As String
        If ToUrl.Trim & "" <> "" Then
            Dim arr1 As String() = New String() {"-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
                                         "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
                                         "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
                                         "-1D", "-3D", "-4D", "-5D", "-6D", "-2D"}

            Dim arr2 As String() = New String() {".", ":", """", "`", "!", "'",
                                         "@", "#", "$", "^", "&", "*",
                                         "(", ")", "|", "{", "}", "?", "+",
                                         "~", "<", ">", "/", "\", "_"}

            For i As Integer = 0 To arr1.Length - 1
                ToUrl = ToUrl.Replace(arr1(i), arr2(i))
            Next
            Return ToUrl.Replace("-", " ")
        Else
            Return ""
        End If
    End Function
    Public Shared Function RequestSearch(ToUrl As String, Optional ByVal html As String = ".html") As String
        If ToUrl.Contains("/q/") Then
            str = ToUrl.Substring(ToUrl.LastIndexOf("/q/") + 3).Split("/")
            Dim arr1 As String() = New String() {"-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
                                         "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
                                         "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
                                         "-1D", "-3D", "-4D", "-5D", "-6D", "-2D"}

            Dim arr2 As String() = New String() {".", ":", """", "`", "!", "'",
                                         "@", "#", "$", "^", "&", "*",
                                         "(", ")", "|", "{", "}", "?", "+",
                                         "~", "<", ">", "/", "\", "_"}

            ToUrl = str(0)
            For i As Integer = 0 To arr1.Length - 1
                ToUrl = ToUrl.Replace(arr1(i), arr2(i))
            Next
            Return ToUrl.Replace("-", " ")
        Else
            Return ""
        End If
    End Function
    Public Shared Function EncodeSearch(txtkey As String) As String
        txtkey = txtkey.Trim
        Dim arr1 As String() = New String() {".", ":", """", "`", "!", "'",
                                     "@", "#", "$", "^", "&", "*",
                                     "(", ")", "|", "{", "}", "?", "+",
                                     "~", " ", "<", ">", "/", "\", "_"}
        Dim arr2 As String() = New String() {"-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
                                     "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
                                     "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
                                     "-1D", "-", "-3D", "-4D", "-5D", "-6D", "-2D"}

        For i As Integer = 0 To arr1.Length - 1
            txtkey = txtkey.Replace(arr1(i), arr2(i))
        Next
        Return txtkey
    End Function
#End Region
End Class

