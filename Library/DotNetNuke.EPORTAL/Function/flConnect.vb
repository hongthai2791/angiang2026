Imports DotNetNuke.Common

Public Class flConnect
    Public Shared Function GetConnection(codeStr As String) As String
        Try
            _strConnect = Utilities.Config.GetConnectionString(codeStr)
            If String.IsNullOrEmpty(_strConnect) = False Then
                _strConnect = _strConnect
            Else
                _strConnect = Utilities.Config.GetConnectionString("SiteSqlServer")
            End If
            Return _strConnect
        Catch ex As Exception
            Return Utilities.Config.GetConnectionString("SiteSqlServer")
        End Try
    End Function
    Public Shared DnnSqlServer As String = GetConnection("SiteSqlServer")
    Public Shared fileDomain As String = GetConnection("fileDomain")
    Public Shared httpService As String = GetConnection("httpService")
    Public Shared cdnDomain As String = GetConnection("cdnDomain")
    Public Shared CmsConnect As String = GetConnection("CmsConnect")
    Public Shared MapConnect As String = GetConnection("MapConnect")
    Public Shared WorkConnect As String = GetConnection("WorkConnect")
    Public Shared CauConnect As String = GetConnection("CauConnect")
    Public Shared CungConnect As String = GetConnection("CungConnect")
    Public Shared InsuConnect As String = GetConnection("InsuConnect")
    Public Shared ChatbotConnect As String = GetConnection("ChatbotConnect")
    Public Shared AnalyConnect As String = GetConnection("AnalyConnect")
    'nhom danh muc dung chung ma hoa ket noi
    Public Shared DmConnect As String = GetConnection("DmConnect")
    Public Shared DmiConnect As String = GetConnection("DmiConnect")
    Public Shared DmcConnect As String = GetConnection("DmcConnect")

    Public Shared IsLang As String = Threading.Thread.CurrentThread.CurrentCulture.Name
    Public Shared myIP As String = flReg.WebConfig("myIP")
    Shared _strConnect, str() As String
    Public Shared PortalId As Integer = GetPortalSettings.PortalId
    Public Shared Property WebDomain(PortalConnect As Integer) As String
        Get
            _strConnect = CType(flCache.GetCache("WebDomain_" & PortalConnect), String) & ""
            If _strConnect = "" Then
                Dim obj As CMSConnectionInfo = flDnn.CMSConnection_Get(PortalConnect)
                If IsNothing(obj) = False Then _strConnect = obj.WebDomain
                flCache.SetCache("WebDomain_" & PortalConnect, _strConnect)
            End If
            Return _strConnect
        End Get
        Set(ByVal Value As String)
            _strConnect = Value
        End Set
    End Property

End Class
Public Class flText
    Public Shared EditImg As String = "/image/images/F-edit.png"
    Public Shared NoEditImg As String = "/image/images/NoF-edit.png"
    Public Shared SendImg As String = "/image/images/send_new.png"
    Public Shared ViewImg As String = "/image/images/view.png"

    Public Shared TEMPWORD As String = "/DATA/TEMPWORD/"
    Public Shared TEMPEXCEL As String = "/DATA/TEMPEXCEL/"

    Public Shared Function DOC_TEMP(Optional ByVal pid As Integer = 0) As String
        Return flReg.MapPath("/DATA/" & pid & "/TEMPS/")
    End Function
    Public Shared Function DOC_DOC(Optional ByVal pid As Integer = 0) As String
        Return flReg.MapPath("/DATA/" & pid & "/DOCUMENTS/" & Now.Year & "/" & IIf(Now.Month < 10, "0" & Now.Month, Now.Month) & "/")
    End Function
    Public Shared Function DOC_EXPORT(Optional ByVal pid As Integer = 0) As String
        Return flReg.MapPath("/DATA/" & pid & "/EXPORTS/" & pid & "/")
    End Function
    Public Shared Function DOC_AUDIO(Optional ByVal pid As Integer = 0) As String
        Return flReg.MapPath("/DATA/" & pid & "/AUDIO/" & Now.Year & "/" & IIf(Now.Month < 10, "0" & Now.Month, Now.Month) & "/")
    End Function
    Public Shared Function BAR_CODE(Optional ByVal pid As Integer = 0) As String
        Return flReg.MapPath("/DATA/" & pid & "/BARCODE/" & Now.Year & "/" & IIf(Now.Month < 10, "0" & Now.Month, Now.Month) & "/")
    End Function
    Public Shared Function QR_CODE(Optional ByVal pid As Integer = 0) As String
        Return flReg.MapPath("/DATA/" & pid & "/QRCODE/" & Now.Year & "/" & IIf(Now.Month < 10, "0" & Now.Month, Now.Month) & "/")
    End Function
    Public Shared Function DOC_IMG(Optional ByVal pid As Integer = 0) As String
        Return flReg.MapPath("/DATA/" & pid & "/IMAGES/" & Now.Year & "/" & IIf(Now.Month < 10, "0" & Now.Month, Now.Month) & "/")
    End Function
    Public Shared Function DOC_VIDEO(Optional ByVal pid As Integer = 0) As String
        Return flReg.MapPath("/DATA/" & pid & "/VIDEO/" & Now.Year & "/" & IIf(Now.Month < 10, "0" & Now.Month, Now.Month) & "/")
    End Function
End Class
Public Enum GioiTinh
    Nu = 0
    Nam
End Enum
