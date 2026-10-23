Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace Modules.Job_UserBHTNEdit
    Partial Class Edit
        Inherits Entities.Modules.PortalModuleBase
        Dim objCTL As New WorkController()
        Dim obj As New CMS_JobUserInfo
        Dim objbhtn As New HoSoBHTNInfo
        Dim item As New ListItem
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValue()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)
            End Try
        End Sub

        Private Sub InitControls()
            IsSuper.Value = flDic.IsSuper(Me.PortalId, Me.UserInfo.Username, Me.PortalSettings.ActiveTab.TabName)
            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
            If Request.Item("qh") <> "" Then QuanHuyen.SelectedValue = Request.Item("qh")
            Call flFunction.LoadSalary(Me.PortalId, Salary_ID)
            Call flFunction.LoadExperience(Me.PortalId, Experience_ID)
            Call flDic.LoadEducation(Me.PortalId, Level_ID)
            Call flFunction.LoadNeeds(Me.PortalId, Needs_ID)
            Call flFunction.LoadCareer(Me.PortalId, Career_ID)
            Call flDic.LoadPosition(Me.PortalId, LevelDesired)
            Call flDic.LoadPosition(Me.PortalId, CurrentLevel)
            StartDate.Text = flReg.ReadDate(Now, False)
            EndDate.Text = flReg.ReadDate(Now.AddDays(15), False)
            Call LoadCongViec()
        End Sub
        Private Sub LoadCongViec()
            BHTN_NganhngheMongmuon.Items.Clear()
            BHTN_NganhngheMongmuon.Items.Add(New ListItem("Tất cả", -1))
            For Each cr As DanhMucChungBHTN In objCTL.DanhMucChungBHTN_List("DM_Nganhnghe_tuyendung")
                BHTN_NganhngheMongmuon.Items.Add(New ListItem(cr.Name, cr.Id))
            Next
        End Sub
        Private Sub BackEnd()
            Response.Redirect("/" & Me.PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("edit"), True)
        End Sub
        Private Sub LoadValue()
            objbhtn = objCTL.GetHoSoBHTN(flReg.WebConfig("PortalBHTN"), Request.Item("id"))
            If IsNothing(objbhtn) = False Then
                BHTN_HoTen.Text = objbhtn.HoTen
                BHTN_NgaySinh.Text = objbhtn.NgaySinh
                BHTN_GDPhoThong.Text = objbhtn.GDPhoThong
                BHTN_GioiTinh.Text = objbhtn.Gioitinh_Name
                BHTN_CMND.Text = objbhtn.CMND
                BHTN_NgayCap.Text = flReg.ReadDate(objbhtn.NgayCapCMND, False)
                BHTN_NoiCap.Text = objbhtn.NoiCapCMND
                BHTN_SoBHXH.Text = objbhtn.SoSoBHXH
                BHTN_Email.Text = objbhtn.Email
                BHTN_DienThoai.Text = objbhtn.SDT
                BHTN_DanToc.Text = objbhtn.DanToc
                BHTN_TonGiao.Text = objbhtn.TonGiao
                BHTN_TDCM.Text = objbhtn.TrinhDoCMKT
                BHTN_IDNghe.Value = objbhtn.IdNghe
                BHTN_Kinhnghiemlamviec.Text = objbhtn.Kinhnghiemlamviec
                Title.Text = "BHTN_" & BHTN_HoTen.Text
                ItemID.Value = objbhtn.Id.ToString
                BHTN_NganhngheMongmuon.SelectedValue = objbhtn.IDGTVLNganhngheMongmuon
                BHTN_ViTri.Text = objbhtn.GTVLViTri
                BHTN_MucLuong.Text = objbhtn.GTVLMucLuong
                GTVLNoiLamViecMongmuon_TenHuyen.Text = objbhtn.GTVLNoiLamViecMongmuon_TenHuyen
                GTVLNoiLamViecMongmuon_TenTinh.Text = objbhtn.GTVLNoiLamViecMongmuon_TenTinh
                item = Experience_ID.Items.FindByText(BHTN_Kinhnghiemlamviec.Text)
                If IsNothing(item) = False Then
                    Experience_ID.SelectedValue = item.Value
                Else
                    Experience_ID.SelectedValue = "d2315a91-8409-4cac-a69e-8bc145435105"
                End If

                item = Career_ID.Items.FindByText(BHTN_NganhngheMongmuon.SelectedItem.Text)
                If IsNothing(item) = False Then
                    Career_ID.SelectedValue = item.Value
                Else
                    Career_ID.SelectedValue = "b232396b-52d8-4abb-bb96-e4121f293f61"
                End If
                item = TinhTP.Items.FindByText(GTVLNoiLamViecMongmuon_TenTinh.Text)
                If IsNothing(item) = False Then
                    TinhTP.SelectedValue = item.Value
                    Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
                    item = QuanHuyen.Items.FindByText(GTVLNoiLamViecMongmuon_TenHuyen.Text)
                    If IsNothing(item) = False Then QuanHuyen.SelectedValue = item.Value
                End If
                item = LevelDesired.Items.FindByText(BHTN_ViTri.Text)
                If IsNothing(item) = False Then
                    LevelDesired.SelectedValue = item.Value
                Else
                    LevelDesired.SelectedValue = ""
                End If
                item = Salary_ID.Items.FindByText(BHTN_MucLuong.Text)
                If IsNothing(item) = False Then
                    Salary_ID.SelectedValue = item.Value
                Else
                    Salary_ID.SelectedValue = "7ff812b5-2a2f-4857-8de7-1325a91745e3"
                End If
                Needs_ID.SelectedValue = "3120720169193668"
                If String.IsNullOrEmpty(BHTN_IDNghe.Value) = False Then
                    Select Case flReg.WriteNumber(BHTN_IDNghe.Value)
                        Case 7
                            Level_ID.SelectedValue = 3
                        Case 5
                            Level_ID.SelectedValue = 5
                        Case 6
                            Level_ID.SelectedValue = 4
                        Case Else
                            Level_ID.SelectedValue = 20
                    End Select
                End If
                Education.Content = "Trình độ giáo dục phổ thông: " & BHTN_GDPhoThong.Text & "<br>"
                For Each cr As HoSoBHTN_QTDaoTao In objCTL.Off_GTVL_TrinhDoDaoTao_GetAll(objbhtn.Id)
                    Education.Content += "Chuyên ngành: " & cr.ChuyenNganhDaoTao & " - Trình độ đào tạo: " & cr.TrinhDoDaoTao & "<br>"
                Next
                CareerGoals.Content = ""
                For Each cr As HoSoBHTN_QTLamViec In objCTL.Off_GTVL_QuaTrinhLamViec_GetAll(objbhtn.Id)
                    CareerGoals.Content += "Từ " & cr.ThoiGianLamViec & ": Làm " & cr.ViTriDaLam & " tại " & cr.TenDonVi & "<br>"
                Next
                SkillsForte.Content = ""
                If String.IsNullOrEmpty(objbhtn.TrinhDoNgoaiNgu) = False Then SkillsForte.Content += "Trình độ ngoại ngữ: " & objbhtn.TrinhDoNgoaiNgu & "<br>"
                If String.IsNullOrEmpty(objbhtn.TrinhDoTinHoc) = False Then SkillsForte.Content += "Trình độ tin học: " & objbhtn.TrinhDoTinHoc & "<br>"
                If String.IsNullOrEmpty(objbhtn.Kynangnghe) = False Then SkillsForte.Content += "Kỹ năng nghề: " & objbhtn.Kynangnghe & "<br>"
                If String.IsNullOrEmpty(objbhtn.KhaNangNoiTroi) = False Then SkillsForte.Content += "Khả năng nổi trội: " & objbhtn.KhaNangNoiTroi
                WorkExperience.Content = ""
                WorkExperience.Content = objbhtn.GTVLKhac
                If String.IsNullOrEmpty(objbhtn.DieuKienLamViec) = False Then SkillsForte.Content += "Mong muốn làm việc: " & objbhtn.DieuKienLamViec

            End If

        End Sub

        Private Sub AddInfo(quick As Boolean)
            Try
                If quick = False Then
                    If flReg.WriteDate(EndDate.Text, False) < flReg.WriteDate(StartDate.Text, False) Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('warning', 'Ngày đăng phải lớn hơn hoặc bằng ngày hết hạn!', 'Thông báo', false);", True)
                        Exit Sub
                    End If
                    If String.IsNullOrEmpty(ItemID.Value) Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "notify_info", "removewaiting();notify('warning', 'Không tìm thấy hồ sơ BHTN để thêm mới!', 'Thông báo', false);", True)
                        Exit Sub
                    End If
                End If
                obj = New CMS_JobUserInfo
                obj.Title = Title.Text.Trim
                obj.Career_ID = Career_ID.SelectedValue
                obj.CurrentLevel = CurrentLevel.SelectedValue
                obj.LevelDesired = LevelDesired.SelectedValue

                obj.TinhTP = TinhTP.SelectedValue
                obj.QuanHuyen = QuanHuyen.SelectedValue
                obj.Experience_ID = Experience_ID.SelectedValue
                obj.Level_ID = Level_ID.SelectedValue
                obj.Salary_ID = Salary_ID.SelectedValue
                obj.Needs_ID = Needs_ID.SelectedValue
                obj.Education = Education.Content
                obj.CareerGoals = CareerGoals.Content
                obj.WorkExperience = WorkExperience.Content
                obj.SkillsForte = SkillsForte.Content
                obj.UserAdmin = ""
                obj.StartDate = flReg.WriteDate(StartDate.Text, False)
                obj.EndDate = flReg.WriteDate(EndDate.Text, False)
                obj.IsDelete = False
                obj.DeletedUser = ""
                obj.DeletedDate = flReg.DateNull
                obj.IsApproval = IsApproval.Checked
                obj.ApprovalUser = UserInfo.Username
                obj.ApprovalDate = Now
                obj.PortalID = Me.PortalId
                obj.JobUser_ID = flReg.GenKey()
                obj.CreatedDate = Now
                obj.CreatedUser = UserInfo.Username
                obj.UpdatedDate = flReg.DateNull
                Dim objJ As New CMS_JobUserBHTNInfo
                objJ.BHTN_ID = ItemID.Value
                objJ.HoTen = BHTN_HoTen.Text
                objJ.NgaySinh = BHTN_NgaySinh.Text
                objJ.GioiTinh = BHTN_GioiTinh.Text
                objJ.Email = BHTN_Email.Text
                objJ.SoDienThoai = BHTN_DienThoai.Text
                objCTL.CMS_JobUser_AddFromBTHN(Me.PortalId, obj, objJ)
                Call BackEnd()
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "page_load", "removewaiting(); notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, Me.PortalSettings.ActiveTab.TabName) & "', 'Thông báo', false);", True)

            End Try
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub

        Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
            AddInfo(False)
        End Sub

        Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
            AddInfo(True)
        End Sub

        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, QuanHuyen, TinhTP.SelectedValue)
        End Sub
    End Class
End Namespace
