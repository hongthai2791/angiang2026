Imports DotNetNuke.Services.Exceptions.Exceptions
Imports Telerik.Web.UI
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Namespace DesktopModules.Menu

    Partial Class MenuAdmin
        Inherits Entities.Modules.PortalModuleBase

#Region "Variable"
        Private mXmlPath As String = Null.NullString 'Lưu đường dẫn tới file xml
        Private RoleGroupId As Integer = -1
        Dim arr, arrTemp, arrTemp1 As New ArrayList
        Dim strOld As String
        Dim node As RadTreeNode
        Dim mnDInfo As CMS_MenuDInfo
        Dim objController As New CmsController
#End Region

#Region "Property"
        Property CurrentXML() As String
            Get
                If Not ViewState("CurrentXml") Is Nothing Then
                    Return ViewState("CurrentXml")
                Else
                    ViewState.Add("CurrentXml", "")
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                ViewState("CurrentXml") = value.ToString
            End Set
        End Property
        Property CurrentValueNode() As String
            Get
                If Not ViewState("CurrentValueNode") Is Nothing Then
                    Return ViewState("CurrentValueNode")
                Else
                    ViewState.Add("CurrentValueNode", Null.NullInteger.ToString)
                    Return Null.NullInteger.ToString
                End If
            End Get
            Set(ByVal value As String)
                ViewState("CurrentValueNode") = value.ToString
            End Set
        End Property
        Property IsFather() As Boolean
            Get
                If Not ViewState.Item("IsFather") Is Nothing Then
                    Return Boolean.Parse(ViewState.Item("IsFather"))
                Else
                    ViewState.Add("IsFather", "False")
                    Return Null.NullBoolean
                End If
            End Get
            Set(ByVal value As Boolean)
                If ViewState.Item("IsFather") Is Nothing Then
                    ViewState.Add("IsFather", value)
                Else
                    ViewState.Item("IsFather") = value
                End If
            End Set
        End Property
        Property IsNewNode() As Boolean
            Get
                If Not ViewState.Item("IsNewNode") Is Nothing Then
                    Return Boolean.Parse(ViewState.Item("IsNewNode"))
                Else
                    ViewState.Add("IsNewNode", "False")
                    Return Null.NullBoolean
                End If
            End Get
            Set(ByVal value As Boolean)
                If ViewState.Item("IsNewNode") Is Nothing Then
                    ViewState.Add("IsNewNode", value)
                Else
                    ViewState.Item("IsNewNode") = value
                End If
            End Set
        End Property

#End Region

#Region "LoadTab"

        Private Sub LoadTabID()
            drdLink.Items.Clear()
            drdLink.Items.Add(New ListItem("- - - Chọn - - -", "0"))
            For Each Cr As DnnInfo In flDnn.DNN_Tabs_Get_Parent_IsNull(flConnect.DnnSqlServer, ddlPortal.SelectedValue)
                drdLink.Items.Add(New ListItem(Cr.Title, Cr.TabPath.Replace("//", "/")))
                Call LoadTabID(Cr.Tabid, "--")
            Next
        End Sub
        Private Sub LoadTabID(ByVal intTabId As String, ByVal strO As String)
            For Each Cj As DnnInfo In flDnn.DNN_Tabs_Get_By_ParentID(flConnect.DnnSqlServer, intTabId)
                drdLink.Items.Add(New ListItem(strO & ">| " & Cj.Title, Cj.TabPath.Replace("//", "/")))
                strOld = strO & "--"
                Call LoadTabID(Cj.Tabid, strOld)
            Next
        End Sub

#End Region

