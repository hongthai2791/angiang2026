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

            Call flDic.LoadSex(GioiTinh, "Tất cả Giới tính")
            If Request.Item("sex") & "" <> "" Then GioiTinh.SelectedValue = Request.Item("sex")

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
                If Request.Item("itemid") <> "" Then
                    pnDetail.Visible = True
                    pnList.Visible = False
                    Call LoadDetail(Request.Item("itemid"))
                Else
                    pnDetail.Visible = False
                    pnList.Visible = True
                    Call LoadList()

                End If
            End If
        End Sub
        Private Function RedirectURL() As String
            RedirectURL = "/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If GioiTinh.SelectedValue <> "-1" Then RedirectURL += "/sex/" & GioiTinh.SelectedValue
            If ViTri.SelectedValue <> "" Then RedirectURL += "/poi/" & ViTri.SelectedValue
            If MucLuong.SelectedValue <> "" Then RedirectURL += "/sar/" & MucLuong.SelectedValue
            If KinhNghiem.SelectedValue <> "" Then RedirectURL += "/ex/" & KinhNghiem.SelectedValue
            If txtSearch.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtSearch.Text.Trim())
        End Function
        Private Function LinkNganhNghe(wId As String, id As String) As String
            Dim careInfo As CMS_CareerInfo
            LinkNganhNghe = flCache.GetCache("LinkNganhNghe_" & wId & "_" & id) & ""
            If LinkNganhNghe = "" Then
                Dim Str = id.Split(",")
                For i As Integer = 0 To Str.Length - 1
                    careInfo = objContrller.CMS_Career_Get(Me.PortalId, Str(i))
                    If IsNothing(careInfo) = False Then
                        LinkNganhNghe += "<a href=""" & flCheck.GetHomeLinkJob(careInfo.Career_Name, careInfo.Career_Code) & """ class=""job_value text_pink"">" & careInfo.Career_Name & "</a>, "
                    End If
                Next
                If LinkNganhNghe <> "" Then LinkNganhNghe = LinkNganhNghe.Substring(0, LinkNganhNghe.LastIndexOf(","))
                flCache.SetCache("LinkNganhNghe_" & wId & "_" & id, LinkNganhNghe, SecondCache.M1)
            End If
        End Function
        Private Sub LoadDetail(wId As String)
            Dim obj As New CMS_WorkInfo
            obj = CType(flCache.GetCache("CMS_Work_Get_ID_" & wId), CMS_WorkInfo)
            If IsNothing(obj) Then
                obj = New WorkController().CMS_Work_Get_ID(PortalId, wId)
                flCache.SetCache("CMS_Work_Get_ID_" & wId, obj, SecondCache.M1)
            End If
            If IsNothing(obj) = False Then
                Title.Text = obj.Title
                Business_Vn.Text = "<a href=""" & flCheck.GetHomeLinkBusiness(obj.Business_ID) & """ title=""Xem tất cả việc làm"" class=""text_grey3"">" & flCheck.Business_Vn(Me.PortalId, obj.Business_ID) & "</a>"
                HanNop.Text = flReg.ReadDate(obj.EndDate, False)
                MucLuong.Text = flCheck.Salary_Name(Me.PortalId, obj.Salary_ID)
                KinhNghiem.Text = flCheck.Experience_Name(Me.PortalId, obj.Experience_ID)
                ChucVu.Text = flDic.Position_Name(Me.PortalId, obj.LevelDesired_ID)
                BangCap.Text = flDic.Education_Name(Me.PortalId, obj.Level_ID)
                If BangCap.Text = "" Then BangCap.Text = "Không yêu cầu"
                HinhThuc.Text = flCheck.TypeOf_Name(Me.PortalId, obj.TypeOf_ID)
                SoLuong.Text = flReg.FormatPrice(obj.Quantity)
                GioiTinh.Text = flCheck.GioiTinh(obj.Gender)
                ViTri.Text = flCheck.JobPlace_Name(Me.PortalId, obj.JobPlace)
                NganhNghe.Text = LinkNganhNghe(obj.Work_ID, obj.Career_ID)
                DiaDiem.Text = flDic.RegionalName(Me.PortalId, obj.TinhTP, obj.QuanHuyen)
                MoTa.Text = obj.Description.Replace(vbLf, "<br/>")
                QuyenLoi.Text = obj.Benefit.Replace(vbLf, "<br/>")
                YeuCauCongViec.Text = obj.Requirement.Replace(vbLf, "<br/>")
                YeuCauHoSo.Text = obj.RequirementsProfile.Replace(vbLf, "<br/>")
                HanNop2.Text = HanNop.Text
                If obj.IsFast = True Then
                    divThongTin.Visible = True
                    divThongTinLH.Visible = False
                    DTLienHe.Text = flReg.WebConfig("Hotline")
                    Email.Text = flReg.WebConfig("Email")
                Else
                    divThongTin.Visible = False
                    divThongTinLH.Visible = True

                    NguoiLienHe.Text = obj.ContactUser
                    DiaChiLienHe.Text = obj.ContactAddress
                    Dienthoailienhe.Text = obj.ContactMobile
                    Maillienhe.Text = obj.ContactEmail
                End If

                If obj.UpdatedDate.Year > 1945 Then
                    LuotXem.Text = "<span>Lượt xem: " & flReg.FormatPrice(obj.IsView) & "</span> | <span>Mã: NTD" & flCheck.Business_Code(Me.PortalId, obj.Business_ID) & "  </span>| <span>Ngày làm mới: " & flReg.ReadDate(obj.UpdatedDate, False) & "</span>"
                Else
                    LuotXem.Text = "<span>Lượt xem: " & flReg.FormatPrice(obj.IsView) & "</span> | <span>Mã: NTD" & flCheck.Business_Code(Me.PortalId, obj.Business_ID) & "  </span>| <span>Ngày làm mới: " & flReg.ReadDate(obj.CreatedDate, False) & "</span>"
                End If
            End If
        End Sub
        Private Sub LoadList()
            litVal.Text = "<div class=""list-items"">"
            arr = objContrller.CMS_Work_List_Pages(Me.PortalId, currPage.Value, 20, "", 0, "", ViTri.SelectedValue,
                                                   MucLuong.SelectedValue, KinhNghiem.SelectedValue, flReg.WriteStringLess(GioiTinh.SelectedValue), CMS.Ultis.FullTextSearch(txtSearch.Text, False), 0)
            For Each Cr As CMS_WorkInfo In arr
                litVal.Text += "<div class=""row"">"
                litVal.Text += "<div class=""col-md-5 col-xs-6"">"
                litVal.Text += "<span class=""span-tw"">"
                litVal.Text += "<a href=""/" & Me.PortalSettings.ActiveTab.TabName & "/itemid/" & Cr.ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""text_grey2"">" & Cr.Title & "</a>"
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
                Str += "<h1 class=""title_title_box"">Tất cả việc làm (" & Cr.Total & ")</h1>"

                Str += "</div>"
                litVal.Text = Str & litVal.Text
                Exit For
            Next
        End Sub
        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, ViTri.SelectedIndexChanged, MucLuong.SelectedIndexChanged, KinhNghiem.SelectedIndexChanged, GioiTinh.SelectedIndexChanged
            Call LoadList()
        End Sub
    End Class
End Namespace