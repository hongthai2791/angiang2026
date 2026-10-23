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
    Private result As New Response With {.status = ServiceStatus.NODATA, .data = Nothing, .message = String.Empty}
    Dim arr, arrRe, arr2 As New ArrayList
    Dim litRow, total As String
    Dim objContrller As New AppController
    Dim _pid, _currPage, _type, _tp, _sort As Integer
    Dim _key, _usName As String
    Dim str As String = ""
    Dim objCTL As New AppController

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function reviewList(page As String, pid As String, type As String, tp As String, key As String, sort As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            _currPage = flReg.WriteNumber(page)
            _type = flReg.WriteNumber(type)
            _sort = flReg.WriteNumber(sort)
            _pid = flReg.WriteNumber(pid)
            _usName = UserInfo.Username
            _key = key
            total = 0

            If type = 1 Then
                _tp = flReg.WriteNumber(tp)
                litRow = reviewListBE() 'pagination bussiness review
            ElseIf type = 2 Then
                litRow = reviewMList() 'pagination reviewM
            ElseIf type = 3 Then
                litRow = reviewDList() 'pagination reviewD
            End If
            data.data = litRow
            data.message = total
        Catch ex As Exception
            data.data = ex.Message
            data.message = 0
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Private Sub CheckFlag(isFlag As Integer)
        Select Case isFlag
            Case 1
                str += "<span Class='icon-like icon has-text-success'><i Class='fa fa-thumbs-up'></i></span>"
            Case 2
                str += "<span Class='icon-like icon has-text-danger'><i Class='fa fa-thumbs-down'></i></span>"
            Case 3
                str += "<span Class='icon-like icon has-text-danger'><i Class='fa fa-ban'></i></span>"
            Case Else
                str += "<span Class='icon has-text-info'><i Class='fa fa-comments'></i></span>"

        End Select
    End Sub
    Private Function reviewMList() As String
        Try
            str = ""
            If str = "" Then
                arr = objCTL.CMS_ReviewM_List_Search(_pid, "", 0, 1, _currPage, 5, _key)
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
                    str += " <div Class='content text-5001'>"
                    str += cr.Contents.Replace(vbLf, "<br/>")
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
                    arrRe = objCTL.CMS_ReviewD_List_By_CMS_ReviewM(_pid, 1, 1, pgzM, cr.ReviewM_ID)
                    If arrRe.Count > 0 Then
                        str += " <div Class='review-comments'>"
                        For Each cr2 As CMS_ReviewDInfo In arrRe
                            str += "<div Class='comment'>"
                            str += " <p Class='comment__title'>"
                            str += "<span Class='has-text-weight-bold'>" & cr2.Hoten & "</span> "
                            str += cr2.Contents.Replace(vbLf, "<br/>") & " -"
                            CheckFlag(cr2.IsFlag)
                            str += "<span style='font-size:12px'>" & flReg.RelativeTime(cr2.CreatedDate) & "</span>"
                            str += "</p>"
                            str += "</div>"
                        Next
                        str += "</div>"
                    End If
                    str += "</div>"
                Next
                str += "<div id='expageReview'>"
                For Each Cr As CMS_ReviewMInfo In arr
                    total = Cr.Total
                    str += "<div class=""clear""></div>"
                    str += flReg.NextPageVs(Cr.Total, 10, _currPage, 5, "fnext(")
                    Exit For
                Next
                str += "</div>"
            End If
            Return str
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Private Function reviewDList() As String
        Try
            str = ""
            If str = "" Then
                arrRe = objCTL.CMS_ReviewD_List_By_CMS_ReviewM(_pid, 1, _currPage, 3, _key)
                If arrRe.Count > 0 Then
                    For Each cr2 As CMS_ReviewDInfo In arrRe
                        str += " <div id='" & cr2.ReviewD_ID & "' Class='comment'>"
                        str += " <p Class='comment__title'>"
                        str += "<span Class='has-text-weight-bold'>" & cr2.Hoten & "</span> "
                        If cr2.Contents.Length > 200 Then
                            str += flReg.Trimstr(cr2.Contents, 200, False).Replace(vbLf, "<br/>").TrimEnd()
                            str += "<span class=""dots"">...</span>"
                            str += "<span class=""more"">&nbsp;" & cr2.Contents.Substring(200).Replace(vbLf, "<br/>") & "</span>"
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
                        total = cr2.Total
                        str += flReg.NextPageVs(cr2.Total, 3, _currPage, 3, "fnext2('" & _key & "',")
                        Exit For
                    Next
                End If
            End If
            Return str
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Private Function reviewList() As String
        Try
            str = "" 'flCache.GetCache("CMS_Review_List_Pages" & currPage & "_" & tinhTP & "_" & nganhNghe) & ""
            If str = "" Then
                Dim star1, star2, star3, star4, star5 As Integer
                Dim svote As Double
                arr = objCTL.CMS_Business_List_ReView(_pid, _pid, _key, 0, _tp, 0, _currPage, 10, 1, 1)
                For Each cr As CMS_BusinessInfo In arr
                    str += " <div Class='col-md-12 company-info'>"
                    str += " <figure Class='company-info__logo image is-64x64'>"
                    str += "<img src = '" & flReg.ImgSRC(cr.Logo, 100, 100) & "' alt='logo bigtech' />"
                    str += "</figure>"
                    str += "<div Class='company-info__detail'>"
                    str += " <div Class='is-size-5 has-text-weight-semibold company-info__name'>"
                    str += " <a href=""/review-doanh-nghiep/" & flCheck.LinkUrl(cr.Business_Vn, cr.ID, "DN") & """ title=""" & flReg.ImgAlt(cr.Business_Vn) & """ class=""capitalize""><strong>" & cr.Business_Vn & "</strong></a>"
                    str += "</a>"

                    str += "<span class='company-info__rating '>"
                    'caculator vote
                    arr2 = objCTL.CMS_ReviewM_Get_By_CMS_Business(_pid, cr.Business_ID, 1)
                    star1 = 0 : star2 = 0 : star3 = 0 : star4 = 0 : star5 = 0 : svote = 0
                    If arr2.Count > 0 Then
                        For Each cr2 As CMS_ReviewMInfo In arr2
                            Select Case cr2.IsStar
                                Case 1
                                    star1 += 1
                                Case 2
                                    star2 += 1
                                Case 3
                                    star3 += 1
                                Case 4
                                    star4 += 1
                                Case 5
                                    star5 += 1
                            End Select
                        Next
                        svote = (5 * star5 + 4 * star4 + 3 * star3 + 2 * star2 + 1 * star1) / (star1 + star2 + star3 + star4 + star5)
                        svote = Math.Round(svote, 1)
                        For i = 1 To 5
                            If i < svote Then
                                str += "<i Class='fa fa-star has-text-warning'></i>"
                            Else
                                str += "<i Class='fa fa-star-o has-text-warning'></i>"
                            End If
                        Next
                    Else
                        For i = 1 To 5
                            str += "<i Class='fa fa-star-o has-text-warning'></i>"
                        Next
                    End If

                    str += "</span>"
                    str += "<span Class='company-info__rating-count'>(<i class='fa fa-comment'></i> " & cr.WBID & ")"
                    str += "</span>"
                    str += "</span>"
                    str += "</div>"
                    If String.IsNullOrEmpty(cr.Website) = False Or String.IsNullOrEmpty(cr.Scale) = False Then

                        str += "<div Class='company-info__other'>"
                        str += "<span style = 'margin-right: 0.4rem' Class='td'>"
                        If String.IsNullOrEmpty(cr.Website) = False Then
                            str += "<span Class='icon'>"
                            str += " <i Class='fa fa-internet-explorer td'>"
                            str += "</i>"
                            str += "</span>"
                            str += cr.Website
                            str += "</span>"

                        End If
                        If String.IsNullOrEmpty(cr.Scale) = False Then
                            str += " <span Class='td'>"
                            str += " <span Class='icon'>"
                            str += "<i class='fa fa-users td'>"
                            str += "</i>"
                            str += "</span>"
                            str += cr.Scale
                            str += "</span>"
                        End If
                        str += "</div>"
                    End If
                    str += "<div Class='company-info__location '>"
                    str += "<span Class='td'>"
                    str += "<span Class='icon'>"
                    str += " <i Class='fa fa-building'>"
                    str += "</i>"
                    str += "</span>"
                    str += cr.Address
                    str += "</span>"
                    str += "</div>"
                    str += "</div>"

                    str += "<div class='row' id='reviewContent'>"
                    str += "</div>"
                    str += "</div>"
                Next
                For Each Cr As CMS_BusinessInfo In arr
                    total = Cr.Total
                    str += "<div class=""clear""></div>"
                    str += flReg.NextPageVs(Cr.Total, 10, _currPage, 5, "fnext(")
                    Exit For
                Next
                flCache.SetCache("CMS_Review_List_Pages" & _currPage, str, SecondCache.S8)
            End If
            Return str
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Private Function reviewListBE() As String
        Try
            Dim strUrl = "/app-users/edit/review-business/"
            str = "" 'flCache.GetCache("CMS_Review_List_Pages" & currPage & "_" & tinhTP & "_" & nganhNghe) & ""
            If str = "" Then
                Dim star1, star2, star3, star4, star5 As Integer
                Dim svote As Double
                arr = objCTL.CMS_Business_ListReView_ForUser(_pid, _pid, _key, _sort, _tp, 0, _currPage, 10, _usName)
                For Each cr As CMS_BusinessInfo In arr
                    str += " <div Class='col-md-12 company-info'>"
                    str += " <figure Class='company-info__logo image is-64x64'>"
                    str += " <a href=" & strUrl & "itemid/" & cr.Business_ID & " title=""" & flReg.ImgAlt(cr.Business_Vn) & """ class=""capitalize"">"
                    str += "<img src = '" & flReg.ImgSRC(cr.Logo, 100, 100) & "' alt='logo bigtech' />"
                    str += "</a>"
                    str += "</figure>"
                    str += "<div Class='company-info__detail'>"
                    str += " <div Class='is-size-5 has-text-weight-semibold company-info__name'>"
                    str += " <a href=" & strUrl & "itemid/" & cr.Business_ID & " title=""" & flReg.ImgAlt(cr.Business_Vn) & """ class=""capitalize""><strong>" & cr.Business_Vn & "</strong></a>"
                    str += "</a>"
                    str += "<span class='company-info__rating '>"
                    'caculator vote
                    arr2 = objCTL.CMS_ReviewM_Get_By_CMS_Business(_pid, cr.Business_ID, -1)
                    star1 = 0 : star2 = 0 : star3 = 0 : star4 = 0 : star5 = 0 : svote = 0
                    If arr2.Count > 0 Then
                        For Each cr2 As CMS_ReviewMInfo In arr2
                            Select Case cr2.IsStar
                                Case 1
                                    star1 += 1
                                Case 2
                                    star2 += 1
                                Case 3
                                    star3 += 1
                                Case 4
                                    star4 += 1
                                Case 5
                                    star5 += 1
                            End Select
                        Next
                        svote = (5 * star5 + 4 * star4 + 3 * star3 + 2 * star2 + 1 * star1) / (star1 + star2 + star3 + star4 + star5)
                        svote = Math.Round(svote, 1)
                        For i = 1 To 5
                            If i < svote Then
                                str += "<i Class='fa fa-star has-text-warning'></i>"
                            Else
                                str += "<i Class='fa fa-star-o has-text-warning'></i>"
                            End If
                        Next
                    Else
                        For i = 1 To 5
                            str += "<i Class='fa fa-star-o has-text-warning'></i>"
                        Next
                    End If
                    str += "</span>"
                    str += "<span Class='company-info__rating-count'>(<i class='fa fa-comment'></i> " & cr.WBID & ")"
                    str += "</span>"
                    str += "</span>"
                    str += "</div>"
                    If String.IsNullOrEmpty(cr.Website) = False Or String.IsNullOrEmpty(cr.Scale) = False Then
                        str += "<div Class='company-info__other'>"
                        str += "<span style = 'margin-right: 0.4rem' Class='td'>"
                        If String.IsNullOrEmpty(cr.Website) = False Then
                            str += "<span Class='icon'>"
                            str += " <i Class='fa fa-internet-explorer td'>"
                            str += "</i>"
                            str += "</span>"
                            str += cr.Website
                            str += "</span>"

                        End If
                        If String.IsNullOrEmpty(cr.Scale) = False Then
                            str += " <span Class='td'>"
                            str += " <span Class='icon'>"
                            str += "<i class='fa fa-users td'>"
                            str += "</i>"
                            str += "</span>"
                            str += cr.Scale
                            str += "</span>"
                        End If
                        str += "</div>"
                    End If
                    str += "<div Class='company-info__location '>"
                    str += "<span Class='td'>"
                    str += "<span Class='icon'>"
                    str += " <i Class='fa fa-building'>"
                    str += "</i>"
                    str += "</span>"
                    str += cr.Address
                    str += "</span>"
                    str += "</div>"
                    str += "</div>"
                    str += "</div>"
                Next
                For Each Cr As CMS_BusinessInfo In arr
                    total = Cr.Total
                    str += flReg.NextPageVs(Cr.Total, 10, _currPage, 5, "fnext(")
                    Exit For
                Next
                flCache.SetCache("CMS_Review_List_Pages_BE_" & _currPage, str, SecondCache.S8)
            End If
            Return str
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
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