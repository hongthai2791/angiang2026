Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules.Home
    Partial Class BreadCrumb
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New CmsController
        Dim obj As New CMS_NewsCategoriesInfo
        Dim strValue, str() As String
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    litTitle.Text = BrSeo(flReg.UrlAlias & PortalSettings.ActiveTab.TabPath.Replace("//", "/"), PortalSettings.ActiveTab.Title)
                    litTitle.Text += "<div class=""v3home-block-category"">"
                    litTitle.Text += "<div xmlns:v=""http://rdf.data-vocabulary.org"" class=""toptwo"">"
                    litTitle.Text += "<div class='bgbrdm'>"
                    litTitle.Text += "<div class='clear'></div>"
                    litTitle.Text += "<div class='brcrum-title'>"
                    litTitle.Text += "<span class=""iconhome""><a href=""" & flReg.UrlAlias & """><i class='fa fa-home' style='font-size:16px;' title=""Trang chủ""></i> Trang chủ</a></span>"
                    litTitle.Text += "<span class='brd-menu-span'>|</span>"
                    litTitle.Text += "<span class=""brd-menu-head"" typeof=""v:Breadcrumb"">"

                    If IsNothing(flCache.GetCache("BreadCrumb_" & Me.PortalId & "_" & PortalSettings.ActiveTab.TabID)) Then
                        obj = objController.CMS_NewsCategories_Get_By_TabID(PortalId, PortalSettings.ActiveTab.TabID, Me.PortalId)
                    Else
                        obj = CType(flCache.GetCache("BreadCrumb_" & Me.PortalId & "_" & PortalSettings.ActiveTab.TabID), CMS_NewsCategoriesInfo)
                    End If
                    If IsNothing(obj) = False Then
                        flCache.SetCache("BreadCrumb_" & Me.PortalId & "_" & PortalSettings.ActiveTab.TabID, obj, SecondCache.M30)
                        strValue = ""
                        Call GetCategory(obj.ParentId)
                        str = strValue.Split("@")
                        For i As Integer = str.Length - 1 To 0 Step -1
                            litTitle.Text += str(i)
                        Next
                    End If
                    litTitle.Text += "<a title=""" & PortalSettings.ActiveTab.Title & """ href=""" & PortalSettings.ActiveTab.TabPath.Replace("//", "/") & """ rel=""v:url"" property=""v:title"">"
                    litTitle.Text += PortalSettings.ActiveTab.Title
                    litTitle.Text += "</a></span></div><div class='clear'></div>"

                    litTitle.Text += "</div></div><div class='clear'></div></div>"
                End If
            Catch ex As Exception
                flReg.BugLog(Me.PortalId, ex.Message, "cms")
            End Try
        End Sub

        Private Sub GetCategory(cateID As String)
            If IsNothing(flCache.GetCache("GetCategory_" & Me.PortalId & "_" & PortalSettings.ActiveTab.TabID & "_" & cateID)) Then
                obj = objController.CMS_NewsCategories_Get(Me.PortalId, cateID)
            Else
                obj = CType(flCache.GetCache("GetCategory_" & Me.PortalId & "_" & PortalSettings.ActiveTab.TabID & "_" & cateID), CMS_NewsCategoriesInfo)
            End If
            If IsNothing(obj) = False Then
                strValue += "<a title=""" & flReg.ImgAlt(obj.CategoryName) & """ class=""hidden-xs"" href=""" & obj.TabPath.Replace("//", "/") & """ rel=""v:url"" property=""v:title"">" & obj.CategoryName
                strValue += "</a><span class='brd-menu-span hidden-xs'><i class=""fa fa-angle-double-right brd-menu""></i> </span>"
                flCache.SetCache("GetCategory_" & Me.PortalId & "_" & PortalSettings.ActiveTab.TabID & "_" & cateID, obj, SecondCache.M35)
            End If
        End Sub
        Private Function BrSeo(pageLink As String, pageName As String) As String
            BrSeo = "<script type=""application/ld+json"">"
            BrSeo += "{"
            BrSeo += """@context"": ""http://schema.org"", ""@type"": ""BreadcrumbList"","
            BrSeo += """itemListElement"": "
            BrSeo += "["
            BrSeo += "{""@type"": ""ListItem"", ""position"": 1, ""item"": { ""@id"": """ & flReg.UrlAlias & """, ""name"": ""Trang chủ"" }},"
            BrSeo += "{""@type"": ""ListItem"", ""position"": 2,""item"": {""@id"": """ & pageLink & """, ""name"": """ & pageName & """ }}"
            BrSeo += "]"
            BrSeo += "}"
            BrSeo += "</script>"
        End Function

        Public Function FormatItem(tabid As Integer, title As String) As String
            If IsCurrent(tabid) Then
                Return "<a title=""" & flReg.ImgAlt(title) & """ href=" & NavigateURL(tabid) & " class=""active"">" & title & "<i class=""fa fa-chevron-right""></i></a>"
            Else
                Return "<a title=""" & flReg.ImgAlt(title) & """ href=" & NavigateURL(tabid) & "> " & title & "<i class=""fa fa-chevron-right""></i></a>"
            End If
        End Function
        Public Function IsCurrent(ByVal tab As Integer) As Boolean
            If tab = PortalSettings.ActiveTab.TabID Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace