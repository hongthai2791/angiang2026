<%@ WebHandler Language="VB" Class="searchpage" %>

Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Public Class searchpage : Implements IHttpHandler

    Dim arrTemp As ArrayList
    Dim litSearch, sSearch, sfromdate, stodate As String
    Dim CategoryId, type, adVan As String
    Dim ObjControler As New CmsController
    Dim TotalRecord, iTotalPage, curpage As Integer
    Dim PageSize As Integer = 10
    Dim UrlAlias As String = flReg.UrlAlias
    Private Sub Searchs()
        Select Case type
            Case "video"
                Call SearchVideo()
            Case "audio"
                Call SearchAudio()
            Case "photo"
                Call SearchPhoto()
            Case "new"
                Call SearchNews()
            Case Else
                Call SearchAll()
        End Select
    End Sub

    Private Sub SearchNews()
        arrTemp = ObjControler.CMS_News_Search_Home(GetPortalSettings.PortalId, GetPortalSettings.PortalId, CType(sfromdate, Date),
                                        CType(stodate, Date), CategoryId, curpage, PageSize, False, Ultis.FullTextSearch(sSearch.Trim), Ultis.FullTextSearch(sSearch.Trim, False), adVan)

        For Each Cr As CMS_NewsInfo In arrTemp
            litSearch += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
            If Cr.ImagePath <> "" Then
                litSearch += "<div class=""divimg imgautodiv img-xs"">"
                litSearch += "<a title=""" & flReg.ImgAlt(Cr.Title) & """ class=""item-title"" href='" & Ultis.FormatLink(PortalSettings.Current.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & "'>"
                litSearch += "<img alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 170, 0, True) & """ />"
                litSearch += "</a>"
                litSearch += "</div>"
            End If
            litSearch += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Title) & """ href='" & Ultis.FormatLink(PortalSettings.Current.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & "'>"
            litSearch += Highlight(Cr.Title, "<font class='highlight'>", "</font>")
            litSearch += "</a><br /><span class=""item-subinfo"">"
            litSearch += flReg.ReadDate(Cr.PublishedDate)
            litSearch += "</span><br /><span class=""sitem-summary  hidden-xs"">"
            litSearch += Highlight(Cr.Summary, "<font class='highlight'>", "</font>")
            litSearch += "</span><div class=""clr""></div>"
            litSearch += "<div class=""item-line""></div>"
            litSearch += "</div></div>"
        Next
        For Each Ci As CMS_NewsInfo In arrTemp
            litSearch += "<div class=""clr""></div>"
            litSearch += "<div class=""col-md-12 col-xs-12"">"
            If curpage > 1 Then
                litSearch += flReg.NextPageJs(Ci.Total, 10, curpage, 4, "fnext(")
            Else
                litSearch += flReg.NextPageJs(Ci.Total, 10, curpage, 5, "fnext(")
            End If
            litSearch += "</div>"
            Exit For
        Next
    End Sub

    Private Sub SearchVideo()
        arrTemp = ObjControler.CMS_Media_Search_Home(GetPortalSettings.PortalId, GetPortalSettings.PortalId, CType(sfromdate, Date),
                                                                    CType(stodate, Date), Ultis.endCodeSearch(sSearch), CategoryId, curpage, PageSize, "", 0, False, 0, flReg.NameUrl(sSearch))
        For Each Cr As CMS_MediaInfo In arrTemp
            litSearch += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
            If Cr.Avatar <> "" Then
                litSearch += "<div class=""divimg imgautodiv img-xs"">"
                litSearch += "<a title=""" & flReg.ImgAlt(Cr.Name) & """ class=""item-title"" href=""" & UrlAlias & "/video/" & Cr.ToUrl & "-" & Cr.Id & """ >"
                litSearch += "<img title=""" & flReg.ImgAlt(Cr.Name) & """ src=""" & flReg.ImgSRC(Cr.Avatar, 170, 0, True) & """ />"
                litSearch += "</a>"
                litSearch += "</div>"
            End If
            litSearch += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/video/" & Cr.ToUrl & "-" & Cr.Id & """>"
            litSearch += Highlight(Cr.Name, "<font class='highlight'>", "</font>")
            litSearch += Ultis.IsVideo(2)

            litSearch += "</a>"
            litSearch += "<br /><span class=""item-subinfo"">"
            litSearch += flReg.ReadDate(Cr.PublishedDate)
            litSearch += "</span>"
            litSearch += "<br /><span class=""sitem-summary  hidden-xs"">"
            litSearch += Cr.Summary
            litSearch += "</span>"
            litSearch += "<div class=""clr""></div>"
            litSearch += "<div class=""item-line""></div>"
            litSearch += "</div></div>"
        Next
        For Each Ci As CMS_MediaInfo In arrTemp
            litSearch += "<div class=""clr""></div>"
            litSearch += "<div class=""col-md-12 col-xs-12"">"
            If curpage > 1 Then
                litSearch += flReg.NextPageJs(Ci.Total, 10, curpage, 4, "fnext(")
            Else
                litSearch += flReg.NextPageJs(Ci.Total, 10, curpage, 5, "fnext(")
            End If
            litSearch += "</div>"
            Exit For
        Next
    End Sub

    Private Sub SearchAudio()
        arrTemp = ObjControler.CMS_Media_Search_Home(GetPortalSettings.PortalId, GetPortalSettings.PortalId, CType(sfromdate, Date),
                                                                    CType(stodate, Date), Ultis.endCodeSearch(sSearch),
                                                                    CategoryId, curpage, PageSize, "", 0, False, 0, flReg.NameUrl(sSearch))
        For Each Cr As CMS_MediaInfo In arrTemp
            litSearch += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
            If Cr.Avatar <> "" Then
                litSearch += "<div class=""divimg imgautodiv img-xs"">"
                litSearch += "<a title=""" & flReg.ImgAlt(Cr.Name) & """ class=""item-title"" href=""" & UrlAlias & "/audio/" & Cr.ToUrl & "-" & Cr.Id & """ >"
                litSearch += "<img alt=""" & flReg.ImgAlt(Cr.Name) & """ src=""" & flReg.ImgSRC(Cr.Avatar, 170, 0, True) & """ />"
                litSearch += "</a>"
                litSearch += "</div>"
            End If
            litSearch += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/audio/" & Cr.ToUrl & "-" & Cr.Id & """>"
            litSearch += Cr.Name
            litSearch += "</a>"
            litSearch += "<br /><span class=""item-subinfo"">"
            litSearch += flReg.ReadDate(Cr.PublishedDate)
            litSearch += "</span>"
            litSearch += "<br /><span class=""sitem-summary  hidden-xs"">"
            litSearch += Cr.Summary
            litSearch += "</span>"
            litSearch += "<div class=""clr""></div>"
            litSearch += "<div class=""item-line""></div>"
            litSearch += "</div></div>"
        Next
        For Each Ci As CMS_MediaInfo In arrTemp
            litSearch += "<div class=""clr""></div>"
            litSearch += "<div class=""col-md-12 col-xs-12"">"
            If curpage > 1 Then
                litSearch += flReg.NextPageJs(Ci.Total, 10, curpage, 4, "fnext(")
            Else
                litSearch += flReg.NextPageJs(Ci.Total, 10, curpage, 5, "fnext(")
            End If
            litSearch += "</div>"
            Exit For
        Next
    End Sub

    Private Sub SearchPhoto()

        arrTemp = ObjControler.CMS_News_Search_Home(GetPortalSettings.PortalId, GetPortalSettings.PortalId, flConnect.IsLang, CType(sfromdate, Date), CType(stodate, Date), CategoryId, curpage, 10, True,
                                        Ultis.FullTextSearch(sSearch, False), adVan)

        For Each Cr As CMS_NewsInfo In arrTemp
            litSearch += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
            If Cr.ImagePath <> "" Then
                litSearch += "<div class=""divimg imgautodiv img-xs"">"
                litSearch += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Title) & """ href='" & Ultis.FormatLink(GetPortalSettings.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & "'>"
                litSearch += "<img alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 170, 0, True) & """ />"
                litSearch += "</a>"
                litSearch += "</div>"
            End If
            litSearch += "<a title=""" & flReg.ImgAlt(Cr.Title) & """ class=""item-title"" href='" & Ultis.FormatLink(GetPortalSettings.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & "'>"
            litSearch += Cr.Title
            litSearch += "</a>"
            litSearch += "<br /><span class=""item-subinfo"">"
            litSearch += flReg.ReadDate(Cr.PublishedDate)
            litSearch += "</span>"
            litSearch += "<br /><span class=""sitem-summary  hidden-xs"">"
            litSearch += Cr.Summary
            litSearch += "</span>"
            litSearch += "<div class=""clr""></div>"
            litSearch += "<div class=""item-line""></div>"
            litSearch += "</div></div>"
        Next
        For Each Ci As CMS_NewsInfo In arrTemp
            litSearch += "<div class=""clr""></div>"
            litSearch += "<div class=""col-md-12 col-xs-12"">"
            If curpage > 1 Then
                litSearch += flReg.NextPageJs(Ci.Total, 10, curpage, 4, "fnext(")
            Else
                litSearch += flReg.NextPageJs(Ci.Total, 10, curpage, 5, "fnext(")
            End If
            litSearch += "</div>"
            Exit For
        Next
    End Sub

    Dim ObjDt As New DataTable
    Dim r As DataRow, total As Integer
    Private Sub CreateTable()
        ObjDt.Reset()
        ObjDt.Columns.Add("NewId", GetType(String))
        ObjDt.Columns.Add("Title", GetType(String))
        ObjDt.Columns.Add("ToUrl", GetType(String))
        ObjDt.Columns.Add("ImagePath", GetType(String))
        ObjDt.Columns.Add("PublishedDate", GetType(DateTime))
        ObjDt.Columns.Add("Summary", GetType(String))
        ObjDt.Columns.Add("Type", GetType(Integer))
        ObjDt.Columns.Add("CategoryId", GetType(Integer))
        ObjDt.Columns.Add("Total", GetType(Integer))

    End Sub
    Private Sub SearchAll()
        Call CreateTable()
        arrTemp = ObjControler.CMS_News_Search_Home(GetPortalSettings.PortalId, GetPortalSettings.PortalId, CType(sfromdate, Date),
                                        CType(stodate, Date), CategoryId, curpage, PageSize, False,
                                        Ultis.FullTextSearch(sSearch.Trim), Ultis.FullTextSearch(sSearch.Trim, False), adVan)
        For Each Cr As CMS_NewsInfo In arrTemp
            r = ObjDt.NewRow
            r.Item("NewId") = Cr.NewId
            r.Item("Title") = Cr.Title
            r.Item("ToUrl") = Cr.ToUrl
            r.Item("ImagePath") = Cr.ImagePath
            r.Item("PublishedDate") = Cr.PublishedDate
            r.Item("Summary") = Cr.Summary
            r.Item("Type") = 1
            r.Item("CategoryId") = Cr.CategoryId
            r.Item("Total") = Cr.Total
            ObjDt.Rows.Add(r)
            total = Cr.Total
        Next
        arrTemp = ObjControler.CMS_Media_Search_Home(GetPortalSettings.PortalId, GetPortalSettings.PortalId, CType(sfromdate, Date),
                                                                  CType(stodate, Date), Ultis.endCodeSearch(sSearch),
                                                                  CategoryId, curpage, PageSize, "", 0, False, 0, flReg.NameUrl(sSearch))
        For Each Cr As CMS_MediaInfo In arrTemp
            r = ObjDt.NewRow
            r.Item("NewId") = Cr.Id
            r.Item("Title") = Cr.Name
            r.Item("ToUrl") = Cr.ToUrl
            r.Item("ImagePath") = Cr.Avatar
            r.Item("PublishedDate") = Cr.PublishedDate
            r.Item("Summary") = Cr.Summary
            r.Item("Type") = 2
            r.Item("CategoryId") = Cr.CategoryId
            r.Item("Total") = Cr.Total
            ObjDt.Rows.Add(r)
            If Cr.Total > total Then total = Cr.Total
        Next

        For Each Cr As DataRow In ObjDt.Select("", "PublishedDate DESC")
            If Cr.Item("Type") = 2 Then
                litSearch += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
                If Cr.Item("ImagePath") <> "" Then
                    litSearch += "<div class=""divimg imgautodiv img-xs"">"
                    litSearch += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Item("Title")) & """ href=""" & UrlAlias & "/video/" & Cr.Item("ToUrl") & "-" & Cr.Item("NewId") & """ >"
                    litSearch += "<img alt=""" & flReg.ImgAlt(Cr.Item("Title")) & """ src=""" & flReg.ImgSRC(Cr.Item("ImagePath"), 170, 0, True) & """ />"
                    litSearch += "</a>"
                    litSearch += "</div>"
                End If
                litSearch += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Item("Title")) & """ href=""" & UrlAlias & "/video/" & Cr.Item("ToUrl") & "-" & Cr.Item("NewId") & """>"
                litSearch += Highlight(Cr.Item("Title"), "<font class='highlight'>", "</font>")
                litSearch += Ultis.IsVideo(2)
                litSearch += "</a>"
                litSearch += "<br /><span class=""item-subinfo"">"
                litSearch += flReg.ReadDate(Cr.Item("PublishedDate"))
                litSearch += "</span>"
                litSearch += "<br /><span class=""sitem-summary hidden-xs"">"
                litSearch += Cr.Item("Summary")
                litSearch += "</span>"
                litSearch += "<div class=""clr""></div>"
                litSearch += "<div class=""item-line""></div>"
                litSearch += "</div></div>"
            Else
                litSearch += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
                If Cr.Item("ImagePath") <> "" Then
                    litSearch += "<div class=""divimg imgautodiv img-xs"">"
                    litSearch += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Item("Title")) & """ href='" & Ultis.FormatLink(GetPortalSettings.PortalId, Cr.Item("CategoryId"), Cr.Item("NewId"), Cr.Item("ToUrl")) & "'>"
                    litSearch += "<img alt=""" & flReg.ImgAlt(Cr.Item("Title")) & """ src=""" & flReg.ImgSRC(Cr.Item("ImagePath"), 170, 0, True) & """ />"
                    litSearch += "</a>"
                    litSearch += "</div>"
                End If
                litSearch += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Item("Title")) & """ href='" & Ultis.FormatLink(GetPortalSettings.PortalId, Cr.Item("CategoryId"), Cr.Item("NewId"), Cr.Item("ToUrl")) & "'>"
                litSearch += Highlight(Cr.Item("Title"), "<font class='highlight'>", "</font>")
                litSearch += "</a>"
                litSearch += "<br class='hidden-xs' /><span class=""item-subinfo"">"
                litSearch += flReg.ReadDate(Cr.Item("PublishedDate"))
                litSearch += "</span>"
                litSearch += "<br /><span class=""sitem-summary hidden-xs"">"
                litSearch += Highlight(Cr.Item("Summary"), "<font class='highlight'>", "</font>")
                litSearch += "</span>"
                litSearch += "<div class=""clr""></div>"
                litSearch += "<div class=""item-line""></div>"
                litSearch += "</div></div>"
            End If
        Next

        litSearch += "<div class=""clr""></div>"
        litSearch += "<div class=""col-md-12 col-xs-12"">"
        If curpage > 1 Then
            litSearch += flReg.NextPageJs(total, 10, curpage, 4, "fnext(")
        Else
            litSearch += flReg.NextPageJs(total, 10, curpage, 5, "fnext(")
        End If
        litSearch += "</div>"
    End Sub
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Try
            curpage = context.Request.Item("p")
            sSearch = context.Request.Item("q")
            CategoryId = context.Request.Item("cid")
            adVan = context.Request.Item("ad")
            sfromdate = context.Request.Item("f").Replace("-", "/")
            stodate = context.Request.Item("t").Replace("-", "/")
            type = context.Request.Item("type")
            Call Searchs()

            context.Response.Write(litSearch)
        Catch ex As Exception
            context.Response.Write(0)
        End Try

    End Sub

    Function Highlight(ByVal InputTxt As String, ByVal StartTag As String, ByVal EndTag As String) As String
        If sSearch.Trim = "" Then Return InputTxt
        Highlight = InputTxt
        Dim strArr As String() = HightLightSearch(sSearch.Trim).Split("-")
        For Each word As String In strArr
            Highlight = Regex.Replace(Highlight, "\b(" & Regex.Escape(word) & ")\b", StartTag & "$1" & EndTag, RegexOptions.IgnoreCase)
        Next
        Return Highlight
    End Function
    Function HightLightSearch(ByVal strName As String) As String
        HightLightSearch = strName.Replace(": ", " ").Trim
        HightLightSearch = flReg.RemoveScript(HightLightSearch).Trim
        HightLightSearch = HightLightSearch.Replace(" ", "-")
        HightLightSearch = HightLightSearch.Replace(",", "")
        For i As Integer = 0 To HightLightSearch.Length - 1
            HightLightSearch = HightLightSearch.Replace("--", "-")
        Next
        Return HightLightSearch
    End Function
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class