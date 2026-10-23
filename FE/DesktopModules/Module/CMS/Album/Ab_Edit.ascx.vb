Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.TinAnh.Manager
    Public MustInherit Class Edit_News
        Inherits Entities.Modules.PortalModuleBase
        Public strCssCn As String
        Private objNews As New CMS_NewsInfo
        Private objProcessInfo As New CMS_News_ProcessInfo
        Private objWF As New CMS_News_UserWFInfo
        Dim arr, arrMedia, arrTemp As New ArrayList
        Dim objInfo As New CMS_NewsCategoriesInfo
        Dim ObjController As New CmsController
        Dim cv, positionID As Integer
        Dim str() As String, objTag As New CMS_NewsByTagsInfo
        Dim nbDetailInfo As New CMS_News_NBDetailInfo
        Dim nbInfo As New CMS_News_NBInfo
        Dim dmNhuanButInfo As New CMS_DMNhuanButInfo
        Dim arrTempTin, arrTempAnh As New ArrayList
        Dim _tabName As String = PortalSettings.ActiveTab.TabName

#Region "Common funtions"
        Private Sub GetID()
            ItemID.Value = flReg.WriteNumber(Request.Item("itemid"))
            User_Name.Value = Me.UserInfo.Username

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

            cmdBack1.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK_TEXT1", Request.Item("edit"))
            If cmdBack1.Text <> "" Then
                cmdBack1.Visible = True
                WF_BACK1.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_BACK1", Request.Item("edit")))
            End If

            cmdPUBNOW.Text = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_TEXTPUBNOW", Request.Item("edit"))
            WF_PUBNOW.Value = flReg.WriteNumber(flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PUBNOW", Request.Item("edit")))
            If WF_PUBNOW.Value <> "0" Then
                WF_ROLE.Value = flReg.SettingValue(flConnect.DmConnect, _tabName, "WF_PUBROLE", Request.Item("edit"))
                str = WF_ROLE.Value.Split(",")
                For i As Integer = 0 To str.Length - 1
                    If flReg.IsInRole(Me.PortalId, _tabName, str(i)) = True Then
                        cmdPUBNOW.Visible = True
                        Exit For
                    End If
                Next
            End If

            cmdSave.OnClientClick = "updateTags();formModified=false;saves(0," & WF_DEFAULT.Value & ",'" & cmdSave.Text & "');return false;"
            cmdRun0.OnClientClick = "updateTags();formModified=false; saves(1," & WF_DEFAULT.Value & ",'" & cmdRun0.Text & "');return false;"
            cmdRun1.OnClientClick = "updateTags();formModified=false; saves(1," & WF_TO1.Value & ",'" & cmdRun1.Text & "');return false;"
            cmdRun2.OnClientClick = "updateTags();formModified=false; saves(1," & WF_TO2.Value & ",'" & cmdRun2.Text & "');return false;"
            cmdRun3.OnClientClick = "updateTags();formModified=false; saves(1," & WF_TO3.Value & ",'" & cmdRun3.Text & "');return false;"
            cmdPUBNOW.OnClientClick = "updateTags();formModified=false; saves(1," & WF_PUBNOW.Value & ",'" & cmdPUBNOW.Text & "');return false;"

            If Me.UserInfo.Username = "host" Then cmdSettings.Visible = True
            cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
            UrlReferrer.Value = UrlBack()

            Call flFunction.LoadCategories(ddlCategory, ddlPortal.SelectedValue, "admin", CategoryType.Album, "- - - Chọn - - -", "")
            ddlCategory.SelectedIndex = 1
            hdf_Category.Value = ddlCategory.SelectedValue

            If cmdSave.Visible Then
                labBP.Text = "Bút phê, ghi chú"
                pnAddBp.Visible = True
                cmdButPhe.Text = "Lưu ghi chú"
            Else
                pnAddBp.Visible = False
            End If
        End Sub
        Private Sub LoadValue()
            objNews = ObjController.CMS_News_Get(ddlPortal.SelectedValue, ItemID.Value)
            If IsNothing(objNews) = False Then
                If objNews.IsEdited Then
                    Call BackEnd()
                Else
                    Ultis.LockNews(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username)
                    lockNews.Value = "True"
                End If
                IdTags.Value = ""
                btImg.Visible = True
                cmdDel.Visible = True
                With objNews
                    ddlPortal.SelectedValue = .PortalId
                    Me.txtTitle.Text = .Title
                    txtSummary.Content = .Content
                    WF_STATUS.Value = .Status
                    txtPublishDate.Text = flReg.ReadDate(.PublishedDate)
                    litButPhe.Text = .Note
                    NguonTin.Text = .SendName
                    If .Status = NewsStatus.DaXuatBan Then
                        cmdStop.Visible = flReg.IsInRole(Me.PortalId, _tabName, "Xuat ban")
                        cmdRun0.Visible = False
                        cmdRun1.Visible = False
                        cmdRun2.Visible = False
                        cmdRun3.Visible = False
                        cmdDel.Visible = False
                        txtPublishDate.CssClass = ""
                        txtPublishDate.Enabled = False
                    ElseIf .Status = NewsStatus.HuyXuatBan Then
                        txtPublishDate.Text = ""
                    End If

                    chkCare.Checked = .IsCare
                    chkHotCat.Checked = .Hotcat

                    ddlCategory.SelectedValue = .CategoryId
                    hdf_Category.Value = ddlCategory.SelectedValue
                    If .ImagePath & "" <> "" Then
                        imgDD.InnerHtml = "<img src=""" & EPORTAL.flConnect.fileDomain & .ImagePath & "?w=120""/>"
                        lbtDelImg.Attributes("style") = "display: block;"
                    End If
                    txtImagePath.Value = .ImagePath
                    'Tin lien quan
                    If Not String.IsNullOrEmpty(.Links) Then
                        hdf_Related.Value = .Links
                        Dim arrRelated As New ArrayList
                        Dim obj As New CMS_NewsInfo
                        str = .Links.Split(";")
                        For i As Integer = 0 To str.Length - 1
                            If IsNumeric(str(i)) Then
                                obj = ObjController.CMS_News_Get(ddlPortal.SelectedValue, str(i))
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

                End With
                Call LoadAlbum()
            End If
            txtSummary.Content += "&nbsp;"
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
        End Sub

        Private Sub BackEnd()
            Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username)
			If Request.Item("page") & "" <> "" Then
				Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/pid/" & ddlPortal.SelectedValue, True)
			Else
				Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/album-my/pid/" & ddlPortal.SelectedValue, True)
			End If
		End Sub
		Private Function UrlBack() As String
			Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username)
			If Request.Item("page") & "" <> "" Then
				Return "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("page") & "/pid/" & ddlPortal.SelectedValue
			Else
                Return "/" & Me.PortalSettings.ActiveTab.TabName & "/view/album-my/pid/" & ddlPortal.SelectedValue
            End If
        End Function
        Private Sub LoadAlbum()
            lrAlbum.Text = ""
            arrMedia = ObjController.CMS_Media_Get_By_News_ID(ddlPortal.SelectedValue, ItemID.Value)
            For Each objMedia As CMS_MediaInfo In arrMedia
                lrAlbum.Text += "<tr class=""new-row-album"" id='" & objMedia.Id & "'>"
                lrAlbum.Text += "<td><input type=""text"" name=""stt"" class=""sv-ab album-stt"" style=""width:80%;text-align:center;"" value='" & objMedia.STT & "' /></td>"
                lrAlbum.Text += "<td style=""text-align:center;""><a class=""delRelated"" style=""cursor: pointer;margin: 0 auto;float:none"" onclick=""delRlImg(this, '" & objMedia.Id & "');"" title=""Xóa ảnh?"" style=""cursor:pointer;""></a></td>"
                lrAlbum.Text += "<td style=""text-align:center""><img width=""130"" class=""album-img"" src=""" & flConnect.fileDomain & objMedia.Avatar & "?w=130""/></td>"
                lrAlbum.Text += "<td><textarea style=""width:100%;height:100%"" class=""mota"" name=""ghichu"" type=""text"">" & flReg.RemoveScript(objMedia.Contents, False) & "</textarea><br/><div class=""sp-ab"">Link liên kết</div>"
                lrAlbum.Text += "<input type=""text"" name=""url"" class=""sv-ab TextBox album-url"" style=""width:100%;"" value='" & objMedia.MediaUrl & "' /></td>"
                lrAlbum.Text += "<td style=""display:none;""><p class=""album-name"" title='" & objMedia.Name & "'></p></td>"
                lrAlbum.Text += "</tr>"
            Next
        End Sub
        Private Sub ReturnNews(wfBack As Integer, ProcessName As String)
            Try
                If wfBack = NewsStatus.BiTraLai Then  'Tra lại cho phong viên
                    Dim objUserNews As New CMS_News_UserProcessInfo
                    ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)
                    ObjController.CMS_News_Update_Status(ddlPortal.SelectedValue, ItemID.Value, NewsStatus.BiTraLai, Me.UserInfo.Username, Now)
                    '2. Process
                    With objProcessInfo
                        .ItemID = ItemID.Value
                        .CreateDate = DateTime.Now
                        .ByUser = Me.UserInfo.Username
                        .StatusID = NewsStatus.BiTraLai
                        .ProcessName = "--> " & ProcessName
                        .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                        .Type = 1
                    End With
                    ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)
                    objUserNews.UserID = Ultis.BackWF(ddlPortal.SelectedValue, ItemID.Value) 'Tai khoan tra lai
                    objUserNews.NewsID = ItemID.Value
                    objUserNews.CreatedUser = Me.UserInfo.Username
                    objUserNews.CreatedDate = DateTime.Now
                    objUserNews.Status = NewsStatus.BiTraLai
                    objUserNews.isActive = 0
                    objUserNews.PositionID = 0
                    ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)
                Else
                    Dim objUserNews As New CMS_News_UserProcessInfo
                    ObjController.CMS_News_UserProcess_UpdateStatusByNewsIDAndUserId(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)
                    ObjController.CMS_News_Update_Status(ddlPortal.SelectedValue, ItemID.Value, NewsStatus.TraLaiQT, Me.UserInfo.Username, Now)
                    '2. Process
                    With objProcessInfo
                        .ItemID = ItemID.Value
                        .CreateDate = DateTime.Now
                        .ByUser = Me.UserInfo.Username
                        .StatusID = NewsStatus.TraLaiQT
                        .ProcessName = "--> " & ProcessName
                        .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                        .VersionId = wfBack
                        .Type = 1
                    End With
                    ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)

                    objUserNews.UserID = wfBack
                    objUserNews.NewsID = ItemID.Value
                    objUserNews.CreatedUser = Me.UserInfo.Username
                    objUserNews.CreatedDate = DateTime.Now
                    objUserNews.Status = NewsStatus.TraLaiQT
                    objUserNews.isActive = 0
                    objUserNews.PositionID = 3
                    ObjController.CMS_News_UserProcess_Add(ddlPortal.SelectedValue, objUserNews)
                End If
                objNews.WriterFullName = "--> " & ProcessName
                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, UserInfo.Username)
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
#End Region

