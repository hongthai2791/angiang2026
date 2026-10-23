Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim cmsControl As New CmsController
        Dim arrTemp As New ArrayList
        Dim icount As Integer = 0

        Dim obj As New CMS_JobUserInfo
        Dim strConnect As String = ""

        Private Sub InitControls()
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

        End Sub




        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
        End Function
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Call InitControls()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                strConnect = "Data Source=" & ServerName.Text.Trim & ";Initial Catalog=" & DataBases.Text.Trim & ";User ID=" & TaiKhoan.Text.Trim & ";Password=" & MatKhau.Text.Trim & ""
                icount = 0
                arrTemp = cmsControl.CMS_JobUser_Get_All(strConnect)
                For Each Cr As TN_JobUserInfo In arrTemp
                    obj = New CMS_JobUserInfo
                    obj.JobUser_ID = Cr.JobUser_ID
                    obj.Title = flReg.RemoveScript(flReg.RemoveScript(Cr.Title, False))
                    obj.Career_ID = Cr.Career_ID
                    obj.CurrentLevel = Cr.CurrentLevel
                    obj.LevelDesired = Cr.LevelDesired
                    obj.TinhTP = TinhTP.SelectedValue
                    'obj.QuanHuyen = Cr.QuanHuyen
                    obj.Experience_ID = Cr.Experience_ID
                    obj.Level_ID = Cr.Level_ID
                    obj.Salary_ID = Cr.Salary_ID
                    obj.Needs_ID = Cr.Needs_ID
                    obj.Education = flReg.RemoveScript(flReg.RemoveScript(Cr.Education, False))
                    obj.CareerGoals = flReg.RemoveScript(flReg.RemoveScript(Cr.CareerGoals, False))
                    obj.WorkExperience = flReg.RemoveScript(flReg.RemoveScript(Cr.WorkExperience, False))
                    obj.SkillsForte = flReg.RemoveScript(flReg.RemoveScript(Cr.SkillsForte, False))
                    obj.UserAdmin = Cr.UserAdmin
                    obj.StartDate = Cr.StartDate
                    obj.EndDate = Cr.EndDate
                    obj.IsApproval = Cr.IsApproval
                    obj.ApprovalUser = Cr.ApprovalUser
                    obj.ApprovalDate = Cr.ApprovalDate
                    obj.IsDelete = 0
                    obj.DeletedUser = ""
                    obj.DeletedDate = flReg.DateNull()
                    obj.CreatedDate = Now
                    obj.CreatedUser = Me.UserInfo.Username
                    obj.UpdatedDate = flReg.DateNull()
                    obj.UpdatedUser = ""
                    obj.IsView = Cr.IsView
                    obj.IsSend = Cr.IsSend
                    obj.PortalID = Cr.PortalID
                    obj.EndDate = Now.AddYears(1)
                    objController.CMS_JobUser_Add(Me.PortalId, obj)
                    icount += 1
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã lấy dữ liệu thành công.', 'Thông báo', false);backend('" & ViewState("backUrl") & "')", True)
                    'Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Bạn chưa chọn liên kết để lấy dữ liệu.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect(ViewState("backUrl"), True)
        End Sub
    End Class

End Namespace
