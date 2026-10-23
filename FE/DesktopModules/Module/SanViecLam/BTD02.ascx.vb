Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK


Namespace DesktopModules.Modules

    Partial Class BTD02
        Inherits PortalModuleBase
        Dim IsLang As String = System.Threading.Thread.CurrentThread.CurrentCulture.Name
        Dim objController As New WorkController
        Dim arrTemp As New ArrayList
        Dim objSVLDN As New CMS_DoanhNghiepInfo
        Dim _objPhien As New CMS_PhienGiaoDichInfo

        Public Property PhienGD_ID() As String
            Get
                Return ItemID.Value
            End Get
            Set(ByVal value As String)
                ItemID.Value = value
            End Set
        End Property

        Shared DienRa As Integer = 0
        Public Property Business_ID() As String
            Get
                Return hiddeBusiness_ID.Value
            End Get
            Set(ByVal value As String)
                hiddeBusiness_ID.Value = value
            End Set
        End Property

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Call LoadValues()
                End If
            Catch ex As Exception
            End Try
        End Sub

        Public Sub LoadValues()
            arrTemp = objController.CMS_DoanhNghiep_UngVien_Get_By_Business(Me.PortalId, PhienGD_ID, Business_ID)
            If arrTemp.Count > 0 Then
                For Each Cr As CMS_DoanhNghiep_UngVienInfo In arrTemp
                    Session.Item("BTD02") = Cr.Total
                    litPage.Text = flReg.NextPageJs(Cr.Total, 20, 1, 10, "nextpage_uv(")
                    Exit For
                Next
                dgrDanhSachUngVien.DataSource = arrTemp
                dgrDanhSachUngVien.DataBind()
                dgrDanhSachUngVien.Visible = True

            Else
                litPage.Text = "<h2 class=""noti-none"">Hiện sàn chưa có ứng viên nào tham gia.</h2>"
                Session.Item("BTD02") = "0"
                dgrDanhSachUngVien.Visible = False
            End If
        End Sub

    End Class

End Namespace