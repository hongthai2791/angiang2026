Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim arrTemp As New ArrayList
        Dim objController As New WorkController()
        Dim obj As New CMS_WorkInfo
        Dim objOld As New CMS_WorkInfo
        Dim buInfo As New CMS_BusinessInfo
        Dim str() As String

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub SendMail(email As String, buID As String)
            Dim subject As String = "VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & ": Việc làm phù hợp."
            Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
            body += "<p>Chào bạn</p>"
            body += "<p>VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & " giới thiệu đến bạn những việc làm mới từ các nhà tuyển dụng hàng đầu</p>"
            body += "<p>Doanh nghiệp: <b><a href='" & flReg.UrlAlias & flCheck.GetHomeLinkBusiness(buID) & "'>" & Business_Name.Text & "</a></b></p>"
            body += "<p>Việc làm mới: <a href='" & flReg.UrlAlias & flCheck.GetHomeLinkWork(Title.Text.Trim, ItemID.Value) & "' title='" & Title.Text.Trim & "'>"
            body += Title.Text.Trim & "</a></p>"
            body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
            body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
            body += "Ban quản trị VL-" & flDic.Regional_Name(Me.PortalId, TinhTP.SelectedValue) & "</div>"
            flDnn.DNN_SendMail(email, subject, body)
        End Sub
        Private Sub SendMailAuto(buID As String)
            Try
                arrTemp = objController.CMS_JobUser_List_SendMail(Me.PortalId, CareerID.Value, 0)
                Dim sMail As String = ""
                For Each Cr As CMS_JobUserInfo In arrTemp
                    For Each Ck As DnnInfo In flDnn.DNN_User_Get(Me.PortalId, Cr.UserAdmin)
                        sMail += Ck.Email & ";"
                    Next
                Next
                Call SendMail(sMail, buID)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub InitControls()
            cmdDelete.Attributes.Add("onclick", "javascript:return confirm('Bạn có muốn xóa nội dung này không?');")
            ItemID.Value = Request.Item("itemid")
            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTPMulti, "")

            If flReg.WebConfig("TinhTP") <> "0" Then TinhTPMulti.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTPMulti.SelectedValue = Request.Item("tp")


            Call flFunction.LoadSalary(Me.PortalId, Salary_ID)
            Call flFunction.LoadExperience(Me.PortalId, Experience_ID)
            Call flFunction.LoadGender(Gender, "")
            Call flDic.LoadEducation(Me.PortalId, Level_ID)
            Call flDic.LoadPosition(Me.PortalId, LevelDesired)
            Call flFunction.LoadTypeOf(Me.PortalId, TypeOf_ID)
            Call flFunction.LoadJobPlace(Me.PortalId, JobPlace)
            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "")
            ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/bus-works-list"
            Call LoadBus()
            If Me.PortalSettings.ActiveTab.TabName = "users" Then
                ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit")
                cmdDelete.Visible = False
                cmdUpdate.Visible = False
            End If
        End Sub
        Private Sub LoadBus()
            Business_ID.Value = flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
            buInfo = objController.CMS_Business_Get(Me.PortalId, Business_ID.Value)
            If IsNothing(buInfo) = False Then
                'Business_Name.Text = buInfo.Business_Vn

                Business_Name.Text = flReg.RemoveScript(buInfo.Business_Vn, False)
                ContactAddress.Text = flReg.RemoveScript(buInfo.Address, False)
                ContactUser.Text = flReg.RemoveScript(buInfo.ContactUser, False)
                ContactMobile.Text = buInfo.ContactMobile
                ContactEmail.Text = buInfo.ContactEmail
                TinhTP.SelectedValue = buInfo.TinhTP
                TinhTPMulti.SelectedValue = buInfo.TinhTP
            End If
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Private Sub LoadValue()
            obj = objController.CMS_Work_Get(Me.PortalId, ItemID.Value)
            If IsNothing(obj) = False Then
                Title.Text = obj.Title
                Salary_ID.SelectedValue = obj.Salary_ID
                Quantity.Text = obj.Quantity
                Experience_ID.SelectedValue = obj.Experience_ID
                Gender.SelectedValue = obj.Gender
                Level_ID.SelectedValue = obj.Level_ID
                HidTinhTP.Value = obj.TinhTP
                If HidTinhTP.Value.Contains(",") Then
                    chkMultiple.Checked = True

                    divSelectTP.Attributes.Remove("class")
                    divSelectTP.Attributes.Add("class", "col-md-8")
                    TinhTPMulti.CssClass = "selectpicker TinhTP2 validate[required]"
                    TinhTP.Visible = False
                Else
                    TinhTPMulti.CssClass = "none selectpicker TinhTP2 validate[required]"

                    divSelectTP.Attributes.Remove("class")
                    divSelectTP.Attributes.Add("class", "col-md-4")

                    TinhTP.SelectedValue = HidTinhTP.Value
                    chkMultiple.Checked = False
                End If
                TypeOf_ID.SelectedValue = obj.TypeOf_ID
                CareerID.Value = obj.Career_ID
                LevelDesired.SelectedValue = obj.LevelDesired_ID
                JobPlace.SelectedValue = obj.JobPlace
                Description.Text = obj.Description
                Requirement.Text = obj.Requirement
                Benefit.Text = obj.Benefit
                RequirementsProfile.Text = obj.RequirementsProfile
                ExpiredDate.Text = flReg.ReadDate(obj.ExpiredDate, False)
                SubmissionSend.Text = obj.SubmissionSend
                StartDate.Text = flReg.ReadDate(obj.StartDate, False)
                EndDate.Text = flReg.ReadDate(obj.EndDate, False)
                ContactUser.Text = flReg.RemoveScript(obj.ContactUser, False)
                ContactAddress.Text = flReg.RemoveScript(obj.ContactAddress, False)
                ContactMobile.Text = obj.ContactMobile
                ContactEmail.Text = obj.ContactEmail
                ContactDes.Text = obj.ContactDes
                IsHot.Checked = obj.IsHot
                IsFast.Checked = obj.IsFast
                IsUrgent.Checked = obj.IsUrgent
                IsApproval.Checked = obj.IsApproval
                Ages.Text = flReg.RemoveScript(obj.Ages, False)
                WorkTime.Text = flReg.RemoveScript(obj.WorkTime, False)
                litUpdate.Text = "<div Class=""cmsUpdate"">Ngày tạo:    " & flReg.ReadDate(obj.CreatedDate)
                litUpdate.Text += " - bởi: " & obj.CreatedUser & " - " & flReg.GetUserName(obj.CreatedUser) & "</div>"
                If obj.UpdatedUser <> "" Then
                    litUpdate.Text += "<div class=""cmsUpdate"">Thay đổi lần cuối ngày: " & flReg.ReadDate(obj.UpdatedDate)
                    litUpdate.Text += " - bởi: " & obj.UpdatedUser & " - " & flReg.GetUserName(obj.UpdatedUser) & "</div>"
                End If
            Else
                cmdDelete.Visible = False
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub
        Private Sub SaveWorkCarrer()
            objController.CMS_WorkCareer_Delete_By_CMS_Work(Me.PortalId, ItemID.Value)
            str = CareerID.Value.Split(",")
            Dim wcInfo As New CMS_WorkCareerInfo
            For i As Integer = 0 To str.Length - 1
                If str(i) <> "" Then
                    wcInfo = New CMS_WorkCareerInfo
                    wcInfo.Career_ID = str(i)
                    wcInfo.Work_ID = ItemID.Value
                    objController.CMS_WorkCareer_Add(Me.PortalId, wcInfo)
                End If
            Next
        End Sub

        Private Function GetStringObject(obj As CMS_WorkInfo) As String
            GetStringObject = obj.Title.ToString() + obj.Career_ID.ToString() + obj.Salary_ID.ToString() + obj.Quantity.ToString()
            GetStringObject += obj.TinhTP.ToString() + obj.QuanHuyen.ToString() + obj.Experience_ID.ToString() + obj.Level_ID.ToString()
            GetStringObject += obj.Salary_ID.ToString() + obj.TypeOf_ID.ToString() + obj.JobPlace.ToString() + obj.Description.ToString()
            GetStringObject += obj.Requirement.ToString() + obj.Benefit.ToString() + obj.RequirementsProfile.ToString() + obj.ExpiredDate.ToString()
            GetStringObject += obj.SubmissionSend.ToString() + obj.StartDate.ToString() + obj.EndDate.ToString() + obj.ContactUser.ToString()
            GetStringObject += obj.ContactAddress.ToString() + obj.ContactMobile.ToString() + obj.ContactEmail.ToString() + obj.ContactDes.ToString()
            GetStringObject += obj.IsHot.ToString() + obj.IsFast.ToString() + obj.IsUrgent.ToString() + obj.LevelDesired_ID.ToString()
        End Function

        Private Function CompareObject(objNew As CMS_WorkInfo, objOld As CMS_WorkInfo) As Boolean
            CompareObject = False
            If String.Compare(GetStringObject(objNew).Trim, GetStringObject(objOld).Trim) > 0 Then
                CompareObject = True
            End If
        End Function
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "")
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                If flReg.WriteDate(EndDate.Text, False) < flReg.WriteDate(StartDate.Text, False) Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('warning', 'Ngày hết hạn đăng phải lớn hơn hoặc bằng ngày bắt đầu!', 'Thông báo', false);", True)
                    Exit Sub
                End If
                If flReg.WriteDate(ExpiredDate.Text, False) < flReg.WriteDate(StartDate.Text, False) Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', 'Hạn nộp hồ sơ phải lớn hơn Đăng từ ngày!', 'Thông báo', false);", True)
                    Exit Sub
                End If
                obj = New CMS_WorkInfo
                obj.Title = Title.Text.Trim
                obj.Business_ID = Business_ID.Value
                obj.Salary_ID = Salary_ID.SelectedValue & ""
                obj.Quantity = flReg.WriteNumber(Quantity.Text)
                obj.Experience_ID = Experience_ID.SelectedValue & ""
                obj.Gender = flReg.WriteNumber(Gender.SelectedValue)
                obj.Level_ID = Level_ID.SelectedValue & ""
                If chkMultiple.Checked = False Then
                    obj.TinhTP = TinhTP.SelectedValue
                    obj.QuanHuyen = HidQuanHuyen.Value & ""
                Else
                    obj.TinhTP = HidTinhTP.Value & ""
                End If
                obj.TypeOf_ID = TypeOf_ID.SelectedValue & ""
                obj.JobPlace = JobPlace.SelectedValue & ""
                obj.Career_ID = CareerID.Value & ""
                obj.Description = Description.Text & ""
                obj.Requirement = Requirement.Text & ""
                obj.Benefit = Benefit.Text & ""
                obj.RequirementsProfile = RequirementsProfile.Text
                obj.ExpiredDate = flReg.WriteDate(ExpiredDate.Text, False)
                obj.SubmissionSend = SubmissionSend.Text & ""
                obj.StartDate = flReg.WriteDate(StartDate.Text, False)
                obj.EndDate = flReg.WriteDate(EndDate.Text, False)
                obj.ContactUser = ContactUser.Text & ""
                obj.ContactAddress = ContactAddress.Text & ""
                obj.ContactMobile = ContactMobile.Text & ""
                obj.ContactEmail = ContactEmail.Text & ""
                obj.ContactDes = ContactDes.Text & ""
                obj.IsHot = IsHot.Checked
                obj.IsFast = IsFast.Checked
                obj.IsUrgent = IsUrgent.Checked
                obj.LevelDesired_ID = LevelDesired.SelectedValue & ""
                obj.Ages = Ages.Text
                obj.WorkTime = WorkTime.Text

                obj.IsDelete = False
                obj.DeletedUser = ""
                obj.DeletedDate = flReg.DateNull

                obj.IsApproval = IsApproval.Checked
                obj.ApprovalUser = Me.UserInfo.Username
                obj.ApprovalDate = Now
                obj.PortalID = Me.PortalId
                obj.IsFlag = WorkFlag.WebFrom
                If ItemID.Value <> "" Then
                    obj.Work_ID = ItemID.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = ""
                    obj.UpdatedUser = Me.UserInfo.Username
                    obj.UpdatedDate = Now
                    objOld = objController.CMS_Work_Get(Me.PortalId, ItemID.Value)
                    objController.CMS_Work_Update(Me.PortalId, obj)
                    If CompareObject(obj, objOld) Then
                        objController.CMS_Work_Update_Quick(Me.PortalId, ItemID.Value, IsHot.Checked, IsFast.Checked, IsUrgent.Checked, False, "", flReg.DateNull)
                    End If
                    flCache.RemoveCache("Work_" & ItemID.Value)
                    flCache.RemoveCache("Work_False" & ItemID.Value)
                    flCache.RemoveCache("Work_True" & ItemID.Value)
                Else 'Update
                    ItemID.Value = flReg.GenKey()
                    obj.Work_ID = ItemID.Value
                    obj.CreatedDate = Now
                    obj.CreatedUser = Me.UserInfo.Username
                    obj.UpdatedDate = flReg.DateNull
                    objController.CMS_Work_Add(Me.PortalId, obj)
                End If
                Call SaveWorkCarrer()
                'Call SendMailAuto(obj.Business_ID)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('success', 'Đã cập nhật lại thông tin thành công!', 'Thông báo', false);backend('" & ViewState("UrlReferrer") & "');", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
            Try
                objController.CMS_Work_Delete(Me.PortalId, ItemID.Value)
                Call BackEnd()
            Catch ex As SqlClient.SqlException
                If ex.Number = 547 Then 'Loi co du lieu lien ket
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', 'Lỗi có dữ liệu liên kết, không thể xóa được.', 'Thông báo', false);", True)
                Else 'Loi xoa du lieu
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)
                End If
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "myFunction", "removewaiting();", True)
            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Private Sub chkMultiple_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiple.CheckedChanged
            If chkMultiple.Checked Then
                TinhTP.Visible = False
                TinhTPMulti.CssClass = "selectpicker TinhTP2 validate[required]"
                divSelectQH.Attributes.Add("class", "none")

                divSelectTP.Attributes.Remove("class")
                divSelectTP.Attributes.Add("class", "col-md-8")

            Else
                TinhTP.Visible = True
                TinhTPMulti.CssClass = "none selectpicker TinhTP2 validate[required]"
                divSelectQH.Attributes.Remove("class")
                divSelectQH.Attributes.Add("class", "col-md-4 divQuanHuyen")

                divSelectTP.Attributes.Remove("class")
                divSelectTP.Attributes.Add("class", "col-md-4")
            End If
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "setMultiple", "setMultiple();", True)
        End Sub
    End Class
End Namespace
