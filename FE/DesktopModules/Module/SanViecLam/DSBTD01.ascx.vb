Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK


Namespace DesktopModules.Modules

    Partial Class DSBTD01
        Inherits PortalModuleBase
        Dim objController As New WorkController
        Dim arrTemp, arr As New ArrayList
        Dim iCount As Integer
        Public Property PhienGD_ID() As String
            Get
                Return ItemID.Value
            End Get
            Set(ByVal value As String)
                ItemID.Value = value
            End Set
        End Property
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Call LoadValue()
                End If
            Catch ex As Exception
                litV.Text = ex.Message
            End Try
        End Sub

        Public Sub LoadValue()
            arrTemp = objController.CMS_DoanhNghiep_List_Home(Me.PortalId, "", "", 0, PhienGD_ID)
            If arrTemp.Count > 0 Then
                litV.Text = "<div class=""lb-svl"">"
                iCount = 1
                For Each Cr As CMS_DoanhNghiepInfo In arrTemp
                    arr = objController.CMS_TuyenDung_List_By_PhienGD(Me.PortalId, PhienGD_ID, Cr.Business_ID)
                    litV.Text += "<div class=""col-md-3 col-xs-6"">"
                    litV.Text += "<div class=""svl_item"">"
                    litV.Text += "<div class=""svl_cantuyen"">Cần tuyển: <span>" & arr.Count & "</span></div>"

                    litV.Text += "<div class=""svl_doanhnghiep parentLink"">"
                    litV.Text += "<a href=""" & NavigateToRescruitTable(Cr.Business_ID) & """ class=""button white icon"">"
                    litV.Text += "<div class=""svl_tendn"">" & Cr.Business_Vn & "</div>"
                    litV.Text += "<div class=""svl_logo""><img alt=""logo"" src=""" & flReg.ImgSRC(Cr.Logo, 0, 80) & """/></div>"
                    litV.Text += "</a>"
                    litV.Text += "<div class=""marker none"">"
                    For Each Cj As CMS_WorkInfo In arr
                        litV.Text += "<li class=""market-li"">"
                        litV.Text += "<a target=""_bank"" href=""/viec-lam/" & flCheck.LinkUrl(Cj.Title, Cj.ID, "VL") & """ title=""" & flReg.ImgAlt(Cj.Title) & """>" & Cj.Title & "</a>"
                        litV.Text += "</li>"
                    Next
                    litV.Text += "</div>"
                    litV.Text += "</div>"
                    litV.Text += "<div Class=""col-md-6 col-xs-6""><div Class=""svl_ungvien"">Ứng viên: <b>" & Cr.SoLuongUngVien & "</b></div></div>"
                    litV.Text += "<div class=""col-md-6 col-xs-6 txt-right""><img onclick=""addFav(this); return false;"" class=""addfav"" data-value=""" & Cr.Business_ID & """ src=""/image/svl/saoout.png""></div>"
                    litV.Text += "</div>"
                    litV.Text += "</div>"
                    If iCount = 4 Then
                        litV.Text += "<div class=""clear""></div>"
                        iCount = 0
                    End If
                    iCount += 1
                Next
                litV.Text += "<div class=""clear""></div>"
                litV.Text += "</div>"
                Session.Item("DSBTD01") = arrTemp.Count
            Else
                Session.Item("DSBTD01") = "0"
                litV.Text = "<h2 class=""noti-none"">Chưa có doanh nghiệp nào tham gia.</h2>"
            End If
        End Sub
        Public Function NavigateToRescruitTable(ByVal params As String) As String
            Return "/san-viec-lam/ban-tuyen-dung/itemid/" & PhienGD_ID & "/busid/" & params.ToLower
        End Function

    End Class

End Namespace