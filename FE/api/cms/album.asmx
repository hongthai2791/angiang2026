<%@ WebService Language="VB" Class="WebserviceGolbal.WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace WebserviceGolbal
    <WebService(Namespace:="http://tempuri.org/")> _
    <WebServiceBinding(ConformsTo:=WsiProfiles.None)> _
    <ScriptService()> _
    Public Class WebService
        Inherits System.Web.Services.WebService
        Dim ObjController As New CmsController
        Dim News_ID, drPortalId As Integer
        Dim Str() As String
        Dim httpFile As String = flConnect.fileDomain

        Private objProcessInfo As New CMS_News_ProcessInfo
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function workflow(pco As Integer, ByVal id As String, ByVal WFID As String, username As String, ProcessName As String, PublishedDate As String) As String
            Dim objWF As New CMS_News_UserWFInfo
            objWF = ObjController.CMS_News_UserWF_Get(pco, WFID)
            objProcessInfo = New CMS_News_ProcessInfo
            With objProcessInfo
                .ItemId = id
                .CreateDate = Now
                .ByUser = username
                .StatusID = objWF.TrangThaiDich
                .ProcessName = "--> " & ProcessName
                .IPTrack = ""
                .Type = 1
                .VersionId = WFID
            End With
            ObjController.CMS_News_Process_Add(pco, objProcessInfo)

            Dim objUserNews As New CMS_News_UserProcessInfo
            ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(pco, id, username)
            objUserNews.UserID = objWF.ID
            objUserNews.NewsID = id
            objUserNews.CreatedUser = username
            objUserNews.CreatedDate = Now
            objUserNews.Status = objWF.TrangThaiDich

            PublishedDate = flReg.DeCode64(PublishedDate)

            If objWF.TrangThaiDich = NewsStatus.DaXuatBan Then
                If flReg.WriteDate(PublishedDate).Year = 1900 Then
                    PublishedDate = Now
                Else
                    PublishedDate = flReg.WriteDate(PublishedDate)
                End If
                objUserNews.isActive = 1
            Else
                PublishedDate = Now
                objUserNews.isActive = 0
            End If

            ObjController.CMS_News_Update_Status(pco, id, objWF.TrangThaiDich, username, PublishedDate)

            objUserNews.PositionID = objWF.PositionID
            ObjController.CMS_News_UserProcess_Add(pco, objUserNews)
            Ultis.UnlockNews(pco, id, username)
            Return ""
        End Function
        Public Function ToBoolean(values As String) As Boolean
            Try
                Return CType(values, Boolean)
            Catch ex As Exception
                Return False
            End Try
        End Function
        Private Function GetNull(item As String) As String
            GetNull = item.Trim()
            If GetNull = "null" Or GetNull = "undefined" Then Return ""
        End Function

        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function savenews() As String
            Try
                Dim obj As New CMS_NewsInfo
                News_ID = flReg.WriteNumber(GetNull(HttpContext.Current.Request("id")))
                drPortalId = flReg.WriteNumber(GetNull(HttpContext.Current.Request("pid")))
                With obj
                    .PortalId = drPortalId
                    .NewId = News_ID
                    .CategoryId = flReg.WriteNumber(GetNull(HttpContext.Current.Request("cateid")))
                    .Hotcat = ToBoolean(GetNull(HttpContext.Current.Request("Hotcat")))
                    .IsCare = ToBoolean(GetNull(HttpContext.Current.Request("IsCare")))
                    .Note = GetNull(HttpContext.Current.Request("Notes")) & ""
                    .LanguageId = flConnect.IsLang
                    .SendName = GetNull(HttpContext.Current.Request("NguonTin"))
                    .UserId = GetNull(HttpContext.Current.Request("username"))
                    .WriterName = .UserId
                    .WriterFullName = .UserId
                    .PublishedUser = .UserId
                    .IsImage = True

                    .PublishedDate = flReg.WriteDate(GetNull(HttpContext.Current.Request("PublishedDate")))
                    If flReg.ReadDate(.PublishedDate) = "" Then .PublishedDate = Now
                    .Title = GetNull(HttpContext.Current.Request("Title"))
                    .Summary = GetNull(HttpContext.Current.Request("Summary"))
                    .Content = .Summary
                    .ImagePath = GetNull(HttpContext.Current.Request("ImagePath"))
                    .Links = GetNull(HttpContext.Current.Request("Links"))
                    .isActive = True
                    .Type = 2 ' Tin anh
                    .TypeUrl = "/images/icons/icon_image.png"
                    .ToUrl = flReg.NameUrl(GetNull(HttpContext.Current.Request("Title")))
                    .ArchivedDate = flReg.DateNull
                    .Createdate = flReg.DateNull
                    .ApprovalRequestDate = flReg.DateNull
                    .ApprovalDate = flReg.DateNull
                    .ApprovalUser = ""
                    .ReturnedDate = flReg.DateNull
                    .ReturnedUser = ""
                    .CancelPublishDate = flReg.DateNull
                    .CancelPublishUser = ""
                    .PublishedDate = flReg.DateNull
                    .PublishedUser = ""
                    Dim sTags As String = ""

                    If obj.NewId <> 0 Then
                        If GetNull(HttpContext.Current.Request("Tags")) <> "" Then
                            Str = GetNull(HttpContext.Current.Request("Tags")).ToString().Split(",")
                            For i As Integer = 0 To Str.Length - 1
                                If Str(i).Trim() & "" <> "" Then
                                    If IsNumeric(Str(i)) Then
                                        sTags &= Str(i) & ","
                                    Else
                                        sTags &= ObjController.CMS_NewsByTags_Add(drPortalId, News_ID, Str(i)) & ","
                                    End If
                                End If
                            Next
                        End If
                        .Tags = sTags

                        ObjController.CMS_News_Update(drPortalId, obj)
                    Else
                        .Createdate = Now
                        News_ID = ObjController.CMS_News_Add(drPortalId, obj)
                        If GetNull(HttpContext.Current.Request("Tags")) <> "" Then
                            Str = GetNull(HttpContext.Current.Request("Tags")).ToString().Split(",")
                            For i As Integer = 0 To Str.Length - 1
                                If Str(i).Trim() & "" <> "" Then
                                    If IsNumeric(Str(i)) Then
                                        sTags &= Str(i) & ","
                                    Else
                                        sTags &= ObjController.CMS_NewsByTags_Add(drPortalId, News_ID, Str(i)) & ","
                                    End If
                                End If
                            Next
                        End If
                        ObjController.CMS_News_Update_Tags(drPortalId, News_ID, sTags)

                        With objProcessInfo
                            .ItemID = News_ID
                            .CreateDate = Now
                            .ByUser = GetNull(HttpContext.Current.Request("username"))
                            .StatusID = NewsStatus.DangBienSoan 'Khởi tạo
                            .ProcessName = "--> Đăng tin phóng sự ảnh"
                            .IPTrack = ""
                            .Type = 1
                        End With
                        ObjController.CMS_News_Process_Add(drPortalId, objProcessInfo)
                    End If
                    'Lưu vào bảng chuyên mục trung gian
                    ObjController.CMS_NewsByCategory_Delete_By_NewsID(flReg.WriteNumber(GetNull(HttpContext.Current.Request("pid"))), News_ID)
                    ObjController.CMS_NewsByCategory_Add(drPortalId, News_ID, obj.CategoryId, True, NewsStatus.ChoXuatBan, drPortalId, flConnect.IsLang, 0)
                    flCache.RemoveCache("NewsId_" & News_ID)
                    Return News_ID
                End With
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function savealbum() As String
            Try
                If GetNull(HttpContext.Current.Request("img")) <> "undefined" Then
                    Dim img As String = GetNull(HttpContext.Current.Request("img"))
                    img = img.Replace(httpFile, "")
                    If img.Contains("?") Then img = img.Substring(0, img.LastIndexOf("?"))

                    Dim objMedia As New CMS_MediaInfo
                    objMedia.PortalId = flReg.WriteNumber(GetNull(HttpContext.Current.Request("pco")))
                    objMedia.CreatedDate = Now
                    objMedia.CreatedUser = GetNull(HttpContext.Current.Request("username"))
                    objMedia.Name = GetNull(HttpContext.Current.Request("nameimg"))

                    objMedia.Contents = flReg.RemoveScript(GetNull(HttpContext.Current.Request("dec")))
                    objMedia.PublishedUser = GetPortalSettings.UserInfo.Username
                    objMedia.PublishedDate = Now
                    objMedia.MediaUrl = GetNull(HttpContext.Current.Request("url"))

                    'End If
                    objMedia.Status = NewsStatus.DaXuatBan
                    objMedia.LanguageId = flConnect.IsLang
                    objMedia.Type = mediaType.Image
                    objMedia.CategoryId = flReg.WriteNumber(GetNull(HttpContext.Current.Request("catid")))
                    objMedia.Stt = flReg.WriteNumber(GetNull(HttpContext.Current.Request("stt")))
                    objMedia.ToUrl = " "
                    objMedia.Summary = " "
                    objMedia.Avatar = " "
                    objMedia.Folders = " "
                    objMedia.ApprovalUser = " "

                    If flReg.WriteNumber(GetNull(HttpContext.Current.Request("id"))) = 0 Then
                        objMedia.Avatar = img
                        Dim iMediaId As Integer = ObjController.CMS_Media_Add(flReg.WriteNumber(GetNull(HttpContext.Current.Request("pco"))), objMedia)
                        If iMediaId > 0 Then
                            Dim objNewsByMediaInfo As New CMS_NewsByMediaInfo
                            With objNewsByMediaInfo
                                .NewsId = flReg.WriteNumber(GetNull(HttpContext.Current.Request("newid")))
                                .MediaId = iMediaId
                            End With
                            ObjController.CMS_NewsByMedia_Add(GetNull(HttpContext.Current.Request("pco")), objNewsByMediaInfo)
                        End If
                    Else
                        'update
                        objMedia.Id = GetNull(HttpContext.Current.Request("id"))
                        objMedia.Avatar = img
                        ObjController.CMS_Media_Update(GetNull(HttpContext.Current.Request("pco")), objMedia)
                    End If
                End If
                flCache.RemoveCache("NewsId_Media_" & flReg.WriteNumber(GetNull(HttpContext.Current.Request("newid"))))
                Return ""
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
    End Class
End Namespace
