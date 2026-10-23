Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.SVL.US.USE_ViecLam
    Partial Class View
        Inherits PortalModuleBase

        Dim arrTemp As New ArrayList
        Dim objController As New WorkController
        Dim liter As Literal, count As Integer
        Dim chBox As CheckBox
        Dim iCount, tempI As Integer
        Dim strUrl As String
        Dim ria As RadioButton, hid As HiddenField
        Dim wID As HiddenField
        Dim lbt As LinkButton
        Dim reInfo As New CMS_RecruitmentInfo
        Private Sub LoadValue()
            arrTemp = objController.CMS_TuyenDung_List_Search(Me.PortalId, txtFind.Text.Trim, ItemID.Value, "", 1)
            grdData.DataSource = arrTemp
            grdData.PageSize = arrTemp.Count + 1
            grdData.DataKeyField = "Work_ID"
            grdData.DataBind()
            Session.Item("USE_ViecLam") = arrTemp.Count

        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = (grdData.CurrentPageIndex * grdData.PageSize + e.Item.ItemIndex + 1).ToString()

            wID = e.Item.FindControl("Work_ID")
            wID.Value = DataBinder.Eval(e.Item.DataItem, "Work_ID")

            liter = e.Item.FindControl("SoLuong")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "Quantity")

            liter = e.Item.FindControl("ChucDanh")
            liter.Text = flDic.Position_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "LevelDesired_ID"))

            liter = e.Item.FindControl("MucLuong")
            liter.Text = flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID"))

            liter = e.Item.FindControl("CVDaNop")
            If objController.CMS_UserWork_Check(Me.PortalId, Me.UserInfo.Username, wID.Value) Then
                liter.Text = flCheck.JobUser_Name_SVL(Me.PortalId, objController.CMS_Job_ID_Member(Me.PortalId, flCheck.UngVien_ID(Me.PortalId, ItemID.Value, Me.UserInfo.Username), DataBinder.Eval(e.Item.DataItem, "Work_ID")))
            End If

            liter = e.Item.FindControl("Title")

            liter.Text = "<div><b><a  data-toggle=""modal"" onclick='popDetailJob(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "Work_ID") & """);' href=""javascript:;"" title=""Xem chi tiết hồ sơ"">" & DataBinder.Eval(e.Item.DataItem, "Title") & "</a></b></div>"
            'If flCheck.SVL_TinhTrangUngVien(Me.PortalId, ItemID.Value, DataBinder.Eval(e.Item.DataItem, "TuyenDung_ID"), Me.UserInfo.Username) = False Then
            '    liter.Text += "<span style=""float:Right;height:20px;padding: 5px !important;margin-top:-10px;"" title='Tin này được doanh nghiệp mời ứng tuyển' class='label label-success' >Mời ứng tuyển</span>"
            'End If

            liter.Text += "<div>" & flCheck.Business_Vn(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Business_ID")) & "</div>"

            liter = e.Item.FindControl("Edit")
            'liter.Text = "<div><a class=""aedit"" data-toggle=""modal"" onclick='popDetailJob(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "Work_ID") & """);' href=""javascript:;"" title=""Xem chi tiết hồ sơ""><img src=""/image/images/view.png?w=18"" alt=""edit"" />&nbsp;Xem</a></div>"
            If flCheck.SVL_TinhTrangUngVien(Me.PortalId, ItemID.Value, DataBinder.Eval(e.Item.DataItem, "TuyenDung_ID"), Me.UserInfo.Username) = False Then
                liter.Text = "<span title='Tin này được doanh nghiệp mời ứng tuyển' class='label label-success' ><span style=""padding:5px 0px;font-size:11px;"">Doanh nghiệp đã mời bạn</span></span>"
            End If
            lbt = e.Item.FindControl("cmdNopHS")
            If objController.CMS_UserWork_Check(Me.PortalId, Me.UserInfo.Username, wID.Value) Then
                lbt.Visible = False
                liter = e.Item.FindControl("litTrangThaiNop")
                liter.Text = "<span class='label label-info'>Đã nộp hồ sơ</span>"
            End If
            liter = e.Item.FindControl("TrangThai")
            tempI = flCheck.SVL_TinhTrangHoSo(Me.PortalId, ItemID.Value, DataBinder.Eval(e.Item.DataItem, "TuyenDung_ID"), Me.UserInfo.Username)
            Select Case tempI
                Case 1
                    liter.Text = "<span class='label label-success' >Đạt</span>"
                Case 2
                    liter.Text = "<span class='label label-success' >Không đạt</span>"
                Case 3
                    liter.Text = "<span class='label label-success' >Hẹn phỏng vấn lại</span>"
                Case 4
                    liter.Text = "<span class='label label-success' >Trúng sơ tuyển</span>"
                Case 5
                    liter.Text = "<span class='label label-success' >Đã mời tham gia</span>"
                Case Else
                    If objController.CMS_UserWork_Check(Me.PortalId, Me.UserInfo.Username, wID.Value) Then
                        liter.Text = "<span class='label label-success'  style=""background-color: #b7b7b7  !important;"">Chưa có kết quả</span>"
                    Else
                        liter.Text = "<span class='label label-success ' style=""background-color: #b7b7b7  !important;"" >Chưa nộp</span"
                    End If
                    'liter.Text = "<span class='label label-success ' style=""background-color: #b7b7b7  !important;"" >Chưa có kết quả</span"
            End Select

        End Sub
        Private Function TuyenDungID(doanhNghiep As String, workid As String, phiengd As String) As String
            TuyenDungID = ""
            Dim objtd As CMS_TuyenDungInfo = objController.CMS_TuyenDung_Get_ByWork(Me.PortalId, doanhNghiep, workid, phiengd)
            If IsNothing(objtd) = False Then
                TuyenDungID = objtd.TuyenDung_ID
            End If
        End Function
        Private Sub LoadProfile()
            If IsNothing(flCache.GetCache("CMS_JobUser_List_UserName_" & ItemID.Value & "_" & Me.UserInfo.Username)) Then
                arrTemp = objController.CMS_JobUser_List_UserName(Me.PortalId, Me.PortalId, Me.UserInfo.Username)
            Else
                arrTemp = CType(flCache.GetCache("CMS_JobUser_List_UserName_" & ItemID.Value & "_" & Me.UserInfo.Username), ArrayList)
            End If
            If arrTemp.Count > 0 Then
                flCache.SetCache("CMS_JobUser_List_UserName_" & ItemID.Value & "_" & Me.UserInfo.Username, arrTemp, SecondCache.M1)

                btnSend.Visible = True
                rptProfile.DataSource = arrTemp
                rptProfile.DataBind()
            End If
        End Sub
        Protected Sub onCommandItem(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim link As LinkButton = DirectCast(sender, LinkButton)
                _WID.Value = link.CommandName
                _BUSID.Value = link.CommandArgument
                If rptProfile.Items.Count > 0 Then
                    ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Nop_ho_so", "$('#boxNopHS').modal('show');", True)
                Else
                    ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Khong_Co_hs", "notify('Bạn chưa có hồ sơ, hãy tạo hồ sơ rồi quay lại.');", True)
                End If

            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub View_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                ItemID.Value = Request.Item("itemid") & ""
                _WID.Value = flCheck.getWork_ID(Me.PortalId, flReg.WriteNumber(Request.Item("idw")))
                _BUSID.Value = Request.Item("idb") & ""
                Call LoadValue()
                Call LoadProfile()
                litHotline1.Text = "<strong>Liên hệ Hotline hỗ trợ người lao động:</strong>&nbsp;<a href=""tel:" & CMS.flCheck.SetupValue(0, "NLD_Hotline") & """ class=""hotline"" title=""Hotline"">" & CMS.flCheck.SetupValue(0, "NLD_Hotline") & "</a>"
                If _WID.Value <> "" Then
                    ScriptManager.RegisterStartupScript(Me, Me.GetType(), "Nop_ho_so", "$('#boxNopHS').modal('show');", True)
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
            Call LoadValue()
        End Sub

        Private Sub View_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
            Try
                ItemID.Value = Request.Item("itemid") & ""
                Call LoadValue()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
            If _WID.Value = "" Then
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', 'Không tìm thấy tin tuyển dụng để nộp hồ sơ', 'Thông báo', false);", True)
                Exit Sub
            End If
            If objController.CMS_UserWork_Check(Me.PortalId, Me.UserInfo.Username, _WID.Value) = False Then
                Dim objDNUV As CMS_DoanhNghiep_UngVienInfo = objController.CMS_DoanhNghiep_UngVien_Get_By_UserName(Me.PortalId, ItemID.Value, Me.UserInfo.Username)
                Dim objInfo As CMS_DoanhNghiepInfo = objController.CMS_DoanhNghiep_Get_By_Business_ID(Me.PortalId, ItemID.Value, _BUSID.Value)
                Dim uvInfo As CMS_UngVienInfo = objController.CMS_UngVien_CheckByUserName(Me.PortalId, Me.UserInfo.Username)
                If rptProfile.Items.Count > 0 Then
                    iCount = 0
                    For Each item As RepeaterItem In rptProfile.Items
                        ria = item.FindControl("radProfile")
                        hid = item.FindControl("hdProfileId")
                        If ria.Checked = True Then
                            If IsNothing(uvInfo) = False Then
                                Dim uwInfo As New CMS_UserWorkInfo
                                uwInfo.UserWork_ID = flReg.GenKey()
                                uwInfo.UngVien_ID = uvInfo.UngVien_ID
                                uwInfo.Work_ID = _WID.Value
                                uwInfo.Job_ID = hid.Value
                                uwInfo.DoanhNghiep_ID = objInfo.DoanhNghiep_ID
                                uwInfo.CreatedBy = Now
                                objController.CMS_UserWork_Add(Me.PortalId, uwInfo)
                                Dim duvInfo As New CMS_DoanhNghiep_UngVienInfo
                                duvInfo.DNUV_ID = flReg.GenKey
                                duvInfo.PhienGD_ID = ItemID.Value
                                duvInfo.DoanhNghiep_ID = objInfo.DoanhNghiep_ID
                                duvInfo.UngVien_ID = uvInfo.UngVien_ID
                                duvInfo.BanPhongVan = objInfo.SoBan
                                duvInfo.TinhTrangPhongVan = 0
                                duvInfo.KetQuaPhongVan = 0
                                duvInfo.ChiTietPhongVan = ""
                                duvInfo.ThuTuPhongVan = 0
                                duvInfo.TuyenDung_ID = TuyenDungID(objInfo.DoanhNghiep_ID, _WID.Value, ItemID.Value)
                                duvInfo.TuyenDungName = flCheck.Work_Name("", Me.PortalId, _WID.Value)
                                duvInfo.ViTriDat = ""
                                duvInfo.ViTriDatName = ""
                                duvInfo.CreatedBy = Now
                                duvInfo.UserName = Me.UserInfo.Username
                                duvInfo.UpdatedBy = flReg.DateNull
                                duvInfo.UserUpdate = ""
                                objController.CMS_DoanhNghiep_UngVien_Add(Me.PortalId, duvInfo)
                                objController.CMS_DoanhNghiep_UngVien_Update_Status(Me.PortalId, duvInfo.DNUV_ID, True)
                            End If
                        End If
                    Next
                    For Each item As RepeaterItem In rptProfile.Items
                        ria = item.FindControl("radProfile")
                        hid = item.FindControl("hdProfileId")
                        If ria.Checked = True Then
                            reInfo = New CMS_RecruitmentInfo
                            reInfo.Recruitment_ID = flReg.GenKey()
                            reInfo.JobUser_ID = uvInfo.UngVien_ID
                            reInfo.Work_ID = _WID.Value
                            reInfo.IsView = 0
                            reInfo.IsContact = 0
                            reInfo.IsCancel = 0
                            reInfo.IsElect = 0
                            reInfo.IsInterview = 0
                            reInfo.IsTest = 0
                            reInfo.CreateDate = Now
                            reInfo.UserName = Me.UserInfo.Username
                            reInfo.UpdatedUser = Me.UserInfo.Username
                            reInfo.UpdatedDate = flReg.DateNull
                            objController.CMS_Recruitment_Add(Me.PortalId, reInfo)
                            flCache.RemoveCache("CMS_Recruitment_List_UserName_" & ItemID.Value & "_" & Me.UserInfo.Username)
                        End If
                    Next
                End If
                objController.CMS_Work_Update_Sent(Me.PortalId, _WID.Value)
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('success', 'Bạn đã nộp hồ sơ thành công', 'Thông báo', false);$('#boxNopHS').modal('hide')", True)
            Else
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "notify('info', 'Việc làm này bạn đã nộp hô sơ', 'Thông báo', false);$('#boxNopHS').modal('hide')", True)
            End If
        End Sub

        Private Sub rptProfile_ItemDataBound(sender As Object, e As RepeaterItemEventArgs) Handles rptProfile.ItemDataBound
            If e.Item.ItemType <> ListItemType.Item AndAlso e.Item.ItemType <> ListItemType.AlternatingItem Then Return
            Dim rdo As RadioButton = CType(e.Item.FindControl("radProfile"), RadioButton)
            Dim script As String = "SetUniqueRadioButton('rptProfile.*radJobUser',this)"
            rdo.Attributes.Add("onclick", script)
        End Sub
    End Class
End Namespace
