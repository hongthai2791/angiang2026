Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.WORK


Namespace DesktopModules.Modules

    Partial Class MarketMain
        Inherits PortalModuleBase

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                If Not IsPostBack Then
                    Dim PhienGD_ID As String = New WorkController().CMS_PhienGiaoDich_SelectPhien_DienRa_GanNhat(Me.PortalId, Me.PortalId)
                    ctlDSBTD00.PhienGD_ID = PhienGD_ID
                    ctlDSBTD00.LoadValue()
                    ctlDSBTD01.PhienGD_ID = PhienGD_ID
                    ctlDSBTD02.PhienGD_ID = PhienGD_ID
                    ctlDSUV01.PhienGD_ID = PhienGD_ID
                    ctlTKBCS.PhienGD_ID = PhienGD_ID
                    ctlTKBCS.LoadValue()
                End If
            Catch ex As Exception

            End Try
        End Sub

    End Class

End Namespace
