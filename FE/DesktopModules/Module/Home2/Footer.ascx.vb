Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.CMS
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

                For Each Cr As CMS_WebLinkInfo In New CmsController().CMS_WebLink_List(0, 0)
                    ltWeblink.Text += "<a  target='_blank' rel='nofollow' href='" & Cr.Url & "' title='" & Cr.Name & "'  class=""btn btn-link"">"
                    ltWeblink.Text += Cr.Name
                    ltWeblink.Text += "</a>"
                Next
                flCache.SetCache("Weblink_" & Me.PortalId, ltWeblink.Text, SecondCache.M10)
            End If
        End Sub
        Private Sub LoadFooter()
            If IsNothing(Session("OtherStatistic")) Then
                obStatic = wCtl.CMS_System_Statistic(Me.PortalId, 0, flReg.DateNull, flReg.DateNull, True)
                Session("OtherStatistic") = "<div class=""row-tke"">Đã truy cập:  <span> " & flReg.FormatPrice(obStatic.TongSoTruyCap) & "</span><div class=""clear""></div></div>"
                Session("OtherStatistic") += "<div class=""row-tke"" >Hồ sơ tìm việc: <span> " & flReg.FormatPrice(obStatic.HoSoTimViec) & "</span><div class=""clear""></div></div>"
                Session("OtherStatistic") += "<div class=""row-tke"">Nhà tuyển dụng: <span> " & flReg.FormatPrice(obStatic.NhaTuyenDung) & "</span><div class=""clear""></div></div>"
                Session("OtherStatistic") += "<div class=""row-tke"" >Tin tuyển dụng: <span> " & flReg.FormatPrice(obStatic.TinTuyenDung) & "</span><div class=""clear""></div></div>"
                OtherStatistic.Text = Session("OtherStatistic")
            Else
                OtherStatistic.Text = Session("OtherStatistic")
            End If
            litNTD_Hotline.Text = flCheck.SetupValue(0, "NTD_Hotline").Replace(";", "<br/>")
            litNLD_Hotline.Text = flCheck.SetupValue(0, "NLD_Hotline").Replace(";", "<br/>")
            litFooter.Text = "" 'flCache.GetCache("FooterLogo_" & Me.PortalId) & ""
            litFanpage.Text = flCache.GetCache("FooterFanpage_" & Me.PortalId) & ""
            If litFooter.Text = "" Or litFanpage.Text = "" Then
                arr = New CmsController().CMS_Infomation_List(PortalId, PortalId)
                If arr.Count = 0 Then arr = New CmsController().CMS_Infomation_List(0, 0)

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
                flCache.SetCache("FooterLogo_" & Me.PortalId, litFooter.Text)
                flCache.SetCache("FooterFanpage_" & Me.PortalId, litFanpage.Text)
            End If
            '' Load ChatBot
            If IsNothing(Session("lblLoadChatBot")) Then
                Dim listThietLapGT As List(Of HT_ThietLapInfo)
                listThietLapGT = flChatBot.HT_ThietLap_List(Me.PortalId)
                If listThietLapGT.Count() > 0 Then
                    Dim itemChat = listThietLapGT.Where(Function(x) x.MaThietLap = flMaThietLap.APPWEB).ToList()
                    If itemChat.Count > 0 Then
                        Session("lblLoadChatBot") = listThietLapGT.Find(Function(x) x.MaThietLap = flMaThietLap.APPWEB).GiaTri
                        lblLoadChatBot.Text = listThietLapGT.Find(Function(x) x.MaThietLap = flMaThietLap.APPWEB).GiaTri
                    End If
                    Dim itemAuto = listThietLapGT.Where(Function(x) x.MaThietLap = flMaThietLap.ISOPENCHAT).ToList()
                    If itemChat.Count > 0 Then
                        Dim iOpen = listThietLapGT.Find(Function(x) x.MaThietLap = flMaThietLap.ISOPENCHAT).GiaTri
                        Session("ChatBotAuto") = IIf(iOpen <> "True", 0, 1)
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "openchatbot(i)", "openchatbot(" & IIf(iOpen <> "True", 0, 1) & ")", True)
                    End If
                End If
            Else
                lblLoadChatBot.Text = Session("lblLoadChatBot")
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "openchatbot(i)", "openchatbot(" & Session("ChatBotAuto") & ")", True)
            End If

        End Sub
        'Private Sub cndReg_ServerClick(sender As Object, e As EventArgs) Handles cndReg.ServerClick
        '    If VbCapchar.IsValid Then
        '        wCtl.CMS_RegEmail_Add(Me.PortalId, flReg.GenKey(), txtEmail.Text.Trim(), Now)
        '        Dim myCookie As HttpCookie = New HttpCookie("RegEmailSend")
        '        myCookie.Values.Add("val", txtEmail.Text.Trim())
        '        myCookie.Expires = Now.AddDays(7)
        '        Response.Cookies.Add(myCookie)
        '        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "success_0", " notify('success', 'Bạn đã đăng ký nhận tin thông báo thành công', 'Thông báo', false);", True)
        '    End If
        'End Sub
        'Protected Sub btnCloseSession_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseSession.Click
        '    Session("ChatBotAuto") = 0
        'End Sub
        'Protected Sub btnOpenSession_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOpenSession.Click
        '    Session("ChatBotAuto") = 1
        'End Sub
    End Class
End Namespace

