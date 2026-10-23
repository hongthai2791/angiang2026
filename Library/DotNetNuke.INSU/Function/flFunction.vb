Imports System.Web.UI.WebControls
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.EPORTAL

Public Class flFunction
    Shared strOld As String
    Shared arrTemp, arrTemp1 As New ArrayList
    Shared ObjControler As New InsuController
    Shared str() As String

#Region "DB_DM CHUNG"

    Public Shared Sub LoadDVTV(drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem(("Tư vấn việc làm"), "1"))
        drGroup.Items.Add(New ListItem(("Tư vấn học nghề"), "2"))
        drGroup.Items.Add(New ListItem(("Khác"), "3"))
    End Sub
    Public Shared Sub LoadGioiTinh(drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem(("Nam"), "1"))
        drGroup.Items.Add(New ListItem(("Nữ"), "0"))
        drGroup.Items.Add(New ListItem(("Khác"), "2"))
    End Sub
    Public Shared Sub LoadPortals(PortalId As Integer, dr As DropDownList, Optional ByVal all As Boolean = False)
        dr.Items.Clear()
        If UserInfo.Username <> "host" Then
            strOld = flReg.ProvinND(PortalId, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
            str = strOld.Split(";")
            For i As Integer = 0 To str.Length - 1
                If flReg.WriteNumber(str(i)) <> 0 Then
                    dr.Items.Add(New ListItem(flCheck.Portal_Name(PortalId, str(i)), str(i)))
                End If
            Next
        End If
        If dr.Items.Count = 0 Then
            If IsNothing(flCache.GetCache("CMS_Portal_List_" & PortalId)) Then
                arrTemp1 = ObjControler.CMS_Portal_List(PortalId)
                flCache.SetCache("CMS_Portal_List_" & PortalId, arrTemp1)
            Else
                arrTemp1 = CType(flCache.GetCache("CMS_Portal_List_" & PortalId), ArrayList)
            End If
            If all = True Then dr.Items.Add(New ListItem("- - - Tất cả các đơn vị - - ", -1))
            For Each Ci As CMS_PortalInfo In arrTemp1
                dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.PortalName, False), Ci.PortalID))
            Next
        End If
    End Sub
    Public Shared Sub LoadStatus(drGroup As DropDownList, Optional ByVal all As String = "[All],[Moi],[NVu]")
        drGroup.Items.Clear()
        If all = "All" Then
            drGroup.Items.Add(New ListItem("- -  Tất cả - -", -2))
            drGroup.Items.Add(New ListItem("Đang soạn", TrangThaiHS.DangSoan))
            drGroup.Items.Add(New ListItem("Đã gửi hồ sơ", TrangThaiHS.DaNop))
            drGroup.Items.Add(New ListItem("Bị trả lại", TrangThaiHS.TraLai))
        ElseIf all = "Moi" Then
            drGroup.Items.Add(New ListItem("Đang soạn", TrangThaiHS.DangSoan))
            drGroup.Items.Add(New ListItem("Đã gửi hồ sơ", TrangThaiHS.DaNop))
        ElseIf all = "KBVL" Then
            drGroup.Items.Add(New ListItem("- -  Tất cả - -", -2))
            drGroup.Items.Add(New ListItem("Chờ xử lý", TrangThaiHS.DaNop))
            drGroup.Items.Add(New ListItem("Đã tiếp nhận", TrangThaiHS.ChuyenXuLy))
            drGroup.Items.Add(New ListItem("Bị trả lại", TrangThaiHS.TraLai))
        Else
            drGroup.Items.Add(New ListItem("- -  Tất cả - -", -2))
            drGroup.Items.Add(New ListItem("Đã tiếp nhận", TrangThaiHS.TiepNhan))
            drGroup.Items.Add(New ListItem("Đang xử lý", TrangThaiHS.ChuyenXuLy))
            drGroup.Items.Add(New ListItem("Đã hoàn thành", TrangThaiHS.QuyetDinh))
            drGroup.Items.Add(New ListItem("Bị trả lại", TrangThaiHS.TraLai))
            drGroup.Items.Add(New ListItem("Đã trả kết quả", TrangThaiHS.TraKQ))
        End If

    End Sub
    Public Shared Sub LoadField(PortalId As Integer, drGroup As DropDownList, Optional ByVal sNull As Boolean = False, Optional ByVal text As String = "- - - Chọn - - -")
        arrTemp = ObjControler.CMS_Field_List(PortalId, PortalId)
        drGroup.Items.Clear()
        If sNull = True Then drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_FieldInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Field_Name, False), Ci.Field_ID.ToLower))
        Next
    End Sub
    Public Shared Sub LoadWage(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Wage_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_WageInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Wage_Name, False), Ci.Wage_ID))
        Next
    End Sub
    Public Shared Sub LoadTerminated(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Terminated_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TerminatedInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Terminated_Name, False), Ci.Terminated_ID))
        Next
    End Sub
    Public Shared Sub LoadTechnology(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Technology_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TechnologyInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Technology_Name, False), Ci.Technology_ID))
        Next
    End Sub
    Public Shared Sub LoadTechnical(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Technical_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TechnicalInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Technical_Name, False), Ci.Technical_ID))
        Next
    End Sub
    Public Shared Sub LoadSpecialized(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Specialized_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_SpecializedInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Specialized_Name, False), Ci.Specialized_ID))
        Next
    End Sub
    Public Shared Sub LoadSkill(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Skill_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_SkillInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Skill_Name, False), Ci.Skill_ID))
        Next
    End Sub
    Public Shared Sub LoadSalary(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Salary_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_SalaryInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Salary_Name, False), Ci.Salary_ID))
        Next
    End Sub
    Public Shared Sub LoadRecruitment(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Recruitment_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_RecruitmentInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Recruitment_Name, False), Ci.Recruitment_ID))
        Next
    End Sub
    Public Shared Sub LoadPreIndu(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_PreIndu_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_PreInduInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.PreIndu_Name, False), Ci.PreIndu_ID))
        Next
    End Sub
    Public Shared Sub LoadPreCareer(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_PreCareer_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_PreCareerInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.PreCareer_Name, False), Ci.PreCareer_ID))
        Next
    End Sub
    Public Shared Sub LoadLocation(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Location_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_LocationInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Location_Name, False), Ci.Location_ID))
        Next
    End Sub
    Public Shared Sub LoadLeaving(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Leaving_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_LeavingInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Leaving_Name, False), Ci.Leaving_ID))
        Next
    End Sub
    Public Shared Sub LoadLaborType(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_LaborType_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_LaborTypeInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.LaborType_Name, False), Ci.LaborType_ID))
        Next
    End Sub
    Public Shared Sub LoadField(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Field_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_FieldInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Field_Name, False), Ci.Field_ID))
        Next
    End Sub
    Public Shared Sub LoadDecidedType(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_DecidedType_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_DecidedTypeInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.DecidedType_Name, False), Ci.DecidedType_ID))
        Next
    End Sub
    Public Shared Sub LoadContractType(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_ContractType_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_ContractTypeInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.ContractType_Name, False), Ci.ContractType_ID))
        Next
    End Sub
    Public Shared Sub LoadComType(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_ComType_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_ComTypeInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Comtype_Name, False), Ci.ComType_ID))
        Next
    End Sub
    Public Shared Sub LoadCauseOf(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_CauseOf_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_CauseOfInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.CauseOf_Name, False), Ci.CauseOf_ID))
        Next
    End Sub
    Public Shared Sub LoadBanking(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Banking_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_BankingInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Banking_Name, False), Ci.Banking_ID))
        Next
    End Sub
    Public Shared Sub LoadCannot(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Cannot_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_CannotInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Cannot_Name, False), Ci.Cannot_ID))
        Next
    End Sub
    Public Shared Sub LoadCareer(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_CareerInfo In ObjControler.CMS_Career_List(PortalId, PortalId)
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Career_Name, False), Ci.Career_ID))
        Next
    End Sub
