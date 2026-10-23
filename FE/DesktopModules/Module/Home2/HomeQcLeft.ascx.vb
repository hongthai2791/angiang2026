Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules.Home
    Partial Class HomeQc
        Inherits Entities.Modules.PortalModuleBase

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call LoadValue()
            End If
        End Sub
        Private Sub LoadValue()
            Dim pgID As String = flCheck.SetupValue(Me.PortalId, "_HomeQcLeft")
            Dim TOP As Integer = flReg.WriteNumber(flCheck.SetupValue(Me.PortalId, "_HomeQc_Left"))
            Dim arr As ArrayList = New CmsController().CMS_Advertise_List_Home(PortalId, PortalId, pgID, 10)
            For Each item As CMS_AdvertiseInfo In arr
                If item.ImgType = 0 Then
                    litBus.Text += "<div class=""bd-hm-wb"">"
                    If item.IsURL <> "" Then
                        litBus.Text += "<a target=""" & item.Target & """ title=""" & flReg.ImgAlt(item.Advertise_Name) & """ href=""" & item.IsURL & """>"
                    Else
                        litBus.Text += "<a href=""javarscipt:;"" title=""" & flReg.ImgAlt(item.Advertise_Name) & """ >"
                    End If
                    litBus.Text += "<img src=""" & flReg.ImgSRC(item.Images, 200, 0, True) & """ alt=""" & flReg.ImgAlt(item.Advertise_Name) & """/></a>"
                    litBus.Text += "</div>"
                Else
                    litBus.Text += "<div class=""bd-hm-wb"">"
                    litBus.Text += "<object width=""" & item.IsWith & """ height=""" & item.IsHeight & """>"
                    litBus.Text += "<param name=""movie"" value=""" & item.Images & """ />"
                    litBus.Text += "<param name=""quality"" value=""high"" />"
                    litBus.Text += "<param name=""wmode"" value=""transparent"" /><param name=""flashvars"" />"
                    litBus.Text += "<embed src=""" & item.Images & """ quality=""high"" wmode=""transparent"""
                    litBus.Text += "type=""application/x-shockwave-flash"" width=""100%"" height=""100%"" >"
                    litBus.Text += "</embed></object>"
                    litBus.Text += "</div>"
                End If
            Next
        End Sub
    End Class
End Namespace