Namespace Modules.QLLDNN
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Public strJs As String = ""

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                If Me.EditMode = False Then strJs = "<script src='/portals/_default/skins/vbn/fancybox/jquery-3.2.1.min.js'></script>"
            End If
        End Sub

    End Class

End Namespace
