<%@ WebHandler Language="VB" Class="UActive" %>
Imports DotNetNuke.EPORTAL

Public Class UActive : Implements IHttpHandler
    Dim Id, isAct As Integer
    Dim tabName As String
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Id = flReg.WriteNumber(context.Request.Item("i"))
        isAct = flReg.WriteNumber(context.Request.Item("a"))
        tabName = context.Request.Item("ta")
        Try
            If (isAct = -1) Then '' delete user
                flDnn.DNN_User_DeleteLock(Id, True, flReg.subPortal(0, tabName))
            ElseIf (isAct = 1) Then
                flDnn.DNN_User_Lock(Id, True, flReg.subPortal(0, tabName))
            Else
                flDnn.DNN_User_Lock(Id, False, flReg.subPortal(0, tabName))
            End If
            context.Response.Write(Id)
        Catch ex As Exception
            context.Response.Write(ex.Message)
        End Try
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class