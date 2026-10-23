<%@ WebService Language="VB" Class="ReadEmail.Services.Autocomplete" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports MailKit
Imports MailKit.Search
Imports MailKit.Security
Imports MailKit.Net.Imap
Imports MimeKit
Imports System.IO
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports DotNetNuke.APP
Imports DotNetNuke.EPORTAL
Namespace ReadEmail.Services

    <WebService(Namespace:="http://tempuri.org/")>
    <WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Public Class Autocomplete
        Inherits System.Web.Services.WebService

        Public objCTL As New AppController
        Dim arrFile As ArrayList
        Dim sFileType, strAttch As String

        Private Shared Function customCertValidation(ByVal sender As Object,
                                           ByVal cert As X509Certificate,
                                           ByVal chain As X509Chain,
                                           ByVal errors As SslPolicyErrors) As Boolean

            Return True

        End Function
        <WebMethod>
        Public Function ReadContentEmail() As String
            Dim ItemID = HttpContext.Current.Request("id")
            Dim email, pass As String
            Dim filePath As String = "\\data\\0\\KengCV\\" & Now.ToString("yy\\MM\\")
            Try
                Dim diroot As DirectoryInfo
                diroot = New DirectoryInfo(Server.MapPath(filePath))
                If Not diroot.Exists Then diroot.Create()

                email = flReg.WebConfig("EmailFile")
                pass = flReg.Decrypt("keng", flReg.WebConfig("PWDFile"))
                ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf customCertValidation)
                Using client = New ImapClient()
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect)
                    client.Authenticate(email, pass)
                    client.Inbox.Open(FolderAccess.ReadWrite)
                    Dim uids = client.Inbox.Search(SearchQuery.SentAfter(Now.AddMonths(-1)))
                    'Thư chưa đọc
                    For Each uid In uids
                        Dim mailMess = client.Inbox.GetMessage(uid)
                        If mailMess.Subject IsNot Nothing Then
                            If mailMess.Subject = ItemID Then
                                If mailMess.HtmlBody Is Nothing Then Continue For
                                If mailMess.HtmlBody.Contains("[KENG]") = True Then
                                    For Each attachment In mailMess.Attachments
                                        sFileType = flReg.GetFileType(attachment.ContentType.Name, ".").ToLower
                                        strAttch = flReg.GenKey() & "." & sFileType
                                        Using stream = File.Create(Server.MapPath(filePath) & strAttch)
                                            If TypeOf attachment Is MessagePart Then
                                                Dim part = DirectCast(attachment, MessagePart)
                                                part.Message.WriteTo(stream)
                                            Else
                                                Dim part = DirectCast(attachment, MimePart)
                                                part.ContentObject.DecodeTo(stream)
                                            End If
                                        End Using
                                        objCTL.CMS_FileCV_File_Path(0, filePath.Replace("\\", "/").Replace("\", "/") & strAttch, mailMess.Subject)
                                    Next
                                    client.Inbox.AddFlags(uid, MessageFlags.Seen, True)
                                End If
                                Exit For
                            End If
                        End If
                    Next
                    client.Disconnect(True)
                End Using
                Return "ok"
            Catch ex As Exception
                LogError("row" & ex.Source & "--" & ex.Message)
                Return ex.Message
            End Try
        End Function
        <WebMethod>
        Public Function ReadContentEmail_all() As String
            Dim email, pass As String
            Dim filePath As String = "\\data\\0\\KengCV\\" & Now.ToString("yy\\MM\\")
            Try
                Dim diroot As DirectoryInfo
                diroot = New DirectoryInfo(Server.MapPath(filePath))
                If Not diroot.Exists Then diroot.Create()

                email = flReg.WebConfig("EmailFile")
                pass = flReg.Decrypt("keng", flReg.WebConfig("PWDFile"))
                ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf customCertValidation)
                Using client = New ImapClient()
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect)
                    client.Authenticate(email, pass)
                    client.Inbox.Open(FolderAccess.ReadWrite)
                    Dim uids = client.Inbox.Search(SearchQuery.SentAfter(Now.AddMonths(-1)))
                    'Thư chưa đọc
                    For Each uid In uids
                        Dim mailMess = client.Inbox.GetMessage(uid)
                        If mailMess.Subject IsNot Nothing Then
                            If mailMess.HtmlBody Is Nothing Then Continue For
                            If mailMess.HtmlBody.Contains("[KENG]") = True Then
                                For Each attachment In mailMess.Attachments
                                    sFileType = flReg.GetFileType(attachment.ContentType.Name, ".").ToLower
                                    strAttch = flReg.GenKey() & "." & sFileType
                                    Using stream = File.Create(Server.MapPath(filePath) & strAttch)
                                        If TypeOf attachment Is MessagePart Then
                                            Dim part = DirectCast(attachment, MessagePart)
                                            part.Message.WriteTo(stream)
                                        Else
                                            Dim part = DirectCast(attachment, MimePart)
                                            part.ContentObject.DecodeTo(stream)
                                        End If
                                    End Using
                                    objCTL.CMS_FileCV_File_Path(0, filePath.Replace("\\", "/").Replace("\", "/") & strAttch, mailMess.Subject)
                                Next
                                client.Inbox.AddFlags(uid, MessageFlags.Seen, True)
                            End If
                        End If
                    Next
                    client.Disconnect(True)
                End Using
                Return "ok"
            Catch ex As Exception
                LogError("row" & ex.Source & "--" & ex.Message)
                Return ex.Message
            End Try
        End Function
        Private Sub LogError(err As String)
            Dim file As System.IO.StreamWriter
            Dim path = Server.MapPath("/errorservice.txt")
            file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
            file.WriteLine(err)
            file.Close()
        End Sub
    End Class
End Namespace
