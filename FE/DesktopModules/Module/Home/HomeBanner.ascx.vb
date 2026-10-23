Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules.Home
	Partial Class HomeBanner
		Inherits Entities.Modules.PortalModuleBase
		Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
			If Not Page.IsPostBack Then
				Call LoadValues()
			End If
		End Sub
		Private Sub LoadValues()
			litBus.Text = flCache.GetCache("HomeBanner_" & Me.TabModuleId & "_" & Me.PortalId) & ""
			If litBus.Text = "" Then
				Dim pgID As String = flCheck.SetupValue(Me.PortalId, Me.TabModuleId & "_HomeBanner")
				Dim TOP As Integer = flReg.WriteNumber(flCheck.SetupValue(Me.PortalId, Me.TabModuleId & "_HomeBanner_TOP"))
				Dim iSlide As Integer = flReg.WriteNumber(flCheck.SetupValue(Me.PortalId, Me.TabModuleId & "_HomeBanner_SLIDE"))
				If iSlide > 3 Then
					litBus.Text = "<div class=""owl-carousel owl-theme hbanner"" id=""owl-HomeBanner" & Me.TabModuleId & """>"
				ElseIf iSlide > 1 Then
					litBus.Text = "<div class=""owl-carousel owl-theme mbanner"" id=""owl-HomeBanner" & Me.TabModuleId & """>"
				Else
					litBus.Text = "<div class=""owl-carousel owl-theme"" id=""owl-HomeBanner" & Me.TabModuleId & """>"
				End If
				Dim arr As ArrayList = New CmsController().CMS_Advertise_List_Home(PortalId, PortalId, pgID, TOP)
				For Each item As CMS_AdvertiseInfo In arr
					litBus.Text += "<div class=""item"">"
					litBus.Text += "<div class=""row""><div class=""col-md-12"">"
					If item.ImgType = 0 Then
						litBus.Text += "<div class=""bd-hm-wb"">"
						If item.IsURL <> "" Then
							litBus.Text += "<a target=""" & item.Target & """ title=""" & flReg.ImgAlt(item.Advertise_Name) & """ href=""" & item.IsURL & """>"
						Else
							litBus.Text += "<a href=""javarscipt:;"" title=""" & flReg.ImgAlt(item.Advertise_Name) & """ >"
						End If
						litBus.Text += "<img src=""" & flReg.ImgSRC(item.Images, 0, 0, True) & """ alt=""" & flReg.ImgAlt(item.Advertise_Name) & """/></a>"
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
					litBus.Text += "</div></div>"
					litBus.Text += "</div>"
				Next
				litBus.Text += "</div>"
				If arr.Count > 1 Then
					litBus.Text += "<div class=""i-control"">"
					litBus.Text += "<span id=""prev-HomeBanner" & Me.TabModuleId & """ class=""prev-HomeBanner""><i class=""fa fa-angle-left"" aria-hidden=""true""></i></span>"
					litBus.Text += "<span id=""next-HomeBanner" & Me.TabModuleId & """ class=""next-HomeBanner""><i class=""fa fa-angle-right"" aria-hidden=""true""></i></span>"
					litBus.Text += "</div>"
				End If

				If iSlide > 0 Then
					litBus.Text += "<script type=""text/javascript"">"
					litBus.Text += "$(document).ready(function () {"
					litBus.Text += "var osb" & Me.TabModuleId & " = $('#owl-HomeBanner" & Me.TabModuleId & "');"
					litBus.Text += "osb" & Me.TabModuleId & ".owlCarousel({"
					litBus.Text += "autoplay: true, autoplayTimeout: 5500, nav: false, loop: true, dots: false, pagination: false,"
					litBus.Text += "responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: " & iSlide & " } }"
					litBus.Text += "});"
					litBus.Text += "$('#prev-HomeBanner" & Me.TabModuleId & "').click(function () { osb" & Me.TabModuleId & ".trigger('prev.owl.carousel'); });"
					litBus.Text += "$('#next-HomeBanner" & Me.TabModuleId & "').click(function () { osb" & Me.TabModuleId & ".trigger('next.owl.carousel'); });"
					litBus.Text += "});"
					litBus.Text += "</script>"
				End If

				flCache.SetCache("HomeBanner_" & Me.TabModuleId & "_" & Me.PortalId, litBus.Text, SecondCache.M60)
			End If
		End Sub

	End Class
End Namespace