Imports DotNetNuke.EPORTAL
Imports Telerik.Web.UI

Namespace DotNetNuke.CMS
    Public MustInherit Class Edit
        Inherits Entities.Modules.PortalModuleBase

#Region "Varial"
        Public StorageFolder As String = String.Empty
        Public strCssCn As String, lit As Literal
        Dim nbDetailInfo As New CMS_News_NBDetailInfo
        Dim nbInfo As New CMS_News_NBInfo
        Dim dmNhuanButInfo As New CMS_DMNhuanButInfo

        Dim ObjController As New CmsController
        Dim OldObjInfo, objNews As New CMS_NewsInfo
        Dim objProcessInfo As New CMS_News_ProcessInfo
        Dim objWF As New CMS_News_UserWFInfo
        Dim arr, arrTemp, arrTempTin, arrTempAnh As New ArrayList
        Dim objInfo As New CMS_NewsCategoriesInfo
        Dim iArec As Boolean, str(), str1(), newsRoyID As String
        Dim pTotal As Double, iNo As Integer
        Dim objTag As New CMS_NewsByTagsInfo
        Dim txtg As RadNumericTextBox
        Dim drlist As DropDownList
        Dim liter As Literal
        Dim cbox As New CheckBox, lab As New Label
        Dim SoLuong As Integer = 1, pubMonth As Integer, pubYear As Integer
        Dim _tabName As String = PortalSettings.ActiveTab.TabName

#End Region

