Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Namespace DesktopModules.Modules
    Partial Class NhuanBut
        Inherits CDefault
        Dim ObjController As New CmsController
        Dim txtg As TextBox, lit As Literal
        Dim nbDetailInfo As New CMS_News_NBDetailInfo
        Dim nbInfo As New CMS_News_NBInfo
        Dim dmNhuanButInfo As New CMS_DMNhuanButInfo
        Dim drlist As DropDownList
        Dim liter As Literal
        Dim SoLuong As Integer = 1, pubMonth As Integer, pubYear As Integer
        Dim arr, arrTemp, arrTempTin, arrTempAnh As New ArrayList

        Private Sub LoadValues()
            pubMonth = Now.Month
            pubYear = Now.Year
            Select Case IsType.Value
                Case CategoryType.Album
                    Dim obj As CMS_NewsInfo = ObjController.CMS_News_Get(PortalID.Value, ItemID.Value)
                    If IsNothing(obj) = False Then
                        lbTitle.Text = "Phóng sự ảnh: " & obj.Title
                        pubMonth = obj.PublishedDate.Month
                        pubYear = obj.PublishedDate.Year
                    End If
                Case CategoryType.Video
                    Dim obj As CMS_MediaInfo = ObjController.CMS_Media_Get(PortalID.Value, ItemID.Value)
                    If IsNothing(obj) = False Then
                        lbTitle.Text = "Video: " & obj.Name
                        pubMonth = obj.PublishedDate.Month
                        pubYear = obj.PublishedDate.Year
                    End If
                Case CategoryType.Audio
                    Dim obj As CMS_MediaInfo = ObjController.CMS_Media_Get(PortalID.Value, ItemID.Value)
                    If IsNothing(obj) = False Then
                        lbTitle.Text = "Audio: " & obj.Name
                        pubMonth = obj.PublishedDate.Month
                        pubYear = obj.PublishedDate.Year
                    End If
                Case Else
                    Dim obj As CMS_NewsInfo = ObjController.CMS_News_Get(PortalID.Value, ItemID.Value)
                    If IsNothing(obj) = False Then
                        lbTitle.Text = "Tin bài: " & obj.Title
                        pubMonth = obj.PublishedDate.Month
                        pubYear = obj.PublishedDate.Year
                    End If
            End Select

        End Sub

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Try
                ItemID.Value = Context.Request.Item("itemid")
                PortalID.Value = Context.Request.Item("pid")
                IsType.Value = Context.Request.Item("type")
                Username.Value = Context.Request.Item("us")
                If Not IsPostBack Then
                    Call LoadValues()
                    Call LoadNhuanBut()

                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(PortalID.Value, ex.Message, "cms") & "', 'Thông báo', false);", True)

            End Try
        End Sub

        Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            Try
                Call SaveNhuanBut()
                Call LoadNhuanBut()
                lbmsg.Text = "<div class=""dnnFormMessage dnnFormValidationSummary mspad"">Đã cập nhật lại thông tin chấm nhuận bút thành công</div>"
            Catch ex As Exception
                lbmsg.Text = "<div class=""dnnFormMessage dnnFormValidationSummary mspad"">Lỗi cập nhật thông tin chấm nhuận bút</div>"
            End Try
        End Sub

        Private Sub LoadNhuanBut()
            arrTempTin = LoadDM(1)
            drMaDMTin.Items.Add(New ListItem("- - - Chọn định mức - - -", 0))
            For Each item As CMS_DMNhuanButInfo In arrTempTin
                drMaDMTin.Items.Add(New ListItem(item.MaDM, item.ID.ToString))
            Next

            nbInfo = ObjController.CMS_News_NB_Get_By_NewsID(PortalID.Value, flReg.WriteNumber(ItemID.Value), CategoryType.News)
            If Not IsNothing(nbInfo) Then
                drMaDMTin.SelectedValue = nbInfo.DM_ID
                NB_ID.Value = nbInfo.ID
                arr = ObjController.CMS_News_NBDetail_List_By_NewsNBID(PortalID.Value, NB_ID.Value)
                If arr.Count > 0 Then
                    grdDMAnh.DataSource = arr
                    grdDMAnh.PageSize = 20
                    grdDMAnh.DataKeyField = "ID"
                    grdDMAnh.DataBind()
                Else
                    arrTempAnh = LoadDM(2)
                    grdDMAnh.DataSource = arrTempAnh
                    grdDMAnh.PageSize = 20
                    grdDMAnh.DataKeyField = "ID"
                    grdDMAnh.DataBind()
                End If
            Else
                arrTempAnh = LoadDM(2)
                grdDMAnh.DataSource = arrTempAnh
                grdDMAnh.PageSize = 20
                grdDMAnh.DataKeyField = "ID"
                grdDMAnh.DataBind()
            End If
        End Sub
        Private Function LoadDM(Type As Integer) As ArrayList
            arr = ObjController.CMS_DMNhuanBut_Get_By_Type(PortalID.Value, Type, pubMonth, pubYear)
            If arr.Count = 0 Then
                If pubMonth - 1 = 0 Then
                    arr = ObjController.CMS_DMNhuanBut_Get_By_Type(PortalID.Value, Type, 12, pubYear - 1)
                Else
                    arr = ObjController.CMS_DMNhuanBut_Get_By_Type(PortalID.Value, Type, pubMonth - 1, pubYear)
                End If
                For Each item As CMS_DMNhuanButInfo In arr
                    dmNhuanButInfo = New CMS_DMNhuanButInfo
                    dmNhuanButInfo.MaDM = item.MaDM
                    dmNhuanButInfo.Type = item.Type
                    dmNhuanButInfo.HeSo = item.HeSo
                    dmNhuanButInfo.Price = item.DonGia
                    dmNhuanButInfo.Month = Now.Month
                    dmNhuanButInfo.Year = Now.Year
                    dmNhuanButInfo.Description = item.Description
                    dmNhuanButInfo.Orders = item.Orders
                    dmNhuanButInfo.Active = item.Active

                    dmNhuanButInfo.CreateUser = Me.Username.Value
                    dmNhuanButInfo.CreateDate = Now
                    dmNhuanButInfo.UpdateUser = ""
                    dmNhuanButInfo.UpdateDate = Now
                    ObjController.CMS_DMNhuanBut_Add(PortalID.Value, dmNhuanButInfo)
                Next
            End If
            Return arr
        End Function
        Private Sub SaveNhuanBut()
            Dim tinM As Integer
            dmNhuanButInfo = ObjController.CMS_DMNhuanBut_Get(PortalID.Value, drMaDMTin.SelectedValue)
            If IsNothing(dmNhuanButInfo) = False Then
                tinM = dmNhuanButInfo.DonGia * dmNhuanButInfo.HeSo
            End If
            nbInfo = New CMS_News_NBInfo
            nbInfo.NewsID = ItemID.Value
            nbInfo.DM_ID = drMaDMTin.SelectedValue
            nbInfo.Price = tinM

            If NB_ID.Value <> "" Then
                nbInfo.ID = NB_ID.Value
                nbInfo.CreateDate = Now
                nbInfo.CreateUser = Username.Value
                nbInfo.UpdateUser = Username.Value
                nbInfo.UpdateDate = Now
                nbInfo.Type = CategoryType.News
                ObjController.CMS_News_NB_Update(PortalID.Value, nbInfo)
            Else
                nbInfo.CreateDate = Now
                nbInfo.CreateUser = Username.Value
                nbInfo.UpdateUser = ""
                nbInfo.UpdateDate = Now
                nbInfo.Type = CategoryType.News
                nbInfo.ID = ObjController.CMS_News_NB_Add(PortalID.Value, nbInfo)
            End If

            For Each rowItem As DataGridItem In grdDMAnh.Items
                nbDetailInfo = New CMS_News_NBDetailInfo
                If NB_ID.Value <> "" Then
                    nbDetailInfo.NewsNB_ID = NB_ID.Value
                Else
                    nbDetailInfo.NewsNB_ID = nbInfo.ID
                End If

                liter = rowItem.FindControl("ID")
                nbDetailInfo.ID = liter.Text

                liter = rowItem.FindControl("drMaDMAnh")
                nbDetailInfo.MaDM = liter.Text

                liter = rowItem.FindControl("HeSo")
                nbDetailInfo.HeSo = flReg.WriteNumber(liter.Text)

                txtg = rowItem.FindControl("SoLuong")
                nbDetailInfo.SoLuong = flReg.WriteNumber(txtg.Text)

                liter = rowItem.FindControl("DonGia")
                nbDetailInfo.DonGia = flReg.WriteNumber(liter.Text)

                nbDetailInfo.Price = nbDetailInfo.SoLuong * nbDetailInfo.DonGia * nbDetailInfo.HeSo

                nbDetailInfo.CreateDate = Now
                nbDetailInfo.CreateUser = Username.Value
                nbDetailInfo.UpdateDate = Now
                nbDetailInfo.UpdateUser = Username.Value
                ObjController.CMS_News_NBDetail_Add(PortalID.Value, nbDetailInfo)
            Next
        End Sub
        Private Sub grdDMAnh_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdDMAnh.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub

            liter = e.Item.FindControl("IsOrder")
            liter.Text = e.Item.ItemIndex + 1

            liter = e.Item.FindControl("DonGia")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "DonGia")

            liter = e.Item.FindControl("ID")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "ID")

            liter = e.Item.FindControl("drMaDMAnh")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "MaDM")

            liter = e.Item.FindControl("HeSo")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "HeSo")

            txtg = e.Item.FindControl("SoLuong")
            txtg.Text = DataBinder.Eval(e.Item.DataItem, "SoLuong")
            txtg.Attributes.Add("onchange", "updatePrice(" & DataBinder.Eval(e.Item.DataItem, "HeSo") & "," &
                                DataBinder.Eval(e.Item.DataItem, "DonGia") & ",this," & DataBinder.Eval(e.Item.DataItem, "ID") & ")")

            txtg = e.Item.FindControl("IsMoney")
            txtg.Text = DataBinder.Eval(e.Item.DataItem, "Price")
            txtg.CssClass = txtg.CssClass & " money-" & DataBinder.Eval(e.Item.DataItem, "ID")
        End Sub
    End Class

End Namespace