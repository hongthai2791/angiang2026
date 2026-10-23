Imports System.IO
Imports Telerik.Web.UI
Imports System.Drawing.Imaging
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim diroot As DirectoryInfo
    Public strKey As String
    Dim b As Byte()
    Dim sDate, strType, strFlag As String
    Dim strImg, spath, fileName As String
    Dim vTotal, currPage As Integer
    Dim dirinfo As DirectoryInfo
    Dim allFiles() As System.IO.FileInfo
    Dim fileType, arr() As String
    Dim pageRow As Integer = 16
    Dim objImage, imgNew As System.Drawing.Image
    Dim imageCodecInfo As ImageCodecInfo


#Region "Properties"
    Public ReadOnly Property ROOT_FOLDER As String
        Get
            Select Case strType
                Case "video"
                    fileTypeUp.Value = ".mp4"
                    fileImages.Attributes.Add("accept", ".mp4")
                    Return "/DATA/VIDEO/" & _pid.Value
                Case "audio"
                    fileTypeUp.Value = ".mp3"
                    fileImages.Attributes.Add("accept", ".mp3")
                    Return "/DATA/AUDIO/" & _pid.Value
                Case "doc"
                    fileTypeUp.Value = ".doc,.docx,.xls,.xlsx,.ppt,.pptx,.pdf"
                    fileImages.Attributes.Add("accept", ".doc,.docx,.xls,.xlsx,.ppt,.pptx,.pdf")
                    Return "/DATA/DOCUMENTS/" & _pid.Value
                Case "paper"
                    fileTypeUp.Value = ".png,.jpg,.jpeg,.gif,.bmp"
                    fileImages.Attributes.Add("accept", ".png,.jpg,.jpeg,.gif,.bmp")
                    Return "/DATA/BAOIN/" & _pid.Value
                Case Else '"img"
                    fileTypeUp.Value = ".png,.jpg,.jpeg,.gif,.bmp"
                    fileImages.Attributes.Add("accept", ".png,.jpg,.jpeg,.gif,.bmp")
                    Return "/DATA/IMAGES/" & _pid.Value
            End Select
        End Get
    End Property
    Public Function FormatUrl(ByVal physicpath As String, ByVal folder As String) As String
        Try
            physicpath = physicpath.Replace("\", "/")
            physicpath = physicpath.Substring(physicpath.LastIndexOf(folder))
            FormatUrl = "/data/" & physicpath
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Sub LoadFolder(ByVal node As RadTreeNode)
        If node.Nodes.Count > 0 Then Return
        Dim di As New DirectoryInfo(node.Value)
        Dim child1s As DirectoryInfo() = di.GetDirectories()
        For i As Integer = 0 To child1s.Length - 1 Step 1
            Dim tmpdi As DirectoryInfo = child1s(i)
            If flReg.WriteNumber(tmpdi.Name) > 0 Then
                Dim tmpnode As New RadTreeNode(tmpdi.Name, tmpdi.FullName.ToLower)
                node.Nodes.Add(tmpnode)
                Call LoadFolder(tmpnode)
            End If
        Next
    End Sub
    Private Sub FolderUserName()
        If flReg.WriteNumber(_Day.Value) > 0 And flReg.WriteNumber(_Day.Value) <= 31 Then
            diroot = New DirectoryInfo(Server.MapPath(ROOT_FOLDER))
            Dim di1 As New DirectoryInfo(String.Format("{0}\{1}\{2}\{3}\{4}", diroot.FullName.Trim("\"), _Years.Value, _Month.Value, _Day.Value, _UserName.Value))
            If Not di1.Exists Then di1.Create()
        End If
    End Sub
    Private Function NodeValue(node As String) As String
        arr = node.Split("\")
        Return arr(arr.Length - 1)
    End Function
    Private Function ReadSplit(value As String, index As Integer) As String
        ReadSplit = value
        arr = ReadSplit.Split("-")
        Try
            Return arr(index)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Private Function ReadSplit(value As String, index As Integer, ByVal sp As String) As String
        arr = value.Split(sp)
        Try
            Return arr(arr.Length - index)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Private Function ECodeDate() As String
        If flReg.WriteNumber(_Years.Value) = 0 Then
            Return "&d=" & _Month.Value & "-" & _Day.Value
        End If
        Return "&d=" & _Years.Value & "-" & _Month.Value & "-" & _Day.Value
    End Function
    Private Function RedirectURL(Optional ByVal fload As Boolean = False) As String
        RedirectURL = "/files/default.aspx?v=" & Request.Item("v")
        If flReg.WriteNumber(Request.Item("newid")) <> 0 Then RedirectURL = RedirectURL & "&newid=" & Request.Item("newid")
        If fload = False Then 'Load lần 2 sau khi có token
            If txtSearch.Text.Trim <> "" Then RedirectURL &= "&s=" & EncodeSearch(txtSearch.Text.Trim)
            RedirectURL = RedirectURL & ECodeDate()
        Else 'Lần đầu
            If txtSearch.Text.Trim <> "" Then RedirectURL &= "&s=" & EncodeSearch(txtSearch.Text.Trim)
        End If
    End Function
    Private Function CountTotal() As Integer
        CountTotal = 0
        Select Case strType
            Case "img", "paper"
                For i As Integer = 0 To allFiles.Length - 1
                    fileName = allFiles(i).Name
                    fileType = flReg.GetFileType(allFiles(i).Name, ".").ToLower
                    If fileName.Contains(txtSearch.Text.Trim) Then
                        Select Case fileType
                            Case "png", "jpg", "jpeg", "gif", "bmp"
                                CountTotal += 1
                        End Select
                    End If
                Next
            Case "doc"
                For i As Integer = 0 To allFiles.Length - 1
                    fileName = allFiles(i).Name
                    fileType = flReg.GetFileType(allFiles(i).Name, ".").ToLower
                    If fileName.Contains(txtSearch.Text.Trim) Then
                        Select Case fileType
                            Case "doc", "docx", "xls", "xlsx", "ppt", "pptx", "pdf"
                                CountTotal += 1
                        End Select
                    End If
                Next
            Case "video"
                For i As Integer = 0 To allFiles.Length - 1
                    fileName = allFiles(i).Name
                    fileType = flReg.GetFileType(allFiles(i).Name, ".").ToLower
                    If fileName.Contains(txtSearch.Text.Trim) Then
                        Select Case fileType
                            Case "mp4"
                                CountTotal += 1
                        End Select
                    End If
                Next
            Case "audio"
                For i As Integer = 0 To allFiles.Length - 1
                    fileName = allFiles(i).Name
                    fileType = flReg.GetFileType(allFiles(i).Name, ".").ToLower
                    If fileName.Contains(txtSearch.Text.Trim) Then
                        Select Case fileType
                            Case "mp3"
                                CountTotal += 1
                        End Select
                    End If
                Next
        End Select
    End Function
    Public Function RequestSearch(ToUrl As String, Optional ByVal html As String = ".html") As String
        If ToUrl.Contains("/q/") Then
            Dim str() As String = ToUrl.Substring(ToUrl.LastIndexOf("/q/") + 3).Split("/")
            Dim arr1 As String() = New String() {"-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
                                     "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
                                     "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
                                     "-1D", "-3D", "-4D", "-5D", "-6D", "-2D"}

            Dim arr2 As String() = New String() {".", ":", """", "`", "!", "'",
                                     "@", "#", "$", "^", "&", "*",
                                     "(", ")", "|", "{", "}", "?", "+",
                                     "~", "<", ">", "/", "\", "_"}

            ToUrl = str(0)
            For i As Integer = 0 To arr1.Length - 1
                ToUrl = ToUrl.Replace(arr1(i), arr2(i))
            Next
            Return ToUrl.Replace("-", " ")
        Else
            Return ""
        End If
    End Function
    Public Function EncodeSearch(txtkey As String) As String
        txtkey = txtkey.Trim
        Dim arr1 As String() = New String() {".", ":", """", "`", "!", "'", "@", "#", "$", "^", "&", "*", "(", ")", "|", "{", "}", "?", "+", "~", " ", "<", ">", "/", "\", "_"}
        Dim arr2 As String() = New String() {"-1A", "-2A", "-3A", "-4A", "-5A", "-6A", "-1B", "-2B", "-3B", "-4B", "-5B", "-6B", "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C", "-1D", "-", "-3D", "-4D", "-5D", "-6D", "-2D"}

        For i As Integer = 0 To arr1.Length - 1
            txtkey = txtkey.Replace(arr1(i), arr2(i))
        Next
        Return txtkey
    End Function

#End Region

#Region "Event"
    Public Function FileToken(IdKey As String) As String
        IdKey = Encoding.UTF8.GetString(Convert.FromBase64String(IdKey))
        IdKey = flReg.Decrypt("1", IdKey)
        FileToken = Session(IdKey) & ""
        If FileToken = "" Then
            Dim obj As CMSCookieInfo = flDnn.CMSCookie_Get_Token(IdKey)
            If IsNothing(obj) = False Then
                FileToken = flReg.Decrypt("1", obj.UserName)
                Session(IdKey) = FileToken
            End If
        End If
    End Function

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Request.Item("f") & "" <> "" Then
                Session("token_u") = FileToken(Request.Item("f"))
                Session("token_f") = Request.Item("f")
                Session("token_c") = Request.Item("c")
                Session("token_i") = Request.Item("i")
                Response.Redirect(RedirectURL(True), False)
            End If
            _UserName.Value = flReg.Decrypt("1", Session("token_u"))
            strKey = Session("token_f")
            strType = Request.Item("v")
            strFlag = Session("token_c")
            _pid.Value = Session("token_i")

            txtSearch.Attributes.Add("onkeypress", "return clickButton(event,'" + btnSearch.ClientID + "')")
            txtSearch.Text = RequestSearch(Request.RawUrl)
            Call InitData()
            SqlConnection.ClearAllPools()
        Catch ex As Exception
            Response.Redirect("/404.aspx", False)
        End Try
    End Sub
    Public Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
        Dim codecs() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders
        Dim codecInfo As ImageCodecInfo = Nothing
        For Each codec As ImageCodecInfo In codecs
            codecInfo = codec
        Next codec
        Return codecInfo
    End Function
    Protected Sub _Folder_ContextMenuItemClick(ByVal sender As Object, ByVal e As RadTreeViewContextMenuEventArgs)
        Dim clickedNode As RadTreeNode = e.Node
        diroot = New DirectoryInfo(Server.MapPath(ROOT_FOLDER))
        Select Case e.MenuItem.Value
            Case "Delete"
                System.IO.Directory.Delete(clickedNode.Value, True)
                Call InitData()
                Exit Select
        End Select
    End Sub
    Private Sub StartNodeInEditMode(ByVal nodeValue As String)
        Dim js As String = "Sys.Application.add_load(editNode); function editNode(){ "
        js += "var tree = $find(""" + _Folder.ClientID + """);"
        js += "var node = tree.findNodeByValue('" + nodeValue + "');"
        js += "if (node) node.startEdit();"
        js += "Sys.Application.remove_load(editNode);};"
        RadScriptManager.RegisterStartupScript(Page, Page.[GetType](), "nodeEdit", js, True)
    End Sub
    Protected Sub TreeNodeClick(ByVal sender As Object, ByVal e As RadTreeNodeEventArgs)
        e.Node.Selected = True
        Try
            _Day.Value = ReadSplit(e.Node.Value, 1, "\")
            _Month.Value = ReadSplit(e.Node.Value, 2, "\")
            _Years.Value = ReadSplit(e.Node.Value, 3, "\")
            Response.Redirect(RedirectURL, True)
        Catch ex As Exception
        End Try
    End Sub
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs)
        Response.Redirect(RedirectURL, True)
    End Sub
    Protected Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
        Call LoadValue()
    End Sub
    Protected Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        Try
            Dim node As RadTreeNode = _Folder.SelectedNode
            If node Is Nothing Then
                lblMessage.Text = "Bạn chưa chọn thư mục upload file."
                lblMessage.Visible = True
                Return
            End If

            Dim folder_path As String = node.Value & "\" & _UserName.Value
            Dim di As New DirectoryInfo(folder_path)
            If Not di.Exists Then
                lblMessage.Text = "Chọn thư mục tải file không đúng."
                lblMessage.Visible = True
                Return
            End If

            Dim tick As Long = Now.Ticks
            Dim m As Integer = 0
            Dim tmppath As String
            Dim flImages As HttpFileCollection = Request.Files
            For i As Integer = 0 To flImages.Count - 1
                Dim a As HttpPostedFile = flImages(i)
                m = 1 : tick = 0
                fileType = flReg.GetFileType(a.FileName.ToLower, ".")
                If a.ContentLength > 1 And fileTypeUp.Value.Contains(fileType) Then
                    tmppath = folder_path & "\" & flReg.NameUrl(flReg.GetFileName(a.FileName.Replace("images", ""), ".")) & "." & flReg.GetFileType(a.FileName, ".").ToLower
                    While (File.Exists(tmppath))
                        tick = tick + 1
                        tmppath = folder_path & "\" & flReg.NameUrl(flReg.GetFileName(a.FileName.Replace("images", ""), ".") & " " & tick) & "." & flReg.GetFileType(a.FileName, ".").ToLower
                    End While
                    a.SaveAs(tmppath)
                End If
            Next
            ScriptManager.RegisterStartupScript(Me.Page, Page.GetType(), "myFunction", "doneUpload();", True)
            Call LoadValue()
            lblMessage.Text = "Tải file thành công"
        Catch ex As Exception
            lblMessage.Text = ex.Message + "<br/>" + ex.StackTrace + "<br/>" + ex.Source
        End Try
    End Sub
#End Region

#Region "LoadFiles"
    Function GetNum(iva As String) As String
        If iva.Length = 1 Then
            Return "0" & iva
        Else
            Return iva
        End If
    End Function
    Public Sub InitData()
        _newid.Value = flReg.WriteNumber(Request.Item("newid") & "")
        If _newid.Value = "0" Then
            cbImgNew.Visible = False
        Else
            spTitle.Text = "<span class='sp-title'>Danh sách ảnh trong bài viết?</span>"
        End If
        diroot = New DirectoryInfo(Server.MapPath(ROOT_FOLDER))
        If Not diroot.Exists Then diroot.Create()

        sDate = Request.Item("d") & ""
        If sDate <> "" Then
            _Years.Value = ReadSplit(sDate, 0)
            _Month.Value = ReadSplit(sDate, 1)
            _Day.Value = ReadSplit(sDate, 2)
        Else
            _Years.Value = Now.Year
            _Month.Value = GetNum(Now.Month)
            _Day.Value = GetNum(Now.Day)
        End If
        Call FolderUserName()

        _Folder.Nodes.Clear()
        Dim tmpnode As New RadTreeNode("Thư mục gốc", diroot.FullName.ToLower)
        _Folder.Nodes.Add(tmpnode)

        Call LoadFolder(tmpnode)
        tmpnode.Expanded = True

        Call SelectTree()
        Call LoadValue()

    End Sub
    Private Sub SelectTree()
        For Each nodeYear As RadTreeNode In _Folder.GetAllNodes
            If _Years.Value = NodeValue(nodeYear.Value) Then
                For Each nodeMonth As RadTreeNode In nodeYear.GetAllNodes
                    If _Month.Value = 0 Then
                        nodeYear.Selected = True
                        nodeYear.Expanded = True
                        Exit Sub
                    End If

                    If _Month.Value = NodeValue(nodeMonth.Value) Then
                        If _Day.Value = 0 Then
                            nodeMonth.Selected = True
                            nodeMonth.Expanded = True
                            nodeYear.Expanded = True
                            Exit Sub
                        End If
                        For Each nodeDay As RadTreeNode In nodeMonth.GetAllNodes
                            If _Day.Value = NodeValue(nodeDay.Value) Then
                                nodeDay.Selected = True
                                nodeMonth.Expanded = True
                                nodeYear.Expanded = True
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub NextPages()
        _Total.Value = CountTotal()
        If currPage = 1 Then
            If _Total.Value > pageRow Then
                vTotal = pageRow
            Else
                vTotal = _Total.Value
            End If
        Else
            If (_Total.Value - currPage * pageRow) > pageRow Then
                vTotal = (currPage * pageRow)
            Else
                vTotal = _Total.Value
            End If
        End If
    End Sub
    Public Sub LoadValue()
        currPage = flReg.WriteNumber(Request.Item("p") & "")
        _newid.Value = flReg.WriteNumber(Request.Item("newid") & "")
        If currPage = 0 Then currPage = 1
        If _Folder.SelectedNode Is Nothing Then Return
        foundFolder.Value = _Folder.SelectedNode.Value & "\" & _UserName.Value
        dirinfo = New DirectoryInfo(foundFolder.Value)
        If dirinfo.Exists Then
            allFiles = dirinfo.GetFiles()
            Array.Sort(allFiles, New clsCompareFileInfo)
            Call NextPages()
            litCount.Text = "<div class=""count"">Tổng số (" & _Total.Value & ")</div>"
            litView.Text = ""
            imgInsert.Value = "logo.png"
            If strFlag = "one" Then
                'Select one
                Select Case strType
                    Case "img"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH TỆP ẢNH ĐÃ UPLOAD</div>"
                        litFile.Text = " File ảnh <span>(png, jpg, jpeg, gif, bmp)</span>"
                        cmdDel.Text = "Xóa ảnh"
                        cmdSave.Visible = False
                        Call LoadOneImg("images")
                    Case "paper"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH TỆP ẢNH ĐÃ UPLOAD</div>"
                        litFile.Text = " File ảnh <span>(png, jpg, jpeg, gif, bmp)</span>"
                        cmdDel.Text = "Xóa ảnh"
                        cmdSave.Visible = False
                        Call LoadOneImg("baoin")
                    Case "doc"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH TÀI LIỆU ĐÃ UPLOAD</div>"
                        litFile.Text = " Tài liệu <span>(doc, docx, xls, xlsx, ppt, pptx, pdf)</span>"
                        cmdDel.Text = "Xóa tài liệu"
                        cmdDel.Attributes.Add("onClick", "return questiondelete('Bạn có muốn xóa danh sách tài liệu đã chọn không?')")
                        cmdSave.Visible = False
                        Call LoadOneDocument()
                    Case "video"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH VIDEO ĐÃ UPLOAD</div>"
                        litFile.Text = " File video <span>(mp4)</span>"
                        cmdDel.Text = "Xóa video"
                        cmdDel.Attributes.Add("onClick", "return questiondelete('Bạn có muốn xóa danh sách video đã chọn không?')")
                        Call LoadOneVideo()
                        cmdSave.Visible = False
                        imgInsert.Value = "autoplay.png"
                    Case "audio"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH AUDIO ĐÃ UPLOAD</div>"
                        litFile.Text = " File audio <span>(mp3)</span>"
                        cmdDel.Text = "Xóa audio"
                        cmdDel.Attributes.Add("onClick", "return questiondelete('Bạn có muốn xóa danh sách audio đã chọn không?')")
                        Call LoadOneAudio()
                        cmdSave.Visible = False
                        imgInsert.Value = "autoplay.png"
                End Select
            Else 'Select multi
                cmdSave.OnClientClick = "multiplechoose()"
                Select Case strType
                    Case "img"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH TỆP ẢNH ĐÃ UPLOAD</div>"

                        litFile.Text = " File ảnh <span>(png, jpg, jpeg, gif, bmp)</span>"
                        cmdSave.Text = "Chèn ảnh"
                        cmdDel.Text = "Xóa ảnh"
                        Call LoadMultiImg("images")
                    Case "paper"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH TỆP ẢNH ĐÃ UPLOAD</div>"
                        litFile.Text = " File ảnh <span>(png, jpg, jpeg, gif, bmp)</span>"
                        cmdSave.Text = "Chèn ảnh"
                        cmdDel.Text = "Xóa ảnh"
                        Call LoadMultiImg("baoin")
                    Case "doc"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH TÀI LIỆU ĐÃ UPLOAD</div>"
                        litFile.Text = " Tài liệu <span>(doc, docx, xls, xlsx, ppt, pptx, pdf)</span>"
                        cmdSave.Text = "Chèn tài liệu"
                        cmdDel.Text = "Xóa tài liệu"
                        cmdDel.Attributes.Add("onClick", "return questiondelete('Bạn có muốn xóa danh sách tài liệu đã chọn không?')")
                        Call LoadMultiDocument()
                    Case "video"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH VIDEO ĐÃ UPLOAD</div>"
                        litFile.Text = " File video <span>(mp4)</span>"
                        cmdSave.Text = "Chèn video"
                        cmdDel.Text = "Xóa video"
                        cmdDel.Attributes.Add("onClick", "return questiondelete('Bạn có muốn xóa danh sách video đã chọn không?')")
                        Call LoadMultiVideo()
                        imgInsert.Value = "autoplay.png"
                    Case "audio"
                        litTitle.Text = "<div class=""chotitle"">DANH SÁCH AUDIO ĐÃ UPLOAD</div>"
                        litFile.Text = " File audio <span>(mp3</span>"
                        cmdSave.Text = "Chèn audio"
                        cmdDel.Text = "Xóa audio"
                        cmdDel.Attributes.Add("onClick", "return questiondelete('Bạn có muốn xóa danh sách audio đã chọn không?')")
                        Call LoadMultiAudio()
                        imgInsert.Value = "autoplay.png"
                End Select
            End If

            litView.Text += "<div class=""clr""></div>"
            ScriptManager.RegisterStartupScript(Me.Page, Page.GetType(), Guid.NewGuid.ToString(), "nextPage(" & _Total.Value & "," & pageRow & "," & currPage & ",'" & RedirectURL() & "');", True)
        Else
            litView.Text = ""
        End If
        ScriptManager.RegisterStartupScript(Me.Page, Page.GetType(), "removewaiting", "removewaiting();", True)
    End Sub
    Private Sub LoadOneImg(folder As String)
        For i As Integer = ((currPage * pageRow) - pageRow) To vTotal - 1
            fileName = allFiles(i).Name
            If fileName.Contains(txtSearch.Text.Trim) Then
                fileType = flReg.GetFileType(fileName, ".").ToLower
                Select Case fileType
                    Case "jpg", "jpeg", "jpe", "jpe", "gif", "png", "bmp", "png", "svg", "ico", "ttf"
                        spath = FormatUrl(foundFolder.Value & "\" & fileName, folder)
                        litView.Text += "<div class=""cfdiv"">"
                        litView.Text += "<div class=""cfcheck xcheck"">"
                        litView.Text += "<input id=""id" & i & """ type=""checkbox"" name=""image"">"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""cfimg"" onclick=""onechoose('" & spath & "');"" ><span>"
                        litView.Text += "<img alt=""" & fileName & """ title=""" & fileName & """ src=""" & flReg.ImgSRC(spath, 150, 90, True) & """>"
                        litView.Text += "</span></div>"
                        litView.Text += "<div class=""mathpath"">" & foundFolder.Value & "\" & fileName & "</div>"
                        litView.Text += "<div class=""webpath"">" & spath & "</div>"
                        litView.Text += "<div class=""cftitle id" & i & """>" & fileName & "</div>"
                        litView.Text += "</div>"
                End Select
            End If
        Next
    End Sub
    Private Sub LoadMultiImg(folder As String)
        For i As Integer = ((currPage * pageRow) - pageRow) To vTotal - 1
            fileName = allFiles(i).Name
            If fileName.Contains(txtSearch.Text.Trim) Then
                fileType = flReg.GetFileType(fileName, ".").ToLower
                Select Case fileType
                    Case "jpg", "jpeg", "jpe", "jpe", "gif", "png", "bmp", "png", "svg", "ico", "ttf"
                        spath = FormatUrl(foundFolder.Value & "\" & fileName, folder)
                        litView.Text += "<div class=""cfdiv"">"
                        litView.Text += "<div class=""cfcheck xcheck"">"
                        litView.Text += "<input id=""id" & i & """ type=""checkbox"" name=""image""  onclick=""clickfile(this);"">"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""cfimg"" onclick=""selectedfile(this);""><span>"
                        litView.Text += "<img alt=""" & fileName & """ title=""" & fileName & """ src=""" & flReg.ImgSRC(spath, 150, 90, True) & """>"
                        litView.Text += "</span></div>"
                        litView.Text += "<div class=""cfinput"">"
                        litView.Text += "<input type=""text"" name=""text"" value=""" & spath & """>"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""mathpath"">" & foundFolder.Value & "\" & fileName & "</div>"
                        litView.Text += "<div class=""webpath"">" & spath & "</div>"
                        litView.Text += "<div class=""cftitle id" & i & """>" & fileName & "</div>"
                        litView.Text += "</div>"
                End Select
            End If
        Next
    End Sub
    Private Sub LoadOneVideo()
        For i As Integer = ((currPage * pageRow) - pageRow) To vTotal - 1
            fileName = allFiles(i).Name
            If fileName.Contains(txtSearch.Text.Trim) Then
                fileType = flReg.GetFileType(fileName, ".").ToLower
                Select Case fileType
                    Case "mp4"
                        spath = FormatUrl(foundFolder.Value, "video") & "/" & fileName & "|" & fileName
                        litView.Text += "<div class=""cfdiv"">"
                        litView.Text += "<div class=""cfcheck xcheck"">"
                        litView.Text += "<input id=""id" & i & """ type=""checkbox"" name=""image"">"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""cfimg"" onclick=""onechoose('" & spath & "');"" ><span>"

                        strImg = "/files/images/video.png?w=150&amp;h=90"
                        litView.Text += "<img alt=""" & fileName & """ title=""" & fileName & """ src=""" & strImg & """>"
                        litView.Text += "</span></div>"
                        litView.Text += "<div class=""mathpath"">" & foundFolder.Value & "\" & fileName & "</div>"
                        litView.Text += "<div class=""webpath"">" & spath & "</div>"
                        litView.Text += "<div class=""cftitle id" & i & """>" & fileName & "</div>"
                        litView.Text += "</div>"
                End Select
            End If
        Next
    End Sub
    Private Sub LoadMultiVideo()
        For i As Integer = ((currPage * pageRow) - pageRow) To vTotal - 1
            fileName = allFiles(i).Name
            If fileName.Contains(txtSearch.Text.Trim) Then
                fileType = flReg.GetFileType(fileName, ".").ToLower
                Select Case fileType
                    Case "mp4"
                        spath = FormatUrl(foundFolder.Value, "video") & "/" & fileName & "|" & fileName
                        litView.Text += "<div class=""cfdiv"">"
                        litView.Text += "<div class=""cfcheck xcheck"">"
                        litView.Text += "<input id=""id" & i & """ type=""checkbox"" name=""image"">"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""cfimg"" onclick=""selectedfile(this);""><span>"
                        strImg = "/files/images/video.png?w=150&amp;h=90"
                        litView.Text += "<img alt=""" & fileName & """ title=""" & fileName & """ src=""" & strImg & """>"
                        litView.Text += "</span></div>"

                        litView.Text += "<div class=""cfinput"">"
                        litView.Text += "<input type=""text"" name=""text"" value=""" & spath & """>"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""mathpath"">" & foundFolder.Value & "\" & fileName & "</div>"
                        litView.Text += "<div class=""webpath"">" & spath & "</div>"
                        litView.Text += "<div class=""cftitle id" & i & """>" & fileName & "</div>"
                        litView.Text += "</div>"
                End Select
            End If
        Next
    End Sub
    Private Sub LoadOneDocument()
        For i As Integer = ((currPage * pageRow) - pageRow) To vTotal - 1
            fileName = allFiles(i).Name
            If fileName.Contains(txtSearch.Text.Trim) Then
                fileType = flReg.GetFileType(fileName, ".").ToLower
                Select Case fileType
                    Case "doc", "docx", "xls", "xlsx", "ppt", "pptx", "pdf"
                        spath = FormatUrl(foundFolder.Value, "documents") & "/" & fileName & "|" & fileName

                        litView.Text += "<div class=""cfdiv"" >"
                        litView.Text += "<div class=""cfcheck xcheck"">"
                        litView.Text += "<input id=""id" & i & """ type=""checkbox"" name=""image"">"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""cfimg"" onclick=""onechoose('" & spath & "');"" ><span>"

                        strImg = "/image/editor/" & flReg.GetFileType(fileName, ".") & ".png?w=150&amp;h=90"
                        litView.Text += "<img alt=""" & fileName & """ title=""" & fileName & """ src=""" & strImg & """>"
                        litView.Text += "</span></div>"

                        litView.Text += "<div class=""mathpath"">" & foundFolder.Value & "\" & fileName & "</div>"
                        litView.Text += "<div class=""webpath"">" & spath & "</div>"
                        litView.Text += "<div class=""cftitle id" & i & """>" & fileName & "</div>"
                        litView.Text += "</div>"
                End Select
            End If
        Next
    End Sub
    Private Sub LoadMultiDocument()
        For i As Integer = ((currPage * pageRow) - pageRow) To vTotal - 1
            fileName = allFiles(i).Name
            If fileName.Contains(txtSearch.Text.Trim) Then
                fileType = flReg.GetFileType(fileName, ".").ToLower
                Select Case fileType
                    Case "doc", "docx", "xls", "xlsx", "ppt", "pptx", "pdf"
                        spath = FormatUrl(foundFolder.Value, "documents") & "/" & fileName & "|" & fileName

                        litView.Text += "<div class=""cfdiv"" >"
                        litView.Text += "<div class=""cfcheck xcheck"">"
                        litView.Text += "<input id=""id" & i & """ type=""checkbox"" name=""image"">"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""cfimg"" onclick=""selectedfile(this);""><span>"

                        strImg = "/image/editor/" & flReg.GetFileType(fileName, ".") & ".png?w=150&amp;h=90"
                        litView.Text += "<img alt=""" & fileName & """ title=""" & fileName & """ src=""" & strImg & """>"
                        litView.Text += "</span></div>"

                        litView.Text += "<div class=""cfinput"">"
                        litView.Text += "<input type=""text"" name=""text"" value=""" & spath & """>"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""mathpath"">" & foundFolder.Value & "\" & fileName & "</div>"
                        litView.Text += "<div class=""webpath"">" & spath & "</div>"
                        litView.Text += "<div class=""cftitle id" & i & """>" & fileName & "</div>"
                        litView.Text += "</div>"
                End Select
            End If
        Next
    End Sub
    Private Sub LoadOneAudio()
        For i As Integer = ((currPage * pageRow) - pageRow) To vTotal - 1
            fileName = allFiles(i).Name
            If fileName.Contains(txtSearch.Text.Trim) Then
                fileType = flReg.GetFileType(fileName, ".").ToLower
                Select Case fileType
                    Case "mp3"
                        spath = FormatUrl(foundFolder.Value, "audio") & "/" & fileName & "|" & fileName
                        litView.Text += "<div class=""cfdiv"">"
                        litView.Text += "<div class=""cfcheck xcheck"">"
                        litView.Text += "<input id=""id" & i & """ type=""checkbox"" name=""image"">"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""cfimg"" onclick=""onechoose('" & spath & "');"" ><span>"

                        strImg = "/files/images/audio.png?w=150&amp;h=90"
                        litView.Text += "<img alt=""" & fileName & """ title=""" & fileName & """ src=""" & strImg & """>"
                        litView.Text += "</span></div>"
                        litView.Text += "<div class=""mathpath"">" & foundFolder.Value & "\" & fileName & "</div>"
                        litView.Text += "<div class=""webpath"">" & spath & "</div>"
                        litView.Text += "<div class=""cftitle id" & i & """>" & fileName & "</div>"
                        litView.Text += "</div>"
                End Select
            End If
        Next
    End Sub
    Private Sub LoadMultiAudio()
        For i As Integer = ((currPage * pageRow) - pageRow) To vTotal - 1
            fileName = allFiles(i).Name
            If fileName.Contains(txtSearch.Text.Trim) Then
                fileType = flReg.GetFileType(fileName, ".").ToLower
                Select Case fileType
                    Case "mp3"
                        spath = FormatUrl(foundFolder.Value, "audio") & "/" & fileName & "|" & fileName
                        litView.Text += "<div class=""cfdiv"">"
                        litView.Text += "<div class=""cfcheck xcheck"">"
                        litView.Text += "<input id=""id" & i & """ type=""checkbox"" name=""image"">"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""cfimg"" onclick=""selectedfile(this);""><span>"
                        strImg = "/files/images/audio.png?w=150&amp;h=90"
                        litView.Text += "<img alt=""" & fileName & """ title=""" & fileName & """ src=""" & strImg & """>"
                        litView.Text += "</span></div>"

                        litView.Text += "<div class=""cfinput"">"
                        litView.Text += "<input type=""text"" name=""text"" value=""" & spath & """>"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""mathpath"">" & foundFolder.Value & "\" & fileName & "</div>"
                        litView.Text += "<div class=""webpath"">" & spath & "</div>"
                        litView.Text += "<div class=""cftitle id" & i & """>" & fileName & "</div>"
                        litView.Text += "</div>"
                End Select
            End If
        Next
    End Sub
    Private Sub cbImgNew_CheckedChanged(sender As Object, e As EventArgs) Handles cbImgNew.CheckedChanged
        If cbImgNew.Checked = False Then
            Call InitData()
        Else
            imgInsert.Value = "logo.png"
            litCount.Text = "<div class=""count"">Tổng số (0)</div>"
            If strFlag = "one" Then 'Select one
                cmdSave.Visible = False
                litTitle.Text = "<div class=""chotitle"">DANH SÁCH TỆP ẢNH ĐÃ UPLOAD</div>"
                litFile.Text = " File ảnh <span>(png, jpg, jpeg, gif, bmp)</span>"
                ScriptManager.RegisterStartupScript(Me.Page, Page.GetType(), "getImgOne_" & _newid.Value, "getContent('1');", True)
            Else 'Select multi
                cmdSave.OnClientClick = "multiplechoose()"
                litTitle.Text = "<div class=""chotitle"">DANH SÁCH TỆP ẢNH ĐÃ UPLOAD</div>"
                litFile.Text = " File ảnh <span>(jpg, jpeg, jpe, jpe, gif, png, bmp, png, svg, ico, ttf)</span>"
                cmdSave.Text = "Chèn ảnh"
                ScriptManager.RegisterStartupScript(Me.Page, Page.GetType(), "getImgMulti_" & _newid.Value, "getContent('2');", True)
            End If
        End If
    End Sub

#End Region


End Class
