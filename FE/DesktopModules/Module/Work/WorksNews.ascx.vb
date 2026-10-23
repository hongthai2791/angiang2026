Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules.Work
    Partial Class WorksNews
        Inherits Entities.Modules.PortalModuleBase

        Private Sub LoadValue()
            For Each Cr As CMS_WorkInfo In New WorkController().CMS_Work_List_Home(Me.PortalId, -1, 7, "")
                litview.Text += "<div class=""recruitment"">"
                litview.Text += "<a class=""name-work"" href=""" & flCheck.GetHomeLinkWork(Cr.Title, Cr.ID) & """ title=""" & flReg.ImgAlt(Cr.Title) & """><span>" & Cr.Title & "</span></a>"
                litview.Text += "<span class=""name-user"">" & flCheck.Business_Vn(Cr.PortalID, Cr.Business_ID) & "</span>"
                litview.Text += "<span class=""salary col-md-6 col-xs-6 pdl0"">"
                litview.Text += "<i class=""fa fa-usd"" aria-hidden=""true""></i>"
                litview.Text += "<span>" & flCheck.Salary_Name(Me.PortalId, Cr.Salary_ID) & "</span>"
                litview.Text += "</span>"
                litview.Text += "<span class=""address col-md-6 col-xs-6 pdr0"">"
                litview.Text += "<i class=""fa fa-map-marker"" aria-hidden=""true""></i>"
                litview.Text += "<span>" & flDic.RegionalName(Cr.PortalID, Cr.TinhTP, Cr.QuanHuyen).Replace("Thành phố", "TP.") & "</span>"
                litview.Text += "</span>"
                litview.Text += "<div class=""clear""></div>"
                litview.Text += "</div>"
            Next
        End Sub
        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                litview.Text = flCache.GetCache("WorksNews_" & Me.PortalSettings.ActiveTab.TabID) & ""
                If litview.Text = "" Then
                    Call LoadValue()
                    flCache.SetCache("WorksNews_" & Me.PortalSettings.ActiveTab.TabID, litview.Text, SecondCache.M1)
                End If
            End If
        End Sub
    End Class
End Namespace