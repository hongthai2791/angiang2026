Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Partial Public Class EPORTALHelper
#Region "SQL Helper"
    Public Shared Function ExecuteSQLText(ByVal ConnectionString As String, ByVal sql As String) As DataSet
        Dim startTime As Date = Now
        Dim obj As DataSet = SqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, sql)
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return obj
    End Function

    Public Shared Function ExecuteDataset(ByVal ConnectionString As String, ByVal procname As String, ParamArray params() As Object) As DataSet
        Dim startTime As Date = Now
        Dim obj As DataSet = SqlHelper.ExecuteDataset(ConnectionString, procname, params)
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return obj
    End Function
    Public Shared Function ExecuteNonQuery(ByVal ConnectionString As String, ByVal procname As String, ParamArray params() As Object) As Integer
        Dim startTime As Date = Now
        Dim obj As Integer = SqlHelper.ExecuteNonQuery(ConnectionString, procname, params)
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return obj
    End Function
    Public Shared Function ExecuteReader(ByVal ConnectionString As String, ByVal procname As String, ParamArray params() As Object) As SqlDataReader
        Dim startTime As Date = Now
        Dim obj As SqlDataReader = SqlHelper.ExecuteReader(ConnectionString, procname, params)
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return obj
    End Function
    Public Shared Function ExecuteScalar(ByVal ConnectionString As String, ByVal procname As String, ParamArray params() As Object) As Object
        Dim startTime As Date = Now
        Dim obj As Object = SqlHelper.ExecuteScalar(ConnectionString, procname, params)
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return obj
    End Function
    Public Shared Function ExecuteNonQuery(ByVal trans As SqlTransaction, ByVal procname As String, ParamArray params() As Object) As Integer
        Dim startTime As Date = Now
        Dim obj As Integer = SqlHelper.ExecuteNonQuery(trans, procname, params)
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return obj
    End Function
    Public Shared Function ExecuteScalar(ByVal trans As SqlTransaction, ByVal procname As String, ParamArray params() As Object) As Object
        Dim startTime As Date = Now
        Dim obj As Object = SqlHelper.ExecuteScalar(trans, procname, params)
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return obj
    End Function
#End Region
#Region "With Timeout"
    Public Shared Function ExecuteNonQueryWithTimeout(ByVal ConnectionString As String, ByVal procname As String, timeout As Integer, ParamArray params() As Object) As Integer
        Dim startTime As Date = Now

        Dim ref As Integer = -1
        Dim connection As New SqlConnection(ConnectionString)
        Try
            Dim command As New SqlCommand(procname, connection)
            command.CommandType = CommandType.StoredProcedure

            connection.Open()
            SqlCommandBuilder.DeriveParameters(command)
            Dim x As Integer = 0
            For i As Integer = 0 To command.Parameters.Count - 1
                If command.Parameters(i).Direction = ParameterDirection.Input Then
                    command.Parameters(i).Value = params(x)
                    x = x + 1
                End If
            Next
            command.CommandTimeout = timeout
            ref = command.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            connection.Close()
        End Try

        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)

        Return ref
    End Function
    Public Shared Function ExecuteScalarWithTimeout(ByVal ConnectionString As String, ByVal procname As String, timeout As Integer, ParamArray params() As Object) As Object
        Dim startTime As Date = Now

        Dim ref As Object = Nothing

        Dim connection As New SqlConnection(ConnectionString)
        Try
            Dim command As New SqlCommand(procname, connection)
            command.CommandType = CommandType.StoredProcedure

            connection.Open()
            SqlCommandBuilder.DeriveParameters(command)
            Dim x As Integer = 0
            For i As Integer = 0 To command.Parameters.Count - 1
                If command.Parameters(i).Direction = ParameterDirection.Input Then
                    command.Parameters(i).Value = params(x)
                    x = x + 1
                End If
            Next
            command.CommandTimeout = timeout
            ref = command.ExecuteScalar()
        Catch ex As Exception
        Finally
            connection.Close()
        End Try
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return ref
    End Function
    Public Shared Function ExecuteDatasetWithTimeout(ByVal ConnectionString As String, ByVal procname As String, timeout As Integer, ParamArray params() As Object) As DataSet
        Dim startTime As Date = Now
        Dim ds As DataSet = New DataSet()

        Dim connection As New SqlConnection(ConnectionString)
        Try
            Dim command As New SqlCommand(procname, connection)
            command.CommandType = CommandType.StoredProcedure

            connection.Open()
            SqlCommandBuilder.DeriveParameters(command)
            Dim x As Integer = 0
            For i As Integer = 0 To command.Parameters.Count - 1
                If command.Parameters(i).Direction = ParameterDirection.Input Then
                    command.Parameters(i).Value = params(x)
                    x = x + 1
                End If
            Next
            command.CommandTimeout = timeout
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(ds)
        Catch ex As Exception
            Throw ex
        Finally
            If connection IsNot Nothing Then
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End If
        End Try
        Dim endTime As Date = Now
        'Logger.SQLTimeTracker(procname, endTime.Subtract(startTime).TotalSeconds, params)
        Return ds
    End Function
#End Region
End Class
