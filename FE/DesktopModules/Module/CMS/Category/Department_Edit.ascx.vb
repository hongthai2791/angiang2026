Imports DotNetNuke.EPORTAL
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.CMS

Namespace DesktopModules.DanhMuc.PhongBan
    Public MustInherit Class inc_Edit
        Inherits Entities.Modules.PortalModuleBase

        Dim itemid As Integer
        Dim obj As CMS_DepartmentsInfo
        Dim arr, arrTemp As New ArrayList
        Dim itemToRemove As ListItem
        Dim ObjController As New CmsController
        Dim uinfo As New UserInfo

        Private Sub LoadPhongBan()
            ddlPhongBanCha.DataSource = ObjController.CMS_Departments_List(ddlPortal.SelectedValue)
            ddlPhongBanCha.DataTextField = "TenPhongBan"
            ddlPhongBanCha.DataValueField = "Id"
            ddlPhongBanCha.DataBind()
            ddlPhongBanCha.Items.Insert(0, New ListItem("--Chọn phòng ban --", "0"))
        End Sub
        Private Sub LoadValue()
            obj = ObjController.CMS_Departments_Get(ddlPortal.SelectedValue, itemid)
            If IsNothing(obj) = False Then
                txtGiaTri.Text = obj.TenPhongBan
                txtMoTa.Text = obj.MoTa
                chkIsActive.Checked = obj.IsActive
                txtOrderNumber.Text = obj.OrderNumber
                txtTenVietTat.Text = obj.TenVietTat
                If Not String.IsNullOrEmpty(obj.Avatar) Then
                    imgDaidien.Visible = True
                    imgDaidien.ImageUrl = obj.Avatar
                End If

                IsUrl.Text = obj.IsUrl
                ddlPortal.SelectedValue = obj.PortalId

                itemToRemove = ddlPhongBanCha.Items.FindByValue(obj.Id)
                If IsNothing(itemToRemove) = False Then
                    ddlPhongBanCha.Items.Remove(itemToRemove)
                End If 'Xoa ten pb co trong danh sach

                itemToRemove = ddlPhongBanCha.Items.FindByValue(obj.ParentId)
                If IsNothing(itemToRemove) = False Then
                    ddlPhongBanCha.SelectedValue = obj.ParentId
                Else
                    'subsite chinh
                    ddlPhongBanCha.Items.Insert(0, New ListItem("--Chọn phòng ban--", "0"))
                    ddlPhongBanCha.SelectedIndex = 0
                    ddlPhongBanCha.Enabled = False
                End If
            End If

        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                itemid = flReg.WriteNumber(Request.Item("itemid"))
                If Not IsPostBack Then
                    cmdDelete.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
                    Call BindLoadPortal()
                    Call LoadPhongBan()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub

        Public Sub GetPhongBanList2(ByVal arrPhongBan As ArrayList, ByVal ParentPhongBanId As Integer, ByRef arrReturn As ArrayList, ByVal Prefix As String, ByVal SelectedPhongBanID As Integer)
            If ParentPhongBanId = 0 Then
                For Each obj As CMS_DepartmentsInfo In arrPhongBan
                    If obj.ParentId = ParentPhongBanId Then
                        If obj.Id <> SelectedPhongBanID Then
                            obj.TenPhongBan = Prefix & obj.TenPhongBan
                            arrReturn.Add(obj)
                            ' kiem tra xem co doi tuong con hay khong
                            If ObjController.CMS_Departments_GetByParentId(ddlPortal.SelectedValue, ddlPortal.SelectedValue, obj.Id).Count > 0 Then
                                GetPhongBanList2(arrPhongBan, obj.Id, arrReturn, Prefix & "--", SelectedPhongBanID)
                            End If
                        End If
                    End If
                Next
            Else 'Theo sub
                For Each obj As CMS_DepartmentsInfo In arrPhongBan
                    If obj.Id <> SelectedPhongBanID Then
                        obj.TenPhongBan = Prefix & obj.TenPhongBan
                        arrReturn.Add(obj)
                        ' kiem tra xem co doi tuong con hay khong
                        If ObjController.CMS_Departments_GetByParentId(ddlPortal.SelectedValue, ddlPortal.SelectedValue, obj.Id).Count > 0 Then
                            GetPhongBanList2(arrPhongBan, obj.Id, arrReturn, Prefix & "--", SelectedPhongBanID)
                        End If
                    End If
                Next
            End If

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
        End Sub

        Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/pid/" & ddlPortal.SelectedValue, False)
        End Sub
        Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
            If itemid > 0 Then
                ObjController.CMS_Departments_Delete(ddlPortal.SelectedValue, itemid)
                'Remove cache
                DataCache.RemoveCache(TNCacheKey.DanhSachPhongBan.ToString)
                Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/pid/" & ddlPortal.SelectedValue, False)
            End If
        End Sub
        Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
            Dim obj As New CMS_DepartmentsInfo()
            obj.Id = itemid
            obj.TenPhongBan = txtGiaTri.Text
            obj.ParentId = flReg.WriteNumber(ddlPhongBanCha.SelectedValue)
            obj.MoTa = txtMoTa.Text
            obj.NguoiTao = UserId
            obj.NgayTao = Now
            obj.IsActive = chkIsActive.Checked
            obj.OrderNumber = flReg.WriteNumber(txtOrderNumber.Text.Trim)
            obj.PortalId = ddlPortal.SelectedValue
            obj.ModuleId = ModuleId
            obj.Avatar = imgDaidien.ImageUrl
            obj.TenVietTat = txtTenVietTat.Text
            obj.LanguageId = flConnect.IsLang
            obj.IsUrl = IsUrl.Text

            If itemid > 0 Then
                ObjController.CMS_Departments_Update(ddlPortal.SelectedValue, obj)
            Else
                ObjController.CMS_Departments_Add(ddlPortal.SelectedValue, obj)
            End If
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/pid/" & ddlPortal.SelectedValue, False)
        End Sub
        Public Function GetNameByUserId(ByVal UserId As String) As String
            Dim dnnInfo As DnnInfo = flDnn.DNN_User_Get_UserName(ddlPortal.SelectedValue, UserId)
            If IsNothing(dnnInfo) = False Then
                Return dnnInfo.Username & " - " & dnnInfo.DisplayName
            Else
                Return UserId
            End If
        End Function
    End Class
End Namespace
