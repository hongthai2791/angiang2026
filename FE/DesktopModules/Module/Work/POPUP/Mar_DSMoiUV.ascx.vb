Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.Mar_DSMoiUV

    Partial Class View
        Inherits PortalModuleBase
        Dim objController As New WorkController
        Dim arrTemp, arr1, arr2 As New ArrayList
        Dim liter As Literal, iTuyen As Integer
        Dim obj As New CMS_UngVienInfo
        Dim Hf As HiddenField
        Public Event OnSubmit()
        Public Property SelectedGrdItem() As Integer
            Get
                Return _HF_GrItem.Value
            End Get
            Set(ByVal value As Integer)
                _HF_GrItem.Value = value
            End Set
        End Property
        Public Property PGDId() As String
            Get
                Return _PGDId.Value
            End Get
            Set(ByVal value As String)
                _PGDId.Value = value
            End Set
        End Property

        Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            Try
                Call LoadValues()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Public Sub LoadValues()
            arrTemp = flDnn.DNN_UserConfig_List_By_Roles(Me.PortalId, Me.PortalSettings.ActiveTab.TabName, DSMoiUV_Find.Text.Trim, 1, 35, flReg.GetRolesID(Me.PortalSettings.ActiveTab.TabName, "Nguoi lao dong"), 0)
            For Each Ck As CMS_UngVienInfo In objController.CMS_UngVien_List_PhienGD_ID(Me.PortalId, PGDId)
                For Each item As DnnInfo In arrTemp
                    If item.Username = Ck.NguoiTimViec_ID Then
                        arrTemp.Remove(item)
                        iTuyen += 1
                        Exit For
                    End If
                Next
            Next
            dgrDanhSachUngVien.DataSource = arrTemp
            dgrDanhSachUngVien.DataKeyField = "UserName"
            dgrDanhSachUngVien.PageSize = 35
            dgrDanhSachUngVien.DataBind()
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles dgrDanhSachUngVien.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (dgrDanhSachUngVien.CurrentPageIndex * dgrDanhSachUngVien.PageSize + e.Item.ItemIndex + 1).ToString()

            liter = e.Item.FindControl("Tel")
            liter.Text = flReg.Telephone(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "UserName"))

            liter = e.Item.FindControl("Email")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Email")

            liter = e.Item.FindControl("TenDayDu")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "DisplayName")

            liter = e.Item.FindControl("UserName")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "UserName")
            Hf = e.Item.FindControl("HF_UVID_InGrid")
            Hf.Value = DataBinder.Eval(e.Item.DataItem, "UserName")

        End Sub
        Private Sub cmdDSMoiUV_Search_Click(sender As Object, e As EventArgs) Handles cmdDSMoiUV_Search.Click
            Call LoadValues()
        End Sub

        Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
            Try

                Dim obDN As New CMS_UngVienInfo
                obDN = objController.CMS_UngVien_Get(Me.PortalId, _SelectedId.Value)
                If obDN IsNot Nothing Then

                    Dim obUs As DnnInfo = flDnn.DNN_User_Get_UserName(Me.PortalId, _HF_GrItem.Value)
                    obDN.Email = obUs.Email
                    obDN.Tel = obUs.Telephone
                    obDN.TenDayDu = obUs.DisplayName
                    obDN.NguoiTimViec_ID = _HF_GrItem.Value


                    Call objController.CMS_UngVien_Replace(Me.PortalId, obDN)
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "closeDialogUngVien();notify('succcess', 'Thay thế ứng viên thành công', 'Thông báo', false);", True)
                    Call LoadValues()
                    RaiseEvent OnSubmit()

                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('error', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
    End Class

End Namespace