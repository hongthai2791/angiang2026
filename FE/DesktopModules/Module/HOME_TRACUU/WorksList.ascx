<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WorksList.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeWorks" %>

<div class="box box-info">
    <div class="box-body">
        <div class="main-body box-search-job">
            <div class="col-md-12">
                <div class="col-xs-6 ViTri">
                    <asp:DropDownList ID="ViTri" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-xs-6 MucLuong">
                    <asp:DropDownList ID="MucLuong" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-xs-6 KinhNghiem">
                    <asp:DropDownList ID="KinhNghiem" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-xs-6 GioiTinh">
                    <asp:DropDownList ID="GioiTinh" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-xs-12 mgt10">
                    <asp:TextBox ID="txtSearch" runat="server" placeholder="Tìm kiếm theo tiêu đề tin ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <asp:Panel runat="server" ID="pnList" Visible="false"> 
                       <div class="box_list_works">
       <asp:Literal ID="litVal" runat="server"></asp:Literal>
   </div>
                </asp:Panel>
                <asp:Panel runat="server" ID="pnDetail" Visible="false">
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
                                        <asp:Literal ID="Literal1" runat="server"></asp:Literal></span>
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
                                        <asp:Literal ID="Literal2" runat="server"></asp:Literal></span></span>
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
                                        <asp:Literal ID="Literal3" runat="server"></asp:Literal></span></span>
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
                                        <asp:Literal ID="Literal4" runat="server"></asp:Literal></span></span>
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
                    </div>
                </asp:Panel>
             

            </div>
        </div>
    </div>
</div>
<asp:HiddenField ID="currPage" Value="1" runat="server" Visible="false" />
<asp:HiddenField ID="vUrl" Value="1" runat="server" Visible="false" />


