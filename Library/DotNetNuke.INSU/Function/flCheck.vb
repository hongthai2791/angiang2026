Imports DotNetNuke.EPORTAL

Public Class flCheck
    Private Shared arrTemp As New ArrayList
    Shared str() As String
    Public Shared Function TenDVTV(isType As Integer) As String
        TenDVTV = ""
        Select Case isType
            Case 1
                TenDVTV = "Tư vấn việc làm"
            Case 2
                TenDVTV = "Tư vấn học nghề"
            Case Else
                TenDVTV = "Tư vấn khác"
        End Select
    End Function
    Public Shared Function NoCode(pid As Integer, isType As Integer) As String
        Return flReg.FormatNumber(isType) & Now.ToString("yyMMdd") & flReg.CodeNumber(New InsuController().EXE_Insurrance_Count_Add(pid, isType))
    End Function
    Public Shared Function GetCode(pid As Integer, Id As String, isType As Integer) As String
        GetCode = flCache.GetCache("GetCode_" & pid & "_" & Id & "_" & isType) & ""
        If GetCode = "" Then
            Select Case isType
                Case ProType.TCTN
                    Dim obj As EXE_ProSubsiInfo = New InsuController().EXE_ProSubsi_Get(pid, Id)
                    If IsNothing(obj) = False Then GetCode = obj.NoCode
                Case ProType.TVGT
                    Dim obj As EXE_AdvisoryInfo = New InsuController().EXE_Advisory_Get(pid, Id)
                    If IsNothing(obj) = False Then GetCode = obj.NoCode
                Case ProType.KBVL
                    Dim obj As EXE_NotificationInfo = New InsuController().EXE_Notification_Get(pid, Id)
                    If IsNothing(obj) = False Then GetCode = obj.NoCode
                Case ProType.DKXH
                    Dim obj As EXE_NumberAutoInfo = New InsuController().EXE_NumberAuto_Get(pid, Id)
                    If IsNothing(obj) = False Then GetCode = obj.NoCode
                Case Else 'ProType.HTHN 
                    Dim obj As EXE_ApprenticeInfo = New InsuController().EXE_Apprentice_Get(pid, Id)
                    If IsNothing(obj) = False Then GetCode = obj.NoCode
            End Select
            If GetCode <> "" Then flCache.SetCache("GetCode_" & pid & "_" & Id & "_" & isType, GetCode)
        End If
    End Function
    Public Shared Function Recipients_Name(PortalId As Integer, Recipients_ID As String) As String
        Recipients_Name = flCache.GetCache("Recipients_Name" & PortalId & Recipients_ID) & ""
        If Recipients_Name = "" Then
            Dim Info As CMS_RecipientsInfo = New InsuController().CMS_Recipients_Get(PortalId, Recipients_ID)
            If IsNothing(Info) = False Then
                Recipients_Name = flReg.RemoveScript(Info.Recipients_Name, False)
                flCache.SetCache("Recipients_Name" & PortalId & Recipients_ID, Recipients_Name)
            End If
        End If
    End Function
    Public Shared Function Portal_Name(PortalConnect As Integer, pID As String) As String
        Portal_Name = flCache.GetCache("Portal_Name" & PortalConnect & pID) & ""
        If Portal_Name = "" Then
            Dim Info As CMS_PortalInfo = New InsuController().CMS_Portal_Get(PortalConnect, pID)
            If IsNothing(Info) = False Then
                Portal_Name = flReg.RemoveScript(Info.PortalName, False)
                flCache.SetCache("Portal_Name" & PortalConnect & pID, Portal_Name)
            End If
        End If
    End Function
    Public Shared Function Satellite_ID(PortalConnect As Integer, Satellite_Code As String) As String
        Satellite_ID = flCache.GetCache("Satellite_ID" & PortalConnect & Satellite_Code) & ""
        If Satellite_ID = "" Then
            Dim Info As CMS_SatelliteInfo = New InsuController().CMS_Satellite_Get_ByCode(PortalConnect, Satellite_Code)
            If IsNothing(Info) = False Then
                Satellite_ID = flReg.RemoveScript(Info.Satellite_ID, False)
                flCache.SetCache("Satellite_ID" & PortalConnect & Satellite_Code, Satellite_ID)
            End If
        End If
    End Function
    Public Shared Function Career_Name(PortalId As Integer, Career_ID As String) As String
        Career_Name = flCache.GetCache("Career_Name" & PortalId & Career_ID) & ""
        If Career_Name = "" Then
            Dim Info As CMS_CareerInfo = New InsuController().CMS_Career_Get(PortalId, Career_ID)
            If IsNothing(Info) = False Then
                Career_Name = flReg.RemoveScript(Info.Career_Name, False)
                flCache.SetCache("Career_Name" & PortalId & Career_ID, Career_Name)
            End If
        End If
    End Function
    Public Shared Function CareerNames(PortalId As Integer, Career_ID As String) As String
        CareerNames = flCache.GetCache("CareerNames" & PortalId & Career_ID) & ""
        If CareerNames = "" Then
            str = Career_ID.Split(",")
            For i As Integer = 0 To str.Length - 1
                If str(i) <> "" Then
                    CareerNames += Career_Name(PortalId, str(i)) & "; "
                End If
            Next
            If CareerNames.Length > 2 Then CareerNames = CareerNames.Substring(0, CareerNames.LastIndexOf(";"))
            flCache.SetCache("CareerNames" & PortalId & Career_ID, CareerNames)
        End If
    End Function
    Public Shared Function UnitParent(PortalId As Integer, Id As String) As String
        UnitParent = flCache.GetCache("UnitParent" & PortalId & Id)
        If UnitParent = "" Then
            Dim Info As CMS_UnitInfo = New InsuController().CMS_Unit_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                UnitParent = flReg.RemoveScript(Info.Parent_ID, False)
                flCache.SetCache("UnitParent" & PortalId & Id, UnitParent)
            End If
        End If
    End Function
    Public Shared Function Unit_Name(PortalId As Integer, Id As String) As String
        Unit_Name = flCache.GetCache("Unit_" & PortalId & Id)
        If Unit_Name = "" Then
            Dim Info As CMS_UnitInfo = New InsuController().CMS_Unit_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Unit_Name = flReg.RemoveScript(Info.Unit_Name, False)
                flCache.SetCache("Unit_" & PortalId & Id, Unit_Name)
            End If
        End If
    End Function
    Public Shared Function Field_Name(PortalId As Integer, Id As String) As String
        Field_Name = flCache.GetCache("Field_" & PortalId & Id)
        If Field_Name = "" Then
            Dim Info As CMS_FieldInfo = New InsuController().CMS_Field_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Field_Name = flReg.RemoveScript(Info.Field_Name, False)
                flCache.SetCache("Field_" & PortalId & Id, Field_Name)
            End If
        End If
    End Function
    Public Shared Function Field_Names(PortalId As Integer, Id As String) As String
        str = Id.Split(",")
        Field_Names = ""
        For i As Integer = 0 To str.Length - 1
            Field_Names += "- " & PortalId & Field_Name(PortalId, str(i)) & "<br/>"
        Next
        If Field_Names.Length > 0 Then Field_Names = Field_Names.Substring(0, Field_Names.LastIndexOf("<"))
    End Function
    Public Shared Function Wage_Name(PortalId As Integer, Id As String) As String
        Wage_Name = flCache.GetCache("Wage_" & PortalId & Id)
        If Wage_Name = "" Then
            Dim Info As CMS_WageInfo = New InsuController().CMS_Wage_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Wage_Name = flReg.RemoveScript(Info.Wage_Name, False)
                flCache.SetCache("Wage_" & PortalId & Id, Wage_Name)
            End If
        End If
    End Function
    Public Shared Function Terminated_Name(PortalId As Integer, Id As String) As String
        Terminated_Name = flCache.GetCache("Terminated_" & PortalId & Id)
        If Terminated_Name = "" Then
            Dim Info As CMS_TerminatedInfo = New InsuController().CMS_Terminated_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Terminated_Name = flReg.RemoveScript(Info.Terminated_Name, False)
                flCache.SetCache("Terminated_" & PortalId & Id, Terminated_Name)
            End If
        End If
    End Function
    Public Shared Function Training_Name(PortalId As Integer, Id As String) As String
        Training_Name = flCache.GetCache("Training_" & PortalId & Id)
        If Training_Name = "" Then
            Dim Info As CMS_TrainingInfo = New InsuController().CMS_Training_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Training_Name = flReg.RemoveScript(Info.Training_Name, False)
                flCache.SetCache("Training_" & PortalId & Id, Training_Name)
            End If
        End If
    End Function
    Public Shared Function Technology_Name(PortalId As Integer, Id As String) As String
        Technology_Name = flCache.GetCache("Technology_" & PortalId & Id)
        If Technology_Name = "" Then
            Dim Info As CMS_TechnologyInfo = New InsuController().CMS_Technology_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Technology_Name = flReg.RemoveScript(Info.Technology_Name, False)
                flCache.SetCache("Technology_" & PortalId & Id, Technology_Name)
            End If
        End If
    End Function
    Public Shared Function Specialized_Name(PortalId As Integer, Id As String) As String
        Specialized_Name = flCache.GetCache("Specialized_" & PortalId & Id)
        If Specialized_Name = "" Then
            Dim Info As CMS_SpecializedInfo = New InsuController().CMS_Specialized_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Specialized_Name = flReg.RemoveScript(Info.Specialized_Name, False)
                flCache.SetCache("Specialized_" & PortalId & Id, Specialized_Name)
            End If
        End If
    End Function
    Public Shared Function Technical_Name(PortalId As Integer, Id As String) As String
        Technical_Name = flCache.GetCache("Technical_" & PortalId & Id)
        If Technical_Name = "" Then
            Dim Info As CMS_TechnicalInfo = New InsuController().CMS_Technical_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Technical_Name = flReg.RemoveScript(Info.Technical_Name, False)
                flCache.SetCache("Technical_" & PortalId & Id, Technical_Name)
            End If
        End If
    End Function
    Public Shared Function Skill_Name(PortalId As Integer, Id As String) As String
        Skill_Name = flCache.GetCache("Skill_" & PortalId & Id)
        If Skill_Name = "" Then
            Dim Info As CMS_SkillInfo = New InsuController().CMS_Skill_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Skill_Name = flReg.RemoveScript(Info.Skill_Name, False)
                flCache.SetCache("Skill_" & PortalId & Id, Skill_Name)
            End If
        End If
    End Function
    Public Shared Function Signer_Name(PortalId As Integer, Id As String) As String
        Signer_Name = flCache.GetCache("Signer_" & PortalId & Id)
        If Signer_Name = "" Then
            Dim Info As CMS_SignerInfo = New InsuController().CMS_Signer_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Signer_Name = flReg.RemoveScript(Info.Signer_Name, False)
                flCache.SetCache("Signer_" & PortalId & Id, Signer_Name)
            End If
        End If
    End Function
    Public Shared Function Satellite_Name(PortalId As Integer, Id As String) As String
        Satellite_Name = flCache.GetCache("Satellite_" & PortalId & Id)
        If Satellite_Name = "" Then
            Dim Info As CMS_SatelliteInfo = New InsuController().CMS_Satellite_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Satellite_Name = flReg.RemoveScript(Info.Satellite_Name, False)
                flCache.SetCache("Satellite_" & PortalId & Id, Satellite_Name)
            End If
        End If
    End Function
    Public Shared Function Salary_Name(PortalId As Integer, Id As String) As String
        Salary_Name = flCache.GetCache("Salary_" & PortalId & Id)
        If Salary_Name = "" Then
            Dim Info As CMS_SalaryInfo = New InsuController().CMS_Salary_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Salary_Name = flReg.RemoveScript(Info.Salary_Name, False)
                flCache.SetCache("Salary_" & PortalId & Id, Salary_Name)
            End If
        End If
    End Function
    Public Shared Function Recruitment_Name(PortalId As Integer, Id As String) As String
        Recruitment_Name = flCache.GetCache("Recruitment_" & PortalId & Id)
        If Recruitment_Name = "" Then
            Dim Info As CMS_RecruitmentInfo = New InsuController().CMS_Recruitment_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Recruitment_Name = flReg.RemoveScript(Info.Recruitment_Name, False)
                flCache.SetCache("Recruitment_" & PortalId & Id, Recruitment_Name)
            End If
        End If
    End Function
    Public Shared Function PreIndu_Name(PortalId As Integer, Id As String) As String
        PreIndu_Name = flCache.GetCache("PreIndu_" & PortalId & Id)
        If PreIndu_Name = "" Then
            Dim Info As CMS_PreInduInfo = New InsuController().CMS_PreIndu_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                PreIndu_Name = flReg.RemoveScript(Info.PreIndu_Name, False)
                flCache.SetCache("PreIndu_" & PortalId & Id, PreIndu_Name)
            End If
        End If
    End Function
    Public Shared Function PreCareer_Name(PortalId As Integer, Id As String) As String
        PreCareer_Name = flCache.GetCache("PreCareer_" & PortalId & Id)
        If PreCareer_Name = "" Then
            Dim Info As CMS_PreCareerInfo = New InsuController().CMS_PreCareer_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                PreCareer_Name = flReg.RemoveScript(Info.PreCareer_Name, False)
                flCache.SetCache("PreCareer_" & PortalId & Id, PreCareer_Name)
            End If
        End If
    End Function
    Public Shared Function Location_Name(PortalId As Integer, Id As String) As String
        Location_Name = flCache.GetCache("Location_" & PortalId & Id)
        If Location_Name = "" Then
            Dim Info As CMS_LocationInfo = New InsuController().CMS_Location_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Location_Name = flReg.RemoveScript(Info.Location_Name, False)
                flCache.SetCache("Location_" & PortalId & Id, Location_Name)
            End If
        End If
    End Function
    Public Shared Function Leaving_Name(PortalId As Integer, Id As String) As String
        Leaving_Name = flCache.GetCache("Leaving_" & PortalId & Id)
        If Leaving_Name = "" Then
            Dim Info As CMS_LeavingInfo = New InsuController().CMS_Leaving_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Leaving_Name = flReg.RemoveScript(Info.Leaving_Name, False)
                flCache.SetCache("Leaving_" & PortalId & Id, Leaving_Name)
            End If
        End If
    End Function
    Public Shared Function LaborType_Name(PortalId As Integer, Id As String) As String
        LaborType_Name = flCache.GetCache("LaborType_" & PortalId & Id)
        If LaborType_Name = "" Then
            Dim Info As CMS_LaborTypeInfo = New InsuController().CMS_LaborType_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                LaborType_Name = flReg.RemoveScript(Info.LaborType_Name, False)
                flCache.SetCache("LaborType_" & PortalId & Id, LaborType_Name)
            End If
        End If
    End Function
    Public Shared Function Insurance_Name(PortalId As Integer, Id As String) As String
        Insurance_Name = flCache.GetCache("Insurance_" & PortalId & Id)
        If Insurance_Name = "" Then
            Dim Info As CMS_InsuranceInfo = New InsuController().CMS_Insurance_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Insurance_Name = flReg.RemoveScript(Info.Insurance_Name, False)
                flCache.SetCache("Insurance_" & PortalId & Id, Insurance_Name)
            End If
        End If
    End Function
    Public Shared Function DecidedType_Name(PortalId As Integer, Id As String) As String
        DecidedType_Name = flCache.GetCache("DecidedType_" & PortalId & Id)
        If DecidedType_Name = "" Then
            Dim Info As CMS_DecidedTypeInfo = New InsuController().CMS_DecidedType_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                DecidedType_Name = flReg.RemoveScript(Info.DecidedType_Name, False)
                flCache.SetCache("DecidedType_" & PortalId & Id, DecidedType_Name)
            End If
        End If
    End Function
    Public Shared Function Course_Name(PortalId As Integer, Id As String) As String
        Course_Name = flCache.GetCache("Course_" & PortalId & Id)
        If Course_Name = "" Then
            Dim Info As CMS_CourseInfo = New InsuController().CMS_Course_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Course_Name = flReg.RemoveScript(Info.Course_Name, False)
                flCache.SetCache("Course_" & PortalId & Id, Course_Name)
            End If
        End If
    End Function
    Public Shared Function ContractType_Name(PortalId As Integer, Id As String) As String
        ContractType_Name = flCache.GetCache("ContractType_" & PortalId & Id)
        If ContractType_Name = "" Then
            Dim Info As CMS_ContractTypeInfo = New InsuController().CMS_ContractType_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                ContractType_Name = flReg.RemoveScript(Info.ContractType_Name, False)
                flCache.SetCache("ContractType_" & PortalId & Id, ContractType_Name)
            End If
        End If
    End Function
    Public Shared Function Company_Name(PortalId As Integer, Id As String) As String
        Company_Name = flCache.GetCache("Company_" & PortalId & Id)
        If Company_Name = "" Then
            Dim Info As CMS_CompanyInfo = New InsuController().CMS_Company_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Company_Name = flReg.RemoveScript(Info.Company_Name, False)
                flCache.SetCache("Company_" & PortalId & Id, Company_Name)
            End If
        End If
    End Function
    Public Shared Function ComType_Name(PortalId As Integer, Id As String) As String
        ComType_Name = flCache.GetCache("ComType_" & PortalId & Id)
        If ComType_Name = "" Then
            Dim Info As CMS_ComTypeInfo = New InsuController().CMS_ComType_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                ComType_Name = flReg.RemoveScript(Info.Comtype_Name, False)
                flCache.SetCache("ComType_" & PortalId & Id, ComType_Name)
            End If
        End If
    End Function
    Public Shared Function CauseOf_Name(PortalId As Integer, Id As String) As String
        CauseOf_Name = flCache.GetCache("CauseOf_" & PortalId & Id)
        If CauseOf_Name = "" Then
            Dim Info As CMS_CauseOfInfo = New InsuController().CMS_CauseOf_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                CauseOf_Name = flReg.RemoveScript(Info.CauseOf_Name, False)
                flCache.SetCache("CauseOf_" & PortalId & Id, CauseOf_Name)
            End If
        End If
    End Function
    Public Shared Function Cannot_Name(PortalId As Integer, Id As String) As String
        Cannot_Name = flCache.GetCache("Cannot_" & PortalId & Id)
        If Cannot_Name = "" Then
            Dim Info As CMS_CannotInfo = New InsuController().CMS_Cannot_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Cannot_Name = flReg.RemoveScript(Info.Cannot_Name, False)
                flCache.SetCache("Cannot_" & PortalId & Id, Cannot_Name)
            End If
        End If
    End Function
    Public Shared Function Branch_Name(PortalId As Integer, Id As String) As String
        Branch_Name = flCache.GetCache("Branch_" & PortalId & Id)
        If Branch_Name = "" Then
            Dim Info As CMS_BranchInfo = New InsuController().CMS_Branch_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Branch_Name = flReg.RemoveScript(Info.Branch_Name, False)
                flCache.SetCache("Branch_" & PortalId & Id, Branch_Name)
            End If
        End If
    End Function
    Public Shared Function Banking_Name(PortalId As Integer, Id As String) As String
        Banking_Name = flCache.GetCache("Banking_" & PortalId & Id)
        If Banking_Name = "" Then
            Dim Info As CMS_BankingInfo = New InsuController().CMS_Banking_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Banking_Name = flReg.RemoveScript(Info.Banking_Name, False)
                flCache.SetCache("Banking_" & PortalId & Id, Banking_Name)
            End If
        End If
    End Function
    Private Shared Function ValNumber(number As Integer, count As Integer) As String
        If number.ToString.Length < count Then
            ValNumber = ""
            For i As Integer = 0 To count - number.ToString.Length - 1
                ValNumber &= "0"
            Next
            ValNumber &= number + 1
        Else
            Return number + 1
        End If
    End Function
    Public Shared Function OffTime(PortalConnect As Integer, intEndDate As Integer, startDate As DateTime) As DateTime
        If intEndDate = 0 Then
            Return flReg.DateNull
        Else
            Dim dateTemp, dateNew As DateTime
            Dim intD, intCount, intK As Integer
            intD = 0 : intCount = 0
            intD = intEndDate
            Dim s As String = ""
            '---- Begin 1: Đếm có bao nhiêu T7 và CN trong khoảng thời gian 
            For i As Integer = 0 To intD - 1
                dateTemp = DateAdd(DateInterval.Day, i, startDate)
                If dateTemp.DayOfWeek = DayOfWeek.Sunday Then
                    intCount += 1 'Chu nhat 
                    s += dateTemp.ToString("dd/MM/yyyy") & "_"
                ElseIf dateTemp.DayOfWeek = DayOfWeek.Saturday Then
                    intCount += 1 'Thu 7
                    s += dateTemp.ToString("dd/MM/yyyy") & "_"
                End If
                intK = New InsuController().CMS_DayOff_Get_OffTime(PortalConnect, dateTemp) 'Nghi bu
                If intK > 0 Then
                    intCount += intK
                    s += dateTemp.ToString("dd/MM/yyyy") & "_"
                End If
            Next
            intD = intEndDate + intCount - 1
            '----- End 1

            '--- Begin 2: Kiểm tra ngày kết thúc có vào T7 và CN không?
            dateTemp = DateAdd(DateInterval.Day, intD, startDate)
            If dateTemp.DayOfWeek = DayOfWeek.Sunday Then
                intD += 1
                s += dateTemp.ToString("dd/MM/yyyy") & "_"
            End If
            If dateTemp.DayOfWeek = DayOfWeek.Saturday Then
                intD += 2
                s += dateTemp.ToString("dd/MM/yyyy") & "_"
            End If

            dateNew = DateAdd(DateInterval.Day, intD, startDate)
            intK = New InsuController().CMS_DayOff_Get_OffTime(PortalConnect, dateNew)
            If intK > 0 Then
                intD = intD + intK
                s += dateNew.ToString("dd/MM/yyyy") & "_"
            End If
            '--- End 2

            '--- Begin 3: Kiểm tra ngày kết thúc sau khi cộng ngày nghỉ lễ có vào T7 và CN không?
            dateTemp = DateAdd(DateInterval.Day, intD, startDate)
            If dateTemp.DayOfWeek = DayOfWeek.Sunday Then
                intD += 1
                s += dateTemp.ToString("dd/MM/yyyy") & "_"
            End If
            If dateTemp.DayOfWeek = DayOfWeek.Saturday Then
                intD += 2
                s += dateTemp.ToString("dd/MM/yyyy") & "_"
            End If
            '--- End 3

            intCount = 0
            For i As Integer = intEndDate To intD
                dateTemp = DateAdd(DateInterval.Day, i, startDate)
                If dateTemp.DayOfWeek = DayOfWeek.Sunday And s.Contains(dateTemp.ToString("dd/MM/yyyy")) = False Then
                    intCount += 1 'Chu nhat 
                ElseIf dateTemp.DayOfWeek = DayOfWeek.Saturday And s.Contains(dateTemp.ToString("dd/MM/yyyy")) = False Then
                    intCount += 1 'Thu 7
                End If
                If s.Contains(dateTemp.ToString("dd/MM/yyyy")) = False Then
                    intCount += New InsuController().CMS_DayOff_Get_OffTime(PortalConnect, dateTemp) 'Nghi bu
                End If
            Next
            Return DateAdd(DateInterval.Day, intD + intCount, startDate)
        End If
    End Function
    Public Shared Function getTrangThai(trangThai As Integer) As String
        Select Case trangThai
            Case TrangThaiHS.DangSoan
                Return "Đang soạn"
            Case TrangThaiHS.DaNop
                Return "Đã nộp"
            Case TrangThaiHS.TiepNhan
                Return "Tiếp nhận"
            Case TrangThaiHS.TraLai
                Return "Trả lại"
            Case TrangThaiHS.ChuyenXuLy
                Return "Đang xử lý"
            Case TrangThaiHS.QuyetDinh
                Return "Hoàn thành"
            Case Else 'TrangThaiHS.TraKQ
                Return "Trả kết quả"
        End Select
    End Function
    Public Shared Function getFlagTypeName(flagType As Integer) As String
        Select Case flagType
            Case FlagService.DKBHTN
                Return "Nộp hồ sơ hưởng bảo hiểm thất nghiệp"
            Case FlagService.DKHN
                Return "Đăng ký hỗ trợ học nghề"
            Case FlagService.DKTVGTVL
                Return "Đăng ký tư vấn, giới thiệu việc làm"
            Case FlagService.TBTKVL
                Return "Thông báo tìm kiếm việc làm"
            Case Else
                Return "Đăng ký nhận kết quả hồ sơ"
        End Select
    End Function
    Public Shared Function getNumDoor(portalID As Integer, satelliteID As String, flagType As Integer) As String
        getNumDoor = flCache.GetCache("Insu_SettingNumDoor_" & portalID & "_" & satelliteID & "_" & flagType)
        If getNumDoor = "" Then
            Dim objCTL As New InsuController
            Dim obj As New CMS_SettingAutoInfo
            obj = objCTL.CMS_SettingAuto_Get_ByPortal(portalID, portalID, satelliteID, flagType)
            If IsNothing(obj) = False Then
                getNumDoor = obj.NumDoor.ToString()
                flCache.SetCache("Insu_SettingNumDoor_" & portalID & "_" & satelliteID & "_" & flagType, getNumDoor)
            End If
        End If
    End Function
End Class
Public Enum TrangThaiHS
    DangSoan = -1
    DaNop = 0
    TiepNhan
    TraLai
    ChuyenXuLy
    QuyetDinh
    TraKQ
End Enum
Public Enum ProType
    TCTN = 1
    TVGT
    HTHN
    KBVL
    DKXH
End Enum
Public Enum numberStatus
    DangCho
    QuaLuot
    DaPhucVu
End Enum