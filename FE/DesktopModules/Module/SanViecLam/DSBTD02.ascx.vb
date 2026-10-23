Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace DesktopModules.Modules

    Partial Class DSBTD02
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

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Call InitData()
                    Call LoadValues()
                End If
            Catch ex As Exception
                litPage.Text = ex.Message
            End Try
        End Sub

        Private Sub InitData()
            Call flFunction.LoadCareer(Me.PortalId, nganhNghe, "Tất cả Ngành nghề")
            Call flDic.LoadPosition(Me.PortalId, chucVu, "Tất cả Chức danh")
            Call flDic.LoadEducation(Me.PortalId, trinhDo, "Tất cả Trình độ")
        End Sub

        Public Sub LoadValues()
            arrTemp = objController.CMS_Work_List_By_PhienGD(Me.PortalId, PhienGD_ID, nganhNghe.SelectedValue, chucVu.SelectedValue, trinhDo.SelectedValue, sapXep.SelectedValue, curentPage.Value, 20)
            If arrTemp.Count > 0 Then
                drgRecruitment.DataSource = arrTemp
                drgRecruitment.DataBind()
                drgRecruitment.Visible = True
                For Each Cr As CMS_WorkInfo In arrTemp
                    litPage.Text = "<div class=""a2-head"">" & flReg.NextPageJs(Cr.Total, 20, 1, 10, "nextpage_02(") & "</div>"
                    Session.Item("DSBTD02") = Cr.Total
                    Exit For
                Next
            Else
                litPage.Text = "<h2 class=""noti-none"">Hiện sàn chưa có việc làm nào.</h2>"
                Session.Item("DSBTD02") = "0"
                drgRecruitment.Visible = False
            End If
        End Sub

        Protected Sub chucVu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chucVu.SelectedIndexChanged, nganhNghe.SelectedIndexChanged, trinhDo.SelectedIndexChanged, sapXep.SelectedIndexChanged, cmdNext.Click
            Call LoadValues()
        End Sub

    End Class

End Namespace