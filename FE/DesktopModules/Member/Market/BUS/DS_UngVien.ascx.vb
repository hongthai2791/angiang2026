Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.DS_UngVien

    Partial Class View
        Inherits PortalModuleBase
        Dim objController As New WorkController
        Dim arrTemp, arrTemp1 As New ArrayList
        Dim drList As DropDownList
        Dim liter As Literal
        Dim i, j, ctotal As Integer


#Region "Property"
        Public Property PhienGD_ID() As String
            Get
                Return ItemID.Value
            End Get
            Set(ByVal value As String)
                ItemID.Value = value
            End Set
        End Property

        Public Property Business_ID() As String
            Get
                Return hidBusiness_ID.Value
            End Get
            Set(ByVal value As String)
                hidBusiness_ID.Value = value
            End Set
        End Property
        Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            Try
                Business_ID = Request.Item("busid") & ""
                PhienGD_ID = Request.Item("itemid") & ""
                Call LoadValues()
            Catch ex As Exception
            End Try
        End Sub

        Public Sub LoadValues()
            arrTemp = objController.CMS_DoanhNghiep_UngVien_Get_By_Business_file_UngVien(Me.PortalId, PhienGD_ID, Business_ID)
            If arrTemp.Count > 0 Then
                grdData.DataSource = arrTemp
                grdData.DataBind()
                grdData.Visible = True
                Session.Item("DS_UngVien") = arrTemp.Count
            Else
                Session.Item("DS_UngVien") = "0"
                grdData.Visible = False
            End If


        End Sub

        Public Sub KetQuaPhongVan(ByVal kq As DropDownList)
            kq.Items.Clear()
            kq.Items.Add(New ListItem("Chọn kết quả", 0))
            kq.Items.Add(New ListItem("Đạt", 1))
            kq.Items.Add(New ListItem("Không đạt", 2))
            kq.Items.Add(New ListItem("Hẹn phỏng vấn lại", 3))
            kq.Items.Add(New ListItem("Trúng sơ tuyển", 4))
        End Sub
        Private Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            'liter = e.Item.FindControl("TrangThai")
            'If flCheck.SVL_TinhTrangUngVien(Me.PortalId, PhienGD_ID, DataBinder.Eval(e.Item.DataItem, "TuyenDung_ID"), DataBinder.Eval(e.Item.DataItem, "NguoiTimViec_ID")) Then
            '    liter.Text += "<span class='label label-info' >Tự nộp</span"
            'Else
            '    liter.Text += "<span class='label label-success' >DN mời nộp</span"
            'End If

            drList = e.Item.FindControl("KetQuaPhongVan")
            Call KetQuaPhongVan(drList)
                drList.SelectedValue = DataBinder.Eval(e.Item.DataItem, "KetQuaPhongVan")
                drList.Attributes("onchange") = "updatevalue(this,'" & DataBinder.Eval(e.Item.DataItem, "DNUV_ID") & "')"




        End Sub

        Private Sub cmdUpdateValue_Click(sender As Object, e As EventArgs) Handles cmdUpdateValue.Click
            Try
                objController.CMS_DoanhNghiep_Update_KetQua(Me.PortalId, DNUV_ID.Value, KQPV.Value, Now, Me.UserInfo.Username)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "removewaiting(); notify('success','Đã cập nhật lại kết quả phỏng vấn.', 'Thông báo', false);", True)
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "thong_bao", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "work") & "', 'Thông báo', false);", True)

            End Try
        End Sub
#End Region

    End Class

End Namespace