Imports DotNetNuke.EPORTAL

Public Class flCheck

    Public Shared Function WorksCode(id As Integer) As String
        If id < 10 Then
            WorksCode = "0000" & id
        ElseIf id < 100 Then
            WorksCode = "000" & id
        ElseIf id < 1000 Then
            WorksCode = "00" & id
        Else
            WorksCode = id
        End If
    End Function
    Public Shared Function CheckInfoUser(PortalId As Integer, userName As String) As Boolean
        CheckInfoUser = flReg.ToBoolean(flCache.GetCache("CheckInfoUser_" & PortalId & "_" & userName) & "")
        If CheckInfoUser = False Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get_UserAdmin(PortalId, userName)
            If IsNothing(obj) = False Then
                If obj.IsApproval = False Then
                    flCache.SetCache("CheckInfoUser_" & PortalId & "_" & userName, obj.IsApproval, SecondCache.M5)
                    Return obj.IsApproval
                Else
                    flCache.SetCache("CheckInfoUser_" & PortalId & "_" & userName, obj.IsActive, SecondCache.M5)
                    Return obj.IsActive
                End If
            End If
        End If
    End Function
    Public Shared Function ReadCode(id As Integer) As String
        If id < 10 Then
            ReadCode = "0000" & id
        ElseIf id < 100 Then
            ReadCode = "000" & id
        ElseIf id < 1000 Then
            ReadCode = "00" & id
        Else
            ReadCode = id
        End If
    End Function
    Public Shared Function GioiTinh(Gender As Integer) As String
        Select Case Gender
            Case GenderType.KhongYeuCau
                Return "Không yêu cầu"
            Case GenderType.Nam
                Return "Nam"
            Case GenderType.Nu
                Return "Nữ"
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function TypeOf_Name(PortalConnect As Integer, TypeOf_ID As String) As String
        TypeOf_Name = flCache.GetCache("TypeOf_Name" & TypeOf_ID) & ""
        If TypeOf_Name = "" Then
            Dim obj As CMS_TypeOfInfo = New WorkController().CMS_TypeOf_Get(PortalConnect, TypeOf_ID)
            If IsNothing(obj) = False Then TypeOf_Name = flReg.RemoveScript(obj.TypeOf_Name, False)
            flCache.SetCache("TypeOf_Name" & TypeOf_ID, TypeOf_Name)
        End If
    End Function
    Public Shared Function TypeOf_Code(PortalConnect As Integer, TypeOf_ID As String) As String
        TypeOf_Code = flCache.GetCache("TypeOf_Code" & TypeOf_ID) & ""
        If TypeOf_Code = "" Then
            Dim obj As CMS_TypeOfInfo = New WorkController().CMS_TypeOf_Get(PortalConnect, TypeOf_ID)
            If IsNothing(obj) = False Then TypeOf_Code = flReg.RemoveScript(obj.TypeOf_Code, False)
            flCache.SetCache("TypeOf_Code" & TypeOf_ID, TypeOf_Code)
        End If
    End Function
    Public Shared Function Career_Name(PortalConnect As Integer, Career_ID As String) As String
        Career_Name = flCache.GetCache("Career_Name" & Career_ID) & ""
        If Career_Name = "" Then
            Dim obj As CMS_CareerInfo = New WorkController().CMS_Career_Get(PortalConnect, Career_ID)
			If IsNothing(obj) = False Then Career_Name = flReg.RemoveScript(obj.Career_Name, False)
			flCache.SetCache("Career_Name" & Career_ID, Career_Name)
        End If
    End Function
    Public Shared Function Career_Code(PortalConnect As Integer, Career_ID As String) As String
        Career_Code = flCache.GetCache("Career_Code" & Career_ID) & ""
        If Career_Code = "" Then
            Dim obj As CMS_CareerInfo = New WorkController().CMS_Career_Get(PortalConnect, Career_ID)
			If IsNothing(obj) = False Then Career_Code = flReg.RemoveScript(obj.Career_Code, False)
			flCache.SetCache("Career_Code" & Career_ID, Career_Code)
        End If
    End Function
    Public Shared Function Experience_Name(PortalConnect As Integer, Experience_ID As String) As String
        Experience_Name = flCache.GetCache("Experience_Name" & Experience_ID) & ""
        If Experience_Name = "" Then
            Dim obj As CMS_ExperienceInfo = New WorkController().CMS_Experience_Get(PortalConnect, Experience_ID)
            If IsNothing(obj) = False Then Experience_Name = flReg.RemoveScript(obj.Experience_Name, False)
            flCache.SetCache("Experience_Name" & Experience_ID, Experience_Name)
        End If
    End Function
    Public Shared Function Experience_Code(PortalConnect As Integer, Experience_ID As String) As String
        Experience_Code = flCache.GetCache("Experience_Code" & Experience_ID) & ""
        If Experience_Code = "" Then
            Dim obj As CMS_ExperienceInfo = New WorkController().CMS_Experience_Get(PortalConnect, Experience_ID)
            If IsNothing(obj) = False Then Experience_Code = flReg.RemoveScript(obj.Experience_Code, False)
            flCache.SetCache("Experience_Code" & Experience_ID, Experience_Code)
        End If
    End Function
    Public Shared Function Needs_Name(PortalConnect As Integer, Needs_ID As String) As String
        Needs_Name = flCache.GetCache("Needs_Name" & Needs_ID) & ""
        If Needs_Name = "" Then
            Dim obj As CMS_NeedsInfo = New WorkController().CMS_Needs_Get(PortalConnect, Needs_ID)
			If IsNothing(obj) = False Then Needs_Name = flReg.RemoveScript(obj.Needs_Name, False)
			flCache.SetCache("Needs_Name" & Needs_ID, Needs_Name)
        End If
    End Function
    Public Shared Function JobPlace_Name(PortalConnect As Integer, JobPlace_ID As String) As String
        JobPlace_Name = flCache.GetCache("JobPlace_Name" & JobPlace_ID) & ""
        If JobPlace_Name = "" Then
            Dim obj As CMS_JobPlaceInfo = New WorkController().CMS_JobPlace_Get(PortalConnect, JobPlace_ID)
            If IsNothing(obj) = False Then JobPlace_Name = flReg.RemoveScript(obj.JobPlace_Name, False)
            flCache.SetCache("JobPlace_Name" & JobPlace_ID, JobPlace_Name)
        End If
    End Function
    Public Shared Function JobPlace_Name_code(PortalConnect As Integer, JobPlace_Code As String) As String
        JobPlace_Name_code = flCache.GetCache("JobPlace_NameC" & JobPlace_Code) & ""
        If JobPlace_Name_code = "" Then
            Dim obj As CMS_JobPlaceInfo = New WorkController().CMS_JobPlace_Get_Code(PortalConnect, JobPlace_Code)
            If IsNothing(obj) = False Then JobPlace_Name_code = flReg.RemoveScript(obj.JobPlace_Name, False)
            flCache.SetCache("JobPlace_NameC" & JobPlace_Code, JobPlace_Name_code)
        End If
    End Function
    Public Shared Function JobPlace_Parents(PortalConnect As Integer, JobPlace_Pr As String) As String
        JobPlace_Parents = flCache.GetCache("JobPlace_Parent" & JobPlace_Pr) & ""
        If JobPlace_Parents = "" Then
            Dim obj As CMS_JobPlaceInfo = New WorkController().CMS_JobPlace_Get_Parents(PortalConnect, JobPlace_Pr)
            If IsNothing(obj) = False Then JobPlace_Parents = flReg.RemoveScript(obj.JobPlace_Name, False)
            flCache.SetCache("JobPlace_Parent" & JobPlace_Pr, JobPlace_Parents)
        End If
    End Function
    Public Shared Function JobPlace_Code(PortalConnect As Integer, JobPlace_ID As String) As String
        JobPlace_Code = flCache.GetCache("JobPlace_Code" & JobPlace_ID) & ""
        If JobPlace_Code = "" Then
            Dim obj As CMS_JobPlaceInfo = New WorkController().CMS_JobPlace_Get(PortalConnect, JobPlace_ID)
            If IsNothing(obj) = False Then JobPlace_Code = flReg.RemoveScript(obj.JobPlace_Code, False)
            flCache.SetCache("JobPlace_Code" & JobPlace_ID, JobPlace_Code)
        End If
    End Function
    Public Shared Function Salary_Name(PortalConnect As Integer, Salary_ID As String) As String
        Salary_Name = flCache.GetCache("Salary_Name" & Salary_ID) & ""
        If Salary_Name = "" Then
            Dim obj As CMS_SalaryInfo = New WorkController().CMS_Salary_Get(PortalConnect, Salary_ID)
            If IsNothing(obj) = False Then Salary_Name = flReg.RemoveScript(obj.Salary_Name, False)
            flCache.SetCache("Salary_Name" & Salary_ID, Salary_Name)
        End If
    End Function
    Public Shared Function Salary_Code(PortalConnect As Integer, Salary_ID As String) As String
        Salary_Code = flCache.GetCache("Salary_Code" & Salary_ID) & ""
        If Salary_Code = "" Then
            Dim obj As CMS_SalaryInfo = New WorkController().CMS_Salary_Get(PortalConnect, Salary_ID)
            If IsNothing(obj) = False Then Salary_Code = flReg.RemoveScript(obj.Salary_Code, False)
            flCache.SetCache("Salary_Code" & Salary_ID, Salary_Code)
        End If
    End Function
    Public Shared Function Business_Name(sUrl As String, PortalConnect As Integer, Business_ID As String, Optional ByVal viewAddress As Boolean = False, Optional ByVal viewHome As Boolean = False) As String
        Business_Name = flCache.GetCache("Business_Name_" & sUrl.Replace("/", "_") & viewAddress & "_" & viewHome & "_" & Business_ID) & ""
        If Business_Name = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
            If IsNothing(obj) = False Then
                If viewAddress = True Then
					Business_Name = "<div>Đơn vị: "
					If sUrl <> "" Then
                        If viewHome = False Then
                            Business_Name += "<a class='aedit' title='Chi tiết' href='/" & sUrl & "/itemid/" & obj.Business_ID & "'>"
                        Else
                            Business_Name += "<a target=""_bank"" href='/nha-tuyen-dung/" & LinkUrl(flReg.RemoveScript(obj.Business_Vn, False), obj.Business_ID, "DN") & "'>"
                        End If
                        Business_Name += "<b>" & flReg.RemoveScript(obj.Business_Vn, False) & "</b></a></div>"
                    Else
                        Business_Name += "<b>" & flReg.RemoveScript(obj.Business_Vn, False) & "</b></div>"
                    End If
					Business_Name += "<div>ĐT: <b>" & obj.Mobile & "</b></div>"
					Business_Name += "<div>ĐC: <b>" & obj.Address & "</b></div>"
				Else
                    Business_Name = flReg.RemoveScript(obj.Business_Vn, False)
                End If
            End If
            flCache.SetCache("Business_Name_" & sUrl.Replace("/", "_") & viewAddress & "_" & viewHome & "_" & Business_ID, Business_Name, SecondCache.M1)
        End If
    End Function
    Public Shared Function Business_Address(PortalConnect As Integer, Business_ID As String) As String
        Business_Address = flCache.GetCache("Business_Address" & Business_ID) & ""
        If Business_Address = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
            If IsNothing(obj) = False Then Business_Address = obj.Address
            flCache.SetCache("Business_Address" & Business_ID, Business_Address)
        End If
    End Function
    Public Shared Function Business_TaxCode(PortalConnect As Integer, Business_ID As String) As String
        Business_TaxCode = flCache.GetCache("Business_TaxCode" & Business_ID) & ""
        If Business_TaxCode = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
            If IsNothing(obj) = False Then Business_TaxCode = obj.TaxCode
            flCache.SetCache("Business_TaxCode" & Business_ID, Business_TaxCode)
        End If
    End Function
    Public Shared Function Business_Mobile(PortalConnect As Integer, Business_ID As String) As String
        Business_Mobile = flCache.GetCache("Business_Mobile" & Business_ID) & ""
        If Business_Mobile = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
            If IsNothing(obj) = False Then Business_Mobile = obj.Mobile
            flCache.SetCache("Business_Mobile" & Business_ID, Business_Mobile)
        End If
    End Function
    Public Shared Function Business_Email(PortalConnect As Integer, Business_ID As String) As String
        Business_Email = flCache.GetCache("Business_Email" & Business_ID) & ""
        If Business_Email = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
            If IsNothing(obj) = False Then Business_Email = obj.Email
            flCache.SetCache("Business_Email" & Business_ID, Business_Email)
        End If
    End Function
    Public Shared Function Business_ContactUser(PortalConnect As Integer, Business_ID As String) As String
        Business_ContactUser = flCache.GetCache("Business_ContactUser" & Business_ID) & ""
        If Business_ContactUser = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
            If IsNothing(obj) = False Then Business_ContactUser = obj.ContactUser
            flCache.SetCache("Business_ContactUser" & Business_ID, Business_ContactUser)
        End If
    End Function
	Public Shared Function Business_Vn(PortalConnect As Integer, Business_ID As String) As String
		Business_Vn = flCache.GetCache("Business_Vn_" & Business_ID) & ""
		If Business_Vn = "" Then
			Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
			If IsNothing(obj) = False Then Business_Vn = obj.Business_Vn
			flCache.SetCache("Business_Vn_" & Business_ID, Business_Vn)
		End If
	End Function
	Public Shared Function getBusiness_ID(PortalConnect As Integer, doanhNghiepID As String) As String
		getBusiness_ID = flCache.GetCache("getBusiness_ID_" & doanhNghiepID) & ""
		If getBusiness_ID = "" Then
			Dim obj As CMS_DoanhNghiepInfo = New WorkController().CMS_DoanhNghiep_Get(PortalConnect, doanhNghiepID)
			If IsNothing(obj) = False Then getBusiness_ID = obj.Business_ID
			flCache.SetCache("getBusiness_ID_" & doanhNghiepID, getBusiness_ID)
		End If
	End Function
	Public Shared Function Business_Code(PortalConnect As Integer, Business_ID As String) As String
        Business_Code = flCache.GetCache("Business_Code_" & Business_ID) & ""
        If Business_Code = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
            If IsNothing(obj) = False Then Business_Code = obj.ID
            flCache.SetCache("Business_Code_" & Business_ID, Business_Code)
        End If
    End Function
	Public Shared Function Business_Link(PortalConnect As Integer, Business_ID As String) As String
		Business_Link = flCache.GetCache("Business_Link_" & Business_ID) & ""
		If Business_Link = "" Then
			Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
			If IsNothing(obj) = False Then Business_Link = obj.Business_Vn & "-" & obj.ID
			flCache.SetCache("Business_Link_" & Business_ID, Business_Link)
		End If
	End Function
	Public Shared Function SoBan(PortalConnect As Integer, phienID As String, Business_ID As String) As Integer
		SoBan = flReg.WriteNumber(flCache.GetCache("SoBan_" & phienID & "_" & Business_ID))
		If SoBan = 0 Then
			Dim obj As CMS_DoanhNghiepInfo = New WorkController().CMS_DoanhNghiep_Get_By_Business_ID(PortalConnect, phienID, Business_ID)
			If IsNothing(obj) = False Then SoBan = obj.SoBan
			flCache.SetCache("SoBan_" & phienID & "_" & Business_ID, SoBan)
		End If
	End Function
    Public Shared Function JobUser_Link(PortalConnect As Integer, JobUser_ID As String) As String
        JobUser_Link = flCache.GetCache("JobUser_Link_" & JobUser_ID) & ""
        If JobUser_Link = "" Then
            Dim obj As CMS_JobUserInfo = New WorkController().CMS_JobUser_Get(PortalConnect, JobUser_ID)
            If IsNothing(obj) = False Then JobUser_Link = obj.Title & "-" & obj.ID
            flCache.SetCache("JobUser_Link_" & JobUser_ID, JobUser_Link)
        End If
    End Function
    Public Shared Function JobUser_UserAdmin(PortalConnect As Integer, JobUser_ID As String) As String
        JobUser_UserAdmin = flCache.GetCache("JobUser_UserAdmin_" & JobUser_ID) & ""
        If JobUser_UserAdmin = "" Then
            Dim obj As CMS_JobUserInfo = New WorkController().CMS_JobUser_Get(PortalConnect, JobUser_ID)
            If IsNothing(obj) = False Then JobUser_UserAdmin = obj.UserAdmin
            flCache.SetCache("JobUser_UserAdmin_" & JobUser_ID, JobUser_UserAdmin)
        End If
    End Function
    Public Shared Function JobUser_ID(PortalConnect As Integer, ID As String) As String
        JobUser_ID = flCache.GetCache("JobUser_ID_" & ID) & ""
        If JobUser_ID = "" Then
            Dim obj As CMS_JobUserInfo = New WorkController().CMS_JobUser_Get_ID(PortalConnect, ID)
            If IsNothing(obj) = False Then JobUser_ID = obj.JobUser_ID
            flCache.SetCache("JobUser_ID_" & ID, JobUser_ID)
        End If
    End Function
    Public Shared Function LinkWork_Name(PortalConnect As Integer, Work_ID As String) As String
        LinkWork_Name = flCache.GetCache("LinkWork_Name" & Work_ID) & ""
        If LinkWork_Name = "" Then
            Dim obj As CMS_WorkInfo = New WorkController().CMS_Work_Get(PortalConnect, Work_ID)
            If IsNothing(obj) = False Then
                LinkWork_Name = "<a target=""_bank"" href='" & flReg.WebConfig("works") & "/viec-lam/" & LinkUrl(obj.Title, obj.ID, "VL") & "'>" & obj.Title & "</a>"
            End If
            flCache.SetCache("LinkWork_Name" & Work_ID, LinkWork_Name)
        End If
    End Function
    Public Shared Function getWork_ID(PortalConnect As Integer, ID As Integer) As String
        getWork_ID = flCache.GetCache("getWork_ID_" & ID) & ""
        If getWork_ID = "" Then
            Dim obj As CMS_WorkInfo = New WorkController().CMS_Work_Get_ID(PortalConnect, ID)
            If IsNothing(obj) = False Then
                getWork_ID = obj.Work_ID
                flCache.SetCache("getWork_ID_" & ID, getWork_ID)
            End If
        End If
    End Function
    Public Shared Function getPhienGD_ID(PortalConnect As Integer, ID As Integer) As String
        getPhienGD_ID = flCache.GetCache("getPhienGD_ID" & ID) & ""
        If getPhienGD_ID = "" Then
            Dim obj As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(PortalConnect, ID)
            If IsNothing(obj) = False Then
                getPhienGD_ID = obj.PhienGD_ID
                flCache.SetCache("getPhienGD_ID" & ID, getPhienGD_ID)
            End If
        End If
    End Function
    Public Shared Function LinkUrl(title As String, id As String, Flag As String) As String
        title = flReg.NameUrl(title)
        LinkUrl = flCache.GetCache("linkurl_" & title & Flag & id) & ""
        If LinkUrl = "" Then
            If id = "" Then
                LinkUrl = title & ".html"
            Else
                LinkUrl = title & "-" & id & ".html"
            End If
            flCache.SetCache("linkurl_" & title & Flag & id, LinkUrl)
        End If
    End Function
    Public Shared Function Work_Name(sUrl As String, PortalConnect As Integer, Work_ID As String, Optional ByVal viewSend As Boolean = False, Optional ByVal viewHome As Boolean = False) As String
        Work_Name = flCache.GetCache("Work_" & sUrl.Replace("/", "_") & viewSend & viewHome & Work_ID) & ""
        If Work_Name = "" Then
            Dim obj As CMS_WorkInfo = New WorkController().CMS_Work_Get(PortalConnect, Work_ID)
            If IsNothing(obj) = False Then
                If viewSend = True Then
                    Work_Name = "<div>Việc làm: "
                    If sUrl <> "" Then
                        If viewHome = False Then
                            Work_Name += "<a class='aedit' title='Chi tiết' href='/" & sUrl & "/itemid/" & obj.Work_ID & "'>"
                        Else
							Work_Name += "<a target=""_bank"" href='" & flReg.WebConfig("works") & "/viec-lam/" & LinkUrl(obj.Title, obj.Work_ID, "VL") & "'>"
						End If
                        Work_Name += "<b>" & obj.Title & "</b></a></div>"
                    Else
                        Work_Name += "<b>" & obj.Title & "</b></div>"
                    End If

                    Work_Name += "<div>Lượt xem: <b>" & flReg.FormatPrice(obj.IsView) & "</b></div>"
                Else
                    Work_Name = obj.Title
                End If
            End If
            flCache.SetCache("Work_" & sUrl.Replace("/", "_") & viewSend & viewHome & Work_ID, Work_Name)
        End If
    End Function
    Public Shared Function JobUser_Name(sUrl As String, PortalConnect As Integer, JobUser_ID As String, Optional ByVal appDate As Boolean = False, Optional ByVal viewHome As Boolean = False) As String
        JobUser_Name = flCache.GetCache("JobUser_" & sUrl.Replace("/", "_") & appDate & viewHome & JobUser_ID) & ""
        If JobUser_Name = "" Then
            Dim obj As CMS_JobUserInfo = New WorkController().CMS_JobUser_Get(PortalConnect, JobUser_ID)
            If IsNothing(obj) = False Then
                If appDate = True Then
                    JobUser_Name = "<div>Hồ sơ xin việc: "
                    If sUrl <> "" Then
                        If viewHome = False Then
                            JobUser_Name += "<a class='aedit' title='Chi tiết' href='/" & sUrl & "/itemid/" & obj.JobUser_ID & "'>"
                        Else
                            JobUser_Name += "<a targer=""_bank"" href='" & flReg.WebConfig("works") & "/ho-so-tuyen-dung/" & LinkUrl(obj.Title, obj.JobUser_ID, "HS") & "'>"
                        End If
                        JobUser_Name += "<b>" & obj.Title & "</b></a></div>"
                    Else
                        JobUser_Name += "<b>" & obj.Title & "</b></div>"
                    End If
                    'JobUser_Name += "<div>Ngày đăng tin: <b>" & flReg.ReadDate(obj.StartDate) & "</b></div>"
                Else
                    JobUser_Name = obj.Title
                End If
            End If
            flCache.SetCache("JobUser_" & sUrl.Replace("/", "_") & appDate & viewHome & JobUser_ID, JobUser_Name)
        End If
    End Function
    Public Shared Function JobUser_Name_SVL(PortalConnect As Integer, JobUser_ID As String) As String
        JobUser_Name_SVL = flCache.GetCache("JobUser_Name_SVL" & JobUser_ID) & ""
        If JobUser_Name_SVL = "" Then
            Dim obj As CMS_JobUserInfo = New WorkController().CMS_JobUser_Get(PortalConnect, JobUser_ID)
            If IsNothing(obj) = False Then
                JobUser_Name_SVL = "<span style=""color:#d86196;font-weight:700;"">" & obj.Title & "</span><br/>"
            End If
            flCache.SetCache("JobUser_Name_SVL" & JobUser_ID, JobUser_Name_SVL)
        End If
    End Function
    Public Shared Function Business_Logo(PortalConnect As Integer, Business_ID As String) As String
        Business_Logo = flCache.GetCache("Business_Logo_" & Business_ID) & ""
        If Business_Logo = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get(PortalConnect, Business_ID)
            If IsNothing(obj) = False Then
                flCache.SetCache("Business_Logo_" & Business_ID, obj.Logo)
                Business_Logo = obj.Logo
            End If
        End If
        If Business_Logo = "" Then Business_Logo = "/image/images/noimage.png"
    End Function
	Public Shared Function JobUser_Avatar(PortalConnect As Integer, JobUser_ID As String) As String
		JobUser_Avatar = flCache.GetCache("JobUser_Avatar_" & JobUser_ID) & ""
        If JobUser_Avatar = "" Then
            Dim obj As CMS_JobUserInfo = New WorkController().CMS_JobUser_Get(PortalConnect, JobUser_ID)
            If IsNothing(obj) = False Then
                flCache.SetCache("JobUser_Avatar_" & JobUser_ID, flDic.PhotoURLFile(obj.UserAdmin, PortalConnect))
                JobUser_Avatar = flDic.PhotoURLFile(obj.UserAdmin, PortalConnect)
            End If
        End If
        If JobUser_Avatar = "" Then JobUser_Avatar = "/image/images/noavatar.png"
	End Function
	Public Shared Function DoanhNghiep_ID(PortalConnect As Integer, phienGD As String, Business_ID As String) As String
        DoanhNghiep_ID = flCache.GetCache("DoanhNghiep_ID" & phienGD & Business_ID) & ""
        If DoanhNghiep_ID = "" Then
            Dim obj As CMS_DoanhNghiepInfo = New WorkController().CMS_DoanhNghiep_Get_By_Business_ID(PortalConnect, phienGD, Business_ID)
            If IsNothing(obj) = False Then
                flCache.SetCache("DoanhNghiep_ID" & phienGD & Business_ID, obj.DoanhNghiep_ID)
                Return obj.DoanhNghiep_ID
            End If
        End If
    End Function
    Public Shared Function UngVien_ID(PortalConnect As Integer, phienGD As String, UserName As String) As String
        UngVien_ID = flCache.GetCache("UngVien_ID" & phienGD & UserName) & ""
        If UngVien_ID = "" Then
            Dim obj As CMS_UngVienInfo = New WorkController().CMS_UngVien_Get_PhienGD_ID(PortalConnect, phienGD, UserName)
            If IsNothing(obj) = False Then
                flCache.SetCache("UngVien_ID" & phienGD & UserName, obj.UngVien_ID)
                Return obj.UngVien_ID
            End If
        End If
    End Function
    Public Shared Function Business_ID(PortalConnect As Integer, UserAdmin As String) As String
        Business_ID = flCache.GetCache("Business_ID" & UserAdmin) & ""
        If Business_ID = "" Then
            Dim obj As CMS_BusinessInfo = New WorkController().CMS_Business_Get_UserAdmin(PortalConnect, UserAdmin)
            If IsNothing(obj) = False Then
                flCache.SetCache("Business_ID" & UserAdmin, obj.Business_ID)
                Return obj.Business_ID
            End If
        End If
    End Function
    Public Shared Function GetHomeLinkPlace(Name As String, ByVal Id As String) As String
		Return flReg.WebConfig("works") & "/vi-tri/" & flCheck.LinkUrl(Name, Id, "NN")
	End Function
    Public Shared Function GetHomeLinkWork(Title As String, ByVal Work_ID As String) As String
		Return flReg.WebConfig("works") & "/viec-lam/" & flCheck.LinkUrl(Title, Work_ID, "VL")
	End Function
    Public Shared Function GetHomeLinkBusiness(Business_ID As String) As String
		Return flReg.WebConfig("works") & "/nha-tuyen-dung/" & flCheck.LinkUrl(flCheck.Business_Link(flConnect.PortalId, Business_ID), "", "DN")
	End Function
    Public Shared Function GetHomeLinkJobUser(JobUser_ID As String) As String
		Return flReg.WebConfig("works") & "/ho-so-xin-viec/" & flCheck.LinkUrl(flCheck.JobUser_Link(flConnect.PortalId, JobUser_ID), "", "HSXV")
	End Function
    Public Shared Function GetHomeLinkRegional(Title As String, ByVal Id As String) As String
		Return flReg.WebConfig("works") & "/khu-vuc/" & flCheck.LinkUrl(Title, Id, "KV")
	End Function
    Public Shared Function GetLinkProfile(Name As String, ByVal Id As String) As String
		Return flReg.WebConfig("works") & "/ho-so-tuyen-dung/" & flCheck.LinkUrl(Name, Id, "HS")
	End Function
    Public Shared Function GetHomeProfileLinkJob(Id As String) As String
		Return flReg.WebConfig("works") & "/ho-so-tim-kiem/car/" & Id.ToString
	End Function
    Public Shared Function GetHomeProfileLinkReg(Id As String) As String
		Return flReg.WebConfig("works") & "/ho-so-tim-kiem/reg/" & Id.ToString
	End Function
    Public Shared Function GetHomeLinkJob(Name As String, ByVal Id As String) As String
        Return flReg.WebConfig("works") & "/nganh-nghe/" & flCheck.LinkUrl(Name, Id, "NN")
    End Function
    Public Shared Function CheckInJobView(PortalID As Integer, idKey As String, usName As String) As Boolean
        CheckInJobView = flReg.ToBoolean(flCache.GetCache("CheckInJobView_" & PortalID & "_" & idKey & "_" & usName))
        If CheckInJobView = False Then
            Dim temp As Boolean = New WorkController().CMS_JobView_Check(PortalID, idKey, usName)
            flCache.SetCache("CheckInJobView_" & PortalID & "_" & idKey & "_" & usName, temp)
            Return temp
        End If
    End Function
    Public Shared Function CheckInWorkInvite(PortalID As Integer, WorkID As String, BusID As String) As Boolean
        CheckInWorkInvite = flReg.ToBoolean(flCache.GetCache("CheckInWorkInvite" & PortalID & "_" & WorkID & "_" & BusID))
        If CheckInWorkInvite = False Then
            Dim temp As Boolean = New WorkController().CMS_WorkInvite_Check(PortalID, WorkID, BusID)
            flCache.SetCache("CheckInWorkInvite" & PortalID & "_" & WorkID & "_" & BusID, temp)
            Return temp
        End If
    End Function
    Public Shared Function CheckInJobInvite(PortalID As Integer, JobID As String, BusID As String) As Boolean
        CheckInJobInvite = flReg.ToBoolean(flCache.GetCache("CheckInJobInvite_" & PortalID & "_" & JobID & "_" & BusID))
        If CheckInJobInvite = False Then
            Dim temp As Boolean = New WorkController().CMS_JobInvite_Check(PortalID, JobID, BusID)
            flCache.SetCache("CheckInJobInvite_" & PortalID & "_" & JobID & "_" & BusID, temp)
            Return temp
        End If
    End Function
    Public Shared Function ProfileMember(UserName As String, Optional ByVal isUrl As Boolean = True) As String
        ProfileMember = flCache.GetCache("ProfileMember_" & UserName) & ""
        If ProfileMember = "" Then
            For Each Cr As DnnInfo In flDnn.DNN_User_Get(flConnect.PortalId, UserName)
                If isUrl Then
                    ProfileMember = "<div>Họ tên: <a target=""_bank"" href='/thong-tin-ung-vien/" & LinkUrl(Cr.FullName, Cr.UserID, "UV") & "'>"
                    ProfileMember += "<b>" & Cr.FullName & "</b></a></div>"
                Else
                    ProfileMember = "<div>Họ tên: "
                    ProfileMember += "<b>" & Cr.FullName & "</b></div>"
                End If
                ProfileMember += "<div>Email: <b>" & Cr.Email & "</b> - "
                ProfileMember += "Điện thoại: <b>" & Cr.Telephone & "</b></div>"
                ProfileMember += "<div>Ngày đăng ký: <b>" & flReg.ReadDate(Cr.CreatedOnDate) & "</b></div>"
            Next
            flCache.SetCache("ProfileMember_" & UserName, ProfileMember)
        End If
    End Function
    Public Shared Function SVL_TinhTrangUngVien(pid As Integer, pgd As String, tid As String, ntv As String) As Boolean
        Dim obj As New CMS_DoanhNghiep_UngVienInfo
        Dim objCTL As New WorkController
        obj = objCTL.CMS_DoanhNghiep_UngVien_TinhTrang(pid, pgd, tid, ntv, 1)
        If IsNothing(obj) = False Then
            If obj.IsStatus = 0 Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function
    Public Shared Function SVL_TinhTrangDoanhNghiep(pid As Integer, pgd As String, dn As String) As Boolean
        Dim obj As New CMS_DoanhNghiepInfo
        Dim objCTL As New WorkController
        obj = objCTL.CMS_DoanhNghiep_Get_By_Business_ID(pid, pgd, dn)
        If IsNothing(obj) = False Then
            If obj.TinhTrangThamGia = 0 Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function
    Public Shared Function SVL_TinhTrangHoSo(pid As Integer, pgd As String, tid As String, ntv As String) As Integer
        Dim obj As New CMS_DoanhNghiep_UngVienInfo
        Dim objCTL As New WorkController
        obj = objCTL.CMS_DoanhNghiep_UngVien_TinhTrang(pid, pgd, tid, ntv, 0)
        If IsNothing(obj) = False Then
            Return obj.KetQuaPhongVan
        Else
            Return 0
        End If
    End Function
    Public Shared Function TinhTrangTin(pid As Integer, Workid As String) As Boolean
        Dim obj As New CMS_WorkInfo
        Dim objCTL As New WorkController
        obj = objCTL.CMS_Work_Get(pid, Workid)
        If IsNothing(obj) = False Then
            If obj.IsApproval = 0 Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function
    'Public Shared Function getHoVaTen_UserProfile(pid As Integer, userName As String) As String
    '    Dim objCTL As New WorkController
    '    getHoVaTen_UserProfile = flCache.GetCache("getHoVaTen_UserProfile_" & userName) & ""
    '    If getHoVaTen_UserProfile = "" Then
    '        Dim objUs = objCTL.CMS_UserProfile_Get_By_UserName(pid, userName)
    '        If IsNothing(objUs) = False Then
    '            getHoVaTen_UserProfile = objUs.HoVaTen
    '            flCache.SetCache("getHoVaTen_UserProfile_" & userName, getHoVaTen_UserProfile)
    '        End If
    '    End If
    'End Function
    'Public Shared Function JobUser_Code(PortalConnect As Integer, JobUser_ID As String) As Integer
    '    JobUser_Code = flReg.WriteNumber(flCache.GetCache("JobUser_Code_" & JobUser_ID))
    '    If JobUser_Code = 0 Then
    '        Dim obj As CMS_JobUserInfo = New WorkController().CMS_JobUser_Get(PortalConnect, JobUser_ID)
    '        If IsNothing(obj) = False Then
    '            JobUser_Code = obj.ID
    '            flCache.SetCache("JobUser_Code_" & JobUser_ID, JobUser_Code)
    '        End If
    '    End If
    'End Function
