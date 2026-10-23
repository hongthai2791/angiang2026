Imports DotNetNuke.Security.Roles
Imports DotNetNuke.Common.Globals
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.Entities.Users
Imports System.Text
Imports System.Web
Imports System.Reflection

Public Class Ultis
    Shared ObjController As New WorkController
    Shared uInfo As New UserInfo
    Shared arrStr() As String

#Region "General BL"
    Public Shared Function GetRequestId(surl As String) As Integer
        surl = surl.Replace(".html", "").Substring(surl.LastIndexOf("-") + 1)
        If surl.Contains("?") Then surl = surl.Substring(0, surl.LastIndexOf("?"))
        Return flReg.WriteNumber(surl)
    End Function
    Public Shared Function UserPortal(Username As String) As ArrayList
        If IsNothing(flCache.GetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username)) = True Then
            UserPortal = flDnn.DNN_Portal_Get_By_UserID(Username)
            flCache.SetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username, UserPortal)
        Else
            UserPortal = CType(flCache.GetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username), ArrayList)
        End If
    End Function
#End Region
    Public Shared Function ConvertArrayListToDataTable(ByVal arraylist As ArrayList) As DataTable
        Dim dt As DataTable = New DataTable()

        If arraylist.Count <= 0 Then
            Return dt
        End If

        Dim propertiesinfo As PropertyInfo() = arraylist(0).GetType().GetProperties()

        For Each pf As PropertyInfo In propertiesinfo
            Dim dc As DataColumn = New DataColumn(pf.Name)
            'dc.DataType = pf.PropertyType
            If Nullable.GetUnderlyingType(pf.PropertyType) IsNot Nothing Then
                dc.DataType = Nullable.GetUnderlyingType(pf.PropertyType)
            Else
                dc.DataType = pf.PropertyType
            End If
            dt.Columns.Add(dc)
        Next

        For Each ar As Object In arraylist
            Dim dr As DataRow = dt.NewRow
            Dim pf As PropertyInfo() = ar.GetType().GetProperties()

            For Each prop As PropertyInfo In pf
                dr(prop.Name) = prop.GetValue(ar, Nothing)
            Next
            dt.Rows.Add(dr)
        Next
        Return dt
    End Function
    Public Shared Function ConvertArrayListToDataTable(Of T)(ByVal items As List(Of T)) As DataTable
        Dim dataTable As New DataTable()

        If items IsNot Nothing AndAlso items.Any() Then
            Dim properties As PropertyInfo() = GetType(T).GetProperties()
            For Each prop As PropertyInfo In properties
                dataTable.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
            Next

            For Each item As T In items
                Dim row As DataRow = dataTable.NewRow()
                For Each prop As PropertyInfo In properties
                    row(prop.Name) = If(prop.GetValue(item, Nothing) Is Nothing, DBNull.Value, prop.GetValue(item, Nothing))
                Next
                dataTable.Rows.Add(row)
            Next
        End If
        Return dataTable
    End Function
End Class

