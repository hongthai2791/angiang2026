Imports DotNetNuke.Entities.Profile
Imports DotNetNuke.Services.Mail
Imports Telerik.Web.UI
Imports DotNetNuke.EPORTAL

Namespace DotNetNuke.CMS
	Partial Public Class EditProfile
		Inherits DotNetNuke.Entities.Modules.PortalModuleBase
		Dim ObjControler As New CmsController
		Dim arrTemp, arr, arrTemp1 As New ArrayList
		Dim str(), str1(), str2() As String
		Dim cbox As CheckBox
		Public Property U_Id() As Integer
			Get
				If Not ViewState.Item("U_Id") Is Nothing Then
					Dim x As Integer = Null.NullInteger
					Try
						x = Integer.Parse(ViewState.Item("U_Id"))
					Catch ex As System.Exception
						x = Null.NullInteger
					End Try
					Return x
				Else
					ViewState.Add("U_Id", Null.NullInteger.ToString)
					Return Null.NullInteger
				End If
			End Get
			Set(ByVal Value As Integer)
				ViewState.Item("U_Id") = Value.ToString
			End Set
		End Property

#Region "Public Methods"
		Public Sub BindddlCategories(ParentID As Integer, str As String)
			arrTemp1 = ObjControler.CMS_NewsCategories_Get_By_ParentId(ddlPortal.SelectedValue, ddlPortal.SelectedValue, flConnect.IsLang, "admin", CategoryType.News, ParentID)
			For Each Cr1 As CMS_NewsCategoriesInfo In arrTemp1
				Cr1.CategoryName = str & Cr1.CategoryName
				arr.Add(Cr1)
				Call BindddlCategories(Cr1.CategoryID, str & "|--- ")
			Next
		End Sub
		Public Sub LoadCategories()
			arrTemp = ObjControler.CMS_NewsCategories_Get_By_ParentId(ddlPortal.SelectedValue, ddlPortal.SelectedValue, flConnect.IsLang, "admin", CategoryType.News, 0)
			arr = New ArrayList
			For Each Cr As CMS_NewsCategoriesInfo In arrTemp
				arr.Add(Cr)
				Call BindddlCategories(Cr.CategoryID, "|--- ")
			Next
			chkCate.DataSource = arr
			chkCate.DataTextField = "CategoryName"
			chkCate.DataValueField = "CategoryID"
			chkCate.DataBind()
			For Each item As ListItem In chkCate.Items
				If ObjControler.CMS_NewsCategoriesPermission_Get_By_Category(ddlPortal.SelectedValue, txtUserName.Text.Trim, item.Value) > 0 Then
					item.Selected = True
				End If
			Next
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
			ddlPortal.Enabled = False
		End Sub
		Public Sub LoadRole()
			litSub.Text = ""
			arrTemp = flDnn.CMS_Roles_Get_By_CMS_SubMod(Me.PortalId, flDic.SubMod_ID(0, Me.PortalSettings.ActiveTab.TabName))
			For Each Cj As CMS_RolesInfo In arrTemp
				If CheckRole(Cj.Roles_ID) Then
					litSub.Text += "<div class=""col-md-12""><input checked=""checked"" type=""checkbox"" class=""sub-" & Cj.SubMod_ID & " adnew"" id=""subra-" & Cj.Roles_ID & """ onclick=""checkinput(" & Cj.Roles_ID & ");""><span class=""input-span"">" & Cj.Roles_Name & "</span></div>"
				Else
					litSub.Text += "<div class=""col-md-12""><input type=""checkbox"" class=""sub-" & Cj.SubMod_ID & """ id=""subra-" & Cj.Roles_ID & """ onclick=""checkinput(" & Cj.Roles_ID & ");""><span class=""input-span"">" & Cj.Roles_Name & "</span></div>"
				End If
			Next
		End Sub
		Private Function CheckRole(id As Integer) As Boolean
			Try
				str = dataVal.Value.Split(",")
				For i As Integer = 0 To str.Length - 1
					If flReg.WriteNumber(str(i)) = id Then Return True
				Next
				Return False
			Catch ex As Exception
				Return False
			End Try
		End Function
		Private Function GetRole() As String
			GetRole = RolData.Value.Replace("subra-", "")
		End Function
		Public Sub SaveUserAndProfile(ByVal U_Id As Integer)
			Dim objUserInfo As UserInfo = UserController.GetUserById(Me.PortalId, U_Id)

			objUserInfo.FirstName = txtTen.Text.Trim
			objUserInfo.Profile.SetProfileProperty("MiddleName", txtDem.Text.Trim)
			objUserInfo.LastName = txtHo.Text.Trim

			objUserInfo.DisplayName = txtHo.Text.Trim + " " + txtDem.Text.Trim + " " + txtTen.Text.Trim
			objUserInfo.DisplayName = objUserInfo.DisplayName.Replace("  ", " ")

			Dim birthDay As String = ddlDay.SelectedValue.ToString + "/" + ddlMonth.SelectedValue.ToString + "/" + ddlYear.Text
			objUserInfo.Profile.SetProfileProperty("DateOfBirth", birthDay)
			If drdSex.SelectedValue = "Nam" Then
				objUserInfo.Profile.SetProfileProperty("Sex", "Nam")
			Else
				objUserInfo.Profile.SetProfileProperty("Sex", "Nữ")
			End If
			objUserInfo.Email = txtEmail.Text.Trim
			objUserInfo.Profile.SetProfileProperty("Telephone", txtPhone.Text)
			objUserInfo.Membership.Approved = True

			UserController.UpdateUser(Me.PortalId, objUserInfo)
			ProfileController.UpdateUserProfile(objUserInfo)
			flCache.RemoveCache("VaiTroNguoiDung_" & Me.PortalSettings.ActiveTab.TabName & "_" & objUserInfo.Username)
		End Sub
		Public Sub BindDepartment()
			Dim arrResult As New ArrayList
			GetPhongBanList(ObjControler.CMS_Departments_List(ddlPortal.SelectedValue), 0, arrResult, "")
			drgViewData.DataSource = arrResult
			drgViewData.DataKeyField = "ID"
			drgViewData.DataBind()
		End Sub
		Public Sub GetPhongBanList(ByVal arrPhongBan As ArrayList, ByVal ParentPhongBanId As Integer, ByRef arrReturn As ArrayList, ByVal Prefix As String)
			For Each objPhongBan As CMS_DepartmentsInfo In arrPhongBan
				If objPhongBan.ParentId = ParentPhongBanId Then
					objPhongBan.TenPhongBan = Prefix & objPhongBan.TenPhongBan
					arrReturn.Add(objPhongBan)
					If ObjControler.CMS_Departments_GetByParentId(ddlPortal.SelectedValue, ddlPortal.SelectedValue, objPhongBan.Id).Count > 0 Then
						GetPhongBanList(arrPhongBan, objPhongBan.Id, arrReturn, Prefix & "--")
					End If
				End If
			Next
		End Sub
		Public Sub Save_UserDepartment(ByVal U_Id As Integer)
			Try
				Dim pbInfo As New CMS_Departments_NguoiDungInfo
				For Each obj As DataGridItem In drgViewData.Items
					cbox = obj.FindControl("chkChon")
					pbInfo = New CMS_Departments_NguoiDungInfo
					pbInfo.UserId = txtUserName.Text
					pbInfo.PhongBan = drgViewData.DataKeys.Item(obj.ItemIndex)
					If cbox.Checked Then
						pbInfo.ChucVu = ChucVu.SelectedValue
						cbox = obj.FindControl("chkNguoiKy")
						pbInfo.LaNguoiKy = cbox.Checked
						pbInfo.LaNguoiNhanVB = False
						pbInfo.LaLanhDao = False
						pbInfo.PortalId = ddlPortal.SelectedValue
						pbInfo.ChucVu = flReg.WriteNumber(ChucVu.SelectedValue)
						ObjControler.CMS_Departments_NguoiDung_Add(ddlPortal.SelectedValue, pbInfo)
					Else
						ObjControler.CMS_Departments_NguoiDung_Delete(ddlPortal.SelectedValue, pbInfo.PhongBan)
					End If
				Next
			Catch ex As Exception
				txtPhone.Text = ex.Message
			End Try
		End Sub
		Public Sub BindYear()
			For i As Integer = 1960 To Now.Year - 10
				ddlYear.Items.Add(New ListItem(i.ToString, i))
			Next
			For i As Integer = 1 To 12
				ddlMonth.Items.Add(New ListItem("Tháng " & i, i))
			Next
			For i As Integer = 1 To 31
				ddlDay.Items.Add(New ListItem(i, i))
			Next
		End Sub
		Public Sub IntitProfile(ByVal objUserInfo As UserInfo)
			txtUserName.Text = objUserInfo.Username
			If objUserInfo.FirstName & "" <> "" Then
				txtTen.Text = objUserInfo.FirstName
				txtHo.Text = objUserInfo.LastName
			Else
				txtHo.Text = objUserInfo.DisplayName.Substring(0, objUserInfo.DisplayName.LastIndexOf(" "))
				txtTen.Text = objUserInfo.DisplayName.Substring(objUserInfo.DisplayName.LastIndexOf(" ") + 1)
			End If
			txtDem.Text = objUserInfo.Profile.GetPropertyValue("MiddleName")

			Dim strBirthDay As String = objUserInfo.Profile.GetPropertyValue("DateOfBirth")
			If Not String.IsNullOrEmpty(strBirthDay) Then
				Dim arrDate As String() = strBirthDay.Split("/")
				If arrDate.Count > 2 Then
					ddlDay.SelectedValue = arrDate(0)
					ddlMonth.SelectedValue = arrDate(1)
					ddlYear.SelectedValue = arrDate(2)
				End If
			End If
			drdSex.SelectedValue = objUserInfo.Profile.GetPropertyValue("Sex")
			txtEmail.Text = objUserInfo.Email
			txtPhone.Text = objUserInfo.Profile.GetPropertyValue("Telephone")

			dataVal.Value = ""
			arr = flDnn.CMSUserPortal_Get_By_User("", objUserInfo.Username, Me.PortalId)
			For Each Cr As CMSUserPortalInfo In arr
				dataVal.Value += Cr.RolesID & ","
			Next

			Dim pbInfo As New CMS_Departments_NguoiDungInfo
			For Each obj As DataGridItem In drgViewData.Items
				pbInfo = ObjControler.CMS_Departments_NguoiDung_GetByUserIdAnDepartmentId(ddlPortal.SelectedValue, txtUserName.Text, drgViewData.DataKeys.Item(obj.ItemIndex), ddlPortal.SelectedValue)
				If Not pbInfo Is Nothing Then
					cbox = obj.FindControl("chkChon")
					cbox.Checked = True

					cbox = obj.FindControl("chkNguoiKy")
					cbox.Checked = pbInfo.LaNguoiKy

					ChucVu.SelectedValue = flReg.WriteString(pbInfo.ChucVu)
				End If
			Next
		End Sub
		Private Sub SaveCatePermistion()
			For Each item As ListItem In chkCate.Items
				If item.Selected Then
					ObjControler.CMS_NewsCategoriesPermission_Add(ddlPortal.SelectedValue, txtUserName.Text.Trim, item.Value, 1)
				Else
					ObjControler.CMS_NewsCategoriesPermission_Delete_Category(ddlPortal.SelectedValue, txtUserName.Text.Trim, item.Value)
				End If
			Next
		End Sub
		Private Sub SaveUserPortal()
			Try
				flDnn.AddUserPortal(0, U_Id)
				Dim obj As CMSUserPortalInfo = flDnn.CMSUserPortal_Get_By_User("", txtUserName.Text.Trim, PortalSettings.ActiveTab.TabName, 0)
				obj.RolesID = GetRole()
				obj.UserName = txtUserName.Text.Trim
				obj.DisplayName = (txtHo.Text.Trim & " " & txtDem.Text.Trim & " " & txtTen.Text.Trim).Replace("  ", " ")
				obj.Email = txtEmail.Text.Trim
				obj.Telephone = txtPhone.Text.Trim
				obj.SubMod = Me.PortalSettings.ActiveTab.TabName
				flDnn.CMSUserPortal_Add(obj)
			Catch ex As Exception
				ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "pag_load", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
			End Try
		End Sub
		Private Sub LoadValue()
			U_Id = flReg.WriteNumber(Request.Item("itemid"))
			Dim oUser As UserInfo = UserController.GetUserById(Me.PortalId, U_Id)
			If oUser IsNot Nothing Then Call IntitProfile(oUser)
			If flReg.IsInRole(Me.PortalId, oUser.Username, Me.PortalSettings.ActiveTab.TabName, "Manager") Or Me.UserInfo.Username = "host" Then
				drgViewData.Enabled = True
			Else
				drgViewData.Enabled = False
			End If
			Call LoadRole()
			Call LoadCategories()
		End Sub

#End Region

#Region "Event Handler"
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
			Try
				Dim slanguage As String = flConnect.IsLang
				If Not IsPostBack Then
					Call BindYear()
					Call BindLoadPortal()
					Call BindDepartment()
					Call flDic.LoadPosition(ddlPortal.SelectedValue, ChucVu)
					Call LoadValue()
					ViewState("UrlReferrer") = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/user-list"
				End If
			Catch ex As Exception
				txtPhone.Text = ex.Message
			End Try
		End Sub
		Private Sub btnSignUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSignUp.Click
			Try
				flCache.RemoveCache("NewsCategories_Get_By_ParentId" & PortalId & txtUserName.Text.Trim & CategoryType.News)
				Call SaveUserAndProfile(U_Id)
				If drgViewData.Enabled Then
					Call Save_UserDepartment(U_Id)
				End If
				Call SaveCatePermistion()
				Call SaveUserPortal() 'Lưu phân quyền quản trị chuyên san 
				Call LoadValue()
				ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notifySuccess", " notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);", True)
			Catch ex As Exception
				txtPhone.Text = ex.Message
			End Try
		End Sub
		Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
			Response.Redirect(ViewState("UrlReferrer"), True)
		End Sub

#End Region

	End Class
End Namespace
