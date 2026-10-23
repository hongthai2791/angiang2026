Imports System.IO
Imports DotNetNuke.EPORTAL
Imports System.Net
Imports System.Text
Public Class flNotify
    Shared ObjController As New WorkController
    Public Shared Function GetRequestId(surl As String) As Integer
        surl = surl.Replace(".html", "").Substring(surl.LastIndexOf("-") + 1)
        If surl.Contains("?") Then surl = surl.Substring(0, surl.LastIndexOf("?"))
        Return flReg.WriteNumber(surl)
    End Function
    Public Shared Function FullTextSearch(keywords As String, Optional ByVal toUrl As Boolean = True) As String
        If toUrl = True Then
            FullTextSearch = flReg.NameUrl(keywords).Replace("-", " ")
            FullTextSearch = endCodeSearch(FullTextSearch)
            'FullTextSearch = FullTextSearch.Replace("*", "")
        Else
            FullTextSearch = endCodeSearch(keywords)
            'FullTextSearch = FullTextSearch.Replace("*", "")
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
    Public Shared Function IsVideo(Type As String) As String
        If Type = 2 Then
            Return "<img Class=""photo-imgs"" src=""/image/images/nvideo.png?w"" alt=""iconvideo"" />"
        End If
        Return ""
    End Function
    Public Shared Function ImgPhoto(IsImage As Boolean) As String
        If IsImage = True Then
            Return "<img Class=""photo-imgs"" src=""/image/images/photo1.png?w"" alt=""photo"" />"
        End If
        Return ""
    End Function

End Class
