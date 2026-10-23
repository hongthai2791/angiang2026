Imports TN.Web.Helper
Namespace sp
    Partial Class download
        Inherits System.Web.UI.Page
        Public Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

            Try
                Dim fu As String = EPORTAL.flReg.DeCode64(Request.Item("fu"))
                Dim fn As String = EPORTAL.flReg.DeCode64(Request.Item("fn"))
                Dim filepath = Server.MapPath(fu)
                If System.IO.File.Exists(filepath) Then
                    Context.Response.ContentType = "application/octet-stream"
                    Context.Response.AddHeader("Content-Disposition", String.Format("attachment; filename=""{0}""", fn))
                    Context.Response.TransmitFile(filepath)
                    Me.Visible = False
                Else
                    Me.Visible = True
                End If
            Catch ex As Exception
                Me.Visible = True
            End Try
        End Sub
    End Class
End Namespace