#Region "function"
        Private Sub ClearControls()
            txtNodeName.Text = String.Empty
            txtUrl.Text = String.Empty
            txtBackground.Text = "FFFFFF"
            drdLink.SelectedValue = "0"
        End Sub

        Private Sub BindLoadPortal()

            ddlPortal.DataSource = Ultis.UserPortal(Me.UserInfo.Username)
            ddlPortal.DataTextField = "PortalName"
            ddlPortal.DataValueField = "PortalId"
            ddlPortal.DataBind()
            If Request.Item("pid") & "" <> "" Then
                ddlPortal.SelectedValue = Request.Item("pid")
            Else
                ddlPortal.SelectedValue = Me.PortalId
            End If
        End Sub

        Private Sub GetAllNodeRecursive(ByVal node As RadTreeNode)
            node.ContextMenuID = "MainContextMenu"
            For Each childNode As RadTreeNode In node.Nodes
                GetAllNodeRecursive(childNode)
            Next
        End Sub
        Protected Sub HandleDrop(ByVal sender As Object, ByVal e As RadTreeNodeDragDropEventArgs)
            Try
                Dim sourceNode As RadTreeNode = e.SourceDragNode
                Dim destNode As RadTreeNode = e.DestDragNode
                Dim dropPosition As RadTreeViewDropPosition = e.DropPosition
                If Not destNode Is Nothing Then
                    If sourceNode.TreeView.SelectedNodes.Count <= 1 Then 'Gán menu context mới
                        GetAllNodeRecursive(sourceNode)
                        If catMenu.GetAllNodes.Count = 1 AndAlso catMenu.Nodes(0).Value.ToString = Null.NullInteger.ToString Then
                            sourceNode.Owner.Nodes.Remove(sourceNode)
                            catMenu.Nodes.Clear()
                            catMenu.Nodes.Add(sourceNode)
                        Else
                            PerformDragAndDrop(dropPosition, sourceNode, destNode)
                        End If
                    ElseIf sourceNode.TreeView.SelectedNodes.Count > 1 Then
                        Dim node As RadTreeNode                        'Gán menu context mới
                        For Each node In sourceNode.TreeView.SelectedNodes
                            GetAllNodeRecursive(node)
                        Next node

                        If catMenu.GetAllNodes.Count = 1 AndAlso catMenu.Nodes(0).Value.ToString = Null.NullInteger.ToString Then
                            Select Case dropPosition
                                Case RadTreeViewDropPosition.Over, RadTreeViewDropPosition.Above
                                    For Each node In sourceNode.TreeView.SelectedNodes
                                        PerformDragAndDrop(dropPosition, node, destNode)
                                    Next node
                                Case RadTreeViewDropPosition.Below
                                    Dim count As Integer = sourceNode.TreeView.SelectedNodes.Count
                                    For i As Integer = 0 To count - 1
                                        PerformDragAndDrop(dropPosition, sourceNode.TreeView.SelectedNodes(count - 1 - i), destNode)
                                    Next
                            End Select
                            Dim rooNode As RadTreeNode = catMenu.FindNodeByValue(Null.NullInteger.ToString)
                            If rooNode.Nodes.Count = 0 Then
                                rooNode.Owner.Nodes.Remove(rooNode)
                            Else
                                For Each node In rooNode.Nodes
                                    catMenu.Nodes.Add(node)
                                Next
                                catMenu.Nodes.Remove(rooNode)
                            End If
                        Else
                            For Each node In sourceNode.TreeView.SelectedNodes
                                PerformDragAndDrop(dropPosition, node, destNode)
                            Next node
                        End If
                    End If
                    UnselectAllNodes(catMenu)
                    sourceNode.Selected = True
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub 'Handle dropping events
        Private Shared Sub PerformDragAndDrop(ByVal dropPosition As RadTreeViewDropPosition, ByVal sourceNode As RadTreeNode, ByVal destNode As RadTreeNode)
            Select Case dropPosition
                Case RadTreeViewDropPosition.Over
                    If Not sourceNode.IsAncestorOf(destNode) Then
                        sourceNode.Owner.Nodes.Remove(sourceNode)
                        destNode.Nodes.Add(sourceNode)
                    End If
                Case RadTreeViewDropPosition.Above
                    sourceNode.Owner.Nodes.Remove(sourceNode)
                    destNode.InsertBefore(sourceNode)

                Case RadTreeViewDropPosition.Below
                    sourceNode.Owner.Nodes.Remove(sourceNode)
                    destNode.InsertAfter(sourceNode)
            End Select
            destNode.Expanded = True
        End Sub
        Protected Sub catMenu_NodeClick(sender As Object, e As RadTreeNodeEventArgs)
            If e Is Nothing Then Exit Sub
            Dim currentNode As RadTreeNode = e.Node
            _MenuDID.Value = currentNode.Value
            _ParentID.Value = ""
            If Not (currentNode Is Nothing) And Not currentNode.Value.Equals(Null.NullString.ToString) Then
                txtNodeName.Text = currentNode.Text
                IsNewNode = False
                mnDInfo = objController.CMS_MenuD_Get(ddlPortal.SelectedValue, _MenuDID.Value)
                If IsNothing(mnDInfo) = False Then
                    txtUrl.Text = mnDInfo.Url
                    txtBackground.Text = mnDInfo.BackColor
                    IsOrder.Text = mnDInfo.IsOrder
                    _ParentID.Value = mnDInfo.Parent_ID
                End If
                e.Node.Selected = True
                catMenu.Nodes(0).CollapseChildNodes()
                _MenuDID.Value = e.Node.Value
                e.Node.Expanded = True
                e.Node.Focus()
            End If

            'Load danh sách con menu
            catMenu.UnselectAllNodes()
            e.Node.Selected = True
            If e.Node.Nodes.Count > 0 Then e.Node.Nodes.Clear()
            For Each nk As CMS_MenuDInfo In objController.CMS_MenuD_List_By_ParentID(ddlPortal.SelectedValue, e.Node.Value)
                node = New RadTreeNode(nk.MenuD_Name, nk.MenuD_ID)
                e.Node.Nodes.Add(node)
            Next
            e.Node.Expanded = True
            e.Node.Focus()

        End Sub
        Private Sub UnselectAllNodes(ByVal treeView As RadTreeView)
            Dim node As RadTreeNode
            For Each node In treeView.GetAllNodes()
                node.Selected = False
            Next node
        End Sub
        Protected Sub HandleContextClick(ByVal sender As Object, ByVal e As RadTreeViewContextMenuEventArgs)
            Try
                If e Is Nothing Then Exit Sub
                Dim currentNode As RadTreeNode = e.Node
                CurrentValueNode = currentNode.Value
                _MenuDID.Value = ""
                Select Case e.MenuItem.Value
                    Case "addchildren" 'Thêm chuyên mục con
                        ClearControls()
                        IsNewNode = True
                        IsFather = True
                        _ParentID.Value = e.Node.Value
                        IsOrder.Text = currentNode.Nodes.Count + 1
                    Case "addsibling" 'Thêm chuyên mục cùng cấp
                        ClearControls()
                        IsNewNode = True
                        IsFather = False
                        _ParentID.Value = ""
                        IsOrder.Text = catMenu.Nodes.Count + 1
                    Case "Delete" 'Xóa chuyên mục này
                        If currentNode Is Nothing Then Exit Sub
                        If currentNode.Value.Equals(Null.NullString.ToString) AndAlso catMenu.Nodes.Count < 2 Then Exit Sub

                        currentNode.Owner.Nodes.Remove(currentNode)
                        objController.CMS_MenuD_Delete(ddlPortal.SelectedValue, currentNode.Value)
                        Call BindMenu()
                    Case "edit" 'Sửa chi tiết
                        If Not (currentNode Is Nothing) And Not currentNode.Value.Equals(Null.NullInteger.ToString) Then
                            _MenuDID.Value = e.Node.Value

                            txtNodeName.Text = currentNode.Text
                            IsNewNode = False

                            If Not currentNode.Attributes("NavUrl") Is Nothing Then txtUrl.Text = currentNode.Attributes("NavUrl")
                            If Not currentNode.Attributes("Background") Is Nothing Then txtBackground.Text = currentNode.Attributes("Background")

                            chkLinkPopup.Checked = False
                            If Not currentNode.Target = "" Then chkLinkPopup.Checked = True
                        End If
                End Select
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Public Sub CreateChildTree(ByVal parent As RadTreeNode, ByVal list As ArrayList)
            Dim childList As New List(Of CMS_MenuInfo)
            For Each obj As CMS_MenuInfo In list
                If obj.ParentId = Convert.ToInt32(parent.Value) Then
                    childList.Add(obj)
                End If
            Next
            For Each obj As CMS_MenuInfo In childList
                Dim node As RadTreeNode = CreateNewNode(obj)
                parent.Nodes.Add(node)
                node.DataItem = obj
                CreateChildTree(node, list)
            Next
        End Sub
        Public Function CreateNewNode(ByVal obj As CMS_MenuInfo) As RadTreeNode
            Dim node As New RadTreeNode(obj.Name, obj.Id.ToString)
            node.Expanded = False
            node.ToolTip = obj.Id.ToString
            node.Attributes("Title") = obj.Title

            node.Attributes.Add("NavUrl", obj.Url.Trim)
            If obj.Params <> Null.NullString Then
                node.Attributes.Add("Params", obj.Params.Trim)
            End If
            Return node
        End Function
        Public Function CreateNewNodeForMenu(ByVal text As String, ByVal value As String) As RadTreeNode
            Dim node As New RadTreeNode(text, value)
            node.Expanded = False
            node.ToolTip = value
            Return node
        End Function
        Private Sub BindMenu(treNode As RadTreeNode, parent As String)
            For Each nk As CMS_MenuDInfo In objController.CMS_MenuD_List_By_ParentID(ddlPortal.SelectedValue, parent)
                node = New RadTreeNode(nk.MenuD_Name, nk.MenuD_ID)
                treNode.Nodes.Add(node)
            Next
        End Sub
        Private Sub BindMenu()
            Try
                catMenu.Nodes.Clear()
                For Each mnI As CMS_MenuDInfo In objController.CMS_MenuD_List_By_MenuID(ddlPortal.SelectedValue, drlMenu.SelectedValue, ddlPortal.SelectedValue)
                    node = New RadTreeNode(mnI.MenuD_Name, mnI.MenuD_ID)
                    catMenu.Nodes.Add(node)
                    Call BindMenu(node, mnI.MenuD_ID)
                Next
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Public Function GenerateSEOForCatId(ByVal node As RadTreeNode) As String
            Dim sTemp As String = String.Empty
            sTemp = flReg.ToEnglish(node.Text)
            While True
                Dim parentNode As RadTreeNode = node.ParentNode
                If Not parentNode Is Nothing Then
                    sTemp = flReg.ToEnglish(parentNode.Text) + "/" + sTemp
                    node = parentNode
                Else
                    Exit While
                End If
            End While
            Return sTemp
        End Function
        Private Sub CopyFile(ParentID As String, oldParentID As String)
            arrTemp1 = objController.CMS_MenuD_List_By_ParentID(ddlPortal.SelectedValue, oldParentID)
            For Each Cr As CMS_MenuDInfo In arrTemp1
                mnDInfo = New CMS_MenuDInfo
                mnDInfo.MenuD_ID = flReg.GenKey()
                mnDInfo.Menu_ID = drCopy.SelectedValue
                mnDInfo.MenuD_Name = Cr.MenuD_Name
                mnDInfo.Url = Cr.Url
                mnDInfo.BackColor = Cr.BackColor
                mnDInfo.IsOrder = Cr.IsOrder
                mnDInfo.UpdateDate = flReg.DateNull
                mnDInfo.UpdateUser = ""
                mnDInfo.Parent_ID = ParentID
                mnDInfo.CreatedDate = Now
                mnDInfo.CreatedUser = Me.UserInfo.Username
                objController.CMS_MenuD_Add(ddlPortal.SelectedValue, mnDInfo)

                Call CopyFile(mnDInfo.MenuD_ID, Cr.MenuD_ID)
            Next
        End Sub
        Private Sub CopyFile()
            arrTemp = objController.CMS_MenuD_List_By_MenuID(ddlPortal.SelectedValue, drlMenu.SelectedValue, ddlPortal.SelectedValue)
            For Each Cr As CMS_MenuDInfo In arrTemp
                mnDInfo = New CMS_MenuDInfo
                mnDInfo.MenuD_ID = flReg.GenKey()
                mnDInfo.Menu_ID = drCopy.SelectedValue
                mnDInfo.MenuD_Name = Cr.MenuD_Name
                mnDInfo.Url = Cr.Url
                mnDInfo.BackColor = Cr.BackColor
                mnDInfo.IsOrder = Cr.IsOrder
                mnDInfo.UpdateDate = flReg.DateNull
                mnDInfo.UpdateUser = ""
                mnDInfo.Parent_ID = ""
                mnDInfo.CreatedDate = Now
                mnDInfo.CreatedUser = Me.UserInfo.Username
                objController.CMS_MenuD_Add(ddlPortal.SelectedValue, mnDInfo)

                Call CopyFile(mnDInfo.MenuD_ID, Cr.MenuD_ID)
            Next
        End Sub
