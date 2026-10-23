Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules
    Public MustInherit Class Read
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController
        Dim obj As New CMS_JobUserInfo
        Dim obj1 As New CMS_JobViewInfo
        Dim arr As New ArrayList
        Dim UrlAlias As String = flReg.UrlAlias
        Dim str() As String, careInfo As CMS_CareerInfo
        Private Sub GetID()
            ItemID.Value = Request.Item("itemid")
            Das.Value = Request.Item("Das")

            objController.CMS_JobUser_Update_View(PortalId, ItemID.Value)
            obj = CType(flCache.GetCache("CMS_JobUser_Get_" & ItemID.Value), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = New WorkController().CMS_JobUser_Get(PortalId, ItemID.Value)
                flCache.SetCache("CMS_JobUser_Get_" & ItemID.Value, obj, SecondCache.M30)
            End If
            If Das.Value <> "" Then
                ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName
            Else
                ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit")
            End If
            litHotline.Text = "<strong>Liên hệ Hotline hỗ trợ Nhà tuyển dụng:</strong>&nbsp;<a href=""tel:" & CMS.flCheck.SetupValue(0, "NTD_Hotline") & """ class=""hotline"" title=""Hotline"">" & CMS.flCheck.SetupValue(0, "NTD_Hotline") & "</a>"
        End Sub
        Private Sub LoadValue()
            Call GetID()
            If IsNothing(obj) = False Then
                Title.Text = obj.Title
                JobUser_Vn.Text = flReg.GetUserName(obj.UserAdmin, Me.PortalId)
                JobUser_Img.Text = "<img src='" & flCheck.JobUser_Avatar(obj.PortalID, obj.JobUser_ID) & "?w=160' alt='" & obj.Title & "' />"

                litInfo.Text = ""

                litInfo.Text += "<div class='col-md-12'>"
                litInfo.Text += "<p class='line-icon mb_12'>"
                litInfo.Text += "<i class='icon-position icon_16'></i><span class='pl_28'>Chức vụ: "
                litInfo.Text += "<span class='job_value'>" & flDic.Position_Name(Me.PortalId, obj.LevelDesired) & "</span>"
                litInfo.Text += "</span>"
                litInfo.Text += "</p></div>"

                litInfo.Text += "<div class='col-md-12'>"
                litInfo.Text += "<p class='line-icon mb_12'>"
                litInfo.Text += "<i class='icon-money icon_16'></i><span class='pl_28'>Mức lương: "
                litInfo.Text += "<span class='job_value'>" & flCheck.Salary_Name(Me.PortalId, obj.Salary_ID) & "</span>"
                litInfo.Text += "</span>"
                litInfo.Text += "</p></div>"

                litInfo.Text += "<div class='col-md-12'>"
                litInfo.Text += "<p class='line-icon mb_12'>"
                litInfo.Text += "<i class='icon-age icon_16'></i><span class='pl_28'>Nhu cầu làm việc: "
                litInfo.Text += "<span class='job_value'>" & flCheck.Needs_Name(Me.PortalId, obj.Needs_ID) & "</span>"
                litInfo.Text += "</span>"
                litInfo.Text += "</p></div>"

                litCin.Text = "<div class='col-md-12'>"
                litCin.Text += "<p class='line-icon mb_12'>"
                litCin.Text += "<i class='icon-address icon_16'></i><span class='pl_28'>Nơi làm việc: "
                litCin.Text += "<span class='job_value'>" & flDic.RegionalName(Me.PortalId, obj.TinhTP, obj.QuanHuyen) & "</span>"
                litCin.Text += "</span>"
                litCin.Text += "</p></div>"

                litCin.Text += "<div class='col-md-12'>"
                litCin.Text += "<p class='line-icon mb_12'>"
                litCin.Text += "<i class='icon-career icon_16'></i><span class='pl_28'>Ngành nghề: "
                'litCin.Text += "<span class='job_value'>" & flCheck.Career_Name(Me.PortalId, obj.Career_ID) & "</span>"
                litCin.Text += "<span class='job_value'>" & CareerMultiName(obj.Career_ID) & "</span>"
                litCin.Text += "</span>"
                litCin.Text += "</p></div>"

                litCin.Text += "<div class='col-md-12'>"
                litCin.Text += "<p class='line-icon mb_12'>"
                litCin.Text += "<i class='icon-countdown icon_16'></i><span class='pl_28'>Ngày đăng tin: "
                litCin.Text += "<span class='job_value'>" & flReg.ReadDate(obj.StartDate, False) & "</span>"
                litCin.Text += "</span>"
                litCin.Text += "</p></div>"

                ltTrinhDo.Text = "<p class='line-icon mb_12'>"
                ltTrinhDo.Text += "<i class='icon-exp icon_16'></i><span class='pl_28'>Kinh nghiệm làm việc: </span>"
                ltTrinhDo.Text += "<span class='job-text'>" & flCheck.Experience_Name(Me.PortalId, obj.Experience_ID) & "</span>"
                ltTrinhDo.Text += "</p>"

                ltTrinhDo.Text += "<p class='line-icon mb_12'>"
                ltTrinhDo.Text += "<i class='icon-edu icon_16'></i><span class='pl_28'>Trình độ học vấn</span>"
                ltTrinhDo.Text += "</p>"
                ltTrinhDo.Text += "<p class='job-text'>" & obj.Education.Replace(vbCrLf, "<br/>") & "</p>"

                ltTrinhDo.Text += "<p class='line-icon mb_12'>"
                ltTrinhDo.Text += "<i class='icon-edu icon_16'></i><span class='pl_28'>Trình độ chuyên môn: </span>"
                ltTrinhDo.Text += "<span class='job-text'>" & flDic.Education_Name(Me.PortalId, obj.Level_ID) & "</span>"
                ltTrinhDo.Text += "</p>"

                ltTrinhDo.Text += "<p class='line-icon mb_12'>"
                ltTrinhDo.Text += "<i class='icon-exp icon_16'></i><span class='pl_28'>Kinh nghiệm làm việc</span>"
                ltTrinhDo.Text += "</p>"
                ltTrinhDo.Text += "<p class='job-text'>" & obj.CareerGoals.Replace(vbCrLf, "<br/>") & "</p>"

                ltrMucTieu.Text = "<p class='line-icon mb_12'>"
                ltrMucTieu.Text += "<i class='icon-age icon_16'></i><span class='pl_28'>Mục tiêu nghề nghiệp</span>"
                ltrMucTieu.Text += "</p>"
                ltrMucTieu.Text += "<p class='text-jobus'>" & obj.WorkExperience.Replace(vbCrLf, "<br/>") & "</p>"

                ltrMucTieu.Text += "<p class='line-icon mb_12'>"
                ltrMucTieu.Text += "<i class='icon-career icon_16'></i><span class='pl_28'>Kỹ năng sở trường</span>"
                ltrMucTieu.Text += "</p>"
                ltrMucTieu.Text += "<p class='text-jobus'>" & obj.SkillsForte.Replace(vbCrLf, "<br/>") & "</p>"

                If flCheck.CheckInJobView(Me.PortalId, obj.JobUser_ID, flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)) Then
                    saveJobView.Visible = False
                    litTB.Text = "<span title='Hồ sơ đã lưu' class='panel-save'><i class=""fa fa-star pdr10"" ></i>Hồ sơ đã lưu </span>"
                Else
                    saveJobView.Visible = True
                    litTB.Text = ""
                End If
                If flCheck.CheckInJobInvite(Me.PortalId, obj.JobUser_ID, flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)) Then
                    lbJobInvite.Visible = False
                    litMUV.Text = "<span title='Hồ sơ đã mời' class='panel-moi'><i class=""fa fa-star pdr10"" ></i>Hồ sơ đã mời </span>"
                Else
                    lbJobInvite.Visible = True
                    litMUV.Text = ""
                End If
                Dim pInfo As New CMS_ProfileSaveInfo
                pInfo.ProfileSave_ID = flReg.GenKey()
                pInfo.JobUser_ID = obj.JobUser_ID
                pInfo.Business_ID = flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
                pInfo.UserName = Me.UserInfo.Username
                pInfo.CreateDate = Now
                objController.CMS_ProfileSave_Add(PortalId, pInfo)

            End If
        End Sub
        Private Function CareerMultiName(id As String) As String
            CareerMultiName = ""
            Dim str() As String = id.Split(",")
            For i = 0 To str.Count - 1
                If String.IsNullOrEmpty(str(i)) = False Then
                    CareerMultiName += flCheck.Career_Name(Me.PortalId, str(i)) & IIf(i = str.Count - 1, "", ", ")
                End If
            Next
        End Function
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not IsPostBack Then
                Try
                    Call LoadValue()
                Catch ex As Exception
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "works") & "', 'Thông báo', false);", True)
                End Try
            End If
        End Sub

        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub

        Private Sub saveJobView_Click(sender As Object, e As EventArgs) Handles saveJobView.Click
            Try
                Dim jInfo As New CMS_JobViewInfo
                jInfo.JobView_ID = flReg.GenKey()
                jInfo.IdKey = ItemID.Value
                jInfo.IdName = Title.Text
                jInfo.UserName = flCheck.Business_ID(Me.PortalId, Me.UserInfo.Username)
                jInfo.CreateDate = Now
                jInfo.IsFlag = JobView.DoanhNghiepLuu
                objController.CMS_JobView_Add(Me.PortalId, jInfo)
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Thong_Bao", "<script type='text/javascript'> toogleModal('.nhs_replace_success',true);</script>", False)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "works") & "', 'Thông báo', false);", True)
            End Try

        End Sub

        Private Sub lbJobInvite_Click(sender As Object, e As EventArgs) Handles lbJobInvite.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/job-invite/jobid/" & ItemID.Value, True)
        End Sub
    End Class

End Namespace