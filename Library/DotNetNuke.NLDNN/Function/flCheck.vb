Imports DotNetNuke.EPORTAL
Public Class flCheck
    Shared objController As New NLDNNController()


    Public Shared Function ProvideYear(tinhTp As String) As Integer
        ProvideYear = flReg.WriteNumber(flCache.GetCache("NLDNNProvideYear_" & tinhTp))
        If ProvideYear = 0 Then
            tinhTp = flReg.WriteNumber(tinhTp)
            Dim obj As CMS_Provide_ConfigInfo = objController.CMS_Provide_Config_Get_Active(tinhTp, tinhTp, True)
            If IsNothing(obj) = False Then ProvideYear = obj.ProConfig_Value
            flCache.SetCache("NLDNNProvideYear_" & tinhTp, ProvideYear)
        End If
    End Function
    Public Shared Function NLDNN_ChuyenMonDT_Name(PortalConnect As Integer, ID As String) As String
        NLDNN_ChuyenMonDT_Name = flCache.GetCache("NLDNN_ChuyenMonDT_Name" & ID) & ""
        If NLDNN_ChuyenMonDT_Name = "" Then
            Dim dicInfo As DM_TrinhDoDTInfo = objController.DM_TrinhDoDT_Get(PortalConnect, ID)
            If IsNothing(dicInfo) = False Then NLDNN_ChuyenMonDT_Name = flReg.RemoveScript(dicInfo.Name, False)
            flCache.SetCache("NLDNN_ChuyenMonDT_Name" & ID, NLDNN_ChuyenMonDT_Name)
        End If
    End Function
    Public Shared Function NLDNN_TrinhDoGD_Name(PortalConnect As Integer, ID As String) As String
        NLDNN_TrinhDoGD_Name = flCache.GetCache("NLDNN_TrinhDoGD_Name" & ID) & ""
        If NLDNN_TrinhDoGD_Name = "" Then
            Dim dicInfo As DM_TrinhDoDTInfo = objController.DM_TrinhDoDT_Get(PortalConnect, ID)
            If IsNothing(dicInfo) = False Then NLDNN_TrinhDoGD_Name = flReg.RemoveScript(dicInfo.Name, False)
            flCache.SetCache("NLDNN_TrinhDoGD_Name" & ID, NLDNN_TrinhDoGD_Name)
        End If
    End Function
    Public Shared Function NLDNN_NgheCongViec_Name(PortalConnect As Integer, ID As String) As String
        NLDNN_NgheCongViec_Name = flCache.GetCache("NLDNN_NgheCongViec_Name" & ID) & ""
        If NLDNN_NgheCongViec_Name = "" Then
            Dim dicInfo As DM_TrinhDoDTInfo = objController.DM_TrinhDoDT_Get(PortalConnect, ID)
            If IsNothing(dicInfo) = False Then NLDNN_NgheCongViec_Name = flReg.RemoveScript(dicInfo.Name, False)
            flCache.SetCache("NLDNN_NgheCongViec_Name" & ID, NLDNN_NgheCongViec_Name)
        End If
    End Function
    Public Shared Function NLDNN_ViTriCV_Name(PortalConnect As Integer, ID As String) As String
        NLDNN_ViTriCV_Name = flCache.GetCache("NLDNN_ViTriCV_Name" & ID) & ""
        If NLDNN_ViTriCV_Name = "" Then
            Dim dicInfo As DM_TrinhDoDTInfo = objController.DM_TrinhDoDT_Get(PortalConnect, ID)
            If IsNothing(dicInfo) = False Then NLDNN_ViTriCV_Name = flReg.RemoveScript(dicInfo.Name, False)
            flCache.SetCache("NLDNN_ViTriCV_Name" & ID, NLDNN_ViTriCV_Name)
        End If
    End Function
    Public Shared Function NLDNN_HinhThucLV_Name(PortalConnect As Integer, ID As String) As String
        NLDNN_HinhThucLV_Name = flCache.GetCache("NLDNN_HinhThucLV_Name" & ID) & ""
        If NLDNN_HinhThucLV_Name = "" Then
            Dim dicInfo As DM_TrinhDoDTInfo = objController.DM_TrinhDoDT_Get(PortalConnect, ID)
            If IsNothing(dicInfo) = False Then NLDNN_HinhThucLV_Name = flReg.RemoveScript(dicInfo.Name, False)
            flCache.SetCache("NLDNN_HinhThucLV_Name" & ID, NLDNN_HinhThucLV_Name)
        End If
    End Function

    Public Shared Function NLDNN_TinhTrangCP_Name(PortalConnect As Integer, ID As String) As String
        NLDNN_TinhTrangCP_Name = flCache.GetCache("NLDNN_TinhTrangCP_Name" & ID) & ""
        If NLDNN_TinhTrangCP_Name = "" Then
            Select Case ID
                Case 1
                    NLDNN_TinhTrangCP_Name = "Cấp mới"
                Case 2
                    NLDNN_TinhTrangCP_Name = "Cấp lại"
                Case 3
                    NLDNN_TinhTrangCP_Name = "Gia hạn"
                Case Else
                    NLDNN_TinhTrangCP_Name = ""
            End Select
            flCache.SetCache("NLDNN_TinhTrangCP_Name" & ID, NLDNN_TinhTrangCP_Name)
        End If
    End Function
End Class

