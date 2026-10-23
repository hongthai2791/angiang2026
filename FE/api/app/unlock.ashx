<%@ WebHandler Language="VB" Class="unlock" %>
Imports DotNetNuke.APP
Imports DotNetNuke.EPORTAL
Imports System.Threading

Public Class unlock : Implements IHttpHandler

    Dim usID As String
    Dim isAct, pid As Integer
    Dim objController As New AppController
    Private Sub SendMail(email As String, isActive As Boolean)
        Dim subject As String = "Keng | Thông báo xác thực thông tin doanh nghiệp của bạn."
        Dim body As String = "<div style='font-size: 15px; font-family: Roboto; border: 1px solid #ccc; padding: 10px;'>"
        body += "Cảm ơn <b>Ông/Bà</b> đã đăng ký sử dụng dịch vụ đăng tin tuyển dụng, tra cứu thông tin việc làm của Keng.<p></p>"
        If isActive = True Then
            body += "Thông tin tài khoản doanh nghiệp của bạn đã được xác thực, vui lòng truy cập vào hệ thống để đăng tin tuyển dụng.<br/> "
        Else
            body += "Thông tin tài khoản doanh nghiệp của bạn đã bị khóa, vui lòng liên hệ với quản trị để được hỗ trợ.<br/> "
        End If
        body += "<p><i>Chú ý: <b>Đây là Email được gửi từ hòm thư tự động, Ông/Bà vui lòng không trả lời lại Email này.</b></i></p>"
        body += "<p style='padding-top:10px'></p>Trân trọng,<br/>"
        body += "Ban quản trị Keng</div>"
        flDnn.DNN_SendMail(email, subject, body)
    End Sub
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        usID = context.Request.Item("uid")
        isAct = flReg.WriteNumber(context.Request.Item("a"))
        pid = flReg.WriteNumber(context.Request.Item("p"))
        Try
            flCache.RemoveCache("CheckInfoUser_" & pid & "_" & usID)
            If (isAct = 1) Then
                objController.CMS_BusUser_Update_Active(pid, usID, True, UserInfo.Username, Now)
            Else
                objController.CMS_BusUser_Update_Active(pid, usID, False, UserInfo.Username, Now)
            End If
            Dim obj As DnnInfo = flDnn.DNN_User_Get_UserName(pid, usID)
            If IsNothing(obj) = False Then
                If obj.IsDeleted = False Then
                    Call SendMail(obj.Email, isAct)
                End If
            End If
        Catch ex As Exception
        End Try
        context.Response.Write("")
    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class

Public Module Moduler
    Public ReadOnly Property UserInfo As UserInfo
        Get
            Dim user As UserInfo
            If (HttpContext.Current Is Nothing) Then
                If Not Thread.CurrentPrincipal.Identity.IsAuthenticated Then
                    Return New UserInfo()
                End If
                Dim portalSettings = PortalController.Instance.GetCurrentPortalSettings()
                If portalSettings IsNot Nothing Then
                    user = UserController.GetCachedUser(portalSettings.PortalId, Thread.CurrentPrincipal.Identity.Name)
                    Return If(user, New UserInfo())
                End If
                Return New UserInfo()
            ElseIf HttpContext.Current.Items("UserInfo") Is Nothing Then
                If HttpContext.Current.Request.IsAuthenticated Then
                    user = UserController.GetCachedUser(PortalSettings.Current.PortalId, HttpContext.Current.User.Identity.Name)
                    HttpContext.Current.Items("UserInfo") = user
                End If
            End If
            user = DirectCast(HttpContext.Current.Items("UserInfo"), UserInfo)
            Return If(user, New UserInfo())
        End Get
    End Property
End Module