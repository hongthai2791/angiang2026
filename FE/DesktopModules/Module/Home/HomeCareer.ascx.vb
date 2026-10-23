Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace DesktopModules.Modules.Home
    Partial Class HomeCareer
        Inherits Entities.Modules.PortalModuleBase
        Dim arr As New ArrayList
        Dim objController As New WorkController()
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            'If Not Page.IsPostBack Then
            '    litBus.Text = flCache.GetCache("HomeCareer_" & Me.PortalId) & ""
            '    If litBus.Text = "" Then
            '        litBus.Text = "<div class=""row"">"
            '        For Each Cr As CMS_CareerInfo In objController.CMS_Career_List_Home(Me.PortalId, 10)
            '            litBus.Text += "<div class=""col-md-12"">"
            '            litBus.Text += "<div class=""info-box-content"">"
            '            litBus.Text += "<span class=""career-title""><a href=""/viec-lam/nganh-nghe/" & flReg.NameUrl(Cr.Career_Name) & "-" & Cr.ID & """ title=""" & flReg.ImgAlt(Cr.Career_Name) & """>" & Cr.Career_Name & "</a></span>"
            '            litBus.Text += "&nbsp;(<span class=""career-number"">" & Cr.Total & "</span>)"
            '            litBus.Text += "</div>"
            '            litBus.Text += "</div>"
            '        Next
            '        litBus.Text += "<div class=""clear""></div>"
            '        litBus.Text += "</div>"
            '        flCache.SetCache("HomeCareer_" & Me.PortalId, litBus.Text, SecondCache.S2)
            '    End If
            'End If
        End Sub
    End Class
End Namespace