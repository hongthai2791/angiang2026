Imports DotNetNuke.EPORTAL
Imports System.Web.UI.WebControls
Public Class flWork
    Shared strOld, str(), strOld1, str1() As String
    Shared arrTemp, arrTemp1 As New ArrayList


    Public Shared Sub LoadSpecialize(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
        Dim objController As New WorkController()
        dr.Items.Clear()
        If IsNothing(flCache.GetCache("CMS_Specialize_" & PortalId)) Then
            arrTemp = objController.CMS_Specialize_List(PortalId)
            flCache.SetCache("CMS_Specialize_" & PortalId, arrTemp)
        Else
            arrTemp = CType(flCache.GetCache("CMS_Specialize_" & PortalId), ArrayList)
        End If
        If text <> "" Then dr.Items.Add(New ListItem(text, ""))
        For Each Ci As CMS_SpecializeInfo In arrTemp
            dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Specialize_Code & "--" & Ci.Specialize_Name, False), Ci.Specialize_ID))
        Next

    End Sub

    Public Shared Function Specialize_Name(PortalId As Integer, Id As String) As String
        Dim objController As New WorkController()
        Specialize_Name = flCache.GetCache("Specialize_Name_" & PortalId & "_" & Id) & ""
        If Specialize_Name = "" And Id <> "" Then
            Dim Info As CMS_SpecializeInfo = objController.CMS_Specialize_Get(PortalId, flReg.WriteNumber(Id))
            If IsNothing(Info) = False Then
                Specialize_Name = flReg.RemoveScript(Info.Specialize_Name, False)
                flCache.SetCache("Specialize_Name_" & PortalId & "_" & Id, Specialize_Name)
            End If
        End If
    End Function

End Class