#Region "Function"

        Private Sub GetID()
            WF_DEFAULT.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_DEFAULT", Request.Item("edit")))
            If WF_DEFAULT.Value <> "0" Then
                cmdRun0.Visible = True
                cmdRun0.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXTDF", Request.Item("edit")) & ""
            End If

            WF_TO1.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TO1", Request.Item("edit")))
            If WF_TO1.Value <> "0" Then
                cmdRun1.Visible = True
                cmdRun1.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXT1", Request.Item("edit")) & ""
            End If

            WF_TO2.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TO2", Request.Item("edit")))
            If WF_TO2.Value <> "0" Then
                cmdRun2.Visible = True
                cmdRun2.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXT2", Request.Item("edit")) & ""
            End If

            'WF_TO3.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TO3", Request.Item("edit")))
            'If WF_TO3.Value <> "0" Then
            '    cmdRun3.Visible = True
            '    cmdRun3.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXT3", Request.Item("edit")) & ""
            'End If

            cmdBack1.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT1", Request.Item("edit"))
            If cmdBack1.Text <> "" Then
                cmdBack1.Visible = True
                WF_BACK1.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK1", Request.Item("edit")))
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
            'cmdBack4.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT4", Request.Item("edit"))
            'If cmdBack4.Text <> "" Then
            '    cmdBack4.Visible = True
            '    WF_BACK4.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK4", Request.Item("edit")))
            'End If
            cmdPUBNOW.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXTPUBNOW", Request.Item("edit"))
            WF_PUBNOW.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PUBNOW", Request.Item("edit")))

            If WF_PUBNOW.Value <> "0" Then
                WF_ROLE.Value = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PUBROLE", "news-create")
                str = WF_ROLE.Value.Split(",")
                For i As Integer = 0 To str.Length - 1
                    If flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, str(i)) = True Then
                        cmdPUBNOW.Visible = True
                        Exit For
                    End If
                Next
            End If
            WF_VIVN.Value = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_VIVN", Request.Item("edit"))

            If Me.UserInfo.Username = "host" Then cmdSettings.Visible = True
            cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
            If cmdSave.Visible Then
                labBP.Text = "Bút phê, ghi chú"
                pnAddBp.Visible = True
                cmdButPhe.Text = "Lưu ghi chú"
            Else
                pnAddBp.Visible = False
            End If
            'pnNhuanBut.Visible = flReg.IsInRole(Me.PortalSettings.ActiveTab.TabName, "Nhuan But")
        End Sub
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
            _HTTPAlias.Value = flConnect.WebDomain(ddlPortal.SelectedValue)

            WF_VIVN.Value = WF_VIVN.Value.Contains(ddlPortal.SelectedValue)
            newVN.Visible = WF_VIVN.Value
        End Sub
        Private Sub LoadAuthors(CreateUser As String)
            WriterName.Items.Clear()
            arr = ObjController.CMS_Authors_List_Search(ddlPortal.SelectedValue, "", 0, -1, 0, "")
            For Each Cr As CMS_AuthorsInfo In arr
                If Cr.Regions = 0 Then
                    WriterName.Items.Add(New ListItem(Cr.FullName & " (" & Cr.Address & ")", Cr.Authors_ID))
                Else
                    If Cr.PenName <> Cr.FullName And Cr.PenName <> "" Then
                        WriterName.Items.Add(New ListItem(Cr.FullName & " (" & Cr.PenName & ")", Cr.Authors_ID))
                    Else
                        WriterName.Items.Add(New ListItem(Cr.FullName, Cr.Authors_ID))
                    End If
                End If
            Next
        End Sub
        Private Sub LoadValues()
            pubMonth = Now.Month : pubYear = Now.Year
            If ItemID.Value <> "0" Then
                IdTags.Value = ""
                objNews = ObjController.CMS_News_Get(ddlPortal.SelectedValue, ItemID.Value)
                With objNews
                    If .IsEdited = True Then
                        Call BackEnd()
                    Else
                        Ultis.LockNews(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)
                        lockNews.Value = "True"
                    End If
                    Call LoadAuthors(.UserId)
                    ParentText.Text = "Chuyên mục: " & flCheck.CategoryParentName(.PortalId, .CategoryId)
                    flCache.SetCache("OldId" & ItemID.Value, objNews)

                    ddlPortal.SelectedValue = .PortalId
                    WF_STATUS.Value = .Status
                    txtPublishDate.Text = flReg.ReadDate(.PublishedDate)
                    nowStatus.Value = .Status
                    If Me.UserInfo.Username = .UserId Then cmdDel.Visible = True
                    If .Status = NewsStatus.DaXuatBan Then
                        cmdStop.Visible = flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Xuat ban")
                        cmdRun0.Visible = False
                        cmdRun1.Visible = False
                        cmdRun2.Visible = False
                        cmdRun3.Visible = False
                        cmdDel.Visible = False
                        txtPublishDate.CssClass = ""
                        txtPublishDate.Enabled = False
                        pubMonth = .PublishedDate.Month
                        pubYear = .PublishedDate.Year
                    ElseIf .Status = NewsStatus.HuyXuatBan Then
                        txtPublishDate.Text = ""
                    End If
                    Me.txtTitle.Text = .Title
                    Me.txtSummary.Text = .Summary

                    If .NewsKind = 5 Then chkIsNewsLive.Checked = True
                    hdf_theloai.Value = .NewsKind
                    teContent.Content = .Content

                    hdWriterName.Value = .WriterName
                    If hdWriterName.Value <> "" Then ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setmultile", "setmultile();", True)

                    'Tin tiêu điểm, theo dòng sự kiện, nổi bật trang chủ, nổi bật chuyên mục
                    chkHotCat.Checked = .Hotcat
                    chkMobile.Checked = .IsMobile
                    chkCare.Checked = .IsCare
                    SourceInfo.SelectedValue = .SourceInfo
                    Introduction.Text = .Introduction
                    ddlCategory.SelectedValue = .CategoryId
                    NguonTin.Text = .SendName

                    If .ImagePath & "" <> "" Then
                        imgDD.InnerHtml = "<img alt='ảnh đại diện' src='" & flConnect.fileDomain & .ImagePath & "?dpi=150&quality=100&w=165&h=130'/>"
                        lbtDelImg.Attributes("style") = "display: block;"
                    Else
                        imgDD.InnerHtml = "<img alt='ảnh đại diện' src='/image/images/noimage.png?dpi=150&quality=100&w=165&h=130'/>"
                        lbtDelImg.Attributes("style") = "display: none;"
                    End If
                    txtImagePath.Value = .ImagePath
                    'Tin lien quan
                    If .Links & "" <> "" Then
                        hdf_Related.Value = .Links
                        Dim arrRelated As New ArrayList
                        str = .Links.Split(";")
                        For i As Integer = 0 To str.Length - 1
                            If IsNumeric(str(i)) Then
                                arrRelated.Add(ObjController.CMS_News_Get(ddlPortal.SelectedValue, str(i)))
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
                                IdTags.Value += objTag.TagName.Trim() & ","
                            End If
                        Next
                    End If
                    If .GetFromNewId > 0 Then cmdBack1.Visible = False
                    StorageFolder = ""
                    ' Ghi chú nhuận bút
                    litButPhe.Text = flReg.RemoveScript(.Note, False)
                    txtNotePrices.Text = .NotePrices
                End With
                hdf_Category.Value = ddlCategory.SelectedValue
            Else
                Call LoadAuthors(Me.UserInfo.Username)
                hdWriterName.Value = Me.UserInfo.Username
            End If
            teContent.Content += "&nbsp;"
            If litButPhe.Text <> "" Then pnButPhe.Visible = True
            Call LoadChuyenMP()
            Call LoadNhuanBut()
        End Sub
        Private Sub BackEnd2()
            If Request.Item("page") & "" <> "" Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/pid/" & ddlPortal.SelectedValue, True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/news-my/pid/" & ddlPortal.SelectedValue & "/status/2", True)
            End If
        End Sub
        Private Sub BackEnd()
            If Request.Item("page") & "" <> "" Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/pid/" & ddlPortal.SelectedValue, True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/news-my/pid/" & ddlPortal.SelectedValue, True)
            End If
        End Sub
        Private Sub BackEnd1()
            If Request.Item("page") & "" <> "" Then
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/pid/" & ddlPortal.SelectedValue, True)
            Else
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/news-my/pid/" & ddlPortal.SelectedValue & "/status/5", True)
            End If
        End Sub
        Private Function SaveNews(Optional ByVal bs As Boolean = False) As CMS_NewsInfo
            Try
                '1. Update
                If ItemID.Value <> "0" Then
                    objNews = getNewInfo(ObjController.CMS_News_Get(ddlPortal.SelectedValue, ItemID.Value))
                    ObjController.CMS_News_Update(ddlPortal.SelectedValue, objNews)
                    If bs = True Then
                        With objProcessInfo
                            .ItemID = ItemID.Value
                            .CreateDate = DateTime.Now
                            .ByUser = Me.UserInfo.Username
                            .StatusID = NewsStatus.DangBienSoan
                            .ProcessName = "--> Chỉnh sửa"
                            .Type = 1
                        End With
                        ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)
                        objNews.WriterFullName = "--> Chỉnh sửa"
                        Call SaveVersion(objNews)
                    End If
                Else 'Add New
                    objNews = getNewInfo(Nothing)
                    ItemID.Value = ObjController.CMS_News_Add(ddlPortal.SelectedValue, objNews)
                    ObjController.CMS_News_Update_Tags(ddlPortal.SelectedValue, ItemID.Value, SaveTags(hdf_Tags.Value))
                    objNews.NewId = ItemID.Value

                    With objProcessInfo
                        .ItemID = ItemID.Value
                        .CreateDate = DateTime.Now
                        .ByUser = Me.UserInfo.Username
                        .StatusID = NewsStatus.DangBienSoan
                        .ProcessName = "--> Đăng tin bài"
                        .Type = 1
                    End With
                    ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)

                    objNews.WriterFullName = "--> Đăng tin bài"
                    Call SaveVersion(objNews)
                End If
                Call SaveNhuanBut() 'Nhuận bút
                Call SaveChuyenMP(ItemID.Value)
                Return objNews
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                Return Nothing
            End Try
        End Function
        Private Function SaveTags(tags As String) As String
            SaveTags = ""
            str = tags.Split(",")
            For i As Integer = 0 To str.Length - 1
                If str(i).Trim() & "" <> "" Then
                    If IsNumeric(str(i)) Then
                        SaveTags &= str(i).Trim() & ","
                    Else
                        SaveTags &= ObjController.CMS_NewsByTags_Add(ddlPortal.SelectedValue, ItemID.Value, str(i).Trim()) & ","
                    End If
                End If
            Next
            If SaveTags <> "" Then SaveTags = SaveTags.Substring(0, SaveTags.LastIndexOf(","))
        End Function 'Tags
        Private Function getNewInfo(ByVal obj As CMS_NewsInfo) As CMS_NewsInfo
            Try
                If obj Is Nothing Then
                    obj = New CMS_NewsInfo
                    obj.Createdate = DateTime.Now
                    obj.UserId = Me.UserInfo.Username
                    obj.LanguageId = flConnect.IsLang
                    obj.Unit = flCheck.GetPhongBanIdByUserId(ddlPortal.SelectedValue, UserId)
                End If

                With obj
                    .NewId = ItemID.Value
                    .PortalId = ddlPortal.SelectedValue
                    .LanguageId = flConnect.IsLang
                    .IsEdited = False
                    .Introduction = Introduction.Text
                    .CategoryId = ddlCategory.SelectedValue
                    .Tags = SaveTags(hdf_Tags.Value) 'Tags
                    .NumberNews = 0
                    'Lưu ngày xuất bản
                    .PublishedDate = flReg.WriteDate(txtPublishDate.Text)
                    .PublishedUser = Me.UserInfo.Username

                    'Tin tiêu điểm, sự kiện, nổi bật trang chủ, chuyên mục
                    .Hotcat = chkHotCat.Checked
                    .IsMobile = chkMobile.Checked
                    .IsCare = chkCare.Checked

                    'Người gửi, tác giả
                    .SendName = NguonTin.Text.Trim
                    .WriterName = hdWriterName.Value
                    .WriterFullName = .WriterName

                    .Title = txtTitle.Text
                    .ToUrl = flReg.NameUrl(txtTitle.Text.Trim)
                    .NewsKind = flReg.WriteNumber(hdf_theloai.Value)
                    .SourceInfo = SourceInfo.SelectedValue
                    .Summary = txtSummary.Text & ""
                    .Content = teContent.Content
                    .IsImage = False
                    .isActive = True
                    .Type = 0
                    .TypeUrl = ""
                    .ImagePath = txtImagePath.Value
                    .Links = hdf_Related.Value 'Tin lien quan
                    .Note = flReg.RemoveScript(butPhe.Value.Replace(vbLf, "").Replace("onclick", "xoaclink"))
                    .Credit = 0
                    .GetFromPortal = ddlPortal.SelectedValue
                    .NotePrices = txtNotePrices.Text ' ghi chú nhuận bút
                End With
                Return obj
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Private Sub SaveSubSite(newsid As Integer, PortalSub As Integer)
            With objProcessInfo
                .ItemID = ItemID.Value
                .CreateDate = DateTime.Now
                .ByUser = Me.UserInfo.Username
                .StatusID = NewsStatus.DangBienSoan
                .ProcessName = "--> Đã gửi bài tới đơn vị"
                .Type = 1
            End With
            ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)

            Dim obj As New CMS_NewsInfo
            obj.Createdate = Now
            obj.UserId = Me.UserInfo.Username
            obj.LanguageId = flConnect.IsLang
            obj.PortalId = PortalSub
            obj.Tags = SaveTags(hdf_Tags.Value)

            obj.Introduction = Introduction.Text
            obj.CategoryId = 0

            'Lưu ngày xuất bản
            obj.PublishedDate = flReg.DateNull
            obj.PublishedUser = Me.UserInfo.Username

            obj.Hotcat = chkHotCat.Checked
            obj.IsMobile = chkMobile.Checked
            obj.IsCare = chkCare.Checked

            'Người gửi, tác giả
            obj.SendName = obj.SendName
            obj.WriterName = hdWriterName.Value
            obj.WriterFullName = obj.WriterName

            obj.Title = txtTitle.Text
            obj.ToUrl = flReg.NameUrl(txtTitle.Text.Trim)
            obj.NewsKind = flReg.WriteNumber(hdf_theloai.Value)
            obj.SourceInfo = SourceInfo.SelectedValue
            obj.Summary = txtSummary.Text & ""
            obj.Content = teContent.Content
            obj.Status = NewsStatus.ChoXuatBan

            obj.isActive = True
            obj.IsEdited = False
            obj.IsImage = False
            obj.Unit = 0
            obj.Credit = 0
            obj.Type = 0

            obj.TypeUrl = ""
            obj.NumberNews = ""
            obj.Links = "" 'Tin lien quan
            obj.ImagePath = txtImagePath.Value
            obj.GetFromNewId = newsid
            obj.GetFromPortal = ddlPortal.SelectedValue
            obj.Note = butPhe.Value

            obj.NewId = ObjController.CMS_News_Add(PortalSub, obj)
            ObjController.CMS_News_Update_Status(PortalSub, obj.NewId, NewsStatus.ChoXuatBan, Me.UserInfo.Username, Now)

            ObjController.CMS_NewsByCategory_Add(PortalSub, obj.NewId, 0, True, NewsStatus.ChoXuatBan, PortalSub, flConnect.IsLang, obj.Hotcat)
        End Sub
        Private Sub SaveVersion(newObj As CMS_NewsInfo)
            Ultis.Save2Version(ddlPortal.SelectedValue, newObj, Me.UserInfo.Username)
        End Sub
        Private Sub NextNews(WFID As String, nextName As String)
            Try
                If txtTitle.Text.Trim = "" Then
                    txtTitle.Focus() : Exit Sub
                End If
                If ddlCategory.SelectedValue = 0 Then
                    ddlCategory.Focus() : Exit Sub
                End If
                objNews = SaveNews()
                objWF = ObjController.CMS_News_UserWF_Get(ddlPortal.SelectedValue, WFID)
                objProcessInfo = New CMS_News_ProcessInfo
                With objProcessInfo
                    .ItemID = ItemID.Value
                    .CreateDate = DateTime.Now
                    .ByUser = Me.UserInfo.Username
                    .StatusID = objWF.TrangThaiDich
                    .ProcessName = "--> " & nextName
                    .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                    .VersionId = WFID
                    .Type = 1
                End With
                ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)

                Dim objUserNews As New CMS_News_UserProcessInfo
                ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)
                objUserNews.UserID = objWF.ID
                objUserNews.NewsID = ItemID.Value
                objUserNews.CreatedUser = Me.UserInfo.Username
                objUserNews.CreatedDate = Now
                objUserNews.Status = objWF.TrangThaiDich
                If objWF.TrangThaiDich = NewsStatus.DaXuatBan Then
                    If flReg.WriteDate(txtPublishDate.Text).Year = 1900 Then
                        objNews.PublishedDate = Now
                    Else
                        objNews.PublishedDate = flReg.WriteDate(txtPublishDate.Text)
                    End If
                    objUserNews.isActive = 1
                    ObjController.CMS_News_Update_Status(ddlPortal.SelectedValue, ItemID.Value, NewsStatus.DaXuatBan, Me.UserInfo.Username, objNews.PublishedDate)
                Else
                    ObjController.CMS_News_Update_Status(ddlPortal.SelectedValue, ItemID.Value, objWF.TrangThaiDich, Me.UserInfo.Username, Now)
                    objUserNews.isActive = 0
                End If
                objUserNews.PositionID = objWF.PositionID
                ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)
                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)

                objNews.Status = objWF.TrangThaiDich

                objNews.WriterFullName = "--> " & nextName
                Call SaveVersion(objNews)
                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username)
                'Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub ReturnNews(wfBack As Integer, ProcessName As String)
            Try
                objWF = ObjController.CMS_News_UserWF_Get(ddlPortal.SelectedValue, wfBack)
                If IsNothing(objWF) = False Then  'Tra lại cho phong viên
                    objNews = SaveNews()
                    Dim objUserNews As New CMS_News_UserProcessInfo
                    ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)
                    ObjController.CMS_News_Update_Status(ddlPortal.SelectedValue, ItemID.Value, objWF.TrangThaiDich, Me.UserInfo.Username, Now)
                    '2. Process
                    With objProcessInfo
                        .ItemID = ItemID.Value
                        .CreateDate = DateTime.Now
                        .ByUser = Me.UserInfo.Username
                        .StatusID = objWF.TrangThaiDich
                        .ProcessName = "--> " & ProcessName
                        .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                        .VersionId = wfBack
                        .Type = 1
                    End With
                    ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)
                    objUserNews.UserID = Ultis.BackWF(ddlPortal.SelectedValue, ItemID.Value) 'Tai khoan tra lai
                    objUserNews.NewsID = ItemID.Value
                    objUserNews.CreatedUser = Me.UserInfo.Username
                    objUserNews.CreatedDate = DateTime.Now
                    objUserNews.Status = objWF.TrangThaiDich
                    objUserNews.isActive = 0
                    objUserNews.PositionID = objWF.PositionID
                    ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)
                End If
                objNews.WriterFullName = "--> " & ProcessName
                Call SaveVersion(objNews)
                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub SaveChuyenMP(ByVal newsid As Integer)
            Try
                ObjController.CMS_NewsByCategory_Delete_By_NewsID(ddlPortal.SelectedValue, newsid)
                str1 = cateID_CMP.Value.Split(";")

                If cateID_NPhu.Value <> "" Then
                    str = cateID_NPhu.Value.Split(";")
                    For i As Integer = 0 To str.Length - 1
                        If flReg.WriteNumber(str(i)) > 0 And str(i) <> ddlCategory.SelectedValue Then
                            ObjController.CMS_NewsByCategory_Add(ddlPortal.SelectedValue, newsid, str(i), False, WF_STATUS.Value, ddlPortal.SelectedValue, flConnect.IsLang, 1)
                        End If
                    Next 'Nóng chuyên mục phụ
                    For j As Integer = 0 To str1.Length - 1
                        If flReg.WriteNumber(str1(j)) > 0 Then
                            If cateID_NPhu.Value.Contains(str1(j)) = False And str1(j) <> ddlCategory.SelectedValue Then
                                ObjController.CMS_NewsByCategory_Add(ddlPortal.SelectedValue, newsid, str1(j), False, WF_STATUS.Value, ddlPortal.SelectedValue, flConnect.IsLang, 0)
                            End If
                        End If
                    Next 'Chuyên mục phụ
                Else
                    For j As Integer = 0 To str1.Length - 1
                        If flReg.WriteNumber(str1(j)) > 0 Then
                            If str1(j) <> ddlCategory.SelectedValue Then
                                ObjController.CMS_NewsByCategory_Add(ddlPortal.SelectedValue, newsid, str1(j), False, WF_STATUS.Value, ddlPortal.SelectedValue, flConnect.IsLang, 0)
                            End If
                        End If
                    Next 'Chuyên mục phụ
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub LoadChuyenMP()
            If IsNothing(flCache.GetCache("CMS:NewsCategories_Poral_" & ddlPortal.SelectedValue)) = True Then
                arr = ObjController.CMS_NewsCategories_List_All(ddlPortal.SelectedValue, ddlPortal.SelectedValue, flConnect.IsLang)
                flCache.SetCache("CMS:NewsCategories_Poral_" & ddlPortal.SelectedValue, arr)
            Else
                arr = CType(flCache.GetCache("CMS:NewsCategories_Poral_" & ddlPortal.SelectedValue), ArrayList)
            End If
            catePhu.DataSource = arr
            catePhu.DataTextField = "CategoryName"
            catePhu.DataFieldID = "CategoryID"
            catePhu.DataFieldParentID = "ParentId"
            catePhu.DataValueField = "CategoryID"
            catePhu.DataBind()

            Call ChuyenMPChecked()
        End Sub
        Private Sub ChuyenMPChecked()
            catePhu.TriStateCheckBoxes = False 'Disable tristate handling

            arr = ObjController.CMS_NewsByCategory_GetByNewsId(ddlPortal.SelectedValue, ddlPortal.SelectedValue, flConnect.IsLang, ItemID.Value)
            cateID_NPhu.Value = "" : cateID_CMP.Value = ""
            For Each node As RadTreeNode In catePhu.GetAllNodes()
                cbox = New CheckBox
                cbox.ID = "isHot"
                cbox.Attributes.Add("onClick", "return AddRemoveHotCategory(this,'" & node.Value & "')")
                cbox.Attributes.Add("title", "Nóng chuyên mục")

                For Each Ck As CMS_NewsByCategoryInfo In arr
                    If Ck.CategoryId = node.Value And Ck.IsMainCategory = False Then
                        cateID_CMP.Value += ";" & Ck.CategoryId
                        node.Checked = True

                        If Ck.IsHotCate = True Then cateID_NPhu.Value += ";" & Ck.CategoryId
                        cbox.Checked = Ck.IsHotCate
                        arr.Remove(Ck)
                        Exit For
                    End If
                Next

                lab = New Label
                lab.Text = node.Text

                node.Controls.AddAt(0, cbox)
                node.Controls.AddAt(1, lab)
            Next
            catePhu.TriStateCheckBoxes = True 'Enable back tristate handling
        End Sub

