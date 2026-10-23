Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports Telerik.Web.UI

Namespace DesktopModules.Media.Manager
    Public MustInherit Class Edit_Media
        Inherits Entities.Modules.PortalModuleBase

#Region "Properties"
        Private ObjController As New CmsController
        Dim arr, arrTemp, arrTemp1, arrValue, arrTempTin, arrTempAnh As New ArrayList
        Dim objMedia As New CMS_MediaInfo
        Dim objTag As CMS_NewsByTagsInfo
        Private objProcessInfo As New CMS_News_ProcessInfo
        Private objWF As New CMS_News_UserWFInfo
        Dim DropDown As DropDownList
        Dim TextBox As TextBox
        Dim HiddenField As HiddenField

        Dim str() As String, lit As Literal
        Dim drlist As DropDownList
        Dim txtg As RadNumericTextBox
        Dim nbDetailInfo As New CMS_News_NBDetailInfo
        Dim nbInfo As New CMS_News_NBInfo
        Dim dmNhuanButInfo As New CMS_DMNhuanButInfo
        Dim _tabName As String = PortalSettings.ActiveTab.TabName
#End Region
#Region "Function"
        Private Sub GetID()
            ItemId.Value = flReg.WriteNumber(Request.Item("id"))
            If Request.Item("up") & "" = "" Then Session("UrlReferrer_Media") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName) & ""
            WF_TYPE.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TYPE", Request.Item("edit")))

            WF_DEFAULT.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_DEFAULT", Request.Item("edit")))
            If WF_DEFAULT.Value <> "0" Then
                cmdRun.Visible = True
                cmdRun.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXTDF", Request.Item("edit")) & ""
            End If

            cmdPUBNOW.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXTPUBNOW", Request.Item("edit"))
            WF_PUBNOW.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PUBNOW", Request.Item("edit")))
            If WF_PUBNOW.Value <> "0" Then
                WF_ROLE.Value = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PUBROLE", Request.Item("edit"))
                str = WF_ROLE.Value.Split(",")
                For i As Integer = 0 To str.Length - 1
                    If flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, str(i)) = True Then
                        cmdPUBNOW.Visible = True
                        Exit For
                    End If
                Next
            End If
            cmdBack1.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT1", Request.Item("edit"))
            If cmdBack1.Text <> "" Then
                cmdBack1.Visible = True
                WF_BACK1.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK1", Request.Item("edit")))
                objWF = ObjController.CMS_News_UserWF_Get(ddlPortal.SelectedValue, flReg.WriteNumber(WF_BACK1.Value))
                If IsNothing(objWF) = False Then WF_BACK1.Value = flReg.WriteNumber(objWF.TrangThaiDich)
            End If
            'cmdBack2.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT2", Request.Item("edit"))
            'If cmdBack2.Text <> "" Then
            '    cmdBack2.Visible = True
            '    WF_BACK2.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK2", Request.Item("edit")))
            'End If
            'cmdBack3.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT3", Request.Item("edit"))
            'If cmdBack3.Text <> "" Then
            '    cmdBack3.Visible = True
            '    WF_BACK3.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK3", Request.Item("edit")))
            'End If
            If cmdSave.Visible Then
                labBP.Text = "Ghi chú xuất bản"
                pnAddBp.Visible = True
                cmdButPhe.Text = "Lưu ghi chú"
            Else
                pnAddBp.Visible = False
            End If
            If Me.UserInfo.Username = "host" Then cmdSettings.Visible = True
            cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
        End Sub
        Private Sub LoadAuthors(CreateUser As String)
            WriterName.Items.Clear()
            If flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Xuat ban") Then
                arr = ObjController.CMS_Authors_List_Search(ddlPortal.SelectedValue, "", 0, -1, 0, "")
            Else
                arr = ObjController.CMS_Authors_List_Search(ddlPortal.SelectedValue, "", 0, -1, 0, Me.UserInfo.Username & "," & CreateUser)
            End If
            For Each Cr As CMS_AuthorsInfo In arr
                WriterName.Items.Add(New ListItem(Cr.FullName & " (" & Cr.PenName & ")", Cr.Authors_ID))
            Next
        End Sub
        Private Sub LoadType()
            ddlType.Items.Clear()
            If WF_TYPE.Value = mediaType.Audio Then
                ddlType.Items.Add(New ListItem("Audio", CategoryType.Audio))
                pnaVideo.Visible = False
                pnaAudio.Visible = True
                Call flFunction.LoadCategories(ddlDanhmuc, ddlPortal.SelectedValue, "admin", CategoryType.Audio, "- - - Chọn chuyên mục - - -", "")
                NBType.Value = CategoryType.Audio

                MediaRela.Text = "<b>Audio liên quan</b>"
                MediaRela.Text += "<a onclick=""popupRelated('audio', 900,600); return false;"" title='Chọn audio liên quan'>"
                MediaRela.Text += "&nbsp;&nbsp;<img src='/images/icons/note_go.png' alt='Chọn audio liên quan' /></a>"
                litTitle.Text = "THÔNG TIN NỘI DUNG AUDIO"
            Else
                ddlType.Items.Add(New ListItem("Video", CategoryType.Video))
                pnaVideo.Visible = True
                pnaAudio.Visible = False
                Call flFunction.LoadCategories(ddlDanhmuc, ddlPortal.SelectedValue, "admin", CategoryType.Video, "- - - Chọn chuyên mục - - -", "")
                NBType.Value = CategoryType.Video

                MediaRela.Text = "<b>Video liên quan</b>"
                MediaRela.Text += "<a onclick=""popupRelated('video', 900,600); return false;"" title='Chọn video liên quan'>"
                MediaRela.Text += "&nbsp;&nbsp;<img src='/images/icons/note_go.png' alt='Chọn video liên quan' /></a>"
                litTitle.Text = "THÔNG TIN NỘI DUNG VIDEO"

            End If
            ddlDanhmuc.SelectedIndex = 1
        End Sub
        Private Sub LoadValue()
            objMedia = ObjController.CMS_Media_Get(ddlPortal.SelectedValue, ItemId.Value)
            If IsNothing(objMedia) = False Then
                IdTags.Value = ""
                With objMedia
                    cmdDel.Visible = True
                    New_STATUS.Value = .Status
                    txtPublishDate.Text = flReg.ReadDate(.PublishedDate)
                    Call LoadAuthors(.CreatedUser)

                    If .Avatar & "" <> "" Then
                        imgDD.InnerHtml = "<img alt=""ảnh đại diện"" src='" & flConnect.fileDomain & .Avatar & "?w=120'/>"
                        lbtDelImg.Attributes("style") = "display: block;"
                    End If
                    hdWriterName.Value = .WriterName
                    If hdWriterName.Value <> "" Then ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setmultile", "setmultile();", True)

                    txtTitle.Text = .Name
                    IsHot.Checked = .IsHot
                    IsHome.Checked = .IsHome
                    IsPage.Checked = .IsPage
                    txtSummary.Text = Server.HtmlDecode(.Summary)
                    chkYoutube.Checked = .IsYoutube
                    txtImagePath.Value = objMedia.Avatar
                    hdfMedia.Value = .MediaUrl
                    txtlinkYotube.Text = hdfMedia.Value
                    litButPhe.Text = .Note

                    If .MediaUrl <> "" Then
                        If .Type = 1 Then 'Audio
                            viewMedia.InnerHtml = "<audio class=""view-media"" controls><source src=""" & flConnect.fileDomain & .MediaUrl & """ type=""audio/mpeg""></audio>"
                        Else 'Video
                            If .IsYoutube = True Then
                                ytb.Attributes("class") = "control media-youtube"
                                viewMedia.InnerHtml = "<object id=""flvplayer"" wmode=""transparent"" type=""application/x-shockwave-flash"" allowfullscreen=""True"""
                                viewMedia.InnerHtml += " data=""http://www.youtube.com/v/" & .MediaUrl & "&hl=en&fs=1&autoplay=1&rel=0"" width=""100%"" height=""400px""></object>"
                            Else
                                viewMedia.InnerHtml = "<video width='220' controls><source src='" & flConnect.fileDomain & .MediaUrl & "' type='video/mp4'></video>"
                            End If
                        End If
                    End If
                    ddlDanhmuc.SelectedValue = .CategoryId
                    If .Contents & "" <> "" Then
                        hdf_Related.Value = .Contents
                        Dim arrRelated As New ArrayList
                        str = .Contents.Split(";")
                        Dim obj As New CMS_MediaInfo
                        For i As Integer = 0 To str.Length - 1
                            If IsNumeric(str(i)) Then
                                obj = ObjController.CMS_Media_Get(ddlPortal.SelectedValue, str(i))
                                arrRelated.Add(obj)
                            End If
                        Next
                        rptRelated.DataSource = arrRelated
                        rptRelated.DataBind()
                    End If

                    'Tags
                    If .Tags & "" <> "" Then
                        hdf_Tags.Value = .Tags
                        str = .Tags.Split(",")
                        For i As Integer = 0 To str.Length - 1
                            objTag = ObjController.CMS_NewsByTags_Get(ddlPortal.SelectedValue, flReg.WriteNumber(str(i)))
                            If IsNothing(objTag) = False Then
                                IdTags.Value += objTag.TagName & ","
                            End If
                        Next
                    End If
                    If .Status = NewsStatus.DaXuatBan Then
                        cmdStop.Visible = flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Xuat ban")
                        cmdRun.Visible = False
                        cmdDel.Visible = False
                        txtPublishDate.CssClass = ""
                        txtPublishDate.Enabled = False
                    ElseIf .Status = NewsStatus.HuyXuatBan Then
                        txtPublishDate.Text = ""
                    End If
                End With
				ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "cdel_load", " cdel();", True)
			Else
				Call LoadAuthors("")
            End If
        End Sub
        Function CheckValid() As Boolean
            If (ddlDanhmuc.SelectedIndex = -1) OrElse txtTitle.Text = "" Or String.IsNullOrEmpty(txtTitle.Text) Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Bạn phải nhập đầy đủ các trường bắt buộc!', 'Thông báo', false);", True)
                Return False
            Else
                Return True
            End If
        End Function
        Private Function SaveTags(tags As String) As String
            SaveTags = ""
            str = tags.Split(",")
            For i As Integer = 0 To str.Length - 1
                If str(i) & "" <> "" Then
                    If IsNumeric(str(i)) Then
                        SaveTags &= str(i) & ","
                    Else
                        SaveTags &= ObjController.CMS_NewsByTags_Add(ddlPortal.SelectedValue, ItemId.Value, str(i)) & ","
                    End If
                End If
            Next
            If SaveTags <> "" Then SaveTags = SaveTags.Substring(0, SaveTags.LastIndexOf(","))
        End Function 'Tags
        Private Function SaveMedia(WFID As Integer) As CMS_MediaInfo
            If ItemId.Value <> "0" Then
                objMedia = ObjController.CMS_Media_Get(ddlPortal.SelectedValue, ItemId.Value)
                'Lưu media
                With objMedia
                    .PublishedDate = flReg.WriteDate(txtPublishDate.Text)
                    .CategoryId = ddlDanhmuc.SelectedValue
                    .Name = txtTitle.Text.Trim
                    .ToUrl = flReg.NameUrl(.Name)
                    .IsHot = IsHot.Checked
                    .IsHome = IsHome.Checked
                    .IsPage = IsPage.Checked
                    .IsYoutube = chkYoutube.Checked
                    .Type = WF_TYPE.Value
                    .LanguageId = flConnect.IsLang
                    .PortalId = ddlPortal.SelectedValue
                    .ApprovalUser = UserInfo.Username
                    .ApprovalDate = Now
                    .Contents = hdf_Related.Value
                    .IsFTP = False
                    .Status = New_STATUS.Value
                    .Tags = SaveTags(hdf_Tags.Value) 'Tags
                    .Summary = txtSummary.Text
                    .PublishedDate = flReg.WriteDate(txtPublishDate.Text)
                    .WriterName = hdWriterName.Value
                    .Note = flReg.RemoveScript(butPhe.Value.Replace(vbLf, "").Replace("onclick", "xoaclink"))
                    If chkYoutube.Checked = True Then
                        .MediaUrl = Me.txtlinkYotube.Text
                        hdfMedia.Value = ""
                    Else
                        .MediaUrl = hdfMedia.Value
                    End If
                    .Avatar = txtImagePath.Value
                End With
                ObjController.CMS_Media_Update(ddlPortal.SelectedValue, objMedia)

                ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, WFID, UserInfo.Username)
            Else
                objMedia = New CMS_MediaInfo
                With objMedia
                    .CategoryId = ddlDanhmuc.SelectedValue
                    .Name = txtTitle.Text.Trim
                    .ToUrl = flReg.NameUrl(.Name)
                    .IsHot = IsHot.Checked
                    .IsHome = IsHome.Checked
                    .IsPage = IsPage.Checked
                    .IsYoutube = chkYoutube.Checked
                    .Type = WF_TYPE.Value
                    .LanguageId = flConnect.IsLang
                    .PortalId = ddlPortal.SelectedValue
                    .WriterName = hdWriterName.Value
                    .CreatedDate = Now
                    .CreatedUser = UserInfo.Username
                    .ApprovalUser = UserInfo.Username
                    .ApprovalDate = Now
                    .Contents = hdf_Related.Value
                    .IsFTP = False
                    .PublishedDate = flReg.WriteDate(txtPublishDate.Text)
                    .Status = New_STATUS.Value
                    .Tags = "" 'Tags
                    .Summary = txtSummary.Text
                    .Note = flReg.RemoveScript(butPhe.Value.Replace(vbLf, "").Replace("onclick", "xoaclink"))
                    If chkYoutube.Checked = True Then
                        .MediaUrl = Me.txtlinkYotube.Text
                        hdfMedia.Value = ""
                    Else
                        .MediaUrl = hdfMedia.Value
                    End If
                    .Avatar = txtImagePath.Value
                End With
                ItemId.Value = ObjController.CMS_Media_Add(ddlPortal.SelectedValue, objMedia)
                ObjController.CMS_News_Update_Tags_Media(ddlPortal.SelectedValue, ItemId.Value, SaveTags(hdf_Tags.Value))

                objProcessInfo.ItemId = ItemId.Value
                objProcessInfo.CreateDate = Now
                objProcessInfo.ByUser = UserInfo.Username
                objProcessInfo.IPTrack = Request.ServerVariables("REMOTE_ADDR")
                objProcessInfo.Type = 1 'Dành cho media
                objProcessInfo.ProcessName = "--> Đăng nội dung"
                ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)
            End If
            Call SaveNhuanBut()
            Return objMedia
        End Function
        Private Sub BackEnd()
            Ultis.UnlockNews(ddlPortal.SelectedValue, ItemId.Value, UserInfo.Username)
			If Request.Item("page") & "" <> "" Then
				Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/pid/" & ddlPortal.SelectedValue, True)
			Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/video-my/pid/" & ddlPortal.SelectedValue, True)
            End If
        End Sub
        Private Function GetMediaPath(ByVal foldername As String, ByVal radupload As RadAsyncUpload) As String
            If radupload.UploadedFiles.Count > 0 Then
                Dim f As UploadedFile = radupload.UploadedFiles(0)
                Return foldername & "/" & f.FileName
            Else
                Return ""
            End If
        End Function
        Private Function GetUploadPath(ByVal spath As String) As String
            Try
                Return spath.Substring(0, spath.LastIndexOf("/", System.StringComparison.Ordinal))
            Catch ex As Exception
                Return ""
            End Try
        End Function
        Private Sub BindLoadPortal()
            ddlPortal.DataSource = Ultis.UserPortal(Me.UserInfo.Username)
            ddlPortal.DataTextField = "PortalName"
            ddlPortal.DataValueField = "PortalId"
            ddlPortal.DataBind()
            If Request.Item("pid") & "" <> "" Then
                ddlPortal.SelectedValue = Request.Item("pid")
            Else
                ddlPortal.SelectedValue = Me.PortalId
            End If
        End Sub
