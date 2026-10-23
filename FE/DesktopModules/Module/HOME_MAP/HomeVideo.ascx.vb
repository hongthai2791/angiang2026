Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class HomeVideo
        Inherits Entities.Modules.PortalModuleBase
        Dim obj As CMS_MediaInfo
        Private Sub LoadValue()
            litNews.Text = flCache.GetCache("HomeVideo-HOME-VIDEO-BOTTOM_" & Me.PortalId) & ""
            If litNews.Text = "" Then
                Dim objControler As New CmsController
                Dim obj As New CMS_MediaInfo
                litNews.Text += " <div class=""row"">"
                For Each Cr As CMS_MediaInfo In objControler.CMS_Media_List_Home(Me.PortalId, Me.PortalId, flConnect.IsLang, 3668, mediaType.Video, 1, 4)
                    litNews.Text += "<div class=""col-md-6 pdt10"">"
                    litNews.Text += "<div class=""home-box-news-video i-content-video"">"
                    litNews.Text += "<a title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.Id, Cr.ToUrl) & """>"
                    litNews.Text += "<div class=""box-new-img-video"">"
                    litNews.Text += "<img alt=""" & flReg.ImgAlt(Cr.Name) & """ src=""" & flReg.ImgSRC(Cr.Avatar, 320, 125, True) & """/><i class=""fa fa-play-circle icon-video"" aria-hidden=""True""></i>"
                    litNews.Text += "</div>"
                    litNews.Text += "<p>" & flReg.Trimstr(Cr.Name, 35) & "</p>"
                    litNews.Text += "</a>"
                    litNews.Text += "</div>"
                    litNews.Text += "</div>"
                Next
                litNews.Text += "</div>"
                flCache.SetCache("HomeVideo-HOME-VIDEO-BOTTOM_" & Me.PortalId, litNews.Text, SecondCache.S2)
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadValue()
            End If
        End Sub
    End Class
End Namespace