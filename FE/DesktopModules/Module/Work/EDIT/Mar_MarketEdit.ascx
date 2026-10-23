<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Mar_MarketEdit.ascx.vb" Inherits="Modules.Market.Work.Edit" %>

<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin phiên giao dịch việc làm</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 b pdt5">Thời gian bắt đầu</div>
                <div class="col-md-4">
                    <div class="rccalpopup">
                        <asp:TextBox ID="txtBatDau" Placeholder="dd/mm/yyyy hh:mm" CssClass="timepicker TextBox validate[required]" runat="server" />
                    </div>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 txt-right pdt5">Thời gian kết thúc</div>
                <div class="col-md-4">
                    <div class="rccalpopup">
                        <asp:TextBox ID="txtKetThuc" Placeholder="dd/mm/yyyy hh:mm" CssClass="timepicker TextBox validate[required]" runat="server" />
                    </div>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 b pdt5">Tên phiên giao dịch</div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtPhien" CssClass="TextBox validate[required]" TextMode="MultiLine" Height="50px"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 b pdt5">Địa điểm diễn ra </div>
                <div class="col-md-2">
                    <asp:DropDownList runat="server" ID="TinhTP" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-8">
                    <asp:TextBox runat="server" ID="txtDiaDiem" placeHolder="Địa điểm diễn ra phiên giao dịch việc làm" CssClass="TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 b pdt5">Loại phiên giao dịch </div>
                <div class="col-md-4">
                    <asp:DropDownList runat="server" ID="ddlLoaiSan" CssClass="selectpicker validate[required]">
                        <asp:ListItem Text="- - - Chọn - - -" Value=""></asp:ListItem>
                        <asp:ListItem Text="Phiên di động" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Phiên cố Định" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 txt-right">Số điện thoại hotline </div>
                <div class="col-md-4">
                    <asp:TextBox runat="server" ID="txtHotLine" CssClass="TextBox "></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2">Duyệt sử dụng? </div>
                <div class="col-md-10">
                    <asp:CheckBox runat="server" ID="chkOnline" CssClass="CheckBox" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 b pdt5">Nội dung chi tiết</div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtChiTiet" CssClass="TextBox " TextMode="MultiLine" Height="180px"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="clr clUp"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Cập nhật" CssClass="cmsbut cmsbtrun" OnClientClick="return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');"/>
        <div class="clr"></div>
    </div>
</div>
<asp:HiddenField runat="server" ID="ItemID" Visible="false" Value="" />

