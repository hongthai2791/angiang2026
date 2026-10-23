<%@ WebHandler Language="VB" Class="workList" %>
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.APP

Public Class workList : Implements IHttpHandler

    Dim arr As New ArrayList
    Dim litRow As String
    Dim objContrller As New AppController
    Dim PortalID, currPage As Integer
    Dim sClass, TinhTP, Genner As String
    Dim CareerID As String = ""
    Dim EducationID As String = ""
    Dim JobPlaceID As String = ""
    Dim SalaryID As String = ""
    Dim Experienceid As String = ""
    Dim PositionID As String = ""
    Dim Title As String = ""
    Dim nghe, tinh, td, vt As String
    Dim ml, kn, gt, key As String
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Try
            currPage = context.Request.Item("page")
            PortalID = flReg.WriteNumber(context.Request.Item("pid"))
            If flReg.WriteNumber(context.Request.Item("type")) = 0 Then
                litRow = dsTuyenDungMoi()
            ElseIf flReg.WriteNumber(context.Request.Item("type")) = 1 Then
                litRow = dsNganhNghe(context.Request.Item("ced"), flReg.WriteNumber(context.Request.Item("sid")))
            ElseIf flReg.WriteNumber(context.Request.Item("type")) = 2 Then
                litRow = dsViTriTDMoi(context.Request.Item("jid"), flReg.WriteNumber(context.Request.Item("sid")))
            ElseIf flReg.WriteNumber(context.Request.Item("type")) = 3 Then
                litRow = dsTimKiem(flReg.WriteNumber(context.Request.Item("sid")))
            ElseIf flReg.WriteNumber(context.Request.Item("type")) = 4 Then
                litRow = dsNhaTuyenDungMoi()
            ElseIf flReg.WriteNumber(context.Request.Item("type")) = 5 Then
                litRow = dsViecLamNTD(context.Request.Item("bid"))
            ElseIf flReg.WriteNumber(context.Request.Item("type")) = 6 Then
                litRow = dsNhomViecLam(context.Request.Item("fag"))
            ElseIf flReg.WriteNumber(context.Request.Item("type")) = 7 Then
                litRow = dsXemThemDN(context.Request.Item("bid"))
            ElseIf flReg.WriteNumber(context.Request.Item("type")) = 8 Then
                litRow = dsTuyenDungMoiChiaCot()
            End If
            context.Response.Write(litRow)
        Catch ex As Exception
            context.Response.Write("")
        End Try
    End Sub
    Private Sub getSearch(SearchID As String)
        Dim obj As CMS_SearchInfo = objContrller.CMS_Search_Get(Me.PortalID, SearchID)
        If IsNothing(obj) = False Then
            CareerID = obj.NganhNghe
            TinhTP = obj.TinhTP
            EducationID = obj.TrinhDo
            JobPlaceID = obj.ViTri
            SalaryID = obj.MucLuong
            Experienceid = obj.KinhNghiem
            Genner = obj.GioiTinh
            PositionID = obj.ChucVu
            Title = obj.TuKhoa
        End If
    End Sub
    Private Function dsTuyenDungMoi()
        dsTuyenDungMoi = flCache.GetCache("TuyenDungMoi_" & Me.PortalID & "_" & currPage) & ""
        If dsTuyenDungMoi = "" Then
            'arr = objContrller.CMS_Works_List_Pages(Me.PortalID, currPage, 10, "", 0, "", "", "", "", -1, "", "")
            ' arr = objContrller.CMS_Works_List_Pages(Me.PortalID, currPage, 10, nghe, tinh, td, vt, ml, kn, gt, key, flReg.RemoveScript(key))
            For Each Cr As CMS_WorksInfo In arr
                dsTuyenDungMoi += "<div class=""col-md-12 col-lg-12 item  tinTD-gach"">"
                dsTuyenDungMoi += "<div class=""col-sm-2 col-xs-4 hidden-xs"">"
                dsTuyenDungMoi += "<div class=""company_logo"">"
                dsTuyenDungMoi += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"
                dsTuyenDungMoi += "<div class=""logo_box hidden-xs"">"
                dsTuyenDungMoi += "<img class=""lazy-load"" src=""" & flReg.ImgSRC(flCheck.Business_Logo(Me.PortalID, Cr.Business_ID), 160, 105, True, "logo-dn.png") & """ alt=""" & flReg.ImgAlt(Cr.Title) & """>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "</a>"
                dsTuyenDungMoi += "</div></div>"
                dsTuyenDungMoi += "<div class=""col-sm-10"">"
                dsTuyenDungMoi += "<div class=""content"">"
                dsTuyenDungMoi += "<div class=""company_name"">"
                dsTuyenDungMoi += "<p class=""j_title text_ellipsis"">"
                dsTuyenDungMoi += "<a href=""/tuyen-dung/viec-lam/" & flCheck.LinkUrl(Cr.Title, Cr.ID, "VL") & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class="""">"
                If Cr.IsClass = classCSS.UuTien3 Then
                    dsTuyenDungMoi += "<span class=""clsut2 clsut3"">HOT</span><span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien2 Then
                    dsTuyenDungMoi += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien1 Then
                    dsTuyenDungMoi += "<span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.TinThuong Then
                    dsTuyenDungMoi += "<span class=""clsthuong"">" & Cr.Title & "</span></a>"
                Else
                    dsTuyenDungMoi += "<span>" & Cr.Title & "</span></a>"
                End If
                dsTuyenDungMoi += "</p>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "<div class=""col-sm-9 pd0"">"
                dsTuyenDungMoi += "<div class=""j_company"">"
                dsTuyenDungMoi += "<div class=""name-td"">"
                dsTuyenDungMoi += "<a href=""/app-users/view/us-business-detail/itemid/" & Cr.Business_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ >"
                dsTuyenDungMoi += "<span>" & Cr.Business_Name & "&nbsp;</span>"
                dsTuyenDungMoi += "</a>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "<div class=""col-sm-3 name-td"">"
                dsTuyenDungMoi += "<div class=""txt-right txt-luutin""><a href=""/"" title=""""><i class=""fa fa-heart-o"" aria-hidden=""True""></i>&nbsp;Lưu tin</a></div>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "<div class=""clear""></div>"
                dsTuyenDungMoi += "<div class=""col-sm-9 pd0"">"
                dsTuyenDungMoi += "<div class=""extra-info"">"
                dsTuyenDungMoi += "<div title=""Nơi làm việc""  class=""col-sm-3 pd0 location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(Me.PortalID, Cr.TinhTP, Cr.QuanHuyen) & "</div>"
                dsTuyenDungMoi += "<div title=""Hạn nộp""  class=""col-sm-3 time""><i class=""fa fa-clock-o"" aria-hidden=""true""></i>&nbsp;" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
                dsTuyenDungMoi += "<div title=""Mức lương"" class=""col-sm-3 pd0 dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & flCheck.Salary_Name(Me.PortalID, Cr.Salary_ID) & "</div>"
                dsTuyenDungMoi += "<div title=""Số lượng tuyển dụng"" class=""col-sm-3 pd0 dollar""><i class=""fa fa-filter"" aria-hidden=""true""></i>&nbsp;Số lượng:&nbsp; " & Cr.Quantity & "</div>"

                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "<div class=""col-sm-3 pd0 txt-right"">"
                If flReg.RelativeTime(Cr.ApprovalDate) <> "" Then
                    dsTuyenDungMoi += "<div class=""txt-clxacthuc txt-right"">" & flReg.RelativeTime(Cr.CreatedDate) & "</div>"
                Else
                    dsTuyenDungMoi += "<div class=""txt-clxacthuc txt-right""> Không xác định</div>"
                End If
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "<div class=""clear""></div>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "</div>"
                dsTuyenDungMoi += "</div>"
            Next
            For Each Cr As CMS_WorksInfo In arr
                'litTotal.Text = Cr.Total
                dsTuyenDungMoi += flReg.NextPageJs(Cr.Total, 16, 1, 5, "viewData('list',")
                Exit For
            Next
            flCache.SetCache("TuyenDungMoi_" & Me.PortalID & "_" & currPage, dsTuyenDungMoi, SecondCache.S10)
        End If
    End Function
    Private Function dsTuyenDungMoiChiaCot() As String
        dsTuyenDungMoiChiaCot = "" 'flCache.GetCache("TuyenDungMoi_" & Me.PortalID & "_" & currPage) & ""
        If dsTuyenDungMoiChiaCot = "" Then
            'arr = objContrller.CMS_Works_List_Pages(Me.PortalID, currPage, 16, "", 0, "", "", "", "", -1, "", "")
            'arr = objContrller.CMS_Works_List_Pages(Me.PortalID, 1, 16, nghe, tinh, td, vt, ml, kn, gt, key, flReg.RemoveScript(key))
            For Each Cr As CMS_WorksInfo In arr
                dsTuyenDungMoiChiaCot += "<div class=""col-md-6 col-lg-6 item  tinTD-gachc"">"
                dsTuyenDungMoiChiaCot += "<div class=""col-sm-3 col-xs-4 hidden-xs"">"
                dsTuyenDungMoiChiaCot += "<div class=""company_logo"">"
                'dsTuyenDungMoiChiaCot += "<a href=""/tuyen-dung/viec-lam/" & flCheck.LinkUrl(Cr.Title, Cr.ID, "VL") & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class="""">"
                dsTuyenDungMoiChiaCot += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"
                dsTuyenDungMoiChiaCot += "<div class=""logo_box hidden-xs"">"
                dsTuyenDungMoiChiaCot += "<img class=""lazy-load"" src=""" & flReg.ImgSRC(flCheck.Business_Logo(Me.PortalID, Cr.Business_ID), 150, 105, True, "logo-dn.png") & """ alt=""" & flReg.ImgAlt(Cr.Title) & """>"
                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "</a>"
                dsTuyenDungMoiChiaCot += "</div></div>"
                dsTuyenDungMoiChiaCot += "<div class=""col-sm-9"">"
                dsTuyenDungMoiChiaCot += "<div class=""content"">"
                dsTuyenDungMoiChiaCot += "<div class=""company_name"">"
                dsTuyenDungMoiChiaCot += "<p class=""j_title text_ellipsis"">"
                'dsTuyenDungMoiChiaCot += "<a href=""/tuyen-dung/viec-lam/" & flCheck.LinkUrl(Cr.Title, Cr.ID, "VL") & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip "">"
                dsTuyenDungMoiChiaCot += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"
                If Cr.IsClass = classCSS.UuTien3 Then
                    dsTuyenDungMoiChiaCot += "<span class=""clsut2 clsut3"">HOT</span><span class=""clsthuong clsut1"">" & flReg.Trimstr(Cr.Title, 50) & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien2 Then
                    dsTuyenDungMoiChiaCot += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien1 Then
                    dsTuyenDungMoiChiaCot += "<span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.TinThuong Then
                    dsTuyenDungMoiChiaCot += "<span class=""clsthuong"">" & Cr.Title & "</span></a>"
                Else
                    dsTuyenDungMoiChiaCot += "<span>" & Cr.Title & "</span></a>"
                End If
                dsTuyenDungMoiChiaCot += "</p>"
                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "<div class=""col-sm-12 pd0"">"
                dsTuyenDungMoiChiaCot += "<div class=""j_company"">"
                dsTuyenDungMoiChiaCot += "<div class=""name-td"">"
                dsTuyenDungMoiChiaCot += "<a href=""/app-users/view/us-business-detail/itemid/" & Cr.Business_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ >"
                'dsTuyenDungMoiChiaCot += "<a href=""/tuyen-dung/viec-lam/" & flCheck.LinkUrl(Cr.Title, Cr.ID, "VL") & """ title=""" & flReg.ImgAlt(Cr.Title) & """>"
                dsTuyenDungMoiChiaCot += "<span>" & flReg.Trimstr(Cr.Business_Name, 50) & "&nbsp;</span>"
                dsTuyenDungMoiChiaCot += "</a>"
                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "<div class=""clear""></div>"
                dsTuyenDungMoiChiaCot += "<div class=""col-sm-12 pd0"">"
                dsTuyenDungMoiChiaCot += "<div class=""extra-info"">"
                dsTuyenDungMoiChiaCot += "<div class=""col-sm-5 pd0 location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(Me.PortalID, Cr.TinhTP, Cr.QuanHuyen) & "</div>"
                dsTuyenDungMoiChiaCot += "<div class=""col-sm-7 pd0 dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & flCheck.Salary_Name(Me.PortalID, Cr.Salary_ID) & "</div>"

                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "<div class=""clear""></div>"
                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "</div>"
                dsTuyenDungMoiChiaCot += "</div>"
            Next
            dsTuyenDungMoiChiaCot += "<div class=""clear""></div>"
            For Each Cr As CMS_WorksInfo In arr
                dsTuyenDungMoiChiaCot += "<div class=""phan-trang"">"
                dsTuyenDungMoiChiaCot += flReg.NextPageJs(Cr.Total, 16, currPage, 5, "fnext1(")
                dsTuyenDungMoiChiaCot += "</div>"
                Exit For
            Next
            'flCache.SetCache("TuyenDungMoi_" & Me.PortalID & "_" & currPage, dsTuyenDungMoiChiaCot, SecondCache.S10)
        End If
    End Function
    Private Function dsNganhNghe(nganhNghe As String, tinhTP As Integer) As String
        dsNganhNghe = flCache.GetCache("CMS_Work_List_Pages" & currPage & "_" & tinhTP & "_" & nganhNghe) & ""
        If dsNganhNghe = "" Then
            If nganhNghe <> "" Then
                Dim cInfo As CMS_CareerInfo = objContrller.CMS_Career_Get(Me.PortalID, nganhNghe)
                If IsNothing(cInfo) = False Then CareerID = cInfo.Career_ID
            End If
            dsNganhNghe = "" : sClass = "box-tab-content3"
            'arr = objContrller.CMS_Works_List_Pages(Me.PortalID, currPage, 10, "", 0, "", "", "", "", -1, "", "")
            For Each Cr As CMS_WorksInfo In arr
                dsNganhNghe += "<div class=""" & sClass & """>"
                dsNganhNghe += "<div class=""row"">"
                dsNganhNghe += "<div class=""col-md-2 col-xs-3 txt-center""><div class='table-img'><div class='cell-img height-60'>"
                dsNganhNghe += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ class=""text_grey2 bold"">"
                dsNganhNghe += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(Me.PortalID, Cr.Business_ID), 55, 0, True, "logo-dn.png") & """ alt=""" & flReg.ImgAlt(Cr.Title) & """ />"
                dsNganhNghe += "</a></div></div>"
                dsNganhNghe += "</div>"
                dsNganhNghe += "<div class=""col-md-10 col-xs-9"">"
                dsNganhNghe += "<div class=""col-md-7 pdl0"">"
                dsNganhNghe += "<div class=""pdl0 wname text_ellipsis"">"
                dsNganhNghe += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ class=""text_grey2 bold""><span>" & Cr.Title & "</span></a>"
                dsNganhNghe += "</div>"
                dsNganhNghe += "<div class=""clear""></div>"
                dsNganhNghe += "<div class=""pdl0 wtitle text_ellipsis"">"
                dsNganhNghe += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """><span>" & Cr.Business_Name & "</span></a>"
                dsNganhNghe += "</div>"
                dsNganhNghe += "<div class=""clear""></div>"
                dsNganhNghe += "</div>"
                dsNganhNghe += "<div class=""col-md-5 extra-work pdl0 full-row"">"
                dsNganhNghe += "<div class=""dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & flCheck.Salary_Name(Me.PortalID, Cr.Salary_ID) & "</div>"
                dsNganhNghe += "<div class=""time""><i class=""fa fa-clock-o"" aria-hidden=""true""></i>&nbsp;" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
                dsNganhNghe += "<div class=""location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(Me.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "").Replace("Tỉnh", "").Replace("Huyện ", "").Replace("Tỉnh", "").Replace("Thị xã ", "TX.").Replace("Quận ", "Q.") & "</div>"
                dsNganhNghe += "<div class=""clear""></div>"
                dsNganhNghe += "</div>"

                dsNganhNghe += "</div>"
                dsNganhNghe += "</div>"
                dsNganhNghe += "</div>"
                If sClass = "box-tab-content3" Then
                    sClass = "box-tab-content4"
                Else
                    sClass = "box-tab-content3"
                End If
            Next
            For Each Cr As CMS_WorksInfo In arr
                dsNganhNghe += "<div class=""clear""></div>"
                dsNganhNghe += flReg.NextPageVs(Cr.Total, 12, currPage, 12, "fnext(")
                Exit For
            Next
            flCache.SetCache("CMS_Work_List_Pages" & currPage & "_" & tinhTP & "_" & nganhNghe, dsNganhNghe, SecondCache.S8)
        End If
    End Function
    Private Function dsViTriTDMoi(jid As String, SearchID As Integer) As String
        dsViTriTDMoi = flCache.GetCache("Vi_Tri_Tuyen_Dung_Moi_" & jid & "_" & currPage & "_" & SearchID)
        If dsViTriTDMoi = "" Then
            Call getSearch(SearchID)
            JobPlaceID = jid
            If Genner = "" Then Genner = "-1"
            If TinhTP = "" Then TinhTP = "0"
            sClass = "box-tab-content3"
            'arr = objContrller.CMS_Works_List_Pages(Me.PortalID, currPage, 12, CareerID, TinhTP, EducationID, JobPlaceID, SalaryID, Experienceid, Genner, Title, flNotify.FullTextSearch(Title, False))
            If arr.Count > 0 Then
                dsViTriTDMoi = ""
                For Each Cr As CMS_WorksInfo In arr
                    dsViTriTDMoi += "<div class=""" & sClass & """>"
                    dsViTriTDMoi += "<div class=""row"">"
                    dsViTriTDMoi += "<div class=""col-md-2 col-xs-3 txt-center""><div class='table-img'><div class='cell-img height-60'>"
                    dsViTriTDMoi += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ class=""text_grey2 bold"">"
                    dsViTriTDMoi += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(Me.PortalID, Cr.Business_ID), 55, 0, True, "logo-dn.png") & """ alt=""" & flReg.ImgAlt(Cr.Title) & """ />"
                    dsViTriTDMoi += "</a></div></div>"
                    dsViTriTDMoi += "</div>"
                    dsViTriTDMoi += "<div class=""col-md-10 col-xs-9"">"
                    dsViTriTDMoi += "<div class=""col-md-8 pdl0"">"
                    dsViTriTDMoi += "<div class=""pdl0 wname text_ellipsis"">"
                    dsViTriTDMoi += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ class=""text_grey2 bold"">"

                    If Cr.IsClass = classCSS.UuTien3 Then
                        dsViTriTDMoi += "<span class=""clsut2 clsut3"">HOT</span><span class=""clsthuong clsut1"">" & flReg.Trimstr(Cr.Title, 50) & "</span></a>"
                    ElseIf Cr.IsClass = classCSS.UuTien2 Then
                        dsViTriTDMoi += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                    ElseIf Cr.IsClass = classCSS.UuTien1 Then
                        dsViTriTDMoi += "<span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                    ElseIf Cr.IsClass = classCSS.TinThuong Then
                        dsViTriTDMoi += "<span class=""clsthuong"">" & Cr.Title & "</span></a>"
                    Else
                        dsViTriTDMoi += "<span>" & Cr.Title & "</span></a>"
                    End If

                    dsViTriTDMoi += "</div>"
                    dsViTriTDMoi += "<div class=""clear""></div>"
                    dsViTriTDMoi += "<div class=""pdl0 wtitle text_ellipsis"">"
                    dsViTriTDMoi += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """><span>" & Cr.Business_Name & "</span></a>"
                    dsViTriTDMoi += "</div>"
                    dsViTriTDMoi += "<div class=""clear""></div>"
                    dsViTriTDMoi += "</div>"
                    dsViTriTDMoi += "<div class=""col-md-4 extra-work pdl0 full-row"">"
                    dsViTriTDMoi += "<div class=""dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & flCheck.Salary_Name(Me.PortalID, Cr.Salary_ID) & "</div>"
                    dsViTriTDMoi += "<div class=""time""><i class=""fa fa-clock-o"" aria-hidden=""true""></i>&nbsp;" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
                    dsViTriTDMoi += "<div class=""location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(Me.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "").Replace("Tỉnh", "").Replace("Huyện ", "").Replace("Tỉnh", "").Replace("Thị xã ", "TX.").Replace("Quận ", "Q.") & "</div>"
                    dsViTriTDMoi += "<div class=""clear""></div>"
                    dsViTriTDMoi += "</div>"

                    dsViTriTDMoi += "</div>"
                    dsViTriTDMoi += "</div>"
                    dsViTriTDMoi += "</div>"
                    If sClass = "box-tab-content3" Then
                        sClass = "box-tab-content4"
                    Else
                        sClass = "box-tab-content3"
                    End If
                Next
                For Each Cr As CMS_WorksInfo In arr
                    dsViTriTDMoi += "<div class=""clear""></div>"
                    dsViTriTDMoi += flReg.NextPageVs(Cr.Total, 12, currPage, 12, "fnext(")
                    Exit For
                Next
            End If
            flCache.SetCache("Vi_Tri_Tuyen_Dung_Moi_" & jid & "_" & currPage & "_" & SearchID, dsViTriTDMoi, SecondCache.S6)
        End If
    End Function
    Private Function dsTimKiem(SearchID As Integer) As String
        dsTimKiem = flCache.GetCache("TimKiem_ViecLam_" & PortalID & "_" & SearchID & "_" & currPage) & ""
        If dsTimKiem = "" Then
            Call getSearch(SearchID)
            If Genner = "" Then Genner = "-1"
            If TinhTP = "" Then TinhTP = "0"
            arr = objContrller.CMS_Works_List_Find(Me.PortalID, Title, flReg.RemoveScript(Title, False), TinhTP, CareerID, JobPlaceID, SalaryID, EducationID, Experienceid, Genner, PositionID, currPage, 10)
            For Each Cr As CMS_WorksInfo In arr
                dsTimKiem += "<div class=""col-md-12 col-lg-12 item  qcao-" & Cr.IsPrice & """>"
                dsTimKiem += "<div class=""col-md-8 col-xs-8"">"
                dsTimKiem += "<div class=""col-md-12"">"
                dsTimKiem += "<div class=""company_name"">"
                dsTimKiem += "<p class=""j_title text_ellipsis"">"
                dsTimKiem += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"

                If Cr.IsClass = classCSS.UuTien3 Then
                    dsTimKiem += "<span class=""clsut2 clsut3"">HOT</span><span class=""clsthuong clsut1"">" & flReg.Trimstr(Cr.Title, 50) & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien2 Then
                    dsTimKiem += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien1 Then
                    dsTimKiem += "<span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.TinThuong Then
                    dsTimKiem += "<span class=""clsthuong"">" & Cr.Title & "</span></a>"
                Else
                    dsTimKiem += "<span>" & Cr.Title & "</span></a>"
                End If

                dsTimKiem += "</p>"
                dsTimKiem += "</div>"
                dsTimKiem += "<div class=""j_company"">"
                dsTimKiem += "<div class=""name"">"
                dsTimKiem += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """>"
                dsTimKiem += "<span>" & Cr.Business_Name & "&nbsp;</span>"
                dsTimKiem += "</a>"
                dsTimKiem += "</div>"
                dsTimKiem += "</div>"
                dsTimKiem += "</div>"
                dsTimKiem += "</div>"
                dsTimKiem += "<div class=""col-md-4 col-xs-4 extra-info"">"
                dsTimKiem += "<div class=""dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & flCheck.Salary_Name(Me.PortalID, Cr.Salary_ID) & "</div>"
                dsTimKiem += "<div class=""time""><i class=""fa fa-clock-o"" aria-hidden=""true""></i>&nbsp;" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
                dsTimKiem += "<div class=""location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(Me.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "").Replace("Tỉnh", "").Replace("Huyện ", "").Replace("Tỉnh", "").Replace("Thị xã ", "TX.").Replace("Quận ", "Q.") & "</div>"
                dsTimKiem += "<div class=""clear""></div>"
                dsTimKiem += "</div>"
                dsTimKiem += "</div>"
            Next
            For Each Cr As CMS_WorksInfo In arr
                dsTimKiem += "<div class=""clear""></div>"
                dsTimKiem += flReg.NextPageVs(Cr.Total, 10, currPage, 10, "fnext(")
                Exit For
            Next
            flCache.SetCache("TimKiem_ViecLam_" & PortalID & "_" & SearchID & "_" & currPage, dsTimKiem, SecondCache.S10)
        End If
    End Function
    Private Function dsNhaTuyenDungMoi() As String
        dsNhaTuyenDungMoi = flCache.GetCache("ds_Nha_Tuyen_Dung_Moi_" & Me.PortalID & "_" & currPage) & ""
        If dsNhaTuyenDungMoi = "" Then
            arr = objContrller.CMS_Business_List_Home(Me.PortalID, BussHome.DN_Moi, currPage, 27)
            For Each Cr As CMS_BusinessInfo In arr
                dsNhaTuyenDungMoi += "<div class=""col-md-4 pdl0 pdr0"">"
                dsNhaTuyenDungMoi += "<div class=""bd-hm-w"">"
                dsNhaTuyenDungMoi += "<a href=""" & flCheck.GetHomeLinkBusiness(Cr.Business_ID) & """ title=""" & flReg.ImgAlt(Cr.Business_Vn) & """>"
                dsNhaTuyenDungMoi += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(0, Cr.Business_ID), 120, 100) & """ alt=""" & flReg.ImgAlt(Cr.Business_Vn) & """ />"
                dsNhaTuyenDungMoi += "<div class=""hm-w-title"">" & Cr.Business_Vn & "</div>"
                dsNhaTuyenDungMoi += "</a></div>"
                dsNhaTuyenDungMoi += "</div>"
            Next
            For Each Cr As CMS_BusinessInfo In arr
                dsNhaTuyenDungMoi += "<div class=""clear""></div>"
                dsNhaTuyenDungMoi += flReg.NextPageVs(Cr.Total, 27, currPage, 5, "fnext(")
                Exit For
            Next
            flCache.SetCache("ds_Nha_Tuyen_Dung_Moi_" & Me.PortalID & "_" & currPage, dsNhaTuyenDungMoi, SecondCache.M30)
        End If
    End Function
    Private Function dsViecLamNTD(BusinessID As String) As String
        dsViecLamNTD = flCache.GetCache("CMS_Works_List_By_Business_Home_" & BusinessID & "_" & Me.PortalID & "_" & currPage) & ""
        If dsViecLamNTD = "" Then
            arr = objContrller.CMS_Works_List_By_Business_Home(Me.PortalID, BusinessID, Me.PortalID, currPage, 10)
            dsViecLamNTD += "<div class=""list-items work-list-item"">"
            For Each Cr As CMS_WorksInfo In arr
                dsViecLamNTD += "<div class=""row"">"
                dsViecLamNTD += "<div class=""col-md-8 col-xs-12 text_ellipsis"">"
                dsViecLamNTD += "<span class=""span-tw"">"
                dsViecLamNTD += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""text_grey2 "">" & Cr.Title & "</a>"
                dsViecLamNTD += "</span>"
                dsViecLamNTD += "</div>"

                dsViecLamNTD += "<div class=""col-md-4 extra-work pdl0 full-row"">"
                dsViecLamNTD += "<div class=""dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & flCheck.Salary_Name(Me.PortalID, Cr.Salary_ID) & "</div>"
                dsViecLamNTD += "<div class=""time""><i class=""fa fa-clock-o"" aria-hidden=""true""></i>&nbsp;" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
                dsViecLamNTD += "<div class=""location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(Me.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "").Replace("Tỉnh", "").Replace("Huyện ", "").Replace("Tỉnh", "").Replace("Thị xã ", "TX.").Replace("Quận ", "Q.") & "</div>"
                dsViecLamNTD += "<div class=""clear""></div>"
                dsViecLamNTD += "</div>"

                dsViecLamNTD += "<div class=""line_list""></div>"
                dsViecLamNTD += "</div>"
            Next
            dsViecLamNTD += "</div>"
            dsViecLamNTD += "<div class=""clear""></div>"
            For Each Cr As CMS_WorksInfo In arr
                dsViecLamNTD += flReg.NextPageVs(Cr.Total, 10, currPage, 10, "fnext(")
                Exit For
            Next
            flCache.SetCache("CMS_Works_List_By_Business_Home_" & BusinessID & "_" & Me.PortalID & "_" & currPage, dsViecLamNTD, SecondCache.S8)
        End If
    End Function

    Private Function dsXemThemDN(BusinessID As String) As String
        dsXemThemDN = flCache.GetCache("member_Works_List_By_Business_Home_" & BusinessID & "_" & Me.PortalID & "_" & currPage) & ""
        If dsXemThemDN = "" Then
            arr = objContrller.CMS_Works_List_By_Business_Home(Me.PortalID, BusinessID, Me.PortalID, currPage, 10)
            dsXemThemDN = "<div class=""row"">"
            For Each Cr As CMS_WorksInfo In arr
                dsXemThemDN += "<div class=""col-md-12 col-lg-12 job-over-item"">"
                dsXemThemDN += "<div class=""row job-item"">"
                dsXemThemDN += "<p class=""j_title text_ellipsis"">"
                dsXemThemDN += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"
                If Cr.IsClass = classCSS.UuTien3 Then
                    dsXemThemDN += "<span class=""clsut2 clsut3"">HOT</span><span class=""clsthuong clsut1"">" & flReg.Trimstr(Cr.Title, 50) & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien2 Then
                    dsXemThemDN += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien1 Then
                    dsXemThemDN += "<span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.TinThuong Then
                    dsXemThemDN += "<span class=""clsthuong"">" & Cr.Title & "</span></a>"
                Else
                    dsXemThemDN += "<span>" & Cr.Title & "</span></a>"
                End If
                dsXemThemDN += "</p>"
                dsXemThemDN += "<div class=""table-item"">"
                dsXemThemDN += "<div class=""dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & flCheck.Salary_Name(Me.PortalID, Cr.Salary_ID) & "</div>"
                dsXemThemDN += "<div class=""time""><i class=""fa fa-clock-o"" aria-hidden=""true""></i>&nbsp;" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
                dsXemThemDN += "<div class=""location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(Me.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "").Replace("Tỉnh", "").Replace("Huyện ", "").Replace("Tỉnh", "").Replace("Thị xã ", "TX.").Replace("Quận ", "Q.") & "</div>"
                dsXemThemDN += "</div>"
                dsXemThemDN += "</div>"
                dsXemThemDN += "</div>"
            Next
            dsXemThemDN += "</div>"
            flCache.SetCache("member_Works_List_By_Business_Home_" & BusinessID & "_" & Me.PortalID & "_" & currPage, dsXemThemDN, SecondCache.M1)
            For Each Cr As CMS_WorksInfo In arr
                dsXemThemDN += "<div class=""phan-trang"">"
                dsXemThemDN += "<div class=""clear""></div>"
                dsXemThemDN += flReg.NextPageVs(Cr.Total, 10, currPage, 10, "fnext(")
                dsXemThemDN += "</div>"
                Exit For
            Next
        End If
    End Function

    Private Function dsNhomViecLam(flag As Integer) As String
        dsNhomViecLam = "" 'flCache.GetCache("Nhom_Viec_Lam_" & PortalId & "_" & flag & "_" & currPage) & ""
        If dsNhomViecLam = "" Then
            arr = objContrller.CMS_Works_List_Home_Page(Me.PortalID, flag, "", currPage, 11)
            For Each Cr As CMS_WorksInfo In arr
                dsNhomViecLam += "<div class=""col-md-12 col-lg-12 item list-nvl"">"

                dsNhomViecLam += "<div class=""col-md-2 col-xs-4 txt-center"">"
                dsNhomViecLam += "<div class=""company_logo"">"
                dsNhomViecLam += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class="""">"
                dsNhomViecLam += "<div class=""logo_box""><div class='table-img'><div class='cell-img height-60'>"
                dsNhomViecLam += "<img class=""lazy-load"" src=""" & flReg.ImgSRC(flCheck.Business_Logo(Me.PortalID, Cr.Business_ID), 55, 0, True, "logo-dn.png") & """ alt=""" & flReg.ImgAlt(Cr.Title) & """>"
                dsNhomViecLam += "</div></div></div>"
                dsNhomViecLam += "</a>"
                dsNhomViecLam += "</div>"
                dsNhomViecLam += "</div>"

                dsNhomViecLam += "<div class=""col-md-7 col-xs-8"">"
                dsNhomViecLam += "<div class=""col-md-12"">"
                dsNhomViecLam += "<div class=""company_name"">"
                dsNhomViecLam += "<p class=""j_title text_ellipsis"">"
                dsNhomViecLam += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""el-tooltip item"">"
                If Cr.IsClass = classCSS.UuTien3 Then
                    dsNhomViecLam += "<span class=""clsut2 clsut3"">HOT</span><span class=""clsthuong clsut1"">" & flReg.Trimstr(Cr.Title, 50) & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien2 Then
                    dsNhomViecLam += "<span class=""clsut2"">HOT</span><span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.UuTien1 Then
                    dsNhomViecLam += "<span class=""clsthuong clsut1"">" & Cr.Title & "</span></a>"
                ElseIf Cr.IsClass = classCSS.TinThuong Then
                    dsNhomViecLam += "<span class=""clsthuong"">" & Cr.Title & "</span></a>"
                Else
                    dsNhomViecLam += "<span>" & Cr.Title & "</span></a>"
                End If

                dsNhomViecLam += "</p>"
                dsNhomViecLam += "</div>"
                dsNhomViecLam += "<div class=""j_company"">"
                dsNhomViecLam += "<div class=""name"">"
                dsNhomViecLam += "<a href=""/app-users/edit/us-works/itemid/" & Cr.Work_ID & """ title=""" & flReg.ImgAlt(Cr.Title) & """>"
                dsNhomViecLam += "<span>" & Cr.Business_Name & "&nbsp;</span>"
                dsNhomViecLam += "</a>"
                dsNhomViecLam += "</div>"
                dsNhomViecLam += "</div>"
                dsNhomViecLam += "</div>"
                dsNhomViecLam += "</div>"
                dsNhomViecLam += "<div class=""col-md-3 col-xs-4 extra-info"">"
                dsNhomViecLam += "<div class=""dollar""><i class=""fa fa-money"" aria-hidden=""true""></i>&nbsp;" & flCheck.Salary_Name(Me.PortalID, Cr.Salary_ID) & "</div>"
                dsNhomViecLam += "<div class=""time""><i class=""fa fa-clock-o"" aria-hidden=""true""></i>&nbsp;" & flReg.ReadDate(Cr.ExpiredDate, False) & "</div>"
                dsNhomViecLam += "<div class=""location text_ellipsis""><i class=""fa fa-map-marker"" aria-hidden=""true""></i>&nbsp;" & flDic.RegionalName(Me.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "").Replace("Tỉnh", "").Replace("Huyện ", "").Replace("Tỉnh", "").Replace("Thị xã ", "TX.").Replace("Quận ", "Q.") & "</div>"
                dsNhomViecLam += "<div class=""clear""></div>"
                dsNhomViecLam += "</div>"
                dsNhomViecLam += "</div>"
            Next
            For Each Cr As CMS_WorksInfo In arr
                dsNhomViecLam += "<div class=""phan-trang"">"
                dsNhomViecLam += "<div class=""clear""></div>"
                dsNhomViecLam += flReg.NextPageVs(Cr.Total, 11, currPage, 11, "fnext(")
                dsNhomViecLam += "</div>"
                Exit For
            Next
            flCache.SetCache("Nhom_Viec_Lam_" & PortalID & "_" & flag & "_" & currPage, dsNhomViecLam, SecondCache.M1)
        End If
    End Function
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class