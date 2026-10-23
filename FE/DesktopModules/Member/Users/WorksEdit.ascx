<%@ Control Language="vb" ClientIDMode="Static" AutoEventWireup="false" Explicit="true" CodeFile="WorksEdit.ascx.vb" Inherits="DesktopModules.Modules.WorksEdit" %>
<asp:UpdatePanel ID="udpWorkDetail" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">
                        <asp:Literal ID="Title" runat="server"></asp:Literal></h3>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="detail-works">
                    <div class="row">
                        <div class="col-md-12">
                            <p class="title_company">
                                <asp:Literal ID="Business_Vn" runat="server"></asp:Literal>
                            </p>
                            <div class="clear"></div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-9">
                            <asp:LinkButton ID="saveJobView" CssClass="btn btn-white btn-save-job" runat="server">
                                <span class="line-icon">
                                    <i class="icon-star icon_free_style"></i><span class="pl_28">Lưu việc làm</span>
                                </span>
                            </asp:LinkButton>
                            <asp:LinkButton ID="saveJobWrong" CssClass="btn btn-white btn-save-job" runat="server">
                                <span class="line-icon">
                                    <i class="fa fa-exclamation"></i><span class="pl_28 red">Báo cáo sai</span>
                                </span>
                            </asp:LinkButton>
                            <asp:Literal runat="server" ID="litTB" />
                            <span class="line-icon-date">
                                <i class="icon-countdown icon_16"></i><span class="pl_28">Hạn nộp hồ sơ: <span class="text_pink">
                                    <asp:Literal ID="HanNop" runat="server"></asp:Literal>
                                </span></span>
                            </span>
                            <p class="text_grey2 pdt10">
                                <asp:Literal ID="LuotXem" runat="server"></asp:Literal>
                            </p>
                        </div>
                        <div class="col-md-3 txt-right">
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn-nophoso pull-right btn btn-xlg btn-pink font16" OnCommand="btnOpenModalProfile_Command" Text="Nộp hồ sơ"></asp:LinkButton>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="job_detail"></div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-money icon_16"></i><span class="pl_28">Mức lương: <span class="job_value">
                                    <asp:Literal ID="MucLuong" runat="server"></asp:Literal></span>
                                </span>
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-address icon_16"></i><span class="pl_28">Nơi làm việc:
                    <asp:Literal ID="DiaDiem" runat="server"></asp:Literal></span>
                            </p>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-exp icon_16"></i><span class="pl_28">Kinh nghiệm: <span class="job_value">
                                    <asp:Literal ID="KinhNghiem" runat="server"></asp:Literal></span></span>
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-position icon_16"></i><span class="pl_28">Chức vụ: <span class="job_value">
                                    <asp:Literal ID="ChucVu" runat="server"></asp:Literal></span></span>
                            </p>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-edu icon_16"></i><span class="pl_28">Bằng cấp: <span class="job_value">
                                    <asp:Literal ID="BangCap" runat="server"></asp:Literal></span></span>
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-job-type icon_16"></i><span class="pl_28">Hình thức làm việc: <span class="job_value">
                                    <asp:Literal ID="HinhThuc" runat="server"></asp:Literal></span></span>
                            </p>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-quantity icon_16"></i><span class="pl_28">Số lượng cần tuyển: <span class="job_value">
                                    <asp:Literal ID="SoLuong" runat="server"></asp:Literal></span></span>
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-gender icon_16"></i><span class="pl_28">Yêu cầu giới tính: <span class="job_value">
                                    <asp:Literal ID="GioiTinh" runat="server"></asp:Literal></span></span>
                            </p>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="line-icon mb_12">
                                <i class="icon-career icon_16"></i>
                                <h2 class="pl_28 font14 fwb">Ngành nghề:
                                <asp:Literal ID="NganhNghe" runat="server"></asp:Literal></h2>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <p class="line-icon mb_12">
                                <i class="icon-age icon_16"></i><span class="pl_28">Vị trí tuyển dụng: <span class="job_value">
                                    <asp:Literal ID="ViTri" runat="server"></asp:Literal></span></span>
                            </p>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear" style="border-bottom: 1px solid #eee"></div>
                </div>
                <div class="detail-works">
                    <div class="row wd-row">
                        <div class="col-md-12">
                            <h3 class="title-work-h3">Thông tin tuyển dụng</h3>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="row wd-row">
                            <div class="col-md-3">
                                <p class="text_grey">Mô tả công việc</p>
                            </div>
                            <div class="col-md-9 wd-contents">
                                <asp:Literal ID="MoTa" runat="server"></asp:Literal>
                            </div>
                        </div>
                        <div class="row wd-row">
                            <div class="col-md-3">
                                <p class="text_grey">Quyền lợi được hưởng</p>
                            </div>
                            <div class="col-md-9 wd-contents">
                                <asp:Literal ID="QuyenLoi" runat="server"></asp:Literal>
                            </div>
                        </div>
                        <div class="row wd-row">
                            <div class="col-md-3">
                                <p class="text_grey">Yêu cầu công việc</p>
                            </div>
                            <div class="col-md-9 wd-contents">
                                <asp:Literal ID="YeuCauCongViec" runat="server"></asp:Literal>
                            </div>
                        </div>
                        <div class="row wd-row">
                            <div class="col-md-3">
                                <p class="text_grey">Yêu cầu hồ sơ</p>
                            </div>
                            <div class="col-md-9 wd-contents">
                                <asp:Literal ID="YeuCauHoSo" runat="server"></asp:Literal>
                            </div>
                        </div>
                        <div class="row wd-row">
                            <div class="col-md-3">
                                <p class="text_grey">Hình thức nộp hồ sơ</p>
                            </div>
                            <div class="col-md-9">
                                    <asp:LinkButton ID="LinkButton2" runat="server"  OnCommand="btnOpenModalProfile_Command" ><span style="color:black">Bấm vào nút <b>NỘP HỒ SƠ</b> để ứng tuyển</span></asp:LinkButton>
                            </div>
                        </div>
                        <div class="row wd-row">
                            <div class="col-md-3 ">Hạn nộp hồ sơ</div>
                            <div class="col-md-9">
                                <span class="line-icon">
                                    <span class="pt_20">
                                        <i class="icon-countdown icon_16"></i><span class="text_pink pl_28">
                                            <asp:Literal ID="HanNop2" runat="server"></asp:Literal></span>
                                    </span>
                                   
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="detail-works noboderbt">
                   <div class="row wd-row">
        <div class="col-md-12">
            <h3 class="title-work-h3">Thông tin liên hệ</h3>
        </div>
    </div>
    <div class="col-md-12" id="divThongTinLH" runat="server">
        <div class="row wd-row">
            <div class="col-md-3">
                <p class=" text_grey">Người liên hệ</p>
            </div>
            <div class="col-md-9">
                <asp:Literal ID="NguoiLienHe" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="text_grey">Địa chỉ liên hệ</p>
            </div>
            <div class="col-md-9">
                <asp:Literal ID="DiaChiLienHe" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="text_grey">Điện thoại liên hệ</p>
            </div>
            <div class="col-md-9">
                <asp:Literal ID="Dienthoailienhe" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                <p class="text_grey">Email liên hệ</p>
            </div>
            <div class="col-md-9">
                <asp:Literal ID="Maillienhe" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
    <div class="col-md-12 " id="divThongTin" runat="server">
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="text_grey">Điện thoại liên hệ:</p>
            </div>
            <div class="col-md-9 DTLienHe">
                <asp:Literal ID="DTLienHe" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="text_grey">Email liên hệ:</p>
            </div>
            <div class="col-md-9 DTLienHe">
                <asp:Literal ID="Email" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
    <div class="clear"></div>
                </div>
            </div>
        </div>
        <%-- Send profile --%>
        <div class="remodal-overlay" style="display: none;"></div>
        <div class="remodal-wrapper nhs_ds" style="display: none;">
            <div class="remodal p0 remodal-width applyJob remodal-is-initialized">
                <button class="remodal-close" onclick="toogleModal('abc',false);"><i class="fa fa-times" aria-hidden="true"></i></button>
                <div id="pop_resume">
                    <div class="hs_block">Hồ sơ của bạn</div>
                    <div class="demo-list">
                        <asp:Repeater ID="rptProfile" runat="server">
                            <ItemTemplate>
                                <asp:RadioButton ID="radProfile" runat="server" CssClass="RadioButton radProfile" onclick="checkradio(this);" ValidationGroup="Profile" />
                                <asp:HiddenField ID="hdProfileId" runat="server" Value='<%# Eval("JobUser_ID") %>' />
                                <span class="font16"><%# Eval("Title") %></span>
                                <p class="rpt-p">
                                    <i class="fa fa-calendar" aria-hidden="true"></i>
                                    Ngày đăng: <%# EPORTAL.flReg.ReadDate(Eval("StartDate"), False) %>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <i class="fa fa-eye" aria-hidden="true"></i>
                                    Lượt xem: <%# EPORTAL.flReg.FormatPrice(Eval("IsView")) %>
                                </p>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="center mt-20">
                        <asp:Button ID="btnSend" Visible="false" runat="server" CssClass="btn-big btn-danger btn_nop " Text="Nộp hồ sơ" />
                    </div>
                    <div class="footer_popup_success">
                        Bạn gặp khó khăn khi tìm việc?<br>
                        <asp:Literal ID="litHotline1" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>
        <%-- Success --%>
        <div class="remodal-wrapper nhs_ds_success" style="display: none;">
            <div class="remodal popup_content remodal-is-initialized remodal-is-closed">
                <button class="remodal-close" onclick="toogleModal('abc',false);"><i class="fa fa-times" aria-hidden="true"></i></button>
                <div class="lh25">
                    <div class="" id="content_popup2 ">
                        <h1 style="padding: 0px 0px 10px 0px; line-height: 18px;" class="text_green_new font18 center">
                            <i class="icon icon-xs icon-success_new"></i>BẠN ĐÃ NỘP HỒ SƠ THÀNH CÔNG!
                        </h1>
                        <asp:Literal ID="litThankYou" runat="server"></asp:Literal>
                    </div>
                    <div class="mgt20  center">
                        <button type="button" class="btn-big btn-danger w260 font16" style="padding-left: 0px; padding-right: 0px;" onclick="location.href='/users/view/us-works'">Xem việc làm phù hợp khác</button>
                    </div>
                    <div class="footer_popup_success">
                        Bạn gặp khó khăn khi tìm việc?<br>
                        <asp:Literal ID="litHotline2" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>
        <%-- Save work --%>
        <div class="remodal-wrapper nhs_replace_success" style="display: none; margin: 150px auto; height: 100%">
            <div class="remodal popup_content remodal-is-initialized remodal-is-closed">
                <button class="remodal-close" onclick="toogleModal('abc',false);"><i class="fa fa-times" aria-hidden="true"></i></button>
                <div class="font14 lh25 ">
                    <div class="center">
                        <span id="content_popup ">
                            <h1 style="margin-bottom: 25px; line-height: 18px;" class="text_green_new font18 center">
                                <i class="icon icon-xs icon-success_new"></i>BẠN ĐÃ LƯU HỒ SƠ THÀNH CÔNG!
                            </h1>
                        </span>
                    </div>
                    <div class="mgt20  center">
                        <button type="button" class="btn-big btn-danger w260 font16" style="padding-left: 0px; padding-right: 0px;" onclick="location.href='/users/view/us-works'">Xem việc làm phù hợp khác</button>
                    </div>
                    <div class="mgt20  center">
                        <button type="button" class="btn-big btn-primary2 w260 font16" onclick="location.href='/users/view/us-works-save'">Về Tủ hồ sơ</button>
                    </div>
                    <div class="footer_popup_success">
                        Bạn gặp khó khăn khi tìm việc?<br>
                        <asp:Literal ID="litHotline3" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>

        <div class="row text-center pd10">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
            </div>
        </div>
        <asp:HiddenField ID="ItemID" runat="server" />
        <asp:HiddenField ID="busID" runat="server" />
        <script type="text/javascript">
             function toogleModal(modal, status) {
                if (status == true) {
                    $('.remodal-overlay').css("display", "block");
                    $('.remodal-wrapper').css("display", "none");
                    $(modal).css("display", "block");
                } else {
                    $('.remodal-overlay').css("display", "none");
                    $('.remodal-wrapper').css("display", "none");
                }
            };
            function checkradio(t) {
                $(".radProfile input").each(function (e) {
                    if ($(this).attr("name") != $(t).attr("name")) {
                        $(this).removeAttr("checked");
                    }
                });
            };
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:PostBackTrigger ControlID="LinkButton1" />
        <asp:PostBackTrigger ControlID="LinkButton2" />
        <asp:PostBackTrigger ControlID="btnSend" />
        <asp:PostBackTrigger ControlID="saveJobView" />
    </Triggers>
</asp:UpdatePanel>
