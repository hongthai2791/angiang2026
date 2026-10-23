<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="ThietLapEdit.ascx.vb" Inherits="DesktopModules.Modules.Reports.Reports1" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-sm-12">
            <h3 class="box-title">Thông tin kỳ cập nhật khai báo Cầu lao động</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 col-xs-6 lb txt-center">Tỉnh/ thành phố</div>
                <div class="col-md-4 col-xs-6">
                    <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker validate[required]" />
                </div>
                <div class="col-md-2 col-xs-6 lb txt-center">Năm nhập thông báo</div>
                <div class="col-md-2 col-xs-6">
                    <asp:DropDownList ID="Years_ID" runat="server" CssClass="selectpicker validate[required]" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 col-xs-6 lb txt-center">Yêu cầu cập nhật từ</div>
                <div class="col-md-4 col-xs-6">
                    <div class="rccalpopup">
                        <asp:TextBox ID="FromDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                    </div>
                </div>
                <div class="col-md-2 col-xs-6 lb txt-center">Đến hết ngày</div>
                <div class="col-md-4 col-xs-6">
                    <div class="rccalpopup">
                        <asp:TextBox ID="ToDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 col-xs-6 lb txt-center">Kích hoạt sử dụng</div>
                <div class="col-md-4 col-xs-6 pdt5">
                    <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
                </div>
                <div class="col-md-2 col-xs-6 lb txt-center">Khóa kỳ nhập liệu</div>
                <div class="col-md-4 col-xs-6 pdt5">
                    <asp:CheckBox ID="IsLock" CssClass="CheckBox" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 lb txt-center">Nội dung thông báo</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Contents" CssClass="TextBox validate[required]" TextMode="MultiLine" Height="170" runat="server" />
                </div>
            </div>
            <div class="row none">
                <div class="col-md-12 ">
                    <div class="panel panel-warning" style="color: #e8e8e8!important; font-size: 16px; font-weight: 500; background: #584040; padding: 10px!important;">
                        <i class="fa fa-exclamation-triangle" aria-hidden="true"></i>&nbsp; 
                        Lưu ý: Khi tạo kỳ cập nhật mới cho Doanh nghiệp khai báo Cầu lao động, bạn cần thực hiện theo các bước sau đây<br />
                        Bước 1: Nhập đầy đủ thông tin kỳ cập nhật để yêu cầu doanh nghiệp khai báo.<br />
                        Bước 2: Bấm nút chức năng <b style="color:yellow">Lưu lại</b>.<br />
                        Bước 3: Bấm nút chức năng <b style="color:yellow">Đồng bộ dữ liệu</b> để chuyển tất cả dữ liệu doanh nghiệp khai báo kỳ trước sang kỳ khởi tạo.
                    </div>
                </div>
            </div>
            <div class="row">
                <asp:Literal ID="litUpdate" runat="server"></asp:Literal>
            </div>
            <asp:HiddenField ID="ItemID" runat="server" Visible="false" />
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" OnClientClick=" return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdRefresh" Visible="false" runat="server" Text="Đồng bộ dữ liệu" CssClass="cmsbut Refresh" OnClientClick="retunwaiting()" />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmdDel cbclick" />

    </div>
</div>


