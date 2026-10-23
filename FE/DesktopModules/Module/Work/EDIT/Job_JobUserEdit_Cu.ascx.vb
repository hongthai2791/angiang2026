Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim objController As New WorkController()
        Dim obj As New CMS_JobUserInfo

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub InitControls()
            ItemID.Value = Request.Item("itemid")
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTPMulti, "", "")
            If flReg.WebConfig("TinhTP") <> "0" Then TinhTPMulti.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTPMulti.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
            If Request.Item("qh") <> "" Then QuanHuyen.SelectedValue = Request.Item("qh")
            Call flFunction.LoadSalary(Me.PortalId, Salary_ID)
            Call flFunction.LoadExperience(Me.PortalId, Experience_ID)
            Call flDic.LoadEducation(Me.PortalId, Level_ID)
            Call flFunction.LoadNeeds(Me.PortalId, Needs_ID)
            Call flFunction.LoadCareer(Me.PortalId, Career_ID)
            Call flDic.LoadPosition(Me.PortalId, LevelDesired)
            Call flDic.LoadPosition(Me.PortalId, CurrentLevel)
            Call flFunction.ListUserName(UserAdmin, IsSuper.Value, Me.PortalSettings.ActiveTab.TabName, StatusBus.NguoiTimViec)
            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Private Sub LoadValue()
            obj = objController.CMS_JobUser_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then

                Title.Text = obj.Title

                Career_ID.SelectedValue = obj.Career_ID
                CurrentLevel.SelectedValue = obj.CurrentLevel
                LevelDesired.SelectedValue = obj.LevelDesired
                HidTinhTP.Value = obj.TinhTP
                If HidTinhTP.Value.Contains(",") Then
                    chkMultiple.Checked = True
                    divSelectQH.Attributes.Add("class", "none")

                    divSelectTP.Attributes.Remove("class")
                    divSelectTP.Attributes.Add("class", "col-md-10")
                    TinhTPMulti.CssClass = "selectpicker TinhTP2 validate[required]"
                    TinhTP.Visible = False
                Else
                    TinhTPMulti.CssClass = "none selectpicker TinhTP2 validate[required]"
                    divSelectQH.Attributes.Remove("class")
                    divSelectQH.Attributes.Add("class", "col-md-7 divQuanHuyen")

                    divSelectTP.Attributes.Remove("class")
                    divSelectTP.Attributes.Add("class", "col-md-3")

                    TinhTP.SelectedValue = HidTinhTP.Value
                    chkMultiple.Checked = False
                    Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "")
                    HidQuanHuyen.Value = obj.QuanHuyen
                End If


                UserAdmin.SelectedValue = obj.UserAdmin
                imgDD.InnerHtml = "<img class=""vImg"" src=""" & flDic.PhotoURLFile(UserAdmin.SelectedValue, 4) & "?w=120"" alt=""Ảnh đại diện"" />"

                Experience_ID.SelectedValue = obj.Experience_ID
                Level_ID.SelectedValue = obj.Level_ID
                Salary_ID.SelectedValue = obj.Salary_ID
                Needs_ID.SelectedValue = obj.Needs_ID
                Education.Content = obj.Education
                CareerGoals.Content = obj.CareerGoals
                WorkExperience.Content = obj.WorkExperience
                SkillsForte.Content = obj.SkillsForte
                StartDate.Text = flReg.ReadDate(obj.StartDate, False)
                EndDate.Text = flReg.ReadDate(obj.EndDate, False)


                IsApproval.Checked = obj.IsApproval
                litUpdate.Text = "<div class=""cmsUpdate"">Ngày tạo:    " & flReg.ReadDate(obj.CreatedDate)
                litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                If obj.UpdatedUser <> "" Then
                    litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                    litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                End If
                If Me.UserInfo.Username <> obj.CreatedUser Then cmdDelete.Visible = False
                If obj.IsBHTN Then pnUserAdmin.Visible = False
            Else
                imgDD.InnerHtml = "<img class=""vImg"" src=""" & flDic.PhotoURLFile(UserAdmin.SelectedValue, 4) & "?w=120"" alt=""Ảnh đại diện"" />"
                cmdDelete.Visible = False
            End If
            Education.Content += "&nbsp;"
            CareerGoals.Content += "&nbsp;"
            WorkExperience.Content += "&nbsp;"
            SkillsForte.Content += "&nbsp;"
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)

        End Sub
        Private Sub SendMail(email As String)
            Dim subject As String = "VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & ": Ứng viên phù hợp."
            Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
            body += "<p>Chào bạn</p>"
            body += "<p>VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & " giới thiệu đến bạn những ứng viên mới phù hợp với nhu cầu tuyển dụng của quý vị.</p>"
            body += "<p>Ứng viên: <b>" & flReg.GetUserName(UserAdmin.SelectedValue) & "</b></p>"
            body += "<p>Hồ sơ tìm việc: <a href='" & flReg.UrlAlias & flCheck.GetLinkProfile(Title.Text, ItemID.Value) & "' title='" & Title.Text.Trim & "'>"
            body += Title.Text.Trim & "</a></p>"
            body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
            body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
            body += "Ban quản trị VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & "</div>"
            flDnn.DNN_SendMail(email, subject, body)
        End Sub
        Private Sub SendMailAuto()
            Try
                arrTemp = objController.CMS_JobUser_List_SendMail(Me.PortalId, Career_ID.SelectedValue, 1)
                Dim sMail As String = ""
                For Each Cr As CMS_JobUserInfo In arrTemp
                    sMail += Cr.UserAdmin & ";"
                Next
                Call SendMail(sMail)
            Catch ex As Exception
            End Try
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                If flReg.WriteDate(EndDate.Text, False) < flReg.WriteDate(StartDate.Text, False) Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('warning', 'Ngày đăng phải diễn ra trước ngày hết hạn!', 'Thông báo', false);", True)
                    Exit Sub
                End If
                obj = New CMS_JobUserInfo
                obj.Title = Title.Text.Trim

                obj.Career_ID = Career_ID.SelectedValue
                obj.CurrentLevel = CurrentLevel.SelectedValue
                obj.LevelDesired = LevelDesired.SelectedValue

                If chkMultiple.Checked = False Then
                    obj.TinhTP = TinhTP.SelectedValue
                    obj.QuanHuyen = HidQuanHuyen.Value & ""
                Else
                    obj.TinhTP = HidTinhTP.Value & ""
                End If
                obj.Experience_ID = Experience_ID.SelectedValue
                obj.Level_ID = Level_ID.SelectedValue
                obj.Salary_ID = Salary_ID.SelectedValue
                obj.Needs_ID = Needs_ID.SelectedValue
                obj.Education = Education.Content
                obj.CareerGoals = CareerGoals.Content
                obj.WorkExperience = WorkExperience.Content
                obj.SkillsForte = SkillsForte.Content
                obj.UserAdmin = UserAdmin.SelectedValue
                obj.StartDate = flReg.WriteDate(StartDate.Text, False)
                obj.EndDate = flReg.WriteDate(EndDate.Text, False)

                obj.IsDelete = False
                obj.DeletedUser = ""
                obj.DeletedDate = flReg.DateNull

                obj.IsApproval = IsApproval.Checked
                obj.ApprovalUser = UserInfo.Username
                obj.ApprovalDate = Now
                obj.PortalID = Me.PortalId
                If ItemID.Value <> "" Then
                    obj.JobUser_ID = ItemID.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = ""
                    obj.UpdatedUser = UserInfo.Username
                    obj.UpdatedDate = Now
                    objController.CMS_JobUser_Update(Me.PortalId, obj)
                Else 'Update
                    obj.JobUser_ID = flReg.GenKey()
                    obj.CreatedDate = Now
                    obj.CreatedUser = UserInfo.Username
                    obj.UpdatedDate = flReg.DateNull
                    objController.CMS_JobUser_Add(Me.PortalId, obj)
                End If
                Call SendMailAuto()
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.CMS_JobUser_Delete(Me.PortalId, ItemID.Value)
                Call BackEnd()
            Catch exc As SqlClient.SqlException
                If exc.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, exc.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
                End If
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Protected Sub UserAdmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserAdmin.SelectedIndexChanged
            imgDD.InnerHtml = "<img class=""vImg"" src=""" & flDic.PhotoURLFile(UserAdmin.SelectedValue, Me.PortalId) & "?w=120"" alt=""Ảnh đại diện"" />"
        End Sub

        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "")
        End Sub
        Private Sub chkMultiple_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiple.CheckedChanged
            If chkMultiple.Checked Then
                TinhTP.Visible = False
                TinhTPMulti.CssClass = "selectpicker TinhTP2 validate[required]"
                divSelectQH.Attributes.Add("class", "none")

                divSelectTP.Attributes.Remove("class")
                divSelectTP.Attributes.Add("class", "col-md-10")

            Else
                TinhTP.Visible = True
                TinhTPMulti.CssClass = "none selectpicker TinhTP2 validate[required]"
                divSelectQH.Attributes.Remove("class")
                divSelectQH.Attributes.Add("class", "col-md-7 divQuanHuyen")

                divSelectTP.Attributes.Remove("class")
                divSelectTP.Attributes.Add("class", "col-md-3")
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub
    End Class



End Namespace
