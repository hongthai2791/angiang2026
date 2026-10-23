<%@ WebService Language="VB" Class="WebserviceGolbal.WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Namespace WebserviceGolbal
    <WebService(Namespace:="http://tempuri.org/")>
    <WebServiceBinding(ConformsTo:=WsiProfiles.None)>
    <ScriptService()>
    Public Class WebService
        Dim ObjController As New WorkController
        Dim pid = GetPortalSettings.PortalId
        Dim arr As New ArrayList
        Dim strID As String
        'Private Sub SaveDictionaryD(Dictionary_ID As String, id As Integer, name As String, des As String, IsOrder As Integer)
        '    dicDinfo = New CMS_DictionaryDInfo
        '    dicDinfo.DictionaryD_ID = flReg.GenKey()
        '    dicDinfo.Dictionary_ID = Dictionary_ID
        '    dicDinfo.DictionaryD_Code = id
        '    dicDinfo.DictionaryD_Name = name
        '    dicDinfo.DictionaryD_Des = des
        '    dicDinfo.IsActive = True
        '    dicDinfo.IsOrder = IsOrder
        '    dicDinfo.CreatedBy = Now
        '    dicDinfo.UserName = "admin"
        '    dicDinfo.UpdatedBy = Now
        '    dicDinfo.UserUpdate = ""
        '    ObjController.SV_DictionaryD_Add(dicDinfo)
        'End Sub
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function TinTuyenDung(keyCode As String, Id As String, business_ID As String, title As String, salary_ID As String,
                                     quantity As Integer, experience_ID As String,
                                     gender As Integer, level_ID As String, regional_ID As String, typeOf_ID As String, career_ID As String,
                                     description As String, requirement As String, benefit As String, requirementsProfile As String,
                                     expiredDate As DateTime, submissionSend As String, startDate As DateTime, endDate As DateTime,
                                     contactUser As String, contactAddress As String, contactMobile As String, contactEmail As String,
                                     contactDes As String, isHot As Boolean, isFast As Boolean, IsUrgent As Boolean, Position_ID As String,
                                     JobPlace As String) As Boolean
            If keyCode <> "ntb" Then Return False
            Try
                Dim wkInfo As New CMS_WorkInfo
                wkInfo.IdSend = Id
                wkInfo.Work_ID = flReg.GenKey
                wkInfo.Business_ID = ObjController.SV_Business_Get_By_IdKey(pid, pid, business_ID)
                wkInfo.Title = title
                wkInfo.Salary_ID = ObjController.SV_Salary_Get_By_IdKey(pid, salary_ID) & ""
                wkInfo.Quantity = quantity
                wkInfo.Experience_ID = ObjController.SV_Experience_Get_By_IdKey(pid, experience_ID) & ""
                wkInfo.Gender = gender
                wkInfo.Level_ID = flDnn.SV_Education_Get_By_IdKey(pid, level_ID) & ""
                wkInfo.TinhTP = flDnn.SV_Regional_Get_By_IdKey(pid, regional_ID)
                wkInfo.TypeOf_ID = ObjController.SV_TypeOf_Get_By_IdKey(pid, typeOf_ID) & ""
                wkInfo.Career_ID = ObjController.SV_Career_Get_By_IdKey(pid, career_ID) & ""
                wkInfo.Description = description
                wkInfo.Requirement = requirement
                wkInfo.Benefit = benefit
                wkInfo.RequirementsProfile = requirementsProfile
                wkInfo.ExpiredDate = expiredDate
                wkInfo.SubmissionSend = submissionSend
                wkInfo.StartDate = startDate
                wkInfo.EndDate = endDate
                wkInfo.ContactUser = contactUser
                wkInfo.ContactAddress = contactAddress
                wkInfo.ContactMobile = contactMobile
                wkInfo.ContactEmail = contactEmail
                wkInfo.ContactDes = contactDes
                wkInfo.IsHot = isHot
                wkInfo.IsFast = isFast
                wkInfo.IsUrgent = IsUrgent
                wkInfo.IsApproval = False
                wkInfo.ApprovalUser = ""
                wkInfo.ApprovalDate = flReg.DateNull
                wkInfo.IsDelete = False
                wkInfo.DeletedUser = ""
                wkInfo.DeletedDate = flReg.DateNull
                wkInfo.CreatedDate = Now
                wkInfo.CreatedUser = "admin"
                wkInfo.UpdatedDate = Now
                wkInfo.UpdatedUser = "admin"
                wkInfo.IsView = 1
                wkInfo.IsSend = 0
                wkInfo.PortalID = GetPortalSettings.PortalId
                wkInfo.LevelDesired_ID = flDnn.SV_Position_Get_By_IdKey(pid, Position_ID) & ""
                wkInfo.IsFlag = 0
                wkInfo.JobPlace = ObjController.SV_JobPlace_Get_By_IdKey(pid, JobPlace) & ""
                ObjController.SV_Work_Add(pid, wkInfo)
                Return True
            Catch ex As Exception
                Dim s As String = ex.Message
                LogException(ex)
            End Try
            Return False
        End Function


        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function NhaTuyenDung(keyCode As String, Id As String, business_Vn As String, business_En As String, business_Sort As String, regional_ID As String, logo As String, description As String, taxCode As String, mobile As String, fax As String, website As String, email As String, address As String, contactUser As String, contactMobile As String, contactEmail As String, Scale As String) As Boolean
            If keyCode <> "ntb" Then Return False
            Try
                Dim busInfo As New CMS_BusinessInfo
                busInfo.Business_ID = flReg.GenKey
                busInfo.Business_Vn = business_Vn
                busInfo.Business_En = business_En
                busInfo.Business_Sort = business_Sort
                busInfo.TinhTP = flDnn.SV_Regional_Get_By_IdKey(pid, regional_ID)
                busInfo.Logo = logo
                busInfo.Description = description
                busInfo.TaxCode = taxCode
                busInfo.Mobile = mobile
                busInfo.Fax = fax
                busInfo.Website = website
                busInfo.Email = email
                busInfo.Address = address
                busInfo.ContactUser = contactUser
                busInfo.ContactMobile = contactMobile
                busInfo.ContactEmail = contactEmail
                busInfo.CreatedDate = Now
                busInfo.CreatedUser = "admin"
                busInfo.UpdatedDate = Now
                busInfo.UpdatedUser = "admin"
                busInfo.IsApproval = False
                busInfo.ApprovalUser = ""
                busInfo.ApprovalDate = flReg.DateNull
                busInfo.PortalId = GetPortalSettings.PortalId
                busInfo.Scale = Scale
                busInfo.IdSend = Id
                ObjController.SV_Business_Add(pid, busInfo)
                Return True
            Catch ex As Exception
                Dim s As String = ex.Message
            End Try
            Return False
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function TinhThanh(keyCode As String, regional_Name As String, Regional_Code As String, regional_Des As String, parent_ID As String, isOrder As Integer) As Boolean
            Try
                If keyCode <> "ntb" Then Return False
                Dim reInfo As New CMS_RegionalInfo
                reInfo.Regional_ID = flReg.GenKey
                reInfo.Regional_Name = regional_Name
                reInfo.Regional_Code = Regional_Code
                reInfo.Regional_Des = regional_Des
                reInfo.Parent_ID = flDnn.SV_Regional_Get_By_IdKey(pid, parent_ID)
                reInfo.IsActive = True
                reInfo.IsOrder = isOrder
                reInfo.CreatedDate = Now
                reInfo.CreatedUser = "admin"
                reInfo.UpdatedDate = Now
                reInfo.UpdatedUser = "admin"
                flDnn.CMS_Regional_Add(pid, reInfo)
            Catch ex As Exception
            End Try
            Return False
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function NganhNghe(keyCode As String, id As Integer, name As String, des As String, IsOrder As Integer) As Boolean
            Try
                Dim carInfo As New CMS_CareerInfo
                If keyCode <> "ntb" Then Return False
                strID = ObjController.SV_Career_Get_By_IdKey(pid, keyCode)
                If strID <> "" Then
                    carInfo.Career_ID = flReg.GenKey
                    carInfo.Career_Name = name
                    carInfo.Career_Code = keyCode
                    carInfo.Career_Des = des
                    carInfo.IsOrder = IsOrder
                    carInfo.CreatedBy = Now
                    carInfo.UserName = "admin"
                    carInfo.UpdatedBy = flReg.DateNull
                    carInfo.UserUpdate = ""
                    carInfo.ID = id
                    ObjController.SV_Career_Add(pid, carInfo)
                    Return True
                End If
            Catch ex As Exception
            End Try
            Return False
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function ChucVu(keyCode As String, id As Integer, name As String, des As String, IsOrder As Integer) As Boolean
            Try
                Dim posInfo As New CMS_PositionInfo
                If keyCode <> "ntb" Then Return False
                strID = flDnn.SV_Position_Get_By_IdKey(pid, keyCode)
                If strID <> "" Then
                    posInfo.Position_Name = name
                    posInfo.Position_Code = keyCode
                    posInfo.Position_Des = des
                    posInfo.IsOrder = IsOrder
                    posInfo.CreatedDate = Now
                    posInfo.CreatedUser = "admin"
                    posInfo.UpdatedDate = flReg.DateNull
                    posInfo.UpdatedUser = ""
                    posInfo.ID = id
                    flDnn.SV_Position_Add(pid, posInfo)
                    Return True
                End If
            Catch ex As Exception
            End Try
            Return False
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function NamKinhNghiem(keyCode As String, id As Integer, name As String, des As String, IsOrder As Integer) As Boolean
            Try
                Dim exInfo As New CMS_ExperienceInfo
                If keyCode <> "ntb" Then Return False
                strID = ObjController.SV_Experience_Get_By_IdKey(pid, keyCode)
                If strID <> "" Then
                    exInfo.Experience_ID = flReg.GenKey
                    exInfo.Experience_Name = name
                    exInfo.Experience_Code = keyCode
                    exInfo.Experience_Des = des
                    exInfo.IsOrder = IsOrder
                    exInfo.CreatedBy = Now
                    exInfo.UserName = "admin"
                    exInfo.UpdatedBy = flReg.DateNull
                    exInfo.UserUpdate = ""
                    exInfo.IdSend = id
                    ObjController.SV_Experience_Add(pid, exInfo)
                    Return True
                End If
            Catch ex As Exception
            End Try
            Return False
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function NhuCauLamViec(keyCode As String, id As Integer, name As String, des As String, IsOrder As Integer) As Boolean
            Try
                Dim ncInfo As New CMS_NeedsInfo
                If keyCode <> "ntb" Then Return False
                strID = ObjController.SV_Needs_Get_By_IdKey(pid, keyCode)
                If strID <> "" Then
                    ncInfo.Needs_ID = flReg.GenKey
                    ncInfo.Needs_Name = name
                    ncInfo.Needs_Code = keyCode
                    ncInfo.Needs_Des = des
                    ncInfo.IsOrder = IsOrder
                    ncInfo.CreatedBy = Now
                    ncInfo.UserName = "admin"
                    ncInfo.UpdatedBy = flReg.DateNull
                    ncInfo.UserUpdate = ""
                    ncInfo.IdSend = id
                    ObjController.SV_Needs_Add(pid, ncInfo)
                    Return True
                End If
            Catch ex As Exception
            End Try
            Return False
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function TrinhDo(keyCode As String, id As Integer, name As String, des As String, IsOrder As Integer) As Boolean
            Try
                Dim eduInfo As New CMS_EducationInfo
                If keyCode <> "ntb" Then Return False
                strID = flDnn.SV_Education_Get_By_IdKey(pid, keyCode)
                If strID <> "" Then
                    eduInfo.Education_Name = name
                    eduInfo.Education_Code = keyCode
                    eduInfo.Education_Des = des
                    eduInfo.IsOrder = IsOrder
                    eduInfo.CreatedDate = Now
                    eduInfo.CreatedUser = "admin"
                    eduInfo.UpdatedDate = flReg.DateNull
                    eduInfo.UpdatedUser = ""
                    eduInfo.IdSend = id
                    flDnn.SV_Education_Add(pid, eduInfo)
                    Return True
                End If
            Catch ex As Exception
            End Try
            Return False
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function TinhChatCongViec(keyCode As String, id As Integer, name As String, des As String, IsOrder As Integer) As Boolean
            Try
                Dim toInfo As New CMS_TypeOfInfo
                If keyCode <> "ntb" Then Return False
                strID = ObjController.SV_TypeOf_Get_By_IdKey(pid, keyCode)
                If strID <> "" Then
                    toInfo.TypeOf_ID = flReg.GenKey
                    toInfo.TypeOf_Name = name
                    toInfo.TypeOf_Code = keyCode
                    toInfo.TypeOf_Des = des
                    toInfo.IsOrder = IsOrder
                    toInfo.CreatedBy = Now
                    toInfo.UserName = "admin"
                    toInfo.UpdatedBy = flReg.DateNull
                    toInfo.UserUpdate = ""
                    toInfo.IdSend = id
                    ObjController.SV_TypeOf_Add(pid, toInfo)
                    Return True
                End If
            Catch ex As Exception
            End Try
            Return False
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function MucLuong(keyCode As String, id As Integer, name As String, des As String, IsOrder As Integer) As Boolean
            Try
                Dim saInfo As New CMS_SalaryInfo
                If keyCode <> "ntb" Then Return False
                strID = ObjController.SV_Salary_Get_By_IdKey(pid, keyCode)
                If strID <> "" Then
                    saInfo.Salary_ID = flReg.GenKey
                    saInfo.Salary_Name = name
                    saInfo.Salary_Code = keyCode
                    saInfo.Salary_Des = des
                    saInfo.IsOrder = IsOrder
                    saInfo.CreatedBy = Now
                    saInfo.UserName = "admin"
                    saInfo.UpdatedBy = flReg.DateNull
                    saInfo.UserUpdate = ""
                    saInfo.IdSend = id
                    ObjController.SV_Salary_Add(pid, saInfo)
                    Return True
                End If
            Catch ex As Exception
            End Try
            Return False
        End Function

        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function ListBusiness(keyCode As String) As String
            If keyCode <> "ntb" Then Return False
            Call flReg.SetContentResponse()
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
            Dim data = New Response
            Try
                Dim arrTmp As New ArrayList
                arr = ObjController.CMS_Business_List_By_TinhTP_IsOffline(pid, pid, 0, 0, False)
                For Each cr As CMS_BusinessInfo In arr
                    cr.TinhTP = flDic.Regional_Code(pid, cr.TinhTP)
                    cr.QuanHuyen = flDic.Regional_Code(pid, cr.QuanHuyen)
                    arrTmp.Add(cr)
                Next
                data.data = arrTmp
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            Catch ex As Exception
                data.data = ex.Message
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            End Try
            Return JsonConvert.SerializeObject(data, settings)
        End Function

        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function GetBusiness(keyCode As String, id As String) As String
            If keyCode <> "ntb" Then Return False
            Call flReg.SetContentResponse()
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
            Dim data = New Response
            Try
                Dim obj As New CMS_BusinessInfo
                obj = ObjController.CMS_Business_Get(pid, id)
                If IsNothing(obj) = False Then
                    obj.TinhTP = flDic.Regional_Code(pid, obj.TinhTP)
                    obj.QuanHuyen = flDic.Regional_Code(pid, obj.QuanHuyen)
                End If
                data.data = obj
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            Catch ex As Exception
                data.data = ex.Message
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            End Try
            Return JsonConvert.SerializeObject(data, settings)
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function UpdateBusiness_IsSent(keyCode As String, id As String) As String
            If keyCode <> "ntb" Then Return False
            Call flReg.SetContentResponse()
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
            Dim data = New Response
            Try
                ObjController.CMS_Business_Update_IsOffline(pid, id, True)
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            Catch ex As Exception
                data.data = ex.Message
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            End Try
            Return JsonConvert.SerializeObject(data, settings)
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function ListWork(keyCode As String) As String
            If keyCode <> "ntb" Then Return False
            Call flReg.SetContentResponse()
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
            Dim data = New Response
            Try
                Dim arrTmp As New ArrayList
                arr = ObjController.CMS_Work_List_By_TinhTP_IsOffline(pid, pid, 0, 0, False)
                For Each cr As CMS_WorkInfo In arr
                    cr.Salary_ID = flCheck.Salary_Code(pid, cr.Salary_ID)
                    cr.LevelDesired_ID = flDic.Position_Code(pid, cr.LevelDesired_ID)
                    cr.JobPlace = flCheck.JobPlace_Code(pid, cr.JobPlace)
                    cr.Level_ID = flDic.Education_Code(pid, cr.Level_ID)
                    cr.Experience_ID = flCheck.Experience_Code(pid, cr.Experience_ID)
                    cr.Career_ID = flCheck.Career_Code(pid, cr.Career_ID)
                    cr.TypeOf_ID = flCheck.TypeOf_Code(pid, cr.TypeOf_ID)
                    arrTmp.Add(cr)
                Next
                data.data = arrTmp
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            Catch ex As Exception
                data.data = ex.Message
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            End Try
            Return JsonConvert.SerializeObject(data, settings)
        End Function
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function UpdateWork_IsSent(keyCode As String, id As String) As String
            If keyCode <> "ntb" Then Return False
            Call flReg.SetContentResponse()
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
            Dim data = New Response
            Try
                ObjController.CMS_Work_Update_IsOffline(pid, id, True)
                data.status = ServiceStatus.SUCCESS
                data.message = "Success"
            Catch ex As Exception
                data.data = ex.Message
                data.message = "Error"
                data.status = ServiceStatus.FAILED
            End Try
            Return JsonConvert.SerializeObject(data, settings)
        End Function
    End Class
End Namespace
