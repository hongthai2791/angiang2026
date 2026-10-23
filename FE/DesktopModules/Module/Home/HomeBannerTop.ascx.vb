Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules.Home
    Partial Class HomeBannerTop
        Inherits Entities.Modules.PortalModuleBase
        Dim arr As New ArrayList
        Dim cmsController As New CmsController()
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadValues()
            End If
        End Sub
        Private Sub LoadValues()
            If Not Page.IsPostBack Then
                arr = cmsController.CMS_Advertise_List_Home(PortalId, PortalId, 1, 20)
                litBus.Text = flCache.GetCache("HomeBannerTop" & Me.PortalId) & ""
                If litBus.Text = "" Then
                    litBus.Text = "<div class=""owl-carousel owl-theme"" id=""owl-HomeBannerTop"">"
                    For Each Cr As CMS_AdvertiseInfo In arr
                        litBus.Text += "<div class=""item"">"
                        litBus.Text += "<a title=""" & flReg.ImgAlt(Cr.Advertise_Name) & """ href=""" & Cr.IsURL & """>"
                        litBus.Text += "<div class=""row""><div class=""col-md-12"">"
                        litBus.Text += "<div class=""bd-hm-wb"">"
                        litBus.Text += "<img src=""" & flReg.ImgSRC(Cr.Images, 0, 0, True) & """ alt=""" & flReg.ImgAlt(Cr.Advertise_Name) & """/>"
                        litBus.Text += "</a>"
                        litBus.Text += "</div></div></div></div>"
                    Next
                    litBus.Text += "</div>"

                    flCache.SetCache("HomeBannerTop_" & Me.PortalId, litBus.Text, SecondCache.S2)
                End If
            End If
        End Sub

    End Class
End Namespace