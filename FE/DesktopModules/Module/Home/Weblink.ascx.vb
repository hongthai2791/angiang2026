Imports DotnetNuke.Entities.Modules
Imports DotnetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Home
    Partial Class Weblink
        Inherits PortalModuleBase
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadWeblink()
            End If
        End Sub
        Private Sub LoadWeblink()
            ltWeblink.Text = flCache.GetCache("Weblink_" & Me.PortalId) & ""
            If ltWeblink.Text = "" Then

                For Each Cr As CMS_WebLinkInfo In New CmsController().CMS_WebLink_List(0, 0)
                    ltWeblink.Text += "<div class=""item "">"
                    ltWeblink.Text += "<div class=""col-md-12 doitac-color"">"
                    ltWeblink.Text += "<div class=""blog"">"
                    ltWeblink.Text += "<a  target='_blank' rel='nofollow' href='" & Cr.Url & "' title='" & Cr.Name & "' >"
                    ltWeblink.Text += "<div class=""col-md-3 img-dt doitac-cl"">"
                    ltWeblink.Text += "<img src=""" & flReg.ImgSRC(Cr.Image, 50, 50, False) & """ alt=""" & flReg.ImgAlt(flReg.RemoveScript(Cr.Name, False)) & """/>"
                    ltWeblink.Text += "</div>"
                    ltWeblink.Text += "<div class="" col-md-9 pdt25 text-dt doitac-cl"">"
                    ltWeblink.Text += Cr.Name
                    ltWeblink.Text += "</div>"
                    ltWeblink.Text += "</a></div>"
                    ltWeblink.Text += "</div>"
                    ltWeblink.Text += "</div>"
                Next
                flCache.SetCache("Weblink_" & Me.PortalId, ltWeblink.Text, SecondCache.M10)
            End If
        End Sub
    End Class
End Namespace

