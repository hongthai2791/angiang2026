Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Work
    Partial Class WorksList
        Inherits Entities.Modules.PortalModuleBase
        Dim objContrller As New WorkController
        Dim arr As New ArrayList
        Dim obj As New CMS_SearchInfo
        Dim cInfo As New CMS_CareerInfo
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
                cInfo = objContrller.CMS_Career_Get_ID(Me.PortalId, sId)
                If IsNothing(cInfo) = False Then
                    CareerID.Value = cInfo.Career_ID
                    CareerCode.Value = cInfo.ID
                End If
            Else
                If flReg.WriteNumber(Request.Item("search")) > 0 Then
                    obj = objContrller.CMS_Search_Get(Me.PortalId, Request.Item("search"))
                    If IsNothing(obj) = False Then
                        SearchID.Value = obj.ID
                        Title.Value = obj.TuKhoa
                        SearchID.Value = obj.ID
                        CareerID.Value = obj.NganhNghe
                        TinhTP.Value = obj.TinhTP
                        SalaryID.Value = obj.MucLuong
                        ExperienceId.Value = obj.KinhNghiem
                        Title.Value = obj.TuKhoa
                    End If
                End If
            End If
            If TinhTP.Value = "" Then TinhTP.Value = "0"
        End Sub
        Private Sub LoadValue()
            If CareerID.Value = "" Then
                litVal.Text = flCache.GetCache("CMS_Career_List_Job_" & Me.PortalId & "_" & SearchID.Value) & ""
                If litVal.Text = "" Then
                    For Each Cr As CMS_CareerInfo In objContrller.CMS_Career_List_Job(Me.PortalId, 16)
                        litVal.Text += LoadJob(Cr.Career_ID, Cr.ID, 5)
                    Next
                    flCache.SetCache("CMS_Career_List_Job_" & Me.PortalId & "_" & SearchID.Value, litVal.Text, SecondCache.M2)
                End If
            Else
                litVal.Text = flCache.GetCache("CMS_Career_List_Job_" & Me.PortalId & "_" & CareerID.Value & "_" & SearchID.Value) & ""
                If litVal.Text = "" Then
                    cInfo = objContrller.CMS_Career_Get(Me.PortalId, CareerID.Value)
                    If IsNothing(cInfo) = False Then
                        litVal.Text = LoadJob(cInfo.Career_ID, cInfo.ID, 20)
                        flCache.SetCache("CMS_Career_List_Job_" & Me.PortalId & "_" & cInfo.Career_ID & "_" & SearchID.Value, litVal.Text, SecondCache.M2)
                    End If
                End If
            End If
        End Sub
        Private Function LoadJob(CareerID As String, code As Integer, top As Integer) As String
            LoadJob = ""
            arr = objContrller.CMS_JobUser_List_Home(Me.PortalId, CMS.Ultis.FullTextSearch(Title.Value, False), currPage.Value, top, CareerID, SalaryID.Value, ExperienceId.Value, TinhTP.Value)
            If arr.Count > 0 Then
                LoadJob = "<div class=""list-items"">"
                For Each Cr As CMS_JobUserInfo In arr
                    LoadJob += "<div class=""row"">"
                    LoadJob += "<div class=""col-md-6 col-xs-4"">"
                    LoadJob += "<span class=""span-tw"">"
                    LoadJob += "<a href=""" & flCheck.GetHomeLinkJobUser(Cr.JobUser_ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""text_grey2"">" & Cr.Title & "</a>"
                    LoadJob += "</span>"
                    LoadJob += "</div>"
                    LoadJob += "<div class=""col-md-2 col-xs-3"">"
                    LoadJob += "<i class=""icon-money icon_16""></i><br>"
                    LoadJob += "<span>" & IIf(Cr.Salary_ID = "", "Thỏa thuận", flCheck.Salary_Name(Me.PortalId, Cr.Salary_ID)) & "</span>"
                    LoadJob += "</div>"
                    LoadJob += "<div class=""col-md-2 col-xs-2"">"
                    LoadJob += "<i class=""icon-address icon_16""></i><br>"
                    LoadJob += "<span class=""lsaddress"">" & flDic.RegionalName(Me.PortalId, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "TP.") & "</span>"
                    LoadJob += "</div>"
                    LoadJob += "<div class=""col-md-2 col-xs-3"">"
                    LoadJob += "<i class=""icon-countdown icon_16""></i><br>"
                    LoadJob += "<span>" & flReg.ReadDate(Cr.StartDate, False) & "</span>"
                    LoadJob += "</div>"
                    LoadJob += "<div class=""line_list""></div>"
                    LoadJob += "</div>"
                Next
                LoadJob += "</div>"
                LoadJob += "<div class=""clear""></div>"
                For Each Cr As CMS_JobUserInfo In arr
                    If top > 10 Then litVal.Text += flReg.NextPage(Cr.Total, 20, currPage.Value, 5, vUrl.Value & "/p/")
                    str = "<div class=""row"">"
                    CareerName.Value = flCheck.Career_Name(Me.PortalId, CareerID)
                    str += "<h2 class=""title_text_line""><span class=""text-tim-nhat""><a href=""/ho-so-xin-viec/nganh-nghe/" & flReg.NameUrl(CareerName.Value) & "-" & code & ".html"">" & CareerName.Value & " (" & Cr.Total & ")</span></h2>"
                    str += "</div>"
                    LoadJob = str & LoadJob
                    Exit For
                Next
            End If
        End Function
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    Call LoadValue()
                End If
            Catch ex As Exception
                litVal.Text += ex.Message
                flReg.BugLog(Me.PortalId, ex.Message, "works")
            End Try
        End Sub
    End Class
End Namespace
