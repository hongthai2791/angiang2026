Imports DotnetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules
    Public MustInherit Class Read
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController
        Public strFb As String
        Dim obj As New CMS_BusinessInfo
        Dim arr As New ArrayList
        Dim UrlAlias As String = flReg.UrlAlias
        Dim str() As String, careInfo As CMS_CareerInfo
        Private Sub GetID()
            strFb = NavigateURL() & Request.RawUrl.Substring(Request.RawUrl.LastIndexOf("/"))
            ItemID.Value = CMS.Ultis.GetRequestId(Request.RawUrl)

            obj = CType(flCache.GetCache("CMS_Business_Get_ID_" & ItemID.Value), CMS_BusinessInfo)
            If IsNothing(obj) Then
                obj = New WorkController().CMS_Business_Get_ID(PortalId, ItemID.Value)
                flCache.SetCache("CMS_Business_Get_ID_" & ItemID.Value, obj, SecondCache.M30)
            End If
        End Sub
        Private Sub LoadValue()
            Call GetID()
            If IsNothing(obj) = False Then
                Business_Vn.Text = obj.Business_Vn
                Business_Info.Text = "<div class='col-md-12 pdl0'><span class='fa fa-map'></span> Địa chỉ: " & obj.Address & "</div>"
                Business_Info.Text += "<div class='col-md-12 pdl0'><span class='fa fa-users'></span> Quy mô: " & obj.Scale & "</div>"
                Business_Info.Text += "<div class='col-md-12 pdl0'><span class='fa fa-internet-explorer'> </span> Website: " & obj.Website & "</div>"
                Business_Img.Text = "<div class=""al-logo""><img src=""" & flReg.ImgSRC(obj.Logo, 150, 94, False) & """ alt='" & obj.Business_Vn & "' /></div>"
                If obj.IsApproval Then
                    Business_Img.Text += "<img class=""al-ac"" src='/image/ok.png?dpi=150&quality=100&w=90&h=90' title='Đã xác thực' alt='Đã xác thực' />"
                Else
                    Business_Img.Text += "<img class=""al-ac"" src='/image/unok.png?dpi=150&quality=100&w=90&h=90' title='Chưa xác thực alt='Chưa xác thực' />"
                End If
                Description.Text = "<div class='col-md-12 des-company'>" & obj.Description & "</div>"
                BusWorkTitle.Text = "VIỆC LÀM " & obj.Business_Vn.ToUpper & " TUYỂN DỤNG"
                litSEO.Text = JsSeo(obj)
                If Me.UserInfo.Username <> "" Then
                    FollowBusiness.Text = "<a onclick='popFollow(" & Me.PortalId & ",""" & obj.Business_ID & """,""" & Me.UserInfo.Username & """);'  title='Theo dõi nhà tuyển dụng' class=""btn btn-info"" style=""padding: 0 5px;float:right;""><i class=""fa fa-check-circle"" aria-hidden=""true""></i>Theo dõi</a>"
                End If
            End If
        End Sub
        Private Sub LoadWorkList()
            WorkList.Text = flCache.GetCache("CMS_Work_List_By_Business_Home_" & currPage.Value & ItemID.Value & "")
            If WorkList.Text = "" Then
                WorkList.Text = "<div class=""list-items"">"
                arr = objController.CMS_Work_List_By_Business_Home(Me.PortalId, obj.Business_ID, Me.PortalId, currPage.Value, 20)
                For Each Cr As CMS_WorkInfo In arr
                    WorkList.Text += "<div class=""row"">"
                    WorkList.Text += "<div class=""col-md-6 col-xs-6"">"
                    WorkList.Text += "<span class=""span-tw"">"
                    WorkList.Text += "<a href=""" & flCheck.GetHomeLinkWork(Cr.Title, Cr.ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """ class=""text_grey2"">" & Cr.Title & "</a>"
                    WorkList.Text += "</span>"
                    WorkList.Text += "</div>"
                    WorkList.Text += "<div class=""col-md-2 col-xs-2"">"
                    WorkList.Text += "<i class=""icon-money icon_16""></i><br>"
                    WorkList.Text += "<span>" & flCheck.Salary_Name(Me.PortalId, Cr.Salary_ID) & "</span>"
                    WorkList.Text += "</div>"
                    WorkList.Text += "<div class=""col-md-2 col-xs-2"">"
                    WorkList.Text += "<i class=""icon-address icon_16""></i><br>"
                    WorkList.Text += "<span class=""lsaddress"">" & flDic.RegionalName(0, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "TP.") & "</span>"
                    WorkList.Text += "</div>"
                    WorkList.Text += "<div class=""col-md-2 col-xs-2"">"
                    WorkList.Text += "<i class=""icon-countdown icon_16""></i><br>"
                    WorkList.Text += "<span>" & flReg.ReadDate(Cr.ExpiredDate, False) & "</span>"
                    WorkList.Text += "</div>"
                    WorkList.Text += "<div class=""line_list""></div>"
                    WorkList.Text += "</div>"
                Next
                WorkList.Text += "</div>"
                WorkList.Text += "<div class=""clear""></div>"
                For Each Cr As CMS_WorkInfo In arr
                    WorkList.Text += flReg.NextPage(Cr.Total, 20, currPage.Value, 5, vUrl.Value & "/p/")
                    Exit For
                Next
                flCache.SetCache("CMS_Work_List_By_Business_Home_" & currPage.Value & ItemID.Value & "", WorkList.Text, SecondCache.M10)
            End If
        End Sub
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Not IsPostBack Then
                Try
                    Call LoadValue()
                    Call LoadWorkList()
                Catch ex As Exception
                    flReg.BugLog(Me.PortalId, ex.Message, "works")
                    Title.Text = ex.Message
                End Try
            End If
        End Sub
        Private Function JsSeo(obj As CMS_BusinessInfo) As String
            JsSeo = "<script type=""application/ld+json"">"
            JsSeo += "{"
            JsSeo += """@context"": ""http://schema.org"", ""@type"": ""NewsArticle"","
            JsSeo += """mainEntityOfPage"":"
            JsSeo += "{ "
            JsSeo += """@type"":""WebPage"","
            JsSeo += """@id"":""" & flCheck.GetHomeLinkBusiness(obj.ID) & """},"
            JsSeo += """headline"": """ & flReg.Trimstr(flReg.ImgAlt(obj.Business_Vn), 110) & ""","
            JsSeo += """description"": """ & flReg.ImgAlt(obj.Business_Vn) & ""","
            JsSeo += """image"": {""@type"": ""ImageObject"","
            JsSeo += """url"": """ & flConnect.fileDomain & "/favicon.png"","
            JsSeo += """width"" : 800,""height"" : 800},"
            JsSeo += """datePublished"": """ & obj.ApprovalDate & ""","
            JsSeo += """dateModified"": """ & obj.UpdatedDate & ""","
            JsSeo += """author"": {""@type"": ""Person"", ""name"": """ & obj.CreatedUser & """ },"
            JsSeo += """publisher"": { ""@type"": ""Organization"", ""name"": """ & flReg.UrlAlias & ""","
            JsSeo += """logo"": { ""@type"": ""ImageObject"","
            JsSeo += """url"": """ & flConnect.fileDomain & "/favicon.png"","
            JsSeo += """width"": 100, ""height"": 60}"
            JsSeo += "}"
            JsSeo += "}"
            JsSeo += "</script>"
        End Function

    End Class
End Namespace