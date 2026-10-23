Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.INSU

Namespace DesktopModules.Modules
    Partial Class HomePage
        Inherits PortalModuleBase
        Dim sCode As String
        Private Function TenDichVu(dichVu As Integer) As String
            TenDichVu = ""
            If dichVu = 1 Then
                Return "Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp"
            ElseIf dichVu = 2 Then
                Return "Nộp hồ sơ đăng ký hỗ trợ học nghề"
            ElseIf dichVu = 3 Then
                Return "Nộp hồ sơ đăng ký tư vấn, giới thiệu việc làm"
            ElseIf dichVu = 4 Then
                Return "Nộp hồ sơ đăng ký thông báo tìm kiếm việc làm"
            End If
        End Function
        Private Sub FindMode_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                If Page.IsPostBack = False Then
                    If Request.Item("tb") = "nop-ho-so-thanh-cong" Then
                        If flReg.WriteNumber(Request.Item("type")) = ProType.DKXH Then
                            Dim obj As EXE_NumberAutoInfo = New InsuController().EXE_NumberAuto_Get(0, Request.Item("id"))
                            If IsNothing(obj) = False Then
                                sCode = obj.NoCode
                                lbTitle.Text = "Phiếu đăng ký xếp hàng online"
                                litView.Text = "<div class=""col-md-3 col-xs-4""><img src=""" & bigCode.QRCode(sCode, flReg.UrlAlias & "/tra-cuu-ho-so/ma-hs/" & sCode) & """ alt=""Mã hồ sơ""></div>"
                                litView.Text += "<div class=""col-md-9 col-xs-8"">"
                                litView.Text += "<p class='tbnote1'>" & flCheck.Portal_Name(0, obj.PortalID).ToUpper() & "</p>"
                                litView.Text += "<p class='tbnote2'>" & TenDichVu(obj.DichVu) & "</p>"
                                litView.Text += "<p>Mã số đăng ký online của bạn là</p>"
                                litView.Text += "</div>"
                                litView.Text += "<span><img src=""" & bigCode.BARCode(sCode, False) & """ alt=""Mã hồ sơ""></span>"
                                litView.Text += "<span>" & sCode & "</span>"
                                litView.Text += "<div class=""clear""></div>"
                                litView.Text += "<div class=""col-md-12"">"
                                litView.Text += "<p class='tbnote3'>SỐ THỨ TỰ</p>"
                                litView.Text += "<div class='tbnote4'>" & obj.ThuTu & "</div>"
                                litView.Text += "</div>"
                                litView.Text += "<div class=""clear""></div>"
                                litView.Text += "<div class=""col-md-12 note"">Bạn cần lưu ý: </div>"
                                litView.Text += "<div class=""col-md-12 note-1"">Mã Qrcode hoặc Barcode dùng để kiểm tra khi đến làm việc tại đơn vị.</div>"
                                litView.Text += "<div class=""col-md-12 note-1"">In hoặc lưu lại phiếu đăng ký để xếp số khi đến làm việc tại đơn vị đăng ký.</div>"
                                litView.Text += "<div class=""col-md-12 note-1"">Khi đến làm việc mang theo CMND hoặc CCCD để đối chiếu với thông tin đăng ký.</div>"
                                litView.Text += "<div class=""clear""></div>"
                            End If

                        Else
                            sCode = flCheck.GetCode(0, Request.Item("id"), Request.Item("type"))
                            litView.Text = "<div class=""col-md-3""><img src=""" & bigCode.QRCode(sCode, flReg.UrlAlias & "/tra-cuu-ho-so/ma-hs/" & sCode) & """ alt=""Mã hồ sơ""></div>"
                            litView.Text += "<div class=""col-md-9"">"
                            litView.Text += "<p style='font-size:14px'>Bạn đã nộp hồ sơ trên hệ thống dịch vụ công trực tuyến</p>"
                            litView.Text += "<p class='tbnote1'>CỤC VIỆC LÀM - BỘ LAO ĐỘNG - THƯƠNG BINH VÀ XÃ HỘI</p>"
                            litView.Text += "<p>Mã số tiếp nhận hồ sơ online của bạn là:</p>"
                            litView.Text += "</div>"
                            litView.Text += "<span><img src=""" & bigCode.BARCode(sCode, False) & """ alt=""Mã hồ sơ""></span>"
                            litView.Text += "<span>" & sCode & "</span>"
                            litView.Text += "<p class=""mgt10"">Đơn vị tiếp nhận:</p>"
                            litView.Text += "<p class='tbnote1 txt-center'>" & flCheck.Portal_Name(0, flReg.WriteNumber(Request.Item("pid"))).ToUpper() & "</p>"
                            litView.Text += "<div class=""clear""></div>"
                            litView.Text += "<div class=""col-md-12 note"">Bạn cần lưu ý:  </div>"
                            litView.Text += "<div class=""col-md-12 note-1"">Phiếu hẹn trả kết quả của bạn được gửi vào địa chỉ email, vui lòng kiểm tra email để nhận phiếu hẹn.</div>"
                            litView.Text += "<div class=""col-md-12 note-1"">Mã số tiếp nhận và email dùng để tra cứu tình trạng xử lý hồ sơ, bổ sung hồ sơ khi có yêu cầu.</div>"
                            litView.Text += "<div class=""clear""></div>"

                        End If
                    Else
                        litView.Text = "<div class=""col-md-3""><img src=""" & bigCode.QRCode("0000", flReg.UrlAlias & "/huong-dan-su-dung/") & """ alt=""Mã hồ sơ""></div>"
                        litView.Text += "<div class=""col-md-9"">"
                        litView.Text += "<p style='font-size:14px'>Bạn đã nộp hồ sơ trên hệ thống dịch vụ công trực tuyến</p>"
                        litView.Text += "<p class='tbnote1'>CỤC VIỆC LÀM - BỘ LAO ĐỘNG - THƯƠNG BINH VÀ XÃ HỘI</p>"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""clear""></div>"
                        litView.Text += "<div class=""col-md-12"">"
                        litView.Text += "<p class=""note-2""><i class=""fa fa-check-square-o"" aria-hidden=""true""></i>&nbsp;&nbsp;&nbsp;Hiện tại yêu cầu của bạn hệ thống chưa kịp xử lý.</p>"
                        litView.Text += "<p class=""note-2""><i class=""fa fa-check-square-o"" aria-hidden=""true""></i>&nbsp;&nbsp;&nbsp;Hoặc đường truyền dữ liệu không ổn định.</p>"
                        litView.Text += "<p class=""note-2""><i class=""fa fa-check-square-o"" aria-hidden=""true""></i>&nbsp;&nbsp;&nbsp;Vui lòng thử lại sau hoặc liên hệ tới Trung tâm để được trợ giúp.</p>"
                        litView.Text += "<p class=""note-2 mgt20"">Trân trọng!</p>"
                        litView.Text += "</div>"
                        litView.Text += "<div class=""clear""></div>"

                    End If
                End If
            Catch ex As Exception
                litView.Text = ex.Message
            End Try
        End Sub


    End Class
End Namespace

