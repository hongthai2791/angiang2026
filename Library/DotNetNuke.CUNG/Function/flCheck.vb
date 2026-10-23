Imports DotNetNuke.EPORTAL
Public Class flCheck
    Shared objController As New CungController()
    Public Shared Function WorkJoin_Name(PortalConnect As Integer, WorkJoinID As String) As String
        WorkJoin_Name = flCache.GetCache("WorkJoin_Name_" & WorkJoinID) & ""
        If WorkJoin_Name = "" Then
            Dim dicInfo As CMS_WorkJoinInfo = objController.CMS_WorkJoin_Get(PortalConnect, WorkJoinID)
            If IsNothing(dicInfo) = False Then WorkJoin_Name = flReg.RemoveScript(dicInfo.WorkJoin_Name, False)
            flCache.SetCache("WorkJoin_Name_" & WorkJoinID, WorkJoin_Name)
        End If
    End Function
    Public Shared Function Specialize_Name(PortalConnect As Integer, SpecializeID As String) As String
        Specialize_Name = flCache.GetCache("Specialize_Name_" & SpecializeID) & ""
        If Specialize_Name = "" Then
            Dim dicInfo As CMS_SpecializeInfo = objController.CMS_Specialize_Get(PortalConnect, SpecializeID)
            If IsNothing(dicInfo) = False Then Specialize_Name = flReg.RemoveScript(dicInfo.Specialize_Name, False)
            flCache.SetCache("Specialize_Name_" & SpecializeID, Specialize_Name)
        End If
    End Function
    Public Shared Function TypeEco_Name(PortalConnect As Integer, TypeEcoID As String) As String
        TypeEco_Name = flCache.GetCache("TypeEco_Name_" & TypeEcoID) & ""
        If TypeEco_Name = "" Then
            Dim dicInfo As CMS_TypeEcoInfo = objController.CMS_TypeEco_Get(PortalConnect, TypeEcoID)
            If IsNothing(dicInfo) = False Then TypeEco_Name = flReg.RemoveScript(dicInfo.TypeEco_Name, False)
            flCache.SetCache("TypeEco_Name_" & TypeEcoID, TypeEco_Name)
        End If
    End Function
    Public Shared Function Method_Name(PortalConnect As Integer, MethodID As String) As String
        Method_Name = flCache.GetCache("Method_Name_" & MethodID) & ""
        If Method_Name = "" Then
            Dim dicInfo As CMS_MethodInfo = objController.CMS_Method_Get(PortalConnect, MethodID)
            If IsNothing(dicInfo) = False Then Method_Name = flReg.RemoveScript(dicInfo.Method_Name, False)
            flCache.SetCache("Method_Name_" & MethodID, Method_Name)
        End If
    End Function
    Public Shared Function Trainning_Name(PortalConnect As Integer, TrainningID As String) As String
        Trainning_Name = flCache.GetCache("Trainning_Name_" & TrainningID) & ""
        If Trainning_Name = "" Then
            Dim dicInfo As CMS_TrainningInfo = objController.CMS_Trainning_Get(PortalConnect, TrainningID)
            If IsNothing(dicInfo) = False Then Trainning_Name = flReg.RemoveScript(dicInfo.Trainning_Name, False)
            flCache.SetCache("Trainning_Name_" & TrainningID, Trainning_Name)
        End If
    End Function

    Public Shared Function LoaiSo_Name(PortalConnect As Integer, IdHo As String) As String
        LoaiSo_Name = ""
        Dim dicInfo As CMS_HoGDInfo = objController.CMS_HoGD_Get(PortalConnect, IdHo)
        If IsNothing(dicInfo) = False Then LoaiSo_Name = TenSo(dicInfo.IdSo)
    End Function
    Public Shared Function MaHo(PortalConnect As Integer, IdHo As String) As String
        MaHo = ""
        Dim dicInfo As CMS_HoGDInfo = objController.CMS_HoGD_Get(PortalConnect, IdHo)
        If IsNothing(dicInfo) = False Then MaHo = dicInfo.MaHo
    End Function
    Public Shared Function LoaiHo_Name(PortalConnect As Integer, LoaiHoId As String) As String
        LoaiHo_Name = flCache.GetCache("LoaiHo_Name_" & LoaiHoId) & ""
        If LoaiHo_Name = "" Then
            LoaiHo_Name = "KT3"
            If LoaiHoId = LoaiHo.HK Then LoaiHo_Name = "HK"
            flCache.SetCache("LoaiHo_Name_" & LoaiHoId, LoaiHo_Name)
        End If
    End Function
    Public Shared Function Career_Name(PortalConnect As Integer, careerID As String) As String
        Career_Name = flCache.GetCache("Career_Name_" & careerID) & ""
        If Career_Name = "" Then
            Dim dicInfo As CMS_CareerCLDInfo = objController.CMS_CareerCLD_Get(PortalConnect, careerID)
            If IsNothing(dicInfo) = False Then Career_Name = flReg.RemoveScript(dicInfo.CareerCLD_Name, False)
            flCache.SetCache("Career_Name" & careerID, Career_Name)
        End If
    End Function
    Public Shared Function TenSo(IdSo As String) As String
        TenSo = flCache.GetCache("TenSo_" & IdSo) & ""
        If TenSo = "" Then
            For i = 1 To 30
                If flReg.WriteNumber(IdSo) = i Then TenSo = flReg.ReadNumber(i)
            Next
            flCache.SetCache("TenSo_" & IdSo, TenSo)
        End If
    End Function
    Public Shared Function Specialize_Code(PortalConnect As Integer, SpecializeID As String) As String
        Specialize_Code = flCache.GetCache("Specialize_Code_" & SpecializeID) & ""
        If Specialize_Code = "" Then
            Dim dicInfo As CMS_SpecializeInfo = objController.CMS_Specialize_Get(PortalConnect, SpecializeID)
            If IsNothing(dicInfo) = False Then Specialize_Code = dicInfo.Specialize_Code
            flCache.SetCache("Specialize_Code_" & SpecializeID, Specialize_Code)
        End If
    End Function
    Public Shared Function Education_Code(PortalConnect As Integer, EducationID As String) As String
        Education_Code = flCache.GetCache("Education_Code_" & EducationID) & ""
        If Education_Code = "" Then
            Dim dicInfo As CMS_EducationInfo = objController.CMS_Education_Get(PortalConnect, EducationID)
            If IsNothing(dicInfo) = False Then Education_Code = dicInfo.Education_Code
            flCache.SetCache("Education_Code_" & EducationID, Education_Code)
        End If
    End Function
    Public Shared Function Education_Name(PortalConnect As Integer, EducationID As String) As String
        Education_Name = flCache.GetCache("Education_Name_" & EducationID) & ""
        If Education_Name = "" Then
            Dim dicInfo As CMS_EducationInfo = objController.CMS_Education_Get(PortalConnect, EducationID)
            If IsNothing(dicInfo) = False Then Education_Name = flReg.RemoveScript(dicInfo.Education_Name, False)
            flCache.SetCache("Education_Name_" & EducationID, Education_Name)
        End If
    End Function
    Public Shared Function Reason_Name(PortalConnect As Integer, ReasonID As String) As String
        Reason_Name = flCache.GetCache("Reason_Name_" & ReasonID) & ""
        If Reason_Name = "" Then
            Dim dicInfo As CMS_ReasonInfo = objController.CMS_Reason_Get(PortalConnect, ReasonID)
            If IsNothing(dicInfo) = False Then Reason_Name = flReg.RemoveScript(dicInfo.Reason_Name, False)
            flCache.SetCache("Reason_Name_" & ReasonID, Reason_Name)
        End If
    End Function
    Public Shared Function TypeUnemploy_Name(PortalConnect As Integer, TypeUnemployID As String) As String
        TypeUnemploy_Name = flCache.GetCache("TypeUnemploy_Name_" & TypeUnemployID) & ""
        If TypeUnemploy_Name = "" Then
            Dim dicInfo As CMS_TypeUnemployInfo = objController.CMS_TypeUnemploy_Get(PortalConnect, TypeUnemployID)
            If IsNothing(dicInfo) = False Then TypeUnemploy_Name = flReg.RemoveScript(dicInfo.TypeUnemploy_Name, False)
            flCache.SetCache("TypeUnemploy_Name_" & TypeUnemployID, TypeUnemploy_Name)
        End If
    End Function
    Public Shared Function ProvideYear(tinhTp As String) As Integer
        ProvideYear = flReg.WriteNumber(flCache.GetCache("ProvideYear_" & tinhTp))
        If ProvideYear = 0 Then
            tinhTp = flReg.WriteNumber(tinhTp)
            Dim obj As CMS_Provide_ConfigInfo = objController.CMS_Provide_Config_Get_Active(tinhTp, tinhTp, True)
            If IsNothing(obj) = False Then ProvideYear = obj.ProConfig_Value
            flCache.SetCache("ProvideYear_" & tinhTp, ProvideYear)
        End If
    End Function
    Public Shared Function ProvideLock(tinhTp As String) As Boolean
        ProvideLock = False
        If IsNothing(flCache.GetCache("ProvideLock_" & tinhTp)) = True Then
            tinhTp = flReg.WriteNumber(tinhTp)
            Dim obj As CMS_Provide_ConfigInfo = objController.CMS_Provide_Config_Get_Active(tinhTp, tinhTp, True)
            If IsNothing(obj) = False Then ProvideLock = obj.IsLock
            flCache.SetCache("ProvideLock_" & tinhTp, ProvideLock)
        Else
            ProvideLock = flReg.ToBoolean(flCache.GetCache("ProvideLock_" & tinhTp))
        End If
    End Function
    Public Shared Function TenBienDongHo(id As Integer) As String
        Select Case id
            Case BienDongHo.ThemMoi
                Return "Thêm mới"
            Case BienDongHo.ThayDoi
                Return "Cập nhật"
            Case BienDongHo.BienDongKhac
                Return "Biến động khác"
            Case BienDongHo.ThemMoiThanhVien
                Return "Thêm mới thành viên"
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function TenTrangThaiChuyen(id As Integer) As String
        Select Case id
            Case TrangThaiChuyen.SapNhap
                Return "Sáp nhập"
            Case TrangThaiChuyen.ChuyenDen
                Return "Chuyển đến"
            Case TrangThaiChuyen.ChuyenDi
                Return "Chuyển đi"
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function LoaiHinhNoiLamViec(id As Integer) As String
        Select Case id
            Case 1
                Return "Hộ nông, lâm nghiệp, thủy sản"
            Case 2
                Return "Cá nhân lao động tự do"
            Case 3
                Return "Cơ sở kinh doanh cá thể"
            Case 4
                Return "Hợp tác xã"
            Case 5
                Return "Doanh nghiệp"
            Case 6
                Return "Khu vực nhà nước"
            Case 7
                Return "Đơn vị sự nghiệp ngoài nhà nước"
            Case 8
                Return "Khu vực nước ngoài"
            Case 9
                Return "Tổ chức đoàn thể khác"
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function TenThoiGianThatNghiep(id As Integer) As String
        Select Case id
            Case ThoiGianThatNghiep.Duoi3Thang
                Return "Dưới 3 tháng"
            Case ThoiGianThatNghiep.BaThangDen1Nam
                Return "3 tháng đến 1 năm"
            Case ThoiGianThatNghiep.Tren1Nam
                Return "Trên 1 năm"
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GenMaHo(matinh As String, mahuyen As String, maxa As String, mathonto As String) As String
        Dim HoGDCode = ""
        If matinh <> "" Then
            HoGDCode = matinh & "."
        End If
        If mahuyen <> "" Then
            HoGDCode += mahuyen + "."
        End If
        If maxa <> "" Then
            HoGDCode += maxa + "."
        End If
        If mathonto <> "" Then
            HoGDCode += mathonto + "."
        End If
        Return HoGDCode
    End Function


End Class

