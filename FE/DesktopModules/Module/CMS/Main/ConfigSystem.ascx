<%@ Control Language="vb" CodeFile="ConfigSystem.ascx.vb" Inherits="Modules.ConfigSystem.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border pdbt0">
                <div class="col-md-6">
                    <h3 class="box-title">Thiết lập cấu hình hệ thống</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-9 pdr0 pdl0">
                        <div class="row">
                            <div class="col-md-2 b pdt5">Chọn phân hệ</div>
                            <div class="col-md-10">
                                <asp:DropDownList ID="ddlPortal" runat="server" AutoPostBack="true" CssClass="selectpicker validate[required]" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-2 b pdt5">Kích hoạt sử dụng</div>
                            <div class="col-md-4 pdl0">
                                <asp:CheckBox ID="IsLive" runat="server" CssClass="CheckBox b" Text="Sự kiện tường thuật trực tiếp?" />
                            </div>
                            <div class="col-md-4 pdl0">
                                <asp:CheckBox ID="IsCMS" runat="server" CssClass="CheckBox b red" Text="Sử dụng giao diện Quốc tang?" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-2 b pdt5">Link tường thuật</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="LiveUrl" runat="server" CssClass="TextBox" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-2 b pdt5">Tiêu đề tường thuật</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="LiveTitle" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="50" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-2 b pdt5">Nội dung tường thuật</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="LiveDes" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="120" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="row">
                            <div class="col-md-2 b pdt5">Tường thuật từ</div>
                            <div class="col-md-2">
                                <div class="rccalpopup date-pub">
                                    <asp:TextBox ID="StartDate" runat="server" CssClass="timepicker" />
                                </div>
                            </div>
                            <div class="col-md-2 b pdt5 txt-right">Đến ngày</div>
                            <div class="col-md-2">
                                <div class="rccalpopup date-pub">
                                    <asp:TextBox ID="EndDate" runat="server" CssClass="timepicker" />
                                </div>
                            </div>
                            <div class="col-md-2 b pdt5 txt-right">Tạo sitemap</div>
                            <div class="col-md-2">
                                <asp:TextBox ID="SiteMap" runat="server" CssClass="TextBox" Text="7,9,11,14,15,19,21" />
                            </div>
                            <div class="clear"></div>
                        </div>
                         <div class="row">
                            <div class="col-md-2 b pdt5">ID Google Analytics</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="Analytics" runat="server" CssClass="TextBox" />
                            </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                    <div class="col-md-3 pdr0 pdl0">
                        <div class="row">
                            <div class="col-md-12 b red pd5">Địa chỉ IP đăng nhập</div>
                            <div class="col-md-12">
                                <asp:TextBox ID="IpPublic" runat="server" CssClass="TextBox ip-text" Text="127.0.0.1" TextMode="MultiLine" Height="350" />
                            </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                </div>
            </div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick" OnClientClick="setMul()" />
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
        <asp:AsyncPostBackTrigger ControlID="ddlPortal" />
    </Triggers>
</asp:UpdatePanel>
