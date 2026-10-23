<%@ WebHandler Language="VB" Class="BlockConfigKey" %>
Imports DotNetNuke.CMS

Public Class BlockConfigKey : Implements IHttpHandler
    Dim ObjController As New CmsController
    Dim key, str, sSettings, strArr() As String
    Dim objInfo As New CMS_NewsCategoriesInfo
    Dim portal As Integer

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            key = context.Request.Item("key") & ""
            portal = EPORTAL.flReg.WriteNumber(context.Request.Item("portal"))
            sSettings = flCheck.SetupValue(portal, key)
            str = ""
            strArr = sSettings.Split(",")
            For i As Integer = 0 To strArr.Length - 1
                If IsNumeric(strArr(i)) Then
                    objInfo = ObjController.CMS_NewsCategories_Get(portal, strArr(i))
                    If IsNothing(objInfo) = False Then str += objInfo.CategoryID & ";"
                End If
            Next
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