Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace DesktopModules.Modules.Home
    Partial Class HomeBusiness
        Inherits Entities.Modules.PortalModuleBase
        Dim arr As New ArrayList
        Dim workController As New WorkController()
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                arr = workController.CMS_Business_List_Home(Me.PortalId, 0, 1, 20)
                litBus.Text = "" 'flCache.GetCache("HomeBusiness_" & Me.PortalId) & ""
                If litBus.Text = "" Then
                    litBus.Text = "<div class=""owl-carousel owl-theme"" id=""owl-HomeBusiness"">"
                    For Each Cr As CMS_BusinessInfo In arr
                        litBus.Text += "<div class=""item "">"
                        litBus.Text += "<div class=""row""><div class=""col-md-12 col-xs-12"">"
                        litBus.Text += "<div class=""bd-hm-w bg-white"">"
                        litBus.Text += "<img src=""" & flReg.ImgSRC(Cr.Logo, 0, 0, True) & """ alt=""" & flReg.ImgAlt(Cr.Business_Vn) & """ />"
                        litBus.Text += "<div class=""hm-w-title"">"
                        litBus.Text += "<a href=""" & flCheck.GetHomeLinkBusiness(Cr.Business_ID) & """ title=""" & flReg.ImgAlt(Cr.Business_Vn) & """></a>"
                        litBus.Text += Cr.Business_Vn & "</div>"
                        litBus.Text += "</div></div></div></div>"
                    Next
                    litBus.Text += "</div>"
                    If arr.Count > 1 Then
                        litBus.Text += "<div class=""i-control"">"
                        litBus.Text += "<span id=""prev-HomeBusiness"" class=""prev-HomeBusiness""><i class=""fa fa-angle-left"" aria-hidden=""true""></i></span>"
                        litBus.Text += "<span id=""next-HomeBusiness"" class=""next-HomeBusiness""><i class=""fa fa-angle-right"" aria-hidden=""true""></i></span>"
                        litBus.Text += "</div>"
                    End If
                    flCache.SetCache("HomeBusiness_" & Me.PortalId, litBus.Text, SecondCache.S2)
                End If
            End If
        End Sub
    End Class
End Namespace