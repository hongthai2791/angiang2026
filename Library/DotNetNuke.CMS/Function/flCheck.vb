Imports DotNetNuke.EPORTAL

Public Class flCheck

    Private Shared arrTemp As New ArrayList
    Shared str() As String
    Shared strLit As String

#Region "Function"

    Public Shared qsTimKiem As String() = New String() {"sch", "key", "catid", "type", "from", "to", "pageNo", "kind",
                                                        "pbid", "uid", "status", "isactive", "isimage", "source", "flag",
                                                        "itemid", "chucvu", "portalid"}
    Public Shared Function GetPublishedInfo(ByVal portalid As Integer, ByVal publisher As String, ByVal publishedDate As DateTime) As String
        Return flReg.GetUserName(publisher) & " / " & publishedDate.ToString("dd/MM/yyyy HH:mm")
    End Function
    Public Shared Function AppendPatternToString(ByVal sSourceString As String, ByVal sPatten As String, ByVal spliterString As String, Optional ByVal AppendToheader As Boolean = True) As String
        If sSourceString Is Common.Utilities.Null.NullString Then
            sSourceString = String.Empty
        End If
        Dim arrChar As Char() = {spliterString}
        Dim sTemp As String = spliterString + sSourceString.Trim(arrChar) + spliterString
        If Not sTemp.Contains(spliterString + sPatten + spliterString) Then
            If AppendToheader = True Then
                sSourceString = sPatten + spliterString + sSourceString.Trim(arrChar)
            Else
                sSourceString = sSourceString.Trim(arrChar) + spliterString + sPatten
            End If
        End If
        Return sSourceString.Trim(arrChar)
    End Function
    Public Shared Function GetCreatedInfo(ByVal portalid As Integer, ByVal tacgia As String, ByVal Createdate As DateTime) As String
        Dim sResult As String = String.Empty
        sResult = AppendPatternToString(sResult, flReg.GetUserName(tacgia), ",")
        Return sResult & " (" & Createdate.ToString("dd/MM/yyyy HH:mm") & ")"
    End Function
    Public Shared Function GetSend2ApprovalInfo(ByVal portalid As Integer, ByVal tacgia As String, ByVal sendingRequestDate As DateTime) As String
        Dim sResult As String = String.Empty
        sResult = AppendPatternToString(sResult, flReg.GetUserName(tacgia), ",")

        Return sResult & " (" & sendingRequestDate.ToString("dd/MM/yyyy HH:mm") & ")"
    End Function
    Public Shared Function GetApprovalInfo(ByVal portalid As Integer, ByVal approver As String, ByVal approvedDate As DateTime) As String
        Return flReg.GetUserName(approver) + " (" + approvedDate.ToString("dd/MM/yyyy HH:mm") + ")"
    End Function
    Public Shared Function CateTabsID(PortalID As Integer, CategoriesID As String) As Integer
        CateTabsID = flReg.WriteNumber(flCache.GetCache("CateTabsID_" & PortalID & "_" & CategoriesID))
        If CateTabsID = 0 Then
            CategoriesID = flReg.WriteNumber(CategoriesID)
            Dim obj As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get(PortalID, CategoriesID)
            If IsNothing(obj) = False Then
                flCache.SetCache("CateTabsID_" & PortalID & "_" & CategoriesID, obj.TabID)
                Return obj.TabID
            Else
                Return -1
            End If
        End If
    End Function
    Public Shared Function CateTabsPath(PortalID As Integer, CategoriesID As String) As String
        CateTabsPath = flCache.GetCache("CateTabsPath_" & PortalID & "_" & CategoriesID) & ""
        If CateTabsPath = "" Then
            CategoriesID = flReg.WriteNumber(CategoriesID)
            Dim obj As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get(PortalID, CategoriesID)
            If IsNothing(obj) = False Then
                flCache.SetCache("CateTabsPath_" & PortalID & "_" & CategoriesID, obj.TabPath)
                Return obj.TabPath
            End If
        End If
    End Function
    Public Shared Function GetCateID_WebTabID(PortalID As Integer, tabid As Integer) As Integer
        GetCateID_WebTabID = flReg.WriteNumber(flCache.GetCache("GetCateID_WebTabID_" & PortalID & "_" & tabid))
        If GetCateID_WebTabID = 0 Then
            Dim obj As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get_By_TabID(PortalID, tabid, PortalID)
            If Not obj Is Nothing Then
                GetCateID_WebTabID = obj.CategoryID
                flCache.SetCache("GetCateID_WebTabID_" & PortalID & "_" & tabid, GetCateID_WebTabID)
            End If
        End If
    End Function
	Public Shared Function GetCateID_MobileTabID(PortalID As Integer, tabid As Integer) As Integer
		GetCateID_MobileTabID = flReg.WriteNumber(flCache.GetCache("GetCateID_MobileTabID_" & PortalID & "_" & tabid))
		If GetCateID_MobileTabID = 0 Then
			Dim obj As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get_By_TabID(PortalID, tabid, PortalID)
			If Not obj Is Nothing Then
				GetCateID_MobileTabID = obj.CategoryID
				flCache.SetCache("GetCateID_MobileTabID_" & PortalID & "_" & tabid, GetCateID_MobileTabID)
			End If
		End If
	End Function
	Public Shared Function getTrangThai(status As Integer) As String
		Select Case status
			Case NewsStatus.DaXuatBan
				Return "Đã xuất bản"
			Case NewsStatus.HuyXuatBan
				Return "Hủy xuất bản"
			Case Else
				Return "Đang biên tập"
		End Select
	End Function
    Public Shared Function GetPhongBanIdByUserId(ByVal portalid As Integer, ByVal UserId As String) As Integer
        If UserId <> "" Then
            Dim strCacheKey As String = ""
            strCacheKey = "CMS_DepartmentsInfo:" & UserId
            Dim strPhongBan As String = "-1"
            flCache.RemoveCache(strCacheKey)
            strPhongBan = flCache.GetCache(strCacheKey)
            If strPhongBan = "-1" OrElse strPhongBan = "" Then
                Dim arr As ArrayList = New CmsController().CMS_Departments_NguoiDung_GetByNguoiDung(portalid, UserId, portalid)
                If Not arr Is Nothing AndAlso arr.Count > 0 Then
                    Dim obj As CMS_Departments_NguoiDungInfo = DirectCast(arr(0), CMS_Departments_NguoiDungInfo)
                    strPhongBan = obj.PhongBan
                    flCache.SetCache(strCacheKey, strPhongBan)
                Else
                    Return -1
                End If
            End If
            Return strPhongBan
        Else
            Return -1
        End If
    End Function
    Public Shared Function PageLocal_Name(id As String) As String
        PageLocal_Name = flCache.GetCache("CMS_PageLocal_Get_" & id) & ""
        If PageLocal_Name = "" Then
            Dim obj As CMS_PageLocalInfo = New CmsController().CMS_PageLocal_Get(flConnect.PortalId, id)
            If IsNothing(obj) = False Then
                flCache.SetCache("CMS_PageLocal_Get_" & id, obj.PageLocal_Name)
            End If
        End If
    End Function
    Public Shared Function DocType_Name(PortalID As Integer, id As String) As String
        DocType_Name = flCache.GetCache("CMS_DocType_Get_" & id & "_" & PortalID) & ""
        If DocType_Name = "" Then
            Dim obj As CMS_DocTypeInfo = New CmsController().CMS_DocType_Get(PortalID, id)
            If IsNothing(obj) = False Then
                flCache.SetCache("CMS_DocType_Get_" & id & "_" & PortalID, obj.DocType_Name)
            End If
        End If
    End Function
    Public Shared Function DocField_Name(PortalID As Integer, id As String) As String
        DocField_Name = flCache.GetCache("CMS_DocField_Get_" & id & "_" & PortalID) & ""
        If DocField_Name = "" Then
            Dim obj As CMS_DocFieldInfo = New CmsController().CMS_DocField_Get(PortalID, id)
            If IsNothing(obj) = False Then
                flCache.SetCache("CMS_DocField_Get_" & id & "_" & PortalID, obj.DocField_Name)
            End If
        End If
    End Function
    Public Shared Function DocUnit_Name(PortalID As Integer, id As String) As String
        DocUnit_Name = flCache.GetCache("CMS_DocUnit_Get_" & id & "_" & PortalID) & ""
        If DocUnit_Name = "" Then
            Dim obj As CMS_DocUnitInfo = New CmsController().CMS_DocUnit_Get(PortalID, id)
            If IsNothing(obj) = False Then
                flCache.SetCache("CMS_DocUnit_Get_" & id & "_" & PortalID, obj.DocUnit_Name)
            End If
        End If
    End Function
