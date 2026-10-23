Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Work
    Partial Class WorksList
        Inherits Entities.Modules.PortalModuleBase
        Dim objContrller As New WorkController
        Dim arr As New ArrayList
        Dim obj As New CMS_SearchInfo
        Private Sub GetID()
            vUrl.Value = Request.RawUrl
            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If vUrl.Value.Contains("/p/") Then
                vUrl.Value = vUrl.Value.Substring(0, vUrl.Value.LastIndexOf("/p/"))
                currPage.Value = flReg.WriteNumber(CMS.flCheck.RequestItem(Request.RawUrl, "p"))
            End If
            If currPage.Value = 0 Then currPage.Value = 1
            Title.Value = CMS.flCheck.DecodeSearch(Request.Item("key") & "")

            If flReg.WriteNumber(Request.Item("search")) > 0 Then
                obj = objContrller.CMS_Search_Get(Me.PortalId, Request.Item("search"))
                If IsNothing(obj) = False Then
                    SearchID.Value = obj.ID
                    Title.Value = obj.TuKhoa
                End If
            End If
        End Sub
        Private Sub LoadList()
            litVal.Text = ""'flCache.GetCache("CMS_Work_List_Pages" & currPage.Value & SearchID.Value) & ""
            If litVal.Text = "" Then
                arr = objContrller.CMS_Business_List_View_Home(Me.PortalId, txtkey.Text, currPage.Value, 20)
                litVal.Text += "<div class=""row"">"
                For Each Cr As CMS_BusinessInfo In arr
                    litVal.Text += "<div class=""col-md-4 pdl0 pdr0"">"
                    litVal.Text += "<div class=""bd-hm-w"">"
                    litVal.Text += "<a href=""" & flCheck.GetHomeLinkBusiness(Cr.Business_ID) & """ title=""" & flReg.ImgAlt(Cr.Business_Vn) & """>"
                    litVal.Text += "<img src=""" & flReg.ImgSRC(flCheck.Business_Logo(Cr.PortalId, Cr.Business_ID), 120, 100) & """ alt=""" & flReg.ImgAlt(Cr.Business_Vn) & """ />"
                    litVal.Text += "<div Class=""hm-w-title"">" & Cr.Business_Vn & "</div>"
                    litVal.Text += "</div>"
                    litVal.Text += "</div>"
                Next
                litVal.Text += "</div>"
                litVal.Text += "<div class=""clear""></div>"
                For Each Cr As CMS_BusinessInfo In arr
                    litVal.Text += flReg.NextPage(Cr.Total, 20, currPage.Value, 5, vUrl.Value & "/p/")
                    Exit For
                Next
                flCache.SetCache("CMS_Work_List_Pages" & currPage.Value & SearchID.Value, litVal.Text, SecondCache.M1)
            End If
        End Sub
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    Call LoadList()
                End If
            Catch ex As Exception
                flReg.BugLog(Me.PortalId, ex.Message, "works")
            End Try
        End Sub
    End Class
End Namespace