#Region "DaoTaoNghe"

    Public Shared Function DTNGHE_NgheDaoTao_Name(ID As String) As String
        DTNGHE_NgheDaoTao_Name = flCache.GetCache("DTNGHE_NgheDaoTao_Name" & ID) & ""
        If DTNGHE_NgheDaoTao_Name = "" Then
            Dim obj As DTNGHE_NgheDaoTaoInfo = New WorkController().DTNGHE_NgheDaoTao_Get(ID)
            If IsNothing(obj) = False Then DTNGHE_NgheDaoTao_Name = flReg.RemoveScript(obj.Name, False)
            flCache.SetCache("DTNGHE_NgheDaoTao_Name" & ID, obj.Name, SecondCache.M60)
        End If
    End Function

    Public Shared Function DTNGHE_KetQuaDaoTao_Name(ID As String) As String
        DTNGHE_KetQuaDaoTao_Name = flCache.GetCache("DTNGHE_KetQuaDaoTao_Name" & ID) & ""
        If DTNGHE_KetQuaDaoTao_Name = "" Then
            Dim obj As DTNGHE_KetQuaDaoTaoInfo = New WorkController().DTNGHE_KetQuaDaoTao_Get(ID)
            If IsNothing(obj) = False Then DTNGHE_KetQuaDaoTao_Name = flReg.RemoveScript(obj.Name, False)
            flCache.SetCache("DTNGHE_KetQuaDaoTao_Name" & ID, obj.Name, SecondCache.M60)
        End If
    End Function

    Public Shared Function DTNGHE_ThoiGianDaoTao_Name(ID As String) As String
        DTNGHE_ThoiGianDaoTao_Name = flCache.GetCache("DTNGHE_ThoiGianDaoTao_Name" & ID) & ""
        If DTNGHE_ThoiGianDaoTao_Name = "" Then
            Dim obj As DTNGHE_ThoiGianDaoTaoInfo = New WorkController().DTNGHE_ThoiGianDaoTao_Get(ID)
            If IsNothing(obj) = False Then DTNGHE_ThoiGianDaoTao_Name = flReg.RemoveScript(obj.Name, False)
            flCache.SetCache("DTNGHE_ThoiGianDaoTao_Name" & ID, obj.Name, SecondCache.M60)
        End If
    End Function

#End Region
End Class