#Region "Event Handlers"
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call BindLoadPortal()
                    Call GetID()
                    Call LoadValue()
                    Call LoadNhuanBut()
                End If
            Catch ex As Exception
                lbmsg.Text = "<div class=""dnnFormMessage dnnFormValidationSummary"">Bạn đang truy cập vào hệ thống không đúng quy định. Vui lòng liên vệ với ban quản trị để được trợ giúp!</div>"
                newContent.Visible = False
            End Try
        End Sub
        Protected Sub cmdBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack1.Click
            Call ReturnNews(WF_BACK1.Value, cmdBack1.Text)
        End Sub
        Protected Sub cmdBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack2.Click
            Call ReturnNews(WF_BACK2.Value, cmdBack2.Text)
        End Sub
        Protected Sub cmdBack3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack3.Click
            Call ReturnNews(WF_BACK3.Value, cmdBack3.Text)
        End Sub
        Protected Sub cmdBack4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBack4.Click
            Call ReturnNews(WF_BACK4.Value, cmdBack4.Text)
        End Sub
        Protected Sub cmdStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdStop.Click
            Try
                '1. Update Status
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
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
            Try
                Ultis.UnlockNews(ddlPortal.SelectedValue, ItemID.Value, Me.UserInfo.Username)
            Catch exc As Exception
                ProcessModuleLoadException(Me, exc)
            End Try
            Call BackEnd()
        End Sub
        Private Sub ddlPortal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPortal.SelectedIndexChanged
            _HTTPAlias.Value = flConnect.WebDomain(ddlPortal.SelectedValue)
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit") & "/pid/" & ddlPortal.SelectedValue & "/up/me", True)
        End Sub
        Protected Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
            Try
                ObjController.CMS_News_Update_Visible(ddlPortal.SelectedValue, ItemID.Value, False)
                'Version
                With objProcessInfo
                    .ItemID = ItemID.Value
                    .CreateDate = DateTime.Now
                    .ByUser = Me.UserInfo.Username
                    .StatusID = Status
                    .ProcessName = "--> Xóa tin"
                    .IPTrack = Request.ServerVariables("REMOTE_ADDR")
                    .Type = 1
                End With
                ObjController.CMS_News_Process_Add(ddlPortal.SelectedValue, objProcessInfo)

                'Đồng bộ
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

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
            litNB.Text = ""
            nbInfo = ObjController.CMS_News_NB_Get_By_NewsID(ddlPortal.SelectedValue, flReg.WriteNumber(ItemID.Value), CategoryType.Album)
            If Not IsNothing(nbInfo) Then
                drMaDMTin.SelectedValue = nbInfo.DM_ID
                NB_ID.Value = nbInfo.ID
                arr = ObjController.CMS_News_NBDetail_List_By_NewsNBID(ddlPortal.SelectedValue, NB_ID.Value)
                If arr.Count > 0 Then
                    cv = 1
                    For Each Cr As CMS_News_NBDetailInfo In arr
                        litNB.Text += "<tr class='tr-nb-row' id='" & Cr.ID & "'>"
                        litNB.Text += "<td style='text-align: center;'>" & cv & "</td>"
                        litNB.Text += "<td><div class='money-div txt-center MaDM-" & Cr.ID & "'>" & Cr.MaDM & "</div></td>"
                        litNB.Text += "<td><div class='money-div txt-center HeSo-" & Cr.ID & "'>" & Cr.HeSo & "</div></td>"
                        litNB.Text += "<td><input type='text' value='" & Cr.SoLuong & "' onchange='updatePrice(" & Cr.HeSo & "," & Cr.DonGia & ",this," & Cr.ID & ");' class='form-control validate[custom[number]] SoLuong-" & Cr.ID & "''></td>"
                        litNB.Text += "<td><div class='money-div txt-center DonGia-" & Cr.ID & "'>" & Cr.DonGia & "</div></td>"
                        litNB.Text += "<td><div class='money-div txt-center money-" & Cr.ID & "'>" & Cr.Price & "</div></td>"
                        litNB.Text += "</tr>"
                        cv += 1
                    Next
                Else
                    cv = 1
                    For Each Cr As CMS_DMNhuanButInfo In LoadDM(2)
                        litNB.Text += "<tr class='tr-nb-row' id='" & Cr.ID & "'>"
                        litNB.Text += "<td style='text-align: center;'>" & cv & "</td>"
                        litNB.Text += "<td><div class='money-div txt-center MaDM-" & Cr.ID & "'>" & Cr.MaDM & "</div></td>"
                        litNB.Text += "<td><div class='money-div txt-center HeSo-" & Cr.ID & "'>" & Cr.HeSo & "</div></td>"
                        litNB.Text += "<td><input type='text' onchange='updatePrice(" & Cr.HeSo & "," & Cr.DonGia & ",this," & Cr.ID & ");' class='form-control validate[custom[number]] SoLuong-" & Cr.ID & "''></td>"
                        litNB.Text += "<td><div class='money-div txt-center DonGia-" & Cr.ID & "'>" & Cr.DonGia & "</div></td>"
                        litNB.Text += "<td><div class='money-div txt-center money-" & Cr.ID & "'></div></td>"
                        litNB.Text += "</tr>"
                        cv += 1
                    Next
                End If
            Else
                cv = 1
                For Each Cr As CMS_DMNhuanButInfo In LoadDM(2)
                    litNB.Text += "<tr class='tr-nb-row' id='" & Cr.ID & "'>"
                    litNB.Text += "<td style='text-align: center;'>" & cv & "</td>"
                    litNB.Text += "<td><div class='money-div txt-center MaDM-" & Cr.ID & "'>" & Cr.MaDM & "</div></td>"
                    litNB.Text += "<td><div class='money-div txt-center HeSo-" & Cr.ID & "'>" & Cr.HeSo & "</div></td>"
                    litNB.Text += "<td><input type='text' onchange='updatePrice(" & Cr.HeSo & "," & Cr.DonGia & ",this," & Cr.ID & ");' class='form-control validate[custom[number]] SoLuong-" & Cr.ID & "''></td>"
                    litNB.Text += "<td><div class='money-div txt-center DonGia-" & Cr.ID & "'>" & Cr.DonGia & "</div></td>"
                    litNB.Text += "<td><div class='money-div txt-center money-" & Cr.ID & "'></div></td>"
                    litNB.Text += "</tr>"
                    cv += 1
                Next
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

#End Region
    End Class
End Namespace