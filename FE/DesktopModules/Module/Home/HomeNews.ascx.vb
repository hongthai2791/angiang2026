Imports DotnetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class HomeNews
        Inherits Entities.Modules.PortalModuleBase
        Dim str() As String
        Private Sub LoadValue()
            litNew.Text = flCache.GetCache("HomeNews-HOME-NEWS-BOTTOM_" & Me.PortalId) & ""
            If litNew.Text = "" Then
                Dim objControler As New CmsController
                Dim obj As New CMS_NewsCategoriesInfo
                str = flCheck.SetupValue(Me.PortalId, "HOME-NEWS-BOTTOM").Split(";")
                For i As Integer = 0 To str.Length - 1
                    obj = objControler.CMS_NewsCategories_Get(Me.PortalId, flReg.WriteNumber(str(i)))
                    If IsNothing(obj) = False Then
                        litNew.Text += " <div class=""row pdt10"" style=""position: relative"">"
                        For Each Cr As CMS_NewsInfo In objControler.CMS_News_HomeBlock(Me.PortalId, Me.PortalId, HomeBlock.TinThuong, "", obj.CategoryID, 4, False)
                            litNew.Text += "<div class=""col-md-6"">"
                            litNew.Text += "<div class=""home-box-news"">"
                            litNew.Text += "<a title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                            litNew.Text += "<div class=""box-new-img"">"
                            litNew.Text += "<img alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 0, 125, True) & """ />"
                            litNew.Text += "</div>"
                            litNew.Text += "<p>" & Cr.Title & "</p>"
                            litNew.Text += "</a>"
                            litNew.Text += "</div>"
                            litNew.Text += "</div>"
                        Next
                    End If
                Next
                flCache.SetCache("HomeNews-HOME-NEWS-BOTTOM_" & Me.PortalId, litNew.Text, SecondCache.S2)
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadValue()
            End If
        End Sub
    End Class
End Namespace