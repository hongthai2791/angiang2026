Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules
    Partial Class HotNews
        Inherits PortalModuleBase
        Public IsLang As String = Threading.Thread.CurrentThread.CurrentCulture.Name
        Dim ctl As New CmsController
        Private Sub LoadValues()
            litSlide.Text = "<div class=""owl-carousel owl-theme"" id=""owl-slidenews"">"
            For Each Cr As CMS_NewsInfo In ctl.CMS_News_HomeBlock(Me.PortalId, Me.PortalId, HomeBlock.NongTrangChu, "", 0, 4, False)
                litSlide.Text += "<div class=""item"">"
                litSlide.Text += "<div class=""home-box-news slide-box"">"
                litSlide.Text += "<a title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                litSlide.Text += "<img class='hot-img' alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 0, 350, True) & """ />"
                litSlide.Text += "<p>" & Cr.Title & "</p>"
                litSlide.Text += "</a>"
                'litSlide.Text += "<div class=""date-pub"">"
                'litSlide.Text += "<p>" & Cr.PublishedDate.ToString("dd/mm/yyyy") & "</p>"
                'litSlide.Text += "</div>"
                litSlide.Text += "</div>"
                litSlide.Text += "</div>"
            Next
            litSlide.Text += "</div>"
            For Each Cr As CMS_NewsInfo In ctl.CMS_News_HomeBlock(Me.PortalId, Me.PortalId, HomeBlock.TinThuong, "", 0, 4, False)
                litNew.Text += "<div class=""col-md-6"">"
                litNew.Text += "<div class=""home-box-news"">"
                litNew.Text += "<a title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                litNew.Text += "<div class=""box-new-img"">"
                litNew.Text += "<img class='right-img' alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 0, 125, True) & """ />"
                litNew.Text += "</div>"
                litNew.Text += "<p>" & Cr.Title & "</p>"
                litNew.Text += "</a>"
                litNew.Text += "</div>"
                litNew.Text += "</div>"
            Next
        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    Call LoadValues()
                End If
            Catch ex As Exception
                ProcessModuleLoadException(Me, ex)
            End Try
        End Sub

    End Class
End Namespace