#End Region
#Region "Event"
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call BindLoadPortal()
                    Call GetID()
                    Call LoadType()
                    Call LoadValue()
                    Call LoadNhuanBut()
                End If
            Catch ex As Exception
                LogException(ex)
                newContents.Visible = False
                lbmsg.Text = "<div class=""dnnFormMessage dnnFormValidationSummary"">Bạn đang truy cập vào hệ thống không đúng quy định. Vui lòng liên vệ với ban quản trị để được trợ giúp!</div>"
            End Try
        End Sub
        Protected Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Call BackEnd()
        End Sub
        Private Sub NextNews(WFID As String, nextName As String)
            Try
                If txtTitle.Text.Trim & "" = "" Then
                    txtTitle.Focus()
                    Exit Sub
                End If
                If ddlDanhmuc.SelectedValue = "0" Then
                    ddlDanhmuc.Focus()
                    Exit Sub
                End If
                objMedia = SaveMedia(WFID)
                objWF = ObjController.CMS_News_UserWF_Get(ddlPortal.SelectedValue, WFID)
                objProcessInfo = New CMS_News_ProcessInfo
                With objProcessInfo
                    .ItemId = ItemId.Value
                    .CreateDate = DateTime.Now
                    .ByUser = Me.UserInfo.Username
                    .StatusID = objWF.TrangThaiDich
                    .ProcessName = "--> " & nextName
                    .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                    .VersionId = WFID
                    .Type = 1
                End With
                ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)

                Dim strToUsers As String = objWF.NguoiNhan
                Dim objUserNews As New CMS_News_UserProcessInfo

                ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemId.Value, Me.UserInfo.Username)
                objUserNews.UserID = objWF.ID
                objUserNews.NewsID = ItemId.Value
                objUserNews.CreatedUser = Me.UserInfo.Username
                objUserNews.CreatedDate = DateTime.Now
                objUserNews.Status = objWF.TrangThaiDich
                objUserNews.isActive = 0

                If objWF.TrangThaiDich = NewsStatus.DaXuatBan Then objUserNews.isActive = 1

                objUserNews.PositionID = objWF.PositionID
                ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)

                If objMedia.PublishedDate.Year > 1900 Then
                    objMedia.PublishedDate = objMedia.PublishedDate
                Else
                    objMedia.PublishedDate = Now
                End If
                ObjController.CMS_Media_Guiduyet(ddlPortal.SelectedValue, ItemId.Value, objWF.TrangThaiDich, Me.UserInfo.Username, objMedia.PublishedDate)

                objMedia.Status = objWF.TrangThaiDich
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub ReturnNews(wfBack As Integer, ProcessName As String)
            Try
                objMedia = SaveMedia(wfBack)
                If wfBack = NewsStatus.BiTraLai Then 'Tra lại cho phong viên
                    Dim objUserNews As New CMS_News_UserProcessInfo
                    ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemId.Value, Me.UserInfo.Username)
                    ObjController.CMS_Media_Guiduyet(ddlPortal.SelectedValue, ItemId.Value, NewsStatus.BiTraLai, Me.UserInfo.Username, DateTime.Now)
                    '2. Process
                    With objProcessInfo
                        .ItemID = ItemId.Value
                        .CreateDate = DateTime.Now
                        .ByUser = Me.UserInfo.Username
                        .StatusID = NewsStatus.BiTraLai
                        .ProcessName = "--> " & ProcessName
                        .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                        .VersionId = wfBack
                        .Type = 1
                    End With
                    ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)
                    objUserNews.UserID = Ultis.BackWF(ddlPortal.SelectedValue, ItemId.Value) 'Tai khoan tra lai
                    objUserNews.NewsID = ItemId.Value
                    objUserNews.CreatedUser = Me.UserInfo.Username
                    objUserNews.CreatedDate = DateTime.Now
                    objUserNews.Status = NewsStatus.BiTraLai
                    objUserNews.isActive = 0
                    objUserNews.PositionID = 0
                    ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)
                Else  'Trả lại theo quy trình
                    Dim objUserNews As New CMS_News_UserProcessInfo
                    ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemId.Value, Me.UserInfo.Username)
                    ObjController.CMS_Media_Guiduyet(ddlPortal.SelectedValue, ItemId.Value, NewsStatus.TraLaiQT, Me.UserInfo.Username, DateTime.Now)
                    '2. Process
                    With objProcessInfo
                        .ItemID = ItemId.Value
                        .CreateDate = DateTime.Now
                        .ByUser = Me.UserInfo.Username
                        .StatusID = NewsStatus.TraLaiQT
                        .ProcessName = "--> " & ProcessName
                        .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                        .VersionId = wfBack
                        .Type = 1
                    End With
                    ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)

                    objUserNews.UserID = WF_BACK1.Value
                    objUserNews.NewsID = ItemId.Value
                    objUserNews.CreatedUser = Me.UserInfo.Username
                    objUserNews.CreatedDate = DateTime.Now
                    objUserNews.Status = NewsStatus.TraLaiQT
                    objUserNews.isActive = 0
                    objUserNews.PositionID = 3
                    ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Protected Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
            Call NextNews(WF_DEFAULT.Value, cmdRun.Text)
        End Sub
        Protected Sub cmdBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack1.Click
            Call ReturnNews(WF_BACK1.Value, cmdBack1.Text)
            Call BackEnd()

        End Sub
        Protected Sub cmdBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack2.Click
            Call ReturnNews(WF_BACK2.Value, cmdBack2.Text)
            Call BackEnd()
        End Sub
        Protected Sub cmdBack3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack3.Click
            Call ReturnNews(WF_BACK3.Value, cmdBack3.Text)
            Call BackEnd()
        End Sub
        Protected Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
            Try
                '1. Update Status
                ObjController.CMS_Media_Guiduyet(ddlPortal.SelectedValue, ItemId.Value, NewsStatus.HuyXuatBan, Me.UserInfo.Username, Now)
                '2. Process
                With objProcessInfo
                    .ItemID = ItemId.Value
                    .CreateDate = Now
                    .ByUser = UserInfo.Username
                    .StatusID = NewsStatus.HuyXuatBan
                    .ProcessName = " --> " & cmdStop.Text
                    .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                    .Type = 1
                End With
                ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)

                'Hoan thanh qua trinh xu ly
                Dim objUserNews As New CMS_News_UserProcessInfo
                objUserNews = New CMS_News_UserProcessInfo
                With objUserNews
                    .UserID = Ultis.BackWF(ddlPortal.SelectedValue, ItemId.Value)
                    .NewsID = ItemId.Value
                    .CreatedUser = UserInfo.Username
                    .CreatedDate = Now
                    .Status = NewsStatus.HuyXuatBan
                    .isActive = 0
                    .PositionID = NewsStatus.HuyXuatBan
                End With
                ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemId.Value, UserInfo.Username, 0)
                ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Protected Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            ObjController.CMS_Media_Delete_Update(ddlPortal.SelectedValue, True, Now, Me.UserInfo.Username, ItemId.Value)
            Call BackEnd()
        End Sub
        Protected Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                objMedia = SaveMedia(WF_DEFAULT.Value)
                Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)
            Catch ex As Exception

            End Try
        End Sub
        Private Sub ddlPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit") & "/pid/" & ddlPortal.SelectedValue & "/up/me", True)
        End Sub
        Private Sub cmdSettings_Click(sender As Object, e As EventArgs) Handles cmdSettings.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit") & "/setting/module/page/" & Request.Item("edit"), True)
        End Sub
        Private Sub cmdPUBNOW_Click(sender As Object, e As EventArgs) Handles cmdPUBNOW.Click
            Call NextNews(WF_PUBNOW.Value, cmdPUBNOW.Text)
        End Sub
