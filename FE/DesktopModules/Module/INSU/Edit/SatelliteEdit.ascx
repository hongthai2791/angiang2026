<%@ Control Language="vb" CodeFile="SatelliteEdit.ascx.vb" Inherits="Modules.Satellite.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <h3 class="box-title">Thông tin danh mục vệ tinh</h3>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 b pdt5">Đơn vị sử dụng</div>
            <div class="col-md-10">
                <asp:DropDownList ID="drPortal" runat="server" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Mã danh mục</div>
            <div class="col-md-2">
                <asp:TextBox ID="Satellite_Code" runat="server" CssClass="TextBox b txt-center ReadOnly validate[required]" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Tên danh mục</div>
            <div class="col-md-10">
                <asp:TextBox ID="Satellite_Name" runat="server" CssClass="TextBox validate[required]" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Tỉnh/ thành phố</div>
            <div class="col-md-10">
                <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="col-md-2 b pdt5">Địa chỉ</div>
            <div class="col-md-10">
                <asp:TextBox ID="Satellite_Address" runat="server" CssClass="TextBox"></asp:TextBox>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Điện thoại</div>
            <div class="col-md-10">
                <asp:TextBox ID="Satellite_Tel" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
            </div>
            <div class="col-md-2 b pdt5">Sử dụng? </div>
            <div class="col-md-10">
                <asp:CheckBox ID="Satellite_IsActive" CssClass="CheckBox" runat="server" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Thứ tự</div>
            <div class="col-md-1">
                <asp:TextBox ID="Satellite_IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
            </div>
            <div class="clear"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return $('#Form').validationEngine('validate');" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');"/>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
</div>
