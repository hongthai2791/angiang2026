Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Work
    Partial Class WorksList
        Inherits Entities.Modules.PortalModuleBase
        Dim objContrller As New WorkController
        Dim obj As New CMS_SearchInfo
        Dim arr As New ArrayList, intI As Integer
        Dim str As String
        Private Sub GetID()
            vUrl.Value = Request.RawUrl
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If vUrl.Value.Contains("/p/") Then
                vUrl.Value = vUrl.Value.Substring(0, vUrl.Value.LastIndexOf("/p/"))
                currPage.Value = flReg.WriteNumber(CMS.flCheck.RequestItem(Request.RawUrl, "p"))
            End If
            If currPage.Value = 0 Then currPage.Value = 1

            If Request.Item("nganh-nghe") & "" <> "" Then
                SearchID.Value = Request.Item("nganh-nghe")
                Dim sId As Integer = CMS.Ultis.GetRequestId(SearchID.Value)
                Dim cInfo As New CMS_CareerInfo
                cInfo = objContrller.CMS_Career_Get_ID(Me.PortalId, sId)
                If IsNothing(cInfo) = False Then
                    CareerID.Value = cInfo.Career_ID
                    CareerName.Value = "Việc làm " & cInfo.Career_Name
                End If
            Else
                CareerName.Value = "Danh sách việc làm"
                If flReg.WriteNumber(Request.Item("search")) > 0 Then
                    obj = objContrller.CMS_Search_Get(Me.PortalId, Request.Item("search"))
                    If IsNothing(obj) = False Then
                        SearchID.Value = obj.ID
                        CareerID.Value = obj.NganhNghe
                        TinhTP.Value = obj.TinhTP
                        EducationID.Value = obj.TrinhDo
                        JobPlaceID.Value = obj.ViTri
                        SalaryID.Value = obj.MucLuong
                        Experienceid.Value = obj.KinhNghiem
                        Genner.Value = obj.GioiTinh
                        Title.Value = obj.TuKhoa
                    End If
                End If
            End If
            If Genner.Value = "" Then Genner.Value = "-1"
            If TinhTP.Value = "" Then TinhTP.Value = "0"
        End Sub
        Private Sub LoadHot()
            litHot.Text = flCache.GetCache("CMS_Work_List_Pages_1_3_" & SearchID.Value & "_" & 1) & ""
            If litHot.Text = "" Then
                arr = objContrller.CMS_Work_List_Pages(Me.PortalId, 1, 3, CareerID.Value, TinhTP.Value, EducationID.Value, JobPlaceID.Value, SalaryID.Value, Experienceid.Value, Genner.Value, CMS.Ultis.FullTextSearch(Title.Value.Replace("-", ""), False), 1)
                If arr.Count > 0 Then
                    intI = 1
                    litHot.Text = "<div class=""box_tab "">"
                    litHot.Text += "<h2 class=""title_text_line""><span class=""text-tim-nhat"">Tuyển gấp</span></h2>"
                    For Each Cr As CMS_WorkInfo In arr
                        litHot.Text += "<div class=""row"">"
                        litHot.Text += "<div class=""col-md-3 hidden-xs"">"
                        litHot.Text += "<a href=""" & flCheck.GetHomeLinkWork(Cr.Title, Cr.ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>"
                        litHot.Text += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(Cr.PortalID, Cr.Business_ID), 120) & """ alt=""" & flReg.ImgAlt(Cr.Title) & """ />"
                        litHot.Text += "</a>"
                        litHot.Text += "</div>"
                        litHot.Text += "<div class=""col-md-9 col-xs-12"">"
                        litHot.Text += "<div class=""col-md-12 col-xs-12 pdl0"">"
                        litHot.Text += "<a href=""" & flCheck.GetHomeLinkWork(Cr.Title, Cr.ID) & """ class=""text_grey2 bold"">" & Cr.Title & "</a>"
                        litHot.Text += "</div>"
                        litHot.Text += "<div class=""clear mgt10""></div>"
                        litHot.Text += "<div class=""col-md-12 col-xs-12 pdl0"">"
                        litHot.Text += "<a href=""" & flCheck.GetHomeLinkBusiness(Cr.Business_ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """>" & flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID) & "</a>"
                        litHot.Text += "</div>"
                        litHot.Text += "<div class=""clear mgt10""></div>"
                        litHot.Text += "<div class=""col-md-4 col-xs-4 pdl0"">"
                        litHot.Text += "<i class=""icon-money icon_16""></i>"
                        litHot.Text += "<div class=""pl_28"">" & flCheck.Salary_Name(Me.PortalId, Cr.Salary_ID) & "</div>"
                        litHot.Text += "</div>"
                        litHot.Text += "<div class=""col-md-4 col-xs-4 pl0 pdr0"">"
                        litHot.Text += "<i class=""icon-address icon_16""></i>"
                        litHot.Text += "<div class=""pl_28 lsaddress"">" & flDic.RegionalName(Cr.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "TP.") & "</div>"
                        litHot.Text += "</div>"
                        litHot.Text += "<div class=""col-md-4 col-xs-4 pl0 pdr0"">"
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

                    flCache.SetCache("CMS_Work_List_Pages_1_3_" & SearchID.Value & "_" & 1, litHot.Text, SecondCache.M1)
                    For Each Cr As CMS_WorkInfo In arr
                        litVal.Text += flReg.NextPage(Cr.Total, 20, currPage.Value, 5, vUrl.Value & "/p/")
                        str = "<div class=""row""><div class=""box_title_content"">"
                        str += "<h1 class=""title_title_box"">" & CareerName.Value & " (" & Cr.Total & ")</h1>"
                        str += "</div></div>"
                        litVal.Text = str & litVal.Text
                        Exit For
                    Next
                End If
            End If
        End Sub
        Private Sub LoadList()
            litVal.Text = flCache.GetCache("CMS_Work_List_Pages" & currPage.Value & "_" & SearchID.Value & "_" & 0) & ""
            If litVal.Text = "" Then
                litVal.Text = "<div class=""list-items"">"
                arr = objContrller.CMS_Work_List_Pages(Me.PortalId, currPage.Value, 20, CareerID.Value, TinhTP.Value, EducationID.Value, JobPlaceID.Value, SalaryID.Value, Experienceid.Value, Genner.Value, CMS.Ultis.FullTextSearch(Title.Value.Replace("-", ""), False), 0)
                For Each Cr As CMS_WorkInfo In arr
                    litVal.Text += "<div class=""row"">"
                    litVal.Text += "<div class=""col-md-6 col-xs-4"">"
                    litVal.Text += "<span class=""span-tw"">"
                    litVal.Text += "<a href=""" & flCheck.GetHomeLinkWork(Cr.Title, Cr.ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""text_grey2"">" & Cr.Title & "</a>"
                    litVal.Text += "</span>"
                    litVal.Text += "</div>"
                    litVal.Text += "<div class=""col-md-2 col-xs-3"">"
                    litVal.Text += "<i class=""icon-money icon_16""></i><br>"
                    litVal.Text += "<span>" & flCheck.Salary_Name(Me.PortalId, Cr.Salary_ID) & "</span>"
                    litVal.Text += "</div>"
                    litVal.Text += "<div class=""col-md-2 col-xs-2"">"
                    litVal.Text += "<i class=""icon-address icon_16""></i><br>"
                    litVal.Text += "<span class=""lsaddress"">" & flDic.RegionalName(Me.PortalId, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "TP.") & "</span>"
                    litVal.Text += "</div>"
                    litVal.Text += "<div class=""col-md-2 col-xs-3"">"
                    litVal.Text += "<i class=""icon-countdown icon_16""></i><br>"
                    litVal.Text += "<span>" & flReg.ReadDate(Cr.ExpiredDate, False) & "</span>"
                    litVal.Text += "</div>"
                    litVal.Text += "<div class=""line_list""></div>"
                    litVal.Text += "</div>"
                Next
                litVal.Text += "</div>"
                litVal.Text += "<div class=""clear""></div>"
                For Each Cr As CMS_WorkInfo In arr
                    litVal.Text += flReg.NextPage(Cr.Total, 20, currPage.Value, 5, vUrl.Value & "/p/")
                    str = "<div class=""row""><div class=""box_title_content"">"
                    str += "<h1 class=""title_title_box"">" & CareerName.Value & " (" & Cr.Total & ")</h1>"
                    str += "</div></div>"
                    litVal.Text = str & litVal.Text
                    Exit For
                Next
                flCache.SetCache("CMS_Work_List_Pages" & currPage.Value & "_" & SearchID.Value & "_" & 0, litVal.Text, SecondCache.M1)
            End If
        End Sub
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    Call LoadHot()
                    Call LoadList()
                End If
            Catch ex As Exception
                litHot.Text = ex.Message
                flReg.BugLog(Me.PortalId, ex.Message, "works")
            End Try
        End Sub
    End Class
End Namespace