#End Region
#Region "search"
    Public Shared Function RequestSearch(ToUrl As String, Optional ByVal html As String = ".html") As String
        If ToUrl.Contains("/q/") Then
            str = ToUrl.Substring(ToUrl.LastIndexOf("/q/") + 3).Split("/")
            Dim arr1 As String() = New String() {"-7D", "-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
                                         "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
                                         "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
                                         "-1D", "-3D", "-4D", "-5D", "-6D", "-2D"}

            Dim arr2 As String() = New String() {"-", ".", ":", """", "`", "!", "'",
                                         "@", "#", "$", "^", "&", "*",
                                         "(", ")", "|", "{", "}", "?", "+",
                                         "~", "<", ">", "/", "\", "_"}

            ToUrl = str(0)
            For i As Integer = 0 To arr1.Length - 1
                ToUrl = ToUrl.Replace(arr1(i), arr2(i))
            Next
            Return ToUrl
        Else
            Return ""
        End If
    End Function
    Public Shared Function EncodeSearch(txtkey As String) As String
        txtkey = txtkey.Trim
        Dim arr1 As String() = New String() {"-7D", "-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
                                         "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
                                         "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
                                         "-1D", "-3D", "-4D", "-5D", "-6D", "-2D"}

        Dim arr2 As String() = New String() {"-", ".", ":", """", "`", "!", "'",
                                         "@", "#", "$", "^", "&", "*",
                                         "(", ")", "|", "{", "}", "?", "+",
                                         "~", "<", ">", "/", "\", "_"}


        For i As Integer = 0 To arr1.Length - 1
            txtkey = txtkey.Replace(arr2(i), arr1(i))
        Next
        Return txtkey
    End Function
    Public Shared Function DecodeSearch(ToUrl As String) As String
        If ToUrl.Trim & "" <> "" Then
            Dim arr1 As String() = New String() {"-7D", "-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
                                         "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
                                         "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
                                         "-1D", "-3D", "-4D", "-5D", "-6D", "-2D"}

            Dim arr2 As String() = New String() {"-", ".", ":", """", "`", "!", "'",
                                         "@", "#", "$", "^", "&", "*",
                                         "(", ")", "|", "{", "}", "?", "+",
                                         "~", "<", ">", "/", "\", "_"}

            For i As Integer = 0 To arr1.Length - 1
                ToUrl = ToUrl.Replace(arr1(i), arr2(i))
            Next
            Return ToUrl
        Else
            Return ""
        End If
    End Function
#End Region
#Region "Get ID"
    Public Shared Function NguoiDungChucVu(PortalID As String, userName As String, chucVu As String) As String
        NguoiDungChucVu = flCache.GetCache("NguoiDung_Get_ChucVu" & PortalID & userName & chucVu) & ""
        If NguoiDungChucVu = "" Then
            NguoiDungChucVu = New CmsController().CMS_Departments_NguoiDung_Get_ChucVu(PortalID, userName, chucVu)
            NguoiDungChucVu = flReg.GetUserName(NguoiDungChucVu)
            flCache.SetCache("NguoiDung_Get_ChucVu" & PortalID & userName & chucVu, NguoiDungChucVu)
        End If
    End Function
    Public Shared Function DocType(Type As String) As Boolean
        str = New String() {"doc", "docx", "xls", "xlsx", "ppt", "pptx", "pdf", "rar", "zip"}
        For i As Integer = 0 To str.Length - 1
            If Type = str(i) Then Return True
        Next
        Return False
    End Function
    Public Shared Function ImgType(Type As String) As Boolean
        str = New String() {"jpg", "jpeg", "jpe", "jpe", "gif", "png", "bmp", "png", "svg", "ico", "ttf"}
        For i As Integer = 0 To str.Length - 1
            If Type = str(i) Then Return True
        Next
        Return False
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
    Public Shared Function CateID(PortalID As Integer, ByVal tabID As String, Optional ByVal Parent As Boolean = True) As Integer
        Dim obj As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get_By_TabID_Parent(PortalID, tabID, Parent)
        If IsNothing(obj) = False Then
            Return obj.CategoryID
        Else
            Return 0
        End If
    End Function
    Public Shared Function DepamentID(PortalID As Integer, UserName As String) As String
        DepamentID = flCache.GetCache("DepamentID" & PortalID & UserName)
        If DepamentID = "" Then
            For Each Cr As CMS_DepartmentsInfo In New CmsController().CMS_Departments_NguoiDung_Get_By_UserId(PortalID, UserName, PortalID)
                DepamentID = Cr.Id
                flCache.SetCache("DepamentID" & PortalID & UserName, DepamentID)
                Return DepamentID
            Next
        End If
    End Function
    Public Shared Function TenPhongBan(PortalID As Integer, PhongBanID As Integer) As String
        TenPhongBan = flCache.GetCache("TenPhongBan" & PortalID & PhongBanID)
        If TenPhongBan = "" Then
            Dim obj As CMS_DepartmentsInfo = New CmsController().CMS_Departments_Get(PortalID, PhongBanID)
            If IsNothing(obj) = False Then
                TenPhongBan = obj.TenPhongBan
                flCache.SetCache("TenPhongBan" & PortalID & PhongBanID, TenPhongBan)
                Return TenPhongBan
            End If
        End If
    End Function
    Public Shared Function DepamentName(PortalID As Integer, UserName As String) As String
        DepamentName = flCache.GetCache("DepamentName" & PortalID & UserName)
        If DepamentName = "" Then
            For Each Cr As CMS_DepartmentsInfo In New CmsController().CMS_Departments_NguoiDung_Get_By_UserId(PortalID, UserName, PortalID)
                DepamentName = Cr.TenPhongBan
                flCache.SetCache("DepamentName" & PortalID & UserName, DepamentName)
                Return DepamentName
            Next
        End If
    End Function

    Public Shared Function ConfigSystemAnalytics(PortalID As Integer) As String
        ConfigSystemAnalytics = flCache.GetCache("ConfigSystemAnalytics_" & PortalID) & ""
        If ConfigSystemAnalytics = "" Then
            Dim obj As CMS_ConfigSystemInfo = New CmsController().CMS_ConfigSystem_Get_PortalID(PortalID, PortalID)
            If IsNothing(obj) = False Then
                flCache.SetCache("ConfigSystemAnalytics_" & PortalID, obj.Analytics)
                Return obj.Analytics
            End If
        End If
    End Function
    Public Shared Function ConfigSystemCSS(PortalID As Integer) As Boolean
        ConfigSystemCSS = False
        If IsNothing(flCache.GetCache("ConfigSystemCSS_" & PortalID)) Then
            Dim obj As CMS_ConfigSystemInfo = New CmsController().CMS_ConfigSystem_Get_PortalID(PortalID, PortalID)
            If IsNothing(obj) = False Then
                flCache.SetCache("ConfigSystemCSS_" & PortalID, obj.IsCMS)
                Return obj.IsCMS
            End If
        Else
            Return flCache.GetCache("ConfigSystemCSS_" & PortalID)
        End If
    End Function
    Public Shared Function ConfigSystemLive(PortalID As Integer) As Boolean
        ConfigSystemLive = False
        If IsNothing(flCache.GetCache("ConfigSystemLive_" & PortalID)) Then
            Dim obj As CMS_ConfigSystemInfo = New CmsController().CMS_ConfigSystem_Get_PortalID(PortalID, PortalID)
            If IsNothing(obj) = False Then
                If obj.EndDate < Now Then
                    flCache.SetCache("ConfigSystemLive_" & PortalID, False)
                    Return False
                Else
                    flCache.SetCache("ConfigSystemLive_" & PortalID, obj.IsLive)
                    If obj.IsLive = True And obj.EndDate > Now Then
                        flCache.SetCache("ConfigSystemLive_" & PortalID, obj.IsLive, (obj.EndDate - Now).TotalSeconds)
                    End If
                    Return obj.IsLive
                End If

            End If
        Else
            Return flCache.GetCache("ConfigSystemLive_" & PortalID)
        End If
    End Function
    Public Shared Function ConfigSystemIP(PortalID As Integer) As String
        ConfigSystemIP = flCache.GetCache("ConfigSystemIP_" & PortalID) & ""
        If ConfigSystemIP = "" Then
            Dim obj As CMS_ConfigSystemInfo = New CmsController().CMS_ConfigSystem_Get_PortalID(PortalID, PortalID)
            If IsNothing(obj) = False Then
                flCache.SetCache("ConfigSystemIP_" & PortalID, obj.IpPublic.Replace(vbLf, ""))
                Return obj.IpPublic.Replace(vbLf, "")
            End If
        Else
            Return flCache.GetCache("ConfigSystemIP_" & PortalID)
        End If
    End Function
#End Region
#Region "Get Name"
    Public Shared Function SetupValue(PortalID As Integer, strName As String) As String
        SetupValue = flCache.GetCache("SetupValue" & PortalID & strName) & ""
        If SetupValue = "" Then
            Dim obj As CMS_SetupsInfo = New CmsController().CMS_Setups_Get_By_Name(PortalID, strName)
            If IsNothing(obj) = False Then
                SetupValue = obj.SettingValue
                flCache.SetCache("SetupValue" & PortalID & strName, SetupValue)
            End If
        End If
    End Function
    Public Shared Function PortalName(PortalID As Integer) As String
        PortalName = flCache.GetCache("PortalName" & PortalID) & ""
        If PortalName = "" Then
            Dim obj As DnnInfo = flDnn.DNN_Portal_Get_By_ID(PortalID)
            If IsNothing(obj) = False Then
                PortalName = obj.PortalName
                flCache.SetCache("PortalName" & PortalID, PortalName)
            End If
        End If
    End Function
    Public Shared Function WebLink(linkType As Integer) As String
        Select Case linkType
            Case WebLinkType.NoiBo
                Return "Nội bộ"

            Case WebLinkType.Website
                Return "Website"

            Case Else 'WebLinkType.Khac
                Return "Khác"
        End Select
    End Function
    Public Shared Function PhongBanName(UserId As String, PortalId As Integer) As String
        PhongBanName = flCache.GetCache("PhongBanName" & UserId & PortalId) & ""
        If PhongBanName = "" Then
            arrTemp = New CmsController().CMS_Departments_NguoiDung_Get_By_UserId(PortalId, UserId, PortalId)
            For Each Cr As CMS_Departments_NguoiDungInfo In arrTemp
                PhongBanName = PhongBanName & TenPhongBan(PortalId, Cr.PhongBan) & "<br/>"
            Next
            If PhongBanName <> "" Then PhongBanName = PhongBanName.Substring(0, PhongBanName.LastIndexOf("<br/>"))
            flCache.SetCache("PhongBanName" & UserId & PortalId, PhongBanName)
        End If
    End Function
    Public Shared Function PhongBanID(UserId As String, PortalId As Integer) As String
        PhongBanID = flCache.GetCache("PhongBan_ID_" & UserId & PortalId) & ""
        If PhongBanID = "" Then
            arrTemp = New CmsController().CMS_Departments_NguoiDung_Get_By_UserId(PortalId, UserId, PortalId)
            For Each Cr As CMS_Departments_NguoiDungInfo In arrTemp
                PhongBanID += Cr.PhongBan & ","
            Next
            If PhongBanID <> "" Then PhongBanID = PhongBanID.Substring(0, PhongBanID.LastIndexOf(","))
            flCache.SetCache("PhongBan_ID_" & UserId & PortalId, PhongBanID)
        End If
    End Function

    Public Shared Function AuthosName(PortalConnect As String, WriterName As String) As String
        AuthosName = flCache.GetCache("AuthosName_" & PortalConnect & WriterName) & ""
        If AuthosName = "" And WriterName <> "" Then
            str = WriterName.Split(",")
            Dim Info As New CMS_AuthorsInfo
            For i As Integer = 0 To str.Length - 1
                Info = New CmsController().CMS_Authors_Get(PortalConnect, str(i))
                If IsNothing(Info) = False Then
                    AuthosName += Info.FullName & " (" & Info.Address & "); "
                End If
            Next
            flCache.SetCache("AuthosName_" & PortalConnect & WriterName, AuthosName)
        End If
    End Function
    Public Shared Function CategoryParentName(PortalId As Integer, cateID As Integer) As String
        CategoryParentName = flCache.GetCache("CategoryParentName" & PortalId & cateID) & ""
        If CategoryParentName = "" Then
            Dim objInfo As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get(PortalId, cateID)
            If IsNothing(objInfo) = False Then
                CategoryParentName = Category_Name(PortalId, objInfo.ParentId)
                flCache.SetCache("CategoryParentName" & PortalId & cateID, CategoryParentName)
                Return CategoryParentName
            End If
        End If
    End Function
    Public Shared Function CategoryName(PortalId As Integer, tabID As Integer) As String
        CategoryName = flCache.GetCache("CategoryName" & PortalId & tabID) & ""
        If CategoryName = "" Then
            Dim objInfo As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get_By_TabID(PortalId, tabID, PortalId)
            If IsNothing(objInfo) = False Then
                flCache.SetCache("CategoryName" & PortalId & tabID, objInfo.CategoryName)
                Return objInfo.CategoryName
            End If
        End If
    End Function
    Public Shared Function Category_Name(PortalId As Integer, cateID As Integer) As String
        Category_Name = flCache.GetCache("Category_Name" & PortalId & cateID) & ""
        If Category_Name = "" Then
            Dim objInfo As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get(PortalId, cateID)
            If IsNothing(objInfo) = False Then
                flCache.SetCache("Category_Name" & PortalId & cateID, objInfo.CategoryName)
                Return objInfo.CategoryName
            End If
        End If
    End Function
    Public Shared Function Category_Path(PortalId As Integer, cateID As Integer) As String
        Category_Path = flCache.GetCache("Category_Path" & PortalId & cateID) & ""
        If Category_Path = "" Then
            Dim objInfo As CMS_NewsCategoriesInfo = New CmsController().CMS_NewsCategories_Get(PortalId, cateID)
            If IsNothing(objInfo) = False Then
                flCache.SetCache("Category_Path" & PortalId & cateID, objInfo.TabPath.Replace("//", "/"))
                Return objInfo.TabPath.Replace("//", "/")
            End If
        End If
    End Function
    Public Shared Function FAQ_StatusName(statusID As Integer)
        Select Case statusID
            Case QuestionStatus.DaGui
                FAQ_StatusName = "Đã gửi"
            Case QuestionStatus.ChoXuLy
                FAQ_StatusName = "Chờ xử lý"
            Case QuestionStatus.ChoDuyet
                FAQ_StatusName = "Chờ duyệt"
            Case QuestionStatus.DaDuyet
                FAQ_StatusName = "Đã duyệt"
            Case QuestionStatus.TraLai
                FAQ_StatusName = "Không duyệt"
            Case QuestionStatus.HuyBo
                FAQ_StatusName = "Hủy xuất bản"
            Case Else
                FAQ_StatusName = "Đang soạn"
        End Select
    End Function
#End Region
#Region "Code send"
    Public Shared Function setCode(id As String) As String
        Return flReg.Encrypt(Now.Day, "v@" & Now.DayOfWeek & "b" & Now.Year & "n" & Now.Month & "#" & id)
    End Function
    Public Shared Function getCode(code As String) As Boolean
        strLit = flReg.Decrypt(Now.Day, code)
        If strLit = "v@" & Now.DayOfWeek & "b" & Now.Year & "n" & Now.Month & strLit.Substring(strLit.LastIndexOf("#")) Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

End Class

