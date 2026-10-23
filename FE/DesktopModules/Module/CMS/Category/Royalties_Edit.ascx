<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Royalties_Edit.ascx.vb" Inherits="DesktopModules.DanhMuc.PhongBan.inc_Edit" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THÔNG TIN ĐỊNH MỨC NHUẬN BÚT</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-sm-6">
                <div class="col-md-4 b pdt5">Chọn phân hệ</div>
                <div class="col-md-8">
                    <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-4 b ">Loại định mức</div>
                <div class="col-md-8">
                    <asp:DropDownList ID="drType" CssClass="selectpicker validate[required]" runat="server"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-4 b">Mã định mức</div>
                <div class="col-md-8">
                    <asp:TextBox CssClass="TextBox validate[required]" ID="txtMaDM" runat="server"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-4 b ">Hệ số nhân</div>
                <div class="col-md-8">
                    <asp:TextBox CssClass="TextBox validate[required]" ID="txtHeSo" Text="1" runat="server"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-4 b">Nhuận bút (VNĐ)</div>
                <div class="col-md-8">
                    <asp:TextBox CssClass="TextBox validate[required]" ID="txtDonGia" runat="server"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-4 b">Tháng chấm</div>
                <div class="col-md-8">
                    <asp:DropDownList ID="drMonth" CssClass="selectpicker" runat="server"></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-4 b">Năm chấm</div>
                <div class="col-md-8">
                    <asp:DropDownList ID="drYear" CssClass="selectpicker" runat="server"></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-4 b pdt5">Thứ tự</div>
                <div class="col-md-2">
                    <asp:TextBox CssClass="TextBox validate[required custom[integer]]" ID="txtOrder" runat="server"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-4 b pdt5">Sử dụng</div>
                <div class="col-md-8 pdl0">
                    <asp:CheckBox ID="ckActive" CssClass="checkbox" Checked="true" Text="Sử dụng?" runat="server"></asp:CheckBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="col-sm-6">
                <div class="col-md-3 b pdt5">Mô tả nội dung</div>
                <div class="col-md-9">
                    <asp:TextBox CssClass="TextBox" ID="txtMoTa" TextMode="MultiLine" Height="285px" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <asp:HiddenField ID="ItemID" runat="server" />
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdDelete" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" />
        <asp:Button ID="cmdCancel" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
