Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports Rainbow.MergeEngine

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim objController As New WorkController()
        Dim obj As New CMS_JobUserInfo
        Dim objOld As New CMS_JobUserInfo

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub InitControls()
            ItemID.Value = Request.Item("itemid")
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTPMulti, "")
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
            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/us-jobuser-list"
            If Me.PortalSettings.ActiveTab.TabName = "business" Then
                ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit")
                cmdDelete.Visible = False
                cmdUpdate.Visible = False
            End If
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
                imgDD.InnerHtml = "<img class=""vImg"" src=""" & flDic.PhotoURLFile(Me.UserInfo.Username, Me.PortalId) & "?w=120"" alt=""Ảnh đại diện"" />"
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
            End If
            imgDD.InnerHtml = "<img class=""vImg"" src=""" & flDic.PhotoURLFile(Me.UserInfo.Username, Me.PortalId) & "?w=120"" alt=""Ảnh đại diện"" />"
            Education.Content += "&nbsp;"
            CareerGoals.Content += "&nbsp;"
            WorkExperience.Content += "&nbsp;"
            SkillsForte.Content += "&nbsp;"
            Call LoadRefer()
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub
        Private Sub LoadRefer()

        End Sub
        Private Sub SendMail(email As String)
            Dim subject As String = "VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & ": Ứng viên phù hợp."
            Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
            body += "<p>Chào bạn</p>"
            body += "<p>VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & " giới thiệu đến bạn những ứng viên mới phù hợp với nhu cầu tuyển dụng của quý vị.</p>"
            body += "<p>Ứng viên: <b>" & flReg.GetUserName(Me.UserInfo.Username) & "</b></p>"
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

        Private Function GetStringObject(obj As CMS_JobUserInfo) As String
            GetStringObject = obj.Title.ToString() + obj.Career_ID.ToString() + obj.CurrentLevel.ToString() + obj.LevelDesired.ToString()
            GetStringObject += obj.TinhTP.ToString() + obj.QuanHuyen.ToString() + obj.Experience_ID.ToString() + obj.Level_ID.ToString()
            GetStringObject += obj.Salary_ID.ToString() + obj.Needs_ID.ToString() + obj.Education.ToString() + obj.CareerGoals.ToString()
            GetStringObject += obj.WorkExperience.ToString() + obj.SkillsForte.ToString()
        End Function
        Private Function CompareObject(objNew As CMS_JobUserInfo, objOld As CMS_JobUserInfo) As Boolean
            CompareObject = False
            If String.Compare(GetStringObject(objNew).Trim, GetStringObject(objOld).Trim) > 0 Then
                CompareObject = True
            End If
        End Function
        Private Sub SaveRefer()
            Dim objData1 = New CMS_JobUserReferInfo
            objData1.ID = HF_NTK1_ID.Value
            objData1.JobUserID = ItemID.Value
            objData1.HoTen = NTK1_HoTen.Text
            objData1.ChucVu = NTK1_ChucVu.Text
            objData1.NoiCongTac = NTK1_NoiCongTac.Text
            objData1.SoDienThoai = NTK1_SoDienThoai.Text
            objData1.Email = NTK1_Email.Text
            objData1.MoiQuanHe = NTK1_MoiQuanHe.Text

            If HF_NTK1_ID.Value > 0 Then
                objController.CMS_JobUserRefer_Update(Me.PortalId, objData1)
            Else

                objController.CMS_JobUserRefer_Add(Me.PortalId, objData1)
            End If
            Dim objData2 = New CMS_JobUserReferInfo
            objData2.ID = HF_NTK2_ID.Value
            objData2.JobUserID = ItemID.Value
            objData2.HoTen = NTK2_HoTen.Text
            objData2.ChucVu = NTK2_ChucVu.Text
            objData2.NoiCongTac = NTK2_NoiCongTac.Text
            objData2.SoDienThoai = NTK2_SoDienThoai.Text
            objData2.Email = NTK2_Email.Text
            objData2.MoiQuanHe = NTK2_MoiQuanHe.Text
            If HF_NTK2_ID.Value > 0 Then
                objController.CMS_JobUserRefer_Update(Me.PortalId, objData2)
            Else

                objController.CMS_JobUserRefer_Add(Me.PortalId, objData2)
            End If
        End Sub
        Private Function GenHisName(objOld As CMS_JobUserInfo, objNew As CMS_JobUserInfo) As String
            GenHisName = ""
            If objOld.Title <> objNew.Title Then
                GenHisName = "Thay đổi tiêu đề hồ sơ"
            ElseIf objOld.Career_ID <> objNew.Career_ID Then
                GenHisName = "Thay đổi ngành nghề tuyển dụng"
            ElseIf objOld.LevelDesired <> objNew.LevelDesired Then
                GenHisName = "Thay đổi chức vụ mong muốn"
            ElseIf objOld.CurrentLevel <> objNew.CurrentLevel Then
                GenHisName = "Thay đổi chức vụ hiện tại"
            ElseIf objOld.Experience_ID <> objNew.Experience_ID Then
                GenHisName = "Thay đổi kinh nghiệm làm việc"
            ElseIf objOld.Level_ID <> objNew.Level_ID Then
                GenHisName = "Thay đổi trình độ"
            ElseIf objOld.Salary_ID <> objNew.Salary_ID Then
                GenHisName = "Thay đổi mức lương"
            ElseIf objOld.Needs_ID <> objNew.Needs_ID Then
                GenHisName = "Thay đổi nhu cầu làm việc"
            Else
                If objOld.SkillsForte <> objNew.SkillsForte Or objOld.Education <> objNew.Education Or objOld.WorkExperience <> objNew.WorkExperience Then
                    GenHisName = "Thay đổi các thông tin khác"
                End If
            End If
        End Function
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
                obj.UserAdmin = Me.UserInfo.Username
                obj.StartDate = flReg.WriteDate(StartDate.Text, False)
                obj.EndDate = flReg.WriteDate(EndDate.Text, False)

                obj.IsDelete = False
                obj.DeletedUser = ""
                obj.DeletedDate = flReg.DateNull

                obj.IsApproval = IsApproval.Checked
                obj.ApprovalUser = UserInfo.Username
                obj.ApprovalDate = Now
                obj.PortalID = Me.PortalId
                If ItemID.Value <> "" Then 'Update
                    obj.JobUser_ID = ItemID.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = ""
                    obj.UpdatedUser = UserInfo.Username
                    obj.UpdatedDate = Now
                    objOld = objController.CMS_JobUser_Get(Me.PortalId, ItemID.Value)
                    objController.CMS_JobUser_Update(Me.PortalId, obj)
                    If CompareObject(obj, objOld) Then
                        objController.CMS_JobUser_Update_Quick(Me.PortalId, ItemID.Value, False, "", flReg.DateNull)
                    End If
                Else
                    ItemID.Value = flReg.GenKey()
                    obj.JobUser_ID = ItemID.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = UserInfo.Username
                    obj.UpdatedDate = flReg.DateNull
                    objController.CMS_JobUser_Add(Me.PortalId, obj)
                End If
                Call SaveRefer()
                'Call SendMailAuto()
                Call BackEnd()
            Catch ex As Exception
                litUpdate.Text = ex.Message
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & " Vui lòng quay lại sau!', 'Thông báo', false);", True)
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
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, exc.Message, "work") & " Vui lòng quay lại sau!', 'Thông báo', false);", True)
                End If
            End Try

        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
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

        Protected Sub btnXoa1_Click(sender As Object, e As EventArgs)
            Try
                objController.CMS_JobUserRefer_Delete(Me.PortalId, HF_NTK1_ID.Value)
            Catch ex As Exception

            End Try
        End Sub

        Protected Sub btnXoa2_Click(sender As Object, e As EventArgs)
            Try
                objController.CMS_JobUserRefer_Delete(Me.PortalId, HF_NTK2_ID.Value)

            Catch ex As Exception

            End Try
        End Sub
    End Class

End Namespace
