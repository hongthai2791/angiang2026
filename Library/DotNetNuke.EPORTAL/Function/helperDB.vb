Imports System.Data.SqlClient

Public Class helperDB
    Private Enum SqlConnectionOwnership
        Internal
        External
    End Enum

    Private Shared Function ExecuteReader(ByVal connection As SqlConnection, ByVal transaction As SqlTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal commandParameters As SqlParameter(), ByVal connectionOwnership As SqlConnectionOwnership) As SqlDataReader
            Dim cmd As SqlCommand = New SqlCommand()
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters)
            Dim dr As SqlDataReader

            If connectionOwnership = SqlConnectionOwnership.External Then
                dr = cmd.ExecuteReader()
            Else
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            End If

            cmd.Parameters.Clear()
            Return dr
        End Function

        Public Shared Function ExecuteReader(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As SqlDataReader
            Return ExecuteReader(connectionString, commandType, commandText, CType(Nothing, SqlParameter()))
        End Function

        Public Shared Function ExecuteReader(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ParamArray commandParameters As SqlParameter()) As SqlDataReader
            Dim cn As SqlConnection = New SqlConnection(connectionString)
            cn.Open()

            Try
                Return ExecuteReader(cn, Nothing, commandType, commandText, commandParameters, SqlConnectionOwnership.Internal)
            Catch
                cn.Close()
                Throw
            End Try
        End Function

        Public Shared Function ExecuteReader(ByVal connectionString As String, ByVal spName As String, ParamArray parameterValues As Object()) As SqlDataReader
            If (parameterValues IsNot Nothing) AndAlso (parameterValues.Length > 0) Then
                Dim commandParameters As SqlParameter() = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName)
                AssignParameterValues(commandParameters, parameterValues)
                Return ExecuteReader(connectionString, CommandType.StoredProcedure, spName, commandParameters)
            Else
                Return ExecuteReader(connectionString, CommandType.StoredProcedure, spName)
            End If
        End Function

        Public Shared Function ExecuteReader(ByVal connection As SqlConnection, ByVal commandType As CommandType, ByVal commandText As String) As SqlDataReader
            Return ExecuteReader(connection, commandType, commandText, CType(Nothing, SqlParameter()))
        End Function

        Public Shared Function ExecuteReader(ByVal connection As SqlConnection, ByVal commandType As CommandType, ByVal commandText As String, ParamArray commandParameters As SqlParameter()) As SqlDataReader
            Return ExecuteReader(connection, CType(Nothing, SqlTransaction), commandType, commandText, commandParameters, SqlConnectionOwnership.External)
        End Function

        Public Shared Function ExecuteReader(ByVal connection As SqlConnection, ByVal spName As String, ParamArray parameterValues As Object()) As SqlDataReader
            If (parameterValues IsNot Nothing) AndAlso (parameterValues.Length > 0) Then
                Dim commandParameters As SqlParameter() = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName)
                AssignParameterValues(commandParameters, parameterValues)
                Return ExecuteReader(connection, CommandType.StoredProcedure, spName, commandParameters)
            Else
                Return ExecuteReader(connection, CommandType.StoredProcedure, spName)
            End If
        End Function

        Public Shared Function ExecuteReader(ByVal transaction As SqlTransaction, ByVal commandType As CommandType, ByVal commandText As String) As SqlDataReader
            Return ExecuteReader(transaction, commandType, commandText, CType(Nothing, SqlParameter()))
        End Function

        Public Shared Function ExecuteReader(ByVal transaction As SqlTransaction, ByVal commandType As CommandType, ByVal commandText As String, ParamArray commandParameters As SqlParameter()) As SqlDataReader
            Return ExecuteReader(transaction.Connection, transaction, commandType, commandText, commandParameters, SqlConnectionOwnership.External)
        End Function

        Public Shared Function ExecuteReader(ByVal transaction As SqlTransaction, ByVal spName As String, ParamArray parameterValues As Object()) As SqlDataReader
            If (parameterValues IsNot Nothing) AndAlso (parameterValues.Length > 0) Then
                Dim commandParameters As SqlParameter() = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection.ConnectionString, spName)
                AssignParameterValues(commandParameters, parameterValues)
                Return ExecuteReader(transaction, CommandType.StoredProcedure, spName, commandParameters)
            Else
                Return ExecuteReader(transaction, CommandType.StoredProcedure, spName)
            End If
        End Function

    Private Shared Sub AttachParameters(ByVal command As SqlCommand, ByVal commandParameters As SqlParameter())
        For Each p As SqlParameter In commandParameters

            If (p.Direction = ParameterDirection.InputOutput) AndAlso (p.Value Is Nothing) Then
                p.Value = DBNull.Value
            End If

            command.Parameters.Add(p)
        Next
    End Sub
    Private Shared Sub PrepareCommand(ByVal command As SqlCommand, ByVal connection As SqlConnection, ByVal transaction As SqlTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal commandParameters As SqlParameter())
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If
        command.CommandTimeout = 600
        command.Connection = connection
        command.CommandText = commandText

        If transaction IsNot Nothing Then
            command.Transaction = transaction
        End If

        command.CommandType = commandType

        If commandParameters IsNot Nothing Then
            AttachParameters(command, commandParameters)
        End If

        Return
    End Sub
