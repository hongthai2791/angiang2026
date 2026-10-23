<%@ WebHandler Language="VB" Class="medialist" %>
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Public Class medialist : Implements IHttpHandler

    Dim arr As New ArrayList
    Dim curpage, type, litList As String
    Dim objController As New CmsController
    Dim TotalPage As Integer
    Dim intK, PortalID As Integer
    Dim sSettings, arrStr() As String
    Dim UrlAlias As String = flReg.UrlAlias

    Public Function TrimSetting(str As String) As String
        arrStr = str.Replace(",,", "").Split(",")
        If arrStr.Length > 8 Then
            sSettings = ""
            For i As Integer = 0 To arrStr.Length - 1
                sSettings += arrStr(i) & ","
            Next
            Return sSettings.Substring(0, sSettings.LastIndexOf(","))
        Else
            Return str
        End If
    End Function

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Try
            curpage = flReg.WriteNumber(context.Request.Item("p"))
            PortalID = GetPortalSettings.PortalId
            type = context.Request.Item("t")
            If type = mediaType.Audio Then
                Call LoadAudio("")
            Else
                Call LoadVideo(0)
            End If
            context.Response.Write(litList)
        Catch ex As Exception
            context.Response.Write("")
        End Try

    End Sub
    Private Sub LoadAudio(sSettings As String)
        If IsNothing(flCache.GetCache("medialist_Audio_" & Me.PortalID & "_" & curpage)) Then
            arr = objController.CMS_Media_List_Home(PortalID, PortalID, flConnect.IsLang, sSettings, mediaType.Audio, curpage, 12)
            flCache.SetCache("medialist_Audio_" & Me.PortalID & "_" & curpage, arr, SecondCache.M3)
        Else
            arr = CType(flCache.GetCache("medialist_Audio_" & Me.PortalID & "_" & curpage), ArrayList)
        End If
        intK = 1
        For Each Cr As CMS_MediaInfo In arr
            litList += "<div class=""col-md-3 col-sm-6 col-xs-12 mgbt15"">"
            litList += "<div class=""row row5 lvideo-item"">"
            litList += "<a title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/audio/" & Cr.ToUrl & "-" & Cr.Id & ".html/p/" & curpage & """ class=""vhomelink videoItem"">"
            litList += "<div class=""col-md-12  col-sm-12 col-xs-4 col5 imgplayback"">"
            litList += "<div class=""i-img"">"
            litList += "<img alt=""" & flReg.ImgAlt(Cr.Name) & """ class=""w-item hotvimg-responsive"" src=""" & flReg.ImgSRC(Cr.Avatar, 270, 150, True) & """ /><i class=""fa fa-play-circle"" aria-hidden=""true""></i>"
            litList += "</div></div><div class=""col-md-12 col-sm-12 col-xs-8 col5"">"
            litList += "<div class=""lit-pubinfo"">"
            litList += "<i class=""fa fa-calendar-o""></i> "
            litList += flReg.ReadDate(Cr.PublishedDate)
            litList += "</div >"
            litList += "<div class=""rela-videoname"">"
            litList += Cr.Name & "</div></div></a><div class=""clear""></div></div></div>"
            If (intK Mod 2) = 0 Then
                litList += "<div class=""clear-xs""></div>"
            End If
            If (intK Mod 2) = 0 Then litList += "<div class=""clear-sm clear-xs""></div>"
            If (intK Mod 4) = 0 Then litList += "<div class=""clear""></div>"
            intK += 1
            If intK > 12 Then Exit For

        Next
        For Each Ci As CMS_MediaInfo In arr
            litList += "<div class=""clear""></div>"
            litList += flReg.NextPageJs(Ci.Total, 12, curpage, 5, "fnext(")
            Exit For
        Next
    End Sub
    Private Sub LoadVideo(totalSettings As Integer)
        If IsNothing(flCache.GetCache("medialist_Video_" & Me.PortalID & "_" & curpage)) Then
            arr = objController.CMS_Media_List_Home(PortalID, PortalID, flConnect.IsLang, "", mediaType.Video, curpage, 12 - totalSettings)
            flCache.SetCache("medialist_Video_" & Me.PortalID & "_" & curpage, arr, SecondCache.M3)
        Else
            arr = CType(flCache.GetCache("medialist_Video_" & Me.PortalID & "_" & curpage), ArrayList)
        End If
        intK = totalSettings + 1
        For Each Cr As CMS_MediaInfo In arr
            litList += "<div class=""col-md-3 col-sm-6 col-xs-12 mgbt15"">"
            litList += "<div class=""row row5 lvideo-item"">"
            litList += "<a title=""" & flReg.ImgAlt(Cr.Name) & """ href=""" & UrlAlias & "/video/" & Cr.ToUrl & "-" & Cr.Id & ".html/p/" & curpage & """ class=""vhomelink videoItem"">"
            litList += "<div class=""col-md-12  col-sm-12 col-xs-4 col5 imgplayback"">"
            litList += "<div class=""i-img"">"
            litList += "<img alt=""" & flReg.ImgAlt(Cr.Name) & """ class=""w-item hotvimg-responsive"" src=""" & flReg.ImgSRC(Cr.Avatar, 270, 150, True) & """ /><i class=""fa fa-play-circle"" aria-hidden=""true""></i>"
            litList += "</div></div><div class=""col-md-12 col-sm-12 col-xs-8 col5"">"
            litList += "<div class=""lit-pubinfo"">"
            litList += "<i class=""fa fa-calendar-o""></i> "
            litList += flReg.ReadDate(Cr.PublishedDate)
            litList += "</div >"
            litList += "<div class=""rela-videoname"">"
            litList += Cr.Name & "</div></div></a><div class=""clear""></div></div></div>"
            If (intK Mod 2) = 0 Then
                litList += "<div class=""clear-xs""></div>"
            End If
            If (intK Mod 2) = 0 Then litList += "<div class=""clear-sm clear-xs""></div>"
            If (intK Mod 4) = 0 Then litList += "<div class=""clear""></div>"
            intK += 1
            If intK > 12 Then Exit For
        Next
        For Each Ci As CMS_MediaInfo In arr
            litList += "<div class=""clear""></div>"
            litList += flReg.NextPageJs(Ci.Total, 12, curpage, 5, "fnext(")
            Exit For
        Next
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class