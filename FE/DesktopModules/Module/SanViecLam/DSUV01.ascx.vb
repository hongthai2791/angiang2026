Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace DesktopModules.Modules

    Partial Class DSUV01
        Inherits PortalModuleBase
        Dim objController As New WorkController
        Dim arrTemp As New ArrayList

        Public Property PhienGD_ID() As String
            Get
                Return ItemID.Value
            End Get
            Set(ByVal value As String)
                ItemID.Value = value
            End Set
        End Property

        Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            Try
                Call LoadValues()
            Catch ex As Exception
                litPage.Text = ex.Message
            End Try
        End Sub

        Public Sub LoadValues()
            arrTemp = objController.CMS_UngVien_List_PhienGD_ID(Me.PortalId, PhienGD_ID)
            If arrTemp.Count > 0 Then
                For Each Cr As CMS_UngVienInfo In arrTemp
                    Session.Item("DSUV01") = Cr.Total
                    litPage.Text = flReg.NextPageJs(Cr.Total, 20, 1, 10, "nextpage_uv(")
                    Exit For
                Next
                dgrDanhSachUngVien.DataSource = arrTemp
                dgrDanhSachUngVien.DataBind()
                dgrDanhSachUngVien.Visible = True

            Else
                litPage.Text = "<h2 class=""noti-none"">Hiện sàn chưa có ứng viên nào tham gia.</h2>"
                Session.Item("DSUV01") = "0"
                dgrDanhSachUngVien.Visible = False
            End If
        End Sub

    End Class

End Namespace