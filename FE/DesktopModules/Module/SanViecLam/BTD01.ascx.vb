Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK


Namespace DesktopModules.Modules

    Partial Class BTD01
        Inherits PortalModuleBase
        Dim objController As New WorkController
        Dim objInfo As CMS_DoanhNghiepInfo
        Dim arrTemp As New ArrayList

        Public Property Business_ID() As String
            Get
                Return hiddeBusiness_ID.Value
            End Get
            Set(ByVal value As String)
                hiddeBusiness_ID.Value = value
            End Set
        End Property
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
                    Call LoadValues()
                End If
            Catch ex As Exception
                litV.Text = ex.Message
            End Try

        End Sub

        Public Sub LoadValues()
            arrTemp = objController.CMS_TuyenDung_List_By_PhienGD(Me.PortalId, PhienGD_ID, Business_ID)
            If arrTemp.Count > 0 Then
                litV.Text = "<div class=""a2-head"">"
                For Each Cr As CMS_WorkInfo In arrTemp
                    litV.Text += "<div class=""svl_tuyendung"">"
                    litV.Text += "<div class=""col-md-9 bdright"">"
                    litV.Text += "<div class=""bt-tenvl"">" & Cr.Title & "</div>"
                    litV.Text += "<div><i class=""icon-quantity icon_16""></i><div class=""pl_28"">Số lượng tuyển dụng:<strong>" & Cr.Quantity & "</strong></div></div>"
                    litV.Text += "<div><i class=""icon-age icon_16""></i><div class=""pl_28"">Vị trí tuyển dụng: <strong>" & flDic.Position_Name(Me.PortalId, Cr.LevelDesired_ID) & "</strong></div></div>"
                    litV.Text += "<div><i class=""icon-money icon_16""></i><div class=""pl_28"">Mức lương: <strong>" & flCheck.Salary_Name(Me.PortalId, Cr.Salary_ID) & "</strong></div></div>"
                    litV.Text += "</div>"
                    litV.Text += "<div class=""col-md-3 txt-center pdt30"">"
                    litV.Text += "<a href=""/viec-lam/" & flCheck.LinkUrl(Cr.Title, Cr.ID, "VL") & """ target=""_blank"">"
                    litV.Text += "<i class=""fa fa-eye img-xem-ct"" aria-hidden=""true""></i>Xem chi tiết</a>"
                    litV.Text += "</div>"
                    litV.Text += "<div class=""clear""></div>"
                    litV.Text += "</div>"
                Next
                litV.Text += "</div>"

                Session.Item("BTD01") = arrTemp.Count
            Else
                Session.Item("BTD01") = "0"
            End If
        End Sub

    End Class

End Namespace