#End Region

#Region "Events"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If Not Page.IsPostBack Then
                    lbmsg.Text = ""
                    Call BindLoadPortal()
                    Call flFunction.LoadMenu(drlMenu, ddlPortal.SelectedValue)
                    If Request.Item("menu") & "" <> "" Then drlMenu.SelectedValue = Request.Item("menu")
                    flFunction.LoadMenu(drCopy, ddlPortal.SelectedValue)
                    Call LoadTabID()
                    Call BindMenu()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & EPORTAL.flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Private Sub drdLink_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drdLink.SelectedIndexChanged
            txtUrl.Text = drdLink.SelectedValue.Replace("$", "/")
            txtUrl.Text = txtUrl.Text.Replace(flConnect.WebDomain(ddlPortal.SelectedValue), "")
        End Sub
        Protected Sub cbCopy_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbCopy.CheckedChanged
            lbmsg.Text = ""
            If cbCopy.Checked = True Then
                pnCopy.Visible = True
            Else
                pnCopy.Visible = False
            End If
        End Sub
        Protected Sub ddlPortal_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlPortal.SelectedIndexChanged
            Response.Redirect("/cms/view/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue, True)
        End Sub
        Protected Sub cmdCopy_Click(sender As Object, e As System.EventArgs) Handles cmdCopy.Click
            Try
                pnCopy.Visible = False
                cbCopy.Checked = False
                objController.CMS_MenuD_Delete_By_MenuID(ddlPortal.SelectedValue, drCopy.SelectedValue)
                Call CopyFile()
                lbmsg.Text = "<div class=""cCopy2"">Sao chép thành công.</div>"
            Catch ex As Exception
                pnCopy.Visible = False
                cbCopy.Checked = False
                lbmsg.Text = "<div class=""cCopy2"">Lỗi sao chép.</div>"
            End Try
        End Sub
        Protected Sub cmdExit_Click(sender As Object, e As System.EventArgs) Handles cmdExit.Click
            Response.Redirect("/cms/view/" & Request.Item("view"), True)
        End Sub
        Protected Sub cmdSave_Click(sender As Object, e As System.EventArgs) Handles cmdSave.Click
            If _MenuDID.Value <> "" Then
                mnDInfo = objController.CMS_MenuD_Get(ddlPortal.SelectedValue, _MenuDID.Value)
                If txtNodeName.Text.Trim <> "" Then
                    mnDInfo.MenuD_Name = txtNodeName.Text
                    mnDInfo.Url = txtUrl.Text
                    mnDInfo.Parent_ID = _ParentID.Value
                    mnDInfo.BackColor = txtBackground.Text
                    mnDInfo.IsOrder = flReg.WriteNumber(IsOrder.Text)
                    mnDInfo.UpdateDate = Now
                    mnDInfo.UpdateUser = Me.UserInfo.Username
                    mnDInfo.PortalId = ddlPortal.SelectedValue
                    objController.CMS_MenuD_Update(ddlPortal.SelectedValue, mnDInfo)
                Else
                    objController.CMS_MenuD_Delete(ddlPortal.SelectedValue, mnDInfo.MenuD_ID)
                End If
            Else
                If txtNodeName.Text.Trim <> "" Then
                    mnDInfo = New CMS_MenuDInfo
                    _MenuDID.Value = flReg.GenKey()
                    mnDInfo.MenuD_ID = _MenuDID.Value
                    mnDInfo.Menu_ID = drlMenu.SelectedValue
                    mnDInfo.MenuD_Name = txtNodeName.Text
                    mnDInfo.Url = txtUrl.Text
                    mnDInfo.BackColor = txtBackground.Text
                    mnDInfo.IsOrder = flReg.WriteNumber(IsOrder.Text)
                    mnDInfo.UpdateDate = flReg.DateNull
                    mnDInfo.UpdateUser = ""
                    mnDInfo.Parent_ID = _ParentID.Value
                    mnDInfo.CreatedDate = Now
                    mnDInfo.CreatedUser = Me.UserInfo.Username
                    mnDInfo.PortalId = ddlPortal.SelectedValue
                    objController.CMS_MenuD_Add(ddlPortal.SelectedValue, mnDInfo)
                End If
            End If
            Call BindMenu()
        End Sub
        Private Sub UpdateMenu(notes As RadTreeNode, parentID As String)
            Dim n As Integer = 1
            For Each nd In notes.Nodes
                objController.CMS_MenuD_Update_Quick(ddlPortal.SelectedValue, nd.Value, parentID, n)
                If nd.Nodes.Count > 0 Then Call UpdateMenu(nd, nd.Value)
                n += 1
            Next
        End Sub
        Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            Try
                Dim i As Integer = 1
                For Each node In catMenu.Nodes
                    objController.CMS_MenuD_Update_Quick(ddlPortal.SelectedValue, node.Value, "", i)
                    If node.Nodes.Count > 0 Then
                        Call UpdateMenu(node, node.Value)
                    End If
                    i += 1
                Next
            Catch ex As Exception

            End Try
        End Sub
        Private Sub drlMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlMenu.SelectedIndexChanged
            Response.Redirect("/cms/view/" & Request.Item("view") & "/pid/" & ddlPortal.SelectedValue & "/menu/" & drlMenu.SelectedValue, True)
        End Sub
#End Region

    End Class

End Namespace