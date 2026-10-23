Imports DotNetNuke.EPORTAL
Public Class flCheck
    Public Shared Function CheckLevel(pid As Integer, tempID As Integer) As Integer
        CheckLevel = flReg.WriteNumber(flCache.GetCache("CheckLevel_" & pid & "_" & tempID))
        If CheckLevel = 0 Then
            CheckLevel = 1
            For Each C1 As CMS_TargetsInfo In New MapController().CMS_Targets_Get_By_CMS_Temp_Parent_NULL(pid, tempID)
                For Each C2 As CMS_TargetsInfo In New MapController().CMS_Targets_Get_By_CMS_Temp_Parent_ID(pid, tempID, C1.Targets_ID)
                    CheckLevel = 2
                    For Each C3 As CMS_TargetsInfo In New MapController().CMS_Targets_Get_By_CMS_Temp_Parent_ID(pid, tempID, C2.Targets_ID)
                        CheckLevel = 3
                        flCache.SetCache("CheckLevel_" & pid & "_" & tempID, CheckLevel)
                        Return 3
                    Next 'Cấp 3
                Next 'Cấp 2
            Next 'Cấp 1
            flCache.SetCache("CheckLevel_" & pid & "_" & tempID, CheckLevel)
        End If
    End Function

    Public Shared Function Targets_Code(PortalId As Integer, Id As String) As String
        Targets_Code = flCache.GetCache("Targets_Code_" & PortalId & "_" & Id)
        If Targets_Code = "" Then
            Dim Info As CMS_TargetsInfo = New MapController().CMS_Targets_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Targets_Code = flReg.RemoveScript(Info.Targets_Code, False)
                flCache.SetCache("Targets_Code_" & PortalId & "_" & Id, Targets_Code)
            End If
        End If
    End Function
    Public Shared Function Targets_IDByCode(PortalId As Integer, Code As String) As Integer
        Targets_IDByCode = flCache.GetCache("Targets_IDByCode_" & PortalId & "_" & Code)
        If flReg.WriteNumber(Targets_IDByCode) = 0 Then
            Targets_IDByCode = New MapController().CMS_Targets_Get_ByCode(PortalId, Code)
            flCache.SetCache("Targets_IDByCode_" & PortalId & "_" & Code, Targets_IDByCode)
        End If
    End Function
    Public Shared Function GroupID_ByTarID(PortalId As Integer, Id As String) As Integer
        GroupID_ByTarID = flCache.GetCache("GroupID_ByTarID_" & PortalId & "_" & Id)
        If flReg.WriteNumber(GroupID_ByTarID) = 0 Then
            Dim Info As CMS_TargetsInfo = New MapController().CMS_Targets_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                GroupID_ByTarID = flReg.RemoveScript(Info.Group_ID, False)
                flCache.SetCache("GroupID_ByTarID_" & PortalId & "_" & Id, GroupID_ByTarID)
            End If
        End If
    End Function
    Public Shared Function Target_Name(PortalId As Integer, Id As String) As String
        Target_Name = flCache.GetCache("Target_Name_" & PortalId & "_" & Id)
        If Target_Name = "" Then
            Dim Info As CMS_TargetsInfo = New MapController().CMS_Targets_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Target_Name = flReg.RemoveScript(Info.Targets_Name, False)
                flCache.SetCache("Target_Name_" & PortalId & "_" & Id, Target_Name)
            End If
        End If
    End Function
    Public Shared Function Target_Sort(PortalId As Integer, Id As String) As String
        Target_Sort = flCache.GetCache("Target_Sort_" & PortalId & "_" & Id)
        If Target_Sort = "" Then
            Dim Info As CMS_TargetsInfo = New MapController().CMS_Targets_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Target_Sort = flReg.RemoveScript(Info.Targets_Sort, False)
                flCache.SetCache("Target_Sort_" & PortalId & "_" & Id, Target_Sort)
            End If
        End If
    End Function
    Public Shared Function Target_Des(PortalId As Integer, Id As String) As String
        Target_Des = flCache.GetCache("Target_Des_" & PortalId & "_" & Id)
        If Target_Des = "" Then
            Dim Info As CMS_TargetsInfo = New MapController().CMS_Targets_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Target_Des = flReg.RemoveScript(Info.Targets_Sort, False)
                flCache.SetCache("Target_Des_" & PortalId & "_" & Id, Target_Des)
            End If
        End If
    End Function
    Public Shared Function Target_UnitType(PortalId As Integer, Id As String) As String
        Target_UnitType = flCache.GetCache("Target_UnitType_" & PortalId & "_" & Id)
        If Target_UnitType = "" Then
            Dim Info As CMS_TargetsInfo = New MapController().CMS_Targets_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Target_UnitType = flReg.RemoveScript(Info.UnitTypeID, False)
                flCache.SetCache("Target_UnitType_" & PortalId & "_" & Id, Target_UnitType)
            End If
        End If
    End Function
    Public Shared Function Group_Name(PortalId As Integer, Id As String) As String
        Group_Name = flCache.GetCache("Group_Name_" & PortalId & "_" & Id)
        If Group_Name = "" Then
            Dim Info As CMS_GroupInfo = New MapController().CMS_Group_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Group_Name = flReg.RemoveScript(Info.Group_Name, False)
                flCache.SetCache("Group_Name_" & PortalId & "_" & Id, Group_Name)
            End If
        End If
    End Function
    Public Shared Function Group_Code(PortalId As Integer, Id As String) As String
        Group_Code = flCache.GetCache("Group_Code_" & PortalId & "_" & Id)
        If Group_Code = "" Then
            Dim Info As CMS_GroupInfo = New MapController().CMS_Group_Get(PortalId, Id)
            If IsNothing(Info) = False Then
                Group_Code = flReg.RemoveScript(Info.Group_Code, False)
                flCache.SetCache("Group_Code_" & PortalId & "_" & Id, Group_Code)
            End If
        End If
    End Function
    Public Shared Function Group_Count(PortalId As Integer, Id As String) As String
        Group_Count = New MapController().CMS_Group_Count_Parent(PortalId, Id)
    End Function

End Class

