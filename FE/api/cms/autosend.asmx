<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService

    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub

    Dim ObjController As New CmsController
    Dim objSend As New sv.web.WebService
    Dim objAuth As New sv.web.AuthHeader
    Dim arrTemp, arrTemp1, arrTemp2 As New ArrayList
    Dim objNews As New CMS_NewsInfo
    Dim objMedia As New CMS_MediaInfo
    Dim menuInfo As New CMS_MenuDInfo
    Dim advInfo As New CMS_AdvertiseInfo
    Dim foInfo As New CMS_InfomationInfo
    Dim webInfo As New CMS_WebLinkInfo
    Dim fbInfo As New CMS_NewsFeedbackInfo
    Dim cateInfo As New CMS_NewsCategoriesInfo
    Dim faqInfo As New CMS_FAQInfo
    Dim queInfo As New CMS_FAQQuestionsInfo
    Dim ansInfo As New CMS_FAQAnswersInfo
    Dim confInfo As New CMS_ConfigSystemInfo
    Dim setupfInfo As New CMS_SetupsInfo
    Dim tagInfo As New CMS_NewsByTagsInfo
    Dim SendView As Boolean


    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function UpdateValue() As String
        Call SetContentResponse()
        Dim httpService As String = flConnect.httpService
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim dataReturn As New PortalReturn
        Dim listReturn As New List(Of PortalReturn)
        Try
            objAuth.Username = flReg.WebConfig("SoapUser")
            objAuth.Password = flReg.WebConfig("SoapPass")

            For Each Cr As DnnInfo In Ultis.AllPortal()
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.TinTuc) 'Tin tức
                For Each Cj As CMS_NewsInfo In arrTemp1
                    objNews = ObjController.CMS_News_Get(Cr.PortalID, Cj.NewId)
                    Call SV_New_Add(objNews, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.NewId
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.TinTuc
                    listReturn.Add(dataReturn)
                Next

                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.Album) 'PSA
                For Each Cj As CMS_NewsInfo In arrTemp1
                    objNews = ObjController.CMS_News_Get(Cr.PortalID, Cj.NewId)
                    Call SV_New_Add_PSA(objNews, Cr.PortalID)

                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.NewId
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.Album
                    listReturn.Add(dataReturn)
                Next

                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.Media) 'Audio + Video
                For Each Cj As CMS_MediaInfo In arrTemp1
                    objMedia = ObjController.CMS_Media_Get(Cr.PortalID, Cj.Id)
                    Call SV_Media_Add(objMedia, Cr.PortalID)

                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.Id
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.Media
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.Menu)
                For Each Cj As CMS_MenuDInfo In arrTemp1
                    menuInfo = ObjController.CMS_MenuD_Get(Cr.PortalID, Cj.MenuD_ID)
                    Call SV_MenuD_Add(menuInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.MenuD_ID
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.Menu
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.Advertise)
                For Each Cj As CMS_AdvertiseInfo In arrTemp1
                    advInfo = ObjController.CMS_Advertise_Get(Cr.PortalID, Cj.Advertise_ID)
                    Call SV_Advertise_Add(advInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.Advertise_ID
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.Advertise
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.FAQ)
                For Each Cj As CMS_FAQInfo In arrTemp1
                    faqInfo = ObjController.CMS_FAQ_Get(Cr.PortalID, Cj.Id)
                    Call SV_CMS_FAQ_Add(faqInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.Id
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.FAQ
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.FAQQuestion)
                For Each Cj As CMS_FAQQuestionsInfo In arrTemp1
                    queInfo = ObjController.CMS_FAQQuestions_Get(Cr.PortalID, Cj.Id)
                    Call SV_CMS_FAQQuestions_Add(queInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.Id
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.FAQQuestion
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.FAQAnswers)
                For Each Cj As CMS_FAQAnswersInfo In arrTemp1
                    ansInfo = ObjController.CMS_FAQAnswers_Get(Cr.PortalID, Cj.Id)
                    Call SV_CMS_FAQAnswers_Add(ansInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.Id
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.FAQAnswers
                    listReturn.Add(dataReturn)
                Next

                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.ConfigSystem)
                For Each Cj As CMS_ConfigSystemInfo In arrTemp1
                    confInfo = ObjController.CMS_ConfigSystem_Get_PortalID(Cr.PortalID, Cj.PortalID)
                    Call SV_CMS_ConfigSystem_Add(confInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.ID
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.ConfigSystem
                    listReturn.Add(dataReturn)
                Next

                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.Setup)
                For Each Cj As CMS_SetupsInfo In arrTemp1
                    setupfInfo = ObjController.CMS_Setups_Get(Cr.PortalID, Cj.ID)
                    Call SV_CMS_Setups_Add(setupfInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.SettingName
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.Setup
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.Infomation)
                For Each Cj As CMS_InfomationInfo In arrTemp1
                    foInfo = ObjController.CMS_Infomation_Get(Cr.PortalID, Cj.Id)
                    Call SV_Infomation_Add(foInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.Id
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.Infomation
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.WebLink)
                For Each Cj As CMS_WebLinkInfo In arrTemp1
                    webInfo = ObjController.CMS_WebLink_Get(Cr.PortalID, Cj.Id)
                    Call SV_CMS_WebLink_Add(webInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.Id
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.WebLink
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.Feedback)
                For Each Cj As CMS_NewsFeedbackInfo In arrTemp1
                    fbInfo = ObjController.CMS_NewsFeedback_Get(Cr.PortalID, Cj.NewsFeedbackId)
                    Call SV_CMS_NewsFeedback_Add(fbInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.NewsFeedbackId
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.Feedback
                    listReturn.Add(dataReturn)
                Next
                arrTemp1 = ObjController.SV_CMS_ListError(Cr.PortalID, ServiceType.NewsCategories)
                For Each Cj As CMS_NewsCategoriesInfo In arrTemp1
                    cateInfo = ObjController.CMS_NewsCategories_Get(Cr.PortalID, Cj.CategoryID)
                    Call SV_NewsCategories_Add(cateInfo, Cr.PortalID)
                    dataReturn = New PortalReturn
                    dataReturn.http = flConnect.WebDomain(Cr.PortalID)
                    dataReturn.url = httpService
                    dataReturn.nID = Cj.CategoryID
                    dataReturn.pID = Cr.PortalID
                    dataReturn.tPe = ServiceType.NewsCategories
                    listReturn.Add(dataReturn)
                Next
            Next
            data.Data = listReturn
        Catch ex As Exception
            LogException(ex)
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Private Sub SV_MenuD_Add(obj As CMS_MenuDInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_MenuD_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.MenuD_ID,
                                                           flReg.EnCode64(obj.MenuD_Name), obj.Menu_ID, obj.Parent_ID, flReg.EnCode64(obj.Url),
                                                           obj.BackColor, obj.IsOrder, obj.PortalId, obj.CreatedDate, obj.CreatedUser, obj.UpdateDate, obj.UpdateUser)
            ObjController.SV_Update_CMS_MenuD_SendView(PortalID, obj.MenuD_ID, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_MenuD_SendView(PortalID, obj.MenuD_ID, False)
        End Try
    End Sub
    Private Sub SV_Advertise_Add(obj As CMS_AdvertiseInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_Advertise_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.Advertise_ID,
                                                            flReg.EnCode64(obj.Advertise_Name), obj.ImgType, flReg.EnCode64(obj.Images), obj.IsWith, obj.IsHeight,
                                                            obj.Target, flReg.EnCode64(obj.IsURL), obj.StartDate, obj.EndDate, obj.IsLang, obj.IsActive,
                                                            obj.IsOrder, obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UserUpdate,
                                                            obj.PageLoca_ID, obj.PortalID, obj.CategoryID)
            ObjController.SV_Update_CMS_Advertise_SendView(PortalID, obj.Advertise_ID, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_Advertise_SendView(PortalID, obj.Advertise_ID, False)
        End Try
    End Sub
    Private Sub SV_New_Add(obj As CMS_NewsInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_News_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.NewId,
                       obj.CategoryId, flReg.EnCode64(obj.Introduction), flReg.EnCode64(obj.Title), flReg.EnCode64(obj.ImagePath),
                       flReg.EnCode64(obj.Summary), flReg.EnCode64(obj.Content),
                       obj.isActive, obj.Hotcat, obj.IsCare, obj.isRead, obj.Status, obj.Unit, obj.NewsKind,
                       obj.Type, obj.TypeUrl, flReg.EnCode64(obj.Links), flReg.EnCode64(obj.Tags), obj.IsImage, obj.Note, obj.SourceInfo,
                       obj.IsEdited, obj.EditedUser, obj.EditedTime, obj.VoteCount, obj.ViewCount, obj.IsArchived,
                       obj.ArchivedDate, obj.Credit, obj.Createdate, obj.ApprovalRequestDate, obj.ApprovalDate,
                       obj.ApprovalUser, obj.ReturnedDate, obj.ReturnedUser, obj.CancelPublishDate, obj.CancelPublishUser,
                       obj.PublishedDate, obj.PublishedUser, obj.UserId, obj.WriterName, obj.WriterFullName, obj.NumberNews,
                       obj.NotePrices, obj.LanguageId, obj.PortalId, flReg.EnCode64(obj.ToUrl), obj.GetFromPortal, obj.GetFromNewId,
                       obj.SendName, obj.SendView)

            ObjController.SV_Update_CMS_News_SendView(PortalID, obj.NewId, SendView)
            Dim strTags() As String = obj.Tags.Split(",")
            Dim tagInfo As New CMS_NewsByTagsInfo
            For i As Integer = 0 To strTags.Length - 1
                tagInfo = ObjController.CMS_NewsByTags_Get(PortalID, flReg.WriteNumber(strTags(i)))
                If IsNothing(tagInfo) = False Then
                    objSend.SV_CMS_NewsByTags_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, tagInfo.Id, obj.NewId, tagInfo.TagName)
                End If
            Next
            arrTemp = ObjController.CMS_NewsByCategory_GetByNewsId(PortalID, PortalID, flConnect.IsLang, obj.NewId)
            For Each Ck As CMS_NewsByCategoryInfo In arrTemp
                SendView = objSend.SV_CMS_NewsByCategory_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID,
                                 Ck.Id, Ck.NewsId, Ck.CategoryId, Ck.IsMainCategory, Ck.NewsStatusId, Ck.PortalID, Ck.LanguageId)
            Next

        Catch ex As Exception
            ObjController.SV_Update_CMS_News_SendView(PortalID, obj.NewId, False)
        End Try
    End Sub
    Private Sub SV_New_Add_PSA(obj As CMS_NewsInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_News_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.NewId,
                       obj.CategoryId, flReg.EnCode64(obj.Introduction), flReg.EnCode64(obj.Title), flReg.EnCode64(obj.ImagePath),
                       flReg.EnCode64(obj.Summary), flReg.EnCode64(obj.Content),
                       obj.isActive, obj.Hotcat, obj.IsCare, obj.isRead, obj.Status, obj.Unit, obj.NewsKind,
                       obj.Type, obj.TypeUrl, flReg.EnCode64(obj.Links), flReg.EnCode64(obj.Tags), obj.IsImage, obj.Note, obj.SourceInfo,
                       obj.IsEdited, obj.EditedUser, obj.EditedTime, obj.VoteCount, obj.ViewCount, obj.IsArchived,
                       obj.ArchivedDate, obj.Credit, obj.Createdate, obj.ApprovalRequestDate, obj.ApprovalDate,
                       obj.ApprovalUser, obj.ReturnedDate, obj.ReturnedUser, obj.CancelPublishDate, obj.CancelPublishUser,
                       obj.PublishedDate, obj.PublishedUser, obj.UserId, obj.WriterName, obj.WriterFullName, obj.NumberNews,
                       obj.NotePrices, obj.LanguageId, obj.PortalId, flReg.EnCode64(obj.ToUrl), obj.GetFromPortal, obj.GetFromNewId,
                       obj.SendName, obj.SendView)

            ObjController.SV_Update_CMS_News_SendView(PortalID, obj.NewId, SendView)

            arrTemp2 = ObjController.CMS_Media_Get_By_News_ID(PortalID, obj.NewId)
            For Each Cr As CMS_MediaInfo In arrTemp2
                SendView = objSend.SV_CMS_Media_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, Cr.Id, Cr.CategoryId, flReg.EnCode64(Cr.Name & ""), flReg.EnCode64(Cr.Summary & ""),
                            flReg.EnCode64(Cr.Avatar & ""), flReg.EnCode64(Cr.MediaUrl & ""), Cr.Folders & "", flReg.EnCode64(Cr.Contents & ""), Cr.ViewCount,
                            Cr.Status, Cr.Type, Cr.IsYoutube, Cr.IsHot, Cr.IsFTP, Cr.Tags & "", Cr.Note & "",
                            Cr.CreatedDate, Cr.PublishedDate, Cr.ApprovalDate, Cr.CreatedUser & "", Cr.ApprovalUser & "",
                            Cr.PublishedUser & "", Cr.PortalId, Cr.LanguageId & "", Cr.STT, Cr.IsHome, Cr.IsPage, flReg.EnCode64(Cr.ToUrl & ""))
                ObjController.SV_Update_CMS_Media_SendView(PortalID, Cr.Id, SendView)
            Next
            arrTemp2 = ObjController.CMS_NewsByMedia_GetByNewsId(PortalID, obj.NewId)
            For Each Cr1 As CMS_NewsByMediaInfo In arrTemp2
                objSend.SV_CMS_NewsByMedia_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, Cr1.Id, Cr1.NewsId, Cr1.MediaId)
                ObjController.SV_Update_CMS_NewsByMedia_SendView(PortalID, Cr1.Id, SendView)
            Next
            Dim strTags() As String = obj.Tags.Split(",")
            For i As Integer = 0 To strTags.Length - 1
                tagInfo = ObjController.CMS_NewsByTags_Get(PortalID, flReg.WriteNumber(strTags(i)))
                If IsNothing(tagInfo) = False Then
                    objSend.SV_CMS_NewsByTags_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, tagInfo.Id, obj.NewId, tagInfo.TagName)
                End If
            Next
        Catch ex As Exception
            ObjController.SV_Update_CMS_News_SendView(PortalID, obj.NewId, False)
        End Try
    End Sub
    Private Sub SV_Media_Add(obj As CMS_MediaInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_Media_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.Id, obj.CategoryId, flReg.EnCode64(obj.Name & ""), flReg.EnCode64(obj.Summary & ""),
                            flReg.EnCode64(obj.Avatar & ""), flReg.EnCode64(obj.MediaUrl & ""), obj.Folders & "", flReg.EnCode64(obj.Contents & ""), obj.ViewCount,
                            obj.Status, obj.Type, obj.IsYoutube, obj.IsHot, obj.IsFTP, obj.Tags & "", obj.Note & "",
                            obj.CreatedDate, obj.PublishedDate, obj.ApprovalDate, obj.CreatedUser & "", obj.ApprovalUser & "",
                            obj.PublishedUser & "", obj.PortalId, obj.LanguageId & "", obj.STT, obj.IsHome, obj.IsPage, flReg.EnCode64(obj.ToUrl & ""))
            ObjController.SV_Update_CMS_Media_SendView(PortalID, obj.Id, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_News_SendView(PortalID, obj.Id, False)
        End Try
    End Sub
    Private Sub SV_CMS_FAQ_Add(obj As CMS_FAQInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_FAQ_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.Id, flReg.EnCode64(obj.Name), flReg.EnCode64(obj.Summary), flReg.EnCode64(obj.Image),
                                                               obj.StartDate, obj.EndDate, obj.AnswerUserId, flReg.EnCode64(obj.AnswerUserName), obj.IsUserDefault, flReg.EnCode64(obj.DefaultAnswerName), obj.PortalId, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)

            ObjController.SV_Update_CMS_FAQ_SendView(PortalID, obj.Id, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_FAQ_SendView(PortalID, obj.Id, False)
        End Try
    End Sub
    Private Sub SV_CMS_FAQAnswers_Add(obj As CMS_FAQAnswersInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_FAQAnswers_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.Id, obj.QuestionID, flReg.EnCode64(obj.Name), flReg.EnCode64(obj.Title), flReg.EnCode64(obj.Contents), obj.FileAttach, obj.SendDate, obj.Status, obj.IsPublic, obj.PortalId, flReg.EnCode64(obj.AnswerName), obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)

            ObjController.SV_Update_CMS_FAQAnswers_SendView(PortalID, obj.Id, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_FAQAnswers_SendView(PortalID, obj.Id, False)
        End Try
    End Sub
    Private Sub SV_CMS_FAQQuestions_Add(obj As CMS_FAQQuestionsInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_FAQQuestions_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.Id, obj.FAQID, flReg.EnCode64(obj.Name), flReg.EnCode64(obj.Contents), flReg.EnCode64(obj.FileAttach), flReg.EnCode64(obj.Adress), flReg.EnCode64(obj.Email), obj.Phone, obj.SendDate, obj.Status, obj.IsPublic, obj.PortalId, obj.CreateDate, obj.CreateUser, obj.UpdateDate, obj.UpdateUser)
            ObjController.SV_Update_CMS_FAQQuestions_SendView(PortalID, obj.Id, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_FAQQuestions_SendView(PortalID, obj.Id, False)
        End Try
    End Sub
    Private Sub SV_CMS_Setups_Add(obj As CMS_SetupsInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_Setups_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.ID, flReg.EnCode64(obj.SettingName), flReg.EnCode64(obj.SettingValue), obj.CreatedBy, obj.UserName, obj.UpdatedBy, obj.UpdatedUser, obj.PortalID)

            ObjController.SV_Update_CMS_Setups_SendView(PortalID, obj.ID, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_Setups_SendView(PortalID, obj.ID, False)
        End Try
    End Sub
    Private Sub SV_CMS_ConfigSystem_Add(obj As CMS_ConfigSystemInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_ConfigSystem_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.ID, PortalID, obj.IsCMS, obj.IsLive, flReg.EnCode64(obj.LiveTitle), flReg.EnCode64(obj.LiveUrl), flReg.EnCode64(obj.LiveDes), obj.StartDate, obj.EndDate, flReg.EnCode64(obj.SiteMap), flReg.EnCode64(obj.IpPublic), flReg.EnCode64(obj.Analytics), obj.UpdatedBy, obj.UpdateName)

            ObjController.SV_Update_CMS_ConfigSystem_SendView(PortalID, obj.ID, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_ConfigSystem_SendView(PortalID, obj.ID, False)
        End Try
    End Sub
    Private Sub SV_Infomation_Add(obj As CMS_InfomationInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_Infomation_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, flReg.EnCode64(obj.NameH1), flReg.EnCode64(obj.NameH2), flReg.EnCode64(obj.NameH3),
                                                 flReg.EnCode64(obj.ImagePath), flReg.EnCode64(obj.ImageRight), flReg.EnCode64(obj.Footer),
                                                 flReg.EnCode64(obj.Infomation), obj.CreatedDate, obj.CreatedUser, obj.UpdateDate, obj.UpdateUser, obj.PortalId, obj.LanguageId)
            ObjController.SV_Update_CMS_Infomation_SendView(PortalID, obj.Id, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_Infomation_SendView(PortalID, obj.Id, False)
        End Try
    End Sub
    Private Sub SV_CMS_WebLink_Add(obj As CMS_WebLinkInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_WebLink_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.Id, flReg.EnCode64(obj.Name),
                                         obj.OrderNo, flReg.EnCode64(obj.Url), obj.Image, flReg.EnCode64(obj.Description), obj.PortalId, obj.LanguageId,
                                         obj.ViewType, obj.UserName, obj.Createdate)
            ObjController.SV_Update_CMS_WebLink_SendView(PortalID, obj.Id, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_WebLink_SendView(PortalID, obj.Id, False)
        End Try
    End Sub
    Private Sub SV_CMS_NewsFeedback_Add(obj As CMS_NewsFeedbackInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_NewsFeedback_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.NewsFeedbackId, obj.ItemId, flReg.EnCode64(obj.FullName), flReg.EnCode64(obj.Email),
                                obj.CreateDate, obj.PhoneNumber, flReg.EnCode64(obj.Title), flReg.EnCode64(obj.Content), flReg.EnCode64(obj.Address), flReg.EnCode64(obj.IPTrack),
                                Status, flReg.EnCode64(obj.Avatar), obj.Type, obj.PortalId, obj.LanguageId, obj.IsLike, obj.DisLike, obj.ParentID, obj.IsRead, obj.UserRead,
                                obj.DateRead, obj.IsPublic, obj.UserPublic, obj.DatePublic)
            ObjController.SV_Update_CMS_NewsFeedback_SendView(PortalID, obj.NewsFeedbackId, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_NewsFeedback_SendView(PortalID, obj.NewsFeedbackId, False)
        End Try
    End Sub
    Private Sub SV_NewsCategories_Add(obj As CMS_NewsCategoriesInfo, PortalID As Integer)
        Try
            objSend.AuthHeaderValue = objAuth
            SendView = objSend.SV_CMS_NewsCategories_Add(flCheck.setCode(GetPortalSettings.UserId), PortalID, obj.CategoryID,
                            flReg.EnCode64(obj.CategoryName), flReg.EnCode64(obj.Description), obj.TabID, obj.IsActive,
                            obj.CreateDate, obj.PortalId, obj.LanguageId, obj.ParentId, obj.OrderNumber, obj.Type, obj.TabPath, obj.TabMobileID)
            ObjController.SV_Update_CMS_NewsCategories_SendView(PortalID, obj.CategoryID, SendView)
        Catch ex As Exception
            ObjController.SV_Update_CMS_NewsCategories_SendView(PortalID, obj.CategoryID, False)
        End Try
    End Sub

End Class
Public Class PortalReturn
    Public Property http As String
    Public Property url As String
    Public Property nID As String
    Public Property pID As Integer
    Public Property tPe As Integer
End Class
Public Class Response
    Public Property Data As Object
End Class
