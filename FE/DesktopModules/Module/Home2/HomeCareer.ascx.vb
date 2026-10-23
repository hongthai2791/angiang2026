Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace DesktopModules.Modules.Home
    Partial Class HomeCareer
        Inherits Entities.Modules.PortalModuleBase
        Dim arr As New ArrayList
        Dim objController As New WorkController()
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                litBus.Text = flCache.GetCache("HomeCareer_" & Me.PortalId) & ""
                If litBus.Text = "" Then
                    For Each Cr As CMS_CareerInfo In objController.CMS_Career_List_Home(Me.PortalId, 12)
                        'litBus.Text += "<div class=""col-md-12"">"
                        'litBus.Text += "<div class=""info-box-content"">"
                        'litBus.Text += "<span class=""career-title""><a href=""/viec-lam/nganh-nghe/" & flReg.NameUrl(Cr.Career_Name) & "-" & Cr.ID & """ title=""" & flReg.ImgAlt(Cr.Career_Name) & """>" & Cr.Career_Name & "</a></span>"
                        'litBus.Text += "&nbsp;(<span class=""career-number"">" & Cr.Total & "</span>)"
                        litBus.Text += "<div class=""col-xl-2 col-lg-2 col-md-4 col-sm-6"">"
                        litBus.Text += "<div class=""item-all-card text-dark text-center""><a href=""/viec-lam/nganh-nghe/" & flReg.NameUrl(Cr.Career_Name) & "-" & Cr.ID & """ title=""" & flReg.ImgAlt(Cr.Career_Name) & """></a>"
                        litBus.Text += "<div class=""iteam-all-icon"">"
                        litBus.Text += "<img src=""" & flReg.ImgSRC(Cr.Career_Logo, 0, 60, True) & """ class=""imag-service image-serve"" alt=""Cashier"">"
                        litBus.Text += "</div>"
                        litBus.Text += "<div class=""item-all-text mt-3"">"
                        litBus.Text += "<h5 class=""mb-0 text-body"">" & Cr.Career_Name & "</h5>"
                        litBus.Text += "</div>"
                        litBus.Text += "</div>"
                        litBus.Text += "</div>"
                    Next
                    flCache.SetCache("HomeCareer_" & Me.PortalId, litBus.Text, SecondCache.S2)
                End If
            End If
        End Sub
    End Class
End Namespace