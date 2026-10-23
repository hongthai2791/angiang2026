Imports System.IO
Imports System.Web
Imports System.Web.UI.WebControls
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.EPORTAL

Public Class flFunction
    Shared ObjControler As New CungController
    Shared arrTemp As New ArrayList
    Public Shared Sub LoadLoaiHo(ByVal drGroup As DropDownList, Optional ByVal str As String = "- -Loại hộ- -")
        drGroup.Items.Clear()
        If str <> "" Then drGroup.Items.Add(New ListItem("- - Loại hộ- -", ""))
        drGroup.Items.Add(New ListItem("HK", LoaiHo.HK))
        drGroup.Items.Add(New ListItem("KT3", LoaiHo.KT3))
    End Sub
    Public Shared Sub LoadBienDongTv(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem(TrangThaiChuyen.KhongBienDong & "-- Không biến động", TrangThaiChuyen.KhongBienDong))
        drGroup.Items.Add(New ListItem(TrangThaiChuyen.ChuyenDen & "-- Chuyển đến", TrangThaiChuyen.ChuyenDen))
        drGroup.Items.Add(New ListItem(TrangThaiChuyen.ChuyenDi & "-- Chuyển đi", TrangThaiChuyen.ChuyenDi))
        drGroup.Items.Add(New ListItem(TrangThaiChuyen.SapNhap & "-- Sáp nhập", TrangThaiChuyen.SapNhap))

    End Sub
    Public Shared Sub LoadLoaiThatNghiep(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_TypeUnemploy_" & PortalId)) Then
            arrTemp = ObjControler.CMS_TypeUnemploy_List(PortalId)
            flCache.SetCache("CMS_TypeUnemploy_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_TypeUnemploy_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TypeUnemployInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.TypeUnemploy_Code & "--" & Ci.TypeUnemploy_Name, False), Ci.TypeUnemploy_ID))
        Next
    End Sub
    Public Shared Sub LoadErrorType(ByVal drGroup As DropDownList)
        drGroup.Items.Clear()
        drGroup.Items.Add(New ListItem("1--Trình độ học vấn không có dữ liệu", ErrorType.TDHV))
        drGroup.Items.Add(New ListItem("2--Trường CMKT không có dữ liệu", ErrorType.CMKT))
        drGroup.Items.Add(New ListItem("3--Trường ngành nghề không có dữ liệu", ErrorType.NganhNghe))
        drGroup.Items.Add(New ListItem("4--Vừa có việc làm, vừa thất nghiệp", ErrorType.CVLTN))
        drGroup.Items.Add(New ListItem("5--Vừa có việc làm, vừa không HĐKT", ErrorType.CVLKHDKT))
        drGroup.Items.Add(New ListItem("6--Vừa thất nghiệp vừa không HĐKT", ErrorType.TNKHDKT))
        drGroup.Items.Add(New ListItem("7--Không có VL, không TN, không HĐKT", ErrorType.KVLKTNKHDKT))
        drGroup.Items.Add(New ListItem("8--Chưa tốt nghiệp 12 nhưng có trình độ từ trung cấp", ErrorType.TDGD))
        drGroup.Items.Add(New ListItem("9--Chưa có giới tính", ErrorType.GioiTinh))
    End Sub
    Public Shared Sub LoadThoiGianThatNghiep(ByVal drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        drGroup.Items.Clear()
        If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
        drGroup.Items.Add(New ListItem("1--Dưới 3 tháng", ThoiGianThatNghiep.Duoi3Thang))
        drGroup.Items.Add(New ListItem("2--3 tháng đến 1 năm", ThoiGianThatNghiep.BaThangDen1Nam))
        drGroup.Items.Add(New ListItem("3--Trên 1 năm", ThoiGianThatNghiep.Tren1Nam))
    End Sub

    Public Shared Sub LoadSpecialize(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal all As Boolean = False)
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Specialize_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Specialize_List(PortalId)
            flCache.SetCache("CMS_Specialize_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Specialize_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        If all = True Then
            For Each Ci As CMS_SpecializeInfo In arrTemp
                dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Specialize_Code & "--" & Ci.Specialize_Name, False), Ci.Specialize_ID))
            Next
        Else
            For Each Ci As CMS_SpecializeInfo In arrTemp
                Select Case Ci.Specialize_Code
                    Case "5107", "5109", "5110", "5111", "5112"
                    Case Else
                        dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Specialize_Code & "--" & Ci.Specialize_Name, False), Ci.Specialize_ID))
                End Select
            Next
        End If
    End Sub
    Public Shared Sub LoadYearConfig(PortalID As Integer, MaTinh As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each cr As CMS_Provide_ConfigInfo In ObjControler.CMS_Provide_Config_List_ByTinh(MaTinh, MaTinh)
            dr.Items.Add(New ListItem(cr.ProConfig_Value, cr.ProConfig_Value))
        Next
    End Sub
    Public Shared Sub LoadSo(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each cr As CMS_LoaiSoInfo In ObjControler.CMS_LoaiSo_List(PortalId)
            dr.Items.Add(New ListItem(cr.Name, cr.ID))
        Next
    End Sub
    Public Shared Sub LoadSpecializeByEdu(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        Dim itemDr As ListItem
        If IsNothing(flCache.GetCache("CMS_SpecializeByEdu_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Specialize_List(PortalId)
            flCache.SetCache("CMS_SpecializeByEdu_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_SpecializeByEdu_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_SpecializeInfo In arrTemp
            itemDr = New ListItem(flReg.RemoveScript(Ci.Specialize_Code & "--" & Ci.Specialize_Name, False), Ci.Specialize_ID)
            Select Case Ci.Specialize_Code
                Case "5107", "5109", "5110", "5111", "5112"
                    itemDr.Enabled = False
            End Select
            dr.Items.Add(itemDr)
        Next
    End Sub
    Public Shared Sub LoadEducation(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Education_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Education_List(PortalId)
            flCache.SetCache("CMS_Education_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Education_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_EducationInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Education_Code & "--" & Ci.Education_Name, False), Ci.Education_ID))
        Next
    End Sub
    Public Shared Sub LoadTrainning(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Trainning_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Trainning_List(PortalId)
            flCache.SetCache("CMS_Trainning_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Trainning_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TrainningInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Trainning_Code & "--" & Ci.Trainning_Name, False), Ci.Trainning_ID))
        Next
    End Sub
    Public Shared Sub LoadTypeEco(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_TypeEco_" & PortalId)) Then
            arrTemp = ObjControler.CMS_TypeEco_List(PortalId)
            flCache.SetCache("CMS_TypeEco_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_TypeEco_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_TypeEcoInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.TypeEco_Code & "--" & Ci.TypeEco_Name, False), Ci.TypeEco_ID))
        Next
    End Sub
    Public Shared Sub LoadWorkJoin(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_WorkJoin_" & PortalId)) Then
            arrTemp = ObjControler.CMS_WorkJoin_List(PortalId)
            flCache.SetCache("CMS_WorkJoin_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_WorkJoin_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        If text = "" Then dr.Items.Add(New ListItem("---Chọn---", ""))
        For Each Ci As CMS_WorkJoinInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.WorkJoin_Code & "--" & Ci.WorkJoin_Name, False), Ci.WorkJoin_ID))
        Next
    End Sub
    Public Shared Sub LoadReason(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Reason_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Reason_List(PortalId)
            flCache.SetCache("CMS_Reason_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Reason_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_ReasonInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Reason_Code & "--" & Ci.Reason_Name, False), Ci.Reason_ID))
        Next
    End Sub
    Public Shared Sub Load_Method(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Method_" & PortalId)) Then
            arrTemp = ObjControler.CMS_Method_List(PortalId)
            flCache.SetCache("CMS_Method_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Method_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_MethodInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Method_Code & "--" & Ci.Method_Name, False), Ci.Method_ID))
        Next
    End Sub

    Public Shared Sub LoadCareerCLD(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_CareerCLD_List_" & PortalId)) Then
            arrTemp = ObjControler.CMS_CareerCLD_List(PortalId)
            flCache.SetCache("CMS_CareerCLD_List_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_CareerCLD_List_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, 0))
        For Each Ci As CMS_CareerCLDInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.CareerCLD_Code & "--" & Ci.CareerCLD_Name, False), Ci.CareerCLD_ID))
        Next
    End Sub
    Public Shared Sub VerifyDir(ByVal path As String)
        Try
            Dim dir As DirectoryInfo = New DirectoryInfo(path)
            If Not dir.Exists Then
                dir.Create()
            End If

        Catch
        End Try
    End Sub

    Public Shared Sub Logger(ByVal path As String, ByVal contents As String)
        VerifyDir(path)
        Dim fileName As String = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() & "_Logs.txt"
        Try
            Dim file As System.IO.StreamWriter = New System.IO.StreamWriter(path & fileName, True)
            file.WriteLine(DateTime.Now.ToString() & ": " & contents)
            file.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class

Public Class flNotify
#Region "Notification"
    Public Shared MinDate As DateTime = Convert.ToDateTime("1800-01-01")
    Public Shared MinDateText As String = "01/01/1800"
    Public Shared MaxDate As DateTime = Convert.ToDateTime("2900-01-01")
    Public Shared MaxDateText As String = "01/01/2800"
    Public Enum NotifyType
        Info = 1
        Success = 2
        Warning = 3
        Danger = 4
    End Enum
    Public Enum NotifyPosition
        Top = 1
        Bottom = 2
    End Enum
    Public Enum NotifyAlign
        Left = 1
        Center = 2
        Right = 3
    End Enum
    Public Shared Sub Notify(mes As String, Optional ntype As NotifyType = NotifyType.Success, Optional position As NotifyPosition = NotifyPosition.Bottom, Optional align As NotifyAlign = NotifyAlign.Right, Optional time As Integer = 3000)
        ClientAPI.RegisterStartUpScript(DirectCast(HttpContext.Current.Handler, System.Web.UI.Page), Guid.NewGuid.ToString, String.Format("<script>notify('{0}','{1}','{2}','{3}',{4});</script>", mes, ntype.ToString.ToLower.Replace("danger", "error"), position.ToString.ToLower, align.ToString.ToLower, time))
    End Sub
    Public Enum PopoverPlacement
        Top = 1
        Right = 2
        Bottom = 3
        Left = 4
    End Enum
    Public Shared Sub Popover(selector As String, mes As String, Optional livetime As Integer = 5000, Optional placement As PopoverPlacement = PopoverPlacement.Top)
        Dim script = String.Format("<script>popover('{0}','{1}','{2}','{3}','');</script>", selector, mes, livetime, placement.ToString.ToLower)
        ClientAPI.RegisterStartUpScript(DirectCast(HttpContext.Current.Handler, System.Web.UI.Page), Guid.NewGuid.ToString, script)
    End Sub
    Public Shared Function Base64Encode(plainText As String) As String
        Dim plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)
        Return System.Convert.ToBase64String(plainTextBytes)
    End Function
    Public Shared Function Base64Decode(base64EncodedData As String) As String
        Dim base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData)
        Return System.Text.Encoding.UTF8.GetString(base64EncodedBytes)
    End Function
    Public Shared Sub ShowExceptionForDeveloper(lblMessage As System.Web.UI.WebControls.Label, ex As Exception, Optional force As Boolean = False)
        If ex.Message.Contains("Timeout") Then
            flNotify.Notify("Hệ thống đang bận. Vui lòng thử lại sau ít phút!", flNotify.NotifyType.Warning, flNotify.NotifyPosition.Top, flNotify.NotifyAlign.Center)
        End If
        If DotNetNuke.Entities.Portals.PortalSettings.Current.UserInfo.IsInRole("Administrators") Or DotNetNuke.Entities.Portals.PortalSettings.Current.UserInfo.IsSuperUser Or HttpContext.Current.Request.QueryString("mode") = "dev" Then
            lblMessage.Text = String.Format("{0}<hr/>{1}<hr/>{2}", ex.Message.Replace("line", "<span style='color:red;'>line</span>"), ex.StackTrace, ex.Source)
            lblMessage.Visible = True
        End If
    End Sub
#End Region
End Class