<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="JobUserEdit.ascx.vb" Inherits="DesktopModules.Modules.Read" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">
                <asp:Literal ID="Title" runat="server"></asp:Literal></h3>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="box-jobuser">
            <div class="detail-jobuser">
                <div class="row">
                    <div class="col-md-3 pdl0 logo-jobus">
                        <div class="row">
                            <asp:Literal ID="JobUser_Img" runat="server"></asp:Literal>
                            <div class="clear "></div>
                        </div>
                    </div>
                    <div class="col-md-7 pdl0 pdr0">
                        <p class="title-jobus">
                            <asp:Literal ID="JobUser_Vn" runat="server"></asp:Literal>
                        </p>
                        <div class="clear"></div>
                        <div class="info-comdetail">
                            <asp:Literal ID="litInfo" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="col-md-2 txt-right">
                        <asp:LinkButton ID="saveJobView" CssClass="btn btn-whitehs btn-save-job" runat="server">
                                <span class="line-icon">
                                <i class="icon-star icon_free_style"></i><span class="pl_28">Lưu hồ sơ</span>
                                </span>
                        </asp:LinkButton>
                        <div class="clear mgt10"></div>
                        <asp:Literal runat="server" ID="litTB" />
                        <div class="clear mgt10"></div>
                        <asp:LinkButton ID="lbJobInvite" CssClass="btn btn-warning btnmoi" runat="server">
                                <i class="fa fa-telegram"></i><span class="pdl5">Mời ứng tuyển</span>
                        </asp:LinkButton>
                          <div class="clear mgt10 pdt5"></div>
                        <asp:Literal runat="server" ID="litMUV" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
                <div class="row">
                    <asp:Literal ID="litCin" runat="server"></asp:Literal>
                </div>
            </div>
            <div class="detail-jobuser">
                <div class="row">
                    <span class="title_details">Thông tin trình độ, kinh nghiệm</span>
                </div>
                <div class="row pdt10">
                    <asp:Literal ID="ltTrinhDo" runat="server"></asp:Literal>
                </div>
            </div>
            <div class="detail-jobuser">
                <div class="row">
                    <span class="title_details">Thông tin mục tiêu, kỹ năng</span>
                </div>
                <div class="row pdt10">
                    <asp:Literal ID="ltrMucTieu" runat="server"></asp:Literal>
                </div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>
<div class="row text-center pd10">
    <div>
             
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
<asp:HiddenField ID="ItemID" runat="server" />
<asp:HiddenField ID="Das" runat="server" />

<div class="remodal-overlay" style="display: none;"></div>
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
            <div class="center">
                <button type="button" class="btn-big btn-danger w260 font16" style="padding-left: 0px; padding-right: 0px;" onclick="location.href='/business/view/bus-jobuser'">Xem hồ sơ phù hợp khác</button>
            </div>
            <div class="center">
                <button type="button" class="btn-big btn-primary2 w260 font16" onclick="location.href='/business/view/bus-profile-save'">Về Tủ hồ sơ</button>
            </div>
            <div class="footer_popup_success">
                Bạn gặp khó khăn khi tìm ứng viên phù hợp?<br>
                <asp:Literal ID="litHotline" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    function toogleModal(modal, status) { if (status == true) { $('.remodal-overlay').css("display", "block"); $('.remodal-wrapper').css("display", "none"); $(modal).css("display", "block"); } else { $('.remodal-overlay').css("display", "none"); $('.remodal-wrapper').css("display", "none"); } };
</script>


