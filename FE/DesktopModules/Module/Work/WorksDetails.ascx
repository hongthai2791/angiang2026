<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="WorksDetails.ascx.vb" Inherits="DesktopModules.Modules.Read" %>
<%@ Register Src="~/DesktopModules/Module/News/Comments.ascx" TagPrefix="uc1" TagName="Comments" %>

<div id="fb-root"></div>
<script async defer crossorigin="anonymous" src="https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v18.0" nonce="IHg1i94f"></script>
<div class="detail-works">
    <div class="row">
        <div class="col-md-12">
            <h1 class="title_details">
                <asp:Literal ID="Title" runat="server"></asp:Literal></h1>
            <div class="col-md-12 pdl0 pdr0">
                <p class="title_company">
                    <asp:Literal ID="Business_Vn" runat="server"></asp:Literal>
                </p>
            </div>

            <div class="clear"></div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-7">
            <span class="line-icon-date">
                <i class="icon-countdown icon_16"></i><span class="pl_28">Hạn nộp hồ sơ: <span class="text_pink">
                    <asp:Literal ID="HanNop" runat="server"></asp:Literal>
                </span></span>
            </span>

        </div>
        <div class="col-md-5 pdr0 pdbt0 mgbt0">
            <div style="float: right">
                   <div class="fb-urltest none"><%=strFb %></div> 
               
                <div class="fb-share-button" data-href="<%=strFb %>" data-layout="button_count" data-size=""><a  target="_top"  href="https://www.facebook.com/sharer/sharer.php?u=<%=strFb %>&amp;src=sdkpreparse" class="fb-xfbml-parse-ignore">Chia sẻ</a></div>
                <div class="clear"></div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="col-md-12">
            <p class="text_grey2">
                <asp:Literal ID="LuotXem" runat="server"></asp:Literal>
            </p>
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
                <i class="icon-edu icon_16"></i><span class="pl_28">Trình độ CMKT: <span class="job_value">
                    <asp:Literal ID="TrinhDoCMKT" runat="server"></asp:Literal></span></span>
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
    <div class="clear"></div>
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
                <p class="title uppercase text_grey">Mô tả công việc</p>
            </div>
            <div class="col-md-9 wd-contents">
                <asp:Literal ID="MoTa" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="title uppercase text_grey">Quyền lợi được hưởng</p>
            </div>
            <div class="col-md-9 wd-contents">
                <asp:Literal ID="QuyenLoi" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="title uppercase text_grey">Yêu cầu công việc</p>
            </div>
            <div class="col-md-9 wd-contents">
                <asp:Literal ID="YeuCauCongViec" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="title uppercase text_grey">Yêu cầu hồ sơ</p>
            </div>
            <div class="col-md-9 wd-contents">
                <asp:Literal ID="YeuCauHoSo" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="title uppercase text_grey">Hình thức nộp hồ sơ</p>
            </div>
            <div class="col-md-9">
                Bấm vào nút <a href="<%=linkSend %>" title="Nộp hồ sơ" target="_blank" rel="nofollow"><b style="font-size: 16px!important; color: red">NỘP HỒ SƠ</b></a> để ứng tuyển
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3 col-xs-6">Hạn nộp hồ sơ</div>
            <div class="col-md-9 col-xs-6">
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
<div class="detail-works">
    <div class="row wd-row">
        <div class="col-md-12">
            <h3 class="title-work-h3">Thông tin liên hệ</h3>
        </div>
    </div>
    <div class="col-md-12" id="divThongTinLH" runat="server">
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="title text_grey">Người liên hệ</p>
            </div>
            <div class="col-md-9">
                <asp:Literal ID="NguoiLienHe" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="title text_grey">Địa chỉ liên hệ</p>
            </div>
            <div class="col-md-9">
                <asp:Literal ID="DiaChiLienHe" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="title text_grey">Điện thoại liên hệ</p>
            </div>
            <div class="col-md-9">
                <asp:Literal ID="Dienthoailienhe" runat="server"></asp:Literal>
            </div>

        </div>
        <div class="row">
            <div class="col-md-3">
                <p class="title text_grey">Email liên hệ</p>
            </div>
            <div class="col-md-9">
                <asp:Literal ID="Maillienhe" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
    <div class="col-md-12 " id="divThongTin" runat="server">
        <div class="row wd-row">
            <div class="col-md-3">
                <p class="title text_grey">Điện thoại liên hệ:</p>
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
    <div class="row">
        <div class="wd-note">
            Vui lòng <a target="_blank" class="dnworkdetail" href="<%=linkSend %>"><span style="font-weight: bold">Đăng nhập</span></a> để xem thông tin chi tiết!
        </div>
    </div>
    <div class="clear"></div>
</div>
<uc1:Comments runat="server" ID="Comments" />
<asp:Literal runat="server" ID="litRelated"></asp:Literal>
<asp:Literal ID="litSEO" runat="server"></asp:Literal>
<asp:HiddenField ID="ItemID" runat="server" />
