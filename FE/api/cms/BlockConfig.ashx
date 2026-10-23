<%@ WebHandler Language="VB" Class="BlockConfig" %>
Imports DotNetNuke.CMS

Public Class BlockConfig : Implements IHttpHandler
    Dim ObjController As New CmsController
    Dim key, str, sSettings, strArr() As String
    Dim objInfo As New CMS_NewsCategoriesInfo
    Dim portal As Integer

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            key = context.Request.Item("key") & ""
            portal = EPORTAL.flReg.WriteNumber(context.Request.Item("portal"))
            sSettings = flCheck.SetupValue(portal, key)
            str = "<ul id=""sortable"" style=""padding: 0px; margin: 0px"">"
            strArr = sSettings.Split(";")
            For i As Integer = 0 To strArr.Length - 1
                objInfo = ObjController.CMS_NewsCategories_Get(portal, EPORTAL.flReg.WriteNumber(strArr(i)))
                If IsNothing(objInfo) = False Then
                    str += "<li class=""ui-state-default"" rel=""" & objInfo.CategoryID & """>"
                    str += "<span class=""ui-icon ui-icon-arrowthick-2-n-s""></span>" & objInfo.CategoryName
                    str += "<a class=""delRelated"" onclick=""javascript:delCategory(this," & objInfo.CategoryID & ");"" title=""Xóa tin?"" style=""cursor:pointer;""></a>"
                    str += "</li>"
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