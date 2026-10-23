Imports DotNetNuke.Security.Roles
Imports DotNetNuke.Common.Globals
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.Entities.Users
Imports System.Text
Imports System.Web

Public Class Ultis
    Shared ObjController As New MapController
    Shared uInfo As New UserInfo
    Shared arrStr() As String
    Public Shared Function GetSafeRawUrl(url As String) As String
        If String.IsNullOrEmpty(url) Then Return String.Empty
        Dim tProcessedRaw As String = url
        tProcessedRaw = tProcessedRaw.Replace("""", String.Empty)
        tProcessedRaw = tProcessedRaw.Replace("<", "%3C")
        tProcessedRaw = tProcessedRaw.Replace(">", "%3E")
        tProcessedRaw = tProcessedRaw.Replace("&", "%26")
        Return tProcessedRaw.Replace("'", String.Empty)
    End Function
    Public Shared Function getDate(dates As String, bFrom As Boolean) As DateTime
        If bFrom = True Then
            If dates = "" Then dates = "01/01/2000"
            arrStr = dates.Split("/")
            Return New Date(arrStr(2), arrStr(1), arrStr(0), 0, 0, 0)
        Else
            If dates = "" Then dates = Now.AddDays(15).ToString("dd/MM/yyyy")
            arrStr = dates.Split("/")
            Return New Date(arrStr(2), arrStr(1), arrStr(0), 23, 59, 59)
        End If
    End Function
    Public Shared Function ValDate(dates As String, f As Boolean) As DateTime
        If f = True Then
            If dates <> "" Then
                arrStr = dates.Split("-")
                Return New DateTime(arrStr(2), arrStr(1), arrStr(0), 0, 0, 0)
            Else
                Return New DateTime(Now.AddDays(-30).Year, Now.AddDays(-30).Month, Now.AddDays(-30).Day, 0, 0, 0)
            End If
        Else
            If dates <> "" Then
                arrStr = dates.Split("-")
                Return New DateTime(arrStr(2), arrStr(1), arrStr(0), 23, 59, 59)
            Else
                Return New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 59)
            End If
        End If
    End Function
    Public Shared Function AllPortal() As ArrayList
        If IsNothing(flCache.GetCache("AllPortal:DNN_Portal_List_Lang")) = True Then
            AllPortal = flDnn.DNN_Portal_List_Lang(flDic.GetLanguage)
            flCache.SetCache("AllPortal:DNN_Portal_List_Lang", AllPortal)
        Else
            AllPortal = CType(flCache.GetCache("AllPortal:DNN_Portal_List_Lang"), ArrayList)
        End If
    End Function
    Public Shared Function UserPortal(Username As String) As ArrayList
        If IsNothing(flCache.GetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username)) = True Then
            UserPortal = flDnn.DNN_Portal_Get_By_UserID(Username)
            flCache.SetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username, UserPortal)
        Else
            UserPortal = CType(flCache.GetCache("UserPortal:DNN_Portal_Get_By_UserID_" & Username), ArrayList)
        End If
    End Function
    Public Shared Function Version() As String
        Return "3.1"
    End Function
    Public Shared Function FormatViewDate(Dates As DateTime) As String
        Return Dates.ToString("dd/MM/yyyy HH:mm")
    End Function
    Public Shared Function FullTextSearch(keywords As String, Optional ByVal toUrl As Boolean = True) As String
        If toUrl = True Then
            FullTextSearch = flReg.NameUrl(keywords).Replace("-", " ")
            FullTextSearch = endCodeSearch(FullTextSearch)
            FullTextSearch = FullTextSearch.Replace("*", "")
        Else
            FullTextSearch = endCodeSearch(keywords)
            FullTextSearch = FullTextSearch.Replace("*", "")
        End If
    End Function
    Public Shared Function endCodeSearch(keywords As String) As String
        If keywords <> "" Then
            keywords = keywords.Replace("'", "''")
            keywords = keywords.Replace("""", """""")
            Dim sbKeyWordsFilter As New StringBuilder()
            Dim splitedKeyWords As String() = keywords.Trim().Split(" ")
            For i As Integer = 0 To splitedKeyWords.Length - 2

                sbKeyWordsFilter.Append("""")
                sbKeyWordsFilter.Append(splitedKeyWords(i))
                sbKeyWordsFilter.Append("*"" & ")
            Next
            sbKeyWordsFilter.Append("""")
            sbKeyWordsFilter.Append(splitedKeyWords(splitedKeyWords.Length - 1))
            sbKeyWordsFilter.Append("*""")
            Return sbKeyWordsFilter.ToString()
        End If
        Return ""
    End Function
    Public Shared Function FontError(value As String) As String
        Dim arr1 As String() = New String() {"ô%3ḅ", "ê%3ḅ", "â%3ḅ", "Ô%3ḅ", "Ê%3ḅ", "Â%3ḅ"}
        Dim arr2 As String() = New String() {"ộ", "ệ", "ậ", "Ộ", "Ệ", "Ậ"}
        For i As Integer = 0 To arr1.Length - 1
            value = value.Replace(arr1(i), arr2(i))
        Next
        Return value
    End Function
End Class

