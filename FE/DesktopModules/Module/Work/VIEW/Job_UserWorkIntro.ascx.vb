Imports Aspose.Words
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK
Imports GemBox.Document

Namespace Modules.EPORTAL
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Dim objController As New WorkController()
        Dim arrTemp As New ArrayList
        Dim chBox As CheckBox, liter As Literal
        Dim buInfo As New CMS_BusinessInfo
        Dim i, j As Integer, pnV As Panel
        Dim strURL As String
        Dim ctotal As Integer
        Dim obj As New CMS_WorkInfo
        Dim obj2 As New CMS_BusinessInfo
        Private Sub InitControls()
            hIdUser.Value = Me.UserInfo.Username
            txtkey.Attributes.Add("onkeypress", "return clickButton(event,'" & cmdSearch.ClientID & "')")
            txtkey.Text = flReg.RequestSearch(Request.RawUrl)
            FromDate.Text = Now.ToString("01/MM/yyyy")
            ToDate.Text = DateTime.DaysInMonth(Now.Year, Now.Month) & Now.ToString("/MM/yyyy")
            Call flDic.LoadPageSize(drPageSize)
            If Request.Item("num") <> "" Then drPageSize.SelectedValue = Request.Item("num")

            Call flFunction.LoadSalary(Me.PortalId, Salary_ID, "- - Mức lương - -")
            Salary_ID.SelectedValue = Request.Item("sal") & ""

            Call flFunction.LoadExperience(Me.PortalId, Experience_ID, "- - Kinh nghiệm - -")
            Experience_ID.SelectedValue = Request.Item("exp") & ""

            Call flDic.LoadRegional_Parent_Null(Me.PortalId, TinhTP, "")
            If Request.Item("tp") <> "" Then TinhTP.SelectedValue = Request.Item("tp")

            Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "- - Phường/ xã - -")
            If Request.Item("px") <> "" Then XaPhuong.SelectedValue = Request.Item("px")

            Call flFunction.LoadCareer(Me.PortalId, Career_ID, "- - Ngành nghề - -")
            Career_ID.SelectedValue = Request.Item("car")

            Call flFunction.LoadStatusType(Status_ID)
            Status_ID.SelectedValue = Request.Item("sta")


            Call flDic.LoadSex(Gender, "- - Giới tính - -")
            Gender.SelectedValue = Request.Item("gen")


            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, XaPhuong.SelectedValue)
            Business_ID.SelectedValue = Request.Item("bus")

            currPage.Value = flReg.WriteNumber(Request.Item("p"))
            If currPage.Value = "0" Then currPage.Value = "1"

            ViewState("UrlReferrer") = flReg.ConvertUrlReferrer(Request.UrlReferrer, Me.PortalSettings.ActiveTab.TabName)
        End Sub

        Private Sub LoadValues()
            Dim totalCV As Integer = 0
            arrTemp = New ArrayList : i = 1 : ctotal = 0
            For Each Cr As CMS_RecruitmentInfo In objController.CMS_Recruitment_List_Search_GT(Me.PortalId, txtkey.Text.Trim, flReg.RemoveScript(txtkey.Text.Trim), currPage.Value, 35, Gender.SelectedValue,
                                                        Business_ID.SelectedValue, Experience_ID.SelectedValue, TinhTP.SelectedValue, XaPhuong.SelectedValue, flReg.WriteDate(FromDate.Text, False), flReg.WriteDate(ToDate.Text, False),
                                                        Salary_ID.SelectedValue, Career_ID.SelectedValue, Status_ID.SelectedValue, "")
                Cr.STT = i
                arrTemp.Add(Cr)
                j = 1
                For Each Cj As CMS_RecruitmentInfo In objController.CMS_Recruitment_List_Search_GT(Me.PortalId, txtkey.Text.Trim, flReg.RemoveScript(txtkey.Text.Trim), currPage.Value, 35, Gender.SelectedValue,
                                                        Business_ID.SelectedValue, Experience_ID.SelectedValue, TinhTP.SelectedValue, XaPhuong.SelectedValue, flReg.WriteDate(FromDate.Text, False), flReg.WriteDate(ToDate.Text, False),
                                                        Salary_ID.SelectedValue, Career_ID.SelectedValue, Status_ID.SelectedValue, Cr.Work_ID)
                    Cj.STT = i & "." & j
                    arrTemp.Add(Cj)

                    j += 1
                    ctotal += 1
                    totalCV += 1
                Next
                Cr.Ctotal = ctotal : ctotal = 0
                i += 1

            Next

            grdData.DataSource = arrTemp
            grdData.PageSize = drPageSize.SelectedValue
            grdData.DataKeyField = "Work_ID"
            grdData.DataBind()
            litCount.Text = 0 : litPage.Text = ""
            hrefPage.Value = flReg.UrlAlias() & RedirectURL()
            For Each Cr As CMS_RecruitmentInfo In arrTemp
                litPage.Text = flReg.NextPage(Cr.Total, drPageSize.SelectedValue, currPage.Value, 10, hrefPage.Value & "/p/")
                litCount.Text = totalCV
                Exit For
            Next
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "myFunction", "removewaiting();", True)
        End Sub


        Private Function RedirectURL() As String
            RedirectURL = "/" & PortalSettings.ActiveTab.TabName & "/view/" & Request.Item("view")
            If TinhTP.SelectedValue <> "" Then RedirectURL += "/tp/" & TinhTP.SelectedValue
            If XaPhuong.SelectedValue <> "" Then RedirectURL += "/px/" & XaPhuong.SelectedValue
            If Business_ID.SelectedValue <> "" Then RedirectURL += "/bus/" & Business_ID.SelectedValue
            If Salary_ID.SelectedValue <> "" Then RedirectURL += "/sal/" & Salary_ID.SelectedValue
            If Experience_ID.SelectedValue <> "" Then RedirectURL += "/exp/" & Experience_ID.SelectedValue
            If Career_ID.SelectedValue <> "" Then RedirectURL += "/car/" & Career_ID.SelectedValue
            If Gender.SelectedValue <> "" Then RedirectURL += "/gen/" & Gender.SelectedValue
            If Status_ID.SelectedValue <> "0" Then RedirectURL += "/sta/" & Status_ID.SelectedValue
            If drPageSize.SelectedValue <> "35" Then RedirectURL += "/num/" & drPageSize.SelectedValue
            If txtkey.Text.Trim <> "" Then RedirectURL += "/s/" & flReg.EncodeSearch(txtkey.Text.Trim())
        End Function
        Private Sub TinhTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TinhTP.SelectedIndexChanged
            Call flDic.LoadRegional_Parent_ID(Me.PortalId, XaPhuong, TinhTP.SelectedValue, "- - Phường/ xã - -")
            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, XaPhuong.SelectedValue)

            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Private Sub QuanHuyen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles XaPhuong.SelectedIndexChanged
            Call flFunction.LoadBusiness(Me.PortalId, Business_ID, TinhTP.SelectedValue, XaPhuong.SelectedValue)

            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    Call InitControls()
                    Call LoadValues()
                End If
            Catch ex As Exception
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), flReg.GenKey(), "notify('info', '" & flReg.BugLog(Me.PortalId, ex.Message, "app") & "', 'Thông báo', false);", True)
            End Try
        End Sub
        Private Sub BackEnd()
            Response.Redirect(ViewState("UrlReferrer"), True)
        End Sub
        Protected Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click, drPageSize.SelectedIndexChanged,
                        Status_ID.SelectedIndexChanged, Career_ID.SelectedIndexChanged, Salary_ID.SelectedIndexChanged, Experience_ID.SelectedIndexChanged,
                        Business_ID.SelectedIndexChanged, TinhTP.SelectedIndexChanged, XaPhuong.SelectedIndexChanged, Gender.SelectedIndexChanged, FromDate.TextChanged, ToDate.TextChanged
            ScriptManager.RegisterStartupScript(pageView, pageView.GetType(), "changeUrl", "changeUrl('" & RedirectURL() & "');", True)
            Call LoadValues()
        End Sub
        Protected Sub grdData_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdData.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            liter = e.Item.FindControl("IsOrder")
            liter.Text = DataBinder.Eval(e.Item.DataItem, "STT")

            If DataBinder.Eval(e.Item.DataItem, "W_Title") <> "" Then
                e.Item.CssClass = "black bold tr-parent"
                liter = e.Item.FindControl("W_Title")
                liter.Text = "<div style='float:left; width:calc(100% - 35px);'><a onclick='popDetailVL(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "Work_ID") & """);'  title='Xem chi tiết tin tuyển dụng' class=""text_grey2"">"
                liter.Text += "<img src='/image/images/view.png?w' title='Xem tin tuyển dụng'>&nbsp;</a>[" & flCheck.ReadCode(DataBinder.Eval(e.Item.DataItem, "wID")) & "]&nbsp;" & DataBinder.Eval(e.Item.DataItem, "W_Title") & "</div>"
                liter.Text += "<div class=""td-angle header expand""><i class=""fa fa-angle-double-down"" aria-hidden=""true"" ></i></div>"

                liter = e.Item.FindControl("CV_UngTuyen")
                liter.Text = "Lượt xem: " & DataBinder.Eval(e.Item.DataItem, "LuotXem")

                liter = e.Item.FindControl("SoLuong")
                liter.Text = "<div class=""col-md-6"">Cần tuyển: " & DataBinder.Eval(e.Item.DataItem, "Quantity") & "</div>"
                liter.Text += "<div class=""col-md-6"">Giới thiệu: " & DataBinder.Eval(e.Item.DataItem, "Ctotal") & "</div>"

                pnV = e.Item.FindControl("pnTrangThai")
                pnV.Visible = False
            Else

                liter = e.Item.FindControl("HoTen")
                liter.Text = "<div class=""col-sm-2""><img align=""middle"" class=""center-block"" src=""" & flCheck.JobUser_Avatar(obj.PortalID, "" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID") & "") & "?w=48"" title=""Ảnh đại diện""></div>"
                liter.Text += "<div class=""col-sm-10"">" & flDic.getHoTen(0, DataBinder.Eval(e.Item.DataItem, "UserAdmin"))
                liter.Text += "<div>Địa chỉ: " & flDic.getDiaChi(0, DataBinder.Eval(e.Item.DataItem, "UserAdmin")) & "</div>"


                liter.Text += "<div class=""col-sm-12 pdl0"">Ngày giới thiệu: " & flReg.ReadDate(DataBinder.Eval(e.Item.DataItem, "CreateDate"), False) & "</div>"
                liter.Text += "<div class=""col-sm-12 pdl0"">Mức lương mong muốn: " & flCheck.Salary_Name(Me.PortalId, DataBinder.Eval(e.Item.DataItem, "Salary_ID")) & "</div>"
                liter.Text += "</div> "
                liter = e.Item.FindControl("Tuoi")
                liter.Text = flDic.getTuoi(flDic.getNgaySinh(0, DataBinder.Eval(e.Item.DataItem, "UserAdmin")))

                liter = e.Item.FindControl("CV_UngTuyen")

                liter.Text += "<div class=""col-md-11 ""><a onclick='popGTVL(" & Me.PortalId & ",""" & DataBinder.Eval(e.Item.DataItem, "JobUser_ID") & """,""" & DataBinder.Eval(e.Item.DataItem, "wID") & """,""" & Me.UserInfo.Username & """);'  title='Xem chi tiết hồ sơ ứng viên' class=""text_grey2"">"
                liter.Text += "<img src='/image/images/view.png?w' title='Xem hồ sơ ứng viên'>&nbsp; " & DataBinder.Eval(e.Item.DataItem, "Title") & "</a></div>"

                chBox = e.Item.FindControl("IsView")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsView")

                chBox = e.Item.FindControl("IsContact")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsContact")

                chBox = e.Item.FindControl("IsInterview")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsInterview")

                chBox = e.Item.FindControl("IsTest")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsTest")

                chBox = e.Item.FindControl("IsElect")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsElect")

                chBox = e.Item.FindControl("IsCancel")
                chBox.Checked = DataBinder.Eval(e.Item.DataItem, "IsCancel")

            End If
        End Sub
        Protected Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
            Call BackEnd()
        End Sub
        Sub ReplaceText(ByVal doc As Document, ByVal oldValue As String, ByVal newValue As String)
            doc.Range.Replace(oldValue, newValue, False, False)
        End Sub

        Public Function GenerateIframeDownloadHtmlCode(sFileUrl As String, Optional sFilename As String = "") As String
            Dim sResult As String = ""
            If sFilename = "" Then
                sFilename = System.IO.Path.GetFileName(sFileUrl)
            End If
            sResult = String.Format("<iframe src='/sp/download.aspx?fn={0}&fu={1}'></iframe>", HttpUtility.UrlEncode(flReg.EnCode64(sFilename)), HttpUtility.UrlEncode(flReg.EnCode64(sFileUrl)))
            Return sResult
        End Function
        Public Sub cmdExport_Click(sender As Object, e As EventArgs)
            Dim recuidId = CType(sender, LinkButton).CommandArgument
            If String.IsNullOrEmpty(recuidId) = False Then
                Dim doc As Document
                Dim recuiInfo = objController.CMS_Recruitment_Get(Me.PortalId, recuidId)
                Dim objUser = objController.CMS_JobUser_Get(Me.PortalId, recuiInfo.JobUser_ID)
                Dim wInfo = objController.CMS_Work_Get(Me.PortalId, recuiInfo.Work_ID)
                Dim objBus = objController.CMS_Business_Get(Me.PortalId, wInfo.Business_ID)

                Dim objUs As CMSUserPortalInfo = flDnn.CMSUserPortal_Get_By_User("", recuiInfo.UserName, "", Me.PortalId)
                doc = New Document(Server.MapPath("/api/work/Template/PhieuGioiThieuViecLam.doc"))

                If doc IsNot Nothing Then
                    ReplaceText(doc, "[TenLD]", objUs.DisplayName)
                    ReplaceText(doc, "[NgayGioiThieu]", Now.ToString("dd/MM/yyyy"))
                    ReplaceText(doc, "[Sogiaygioithieu]", "")
                    ReplaceText(doc, "[DanhTinh2]", "Ông/bà")
                    ReplaceText(doc, "[NgaySinh]", flReg.ReadDate(objUs.DateOfBirth, False))
                    ReplaceText(doc, "[TenDonVi]", objBus.Business_Vn)
                    ReplaceText(doc, "[CMTND]", "")
                    ReplaceText(doc, "[NgayCapCMTND]", "")
                    ReplaceText(doc, "[NoiCapCMTND]", "")
                    ReplaceText(doc, "[SoDienThoai]", objUs.Telephone)
                    ReplaceText(doc, "[Email]", objUs.Email)
                    ReplaceText(doc, "[DiaChiThuongTru]", "")
                    ReplaceText(doc, "[DiaChiHienTai]", "")
                    ReplaceText(doc, "[TrinhDoQDPhoThong]", "")
                    ReplaceText(doc, "[TrinhDoCMKT]", "")
                    ReplaceText(doc, "[KinhNghiemLamViec]", "")
                    ReplaceText(doc, "[ViTriDuTuyen]", wInfo.Title)
                    ReplaceText(doc, "[NgayHetGiaTri]", Now.AddDays(7).ToString("dd/MM/yyyy"))

                End If
                Dim fileSave = flReg.GenKey() & ".doc"
                Dim pathTemp = Server.MapPath(flReg.MapPath("/data/0/temps/") & fileSave)
                doc.Save(pathTemp)
                lblDownLoad.Text = GenerateIframeDownloadHtmlCode(flReg.MapPath("/data/0/temps/") & fileSave)
            End If
        End Sub
    End Class

End Namespace
