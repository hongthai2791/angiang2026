Imports System.IO
Imports DotNetNuke.VBN
Imports System.Net
Imports System.Text

Public Class flNotify
    Shared ObjController As New MobileController
    Shared fcm As New CMS_FCMInfo
    Public Shared Function notiSendAdd(mID As Integer, flag As String, appID As String,
                               contents As String, idKey As String, logo As String,
                               Optional ByVal trangThai As Integer = appNotiSend.Send,
                               Optional ByVal fwSend As String = "",
                               Optional ByVal titles As String = "iziMom - Thông báo") As Integer
        Try
            Dim sbj As New CMS_NotiSendInfo
            sbj.Notify_ID = "dfedb717-a7ed-4b87-9448-0dfae08d2737"
            sbj.Titles = titles
            sbj.Contents = contents
            sbj.AppID = appID
            sbj.IdKey = idKey
            sbj.Logo = logo
            sbj.TinhTrang = trangThai
            sbj.CreatedDate = Now
            If trangThai = appNotiSend.Errors Then
                sbj.SendDate = flReg.DateNull()
            Else
                sbj.SendDate = Now
            End If
            sbj.ReadDate = flReg.DateNull()
            sbj.FwSend = fwSend
            sbj.Flags = flag
            sbj.PortalID = mID

            Return ObjController.CMS_NotiSend_Add(0, sbj)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Shared Function SendNotification(pid As Integer, id As String, appID As String, title As String, bodyMsg As String) As Boolean
        fcm = ObjController.CMS_FCM_Get(0, appID, pid)
        If IsNothing(fcm) = False Then
            Try

                Dim tRequest As WebRequest = WebRequest.Create(flReg.WebConfig("fcmPath"))
                tRequest.Method = "POST"
                tRequest.UseDefaultCredentials = True
                tRequest.PreAuthenticate = True
                tRequest.Credentials = CredentialCache.DefaultNetworkCredentials
                tRequest.ContentType = "application/json"
                If pid < 3 Then
                    tRequest.Headers.Add(String.Format("Authorization: key={0}", "" & flReg.WebConfig("serverKey") & ""))
                    tRequest.Headers.Add(String.Format("Sender: id={0}", flReg.WebConfig("senderID")))
                Else
                    tRequest.Headers.Add(String.Format("Authorization: key={0}", "" & flReg.WebConfig("serverKey_IZI") & ""))
                    tRequest.Headers.Add(String.Format("Sender: id={0}", flReg.WebConfig("senderID_IZI")))
                End If
                Dim postData As String = "{""registration_ids"": [""" & String.Join(""", """, fcm.Token) & """],
											""notification"": {""message"": """ & flReg.Trimstr(bodyMsg, 100) & """, ""body"":""" & bodyMsg & """, ""title"": """ & title & """},
											""data"": {""message"": """ & flReg.Trimstr(bodyMsg, 100) & """, ""body"":""" & bodyMsg & """, ""title"": """ & title & """}
										}"
                Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
                tRequest.ContentLength = byteArray.Length
                flNotify.notiLogAdd(id, String.Format("NOTI SEND {0}", postData), fcm.ID)

                Dim dataStream As Stream = tRequest.GetRequestStream()
                dataStream.Write(byteArray, 0, byteArray.Length)
                dataStream.Close()

                Dim tResponse As WebResponse = tRequest.GetResponse()
                dataStream = tResponse.GetResponseStream()

                Dim tReader As StreamReader = New StreamReader(dataStream)
                Dim sResponseFromServer As String = tReader.ReadToEnd()
                flNotify.notiLogAdd(id, String.Format("API CALL. TOKEN: {0}", sResponseFromServer), fcm.ID)

                tReader.Close()
                dataStream.Close()
                tResponse.Close()
                Return True
            Catch ex As Exception
                flNotify.notiLogAdd(id, ex.Message, fcm.ID)
                Return False
            End Try
        Else
            Return False
        End If

    End Function
    Public Shared Sub notiLogAdd(idKey As String, logName As String, fcmID As Integer)
        Try
            Dim obj As New CMS_NotiLogInfo
            obj.Notify_ID = idKey
            obj.LogName = logName
            obj.LogDate = Now
            obj.LogUser = "System"
            obj.FcmID = fcmID
            obj.NotiLog_ID = ObjController.CMS_NotiLog_Add(0, obj)
        Catch ex As Exception
        End Try
    End Sub
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
