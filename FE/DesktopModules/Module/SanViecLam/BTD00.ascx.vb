Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK


Namespace DesktopModules.Modules

    Partial Class BTD00
        Inherits PortalModuleBase

        Protected Timer As Integer
        Dim objController As New WorkController
        Dim objPhien As New CMS_PhienGiaoDichInfo
        Dim obj As New CMS_DoanhNghiepInfo

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
        Shared DienRa As Integer = 0
        Public Event OnClose()

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call Status_btPhongVan()
                    Call BindData_Session()
                End If
            Catch ex As Exception
                txtIdBanPhongVan.Text = ex.Message
            End Try
        End Sub

        Public Sub BindData_Session()
            Try
                obj = objController.CMS_DoanhNghiep_Get_By_Business_ID(Me.PortalId, PhienGD_ID, Business_ID)
                If IsNothing(obj) = False Then
                    txtIdBanPhongVan.Text = obj.SoBan
                    txtTenDN.Text = obj.Business_Vn
                    objPhien = objController.CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD_ID)
                    If obj.TinhTrangThamGia = 0 Then
                        txtTenDN.Text += "<h2 class=""noti-none"">Doanh nghiệp đã đăng ký, đang chờ duyệt.</h2>"
                    End If
                    If IsNothing(objPhien) = False Then
                        If objPhien.ThoiGian_KetThuc.Subtract(Now).TotalSeconds > 0 Then
                            Timer = (objPhien.ThoiGian_KetThuc - Now).TotalSeconds
                            Dim ts As TimeSpan = objPhien.ThoiGian_KetThuc.Subtract(Now)
                            txtThoiGianCon.Text = String.Format("{0:00} h : {1:00} '", ts.TotalHours, ts.Minutes)
                        End If
                    End If
                    txtSoViecLam.Text = obj.SoLuongTuyenDung
                    txtSoUngVien.Text = obj.SoLuongUngVien
                End If
            Catch ex As Exception
                txtSoViecLam.Text = ex.Message
            End Try

        End Sub
        Public Sub Status_btPhongVan()
            objPhien = objController.CMS_PhienGiaoDich_Get(Me.PortalId, PhienGD_ID)
            If IsNothing(objPhien) = False Then
                If DateTime.Compare(objPhien.ThoiGian_BatDau, Date.Now) <= 0 And DateTime.Compare(objPhien.ThoiGian_KetThuc, Date.Now) >= 0 Then
                    DienRa = 1
                Else
                    DienRa = 0
                End If
            End If
        End Sub

    End Class

End Namespace