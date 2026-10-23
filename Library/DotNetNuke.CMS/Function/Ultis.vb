Imports DotNetNuke.Security.Roles
Imports DotNetNuke.Common.Globals
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.Entities.Users
Imports System.Text
Imports System.Web

Public Class Ultis
    Shared ObjController As New CmsController
    Shared uInfo As New UserInfo
    Shared arrStr() As String
    Public Shared Function GetSafeRawUrl(url As String) As String
        If String.IsNullOrEmpty(url) Then Return String.Empty
        Dim tProcessedRaw As String = url
        tProcessedRaw = tProcessedRaw.Replace("""", String.Empty)
        tProcessedRaw = tProcessedRaw.Replace("<", "%3C")
        tProcessedRaw = tProcessedRaw.Replace(">", "%3E")
        tProcessedRaw = tProcessedRaw.Replace("&", "%26")
        Return tProcessedRaw.Replace("'", String.Empty)
    End Function
    Public Shared Function getDate(dates As String, bFrom As Boolean) As DateTime
        If bFrom = True Then
            If dates = "" Then dates = "01/01/2000"
            arrStr = dates.Split("/")
            Return New Date(arrStr(2), arrStr(1), arrStr(0), 0, 0, 0)
        Else
            If dates = "" Then dates = Now.AddDays(15).ToString("dd/MM/yyyy")
            arrStr = dates.Split("/")
            Return New Date(arrStr(2), arrStr(1), arrStr(0), 23, 59, 59)
        End If
    End Function
    Public Shared Function ValDate(dates As String, f As Boolean) As DateTime
        If f = True Then
            If dates <> "" Then
                arrStr = dates.Split("-")
                Return New DateTime(arrStr(2), arrStr(1), arrStr(0), 0, 0, 0)
            Else
                Return New DateTime(Now.AddDays(-30).Year, Now.AddDays(-30).Month, Now.AddDays(-30).Day, 0, 0, 0)
            End If
        Else
            If dates <> "" Then
                arrStr = dates.Split("-")
                Return New DateTime(arrStr(2), arrStr(1), arrStr(0), 23, 59, 59)
            Else
                Return New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 59)
            End If
        End If
    End Function
    Public Shared Function AllPortal() As ArrayList
        If IsNothing(flCache.GetCache("AllPortal:DNN_Portal_List_Lang")) = True Then
            AllPortal = flDnn.DNN_Portal_List_Lang(flDic.GetLanguage)
            flCache.SetCache("AllPortal:DNN_Portal_List_Lang", AllPortal)
        Else
            AllPortal = CType(flCache.GetCache("AllPortal:DNN_Portal_List_Lang"), ArrayList)
        End If
    End Function
    Public Shared Function UserPortal(Username As String) As ArrayList
        If IsNothing(flCache.GetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username)) = True Then
            UserPortal = flDnn.DNN_Portal_Get_By_UserID(Username)
            flCache.SetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username, UserPortal)
        Else
            UserPortal = CType(flCache.GetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username), ArrayList)
        End If
    End Function
    Public Shared Function Version() As String
        Return "3.1"
    End Function
    Public Shared Function FormatViewDate(Dates As DateTime) As String
        Return Dates.ToString("dd/MM/yyyy HH:mm")
    End Function
    Public Shared Function FullTextSearch(keywords As String, Optional ByVal toUrl As Boolean = True) As String
        If toUrl = True Then
            FullTextSearch = flReg.NameUrl(keywords).Replace("-", " ")
            FullTextSearch = endCodeSearch(FullTextSearch)
            FullTextSearch = FullTextSearch.Replace("*", "")
        Else
            FullTextSearch = endCodeSearch(keywords)
            FullTextSearch = FullTextSearch.Replace("*", "")
        End If
    End Function
    Public Shared Function endCodeSearch(keywords As String) As String
        If keywords <> "" Then
            keywords = keywords.Replace("'", "''")
            keywords = keywords.Replace("""", """""")
            Dim sbKeyWordsFilter As New StringBuilder()
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
    Public Shared Function FontError(value As String) As String
        Dim arr1 As String() = New String() {"ô%3ḅ", "ê%3ḅ", "â%3ḅ", "Ô%3ḅ", "Ê%3ḅ", "Â%3ḅ"}
        Dim arr2 As String() = New String() {"ộ", "ệ", "ậ", "Ộ", "Ệ", "Ậ"}
        For i As Integer = 0 To arr1.Length - 1
            value = value.Replace(arr1(i), arr2(i))
        Next
        Return value
    End Function
    Public Shared Function GetCategoryName(PortalId As Integer, categoryId As Integer) As String
        GetCategoryName = flCache.GetCache("GetCategoryName_" & PortalId & "_" & categoryId) & ""
        If GetCategoryName = "" Then
            Dim obj As CMS_NewsCategoriesInfo = ObjController.CMS_NewsCategories_Get(PortalId, categoryId)
            If Not obj Is Nothing Then
                flCache.SetCache("GetCategoryName_" & PortalId & "_" & categoryId, obj.CategoryName)
                Return obj.CategoryName
            End If
            Return "--"
        End If
    End Function
#Region "Images"
    Public Shared Function ThoiTietImg(Type As String) As String
        If Type = 1 Then
            Return "<img Class=""photo-imgs"" src=""/images/thoitiet/w-itmay.png?w"" alt=""w-itmay"" />"
        ElseIf Type = 2 Then
            Return "<img Class=""photo-imgs"" src=""/images/thoitiet/w-khongmua.png?w"" alt=""w-khongmua"" />"
        Else
            Return "<img Class=""photo-imgs"" src=""/images/thoitiet/w-comua.png?w"" alt=""w-comua"" />"
        End If
        Return ""
    End Function
    Public Shared Function IsVideo(Type As String) As String
        If Type = 2 Then
            Return "<img Class=""photo-imgs"" src=""/image/images/nvideo.png?w"" alt=""iconvideo"" />"
        End If
        Return ""
    End Function
    Public Shared Function ImgPhoto(IsImage As Boolean) As String
        If IsImage = True Then
            Return "<img Class=""photo-imgs"" src=""/image/images/photo1.png?w"" alt=""photo"" />"
        End If
        Return ""
    End Function
    Public Shared Function ImagePath(_ImagePath As String) As String
        If _ImagePath & "" <> "" Then
            Return "<img Class=""photo-imgs"" src=""/image/images/nphoto.png?w"" alt=""photo"" />"
        End If
        Return ""
    End Function
    Public Shared Function GetFromPortal(PortalID As String, FromPortal As String) As String
        If PortalID <> FromPortal Then
            Return "<img class=""photo-imgs""  title='Tin bài chuyển từ đơn vị khác đến' src=""/image/stock.png?w"" alt=""photo"" />"
        End If
        Return ""
    End Function
#End Region
#Region "Custom Handlers"
    Private Shared Function SplitValue(val As String, top As Integer) As String
        arrStr = val.Split(", ")
        SplitValue = ""
        For i As Integer = 0 To arrStr.Length - 1
            If i = top Then Exit For
            SplitValue += arrStr(i) & ", "
        Next
    End Function
    Public Shared Function ViewImageByType(IsHotCat As String, IsCare As String) As String
        ViewImageByType = "<span class='view-img-cms'>"
        If IsCare & "" = "True" Then ViewImageByType += "<img src='/image/icon/hot.png' title='Tin nóng trang chủ' alt='Tin nóng trang chủ'/>"
        If IsHotCat & "" = "True" Then ViewImageByType += "<img src='/image/icon/cat.gif' title='Tin nóng chuyên mục' alt='Tin nóng chuyên mục'/>"
        ViewImageByType += "</span>"
    End Function
    Public Shared Function BackWF(PortalId As Integer, NewID As String) As String
        Dim dicInfo As New CMS_News_UserProcessInfo
        dicInfo = ObjController.CMS_BackWF_News(PortalId, flReg.WriteNumber(NewID))
        If IsNothing(dicInfo) = False Then Return dicInfo.UserID
        Return 0
    End Function
#End Region
#Region "General BL"
    Public Shared Function GetRequestId(surl As String) As Integer
        surl = surl.Replace(".html", "").Substring(surl.LastIndexOf("-") + 1)
        If surl.Contains("?") Then surl = surl.Substring(0, surl.LastIndexOf("?"))
        Return flReg.WriteNumber(surl)
    End Function
    Private Shared Function TabPath(PortalConnect As Integer, CategoryID As Integer) As String
        TabPath = flCache.GetCache("tabPath_" & PortalConnect & "_" & CategoryID) & ""
        If TabPath = "" Or TabPath = "/" Then
            Dim Obj As CMS_NewsCategoriesInfo = ObjController.CMS_NewsCategories_Get_TabPath(PortalConnect, CategoryID)
            If IsNothing(Obj) = False Then TabPath = flReg.WebConfig("member") & Obj.TabPath.Replace("//", "/") & "/"
            flCache.SetCache("tabPath_" & PortalConnect & "_" & CategoryID, TabPath)
        End If
    End Function
    Public Shared Function FormatLink(PortalConnect As Integer, CategoryId As Integer, Id As Integer, toUrl As String) As String
        Return TabPath(PortalConnect, CategoryId) & toUrl & "-" & Id & ".html"
    End Function
    Public Shared Function FormatLink(PortalConnect As Integer, CategoryId As Integer, Id As Integer) As String
        Return TabPath(PortalConnect, CategoryId) & "nid-" & Id & ".html"
    End Function

    Private Shared Function PublicPath(PortalConnect As Integer, CategoryID As Integer, Domain As String) As String
        PublicPath = flCache.GetCache("PublicPath_" & PortalConnect & "_" & CategoryID) & ""
        If PublicPath = "" Or PublicPath = "/" Then
            Dim Obj As CMS_NewsCategoriesInfo = ObjController.CMS_NewsCategories_Get_TabPath(PortalConnect, CategoryID)
            If IsNothing(Obj) = False Then PublicPath = Domain & Obj.TabPath.Replace("//", "/") & "/"
            flCache.SetCache("PublicPath_" & PortalConnect & "_" & CategoryID, PublicPath)
        End If
    End Function
    Public Shared Function PublicLink(PortalConnect As Integer, CategoryId As Integer, Id As Integer, toUrl As String, Optional ByVal WebDomain As String = "") As String
        If WebDomain = "" Then WebDomain = flConnect.WebDomain(PortalConnect)
        Return PublicPath(PortalConnect, CategoryId, WebDomain) & toUrl & "-" & Id
    End Function
    Public Shared Function PublicLink(PortalConnect As Integer, CategoryId As Integer, Id As Integer, Optional ByVal WebDomain As String = "") As String
        If WebDomain = "" Then WebDomain = flConnect.WebDomain(PortalConnect)
        Return PublicPath(PortalConnect, CategoryId, WebDomain) & "nid-" & Id
    End Function

    Public Shared Function GetTarget(typeurl As String) As String
        If Not String.IsNullOrEmpty(typeurl) Then
            Return "_blank"
        Else
            Return ""
        End If
    End Function
    Public Shared Sub NewsHardDelete(PortalId As Integer, server As HttpServerUtility, newsid As Integer)
        For Each obj As CMS_NewsByMediaInfo In ObjController.CMS_NewsByMedia_GetByNewsId(PortalId, newsid)
            ObjController.CMS_NewsByMedia_Delete(PortalId, obj.MediaId)
        Next
        ObjController.CMS_NewsByMedia_DeleteByNewsId(PortalId, newsid)
    End Sub
    Public Shared Function GetPhongBan(portalid As Integer) As ArrayList
        Dim arrAll As ArrayList = ObjController.CMS_Departments_GetByParentId(portalid, portalid, 0)
        Dim arrTempParent As New ArrayList
        Dim arrResult As New ArrayList
        For Each obj As CMS_DepartmentsInfo In arrAll
            If obj.ParentId = 0 AndAlso obj.IsActive = True Then
                arrTempParent.Add(obj)
            End If
        Next
        For Each objPB As CMS_DepartmentsInfo In arrTempParent
            GetPhongBanList(ObjController.CMS_Departments_List(portalid), objPB.Id, arrResult, "")
        Next

        Return arrResult
    End Function
    Public Shared Sub GetPhongBanList(arrPhongBan As ArrayList, ParentPhongBanId As Integer, ByRef arrReturn As ArrayList, Prefix As String)
        For Each objPhongBan As CMS_DepartmentsInfo In arrPhongBan
            If objPhongBan.ParentId = ParentPhongBanId Then
                objPhongBan.TenPhongBan = Prefix & objPhongBan.TenPhongBan
                arrReturn.Add(objPhongBan)
            End If
        Next
    End Sub
    Public Shared Function GenerateQueryStringParameters(request As HttpRequest, queryStringKeys As String()) As String
        Dim queryString As New StringBuilder(64)
        For Each key As String In queryStringKeys
            If Not String.IsNullOrEmpty(request.QueryString(key)) Then
                If queryString.Length > 0 Then
                    queryString.Append("&")
                End If

                queryString.Append(key).Append("=").Append(request.QueryString(key))
            End If
        Next

        Return queryString.ToString()
    End Function
#End Region
#Region "Lock - Unlock - Visible News"
    Public Shared Sub UnlockNews(portalid As Integer, newsid As Integer, userid As String)
        Try
            Dim ObjController As New CmsController
            ObjController.CMS_News_Update_Lock(portalid, newsid, False, userid)
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub LockNews(portalid As Integer, newsid As Integer, userid As String)
        Try
            Dim ObjController As New CmsController
            ObjController.CMS_News_Update_Lock(portalid, newsid, True, userid)
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Function NewPublic(IsEdited As String) As Boolean
        If CType(IsEdited, Boolean) = True Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function FormatLock(portalid As Integer, newsid As Integer) As Boolean
        If CheckNewsLock(portalid, newsid) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function LockByUser(IsEdited As String, UserID As String, username As String) As Boolean
        If CType(IsEdited, Boolean) AndAlso UserID = username Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function FormatLockByUser(portalid As Integer, IsEdited As Boolean, username As String, EditedUser As String, EditedTime As DateTime, newid As Integer) As Boolean
        uInfo = New UserController().GetUser(0, GetPortalSettings.UserId)
        If (uInfo.IsInRole("Xuat Ban") = True Or uInfo.IsInRole("Manager") = True) And IsEdited = True Then FormatLockByUser = True
        If IsEdited And EditedUser = username Then FormatLockByUser = True
        If FormatLockByUser = True And (Now.Subtract(EditedTime).Minutes > 15 Or Now.Subtract(EditedTime).Days > 1) Then
            Call UnlockNews(portalid, newid, username)
            Return False
        Else
            Return FormatLockByUser
        End If
    End Function
    Public Shared Function CheckNewsLock(portalid As Integer, newsid As Integer) As Boolean
        Dim arr As ArrayList = New CmsController().CMS_News_GetLocks(portalid, portalid, flConnect.IsLang, newsid)
        If arr.Count > 0 Then Return True
        Return False
    End Function
    Public Shared Function FormatVisibleByStatus(portalid As Integer, canaction As Boolean, newsid As Integer) As Boolean
        If CheckNewsLock(portalid, newsid) = True Then Return False
        If canaction = False Then Return True
        Return False
    End Function
    Public Shared Function FormatVisibleByStatus(IsEdited As Boolean, Status As Integer) As Boolean
        If IsEdited = False And (Status = 0 Or Status = 3) Then Return True
        Return False
    End Function
    Public Shared Function FormatTrieuHoi(portalid As Integer, newsid As Integer, status As Integer, userid As String, approvalUser As String) As Boolean
        If CheckNewsLock(portalid, newsid) Then Return False
        If (status = NewsStatus.ChoPheDuyet OrElse (status = NewsStatus.ChoXuatBan AndAlso (userid = approvalUser OrElse (Not approvalUser <> "")))) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function FormatTrieuHoiByIsRead(isRead As Integer, StatusName As String) As Boolean
        If StatusName.Trim = "Chờ duyệt" Then
            If isRead = 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

#End Region
#Region "Format: Color, Text, Icon,.."
    Public Shared Function FormatEdittedBy(portalid As Integer, EditedUser As String, EditedTime As String, IsEdited As Boolean, newid As Integer) As String
        If EditedTime & "" <> "" And IsEdited = True Then
            If Now.Subtract(EditedTime).Minutes > 15 Or Now.Subtract(EditedTime).Days > 1 Then
                Call UnlockNews(portalid, newid, EditedUser)
                Return ""
            Else
                FormatEdittedBy = "Bài viết đang được chỉnh sửa bởi: " & flReg.GetUserName(EditedUser) & ", khoảng "
                FormatEdittedBy &= IIf(Now.Subtract(EditedTime).Minutes = 0, "< 1", Now.Subtract(EditedTime).Minutes) & " phút trước"
            End If
        Else
            Return ""
        End If
    End Function
    Public Shared Function FormatTooltip(portalid As Integer, userId As Integer, categoryname As String) As String
        Return String.Format("Người tạo: {0} | Chuyên mục chính {1}", flReg.GetUserName(userId), categoryname)
    End Function
    Public Shared Function FormatTooltipClueTip(portalid As Integer, title As String, publishedDate As DateTime, userId As Integer, categoryname As String) As String
        Return String.Format("{0}|<font style='color:maroon;'>Ngày xuất bản: {1}</font>|<font style='color:maroon;padding-bottom:5px;'>Creator: {2}</font>|<font style='color:maroon;padding-bottom:5px;'>Chuyên mục chính {3}</font>", title, flReg.ReadDate(publishedDate), flReg.GetUserName(userId), categoryname)
    End Function

#End Region
#Region "WorkFlow"
    Public Shared Function LoadWorkFlow(portalid As Integer, userin As UserInfo) As ArrayList
        Dim arrResult As New ArrayList
        Dim depart As Integer = flCheck.GetPhongBanIdByUserId(portalid, userin.Username)
        Dim objPBND As CMS_Departments_NguoiDungInfo = New CmsController().CMS_Departments_NguoiDung_GetByUserIdAnDepartmentId(portalid, userin.Username, depart, portalid)
        Try
            If Not objPBND Is Nothing And objPBND.LaLanhDao Then
                Dim iRoleBienTapId As Integer = (New RoleController).GetRoleByName(portalid, "Bien Tap").RoleID
                For Each r As String In userin.Roles()
                    Dim rId As Integer = (New RoleController).GetRoleByName(portalid, r).RoleID
                    If rId > 0 AndAlso rId <> iRoleBienTapId Then
                        arrResult.AddRange(New CmsController().CMS_News_UserWF_GetByPhongBanId(portalid, rId, depart))
                    End If
                Next
            Else
                For Each r As String In userin.Roles()
                    Dim rId As Integer = (New RoleController).GetRoleByName(portalid, r).RoleID
                    If rId > 0 Then
                        arrResult.AddRange(New CmsController().CMS_News_UserWF_GetByPhongBanId(portalid, rId, depart))
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
        Return arrResult
    End Function
    Public Shared Function Save2Version(portalid As Integer, obj As CMS_NewsInfo, userid As String) As Integer
        Try
            Dim vInfo As New CMS_News_VersionInfo
            vInfo.CreatedUser = userid
            vInfo.NewId = obj.NewId
            vInfo.CategoryId = obj.CategoryId
            vInfo.Introduction = obj.Introduction
            vInfo.Title = obj.Title
            vInfo.ImagePath = obj.ImagePath
            vInfo.Summary = obj.Summary
            vInfo.[Content] = obj.[Content]
            vInfo.isActive = obj.isActive
            vInfo.Hotcat = obj.Hotcat
            vInfo.IsCare = obj.IsCare
            vInfo.isRead = obj.isRead
            vInfo.Status = obj.Status
            vInfo.Unit = obj.Unit
            vInfo.NewsKind = obj.NewsKind
            vInfo.Type = obj.Type
            vInfo.TypeUrl = obj.TypeUrl
            vInfo.Links = obj.Links
            vInfo.Tags = obj.Tags
            vInfo.IsImage = obj.IsImage
            vInfo.Note = obj.Note
            vInfo.SourceInfo = obj.SourceInfo
            vInfo.IsEdited = obj.IsEdited
            vInfo.EditedUser = obj.EditedUser
            vInfo.EditedTime = obj.EditedTime
            vInfo.VoteCount = obj.VoteCount
            vInfo.ViewCount = obj.ViewCount
            vInfo.IsArchived = obj.IsArchived
            vInfo.ArchivedDate = obj.ArchivedDate
            vInfo.Credit = obj.Credit
            vInfo.Createdate = obj.Createdate
            vInfo.ApprovalRequestDate = obj.ApprovalRequestDate
            vInfo.ApprovalDate = obj.ApprovalDate
            vInfo.ApprovalUser = obj.ApprovalUser
            vInfo.ReturnedDate = obj.ReturnedDate
            vInfo.ReturnedUser = obj.ReturnedUser
            vInfo.CancelPublishDate = obj.CancelPublishDate
            vInfo.CancelPublishUser = obj.CancelPublishUser
            vInfo.PublishedDate = obj.PublishedDate
            vInfo.PublishedUser = obj.PublishedUser
            vInfo.UserId = obj.UserId
            vInfo.WriterName = obj.WriterName
            vInfo.WriterFullName = obj.WriterFullName
            vInfo.NumberNews = obj.NumberNews
            vInfo.NotePrices = obj.NotePrices
            vInfo.LanguageId = obj.LanguageId
            vInfo.PortalId = obj.PortalId
            vInfo.ToUrl = obj.ToUrl
            vInfo.GetFromPortal = obj.GetFromPortal
            vInfo.GetFromNewId = obj.GetFromNewId
            vInfo.SendName = obj.SendName
            vInfo.SendView = obj.SendView
            Return ObjController.CMS_News_Version_Add(portalid, vInfo)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Shared Function FormatVisibleByStatus(status As Integer) As Boolean
        If (status = NewsStatus.DangBienSoan) OrElse (status = NewsStatus.ChoPheDuyet) OrElse (status = NewsStatus.BiTraLai) OrElse (status = NewsStatus.HuyXuatBan) Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

End Class

