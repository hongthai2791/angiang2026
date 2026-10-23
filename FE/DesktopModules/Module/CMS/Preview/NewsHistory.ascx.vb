Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Namespace DesktopModules.Modules

    Public MustInherit Class NewsHistory
        Inherits Entities.Modules.PortalModuleBase
        Dim ObjController As New CmsController
        Dim newId, PortalConnect As Integer
#Region "Event Handlers"
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not IsPostBack Then
                    newId = flReg.WriteNumber(Request.Item("itemid"))
                    PortalConnect = flReg.WriteNumber(Request.Item("pid"))
                    If newId > 0 Then
                        Dim obj As CMS_NewsInfo = ObjController.CMS_News_Get(PortalConnect, newId)
                        If IsNothing(obj) = False Then
                            lbNews.Text = obj.Title
                            lbUserCreated.Text = flReg.GetUserName(obj.UserId) & " - " & flReg.ReadDate(obj.Createdate)
                            Call BinddrgDataViewer(obj.NewId)
                        End If
                    End If

                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub BinddrgDataViewer(ItemID As Integer)
            Try
                Me.drgDataViewer.DataSource = ObjController.CMS_News_Process_GetByNewsId(PortalConnect, ItemID, 1)
                Me.drgDataViewer.DataBind()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Public Function FormatVisible(ByVal id As Object) As String
            If IsNumeric(id) AndAlso id > 0 Then
                Return "True"
            Else
                Return "False"
            End If
        End Function

        Public Function GetUserName(ByVal userid As String) As String
            If userid = "" Then Return ""
            Return "(" & flDnn.DNN_User_Get_UserName(PortalConnect, userid).DisplayName() & ")"
        End Function
#End Region

    End Class
End Namespace