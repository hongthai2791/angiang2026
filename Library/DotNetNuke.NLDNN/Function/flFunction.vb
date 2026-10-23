Imports System.IO
Imports System.Web
Imports System.Web.UI.WebControls
Imports DotNetNuke.UI.Utilities
Imports DotNetNuke.EPORTAL

Public Class flFunction
    Shared ObjControler As New NLDNNController
    Shared arrTemp As New ArrayList

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
    Public Shared Sub LoadTrinhDoGD(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("DM_TrinhDoDT_List" & PortalId)) Then
            arrTemp = ObjControler.DM_TrinhDoDT_List(PortalId)
            flCache.SetCache("DM_TrinhDoDT_List" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("DM_TrinhDoDT_List" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, "0"))
        For Each Ci As DM_TrinhDoDTInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Name, False), Ci.ID))
        Next
    End Sub
    Public Shared Sub LoadChuyenMonDT(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("DM_ChuyenMonDT_List" & PortalId)) Then
            arrTemp = ObjControler.DM_ChuyenMonDT_List(PortalId)
            flCache.SetCache("DM_ChuyenMonDT_List" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("DM_ChuyenMonDT_List" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, "0"))
        For Each Ci As DM_ChuyenMonDTInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Name, False), Ci.ID))
        Next
    End Sub
    Public Shared Sub LoadHinhThucLV(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("DM_HinhThucLV_List" & PortalId)) Then
            arrTemp = ObjControler.DM_HinhThucLV_List(PortalId)
            flCache.SetCache("DM_HinhThucLV_List" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("DM_HinhThucLV_List" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, "0"))
        For Each Ci As DM_HinhThucLVInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Name, False), Ci.ID))
        Next
    End Sub
    Public Shared Sub LoadNgheCongViec(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("DM_NgheCongViec_List" & PortalId)) Then
            arrTemp = ObjControler.DM_NgheCongViec_List(PortalId)
            flCache.SetCache("DM_NgheCongViec_List" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("DM_NgheCongViec_List" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, "0"))
        For Each Ci As DM_NgheCongViecInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Name, False), Ci.ID))
        Next
    End Sub
    Public Shared Sub LoadViTriCV(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("DM_ViTriCV_List" & PortalId)) Then
            arrTemp = ObjControler.DM_ViTriCV_List(PortalId)
            flCache.SetCache("DM_ViTriCV_List" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("DM_ViTriCV_List" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, "0"))
        For Each Ci As DM_ViTriCVInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Name, False), Ci.ID))
        Next
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