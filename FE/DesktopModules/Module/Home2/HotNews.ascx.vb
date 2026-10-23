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
                litSlide.Text += "<div class=""card mb-0"">"
                litSlide.Text += "<div class=""item7-card-img""><a href=""javascript:Void(0);""></a>"
                litSlide.Text += "<img src=""" & flReg.ImgSRC(Cr.ImagePath, 0, 350, True) & """ alt=""" & flReg.ImgAlt(Cr.Title) & """ class=""cover-image"">"
                litSlide.Text += "</div>"
                litSlide.Text += "<div class=""card-body p-4"">"
                litSlide.Text += "<div class=""item7-card-desc d-flex mb-2"">"
                litSlide.Text += "<span class=""news-date""><i class=""fa fa-calendar-o text-muted Me-2""></i> " & Cr.PublishedDate.ToString("dd/MM/yyyy HH:mm") & "</span>"
                litSlide.Text += "</div>"
                litSlide.Text += "<a title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """ class=""text-dark"">"
                litSlide.Text += "<h4 class=""font-weight-semibold"">" & Cr.Title & "</h4>"
                litSlide.Text += "</a>"
                litSlide.Text += "<p class=""news-summary"">" & Cr.Summary & "</p>"
                litSlide.Text += "</div>"
                litSlide.Text += "</div>"
                litSlide.Text += "</div>"

            Next
            litSlide.Text += "</div>"
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

