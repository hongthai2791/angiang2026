<%@ WebHandler Language="VB" Class="newslistpage" %>

Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Public Class newslistpage : Implements IHttpHandler

    Dim arrContent As New ArrayList
    Dim ltrCateContent As String
    Dim CategoryId, strUrl, NewsID As String
    Dim objController As New CmsController
    Dim PortalID, currPage As Integer

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Try
            currPage = context.Request.Item("p")
            CategoryId = context.Request.Item("cid")
            PortalID = flReg.WriteNumber(context.Request.Item("pid"))
            NewsID = flReg.WriteNumber(context.Request.Item("nid"))

            If IsNothing(flCache.GetCache("CMS_News_List_Home_" & PortalID & "_" & NewsID & "_" & CategoryId & "_" & currPage)) Then
                arrContent = objController.CMS_News_List_Home(PortalID, NewsID, CategoryId, PortalID, flConnect.IsLang, currPage, 9, "", False)
                flCache.SetCache("CMS_News_List_Home_" & PortalID & "_" & NewsID & "_" & CategoryId & "_" & currPage, arrContent, SecondCache.S9)
            Else
                arrContent = CType(flCache.GetCache("CMS_News_List_Home_" & Me.PortalID & "_" & NewsID & "_" & CategoryId & "_" & currPage), ArrayList)
            End If
            For Each cn As CMS_NewsInfo In arrContent
                strUrl = Ultis.FormatLink(Me.PortalID, cn.CategoryId, cn.NewId, cn.ToUrl)
                ltrCateContent += "<div class='w-list'>"
                ltrCateContent += "<div class='row row5'><div class='col-md-4 col-xs-12 col5'><div class='item-image-fixed'>"
                ltrCateContent += "<a href=""" & strUrl & """ title='" & flReg.ImgAlt(cn.Title) & "' class='item-title'>"
                ltrCateContent += "<img alt='" & flReg.ImgAlt(cn.Title) & "' src='" & flReg.ImgSRC(cn.ImagePath, 222, 130, True) & "' class='img-auto' />"
                ltrCateContent += "</a></div></div>"

                ltrCateContent += "<div class='col-md-8 col-xs-12  col5'>"
                ltrCateContent += "<a href='" & strUrl & "'" & " title='" & flReg.ImgAlt(cn.Title) & "' class='item-title'>" & cn.Title & "</a>"
                ltrCateContent += "<div class='item-subinfo'><i class='fa fa-calendar-o'></i><span class='w-number'>" & flReg.ReadDate(cn.PublishedDate) & "</span></div>"
                ltrCateContent += "<div class='sitem-summary'>" & cn.Summary & "</div>"
                ltrCateContent += "</div></div></div>"
            Next
            For Each Ci As CMS_NewsInfo In arrContent
                ltrCateContent += "<div class=""clr""></div>"
                If currPage > 1 Then
                    ltrCateContent += flReg.NextPageJs(Ci.Total, 9, currPage, 4, "fnext(")
                Else
                    ltrCateContent += flReg.NextPageJs(Ci.Total, 9, currPage, 5, "fnext(")
                End If
                Exit For
            Next

            context.Response.Write(ltrCateContent)
        Catch ex As Exception
            context.Response.Write(0)
        End Try

    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class