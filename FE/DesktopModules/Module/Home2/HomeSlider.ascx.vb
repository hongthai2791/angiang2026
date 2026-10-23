Imports DotnetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class HomeSlider
        Inherits Entities.Modules.PortalModuleBase
        Dim arr As New ArrayList
        Dim objControler As New CmsController
		Dim sTitle() As String
		Private Sub LoadValue()
            litSlide.Text = "<div class=""owl-carousel owl-theme"" id=""owl-slidebanner"">"
            For Each Cr As DM_SliderInfo In objControler.DM_Slider_List_Home(Me.PortalId, 10)
                sTitle = Cr.MoTa.Split(vbLf)
                litSlide.Text += "<div class=""item"">"
                litSlide.Text += "<div class=""i-image"">"
                litSlide.Text += "<div class=""job-content"">"
                If sTitle.Length > 1 Then
                    litSlide.Text += "<div class=""job-about hidden-xs"">" & sTitle(0) & "</div>"
                    litSlide.Text += "<div class=""job-number hidden-xs"">" & sTitle(1) & "</div>"
                ElseIf sTitle.Length > 0 Then
                    litSlide.Text += "<div class=""job-about hidden-xs"">" & sTitle(0) & "</div>"
                End If
                litSlide.Text += "</div>"
                If Cr.LienKet = "" Then
                    litSlide.Text += "<img alt=""" & flReg.ImgAlt(Cr.TieuDe) & """ title=""" & flReg.ImgAlt(Cr.TieuDe) & """ src=""" & flReg.ImgSRC(Cr.Avatar, 0, 490, True) & """ class=""img-responsive"">"
                Else
                    litSlide.Text += "<a title=""" & flReg.ImgAlt(Cr.TieuDe) & """ href=""" & Cr.LienKet & """>"
                    litSlide.Text += "<img alt=""" & flReg.ImgAlt(Cr.TieuDe) & """ title=""" & flReg.ImgAlt(Cr.TieuDe) & """ src=""" & flReg.ImgSRC(Cr.Avatar, 0, 490, True) & """ class=""img-responsive"">"
                    litSlide.Text += "</a>"
                End If
                litSlide.Text += "</div>"
                litSlide.Text += "</div>"
            Next
            litSlide.Text += "</div>"
            If arr.Count > 1 Then
                litSlide.Text += "<div class=""i-control"">"
                litSlide.Text += "<span id=""prev-slbanner"" class=""cus-owl-prev""><i class=""fa fa-angle-left"" aria-hidden=""true""></i></span>"
                litSlide.Text += "<span id=""next-slbanner"" class=""cus-owl-next""><i class=""fa fa-angle-right"" aria-hidden=""true""></i></span>"
                litSlide.Text += "</div>"
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            'If Not Page.IsPostBack Then
            litSlide.Text = flCache.GetCache("SlideBanner" & Me.PortalId) & ""
				If litSlide.Text = "" Then
                    Call LoadValue()
					flCache.SetCache("SlideBanner" & Me.PortalId, litSlide.Text, SecondCache.M1)
				End If
            'End If
        End Sub
    End Class
End Namespace