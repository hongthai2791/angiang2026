Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Home
    Partial Class HomeWorks
        Inherits Entities.Modules.PortalModuleBase
        Dim objContrller As New WorkController
        Dim arr As New ArrayList
        Dim intI As Integer, Str As String
        Private Sub InitContrller()
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = 0 Then currPage.Value = 1

            Call flFunction.LoadCareer(Me.PortalId, NganhNghe, "Tất cả Ngành nghề")
            If Request.Item("car") & "" <> "" Then NganhNghe.SelectedValue = Request.Item("car")

            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "ALL", "")
            'If flReg.WebConfig("TinhTP") <> "0" Then TinhTP.SelectedValue = flReg.WebConfig("TinhTP")
            If Request.Item("tp") & "" <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadSex(GioiTinh, "Tất cả Giới tính")
            If Request.Item("sex") & "" <> "" Then GioiTinh.SelectedValue = Request.Item("sex")

            Call flDic.LoadEducation(Me.PortalId, TrinhDo, "Tất cả Trình độ")
            If Request.Item("lev") & "" <> "" Then TrinhDo.SelectedValue = Request.Item("lev")

            Call flFunction.LoadJobPlace(Me.PortalId, ViTri, "Tất cả Vị trí")
            If Request.Item("poi") & "" <> "" Then ViTri.SelectedValue = Request.Item("poi")

            Call flFunction.LoadSalary(Me.PortalId, MucLuong, "Tất cả Mức lương")
            If Request.Item("sar") & "" <> "" Then MucLuong.SelectedValue = Request.Item("sar")

            Call flFunction.LoadExperience(Me.PortalId, KinhNghiem, "Tất cả Kinh nghiệm")
            If Request.Item("ex") & "" <> "" Then KinhNghiem.SelectedValue = Request.Item("ex")

            txtSearch.Attributes.Add("onkeypress", "return clickButton(event,'" + cmdSearch.ClientID + "')")
            txtSearch.Text = flReg.RequestSearch(Request.RawUrl)
        End Sub
        Private Sub HomeWorks_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                Call InitContrller()
                Call LoadList()
            End If
        End Sub
        Private Function RedirectURL() As String
            RedirectURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If NganhNghe.SelectedValue <> "" Then RedirectURL += "/car/" & NganhNghe.SelectedValue
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If GioiTinh.SelectedValue <> "-1" Then RedirectURL += "/sex/" & GioiTinh.SelectedValue
            If TrinhDo.SelectedValue <> "" Then RedirectURL += "/lev/" & TrinhDo.SelectedValue
            If ViTri.SelectedValue <> "" Then RedirectURL += "/poi/" & ViTri.SelectedValue
            If MucLuong.SelectedValue <> "" Then RedirectURL += "/sar/" & MucLuong.SelectedValue
            If KinhNghiem.SelectedValue <> "" Then RedirectURL += "/ex/" & KinhNghiem.SelectedValue
            If txtSearch.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtSearch.Text.Trim())
        End Function
        Private Sub LoadHot()
            arr = objContrller.CMS_Work_List_Pages(Me.PortalId, 1, 4, NganhNghe.SelectedValue, flReg.WriteNumber(TinhTP.SelectedValue), TrinhDo.SelectedValue, ViTri.SelectedValue,
                                                   MucLuong.SelectedValue, KinhNghiem.SelectedValue, flReg.WriteStringLess(GioiTinh.SelectedValue), CMS.Ultis.FullTextSearch(txtSearch.Text, False), 1)
            If arr.Count > 0 Then
                intI = 1
                litHot.Text = "<div class=""box_tab "">"
                litHot.Text += "<h2 class=""title_text_line""><span class=""text-tim-nhat"">Tuyển gấp</span></h2>"
                For Each Cr As CMS_WorkInfo In arr
                    litHot.Text += "<div class=""col-md-6"">"
                    litHot.Text += "<div class=""col-md-3"">"
                    litHot.Text += "<a href=""" & flCheck.GetHomeLinkWork(Cr.Title, Cr.ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>"
                    litHot.Text += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(Cr.PortalID, Cr.Business_ID), 120) & """ alt=""" & flReg.ImgAlt(Cr.Title) & """ />"
                    litHot.Text += "</a>"
                    litHot.Text += "</div>"
                    litHot.Text += "<div class=""col-md-9"">"
                    litHot.Text += "<div class=""col-md-12 pdl0"">"
                    litHot.Text += "<a href=""" & flCheck.GetHomeLinkWork(Cr.Title, Cr.ID) & """ class=""text_grey2"">" & Cr.Title & "</a>"
                    litHot.Text += "</div>"
                    litHot.Text += "<div class=""clear""></div>"
                    litHot.Text += "<div class=""col-md-12 pdl0"">"
                    litHot.Text += "<a href=""" & flCheck.GetHomeLinkBusiness(Cr.Business_ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>" & flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID) & "</a>"
                    litHot.Text += "</div>"
                    litHot.Text += "<div class=""clear""></div>"
                    litHot.Text += "<div class=""col-md-4 pdl0"">"
                    litHot.Text += "<i class=""icon-money icon_16""></i>"
                    litHot.Text += "<div class=""pl_28"">" & flCheck.Salary_Name(Me.PortalId, Cr.Salary_ID) & "</div>"
                    litHot.Text += "</div>"
                    litHot.Text += "<div class=""col-md-4 pl0 pdr0"">"
                    litHot.Text += "<i class=""icon-address icon_16""></i>"
                    litHot.Text += "<div class=""pl_28 lsaddress"">" & flDic.RegionalName(Cr.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "TP.") & "</div>"
                    litHot.Text += "</div>"
                    litHot.Text += "<div class=""col-md-4 pl0 pdr0"">"
                    litHot.Text += "<i class=""icon-countdown icon_16""></i>"
                    litHot.Text += "<div class=""pl_28"">" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
                    litHot.Text += "</div>"
                    litHot.Text += "<div class=""clear""></div>"
                    litHot.Text += "</div>"
                    If intI < arr.Count Then litHot.Text += "<div class=""line_list""></div>"
                    intI += 1
                    litHot.Text += "</div>"
                Next
                litHot.Text += "</div>"
            End If
        End Sub
        Private Sub LoadList()
            litVal.Text = "<div class=""list-items"">"
            arr = objContrller.CMS_Work_List_Pages(Me.PortalId, currPage.Value, 20, NganhNghe.SelectedValue, flReg.WriteNumber(TinhTP.SelectedValue), TrinhDo.SelectedValue, ViTri.SelectedValue,
                                                   MucLuong.SelectedValue, KinhNghiem.SelectedValue, flReg.WriteStringLess(GioiTinh.SelectedValue), CMS.Ultis.FullTextSearch(txtSearch.Text, False), 0)
            For Each Cr As CMS_WorkInfo In arr
                litVal.Text += "<div class=""row"">"
                litVal.Text += "<div class=""col-md-5 col-xs-6"">"
                litVal.Text += "<span class=""span-tw"">"
                litVal.Text += "<a href=""/" & Me.PortalSettings.ActiveTab.TabName & "/edit/" & Request.Item("view") & "/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""text_grey2"">" & Cr.Title & "</a>"
                litVal.Text += "</span>"
                litVal.Text += "</div>"
                litVal.Text += "<div class=""col-md-2 col-xs-2"">"
                litVal.Text += "<i class=""icon-money icon_16""></i><br>"
                litVal.Text += "<span>" & flCheck.Salary_Name(Me.PortalId, Cr.Salary_ID) & "</span>"
                litVal.Text += "</div>"
                litVal.Text += "<div class=""col-md-3 col-xs-2"">"
                litVal.Text += "<i class=""icon-address icon_16""></i><br>"
                litVal.Text += "<span class=""lsaddress"">" & flDic.RegionalName(Me.PortalId, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "TP.") & "</span>"
                litVal.Text += "</div>"
                litVal.Text += "<div class=""col-md-2 col-xs-2"">"
                litVal.Text += "<i class=""icon-countdown icon_16""></i><br>"
                litVal.Text += "<span>" & flReg.ReadDate(Cr.ExpiredDate, False) & "</span>"
                litVal.Text += "</div>"
                litVal.Text += "<div class=""line_list""></div>"
                litVal.Text += "</div>"
            Next
            litVal.Text += "</div>"
            litVal.Text += "<div class=""clear""></div>"
            For Each Cr As CMS_WorkInfo In arr
                litVal.Text += flReg.NextPage(Cr.Total, 20, currPage.Value, 5, flReg.UrlAlias & RedirectURL() & "/p/")
                Str = "<div class=""row""><div class=""box_title_content"">"
                If NganhNghe.SelectedValue = "" Then
                    Str += "<h1 class=""title_title_box"">Tất cả ngành nghề (" & Cr.Total & ")</h1>"
                Else
                    Str += "<h1 class=""title_title_box"">" & flCheck.Career_Name(Me.PortalId, NganhNghe.SelectedValue) & " (" & Cr.Total & ")</h1>"
                End If
                Str += "</div></div>"
                litVal.Text = Str & litVal.Text
                Exit For
            Next
        End Sub
        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, ViTri.SelectedIndexChanged, NganhNghe.SelectedIndexChanged, TinhTP.SelectedIndexChanged, MucLuong.SelectedIndexChanged, TrinhDo.SelectedIndexChanged, KinhNghiem.SelectedIndexChanged, GioiTinh.SelectedIndexChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadList()
        End Sub
    End Class
End Namespace