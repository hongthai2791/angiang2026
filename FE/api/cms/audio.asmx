<%@ WebService Language="VB" Class="audio" %>
Imports System.Web.Services
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Web.Script.Services
Imports System.Web.Services.Protocols


<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ScriptService()>
Public Class audio
    Inherits System.Web.Services.WebService

    Private result As New flFunction.Response With {.Status = 0, .Data = Nothing, .Message = String.Empty}
    Dim ObjController As New CmsController
    Dim arrTemp, arrTemp1, arrTemp2, arrTemp3 As New ArrayList(), arrResult As New ArrayList()
    Public Authentication As AuthHeader

    <WebMethod(EnableSession:=True)>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function AudioHook(request_id As String, audio_link As String) As String
        Try

            Dim Data As New ResponseHookData()
            Data.request_id = request_id
            Data.audio_link = audio_link

            System.Net.ServicePointManager.Expect100Continue = True
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
            'Download file  media về csdl     
            If Data.request_id <> "" And Data.audio_link.ToLower() <> "null" Then

                'DOWNLOAD FILE
                Using wclien As New System.Net.WebClient()
                    'wclien.Credentials = New System.Net.NetworkCredential("root", "")
                    'server path of the file
                    Dim bytes() As Byte = wclien.DownloadData(Data.audio_link)
                    Using mem As New IO.MemoryStream(bytes)
                        Try
                            Using file As New IO.FileStream(Hosting.HostingEnvironment.MapPath("/data/audio"), IO.FileMode.CreateNew, IO.FileAccess.Write)
                                mem.WriteTo(file)
                                file.Close()
                            End Using
                        Catch ex As Exception

                            Dim objEventLog = New DotNetNuke.Services.Log.EventLog.EventLogController()
                            objEventLog.AddLog("NEWS_VOICE_SAVEFILE_LOG:", ex.StackTrace, GetPortalSettings, 1, DotNetNuke.Services.Log.EventLog.EventLogController.EventLogType.ADMIN_ALERT)
                            'ex.Message.ToString()
                        Finally
                            mem.Close()
                        End Try
                    End Using
                End Using
            End If
            result.Data = "1" 'JsonConvert.SerializeObject(data)
            result.Message = "Success"
            result.Status = 200
        Catch ex As Exception
            ex.StackTrace.ToString()
            result.Data = JsonConvert.SerializeObject(ex)
            result.Message = "Fail"
            result.Status = 404
        End Try
        result.ToHttpResponse()
    End Function


    '<WebMethod(EnableSession:=True)>
    '<ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    'Public Function VoiceDetailResponse(pid As String, newsVoiceID As String, voiceAccentID As String, sessionID As String) As String
    '    Try
    '        'Lưu mã session TTS vào 1 bảng trung gian thuooc PORTAL 0 để sau xác định dữ liệu API trả về thuộc portal nào
    '        Dim objSession As New NewsVoice_SessionInfo
    '        objSession.TTS_SessionID = sessionID
    '        objSession.PortalID = pid
    '        objSession.IsFinish = False
    '        objSession.CreateDate = Now
    '        ObjController.NewsVoice_Session_Add(flConnect.PortalId, objSession)

    '        'Kiểm tra nếu chưa có thì tạo mới
    '        Dim objVoiceDetail As New NewsVoice_DetailInfo
    '        objVoiceDetail = ObjController.NewsVoice_Detail_Get_By_AccentID(pid, newsVoiceID, voiceAccentID)

    '        If IsNothing(objVoiceDetail) Then
    '            Dim objVoice As New NewsVoiceInfo
    '            objVoice = ObjController.NewsVoice_Get(pid, newsVoiceID)
    '            Dim pathFolder = "/DATA/" & objSession.PortalID & "/VOICE/" & objVoice.CreateDate.ToString("yyyy/MM/dd") & "/" & newsVoiceID & "/"
    '            If IsNothing(objVoice) = False Then
    '                If IO.Directory.Exists(Hosting.HostingEnvironment.MapPath(pathFolder)) = False Then IO.Directory.CreateDirectory(Hosting.HostingEnvironment.MapPath(pathFolder))
    '                objVoiceDetail = New NewsVoice_DetailInfo()
    '                objVoiceDetail.ID = flReg.GenKey()
    '                objVoiceDetail.NewsVoiceID = newsVoiceID
    '                objVoiceDetail.VoiceAccent = voiceAccentID
    '                objVoiceDetail.VoiceAccentName = VoiceName(voiceAccentID)
    '                objVoiceDetail.TTS_AudioUrl = ""
    '                objVoiceDetail.IsActive = True
    '                objVoiceDetail.SendView = True
    '            End If

    '            objVoiceDetail.TTS_SesionID = sessionID
    '            'objVoiceDetail.TTS_AudioUrl = ""
    '            objVoiceDetail.Status = 1
    '            objVoiceDetail.Audio_Url = pathFolder & voiceAccentID & "_" & Now.ToString("ddMMyyyyhhmmss") & ".mp3"
    '            Call ObjController.NewsVoice_Detail_Add(pid, objVoiceDetail)

    '        Else
    '            Dim objVoice As New NewsVoiceInfo
    '            objVoice = ObjController.NewsVoice_Get(pid, newsVoiceID)
    '            Dim pathFolder = "/DATA/" & objSession.PortalID & "/VOICE/" & objVoice.CreateDate.ToString("yyyy/MM/dd") & "/" & objVoice.ItemID & "/"
    '            If IsNothing(objVoice) = False Then
    '                If IO.Directory.Exists(Hosting.HostingEnvironment.MapPath(pathFolder)) = False Then IO.Directory.CreateDirectory(Hosting.HostingEnvironment.MapPath(pathFolder))
    '            End If
    '            objVoiceDetail.Status = 1
    '            objVoiceDetail.SendView = False
    '            objVoiceDetail.TTS_SesionID = sessionID
    '            objVoiceDetail.Audio_Url = pathFolder & voiceAccentID & "_" & Now.ToString("ddMMyyyyhhmmss") & ".mp3"
    '            ObjController.NewsVoice_Detail_Update(pid, objVoiceDetail)

    '            ''Update status detail
    '            'ObjController.NewsVoice_Detail_Update_Status(pid, objVoiceDetail.ID, 1)
    '            ''Update sendview detail
    '            'ObjController.NewsVoice_Detail_Update_SendView(pid, objVoiceDetail.ID, False)
    '        End If

    '        'Download file  media về csdl     

    '        result.Data = "" 'JsonConvert.SerializeObject(data)
    '        result.Message = "Success"
    '        result.Status = 200
    '    Catch ex As Exception
    '        result.Data = "" 'JsonConvert.SerializeObject(data)
    '        result.Message = "Fail"
    '        result.Status = 200
    '    End Try
    '    result.ToHttpResponse()
    'End Function



    Private Sub ResponseHeader()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub

    Public Function VoiceName(ByVal voiceID As String) As String
        Select Case voiceID
            Case "hn_female_ngochuyen_full_48k-fhg"
                Return "HN - Ngọc Huyền"
            Case "hn_male_phuthang_news65dt_44k-fhg"
                Return "HN - Phú Thăng"
            Case "hn_male_thanhlong_talk_48k-fhg"
                Return "HN - Thanh Long"
            Case "hn_female_maiphuong_vdts_48k-fhg"
                Return "HN - Mai Phương"
            Case "hn_male_manhdung_news_48k-fhg"
                Return "HN - Mạnh Dũng"
            Case "sg_female_tuongvy_call_44k-fhg"
                Return "SG - Tường Vy"
            Case "sg_female_lantrinh_vdts_48k-fhg"
                Return "SG - Lan Trinh"
            Case "sg_male_trungkien_vdts_48k-fhg"
                Return "SG - Trung Kiên"
            Case "sg_male_minhhoang_full_48k-fhg"
                Return "SG - Minh Hoàng"
            Case "sg_female_thaotrinh_full_48k-fhg"
                Return "SG - Thảo Trinh"
            Case "hue_male_duyphuong_full_48k-fhg"
                Return "Huế - Duy Phương"
            Case "hue_female_huonggiang_full_48k-fhg"
                Return "Huế - Hương Giang"
        End Select
        Return ""
    End Function
End Class
Public Module Moduler
    <Extension()>
    Public Sub ToHttpResponse(ByVal target As flFunction.Response)
        Dim context As HttpContext = HttpContext.Current
        Dim settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}
        context.Response.ClearContent()
        context.Response.ContentType = "application/json"
        context.Response.Charset = "UTF-8"
        context.Response.Write(JsonConvert.SerializeObject(target, settings))
        context.Response.Flush()
        context.Response.End()
    End Sub
End Module

Public Class AuthHeader
    Inherits SoapHeader
    Public Username As String
    Public Password As String
End Class


Public Class ResponseHookData
    Public Property app_id As String = String.Empty
    Public Property request_id As String = String.Empty
    Public Property characters As String = String.Empty
    Public Property voice_code As String = String.Empty
    Public Property audio_type As String = String.Empty
    Public Property speed_rate As String = String.Empty
    Public Property bitrate As String = String.Empty
    Public Property sample_rate As String = String.Empty
    Public Property created_at As String = String.Empty
    Public Property status As String = String.Empty
    Public Property audio_link As String = String.Empty
End Class