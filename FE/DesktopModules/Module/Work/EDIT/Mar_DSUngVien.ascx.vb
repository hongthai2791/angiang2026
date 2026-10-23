Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK
Imports DotNetNuke.EPORTAL

Namespace Modules.SVL.Mar_DSUngVien

    Partial Class View
        Inherits PortalModuleBase
        Dim objController As New WorkController
        Dim arrTemp, arrTemp1 As New ArrayList
        Dim liter As Literal
        Public Property PhienGD_ID() As String
            Get
                Return DSUngVien_ItemID.Value
            End Get
            Set(ByVal value As String)
                DSUngVien_ItemID.Value = value
            End Set
        End Property

        Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            'Try
            '    PhienGD_ID = Request.Item("itemid")
            '    Call LoadValue()
            'Catch ex As Exception
            'End Try
            Try
                PhienGD_ID = Request.Item("itemid")
                Mar_DSMoiUV.PGDId = PhienGD_ID
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Public Sub onCommandEvent(ByVal sender As Object, ByVal e As CommandEventArgs)
            Dim UngVien_ID As String = e.CommandArgument
            arrTemp1 = objController.CMS_DoanhNghiep_UngVien_Get_By_UngVien_ID(Me.PortalId, PhienGD_ID, UngVien_ID)
            If arrTemp1.Count > 0 Then
                GridView1.DataSource = arrTemp1
                GridView1.DataBind()
                DSUngVienKQ.Text = ""
            Else
                GridView1.DataSource = Nothing
                GridView1.DataBind()
                DSUngVienKQ.Text = "Hiện tại ứng viên chưa tham gia phỏng vấn ở doanh nghiệp nào!"
            End If
        End Sub
        Public Sub LoadValue()
            arrTemp = objController.CMS_UngVien_List_PhienGD_ID(Me.PortalId, PhienGD_ID)
            If arrTemp.Count > 0 Then
                For Each Cr As CMS_UngVienInfo In arrTemp
                    Session.Item("DSUngVien_" & PhienGD_ID) = Cr.Total
                    Exit For
                Next
                grdData.DataSource = arrTemp
                grdData.PageSize = arrTemp.Count + 1
                grdData.DataBind()
                grdData.Visible = True
                litPage.Text = ""
            Else
                litPage.Text = "Hiện tại ứng viên chưa tham gia phỏng vấn ở doanh nghiệp nào!"
                Session.Item("DSUngVien_" & PhienGD_ID) = "0"
            End If
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("Tel")
            If DataBinder.Eval(e.Item.DataItem, "Tel") = "" And DataBinder.Eval(e.Item.DataItem, "LoaiUngVien") = LoaiUngVien.DaDangKy Then
                liter.Text = flReg.Telephone(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "NguoiTimViec_ID"))
            Else
                liter.Text = DataBinder.Eval(e.Item.DataItem, "Tel")
            End If
            liter.Text += "<br/>" & DataBinder.Eval(e.Item.DataItem, "Email")

            liter = e.Item.FindControl("TenDayDu")
            liter.Text = "<div class='col-md-12'>" & DataBinder.Eval(e.Item.DataItem, "TenDayDu") & "</div>"
            liter.Text += "<div Class='col-md-6'>Giới tính: " & flCheck.GioiTinh(DataBinder.Eval(e.Item.DataItem, "GioiTinh")) & "</div>"
            liter.Text += "<div class='col-md-6'>Ngày sinh: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "NgaySinh"), False) & "</div>"

            liter = e.Item.FindControl("DiaChi")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "DiaChi")
            'liter = e.Item.FindControl("TrinhDo")
            'liter.Text = flDic.Education_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "TrinhDoChuyenMon"))
            'liter = e.Item.FindControl("NganhNghe")
            'liter.Text = flCheck.Career_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "NganhNghe"))

            liter = e.Item.FindControl("IsDelete")
            Dim phInfo As CMS_PhienGiaoDichInfo = New WorkController().CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD_ID)
            If IsNothing(phInfo) = False Then
                If Now > phInfo.ThoiGian_KetThuc = False Then
                    liter.Text = "<a herf=""javascript:;"" onclick=""xoaungvien(" & Me.PortalId & ",'" & DataBinder.Eval(e.Item.DataItem, "UngVien_ID") & "',this);"">"
                    liter.Text += "<img src='/portals/_default/skins/vbn/images/delete.png' title='Xóa ứng viên'/></a>"
                End If
            End If
            liter = e.Item.FindControl("ThayThe")
            liter.Text = "<a  title='Thay thế ứng viên' onclick=""showDialogUngVien('" & PhienGD_ID & "','" & DataBinder.Eval(e.Item.DataItem, "UngVien_ID") & "')"" <span class=""label label-warning pd5""><i class=""fa fa-refresh""></i></span>"
        End Sub
        Protected Sub ResetLink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResetLink.Click
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            lblInfo.Text = ""
        End Sub
        Public Function FormatKetQuaPhongVan(ByVal kq As Integer) As String
            If kq = 1 Then Return "Đạt"
            If kq = 2 Then Return "Không đạt"
            If kq = 3 Then Return "Hẹn phỏng vấn lại"
            If kq = 4 Then Return "Trúng sơ tuyển"
            If kq = 5 Then Return "Đã mời tham gia"
            Return "Chưa phỏng vấn"
        End Function
        Private Sub cmdDSUngVien_Next_Click(sender As Object, e As EventArgs) Handles cmdDSUngVien_Next.Click
            Call LoadValue()
        End Sub
        Protected Sub Mar_DSMoiUV_Close() Handles Mar_DSMoiUV.OnSubmit
            Try
                Call LoadValue()
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('succcess', 'Thay thế ứng viên thành công', 'Thông báo', false);", True)

            Catch ex As Exception

            End Try
        End Sub
    End Class

End Namespace