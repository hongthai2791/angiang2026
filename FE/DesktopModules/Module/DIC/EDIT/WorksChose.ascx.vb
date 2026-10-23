Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList
        Dim icount As Integer = 0
        Dim cmsControl As New CmsController
        Dim obj As New CMS_WorkInfo
        Dim strConnect As String = ""

        Private Sub InitControls()
            'txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            'flDic.LoadPageSize(drPageSize)
            'If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            ''Call LoadSort()
            'drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))
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
                    'Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                strConnect = "Data Source=" & ServerName.Text.Trim & ";Initial Catalog=" & DataBases.Text.Trim & ";User ID=" & TaiKhoan.Text.Trim & ";Password=" & MatKhau.Text.Trim & ""
                icount = 0
                arrTemp = cmsControl.CMS_Work_Get_All(strConnect)
                For Each Cr As TN_WorkInfo In arrTemp
                    'obj  88
                    obj = New CMS_WorkInfo
                    obj.Work_ID = Cr.Work_ID
                    obj.Business_ID = Cr.Business_ID
                    obj.Title = flReg.RemoveScript(flReg.RemoveScript(Cr.Title, False))
                    obj.Salary_ID = Cr.Salary_ID
                    obj.Quantity = Cr.Quantity
                    obj.Experience_ID = Cr.Experience_ID
                    obj.Gender = Cr.Gender
                    obj.Level_ID = Cr.Level_ID
                    obj.TinhTP = TinhTP.SelectedValue
                    'obj.QuanHuyen = Cr.QuanHuyen
                    obj.TypeOf_ID = Cr.TypeOf_ID
                    obj.Career_ID = Cr.Career_ID
                    obj.Description = flReg.RemoveScript(flReg.RemoveScript(Cr.Description, False))
                    obj.Requirement = flReg.RemoveScript(flReg.RemoveScript(Cr.Requirement, False))
                    obj.Benefit = flReg.RemoveScript(flReg.RemoveScript(Cr.Benefit, False))
                    obj.RequirementsProfile = Cr.RequirementsProfile
                    obj.ExpiredDate = Cr.ExpiredDate
                    obj.SubmissionSend = Cr.SubmissionSend
                    obj.StartDate = Cr.StartDate
                    obj.EndDate = Cr.EndDate
                    obj.ContactUser = Cr.ContactUser
                    obj.ContactAddress = Cr.ContactAddress
                    obj.ContactMobile = Cr.ContactMobile
                    obj.ContactEmail = Cr.ContactEmail
                    obj.ContactDes = Cr.ContactDes
                    obj.IsHot = Cr.IsHot
                    obj.IsFast = Cr.IsFast
                    obj.IsUrgent = Cr.IsUrgent
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
                    obj.LevelDesired_ID = Cr.LevelDesired_ID
                    obj.IsFlag = Cr.IsFlag
                    obj.JobPlace = Cr.JobPlace
                    obj.IdSend = Cr.IdSend
                    obj.EndDate = Now.AddYears(1) 'gia hạn thêm 1 năm
                    objController.CMS_Work_Add(Me.PortalId, obj)


                    icount += 1
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã lấy dữ liệu thành công.', 'Thông báo', false);backend('" & ViewState("backUrl") & "')", True)
                    'Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Bạn chưa chọn doanh nghiệp để liên kết.', 'Thông báo', false);", True)
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
