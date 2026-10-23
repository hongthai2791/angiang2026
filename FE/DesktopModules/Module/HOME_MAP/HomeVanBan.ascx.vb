Imports DotNetNuke.EPORTAL
Imports DotnetNuke.CMS

Namespace DesktopModules.Modules.Home
    Partial Class HomeBanner
        Inherits Entities.Modules.PortalModuleBase
        Dim str() As String
        Dim strTB, strDes As String
        Dim obj As New CMS_NewsCategoriesInfo
        Dim objControler As New CmsController
        Private Sub LoadNews()
            litNew.Text = "" ' flCache.GetCache("HomeNews2-HOME-NEWS2-BOTTOM_" & Me.PortalId) & ""
            If litNew.Text = "" Then
                Dim objControler As New CmsController
                Dim obj As New CMS_NewsCategoriesInfo
                str = flCheck.SetupValue(Me.PortalId, "HOME-NEWS2-BOTTOM").Split(";")
                For i As Integer = 0 To str.Length - 1
                    obj = objControler.CMS_NewsCategories_Get(Me.PortalId, flReg.WriteNumber(str(i)))
                    If IsNothing(obj) = False Then
                        litNew.Text += " <div class=""row"">"
                        For Each Cr As CMS_NewsInfo In objControler.CMS_News_HomeBlock(Me.PortalId, Me.PortalId, HomeBlock.TinThuong, "", 3691, 10, False)
                            litNew.Text += "<div class=""col-md-12 box-news"">"
                            litNew.Text += "<div class=""imgbox text-center"">"
                            litNew.Text += "<a title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                            litNew.Text += "<img alt=""" & flReg.ImgAlt(Cr.Title) & """ src=""" & flReg.ImgSRC(Cr.ImagePath, 90, 65, True) & """ />"
                            litNew.Text += "</a>"
                            litNew.Text += "</div>"
                            litNew.Text += "<div class="" contents-news"">"
                            litNew.Text += "<div class=""title"">"
                            litNew.Text += "<a title=""" & flReg.ImgAlt(Cr.Title) & """ href=""" & Ultis.FormatLink(Me.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & """>"
                            litNew.Text += flReg.Trimstr(Cr.Title, 60)
                            litNew.Text += "</a>"
                            litNew.Text += "</div>"
                            litNew.Text += "<div class=""summary"">"
                            litNew.Text += flReg.Trimstr(Cr.Summary, 100)
                            litNew.Text += "</div>"
                            litNew.Text += "</div>"
                            litNew.Text += "<div class=""clear""></div>"
                            litNew.Text += "</div>"
                        Next
                        litNew.Text += " <div class=""clear"">"
                        litNew.Text += " </div>"
                        litNew.Text += " </div>"
                    End If
                Next
                'flCache.SetCache("HomeNews2-HOME-NEWS2-BOTTOM_" & Me.PortalId, litNew.Text, SecondCache.S2)
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadNews()
            End If
        End Sub

    End Class
End Namespace