#End Region

#Region "Event Handlers"
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                Call GetID()
                If Not IsPostBack Then
                    Call BindLoadPortal()
                    ItemID.Value = flReg.WriteNumber(Request.Item("itemid"))
                    If Request.Item("up") & "" = "" Then Session("UrlReferrer_New") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
                    'If flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Manager") = True Then
                    Call flFunction.LoadCategories(ddlCategory, ddlPortal.SelectedValue, "admin", CategoryType.News, "- - - Chọn chuyên mục - - - ", "")
                    'Else
                    '    Call flFunction.LoadCategories(ddlCategory, ddlPortal.SelectedValue, Me.UserInfo.Username, CategoryType.News, "- - - Chọn chuyên mục - - - ", "")
                    'End If
                    ddlCategory.SelectedValue = flReg.WriteNumber(Request.Item("catid"))
                    Call LoadValues()

                    If flReg.WriteNumber(Request.Item("newskind")) = 5 Then
                        chkIsNewsLive.Checked = True
                        hdf_theloai.Value = 5
                    End If
                End If
            Catch ex As Exception
                lbmsg.Text = "<div class=""dnnFormMessage dnnFormValidationSummary"">Bạn đang truy cập vào hệ thống không đúng quy định. Vui lòng liên vệ với ban quản trị để được trợ giúp!</div>"
                lbmsg.Text += "<div class=""dnnFormMessage dnnFormValidationSummary"">" & ex.Message & "</div>"
                pnContent.Visible = False
            End Try
        End Sub
        Private Sub cmdRun0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRun0.Click
            Call NextNews(WF_DEFAULT.Value, cmdRun0.Text)
            Call BackEnd1()
        End Sub
        Private Sub cmdRun1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRun1.Click
            Call NextNews(WF_TO1.Value, cmdRun1.Text)
            Call BackEnd()
        End Sub
        Private Sub cmdRun2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRun2.Click
            Call NextNews(WF_TO2.Value, cmdRun2.Text)
            Call BackEnd()
        End Sub
        Private Sub cmdRun3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRun3.Click
            Call NextNews(WF_TO3.Value, cmdRun3.Text)
            Call BackEnd()
        End Sub
        Private Sub cmdPUBNOW_Click(sender As Object, e As EventArgs) Handles cmdPUBNOW.Click
            Call NextNews(WF_PUBNOW.Value, cmdPUBNOW.Text)
            Call BackEnd2()
        End Sub
        Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
            Try
                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username) '1. Unlock tin bai
                ObjController.CMS_News_Update_Visible(ddlPortal.SelectedValue, ItemID.Value, False) '2. Soft delete
                With objProcessInfo
                    .ItemID = ItemID.Value
                    .CreateDate = DateTime.Now
                    .ByUser = Me.UserInfo.Username
                    .StatusID = WF_STATUS.Value
                    .ProcessName = "--> Xóa tin bài"
                    .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                    .Type = 1
                End With
                ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo) '3. Process: Deleted
                ObjController.CMS_News_Delete(ddlPortal.SelectedValue, ItemID.Value)

                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username)     '4. Return
                Call BackEnd()
            Catch ex As Exception    'Module failed to load
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
            Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)
            Call BackEnd()
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
        Protected Sub cmdBack4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack4.Click
            Call ReturnNews(WF_BACK4.Value, cmdBack4.Text)
            Call BackEnd()
        End Sub
        Private Sub ddlPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged
            _HTTPAlias.Value = flConnect.WebDomain(ddlPortal.SelectedValue)
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit") & "/pid/" & ddlPortal.SelectedValue & "/up/me", True)
        End Sub
        Protected Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
            Try
                '1. Update Status
                objNews = SaveNews()
                ObjController.CMS_News_Update_Status(ddlPortal.SelectedValue, ItemID.Value, NewsStatus.HuyXuatBan, Me.UserInfo.Username, Now)
                '2. Process
                With objProcessInfo
                    .ItemID = ItemID.Value
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
                    .UserID = Ultis.BackWF(ddlPortal.SelectedValue, ItemID.Value)
                    .NewsID = ItemID.Value
                    .CreatedUser = UserInfo.Username
                    .CreatedDate = Now
                    .Status = NewsStatus.HuyXuatBan
                    .isActive = 0
                    .PositionID = NewsStatus.HuyXuatBan
                End With
                ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username, 0)
                ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)
                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)


                'Đồng bộ
                objNews.WriterFullName = " --> " & cmdStop.Text
                Call SaveVersion(objNews)
                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username)
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Protected Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                objNews = SaveNews(True)
                Call LoadValues()
                BackEnd()
                flCache.RemoveCache("NewsId_" & ItemID.Value)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", "removewaiting(); notify('success','Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub cmdSettings_Click(sender As Object, e As EventArgs) Handles cmdSettings.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit") & "/setting/module/page/" & Request.Item("edit"), True)

        End Sub
#End Region

#Region "Nhuận bút"
        Private Sub LoadNhuanBut()
            arrTempTin = LoadDM(1)
            drMaDMTin.Items.Add(New ListItem("- - - Chọn định mức - - -", 0))
            For Each item As CMS_DMNhuanButInfo In arrTempTin
                drMaDMTin.Items.Add(New ListItem(item.MaDM, item.ID.ToString))
            Next

            nbInfo = ObjController.CMS_News_NB_Get_By_NewsID(ddlPortal.SelectedValue, flReg.WriteNumber(ItemID.Value), CategoryType.News)
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
            arr = ObjController.CMS_DMNhuanBut_Get_By_Type(ddlPortal.SelectedValue, Type, pubMonth, pubYear)
            If arr.Count = 0 Then
                If pubMonth - 1 = 0 Then
                    arr = ObjController.CMS_DMNhuanBut_Get_By_Type(ddlPortal.SelectedValue, Type, 12, pubYear - 1)
                Else
                    arr = ObjController.CMS_DMNhuanBut_Get_By_Type(ddlPortal.SelectedValue, Type, pubMonth - 1, pubYear)
                End If
                For Each item As CMS_DMNhuanButInfo In arr
                    dmNhuanButInfo = New CMS_DMNhuanButInfo
                    dmNhuanButInfo.MaDM = item.MaDM
                    dmNhuanButInfo.HeSo = item.HeSo
                    dmNhuanButInfo.SoLuong = item.SoLuong
                    dmNhuanButInfo.DonGia = item.DonGia
                    dmNhuanButInfo.Price = item.Price
                    dmNhuanButInfo.Description = item.Description
                    dmNhuanButInfo.Orders = item.Orders
                    dmNhuanButInfo.Type = item.Type
                    dmNhuanButInfo.Active = item.Active
                    dmNhuanButInfo.Month = Now.Month
                    dmNhuanButInfo.Year = Now.Year

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
            If pnNhuanBut.Visible = False Then Exit Sub
            Dim tinM As Double
            dmNhuanButInfo = ObjController.CMS_DMNhuanBut_Get(ddlPortal.SelectedValue, drMaDMTin.SelectedValue)
            If IsNothing(dmNhuanButInfo) = False Then tinM = dmNhuanButInfo.DonGia * dmNhuanButInfo.HeSo

            nbInfo = New CMS_News_NBInfo
            nbInfo.NewsID = ItemID.Value
            nbInfo.DM_ID = drMaDMTin.SelectedValue
            nbInfo.Price = tinM

            If NB_ID.Value <> "" Then
                nbInfo.ID = NB_ID.Value
                nbInfo.CreateDate = Now
                nbInfo.CreateUser = UserInfo.Username
                nbInfo.UpdateUser = UserInfo.Username
                nbInfo.UpdateDate = Now
                nbInfo.Type = CategoryType.News
                ObjController.CMS_News_NB_Update(ddlPortal.SelectedValue, nbInfo)
            Else
                nbInfo.CreateDate = Now
                nbInfo.CreateUser = UserInfo.Username
                nbInfo.UpdateUser = ""
                nbInfo.UpdateDate = Now
                nbInfo.Type = CategoryType.News
                nbInfo.ID = ObjController.CMS_News_NB_Add(ddlPortal.SelectedValue, nbInfo)
            End If

            For Each rowItem As DataGridItem In grdDMAnh.Items
                nbDetailInfo = New CMS_News_NBDetailInfo
                If NB_ID.Value <> "" Then
                    nbDetailInfo.NewsNB_ID = NB_ID.Value
                Else
                    nbDetailInfo.NewsNB_ID = nbInfo.ID
                End If

                liter = rowItem.FindControl("ID")
                nbDetailInfo.ID = liter.Text

                liter = rowItem.FindControl("drMaDMAnh")
                nbDetailInfo.MaDM = liter.Text

                liter = rowItem.FindControl("HeSo")
                nbDetailInfo.HeSo = flReg.WriteNumber(liter.Text)

                txtg = rowItem.FindControl("SoLuong")
                nbDetailInfo.SoLuong = flReg.WriteNumber(txtg.Text)

                txtg = rowItem.FindControl("IsMoney")
                nbDetailInfo.Price = flReg.WriteNumber(txtg.Text)

                liter = rowItem.FindControl("DonGia")
                nbDetailInfo.DonGia = flReg.WriteNumber(liter.Text)

                nbDetailInfo.CreateDate = Now
                nbDetailInfo.CreateUser = UserInfo.Username
                nbDetailInfo.UpdateDate = Now
                nbDetailInfo.UpdateUser = UserInfo.Username
                ObjController.CMS_News_NBDetail_Add(ddlPortal.SelectedValue, nbDetailInfo)
            Next
        End Sub
        Private Sub grdDMAnh_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdDMAnh.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            liter = e.Item.FindControl("IsOrder")
            liter.Text = e.Item.ItemIndex + 1

            liter = e.Item.FindControl("DonGia")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "DonGia")

            liter = e.Item.FindControl("ID")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ID")

            liter = e.Item.FindControl("drMaDMAnh")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "MaDM")

            liter = e.Item.FindControl("HeSo")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "HeSo")

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