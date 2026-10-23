Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Media.Display.Control
    Partial Class VideoList
        Inherits DotNetNuke.Entities.Modules.PortalModuleBase
        Public strFb As String
        Dim objController As New CmsController
        Dim arr As New ArrayList
        Dim intK, indexJ, total As Integer
        Dim vInfo, obj As CMS_MediaInfo
        Dim UrlAlias As String = flReg.UrlAlias

        Private Sub LoadDB()
            arr = objController.CMS_Media_List_Home(PortalId, PortalId, flConnect.IsLang, "", mediaType.Video, currPage.Value, 12)
            For Each Cr As CMS_MediaInfo In arr
                If Cr.Id <> ItemID.Value Then
                    litVideoList.Text += "<div class=""col-md-3  col-sm-6 col-xs-12 mgbt15"">"
                    litVideoList.Text += "<div class=""row row5 lvideo-item"">"
                    litVideoList.Text += "<a title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/video-gioi-thieu/" & Cr.ToUrl & "-" & Cr.Id & ".html/p/" & currPage.Value & """ class=""vhomelink videoItem"">"
                    litVideoList.Text += "<div class=""col-md-12 col-sm-12 col-xs-4 col5 imgplayback"">"
                    litVideoList.Text += "<div class=""i-img"">"
                    litVideoList.Text += "<img class=""w-item hotvimg-responsive"" alt=""" & flReg.ImgAlt(Cr.Name) & """ src=""" & flReg.ImgSRC(Cr.Avatar, 270, 150, True) & """ /><i class=""fa fa-play-circle"" aria-hidden=""true""></i>"
                    litVideoList.Text += "</div></div><div class=""col-md-12 col-sm-12 col-xs-8 col5"">"
                    litVideoList.Text += "<div class=""lit-pubinfo"">"
                    litVideoList.Text += "<i class=""fa fa-calendar-o""></i> "
                    litVideoList.Text += flReg.ReadDate(Cr.PublishedDate)
                    litVideoList.Text += "</div >"
                    litVideoList.Text += "<div class=""rela-videoname"">"
                    litVideoList.Text += Cr.Name & "</div></div></a><div class=""clear""></div></div></div>"
                    If (intK Mod 2) = 0 Then
                        litVideoList.Text += "<div class=""clear-xs""></div>"
                    End If
                    total = Cr.Total
                    If (intK Mod 2) = 0 Then litVideoList.Text += "<div class=""clear-sm clear-xs""></div>"
                    If (intK Mod 4) = 0 Then litVideoList.Text += "<div class=""clear""></div>"
                    intK += 1
                    If intK > 12 Then Exit For
                End If
            Next
            litVideoList.Text += "<div class=""clear""></div>"
            litVideoList.Text += flReg.NextPageJs(total, 12, currPage.Value, 5, "fnext(")

            If ItemID.Value <> 0 Then
                Call PlayVideo(ItemID.Value)
                objController.CMS_Update_View(Me.PortalId, "Media", ItemID.Value)
                indexJ = 0
                Exit Sub
            Else
                For Each Ci As CMS_MediaInfo In arr
                    Call PlayVideo(Ci.Id)
                    objController.CMS_Update_View(Me.PortalId, "Media", Ci.Id)
                    indexJ = 1
                    Exit Sub
                Next
            End If
        End Sub
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                If Not Page.IsPostBack Then
                    vUrl.Value = Request.RawUrl
                    If vUrl.Value.Contains("/p/") Then
                        vUrl.Value = vUrl.Value.Substring(0, vUrl.Value.LastIndexOf("/p/"))
                        currPage.Value = flReg.WriteNumber(flCheck.RequestItem(Request.RawUrl, "p"))
                    End If
                    If currPage.Value = 0 Then currPage.Value = 1
                    ItemID.Value = flReg.WriteNumber(Ultis.GetRequestId(vUrl.Value))

                    intK = 1
                    Call LoadDB()
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub PlayVideo(id As String)
            vInfo = objController.CMS_Media_Get(PortalId, id)
            litVideoPlay.Text = ""
            If IsNothing(vInfo) = False Then
                strFb = flReg.UrlAlias & "/video/" & vInfo.ToUrl & "-" & vInfo.Id

                If vInfo.IsYoutube Then
                    Left_panel.Visible = False

                    litVideoPlay.Text = "<div class=""col-md-8 col-xs-12""><div class=""video-wrap""><div class=""video""><object id=""flvplayer"" wmode=""transparent"" type=""application/x-shockwave-flash"" allowfullscreen=""True"""
                    litVideoPlay.Text += " data=""http://www.youtube.com/v/" & vInfo.MediaUrl & "&hl=en&fs=1&autoplay=1&rel=0"" width=""100%"" height=""410""></object></div></div></div>"

                    litVideoPlay.Text += "<div class=""col-md-4 col-xs-12""><div class=""x-vhottitle""><h1>" & vInfo.Name & "</h1>"
                    litVideoPlay.Text += "<div class=""lit-pubinfo"" style=""padding:5px 0;"">"
                    litVideoPlay.Text += "<i class=""fa fa-calendar-o"" style=""padding-right:10px;""></i>" & vInfo.PublishedDate.ToString("dd/MM/yyyy HH:mm") & ""
                    litVideoPlay.Text += "</div >"
                    If vInfo.Contents & "" <> "" Then 'Relate news
                        Dim itemLink As String() = vInfo.Contents.Split(";")
                        litVideoPlay.Text += "<div class=""post-relate"">"
                        For i As Integer = 0 To itemLink.Length - 1
                            obj = objController.CMS_Media_Get(PortalId, flReg.WriteNumber(itemLink(i)))
                            If IsNothing(obj) = False Then
                                litVideoPlay.Text += "<a title=""" & flReg.ImgAlt(obj.Name) & """ href=""" & UrlAlias & "/video/" & obj.ToUrl & "-" & obj.Id & ".html/p/" & currPage.Value & """ >"
                                litVideoPlay.Text += "<h3 class=""tin-lien-quan""><span>" & obj.Name & "</span></h3></a>"
                            End If
                        Next
                        litVideoPlay.Text += "</div>"
                    End If
                    litVideoPlay.Text += "<span>" & vInfo.Summary & "</span></div>"


                    'START SOCIAL
                    litVideoPlay.Text += "<div style=""float:Right; margin-right: 5px; margin-top: 5px; height: 20px"">"
                    litVideoPlay.Text += "<div class=""zalo-share-button"" style=""margin-left: 3px;"" data-href=""" & strFb & """ data-oaid=""579745863508352884"" data-layout=""1"" data-color=""blue"" data-customize=""false""></div>"
                    litVideoPlay.Text += "</div>"

                    litVideoPlay.Text += "<div style=""float: Right; margin-top: 5px"" class=""fb-share-button"" data-href=""" & strFb & """ data-layout=""button_count"" data-size=""small"" data-mobile-iframe=""true"">"
                    litVideoPlay.Text += "<a class=""fb-xfbml-parse-ignore"" target=""_blank"" href=""https//www.facebook.com/sharer/sharer.php?u=" & strFb & "&amp;src=sdkpreparse"">Chia sẻ</a>"
                    litVideoPlay.Text += "</div>"

                    litVideoPlay.Text += "<div style=""float: Right; margin-top: 5px; margin-right: 5px;"" class=""fb-like"" data-href=""" & strFb & """ data-layout=""button_count"" data-action=""like"" data-show-faces=""false"" data-share=""false""></div>"

                    litVideoPlay.Text += "<div style=""float:Right; margin-right: 5px; margin-top: 5px; height: 20px"">"
                    litVideoPlay.Text += "<div class=""g-plusone"" data-size=""medium""></div>"
                    litVideoPlay.Text += "</div>"
                    'END SOCIAL

                    litVideoPlay.Text += "</div>"
                    '_PlayVideo.Visible = False
                Else
                    If flReg.GetFileType(vInfo.MediaUrl, ".") = "mp4" Then

                        fileVideo.Text = "<source src=""" & flConnect.fileDomain & vInfo.MediaUrl & """ type=""video/mp4"" /> "

                        litVideoPlay.Text += "<div class=""col-md-4 col-xs-12""><div class=""x-vhottitle""><h1>" & vInfo.Name & "</h1>"
                        litVideoPlay.Text += "<div class=""lit-pubinfo"" style=""padding:5px 0;"">"
                        litVideoPlay.Text += "<i class=""fa fa-calendar-o"" style=""padding-right:10px;""></i>" & flReg.ReadDate(vInfo.PublishedDate) & ""
                        litVideoPlay.Text += "</div>"
                        If vInfo.Contents & "" <> "" Then 'Relate news
                            Dim obj As New CMS_MediaInfo
                            Dim itemLink As String() = vInfo.Contents.Split(";")
                            litVideoPlay.Text += "<div class=""post-relate"">"
                            For i As Integer = 0 To itemLink.Length - 1
                                obj = objController.CMS_Media_Get(PortalId, flReg.WriteNumber(itemLink(i)))
                                If IsNothing(obj) = False Then
                                    litVideoPlay.Text += "<a title=""" & flReg.ImgAlt(obj.Name) & """ href=""" & UrlAlias & "/video/" & obj.ToUrl & "-" & obj.Id & ".html/p/" & currPage.Value & """ >"
                                    litVideoPlay.Text += "<h3 class=""tin-lien-quan""><span>" & obj.Name & "</span></h3></a>"
                                End If
                            Next
                            litVideoPlay.Text += "</div>"
                        End If
                        litVideoPlay.Text += "<span>" & vInfo.Summary & "</span></div>"

                        'START SOCIAL
                        litVideoPlay.Text += "<div style=""float:Right; margin-right: 5px; margin-top: 5px; height: 20px"">"
                        litVideoPlay.Text += "<div class=""zalo-share-button"" style=""margin-left: 3px;"" data-href=""" & strFb & """ data-oaid=""579745863508352884"" data-layout=""1"" data-color=""blue"" data-customize=""false""></div>"
                        litVideoPlay.Text += "</div>"

                        litVideoPlay.Text += "<div style=""float: Right; margin-top: 5px"" class=""fb-share-button"" data-href=""" & strFb & """ data-layout=""button_count"" data-size=""small"" data-mobile-iframe=""true"">"
                        litVideoPlay.Text += "<a class=""fb-xfbml-parse-ignore"" target=""_blank"" href=""https//www.facebook.com/sharer/sharer.php?u=" & strFb & "&amp;src=sdkpreparse"">Chia sẻ</a>"
                        litVideoPlay.Text += "</div>"

                        litVideoPlay.Text += "<div style=""float: Right; margin-top: 5px; margin-right: 5px;"" class=""fb-like"" data-href=""" & strFb & """ data-layout=""button_count"" data-action=""like"" data-show-faces=""false"" data-share=""false""></div>"

                        litVideoPlay.Text += "<div style=""float:Right; margin-right: 5px; margin-top: 5px; height: 20px"">"
                        litVideoPlay.Text += "<div class=""g-plusone"" data-size=""medium""></div>"
                        litVideoPlay.Text += "</div>"
                        'END SOCIAL

                        litVideoPlay.Text += "</div>"
                    Else
                        Dim fileExtend As String = vInfo.MediaUrl.Split(".").Last
                        fileVideo.Text = "<source src=""" & flConnect.fileDomain & vInfo.MediaUrl & """ type=""video/" + fileExtend + """ /> "

                        litVideoPlay.Text += "<div class=""col-md-4 col-xs-12""><div class=""x-vhottitle""><h1>" & vInfo.Name & "</h1>"
                        litVideoPlay.Text += "<div class=""lit-pubinfo"" style=""padding:5px 0;"">"
                        litVideoPlay.Text += "<i class=""fa fa-calendar-o"" style=""padding-right:10px;""></i>" & vInfo.PublishedDate.ToString("dd/MM/yyyy HH:mm") & ""
                        litVideoPlay.Text += "</div >"

                        If vInfo.Contents & "" <> "" Then 'Relate news
                            Dim itemLink As String() = vInfo.Contents.Split(";")
                            litVideoPlay.Text += "<div class=""post-relate"">"
                            For i As Integer = 0 To itemLink.Length - 1
                                obj = objController.CMS_Media_Get(PortalId, flReg.WriteNumber(itemLink(i)))
                                If IsNothing(obj) = False Then
                                    litVideoPlay.Text += "<a title=""" & flReg.ImgAlt(obj.Name) & """ href=""" & UrlAlias & "/video/" & obj.ToUrl & "-" & obj.Id & ".html/p/" & currPage.Value & """ >"
                                    litVideoPlay.Text += "<h3 class=""tin-lien-quan""><span>" & obj.Name & "</span></h3></a>"
                                End If
                            Next
                            litVideoPlay.Text += "</div>"
                        End If

                        litVideoPlay.Text += "<span>" & vInfo.Summary & "</span>"
                        litVideoPlay.Text += "</div>"

                        'START SOCIAL
                        litVideoPlay.Text += "<div style=""float:Right; margin-right: 5px; margin-top: 5px; height: 20px"">"
                        litVideoPlay.Text += "<div class=""zalo-share-button"" style=""margin-left: 3px;"" data-href=""" & strFb & """ data-oaid=""579745863508352884"" data-layout=""1"" data-color=""blue"" data-customize=""false""></div>"
                        litVideoPlay.Text += "</div>"

                        litVideoPlay.Text += "<div style=""float: Right; margin-top: 5px"" class=""fb-share-button"" data-href=""" & strFb & """ data-layout=""button_count"" data-size=""small"" data-mobile-iframe=""true"">"
                        litVideoPlay.Text += "<a class=""fb-xfbml-parse-ignore"" target=""_blank"" href=""https//www.facebook.com/sharer/sharer.php?u=" & strFb & "&amp;src=sdkpreparse"">Chia sẻ</a>"
                        litVideoPlay.Text += "</div>"

                        litVideoPlay.Text += "<div style=""float: Right; margin-top: 5px; margin-right: 5px;"" class=""fb-like"" data-href=""" & strFb & """ data-layout=""button_count"" data-action=""like"" data-show-faces=""false"" data-share=""false""></div>"

                        litVideoPlay.Text += "<div style=""float:Right; margin-right: 5px; margin-top: 5px; height: 20px"">"
                        litVideoPlay.Text += "<div class=""g-plusone"" data-size=""medium""></div>"
                        litVideoPlay.Text += "</div>"
                        'END SOCIAL

                        litVideoPlay.Text += "</div>"
                    End If
                End If
                flReg.LoadBasePage(Me.Page, vInfo.Name, vInfo.Name, flReg.RemoveHTML(vInfo.Summary), vInfo.PublishedDate, flReg.UrlAlias & "/video/" & vInfo.ToUrl & "-" & vInfo.Id & ".html", flConnect.fileDomain & vInfo.Avatar)
            End If
        End Sub
    End Class
End Namespace