#End Region
#Region "Nhuận bút"

        Private Sub LoadNhuanBut()
            arrTempTin = LoadDM(1)
            drMaDMTin.Items.Add(New ListItem("- - - Chọn định mức - - -", 0))
            For Each item As CMS_DMNhuanButInfo In arrTempTin
                drMaDMTin.Items.Add(New ListItem(item.MaDM, item.ID.ToString))
            Next
            nbInfo = ObjController.CMS_News_NB_Get_By_NewsID(ddlPortal.SelectedValue, flReg.WriteNumber(ItemId.Value), NBType.Value)
            If Not IsNothing(nbInfo) Then
                drMaDMTin.SelectedValue = nbInfo.DM_ID
                NB_ID.Value = nbInfo.ID
                arr = ObjController.CMS_News_NBDetail_List_By_NewsNBID(ddlPortal.SelectedValue, NB_ID.Value)
                If arr.Count > 0 Then
                    grdDMAnh.DataSource = arr
                    grdDMAnh.PageSize = 20
                    grdDMAnh.DataKeyField = "ID"
                    grdDMAnh.DataBind()
                Else
                    arrTempAnh = LoadDM(2)
                    grdDMAnh.DataSource = arrTempAnh
                    grdDMAnh.PageSize = 20
                    grdDMAnh.DataKeyField = "ID"
                    grdDMAnh.DataBind()
                End If
            Else
                arrTempAnh = LoadDM(2)
                grdDMAnh.DataSource = arrTempAnh
                grdDMAnh.PageSize = 20
                grdDMAnh.DataKeyField = "ID"
                grdDMAnh.DataBind()
            End If
        End Sub
        Private Function LoadDM(Type As Integer) As ArrayList
            arr = ObjController.CMS_DMNhuanBut_Get_By_Type(ddlPortal.SelectedValue, Type, Now.Month, Now.Year)
            If arr.Count = 0 Then
                If Now.Month - 1 = 0 Then
                    arr = ObjController.CMS_DMNhuanBut_Get_By_Type(ddlPortal.SelectedValue, Type, 12, Now.Year - 1)
                Else
                    arr = ObjController.CMS_DMNhuanBut_Get_By_Type(ddlPortal.SelectedValue, Type, Now.Month - 1, Now.Year)
                End If
                For Each item As CMS_DMNhuanButInfo In arr
                    dmNhuanButInfo = New CMS_DMNhuanButInfo
                    dmNhuanButInfo.MaDM = item.MaDM
                    dmNhuanButInfo.Type = item.Type
                    dmNhuanButInfo.HeSo = item.HeSo
                    dmNhuanButInfo.Price = item.DonGia
                    dmNhuanButInfo.Month = Now.Month
                    dmNhuanButInfo.Year = Now.Year
                    dmNhuanButInfo.Description = item.Description
                    dmNhuanButInfo.Orders = item.Orders
                    dmNhuanButInfo.Active = item.Active

                    dmNhuanButInfo.CreateUser = Me.UserInfo.Username
                    dmNhuanButInfo.CreateDate = Now
                    dmNhuanButInfo.UpdateUser = ""
                    dmNhuanButInfo.UpdateDate = Now
                    ObjController.CMS_DMNhuanBut_Add(ddlPortal.SelectedValue, dmNhuanButInfo)
                Next
            End If
            Return arr
        End Function
        Private Sub SaveNhuanBut()
            Dim tinM As Integer
            dmNhuanButInfo = ObjController.CMS_DMNhuanBut_Get(ddlPortal.SelectedValue, drMaDMTin.SelectedValue)
            If IsNothing(dmNhuanButInfo) = False Then
                tinM = dmNhuanButInfo.DonGia * dmNhuanButInfo.HeSo
            End If
            nbInfo = New CMS_News_NBInfo
            nbInfo.NewsID = ItemId.Value
            nbInfo.DM_ID = drMaDMTin.SelectedValue
            nbInfo.Price = tinM
            nbInfo.Type = NBType.Value
            If NB_ID.Value <> "" Then
                nbInfo.ID = NB_ID.Value
                nbInfo.CreateDate = Now
                nbInfo.CreateUser = UserInfo.Username
                nbInfo.UpdateUser = UserInfo.Username
                nbInfo.UpdateDate = Now
                ObjController.CMS_News_NB_Update(ddlPortal.SelectedValue, nbInfo)
            Else
                nbInfo.CreateDate = Now
                nbInfo.CreateUser = UserInfo.Username
                nbInfo.UpdateUser = ""
                nbInfo.UpdateDate = Now
                nbInfo.ID = ObjController.CMS_News_NB_Add(ddlPortal.SelectedValue, nbInfo)
            End If

            For Each rowItem As DataGridItem In grdDMAnh.Items
                nbDetailInfo = New CMS_News_NBDetailInfo
                If NB_ID.Value <> "" Then
                    nbDetailInfo.NewsNB_ID = NB_ID.Value
                Else
                    nbDetailInfo.NewsNB_ID = nbInfo.ID
                End If

                lit = rowItem.FindControl("ID")
                nbDetailInfo.ID = lit.Text

                lit = rowItem.FindControl("drMaDMAnh")
                nbDetailInfo.MaDM = lit.Text

                lit = rowItem.FindControl("HeSo")
                nbDetailInfo.HeSo = flReg.WriteNumber(lit.Text)

                txtg = rowItem.FindControl("SoLuong")
                nbDetailInfo.SoLuong = flReg.WriteNumber(txtg.Text)

                txtg = rowItem.FindControl("IsMoney")
                nbDetailInfo.Price = flReg.WriteNumber(txtg.Text)

                lit = rowItem.FindControl("DonGia")
                nbDetailInfo.DonGia = flReg.WriteNumber(lit.Text)

                nbDetailInfo.CreateDate = Now
                nbDetailInfo.CreateUser = UserInfo.Username
                nbDetailInfo.UpdateDate = Now
                nbDetailInfo.UpdateUser = UserInfo.Username
                ObjController.CMS_News_NBDetail_Add(ddlPortal.SelectedValue, nbDetailInfo)
            Next
        End Sub
        Private Sub grdDMAnh_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdDMAnh.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            lit = e.Item.FindControl("IsOrder")
            lit.Text = e.Item.ItemIndex + 1

            lit = e.Item.FindControl("DonGia")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "DonGia")

            lit = e.Item.FindControl("ID")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "ID")

            lit = e.Item.FindControl("drMaDMAnh")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "MaDM")

            lit = e.Item.FindControl("HeSo")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "HeSo")

            txtg = e.Item.FindControl("SoLuong")
            txtg.Text = DataBinder.Eval(e.Item.DataItem, "SoLuong")
            txtg.Attributes.Add("onchange", "updatePrice(" & DataBinder.Eval(e.Item.DataItem, "HeSo") & "," &
                                DataBinder.Eval(e.Item.DataItem, "DonGia") & ",this," & DataBinder.Eval(e.Item.DataItem, "ID") & ")")

            txtg = e.Item.FindControl("IsMoney")
            txtg.Text = DataBinder.Eval(e.Item.DataItem, "Price")
            txtg.CssClass = txtg.CssClass & " money-" & DataBinder.Eval(e.Item.DataItem, "ID")
        End Sub
#End Region
    End Class
End Namespace