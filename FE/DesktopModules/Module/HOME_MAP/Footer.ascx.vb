Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.MAP
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CHATBOT

Namespace DesktopModules.Home
    Partial Class Footer
        Inherits PortalModuleBase
        Dim wCtl As New WORK.WorkController
        Dim arr As New ArrayList
        Dim obStatic As New WORK.CMS_SysStatisticInfo
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    Call LoadFooter()
                    Call LoadWeblink()
                End If
            Catch ex As Exception
                litFooter.Text = ex.Message
            End Try
        End Sub
        Private Sub LoadWeblink()
            ltWeblink.Text = "" ' flCache.GetCache("Weblink_" & Me.PortalId) & ""
            If ltWeblink.Text = "" Then

                For Each Cr As LienKetInfo In New MapController().LienKet_List(Me.PortalId)
                    ltWeblink.Text += "<div class=""item "">"
                    ltWeblink.Text += "<a  target='_blank' rel='nofollow' href='" & Cr.LinkURL & "' title='" & Cr.TenLienKet & "' >"
                    ltWeblink.Text += Cr.TenLienKet
                    ltWeblink.Text += "</a>"
                    ltWeblink.Text += "</div>"
                Next
                flCache.SetCache("Weblink_" & Me.PortalId, ltWeblink.Text, SecondCache.M10)
            End If
        End Sub
        Private Sub LoadFooter()
            If IsNothing(Session("OtherStatistic")) Then
                obStatic = wCtl.CMS_System_Statistic(Me.PortalId, 0, flReg.DateNull, flReg.DateNull, True)
                Session("OtherStatistic") = "<div class=""row-tke"">Đã truy cập:  <span> " & flReg.FormatPrice(obStatic.TongSoTruyCap) & "</span><div class=""clear""></div></div>"
                OtherStatistic.Text = Session("OtherStatistic")
            Else
                OtherStatistic.Text = Session("OtherStatistic")
            End If
            litFooter.Text = "" 'flCache.GetCache("FooterLogo_" & Me.PortalId) & ""
            litFanpage.Text = flCache.GetCache("MAP_FooterFanpage_" & Me.PortalId) & ""
            If litFooter.Text = "" Or litFanpage.Text = "" Then
                arr = New MapController().CMS_Infomation_List(PortalId, PortalId)
                If arr.Count = 0 Then arr = New MapController().CMS_Infomation_List(0, 0)

                For Each Cr As CMS_InfomationInfo In arr
                    litFooter.Text = "<div class="" col-md-12"">"
                    litFooter.Text += "<div class="" foot-lienhe"">"
                    litFooter.Text += Cr.Footer
                    litFooter.Text += " </div>"
                    litFooter.Text += " </div>"
                    litFanpage.Text = "<div class="" fb-page"" data-href=""" & Cr.NameH2 & """ data-small-header="" False"" data-adapt-container-width="" True"" data-hide-cover="" False"" data-show-facepile="" False"">"
                    litFanpage.Text += "<blockquote cite=""" & Cr.NameH2 & """ class="" fb-xfbml-parse-ignore"">"
                    litFanpage.Text += "<a title=""" & flReg.RemoveScript(Cr.NameH1, False) & """ rel="" nofollow"" target="" _blank"" href=""" & Cr.NameH2 & """>" & flReg.RemoveScript(Cr.NameH1, False) & "</a>"
                    litFanpage.Text += "</blockquote></div>"
                    Exit For
                Next
                flCache.SetCache("MAP_FooterLogo_" & Me.PortalId, litFooter.Text)
                flCache.SetCache("MAP_FooterFanpage_" & Me.PortalId, litFanpage.Text)
            End If

        End Sub

    End Class
End Namespace

