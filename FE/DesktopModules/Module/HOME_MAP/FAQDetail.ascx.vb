Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL
Namespace DesktopModules.Modules.Home
    Partial Class FAQ
        Inherits Entities.Modules.PortalModuleBase

        Private Sub FAQ_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Page.IsPostBack = False Then
                Try
                    lblAnswer.Text = ""
                    Dim objFAQ = New CmsController().CMS_FAQQuestions_Get(Me.PortalId, flReg.WriteNumber(Request.Item("id")))
                    If objFAQ IsNot Nothing Then
                        If objFAQ.Status = QuestionStatus.DaDuyet Then
                            With objFAQ
                                FullName.Text = .Name
                                Contents.Text = .Contents
                                lblAnswer.Text += .ContentAnswer

                            End With

                        End If
                    End If
                Catch ex As Exception
                    lbMsg.Text = ex.ToString
                End Try
            End If
        End Sub
    End Class
End Namespace