#End Region

#Region "DB_Trung tam"
    Private Shared Sub LoadUnit(PortalId As Integer, Unit_ID As String, strO As String)
        For Each Cis As CMS_UnitInfo In ObjControler.CMS_Unit_Get_By_CMS_Unit(PortalId, Unit_ID)
            strOld = strO & "|--- "
            Cis.Unit_Name = strOld & " " & Cis.Unit_Name
            arrTemp1.Add(Cis)
            Call LoadUnit(PortalId, Cis.Unit_ID, strOld)
        Next
    End Sub
    Public Shared Sub LoadUnit(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        arrTemp = ObjControler.CMS_Unit_List_Parent_NULL(PortalId, PortalId)
        arrTemp1.Clear()
        For Each Ci As CMS_UnitInfo In arrTemp
            arrTemp1.Add(Ci)
            Call LoadUnit(PortalId, Ci.Unit_ID, "")
        Next
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_UnitInfo In arrTemp1
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Unit_Name, False), Ci.Unit_ID))
        Next
    End Sub
    Public Shared Sub LoadUnitParentID(PortalId As Integer, drGroup As DropDownList, Unit_ID As String, Optional ByVal getSelect As Boolean = True, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Unit_Get_By_CMS_Unit(PortalId, Unit_ID)
        If getSelect = True Then drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_UnitInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Unit_Name, False), Ci.Unit_ID))
        Next
    End Sub
    Public Shared Sub LoadUnitParentNull(PortalId As Integer, drGroup As DropDownList, Optional ByVal getSelect As Boolean = True, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Unit_List_Parent_NULL(PortalId, PortalId)
        If getSelect = True Then drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_UnitInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Unit_Name, False), Ci.Unit_ID))
        Next
    End Sub
    Public Shared Sub LoadSigner(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Signer_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_SignerInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Signer_Name, False), Ci.Signer_ID))
        Next
    End Sub
    Public Shared Sub LoadSatellite(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Satellite_List(PortalId, PortalId)
        If text <> "" Then
            drGroup.Items.Add(New ListItem(text, ""))
        End If
        For Each Ci As CMS_SatelliteInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Satellite_Name, False), Ci.Satellite_ID))
        Next
    End Sub

    Public Shared Sub LoadFlagService(drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        drGroup.Items.Add(New ListItem("Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp", FlagService.DKBHTN))
        drGroup.Items.Add(New ListItem("Nộp hồ sơ đăng ký hỗ trợ học nghề", FlagService.DKHN))
        drGroup.Items.Add(New ListItem("Nộp hồ sơ đăng ký tư vấn, giới thiệu việc làm", FlagService.DKTVGTVL))
        drGroup.Items.Add(New ListItem("Nộp hồ sơ đăng ký thông báo tìm kiếm việc làm", FlagService.TBTKVL))
    End Sub
    Public Shared Sub LoadRecipients(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Recipients_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_RecipientsInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Recipients_Name, False), Ci.Recipients_ID))
        Next
    End Sub
    Public Shared Sub LoadInsurance(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Insurance_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_InsuranceInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Insurance_Name, False), Ci.Insurance_ID))
        Next
    End Sub
    Public Shared Sub LoadCourse(PortalId As Integer, drGroup As DropDownList, TrainingID As String, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Course_Gey_By_CMS_Training(PortalId, PortalId, TrainingID)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_CourseInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Course_Name, False), Ci.Course_ID))
        Next
    End Sub
    Public Shared Sub LoadBranch(PortalId As Integer, drGroup As DropDownList, Banking_ID As String, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Branch_Get_By_CMS_Banking(PortalId, Banking_ID, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_BranchInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Branch_Name, False), Ci.Branch_ID))
        Next
    End Sub
    Public Shared Sub LoadTraining(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Training_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TrainingInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Training_Name, False), Ci.Training_ID))
        Next
    End Sub
    Public Shared Sub LoadCompany(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        arrTemp = ObjControler.CMS_Company_List(PortalId, PortalId)
        drGroup.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_CompanyInfo In arrTemp
            drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Company_Name, False), Ci.Company_ID))
        Next
    End Sub
#End Region

End Class
