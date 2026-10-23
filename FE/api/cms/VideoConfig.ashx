<%@ WebHandler Language="VB" Class="VideoConfig" %>
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Public Class VideoConfig : Implements IHttpHandler
    Dim ObjController As New CmsController
    Dim key, str, sSettings, strArr() As String
    Dim objInfo As New CMS_MediaInfo
    Dim portal As Integer

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            key = context.Request.Item("key") & ""
            portal = flReg.WriteNumber(context.Request.Item("portal"))
            sSettings = flCheck.SetupValue(portal, key)
            str = "<ul id=""sortable"" style=""padding: 0px; margin: 0px"">"
            strArr = sSettings.Split(",")
            For i As Integer = 0 To strArr.Length - 1
                If IsNumeric(strArr(i)) Then
                    objInfo = ObjController.CMS_Media_Get(portal, strArr(i))
                    If IsNothing(objInfo) = False Then
                        str += "<li class=""ui-state-default"" rel=""" & objInfo.Id & """>"
                        str += "<span class=""ui-icon ui-icon-arrowthick-2-n-s""></span>" & objInfo.Name
                        str += "<a class=""delRelated"" onclick=""javascript:delNews(this," & objInfo.Id & ");"" title=""Xóa tin?"" style=""cursor:pointer;""></a>"
                        str += "</li>"
                    End If
                End If
            Next
            str += "</ul>"
            context.Response.Write(str)
        Catch ex As Exception
            context.Response.Write("")
        End Try
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class