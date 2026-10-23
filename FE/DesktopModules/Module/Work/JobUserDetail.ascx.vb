Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules
    Public MustInherit Class Read
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController
        Public strFb, linkSend As String
        Dim obj As New CMS_JobUserInfo
        Dim arr As New ArrayList
        Dim UrlAlias As String = flReg.UrlAlias
        Dim str() As String, careInfo As CMS_CareerInfo
        Private Sub GetID()
            strFb = NavigateURL() & Request.RawUrl.Substring(Request.RawUrl.LastIndexOf("/"))
            ItemID.Value = CMS.Ultis.GetRequestId(Request.RawUrl)
            objController.CMS_JobUser_Update_View(PortalId, ItemID.Value)

            obj = CType(flCache.GetCache("CMS_JobUser_Get_ID_" & ItemID.Value), CMS_JobUserInfo)
            If IsNothing(obj) Then
                obj = New WorkController().CMS_JobUser_Get_ID(4, ItemID.Value)
                flCache.SetCache("CMS_JobUser_Get_ID_" & ItemID.Value, obj, SecondCache.M30)
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
        Private Sub SaveJobUserView(ID As String)
            Dim jInfo As New CMS_JobViewInfo
            jInfo.JobView_ID = flReg.GenKey()
            jInfo.IdKey = ID
            jInfo.UserName = Me.UserInfo.Username
            jInfo.CreateDate = Now
            jInfo.IsFlag = JobView.DN_DaXem
            objController.CMS_JobView_Add(Me.PortalId, jInfo)
        End Sub
        Private Sub SaveJobUserBlackList(ID As String)
            Dim jInfo As New CMS_JobViewInfo
            jInfo.JobView_ID = flReg.GenKey()
            jInfo.IdKey = ID
            jInfo.UserName = Me.UserInfo.Username
            jInfo.CreateDate = Now
            jInfo.IsFlag = JobView.DN_DanhSachDen
            objController.CMS_JobView_Add(Me.PortalId, jInfo)
        End Sub
        Private Sub LoadValue()
            Call GetID()
            If IsNothing(obj) = False Then
                If Me.UserId > 0 Then
                    If Me.UserInfo.IsInRole("business") Then
                        Call SaveJobUserView(obj.JobUser_ID)
                    End If
                End If
                Title.Text = obj.Title
                JobUser_Vn.Text = EPORTAL.flReg.GetUserName(obj.UserAdmin, Me.PortalId)
                    'JobUser_Img.Text = "<img src='" & flReg.ImgSRC(flCheck.JobUser_Avatar(0, obj.JobUser_ID), 150, 0, True, "noavatar.png") & "' alt='" & obj.Title & "' />"
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

                    litInfo.Text += "<div class='col-md-12'>"
                    litInfo.Text += "<p class='line-icon mb_12'>"
                    litInfo.Text += "<i class='icon-address icon_16'></i><span class='pl_28'>Nơi làm việc: "
                    litInfo.Text += "<span class='job_value'>" & flDic.RegionalName(Me.PortalId, obj.TinhTP, obj.QuanHuyen) & "</span>"
                    litInfo.Text += "</span>"
                    litInfo.Text += "</p></div>"

                    litInfo.Text += "<div class='col-md-12'>"
                    litInfo.Text += "<p class='line-icon mb_12'>"
                    litInfo.Text += "<i class='icon-career icon_16'></i><span class='pl_28'>Ngành nghề: "
                    'litInfo.Text += "<span class='job_value'>" & flCheck.Career_Name(Me.PortalId, obj.Career_ID) & "</span>"
                    litInfo.Text += "<span class='job_value'>" & CareerMultiName(obj.Career_ID) & "</span>"
                    litInfo.Text += "</span>"
                    litInfo.Text += "</p></div>"

                    litInfo.Text += "<div class='col-md-12'>"
                    litInfo.Text += "<p class='line-icon mb_12'>"
                    litInfo.Text += "<i class='icon-countdown icon_16'></i><span class='pl_28'>Ngày đăng tin: "
                    litInfo.Text += "<span class='job_value'>" & flReg.ReadDate(obj.StartDate, False) & "</span>"
                    litInfo.Text += "</span>"
                    litInfo.Text += "</p></div>"

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
                    litSEO.Text = JsSeo(obj)
                    flReg.LoadBasePage(Page, "Hồ sơ xin việc | " & flReg.RemoveHTML(obj.Title), flReg.RemoveHTML(obj.Title), flReg.RemoveHTML(obj.Title), obj.ApprovalDate, UrlAlias & Request.RawUrl, flConnect.fileDomain & "/favicon.png?w=400")
                    linkSend = flReg.WebConfig("member") & "/send-link/luu-hs/" & flCheck.LinkUrl(obj.Title, obj.ID, "hs")
                End If
        End Sub

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not IsPostBack Then
                Try
                    Call LoadValue()
                Catch ex As Exception
                    flReg.BugLog(Me.PortalId, ex.Message, "works")
                    Title.Text = ex.Message
                End Try
            End If
        End Sub
        Private Function JsSeo(obj As CMS_JobUserInfo) As String
            JsSeo = "<script type=""application/ld+json"">"
            JsSeo += "{"
            JsSeo += """@context"": ""http://schema.org"", ""@type"": ""NewsArticle"","
            JsSeo += """mainEntityOfPage"":"
            JsSeo += "{ "
            JsSeo += """@type"":""WebPage"","
            JsSeo += """@id"":""" & flCheck.GetHomeLinkJobUser(obj.ID) & """},"
            JsSeo += """headline"": """ & flReg.Trimstr(flReg.ImgAlt(obj.Title), 110) & ""","
            JsSeo += """description"": """ & flReg.ImgAlt(obj.Title) & ""","
            JsSeo += """image"": {""@type"": ""ImageObject"","
            JsSeo += """url"": """ & flConnect.fileDomain & "/favicon.png"","
            JsSeo += """width"" : 800,""height"" : 800},"
            JsSeo += """datePublished"": """ & obj.ApprovalDate & ""","
            JsSeo += """dateModified"": """ & obj.UpdatedDate & ""","
            JsSeo += """author"": {""@type"": ""Person"", ""name"": """ & obj.CreatedUser & """ },"
            JsSeo += """publisher"": { ""@type"": ""Organization"", ""name"": """ & flReg.UrlAlias & ""","
            JsSeo += """logo"": { ""@type"": ""ImageObject"","
            JsSeo += """url"": """ & flConnect.fileDomain & "/favicon.png"","
            JsSeo += """width"": 100, ""height"": 60}"
            JsSeo += "}"
            JsSeo += "}"
            JsSeo += "</script>"
        End Function

    End Class
End Namespace