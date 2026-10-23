Imports Microsoft.ApplicationBlocks.Data
Imports DotNetNuke.VBN
Public Class SqlDataProvider
    Inherits DataProvider

#Region "HomePage"
    Public Overrides Function API_Home_Work_List(PortalConnect As String, IsFlag As Integer, Top As Integer, tinhTP As String) As IDataReader
        Return CType(SqlHelper.ExecuteReader(flConnect.WorkConnect(PortalConnect), "API_Home_Work_List", IsFlag, Top, tinhTP), IDataReader)
    End Function
#End Region

End Class

