Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.CongTacVien
    Public MustInherit Class CMS_AuthorsEdit
        Inherits Entities.Modules.PortalModuleBase
#Region "Varial"
        Dim objAuthors As New CMS_AuthorsInfo
        Dim ObjController As New CmsController
        Dim arrTemp, arrTemp1 As ArrayList
#End Region
#Region "Function"
        Private Sub InitControl()
            ItemID.Value = Request.Item("itemID") & ""
            PortalVal.Value = Request.Item("pid") & ""
            Call BindLoadPortal()
            Call LoadRegions()

            If flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Manager") = False And flReg.IsInRole(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, "Administrators") = False Then
                RegisterUser.Enabled = False
                Call flDic.ListUserName(RegisterUser, Me.UserInfo.Username)
                RegisterUser.SelectedValue = Me.UserInfo.Username
            Else
                Call flDic.ListUserName(RegisterUser, "true")
				RegisterUser.SelectedValue = Request.QueryString("user") & ""
            End If
            cmdDel.OnClientClick = "javascript:return confirm('Bạn có muốn xóa nội dung này không?');"
        End Sub
        Private Sub LoadValues()
            objAuthors = ObjController.CMS_Authors_Get(PortalVal.Value, ItemID.Value)
            If IsNothing(objAuthors) = False Then
                PortalVal.Value = objAuthors.PortalID
                ddlPortal.SelectedValue = PortalVal.Value
                PenName.Text = objAuthors.PenName
                FullName.Text = objAuthors.FullName
                Indentify.Text = objAuthors.Indentify
                Birthday.Text = flReg.ReadDate(objAuthors.BirthDay)
                Address.Text = objAuthors.Address
                Email.Text = objAuthors.Email
                Phone.Text = objAuthors.Phone
                RegisterUser.SelectedValue = objAuthors.RegisterUser
                Regions.SelectedValue = objAuthors.Regions
                txtTenTK.Text = objAuthors.TenTK
                txtSoTK.Text = objAuthors.SoTK
                txtDiaChiCN.Text = objAuthors.DiaChiCN
                txtNganHang.Text = objAuthors.NganHang
                cmdDel.Visible = False
            Else
                cmdDel.Visible = False
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

        Private Sub LoadRegions()
            Regions.Items.Add(New ListItem("---Chọn vùng miền---", 0))
            Regions.Items.Add(New ListItem("Bưu điện", 1))
            Regions.Items.Add(New ListItem("Hà Nội", 2))
        End Sub
        Private Sub BackEnd()
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit") & "/pid/" & ddlPortal.SelectedValue & "/user/" & RegisterUser.SelectedValue, True)
        End Sub
#End Region
#Region "Event"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not IsPostBack Then
                Call InitControl()
                Call LoadValues()
            End If
        End Sub
        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                objAuthors = New CMS_AuthorsInfo
                objAuthors.PortalID = ddlPortal.SelectedValue
                objAuthors.FullName = FullName.Text
                objAuthors.PenName = PenName.Text
                objAuthors.Indentify = Indentify.Text
                objAuthors.Phone = Phone.Text
                objAuthors.BirthDay = flReg.WriteDate(Birthday.Text, False)
                objAuthors.Email = Email.Text
                objAuthors.Regions = Regions.SelectedValue
                objAuthors.Address = Address.Text
                PortalVal.Value = ddlPortal.SelectedValue
                objAuthors.RegisterUser = RegisterUser.SelectedValue
                objAuthors.TenTK = txtTenTK.Text
                objAuthors.SoTK = txtSoTK.Text
                objAuthors.DiaChiCN = txtDiaChiCN.Text
                objAuthors.NganHang = txtNganHang.Text
                If ItemID.Value <> "0" Then
                    objAuthors.Authors_ID = ItemID.Value
                    objAuthors.UpdatedDate = Now
                    objAuthors.UpdatedUser = Me.UserInfo.Username
                    ObjController.CMS_Authors_Update(PortalVal.Value, objAuthors)
                Else
                    ItemID.Value = flReg.GenKey
                    objAuthors.Authors_ID = ItemID.Value
                    objAuthors.CreatedDate = Now
                    objAuthors.CreatedUser = Me.UserInfo.Username
                    ObjController.CMS_Authors_Add(PortalVal.Value, objAuthors)
                End If
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
            Try
                Call BackEnd()
            Catch exc As Exception
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub
#End Region
    End Class
End Namespace