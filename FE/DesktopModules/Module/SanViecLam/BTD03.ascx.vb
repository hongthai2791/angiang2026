Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK


Namespace DesktopModules.Modules

    Partial Class BTD03
        Inherits PortalModuleBase

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
                If Page.IsPostBack = False Then
                    Dim objDoanhNghiep As CMS_BusinessInfo = New WorkController().CMS_Business_Get(Me.PortalId, Business_ID)
                    If Not objDoanhNghiep Is Nothing Then
                        lblGioiThieuChung.Text = objDoanhNghiep.Description
                    End If
                End If
            Catch ex As Exception
                lblGioiThieuChung.Text = ex.Message
            End Try

        End Sub

    End Class

End Namespace