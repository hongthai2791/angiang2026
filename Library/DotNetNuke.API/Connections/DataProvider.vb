Public MustInherit Class DataProvider

#Region "Shared/Static Methods"

    Private Shared objProvider As DataProvider = Nothing

    Shared Sub New()
        CreateProvider()
    End Sub

    Private Shared Sub CreateProvider()
        objProvider = CType(Framework.Reflection.CreateObject("data", "DotNetNuke.API", ""), DataProvider)
    End Sub

    Public Shared Shadows Function Instance() As DataProvider
        Return objProvider
    End Function

#End Region

#Region "HomePage"
    Public MustOverride Function API_Home_Work_List(PortalConnect As String, IsFlag As Integer, Top As Integer, tinhTP As String) As IDataReader
#End Region

End Class
