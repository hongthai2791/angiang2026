Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Home

    Public MustInherit Class Search
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjControler As New CmsController
        Dim iTotalPage As Integer
        Dim arrTemp As New ArrayList
        Public CategoryId, adVan As Integer
        Public Datefrom, DateTo As String
        Dim fdate, tdate As DateTime
        Dim ResultStr, strArr() As String
        Dim UrlAlias As String = flReg.UrlAlias

#Region "Event Handlers"
        Public Shared Sub LoadAdvanced(ByVal drList As DropDownList)
            drList.Items.Clear()
            drList.Items.Add(New ListItem("Tìm theo tiêu đề", 1))
            drList.Items.Add(New ListItem("Tìm theo trích dẫn", 2))
            drList.Items.Add(New ListItem("Tìm theo nội dung", 3))
        End Sub
        Private Sub GetID()
            Call LoadAdvanced(drAdvanced)
            Call TypeSearch()
            If Request.Item("type") & "" <> "" Then drType.SelectedValue = Request.Item("type")
            txtSearch.Text = flCheck.RequestSearch(Request.RawUrl)
            For i As Integer = 0 To 5
                txtSearch.Text = txtSearch.Text.Replace("  ", " ")
            Next
            If Request.Item("f") & "" <> "" Then
                Datefrom = Ultis.GetSafeRawUrl(Request.Item("f"))
                txtDateFrom.Text = Datefrom.Replace("-", "/")
            Else
                Datefrom = Now.AddYears(-1).ToString("dd/MM/yyyy")
                txtDateFrom.Text = Now.AddYears(-1).ToString("dd/MM/yyyy")
            End If
            If Request.Item("t") & "" <> "" Then
                DateTo = Ultis.GetSafeRawUrl(Request.Item("t"))
                txtDateTo.Text = DateTo.Replace("-", "/")
            Else
                DateTo = Now.AddDays(1).ToString("dd/MM/yyyy")
                txtDateTo.Text = Now.AddDays(1).ToString("dd/MM/yyyy")
            End If
            vUrl.Value = Request.RawUrl
            If vUrl.Value.Contains("/p/") Then
                vUrl.Value = vUrl.Value.Substring(0, vUrl.Value.LastIndexOf("/p/"))
                currPage.Value = flReg.WriteNumber(flCheck.RequestItem(Request.RawUrl, "p"))
            End If
            If currPage.Value = 0 Then currPage.Value = 1
        End Sub
        Private Sub Searchs()
            Try
                If Not String.IsNullOrEmpty(txtDateFrom.Text) Then fdate = flReg.WriteDate(txtDateFrom.Text, False)
                If Not String.IsNullOrEmpty(txtDateTo.Text) Then tdate = flReg.WriteDate(txtDateTo.Text, False)
                Select Case Request("type") & ""
                    Case "video"
                        Call flFunction.LoadCategories(ddlCategory, Me.PortalId, 0, CategoryType.Video)
                        Call SearchVideo()
                    Case "audio"
                        Call flFunction.LoadCategories(ddlCategory, Me.PortalId, 0, CategoryType.Audio)
                        Call SearchAudio()
                    Case "photo"
                        Call flFunction.LoadCategories(ddlCategory, Me.PortalId, 0, CategoryType.Album)
                        Call SearchPhoto()
                    Case "new"
                        Call flFunction.LoadCategories(ddlCategory, Me.PortalId, 0, CategoryType.News)
                        Call SearchNews()
                    Case Else
                        Call flFunction.LoadCategories(ddlCategory, Me.PortalId, 0, CategoryType.News)
                        Call SearchAll()

                End Select
            Catch ex As Exception
                Dim s As String = ex.Message
            End Try
        End Sub
        Private Sub TypeSearch()
            drType.Items.Clear()
            drType.Items.Add(New ListItem("Tất cả nội dung", "all"))
            drType.Items.Add(New ListItem("Tất cả tin bài", "new"))
            drType.Items.Add(New ListItem("Tất cả video", "video"))
        End Sub
        Private Sub SearchNews()
            CategoryId = flReg.WriteNumber(Ultis.GetSafeRawUrl(Request.Item("cid")))
            ddlCategory.SelectedValue = CategoryId
            drAdvanced.SelectedValue = flReg.WriteNumber(Request.Item("ad") & "")
            adVan = drAdvanced.SelectedValue

            arrTemp = ObjControler.CMS_News_Search_Home(Me.PortalId, PortalId, txtSearch.Text.Trim, fdate, tdate, CategoryId, currPage.Value, 10, False,
                                                        Ultis.FullTextSearch(txtSearch.Text.Trim, False), drAdvanced.SelectedValue)
            For Each Cr As CMS_NewsInfo In arrTemp
                litSearch.Text += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
                If Cr.ImagePath <> "" Then
                    litSearch.Text += "<div class=""divimg imgautodiv img-xs"">"
                    litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                    litSearch.Text += "<img alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 170, 0, True) & """ />"
                    litSearch.Text += "</a>"
                    litSearch.Text += "</div>"
                End If
                litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                litSearch.Text += Highlight(Cr.Title, "<font class=""highlight"">", "</font>")
                litSearch.Text += "</a>"
                litSearch.Text += "<br class=""hidden-xs"" /><span class=""item-subinfo"">"
                litSearch.Text += flReg.ReadDate(Cr.PublishedDate)
                litSearch.Text += "</span>"
                litSearch.Text += "<br /><span class=""sitem-summary hidden-xs"">"
                litSearch.Text += Highlight(Cr.Summary, "<font class=""highlight"">", "</font>")
                litSearch.Text += "</span>"
                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""item-line""></div>"
                litSearch.Text += "</div></div>"
            Next

            For Each Ci As CMS_NewsInfo In arrTemp
                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""col-md-12 col-xs-12"">"
                If flReg.WriteNumber(currPage.Value) > 1 Then
                    litSearch.Text += flReg.NextPageJs(Ci.Total, 10, currPage.Value, 4, "fnext(")
                Else
                    litSearch.Text += flReg.NextPageJs(Ci.Total, 10, currPage.Value, 5, "fnext(")
                End If
                litSearch.Text += "</div>"
                Exit For
            Next

            txtSearch.Focus()
            flReg.LoadBasePage(Page, PortalSettings.ActiveTab.Title & " | " & txtSearch.Text.Trim, txtSearch.Text.Trim, Now, "http://" & PortalAlias.HTTPAlias & Request.RawUrl, flConnect.fileDomain & "/images/logo.png", PortalAlias.HTTPAlias)
            For Each Cr As CMS_NewsInfo In arrTemp
                litSeo.Text = "<h1>" & Cr.Title & "</h1>"
                litSeo.Text += "<h2>" & Cr.Summary & "</h2>"
                Exit For
            Next
        End Sub
        Private Sub SearchVideo()
            If IsNumeric(Request.Item("cid")) Then
                CategoryId = Ultis.GetSafeRawUrl(Request.Item("cid"))
                ddlCategory.SelectedValue = CategoryId
            End If
            arrTemp = ObjControler.CMS_Media_Search_Home(Me.PortalId, PortalId, flConnect.IsLang, fdate, tdate, Ultis.FullTextSearch(txtSearch.Text.Trim, False), CategoryId, currPage.Value, 10, "", 0, False, 0)
            For Each Cr As CMS_MediaInfo In arrTemp
                litSearch.Text += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
                If Cr.Avatar <> "" Then
                    litSearch.Text += "<div class=""divimg imgautodiv img-xs"">"
                    litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/video/" & Cr.ToUrl & "-" & Cr.Id & ".html"" >"
                    litSearch.Text += "<img alt=""" & flReg.ImgAlt(Cr.Name) & """ src=""" & flReg.ImgSRC(Cr.Avatar, 170, 0, True) & """ />"
                    litSearch.Text += "</a>"
                    litSearch.Text += "</div>"
                End If
                litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/video/" & Cr.ToUrl & "-" & Cr.Id & ".html"">"
                litSearch.Text += Highlight(Cr.Name, "<font class=""highlight"">", "</font>")
                litSearch.Text += Ultis.IsVideo(2)
                litSearch.Text += "</a>"
                litSearch.Text += "<br /><span class=""item-subinfo"">"
                litSearch.Text += flReg.ReadDate(Cr.PublishedDate)
                litSearch.Text += "</span>"
                litSearch.Text += "<br /><span class=""sitem-summary hidden-xs"">"
                litSearch.Text += Cr.Summary
                litSearch.Text += "</span>"
                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""item-line""></div>"
                litSearch.Text += "</div></div>"
            Next

            For Each Ci As CMS_MediaInfo In arrTemp
                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""col-md-12 col-xs-12"">"
                If flReg.WriteNumber(currPage.Value) > 1 Then
                    litSearch.Text += flReg.NextPageJs(Ci.Total, 10, currPage.Value, 4, "fnext(")
                Else
                    litSearch.Text += flReg.NextPageJs(Ci.Total, 10, currPage.Value, 5, "fnext(")
                End If
                litSearch.Text += "</div>"
                Exit For
            Next

            txtSearch.Focus()
            flReg.LoadBasePage(Page, PortalSettings.ActiveTab.Title & " | " & txtSearch.Text.Trim, txtSearch.Text.Trim, Now, "http://" & PortalAlias.HTTPAlias & Request.RawUrl, flConnect.fileDomain & "/images/logo.png", PortalAlias.HTTPAlias)
            For Each Cr As CMS_MediaInfo In arrTemp
                litSeo.Text = "<h1>" & Cr.Name & "</h1>"
                litSeo.Text += "<h2>" & Cr.Summary & "</h2>"
                Exit For
            Next
        End Sub
        Private Sub SearchAudio()
            If IsNumeric(Request.Item("cid")) Then
                CategoryId = Ultis.GetSafeRawUrl(Request.Item("cid"))
                ddlCategory.SelectedValue = CategoryId
            End If
            arrTemp = ObjControler.CMS_Media_Search_Home(Me.PortalId, PortalId, flConnect.IsLang, fdate, tdate,
                                                        Ultis.endCodeSearch(txtSearch.Text.Trim), CategoryId, currPage.Value, 10, "", 0, False, 0)
            For Each Cr As CMS_MediaInfo In arrTemp
                litSearch.Text += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
                If Cr.Avatar <> "" Then
                    litSearch.Text += "<div class=""divimg imgautodiv img-xs"">"
                    litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/audio/" & Cr.ToUrl & "-" & Cr.Id & ".html"" >"
                    litSearch.Text += "<img alt=""" & flReg.ImgAlt(Cr.Name) & """ src=""" & flReg.ImgSRC(Cr.Avatar, 170, 0, True) & """ />"
                    litSearch.Text += "</a>"
                    litSearch.Text += "</div>"
                End If
                litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/audio/" & Cr.ToUrl & "-" & Cr.Id & ".html"">"
                litSearch.Text += Cr.Name
                litSearch.Text += "</a>"
                litSearch.Text += "<br /><span class=""item-subinfo"">"
                litSearch.Text += flReg.ReadDate(Cr.PublishedDate)
                litSearch.Text += "</span>"
                litSearch.Text += "<br /><span class=""sitem-summary hidden-xs"">"
                litSearch.Text += Cr.Summary
                litSearch.Text += "</span>"
                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""item-line""></div>"
                litSearch.Text += "</div></div>"
            Next

            For Each Ci As CMS_MediaInfo In arrTemp
                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""col-md-12 col-xs-12"">"
                If flReg.WriteNumber(currPage.Value) > 1 Then
                    litSearch.Text += flReg.NextPageJs(Ci.Total, 10, currPage.Value, 4, "fnext(")
                Else
                    litSearch.Text += flReg.NextPageJs(Ci.Total, 10, currPage.Value, 5, "fnext(")
                End If
                litSearch.Text += "</div>"
                Exit For
            Next

            txtSearch.Focus()
            flReg.LoadBasePage(Page, PortalSettings.ActiveTab.Title & " | " & txtSearch.Text.Trim, txtSearch.Text.Trim, Now, "http://" & PortalAlias.HTTPAlias & Request.RawUrl, flConnect.fileDomain & "/images/logo.png", PortalAlias.HTTPAlias)
            For Each Cr As CMS_MediaInfo In arrTemp
                litSeo.Text = "<h1>" & Cr.Name & "</h1>"
                litSeo.Text += "<h2>" & Cr.Summary & "</h2>"
                Exit For
            Next
        End Sub
        Private Sub SearchPhoto()
            If IsNumeric(Request.Item("cid")) Then
                CategoryId = Ultis.GetSafeRawUrl(Request.Item("cid"))
                ddlCategory.SelectedValue = CategoryId
            End If
            drAdvanced.SelectedValue = flReg.WriteNumber(Request.Item("ad") & "")
            adVan = drAdvanced.SelectedValue

            arrTemp = ObjControler.CMS_News_Search_Home(Me.PortalId, PortalId, flConnect.IsLang, fdate, tdate, CategoryId, currPage.Value, 10, True, Ultis.FullTextSearch(txtSearch.Text.Trim, False), drAdvanced.SelectedValue)

            For Each Cr As CMS_NewsInfo In arrTemp
                litSearch.Text += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
                If Cr.ImagePath <> "" Then
                    litSearch.Text += "<div class=""divimg imgautodiv img-xs"">"
                    litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                    litSearch.Text += "<img alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 170, 0, True) & """ />"
                    litSearch.Text += "</a>"
                    litSearch.Text += "</div>"
                End If
                litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                litSearch.Text += Cr.Title
                litSearch.Text += "</a><br /><span class=""item-subinfo"">"
                litSearch.Text += flReg.ReadDate(Cr.PublishedDate)
                litSearch.Text += "</span>"
                litSearch.Text += "<br /><span class=""sitem-summary hidden-xs"">"
                litSearch.Text += Cr.Summary
                litSearch.Text += "</span>"
                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""item-line""></div>"
                litSearch.Text += "</div></div>"
            Next

            For Each Ci As CMS_NewsInfo In arrTemp
                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""col-md-12 col-xs-12"">"
                If flReg.WriteNumber(currPage.Value) > 1 Then
                    litSearch.Text += flReg.NextPageJs(Ci.Total, 10, currPage.Value, 4, "fnext(")
                Else
                    litSearch.Text += flReg.NextPageJs(Ci.Total, 10, currPage.Value, 5, "fnext(")
                End If
                litSearch.Text += "</div>"
                Exit For
            Next

            txtSearch.Focus()
            flReg.LoadBasePage(Page, PortalSettings.ActiveTab.Title & " | " & txtSearch.Text.Trim, txtSearch.Text.Trim, Now, "http://" & PortalAlias.HTTPAlias & Request.RawUrl, flConnect.fileDomain & "/images/logo.png", PortalAlias.HTTPAlias)
            For Each Cr As CMS_NewsInfo In arrTemp
                litSeo.Text = "<h1>" & Cr.Title & "</h1>"
                litSeo.Text += "<h2>" & Cr.Summary & "</h2>"
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
            ObjDt.Columns.Add("Type", GetType(String))
            ObjDt.Columns.Add("CategoryId", GetType(Integer))
            ObjDt.Columns.Add("Total", GetType(Integer))

        End Sub
        Private Sub SearchAll()
            CategoryId = flReg.WriteNumber(Ultis.GetSafeRawUrl(Request.Item("cid")))
            ddlCategory.SelectedValue = CategoryId
            drAdvanced.SelectedValue = flReg.WriteNumber(Request.Item("ad") & "")
            adVan = drAdvanced.SelectedValue
            Call CreateTable()

            arrTemp = ObjControler.CMS_News_Search_Home(Me.PortalId, PortalId, txtSearch.Text.Trim, fdate, tdate, CategoryId, currPage.Value, 10, False, Ultis.FullTextSearch(txtSearch.Text.Trim, False), drAdvanced.SelectedValue)
            For Each Cr As CMS_NewsInfo In arrTemp
                r = ObjDt.NewRow
                r.Item("NewId") = Cr.NewId
                r.Item("Title") = Cr.Title
                r.Item("ToUrl") = Cr.ToUrl
                r.Item("ImagePath") = Cr.ImagePath
                r.Item("PublishedDate") = Cr.PublishedDate
                r.Item("Summary") = Cr.Summary
                r.Item("Type") = "news"
                r.Item("CategoryId") = Cr.CategoryId
                r.Item("Total") = Cr.Total
                ObjDt.Rows.Add(r)
                total = Cr.Total
            Next

            arrTemp = ObjControler.CMS_News_Search_Home(Me.PortalId, PortalId, flConnect.IsLang, fdate, tdate, CategoryId, currPage.Value, 10, True, Ultis.FullTextSearch(txtSearch.Text.Trim, False), drAdvanced.SelectedValue)

            For Each Cr As CMS_NewsInfo In arrTemp
                r = ObjDt.NewRow
                r.Item("NewId") = Cr.NewId
                r.Item("Title") = Cr.Title
                r.Item("ToUrl") = Cr.ToUrl
                r.Item("ImagePath") = Cr.ImagePath
                r.Item("PublishedDate") = Cr.PublishedDate
                r.Item("Summary") = Cr.Summary
                r.Item("Type") = "photo"
                r.Item("CategoryId") = Cr.CategoryId
                r.Item("Total") = Cr.Total
                ObjDt.Rows.Add(r)
                total = Cr.Total
            Next

            arrTemp = ObjControler.CMS_Media_Search_Home(Me.PortalId, PortalId, flConnect.IsLang, fdate, tdate, Ultis.FullTextSearch(txtSearch.Text.Trim, False), 0, currPage.Value, 10, "", 0, False, 0)
            For Each Cr As CMS_MediaInfo In arrTemp
                r = ObjDt.NewRow
                r.Item("NewId") = Cr.Id
                r.Item("Title") = Cr.Name
                r.Item("ToUrl") = Cr.ToUrl
                r.Item("ImagePath") = Cr.Avatar
                r.Item("PublishedDate") = Cr.PublishedDate
                r.Item("Summary") = Cr.Summary
                r.Item("Type") = "video"
                r.Item("CategoryId") = Cr.CategoryId
                r.Item("Total") = Cr.Total
                ObjDt.Rows.Add(r)
                If Cr.Total > total Then total = Cr.Total
            Next

            For Each Cr As DataRow In ObjDt.Select("", "PublishedDate DESC")
                If Cr.Item("Type") = "video" Then
                    litSearch.Text += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
                    If Cr.Item("ImagePath") <> "" Then
                        litSearch.Text += "<div class=""divimg imgautodiv img-xs"">"
                        litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Item("Title")) & """ href=""" & UrlAlias & "/video/" & Cr.Item("ToUrl") & "-" & Cr.Item("NewId") & ".html"" >"
                        litSearch.Text += "<img alt=""" & flReg.ImgAlt(Cr.Item("Title")) & """ src=""" & flReg.ImgSRC(Cr.Item("ImagePath"), 170, 0, True) & """ />"
                        litSearch.Text += "</a>"
                        litSearch.Text += "</div>"
                    End If
                    litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Item("Title")) & """ href=""" & UrlAlias & "/video/" & Cr.Item("ToUrl") & "-" & Cr.Item("NewId") & ".html"">"
                    litSearch.Text += Highlight(Cr.Item("Title"), "<font class=""highlight"">", "</font>")
                    litSearch.Text += Ultis.IsVideo(2)
                    litSearch.Text += "</a>"
                    litSearch.Text += "<br /><span class=""item-subinfo"">"
                    litSearch.Text += flReg.ReadDate(Cr.Item("PublishedDate"))
                    litSearch.Text += "</span>"
                    litSearch.Text += "<br /><span class=""sitem-summary hidden-xs"">"
                    litSearch.Text += Cr.Item("Summary")
                    litSearch.Text += "</span>"
                    litSearch.Text += "<div class=""clr""></div>"
                    litSearch.Text += "<div class=""item-line""></div>"
                    litSearch.Text += "</div></div>"
                Else
                    litSearch.Text += "<div class=""col-md-12 col-xs-12""><div class=""i-item"">"
                    If Cr.Item("ImagePath") <> "" Then
                        litSearch.Text += "<div class=""divimg imgautodiv img-xs"">"
                        litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Item("Title")) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.Item("CategoryId"), Cr.Item("NewId"), Cr.Item("ToUrl")) & """>"
                        litSearch.Text += "<img alt=""" & flReg.ImgAlt(Cr.Item("Title")) & """ src=""" & flReg.ImgSRC(Cr.Item("ImagePath"), 170, 0, True) & """ />"
                        litSearch.Text += "</a>"
                        litSearch.Text += "</div>"
                    End If
                    litSearch.Text += "<a class=""item-title"" title=""" & flReg.ImgAlt(Cr.Item("Title")) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.Item("CategoryId"), Cr.Item("NewId"), Cr.Item("ToUrl")) & """>"
                    litSearch.Text += Highlight(Cr.Item("Title"), "<font class=""highlight"">", "</font>")
                    litSearch.Text += "</a>"
                    litSearch.Text += "<br class=""hidden-xs"" /><span class=""item-subinfo"">"
                    litSearch.Text += flReg.ReadDate(Cr.Item("PublishedDate"))
                    litSearch.Text += "</span>"
                    litSearch.Text += "<br /><span class=""sitem-summary hidden-xs"">"
                    litSearch.Text += Highlight(Cr.Item("Summary"), "<font class=""highlight"">", "</font>")
                    litSearch.Text += "</span>"
                    litSearch.Text += "<div class=""clr""></div>"
                    litSearch.Text += "<div class=""item-line""></div>"
                    litSearch.Text += "</div></div>"
                End If
            Next

            txtSearch.Focus()
            flReg.LoadBasePage(Page, PortalSettings.ActiveTab.Title & " | " & txtSearch.Text.Trim, txtSearch.Text.Trim, Now, "http://" & PortalAlias.HTTPAlias & Request.RawUrl, flConnect.fileDomain & "/images/logo.png", PortalAlias.HTTPAlias)

            For Each Cr As DataRow In ObjDt.Select("", "PublishedDate DESC")
                litSeo.Text = "<h1>" & Cr.Item("Title") & "</h1>"
                litSeo.Text += "<h2>" & Cr.Item("Summary") & "</h2>"

                litSearch.Text += "<div class=""clr""></div>"
                litSearch.Text += "<div class=""col-md-12 col-xs-12"">"
                If flReg.WriteNumber(currPage.Value) > 1 Then
                    litSearch.Text += flReg.NextPageJs(total, 10, currPage.Value, 4, "fnext(")
                Else
                    litSearch.Text += flReg.NextPageJs(total, 10, currPage.Value, 5, "fnext(")
                End If
                litSearch.Text += "</div>"
                Exit For
            Next


        End Sub
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                txtSearch.Attributes.Add("onkeypress", "return clickButton(event,""" + btnSearch.ClientID + """)")
                If Not IsPostBack Then
                    Call GetID()
                    Call Searchs()
                    txtSearch.Focus()
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Function SearchUrl() As String
            SearchUrl = flReg.UrlAlias & "/tim-kiem"
            If drType.SelectedValue <> "all" Then SearchUrl += "/type/" & drType.SelectedValue
            If ddlCategory.SelectedValue <> "0" Then SearchUrl += "/cid/" & ddlCategory.SelectedValue
            SearchUrl += "/ad/" & drAdvanced.SelectedValue
            If txtDateFrom.Text.Replace("Từ", "") <> "" Then SearchUrl += "/f/" & txtDateFrom.Text.Replace("/", "-")
            If txtDateTo.Text.Replace("Đến", "") <> "" Then SearchUrl += "/t/" & txtDateTo.Text.Replace("/", "-")
            If txtSearch.Text.Trim <> "" Then SearchUrl += "/q/" & flCheck.EncodeSearch(txtSearch.Text.Trim)
        End Function

        Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            Response.Redirect(SearchUrl, True)
        End Sub

        Function Highlight(ByVal InputTxt As String, ByVal StartTag As String, ByVal EndTag As String) As String
            If txtSearch.Text.Trim = "" Then Return InputTxt
            Highlight = InputTxt
            Dim strArr As String() = txtSearch.Text.Trim.Split(" ")
            For Each word As String In strArr
                Highlight = Regex.Replace(Highlight, "\b(" & Regex.Escape(word) & ")\b", StartTag & "$1" & EndTag, RegexOptions.IgnoreCase)
            Next
        End Function
        Protected Sub ddlCategory_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlCategory.SelectedIndexChanged, drAdvanced.SelectedIndexChanged, drType.SelectedIndexChanged
            Response.Redirect(SearchUrl, True)
        End Sub
#End Region

    End Class

End Namespace