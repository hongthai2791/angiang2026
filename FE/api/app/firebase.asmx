<%@ WebService Language="VB" Class="firebase" %>
Imports System.Web.Services
Imports DotNetNuke.APP
Imports System.IO
Imports System.Net

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class firebase
    Inherits System.Web.Services.WebService
    Dim pid As Integer = 0
    Dim objController As New AppController
    Dim obj As New CMS_FCMInfo

    <WebMethod()>
    Public Function notifyGet(appID As String) As String
        Try
            Dim dsFcm As New List(Of CMS_FCMInfo)()
            obj = objController.CMS_FCM_Get(pid, appID)
            If IsNothing(obj) = False Then
                dsFcm.Add(obj)
            End If
            Dim content As String = "Nội dung gửi thông báo"

            If dsFcm.Count > 0 Then
                Dim tRequest As WebRequest
                tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send")
                tRequest.Method = "POST"
                tRequest.UseDefaultCredentials = True
                tRequest.PreAuthenticate = True
                tRequest.Credentials = CredentialCache.DefaultNetworkCredentials
                tRequest.ContentType = "application/json"
                tRequest.Headers.Add(String.Format("Authorization: key={0}", "" & EPORTAL.flReg.WebConfig("NotiApp") & ""))
                tRequest.Headers.Add(String.Format("Sender: id={0}", "416095262216"))

                Dim arrRegid As String() = dsFcm.[Select](Function(x) x.Token).ToArray()
                Dim RegArr As String = String.Empty
                RegArr = String.Join(""", """, arrRegid)
                Dim postData As String = "{ ""registration_ids"": [ """ + RegArr + """ ],""notification"": {""message"": """ + content + """, ""title"": ""Thông báo việc làm hàng tháng"",""collapse_key"":""" + appID + """},""data"": { ""message"": """ + content + """, ""Content"":""" + content + """, ""title"": ""Thông báo việc làm hàng tháng"",""collapse_key"":""" + appID + """}}"
                Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
                tRequest.ContentLength = byteArray.Length
                IO.File.WriteAllText(Server.MapPath("~/log.txt"), String.Format("API CALL. TOKEN: {0}", postData))

                Dim dataStream As Stream = tRequest.GetRequestStream()
                dataStream.Write(byteArray, 0, byteArray.Length)
                dataStream.Close()
                Dim tResponse As WebResponse = tRequest.GetResponse()
                dataStream = tResponse.GetResponseStream()
                Dim tReader As StreamReader = New StreamReader(dataStream)
                Dim sResponseFromServer As String = tReader.ReadToEnd()
                IO.File.WriteAllText(Server.MapPath("~/log1.txt"), String.Format("API CALL. TOKEN: {0}", sResponseFromServer))

                tReader.Close()
                dataStream.Close()
                tResponse.Close()
            End If
            Return "ok"
        Catch ex As Exception
            Return "er"
        End Try
    End Function
End Class
