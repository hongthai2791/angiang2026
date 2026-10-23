Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Modules

    Public MustInherit Class Related
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjControler As New CmsController
        Dim arrTemp, arrTemp1 As New ArrayList

        Private Sub GetID()
            CategoryId.Value = flCheck.GetCateID_WebTabID(Me.PortalId, PortalSettings.ActiveTab.TabID)
            NewsId.Value = flReg.WriteNumber(Ultis.GetRequestId(Request.RawUrl))
        End Sub

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    Call GetID()
                    Call LoadValue()
                End If
            Catch ex As Exception
                flReg.BugLog(Me.PortalId, ex.Message, "cms")
            End Try
        End Sub
        Private Sub LoadValue()
            If litNews.Text = "" Then
                arrTemp1 = ObjControler.CMS_News_SameCate(PortalId, Me.PortalId, NewsId.Value, -1, 5)
                If arrTemp1.Count > 0 Then

                    For Each Cr1 As CMS_NewsInfo In arrTemp1
                        litNews.Text += "<div class=""list-news-tt"">"
                        litNews.Text += "<div class=""col-md-12"">"
                        litNews.Text += "<h2 class=""list-news-title""><a class=""tag-link"" href=""" & Ultis.FormatLink(Me.PortalId, Cr1.CategoryId, Cr1.NewId, Cr1.ToUrl) & """ title=""" & flReg.ImgAlt(Cr1.Title) & """>" & Cr1.Title & "</a></h2>"
                        litNews.Text += "<span class=""list-news-time"">" & flReg.ReadDate(Cr1.PublishedDate) & "</span>"
                        litNews.Text += "</div><div class=""clear""></div></div>"
                    Next
                End If
                litNews.Text += "<div class=""clear""></div>"
            End If
            flCache.SetCache("NewsRelated_ListCateContent_" & Me.PortalId & "_" & CategoryId.Value & "_", litNews.Text, SecondCache.M3)
        End Sub
    End Class

End Namespace

