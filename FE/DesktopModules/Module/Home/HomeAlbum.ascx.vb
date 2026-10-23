Imports DotNetNuke.Entities.Modules
Imports DotnetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class HomeAlbum
        Inherits PortalModuleBase
        Dim i As Integer
        Dim arrMedia As New ArrayList
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                litAlbum.Text = flCache.GetCache("HomeAlbum_" & Me.PortalId) & ""
                If litAlbum.Text = "" Then
                    For Each Cr As CMS_NewsInfo In New CmsController().CMS_News_HomeBlock(Me.PortalId, Me.PortalId, HomeBlock.PhongSuAnh, "", 3676, 5, True)
                        For Each Ck As CMS_MediaInfo In New CmsController().CMS_Media_Get_By_News_ID(Cr.PortalId, Cr.NewId)
                            arrMedia.Add(Ck)
                        Next
                    Next
                    If arrMedia.Count >= 0 Then
                        For j = arrMedia.Count - 1 To 0 Step -1
                            litAlbum.Text += "<div class=""item"">"
                            litAlbum.Text += "<div class=""col-md-12""><img src=""" & flConnect.fileDomain & arrMedia(j).Avatar & """ alt=""" & flReg.ImgAlt(flReg.RemoveScript(arrMedia(j).Contents, False)) & """/></div>"
                            litAlbum.Text += "<div class=""col-md-12""><img src=""" & flConnect.fileDomain & arrMedia(j - 1).Avatar & """ alt=""" & flReg.ImgAlt(flReg.RemoveScript(arrMedia(j - 1).Contents, False)) & """/></div>"
                            litAlbum.Text += "</div>"
                            j = j - 1
                        Next
                    End If

                    flCache.SetCache("HomeAlbum_" & Me.PortalId, litAlbum.Text, SecondCache.M1)
                End If
            End If
        End Sub
    End Class
End Namespace

