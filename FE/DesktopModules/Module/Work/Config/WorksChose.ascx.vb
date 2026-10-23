Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList
        Dim chBox As CheckBox, liter As Literal
        Dim appControl As New APP.AppController()
        Dim obj As New APP.CMS_WorksInfo
        Dim ebj As New APP.CMS_WorksCareerInfo
        Dim bobj As New APP.CMS_BusinessInfo
        Dim str() As String, icount As Integer
        Dim cbj As New CMS_WorkInfo
        Dim cbbj As New CMS_BusinessInfo
        Dim bUinfo As New APP.CMS_BusUserInfo

        Dim _tabName As String = Me.PortalSettings.ActiveTab.TabName
        Private Function getWBID() As String
            getWBID = ""
            For Each Cr As APP.CMS_WorksInfo In appControl.CMS_Works_Get_TopApp(Me.PortalId, TinhTP.SelectedValue)
                getWBID += Cr.WBID & ","
            Next
        End Function
        Private Sub InitControls()
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")
            Call LoadSort()
            drSort.SelectedValue = flReg.WriteNumber(Request.Item("sort"))

            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            If Request.Item("qh") <> "" Then QuanHuyen.SelectedValue = Request.Item("qh")

            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Salary_ID.SelectedValue = Request.Item("sal") & ""

            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Experience_ID.SelectedValue = Request.Item("exp") & ""

            Call flFunction.LoadStatusWork(Status_ID)
            Status_ID.SelectedValue = Request.Item("sta")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            Call flFunction.LoadBusinessToApp(Business_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue)
            Business_ID.SelectedValue = Request.Item("bus")

        End Sub
        Private Sub LoadValues()
            arrTemp = objController.CMS_Work_List_ToApp(TinhTP.SelectedValue, txtkey.Text.Trim, drSort.SelectedValue, currPage.Value, drPageSize.SelectedValue, Business_ID.SelectedValue, Salary_ID.SelectedValue,
                                                        Experience_ID.SelectedValue, QuanHuyen.SelectedValue, Status_ID.SelectedValue, getWBID())
            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Work_ID"
            grdData.DataBind()

            litCount.Text = 0 : litPage.Text = ""
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_WorkInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = Cr.Total
                Exit For
            Next
            If QuanHuyen.SelectedValue <> "" Then
                ViewState("backUrl") = "/" & _tabName & "/view/work-lists/tp/" & TinhTP.SelectedValue & "/qh/" & QuanHuyen.SelectedValue
            Else
                ViewState("backUrl") = "/" & _tabName & "/view/work-lists/tp/" & TinhTP.SelectedValue
            End If
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub
        Private Sub LoadSort()
            drSort.Items.Clear()
            drSort.Items.Add(New ListItem("Mặc định", "0"))
            drSort.Items.Add(New ListItem("Đã phê duyệt", "1"))
            drSort.Items.Add(New ListItem("Ngày đăng tin", "2"))
        End Sub
        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("edit")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If QuanHuyen.SelectedValue <> "" Then RedirectURL += "/qh/" & QuanHuyen.SelectedValue
            If Salary_ID.SelectedValue <> "" Then RedirectURL += "/sal/" & Salary_ID.SelectedValue
            If Experience_ID.SelectedValue <> "" Then RedirectURL += "/exp/" & Experience_ID.SelectedValue
            If Business_ID.SelectedValue <> "" Then RedirectURL += "/bus/" & Business_ID.SelectedValue
            If Status_ID.SelectedValue <> "-1" Then RedirectURL += "/sta/" & Status_ID.SelectedValue
            If drSort.SelectedValue <> "0" Then RedirectURL += "/sort/" & drSort.SelectedValue
            If drPageSize.SelectedValue <> "35" Then RedirectURL += "/num/" & drPageSize.SelectedValue
            If txtkey.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtkey.Text.Trim())
        End Function
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValues()
                End If
            Catch ex As Exception
                If Me.UserInfo.Username = "host" Then litPage.Text = ex.Message & " :: " & flConnect.ToAppConnect(TinhTP.SelectedValue)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, _tabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged, drSort.SelectedIndexChanged, Business_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged, Status_ID.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue, "- - Quận/ huyện - -")
            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue, "")

            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuanHuyen.SelectedIndexChanged
            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, QuanHuyen.SelectedValue, "")

            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("Infomation")
            liter.Text = "<div>DN: " & DataBinder.Eval(e.Item.DataItem, "Business_VN") & "</div>"
            liter.Text += "<div>Kinh nghiệm: " & flCheck.Experience_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Experience_ID")) & "</div>"
            liter.Text += "<div>Mức lương: " & flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID")) & "</div>"

            liter = e.Item.FindControl("DateTime")
            liter.Text = "<div>Hạn nộp: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "ExpiredDate"), False) & "</div>"
            liter.Text += "<div>Đăng từ: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "StartDate"), False) & "</div>"
            liter.Text += "<div>Đến ngày: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "EndDate"), False) & "</div>"

            chBox = e.Item.FindControl("IsApproval")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsApproval")
            If chBox.Checked = False Then e.Item.CssClass = "blue"

            chBox = e.Item.FindControl("IsUrgent")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsUrgent")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsHot")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsHot")
            chBox.Enabled = IsActive.Value

            chBox = e.Item.FindControl("IsFast")
            chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsFast")
            chBox.Enabled = IsActive.Value

            liter = e.Item.FindControl("Title")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Title")
            liter.Text += "<div>Khu vực: " & flDic.RegionalName(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TinhTP"), DataBinder.Eval(e.Item.DataItem, "QuanHuyen")) & "</div>"
            If DataBinder.Eval(e.Item.DataItem, "IsView") <> "0" Then liter.Text += "<div>Lượt xem: " & flReg.FormatPrice(DataBinder.Eval(e.Item.DataItem, "IsView")) & "</div>"

        End Sub
        Private Sub AddBuss(Business_ID As String)
            cbbj = objController.CMS_Business_Get_ToApp(TinhTP.SelectedValue, Business_ID)
            If IsNothing(cbbj) = False Then
                bobj = New APP.CMS_BusinessInfo
                bobj.Business_ID = cbbj.Business_ID
                bobj.Business_Vn = flReg.RemoveScript(flReg.RemoveScript(cbbj.Business_Vn, False))
                bobj.Business_En = flReg.RemoveScript(flReg.RemoveScript(cbbj.Business_En, False))
                bobj.Business_Sort = flReg.RemoveScript(flReg.RemoveScript(cbbj.Business_Sort, False))
                bobj.TinhTP = TinhTP.SelectedValue
                bobj.QuanHuyen = cbbj.QuanHuyen
                bobj.Logo = cbbj.Logo
                bobj.Description = flReg.RemoveScript(flReg.RemoveScript(cbbj.Description, False))
                bobj.TaxCode = cbbj.TaxCode
                bobj.Mobile = flReg.RemoveScript(flReg.RemoveScript(cbbj.Mobile, False))
                bobj.Fax = flReg.RemoveScript(flReg.RemoveScript(cbbj.Fax, False))
                bobj.Website = flReg.RemoveScript(flReg.RemoveScript(cbbj.Website, False))
                bobj.Email = flReg.RemoveScript(flReg.RemoveScript(cbbj.Email, False))
                bobj.Address = flReg.RemoveScript(flReg.RemoveScript(cbbj.Address, False))
                bobj.ContactUser = flReg.RemoveScript(flReg.RemoveScript(cbbj.ContactUser, False))
                bobj.ContactMobile = flReg.RemoveScript(flReg.RemoveScript(cbbj.ContactMobile, False))
                bobj.ContactEmail = flReg.RemoveScript(flReg.RemoveScript(cbbj.ContactEmail, False))
                bobj.CreatedDate = Now
                bobj.CreatedUser = Me.UserInfo.Username
                bobj.UpdatedDate = flReg.DateNull()
                bobj.UpdatedUser = ""
                bobj.Scale = cbbj.Scale
                bobj.IsApproval = cbbj.IsApproval
                bobj.IsRep = False
                bobj.IsTop = False
                bobj.WBID = cbbj.ID
                appControl.CMS_Business_Add(Me.PortalId, bobj)


                'Gán tài khoản quản trị là tài khoản lấy tin
                bUinfo = New APP.CMS_BusUserInfo
                bUinfo.BusUser_ID = flReg.GenKey()
                bUinfo.Business_ID = bobj.Business_ID
                bUinfo.IsAdmin = True
                bUinfo.IsActive = False
                bUinfo.UserAdmin = cbbj.UserAdmin & ""

                bUinfo.CreatedDate = Now
                bUinfo.UpdatedDate = flReg.DateNull

                bUinfo.ApprovalDate = Now
                bUinfo.ApprovalUser = Me.UserInfo.Username
                appControl.CMS_BusUser_Add_Import(Me.PortalId, bUinfo)
            End If
        End Sub
        Function changeGender(gender As Integer) As Integer
            Select Case gender
                Case 1 'Nam
                    Return GenderType.Nam
                Case 2 'Nu
                    Return GenderType.Nu
                Case Else
                    Return GenderType.KhongYeuCau
            End Select
        End Function
        Function changeLevel(level As String) As String
            changeLevel = ""
            If level = "1d7fd679-68dc-4461-8e5d-78017b098da4" Then 'Sơ cấp nghề/Chứng chỉ học nghề ngắn hạn
                Return "5"
            ElseIf level = "2fe13884-0aed-4033-a324-3be1c4c2f57c" Then 'Không có trình độ chuyên môn kỹ thuật
                Return "20"
            ElseIf level = "32f5e90c-1880-4b74-b05d-53c5ba9da5b0" Then 'Cao đẳng nghề/Cao đẳng chuyên nghiệp
                Return "4"
            ElseIf level = "8326facd-c383-46e6-aec3-4b94ae8f2421" Then 'Chứng chỉ/Chứng nhận học nghề dưới 3 tháng
                Return "5"
            ElseIf level = "a160b662-a3e8-4169-b79b-5a3993bfd494" Then 'Bằng nghề dài hạn/Trung cấp nghề/Trung học chuyên nghiệp
                Return "5"
            ElseIf level = "c1ea8748-9b86-488b-a718-2b845e050a2b" Then 'Công nhân kỹ thuật không có bằng nghề/Chứng chỉ nghề
                Return "5"
            ElseIf level = "ccc0f594-9482-46ac-9feb-c6b7a705fefb" Then 'Đại học trở lên
                Return "3"
            End If
        End Function
        Function changePosition(idKey As String) As String
            changePosition = ""
            If idKey = "0533e7d2-4ee2-4a58-86a7-db2fad9737f2" Then
                Return "2"
            ElseIf idKey = "107747fa-8372-45b7-ab32-5c8834f5e786" Then
                Return "13"
            ElseIf idKey = "146dd807-28d0-411c-bd6d-bd2b3019a3a9" Then
                Return "14"
            ElseIf idKey = "2a4c059b-9c2f-4372-9f56-f5dbc4f700da" Then
                Return "2"
            ElseIf idKey = "2cf2658f-e84f-46c6-a37b-22b638d853ce" Then
                Return "6"
            ElseIf idKey = "2ecb8cc8-cbe4-4952-84e7-5f5867a065e4" Then
                Return "14"
            ElseIf idKey = "5756580c-3318-40d5-9052-14a64d963a76" Then
                Return "6"
            ElseIf idKey = "90ef9bc6-c1b2-44bb-ab0d-7c663df907ca" Then
                Return "12"
            ElseIf idKey = "a50aa402-30c1-46a7-b8ae-663c31751479" Then
                Return "15"
            End If
        End Function
        Private Sub AddWorks(cbj As CMS_WorkInfo)
            obj = New APP.CMS_WorksInfo
            obj.Work_ID = cbj.Work_ID
            obj.Business_ID = cbj.Business_ID
            obj.Business_Name = cbj.Business_Vn
            obj.Title = flReg.RemoveScript(flReg.RemoveScript(cbj.Title, False))
            obj.Salary_ID = cbj.Salary_ID
            obj.Quantity = cbj.Quantity
            obj.Experience_ID = cbj.Experience_ID
            obj.Gender = changeGender(cbj.Gender)
            obj.Level_ID = changeLevel(cbj.Level_ID)
            obj.TinhTP = TinhTP.SelectedValue
            obj.QuanHuyen = cbj.QuanHuyen
            obj.TypeOf_ID = cbj.TypeOf_ID
            obj.Career_ID = cbj.Career_ID
            obj.Description = flReg.RemoveScript(flReg.RemoveScript(cbj.Description, False))
            obj.Requirement = flReg.RemoveScript(flReg.RemoveScript(cbj.Requirement, False))
            obj.Benefit = flReg.RemoveScript(flReg.RemoveScript(cbj.Benefit, False))
            obj.RequirementsProfile = flReg.RemoveScript(flReg.RemoveScript(cbj.RequirementsProfile, False))
            obj.ExpiredDate = cbj.ExpiredDate
            obj.SubmissionSend = flReg.RemoveScript(flReg.RemoveScript(cbj.SubmissionSend, False))
            obj.StartDate = cbj.StartDate
            obj.EndDate = cbj.EndDate
            obj.ContactUser = flReg.RemoveScript(flReg.RemoveScript(cbj.ContactUser, False))
            obj.ContactAddress = flReg.RemoveScript(flReg.RemoveScript(cbj.ContactAddress, False))
            obj.ContactMobile = flReg.RemoveScript(flReg.RemoveScript(cbj.ContactMobile, False))
            obj.ContactEmail = flReg.RemoveScript(flReg.RemoveScript(cbj.ContactEmail, False))
            obj.ContactDes = flReg.RemoveScript(flReg.RemoveScript(cbj.ContactDes, False))
            obj.IsHot = cbj.IsHot
            obj.IsFast = cbj.IsFast
            obj.IsUrgent = cbj.IsUrgent
            obj.IsApproval = True
            obj.ApprovalUser = Me.UserInfo.Username
            obj.ApprovalDate = cbj.StartDate
            obj.IsDelete = False
            obj.DeletedUser = ""
            obj.DeletedDate = flReg.DateNull()
            obj.CreatedDate = Now
            obj.CreatedUser = Me.UserInfo.Username
            obj.UpdatedDate = flReg.DateNull()
            obj.UpdatedUser = ""
            obj.LevelDesired_ID = changePosition(cbj.LevelDesired_ID)
            obj.IsView = cbj.IsView
            obj.IsFlag = cbj.IsFlag
            obj.JobPlace = cbj.JobPlace
            obj.WBID = cbj.ID
            appControl.CMS_Works_Add(Me.PortalId, obj)

            Call SaveWPublic(appControl.CMS_Works_Get(Me.PortalId, obj.Work_ID))
        End Sub
        Private Sub SaveWPublic(obj As APP.CMS_WorksInfo)
            Dim wpBj As New APP.CMS_WPublicInfo
            wpBj.ID = obj.ID
            wpBj.Work_ID = obj.Work_ID
            wpBj.Business_ID = obj.Business_ID
            wpBj.Business_Name = obj.Business_Name
            wpBj.Title = obj.Title
            wpBj.Salary_ID = obj.Salary_ID
            wpBj.Quantity = obj.Quantity
            wpBj.Experience_ID = obj.Experience_ID
            wpBj.Gender = obj.Gender
            wpBj.Level_ID = obj.Level_ID
            wpBj.TinhTP = obj.TinhTP
            wpBj.QuanHuyen = obj.QuanHuyen
            wpBj.TypeOf_ID = obj.TypeOf_ID
            wpBj.Career_ID = obj.Career_ID
            wpBj.Description = obj.Description
            wpBj.Requirement = obj.Requirement
            wpBj.Benefit = obj.Benefit
            wpBj.RequirementsProfile = obj.RequirementsProfile
            wpBj.ExpiredDate = obj.ExpiredDate
            wpBj.SubmissionSend = obj.SubmissionSend
            wpBj.LevelDesired_ID = obj.LevelDesired_ID
            wpBj.JobPlace = obj.JobPlace
            wpBj.StartDate = obj.StartDate
            wpBj.EndDate = obj.EndDate
            wpBj.ContactUser = obj.ContactUser
            wpBj.ContactAddress = obj.ContactAddress
            wpBj.ContactMobile = obj.ContactMobile
            wpBj.ContactEmail = obj.ContactEmail
            wpBj.ContactDes = obj.ContactDes
            wpBj.IsHot = obj.IsHot
            wpBj.IsFast = obj.IsFast
            wpBj.IsUrgent = obj.IsUrgent
            wpBj.IsView = obj.IsView
            wpBj.IsFlag = obj.IsFlag
            wpBj.WBID = obj.WBID
            wpBj.IsApproval = obj.IsApproval
            wpBj.ApprovalUser = obj.ApprovalUser
            wpBj.ApprovalDate = obj.ApprovalDate
            wpBj.CreatedDate = obj.CreatedDate
            wpBj.CreatedUser = obj.CreatedUser
            wpBj.UpdatedDate = obj.UpdatedDate
            wpBj.UpdatedUser = obj.UpdatedUser
            appControl.CMS_WPublic_Add(Me.PortalId, wpBj)
            Call SaveWorkCarrer(wpBj.Work_ID, wpBj.Career_ID)
            Call SavePrice(wpBj.Work_ID, wpBj.StartDate, wpBj.EndDate)
        End Sub
        Private Sub SavePrice(wID As String, startDate As DateTime, endDate As DateTime)
            Dim pbj As New APP.CMS_WPriceInfo
            pbj.ID = flReg.GenKey()
            pbj.Work_ID = wID
            pbj.PriceType_ID = 4
            pbj.PriceList_ID = "21f77efb-33f2-47b8-b179-c7cedb418a64"
            pbj.IsMoney = 0
            pbj.IsTimeEnd = 30
            pbj.IsLevel = 4
            pbj.IsOrder = 1
            pbj.IsClass = 0
            pbj.StartDate = New Date(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0)
            pbj.EndDate = New Date(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59)
            pbj.CreatedDate = Now
            pbj.CreatedUser = Me.UserInfo.Username
            pbj.UpdatedDate = flReg.DateNull
            pbj.UpdatedUser = ""
            appControl.CMS_WPrice_Add(Me.PortalId, pbj)
        End Sub 'Goi tin mien phi
        Private Sub SaveWorkCarrer(wID As String, CareerID As String)
            appControl.CMS_WorksCareer_Delete_By_CMS_Works(Me.PortalId, wID)
            str = CareerID.Split(",")
            Dim wcInfo As New APP.CMS_WorksCareerInfo
            For i As Integer = 0 To str.Length - 1
                If str(i) <> "" Then
                    wcInfo = New APP.CMS_WorksCareerInfo
                    wcInfo.Career_ID = str(i)
                    wcInfo.Work_ID = wID
                    appControl.CMS_WorksCareer_Add(Me.PortalId, wcInfo)
                End If
            Next
        End Sub
        Protected Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                icount = 0
                For i As Integer = 0 To grdData.Items.Count - 1
                    chBox = grdData.Items(i).FindControl("IsSelect")
                    If chBox.Checked = True Then
                        cbj = objController.CMS_Work_Get_ToApp(TinhTP.SelectedValue, grdData.DataKeys(i))
                        If IsNothing(cbj) = False Then
                            Call AddBuss(cbj.Business_ID)
                            Call AddWorks(cbj)
                        End If
                        icount = 1
                    End If
                Next
                If icount > 0 Then
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting();notify('success', 'Đã liên kết dữ liệu thành công.', 'Thông báo', false);", True)
                    Call LoadValues()
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "myFunction", "removewaiting();notify('info', 'Bạn chưa chọn doanh nghiệp để liên kết.', 'Thông báo', false);", True)
                End If
            Catch ex As SqlClient.SqlException
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, _tabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Response.Redirect(ViewState("backUrl"), True)
        End Sub
    End Class

End Namespace
