<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.APP
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Private result As New Response With {.Status = ServiceStatus.NODATA, .Data = Nothing, .Message = String.Empty}
    Dim objCTL As New AppController
    Dim str As String, iCount As Integer
    Dim arr, arrRe As ArrayList
    Dim lenghSub = 200
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewList(pid As String, businessID As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim dem As Integer = 0
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = objCTL.CMS_ReviewM_List_Search(pid, "", 0, 1, 1, 20, businessID)

            For Each cr As CMS_ReviewMInfo In arr
                str += "<div Class='review card'>"
                str += " <header Class='card-header'>"
                str += "<p Class='card-header-title'>"
                str += cr.Hoten & "&nbsp;"
                For i = 1 To cr.IsStar
                    str += "<i class='fa fa-star has-text-warning'>"
                    str += "</i>"
                Next

                str += "<time Class='review__time'>" & flReg.RelativeTime(cr.CreatedDate)
                str += "</time>"
                str += "</p>"
                str += "</header>"
                str += "<div Class='card-content'>"
                str += " <div Class='content text-5001' id='" & "ct" & cr.ReviewM_ID & "'>"
                If cr.Contents.Length > lenghSub Then
                    str += flReg.Trimstr(cr.Contents, lenghSub, False).Replace(vbLf, "<br/>").TrimEnd
                    str += "<span class=""dots"">...</span>"
                    str += "<span class=""more"">&nbsp;" & cr.Contents.Substring(lenghSub - 1).Replace(vbLf, "<br/>") & "</span>"
                    str += "<a title='Click để xem thêm hoặc thu gọn' class='btnReadMore' onclick='readMoreLes(""" & "ct" & cr.ReviewM_ID & """)'>Xem thêm</a>"
                Else
                    str += cr.Contents.Replace(vbLf, "<br/>")
                End If

                str += "</div>"
                str += "</div>"
                str += "<footer Class='card-footer'>"
                str += " <a onclick='ReplyReview(""" & cr.ReviewM_ID & """,1);' Class='link-comment card-footer-item clickable'> "
                str += "<span Class='icon-reply icon has-text-info'>"
                str += " <i Class='fa fa-comments' style='margin-right: 10px'>"
                str += "</i>"
                str += "</span>"
                str += "Trả lời"
                str += "</a>"
                str += "<span Class='link-comment card-footer-item clickable'>"
                str += " <a onclick='ReplyReview(""" & cr.ReviewM_ID & """,1);' > "
                str += "<span Class='icon-like icon has-text-success'>"
                str += " <i Class='fa fa-thumbs-up'>"
                str += "</i>" & "&nbsp;" & cr.IsLike
                str += "</span>"
                str += "</a>"
                str += "</span>"
                str += " <span Class='link-comment card-footer-item clickable'>"
                str += " <a onclick='ReplyReview(""" & cr.ReviewM_ID & """,2);' > "
                str += " <span Class='icon-dislike icon has-text-danger'>"
                str += " <i Class='fa fa-thumbs-down'>"
                str += "</i>" & "&nbsp;" & cr.IsUnLike
                str += "</span>"
                str += "</a>"
                str += "</span>"
                str += " <span Class='link-comment card-footer-item clickable'>"
                str += " <a onclick='ReplyReview(""" & cr.ReviewM_ID & """,3);' > "
                str += "<span Class='icon-ban icon'>"
                str += "<i Class='fa fa-ban has-text-danger1'>"
                str += "</i>" & "&nbsp;" & cr.IsRemove
                str += "</span>"
                str += "</a>"
                str += "</span>"
                str += "</footer>"
                'reply review
                Dim pgzM = 3
                arrRe = objCTL.CMS_ReviewD_List_By_CMS_ReviewM(pid, -1, 1, pgzM, cr.ReviewM_ID)
                If arrRe.Count > 0 Then
                    str += " <div Class='review-comments' id=""" & cr.ReviewM_ID & """ > "
                    For Each cr2 As CMS_ReviewDInfo In arrRe
                        str += " <div id='" & cr2.ReviewD_ID & "' Class='comment'>"
                        str += " <p Class='comment__title'>"
                        str += "<span Class='has-text-weight-bold'>" & cr2.Hoten & "</span> "
                        If cr2.Contents.Length > lenghSub Then
                            str += flReg.Trimstr(cr2.Contents, lenghSub, False).Replace(vbLf, "<br/>").TrimEnd()
                            str += "<span class=""dots"">...</span>"
                            str += "<span class=""more"">&nbsp;" & cr2.Contents.Substring(lenghSub - 1).Replace(vbLf, "<br/>") & "</span>"
                            str += "<a title='Click để xem thêm hoặc thu gọn' class='btnReadMore' onclick='readMoreLes(""" & cr2.ReviewD_ID & """)'>Xem thêm</a>"
                        Else
                            str += cr2.Contents.Replace(vbLf, "<br/>")
                        End If
                        CheckFlag(cr2.IsFlag)
                        str += "<span style='font-size:12px'>" & flReg.RelativeTime(cr2.CreatedDate) & "</span>"
                        str += "</p>"
                        str += "</div>"
                    Next

                    For Each cr2 As CMS_ReviewDInfo In arrRe
                        str += flReg.NextPageVs(cr2.Total, 3, 1, pgzM, "fnext2('" + cr.ReviewM_ID + "',")
                        Exit For
                    Next
                    str += "</div>"
                End If
                str += "</div>"
            Next
            If arr.Count > 0 Then
                str += "<div id='expageReview'>"
                For Each Cr As CMS_ReviewMInfo In arr
                    str += flReg.NextPageVs(Cr.Total, 10, 1, 5, "fnext(")
                    Exit For
                Next
                str += "</div>"
            Else
                str = "<span class='label label-info'>Doanh nghiệp này chưa có đánh giá nào!</span>"
            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewListAdmin(pid As String, key As String, isStatus As Integer, type As Integer) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            arr = objCTL.CMS_ReviewM_List_Admin(pid, key.Trim, isStatus, 1, 20, type)

            For Each cr As CMS_ReviewMInfo In arr
                str += "<div Class='review card'>"
                str += " <header Class='card-header-recent'>"
                str += "<p Class='card-header-title'>"
                str += cr.Hoten & "&nbsp;"
                str += "<span class='text-gray'> đã review </span>"
                str += "<a title='" & flCheck.Business_Name(pid, cr.Business_ID) & "' > " & flCheck.Business_Name(pid, cr.Business_ID) & " (" & objCTL.CMS_ReviewM_Count_ByBusiness(pid, cr.Business_ID) & ")"
                str += "</a>"
                str += " - "
                If cr.IsStatus = 0 Then str += "<a title='Click để duyệt review này' onclick='activeReview(" & pid & ",""" & cr.ReviewM_ID & """,1)' class='label label-success'><i class='fa fa-check'></i> Duyệt</a>&nbsp;&nbsp;"

                If cr.IsStatus = 1 Then str += "<a title='Click để gỡ duyệt review này'  onclick='activeReview(" & pid & ",""" & cr.ReviewM_ID & """,0)' class='label label-warning'><i class='fa fa-times-circle-o'></i> Bỏ duyệt</a>&nbsp;&nbsp;"

                str += "<a title='Click để xóa review này'  onclick='deleteReview(" & pid & ",""" & cr.ReviewM_ID & """)' class='label label-danger'>Xóa bỏ</a>"
                str += "</p>"
                str += " <p class='card-header-time'>"
                For i = 1 To cr.IsStar
                    str += "<i class='fa fa-star has-text-warning'>"
                    str += "</i>"
                Next

                str += "<time Class='review__time'>" & flReg.RelativeTime(cr.CreatedDate)
                str += "</time>"
                str += "</p>"
                str += "</header>"
                str += "<div Class='card-content'>"
                str += " <div Class='content text-5001' id='" & "ct" & cr.ReviewM_ID & "'>"
                If cr.Contents.Length > lenghSub Then
                    str += flReg.Trimstr(cr.Contents, lenghSub, False).Replace(vbLf, "<br/>").TrimEnd
                    str += "<span class=""dots"">...</span>"
                    str += "<span class=""more"">&nbsp;" & cr.Contents.Substring(lenghSub - 1).Replace(vbLf, "<br/>") & "</span>"
                    str += "<a title='Click để xem thêm hoặc thu gọn' class='btnReadMore' onclick='readMoreLes(""" & "ct" & cr.ReviewM_ID & """)'>Xem thêm</a>"
                Else
                    str += cr.Contents.Replace(vbLf, "<br/>")
                End If

                str += "</div>"
                str += "</div>"

                'reply review
                Dim pgzM = 3
                arrRe = objCTL.CMS_ReviewD_List_By_CMS_ReviewM(pid, isStatus, 1, pgzM, cr.ReviewM_ID)
                If arrRe.Count > 0 Then
                    str += " <div Class='review-comments' id=""" & cr.ReviewM_ID & """ > "
                    For Each cr2 As CMS_ReviewDInfo In arrRe
                        str += " <div id='" & cr2.ReviewD_ID & "' Class='comment'>"
                        str += " <p Class='comment__title'>"
                        str += "<span Class='has-text-weight-bold'>" & cr2.Hoten & "</span> "
                        If cr2.Contents.Length > lenghSub Then
                            str += flReg.Trimstr(cr2.Contents, lenghSub, False).Replace(vbLf, "<br/>").TrimEnd()
                            str += "<span class=""dots"">...</span>"
                            str += "<span class=""more"">&nbsp;" & cr2.Contents.Substring(lenghSub - 1).Replace(vbLf, "<br/>") & "</span>"
                            str += "<a title='Click để xem thêm hoặc thu gọn' class='btnReadMore' onclick='readMoreLes(""" & cr2.ReviewD_ID & """)'>Xem thêm</a>"
                        Else
                            str += cr2.Contents.Replace(vbLf, "<br/>")
                        End If
                        CheckFlag(cr2.IsFlag)
                        str += "<span style='font-size:12px'>" & flReg.RelativeTime(cr2.CreatedDate) & "</span>"
                        If cr2.IsStatus = 0 Then str += " - <a title='Click để duyệt comment này' onclick='activeComment(" & pid & ",""" & cr.ReviewM_ID & """,""" & cr2.ReviewD_ID & """,""" & cr2.IsFlag & """,1)' class='label'><i class='fa fa-check'></i> Duyệt</a>&nbsp;&nbsp;"
                        If cr2.IsStatus = 1 Then str += "<a title='Click để gỡ duyệt comment này'  onclick='activeComment(" & pid & ",""" & cr.ReviewM_ID & """,""" & cr2.ReviewD_ID & """,""" & cr2.IsFlag & """,0)' class='label txt-danger '><i class='fa fa-times-circle-o'></i> Bỏ duyệt</a>&nbsp;&nbsp;"
                        str += "<a title='Click để xóa comment này'  onclick='deleteComment(" & pid & ",""" & cr2.ReviewD_ID & """)' class='label '><i class='fa fa-trash'></i> Xóa bỏ</a>"
                        str += "</p>"
                        str += "</div>"
                    Next

                    For Each cr2 As CMS_ReviewDInfo In arrRe
                        str += flReg.NextPageVs(cr2.Total, 3, 1, pgzM, "fnext2('" + cr.ReviewM_ID + "',")
                        Exit For
                    Next
                    str += "</div>"
                End If
                str += "</div>"
            Next
            If arr.Count > 0 Then
                str += "<div id='expageReview'>"
                For Each Cr As CMS_ReviewMInfo In arr
                    str += flReg.NextPageVs(Cr.Total, 10, 1, 5, "fnext(")
                    Exit For
                Next
                str += "</div>"
            Else
                str = "<span class='label label-info'>Không có dữ liệu</span>"
            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewDash(pid As String, businessID As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim dem As Integer = 0
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            str = ""
            Dim objM As CMS_ReviewMInfo = objCTL.CMS_Review_DashBoard(pid, businessID, 1)
            If Not IsNothing(objM) Then
                With objM
                    str += "<div class='col-md-3 item-info'>Tổng số Review: " & objM.CountReview & "</div>"
                    str += "<div class='col-md-3 item-like'>Lượt thích: " & objM.CountLike & "</div>"
                    str += "<div class='col-md-3 item-unlike'>Lượt không thích: " & objM.CountDisLike & "</div>"
                    str += "<div class='col-md-3 item-remove'>Lượt báo cáo xấu: " & objM.CountRemove & "</div>"
                End With
            Else
                str = ""
            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewDashAdmin(pid As String, status As Integer) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim dem As Integer = 0
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            str = ""
            Dim objM As CMS_ReviewMInfo = objCTL.CMS_Review_DashBoard(pid, "", status)
            If Not IsNothing(objM) Then
                With objM
                    str += "<div class='col-md-3 item-info'>Số Review: " & objM.CountReview & "</div>"
                    str += "<div class='col-md-3 item-like'>Comment thích: " & objM.CountLike & "</div>"
                    str += "<div class='col-md-3 item-unlike'>Comment không thích: " & objM.CountDisLike & "</div>"
                    str += "<div class='col-md-3 item-remove'>Comment báo xấu: " & objM.CountRemove & "</div>"
                End With
            Else
                str = ""
            End If
            data.Data = str
        Catch ex As Exception
            data.Data = ex.Message
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    Private Sub CheckFlag(isFlag As Integer)
        Select Case isFlag
            Case 1
                str += "<span class='icon-like icon has-text-success'>"
                str += " <i class='fa fa-thumbs-up '>"
                str += "</i>"
                str += "</span>"
            Case 2
                str += "<span class='icon-like icon has-text-danger'>"
                str += " <i class='fa fa-thumbs-down'>"
                str += "</i>"
                str += "</span>"
            Case 3
                str += "<span class='icon-like icon has-text-danger'>"
                str += " <i class='fa fa-ban'>"
                str += "</i>"
                str += "</span>"
            Case Else

                str += "<span class='icon has-text-info'>"
                str += " <i class='fa fa-comments'>"
                str += "</i>"
                str += "</span>"

        End Select
    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewM_Add(pid As Integer, businessID As String, hoten As String, chucvu As String, contents As String, istar As Integer, isreply As Integer, islike As Integer, isunlike As Integer, isremove As Integer, username As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            Dim obj As New CMS_ReviewMInfo
            obj.ReviewM_ID = flReg.GenKey()
            obj.Business_ID = businessID
            obj.Hoten = hoten
            obj.ChucVu = chucvu 'change to email
            obj.Contents = flReg.DeCode64(contents)
            obj.IsStar = istar
            obj.IsReply = isreply
            obj.IsLike = islike
            obj.IsUnLike = isunlike
            obj.IsRemove = isremove
            obj.IsStatus = 0
            obj.CreatedUser = username
            obj.CreatedDate = Now

            objCTL.CMS_ReviewM_Add(pid, obj)
            data.Status = ServiceStatus.SUCCESS
            data.Message = "Success"
        Catch ex As Exception
            data.Data = flReg.BugLog(pid, ex.Message, "app")
            data.Message = "Error"
            data.Status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewM_Update(pid As Integer, reviewID As String, isStatus As Integer, usName As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            objCTL.CMS_ReviewM_Update(pid, reviewID, isStatus, Now, usName)

            data.Status = ServiceStatus.SUCCESS
            data.Message = "Success"
        Catch ex As Exception
            data.Data = flReg.BugLog(pid, ex.Message, "app")
            data.Message = "Error"
            data.Status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewM_Delete(pid As Integer, reviewID As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            objCTL.CMS_ReviewM_Delete(pid, reviewID)
            data.Status = ServiceStatus.SUCCESS
            data.Message = "Success"
        Catch ex As Exception
            data.Data = flReg.BugLog(pid, ex.Message, "app")
            data.Message = "Error"
            data.Status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewD_Update(pid As Integer, reviewID As String, commentID As String, isFlag As Integer, isStatus As Integer, usName As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            objCTL.CMS_ReviewD_Update(pid, commentID, isStatus, Now, usName)
            Call objCTL.CMS_ReviewM_Update_Like(pid, reviewID, isFlag, isStatus)
            data.Status = ServiceStatus.SUCCESS
            data.Message = "Success"
        Catch ex As Exception
            data.Data = flReg.BugLog(pid, ex.Message, "app")
            data.Message = "Error"
            data.Status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewD_Delete(pid As Integer, commentID As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            objCTL.CMS_ReviewD_Delete(pid, commentID)
            data.Status = ServiceStatus.SUCCESS
            data.Message = "Success"
        Catch ex As Exception
            data.Data = flReg.BugLog(pid, ex.Message, "app")
            data.Message = "Error"
            data.Status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function ReviewD_Add(pid As Integer, reviewM As String, hoten As String, contents As String, isflag As Integer, username As String) As String
        Call flReg.SetContentResponse()
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        Try
            Dim obj As New CMS_ReviewDInfo
            obj.ReviewD_ID = flReg.GenKey()
            obj.ReviewM_ID = reviewM
            obj.Hoten = hoten
            obj.Contents = flReg.DeCode64(contents)
            obj.IsFlag = isflag
            obj.IsStatus = 0
            obj.CreatedUser = username
            obj.CreatedDate = DateTime.Now
            objCTL.CMS_ReviewD_Add(pid, obj)
            data.Status = ServiceStatus.SUCCESS
            data.Message = "Success"
        Catch ex As Exception
            data.Data = flReg.BugLog(pid, ex.Message, "app")
            data.Message = "Error"
            data.Status = ServiceStatus.FAILED
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/html"
        Context.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub
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