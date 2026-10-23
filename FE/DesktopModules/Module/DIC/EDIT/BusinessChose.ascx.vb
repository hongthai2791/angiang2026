Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList
        Dim chBox As CheckBox, liter As Literal
        Dim icount As Integer = 0
        Dim cmsControl As New CmsController
        Dim obj As New CMS_BusinessInfo
        Dim cbj As New TN_BusinessInfo
        Dim bUinfo As New CMS_BusUserInfo
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
                arrTemp = cmsControl.CMS_Business_Get_All(strConnect)
                For Each Cr As TN_BusinessInfo In arrTemp
                    'obj  88
                    obj = New CMS_BusinessInfo
                    obj.Business_ID = Cr.Business_ID
                    obj.Business_Vn = flReg.RemoveScript(flReg.RemoveScript(Cr.Business_Vn, False))
                    obj.Business_En = flReg.RemoveScript(flReg.RemoveScript(Cr.Business_En, False))
                    obj.Business_Sort = flReg.RemoveScript(flReg.RemoveScript(Cr.Business_Sort, False))
                    obj.TinhTP = TinhTP.SelectedValue
                    'obj.QuanHuyen = Cr.QuanHuyen
                    obj.Logo = Cr.Logo
                    obj.Description = flReg.RemoveScript(flReg.RemoveScript(Cr.Description, False))
                    obj.TaxCode = Cr.TaxCode
                    obj.Mobile = flReg.RemoveScript(flReg.RemoveScript(Cr.Mobile, False))
                    obj.Fax = flReg.RemoveScript(flReg.RemoveScript(Cr.Fax, False))
                    obj.Website = flReg.RemoveScript(flReg.RemoveScript(Cr.Website, False))
                    obj.Email = flReg.RemoveScript(flReg.RemoveScript(Cr.Email, False))
                    obj.Address = flReg.RemoveScript(flReg.RemoveScript(Cr.Address, False))
                    obj.ContactUser = flReg.RemoveScript(flReg.RemoveScript(Cr.ContactUser, False))
                    obj.ContactMobile = flReg.RemoveScript(flReg.RemoveScript(Cr.ContactMobile, False))
                    obj.ContactEmail = flReg.RemoveScript(flReg.RemoveScript(Cr.ContactEmail, False))
                    obj.CreatedDate = Now
                    obj.CreatedUser = Me.UserInfo.Username
                    obj.UpdatedDate = flReg.DateNull()
                    obj.UpdatedUser = ""
                    obj.Scale = Cr.Scale
                    obj.IsApproval = Cr.IsApproval
                    'obj.WBID = Cr.ID
                    objController.CMS_Business_Add_All(Me.PortalId, obj)

                    'Gán tài khoản quản trị là tài khoản lấy tin
                    bUinfo = New CMS_BusUserInfo
                    bUinfo.BusUser_ID = flReg.GenKey()
                    bUinfo.Business_ID = obj.Business_ID
                    bUinfo.IsAdmin = True
                    bUinfo.IsActive = False
                    bUinfo.UserAdmin = Cr.UserAdmin & ""

                    bUinfo.CreatedDate = Now
                    bUinfo.UpdatedDate = flReg.DateNull

                    bUinfo.ApprovalDate = Now
                    bUinfo.ApprovalUser = Me.UserInfo.Username
                    objController.CMS_BusUser_Add_Import(Me.PortalId, bUinfo)
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