Private Shared Sub AssignParameterValues(ByVal commandParameters As SqlParameter(), ByVal parameterValues As Object())
    If (commandParameters Is Nothing) OrElse (parameterValues Is Nothing) Then
        Return
    End If

    If commandParameters.Length <> parameterValues.Length Then
        Throw New ArgumentException("Parameter count does not match Parameter Value count.")
    End If

    Dim i As Integer = 0, j As Integer = commandParameters.Length

    While i < j
        commandParameters(i).Value = parameterValues(i)
        i += 1
    End While
End Sub

End Class
Public NotInheritable Class SqlHelperParameterCache
    Private Sub New()
    End Sub

    Private Shared paramCache As Hashtable = Hashtable.Synchronized(New Hashtable())

    Private Shared Function DiscoverSpParameterSet(ByVal connectionString As String, ByVal spName As String, ByVal includeReturnValueParameter As Boolean) As SqlParameter()
        Using cn As SqlConnection = New SqlConnection(connectionString)

            Using cmd As SqlCommand = New SqlCommand(spName, cn)
                cn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 500
                SqlCommandBuilder.DeriveParameters(cmd)

                If Not includeReturnValueParameter Then
                    cmd.Parameters.RemoveAt(0)
                End If

                Dim discoveredParameters As SqlParameter() = New SqlParameter(cmd.Parameters.Count - 1) {}
                cmd.Parameters.CopyTo(discoveredParameters, 0)
                Return discoveredParameters
            End Using
        End Using
    End Function

    Private Shared Function CloneParameters(ByVal originalParameters As SqlParameter()) As SqlParameter()
        Dim clonedParameters As SqlParameter() = New SqlParameter(originalParameters.Length - 1) {}
        Dim i As Integer = 0, j As Integer = originalParameters.Length

        While i < j
            clonedParameters(i) = CType((CType(originalParameters(i), ICloneable)).Clone(), SqlParameter)
            i += 1
        End While

        Return clonedParameters
    End Function

    Public Shared Sub CacheParameterSet(ByVal connectionString As String, ByVal commandText As String, ParamArray commandParameters As SqlParameter())
        Dim hashKey As String = connectionString & ":" & commandText
        paramCache(hashKey) = commandParameters
    End Sub

    Public Shared Function GetCachedParameterSet(ByVal connectionString As String, ByVal commandText As String) As SqlParameter()
        Dim hashKey As String = connectionString & ":" & commandText
        Dim cachedParameters As SqlParameter() = CType(paramCache(hashKey), SqlParameter())

        If cachedParameters Is Nothing Then
            Return Nothing
        Else
            Return CloneParameters(cachedParameters)
        End If
    End Function

    Public Shared Function GetSpParameterSet(ByVal connectionString As String, ByVal spName As String) As SqlParameter()
        Return GetSpParameterSet(connectionString, spName, False)
    End Function

    Public Shared Function GetSpParameterSet(ByVal connectionString As String, ByVal spName As String, ByVal includeReturnValueParameter As Boolean) As SqlParameter()
        Dim hashKey As String = connectionString & ":" & spName & (If(includeReturnValueParameter, ":include ReturnValue Parameter", ""))
        Dim cachedParameters As SqlParameter()
        cachedParameters = CType(paramCache(hashKey), SqlParameter())

        If cachedParameters Is Nothing Then
            cachedParameters = CType((CSharpImpl.__Assign(paramCache(hashKey), DiscoverSpParameterSet(connectionString, spName, includeReturnValueParameter))), SqlParameter())
        End If

        Return CloneParameters(cachedParameters)
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class

