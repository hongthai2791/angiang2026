Imports DotNetNuke.EPORTAL
Imports DotnetNuke.CMS

Namespace DesktopModules.Modules.Home
    Partial Class HomeBanner
        Inherits Entities.Modules.PortalModuleBase
        Dim str() As String
        Dim strTB, strDes As String
        Dim obj As New CMS_NewsCategoriesInfo
        Dim objControler As New CmsController
        Private Sub LoadNews()
            litNew.Text = flCache.GetCache("HomeNews2-HOME-NEWS2-BOTTOM_" & Me.PortalId) & ""
            If litNew.Text = "" Then

                Dim objControler As New CmsController
                Dim obj As New CMS_NewsCategoriesInfo
                Dim arr As ArrayList = objControler.CMS_News_HomeBlock(Me.PortalId, Me.PortalId, HomeBlock.TinThuong, "", 251, 10, False)
                str = flCheck.SetupValue(Me.PortalId, "HOME-NEWS2-BOTTOM").Split(";")
                litNew.Text = "<div class=""row"">"
                For i As Integer = 0 To str.Length - 1
                    obj = objControler.CMS_NewsCategories_Get(Me.PortalId, flReg.WriteNumber(str(i)))
                    If IsNothing(obj) = False Then
                        litNew.Text += "<marquee>"
                        For Each Cr As CMS_NewsInfo In arr
                            If (Cr.NewDay > 10) Then
                                litNew.Text += "<a class=""shotnews"" href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>"
                                litNew.Text += "&nbsp;<span class=""new-titlecc"">" & Cr.Title & "</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>"
                            Else
                                litNew.Text += "<a class=""shotnews"" href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>"
                                litNew.Text += "<span class=""New-tt"">New</span>&nbsp;<span class=""new-titlecc"">" & Cr.Title & "</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>"
                            End If
                            'litNew.Text += "<span class=""New-tt"">New</span>&nbsp;<span class=""new-titlecc"">" & Cr.Title & "</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                        Next
                        litNew.Text += "</marquee>"
                        '    litNew.Text += "<h4 ><a  href=""" & flReg.UrlAlias & obj.TabPath.Replace("//", "/") & """ title=""" & flReg.ImgAlt(obj.CategoryName) & """>" & obj.CategoryName & "</h4>"
                        '    litNew.Text += "<div class=""owl-carousel owl-theme"" id=""owl-HomeBanner-tt" & Me.TabModuleId & """>"
                        '    For Each Cr As CMS_NewsInfo In arr
                        '        litNew.Text += "<div class=""item"">"
                        '        litNew.Text += " <div class=""row box-ct-wh-tt "">"
                        '        litNew.Text += "<div class=""col-md-3"">"
                        '        litNew.Text += "<img alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 90, 65, True) & """ />"
                        '        litNew.Text += "</div>"
                        '        litNew.Text += "<div class=""col-md-9 conten-nd-tt cont-size"">"
                        '        If (Cr.NewDay > 10) Then
                        '            litNew.Text += "<div class=""conten-title-tt "">&nbsp;<a href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>" & flReg.Trimstr(Cr.Title, 100) & "</a></div>"
                        '        Else
                        '            litNew.Text += "<div class=""conten-title-tt ""><span class=""New-tt"">New</span>&nbsp;<a href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>" & flReg.Trimstr(Cr.Title, 100) & "</a></div>"
                        '        End If

                        '        litNew.Text += "<div class=""conten-sumary"">" & flReg.Trimstr(Cr.Summary, 100) & "</div>"
                        '        litNew.Text += "<div class=""conten-sumary"">" & flReg.ReadDate(Cr.PublishedDate) & "</div>"
                        '        litNew.Text += "<div class=""row"">"
                        '        litNew.Text += "<div class=""col-md-8 conten-sumary-tt"">"
                        '        litNew.Text += "<p><a href = """ & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, obj.TabID, Cr.ToUrl) & """ > <i Class=""fa fa-tag""></i>" & flCheck.Category_Name(Me.PortalId, Cr.CategoryId) & "</a></p> "
                        '        litNew.Text += "</div>"
                        '        litNew.Text += "<div class=""col-md-4 conten-sumary-tt"">"
                        '        litNew.Text += "<p><a href = """ & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """ > <i Class=""fa fa-plus""></i>Đọc tiếp</a></p> "
                        '        litNew.Text += "</div>"
                        '        litNew.Text += "</div>"
                        '        litNew.Text += "</div>"
                        '        litNew.Text += "</div>"
                        '        litNew.Text += "</div>"
                        '    Next
                        '    litNew.Text += " </div>"

                        '    If arr.Count > 1 Then
                        '        litNew.Text += "<div class=""i-control"">"
                        '        litNew.Text += "<span id=""prev-HomeBanner-tt" & Me.TabModuleId & """ class=""prev-HomeBanner-tt""><i class=""fa fa-angle-left"" aria-hidden=""true""></i></span>"
                        '        litNew.Text += "<span id=""next-HomeBanner-tt" & Me.TabModuleId & """ class=""next-HomeBanner-tt""><i class=""fa fa-angle-right"" aria-hidden=""true""></i></span>"
                        '        litNew.Text += "</div>"
                        '        litNew.Text += "<script type=""text/javascript"">"
                        '        litNew.Text += "$(document).ready(function () {"
                        '        litNew.Text += "var osb" & Me.TabModuleId & " = $('#owl-HomeBanner-tt" & Me.TabModuleId & "');"
                        '        litNew.Text += "osb" & Me.TabModuleId & ".owlCarousel({"
                        '        litNew.Text += "autoplay: true, autoplayTimeout: 5500, nav: false, loop: true, dots: false, pagination: false,"
                        '        litNew.Text += "responsive: { 0: { items: 1 }, 600: { items: 2 }, 1000: { items: 2 } }"
                        '        litNew.Text += "});"
                        '        litNew.Text += "$('#prev-HomeBanner-tt" & Me.TabModuleId & "').click(function () { osb" & Me.TabModuleId & ".trigger('prev.owl.carousel'); });"
                        '        litNew.Text += "$('#next-HomeBanner-tt" & Me.TabModuleId & "').click(function () { osb" & Me.TabModuleId & ".trigger('next.owl.carousel'); });"
                        '        litNew.Text += "});"
                        '        litNew.Text += "</script>"
                        '    End If
                    End If
                Next
                litNew.Text += " </div>"
                flCache.SetCache("HomeNews2-HOME-NEWS2-BOTTOM_" & Me.TabModuleId & "_" & Me.PortalId, litNew.Text, SecondCache.M60)
            End If
        End Sub

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadNews()
            End If
        End Sub

    End Class
End Namespace