Imports Newtonsoft.Json

Public Class VbCapchar
    Inherits System.Web.UI.UserControl
    Public Property IsValid() As Boolean
        Get
            Dim s As String = ReCaptchaClass.Validate(Request.Form("g-recaptcha-response")).ToLower()
            If (s = "true") Then
                Return True
            Else
                Return False
            End If
        End Get
        Set(value As Boolean)

        End Set
    End Property
End Class
Public Class ReCaptchaClass
    Public Shared Function Validate(ByVal EncodedResponse As String) As String
        Dim client = New System.Net.WebClient()
        Dim GoogleReply = client.DownloadString(String.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", EPORTAL.flReg.WebConfig("captCha"), EncodedResponse))
        Dim captchaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ReCaptchaClass)(GoogleReply)
        Return captchaResponse.Success
    End Function

    <JsonProperty("success")>
    Public Property Success() As String
        Get
            Return m_Success
        End Get
        Set(value As String)
            m_Success = value
        End Set
    End Property
    Private m_Success As String

    <JsonProperty("error-codes")>
    Public Property ErrorCodes() As List(Of String)
        Get
            Return m_ErrorCodes
        End Get
        Set(value As List(Of String))
            m_ErrorCodes = value
        End Set
    End Property

    Private m_ErrorCodes As List(Of String)
End Class
