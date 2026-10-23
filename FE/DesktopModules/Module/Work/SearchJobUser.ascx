<%@ Control Language="VB" AutoEventWireup="false" CodeFile="SearchJobUser.ascx.vb" Inherits="DesktopModules.Modules.Work.SearchJobUser" %>
<div class="box-search-job">
    <div class="col-md-12">
        <asp:TextBox ID="txtSearch" runat="server" CssClass="TextBox" placeHolder="Nhập từ khóa"></asp:TextBox>
    </div>
    <div class="col-md-12 ViTri">
        <asp:DropDownList ID="ChucVu" runat="server" CssClass="selectpicker"></asp:DropDownList>
    </div>
    <div class="col-md-12 NganhNghe">
        <asp:DropDownList ID="NganhNghe" runat="server" CssClass="selectpicker"></asp:DropDownList>
    </div>
    <div class="col-md-12 TinhTP">
        <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" Width="80px"></asp:DropDownList>
    </div>
    <div class="col-md-12 MucLuong">
        <asp:DropDownList ID="MucLuong" runat="server" CssClass="selectpicker"></asp:DropDownList>
    </div>
    <div class="col-md-12 TrinhDo">
        <asp:DropDownList ID="TrinhDo" runat="server" CssClass="selectpicker"></asp:DropDownList>
    </div>
    <div class="col-md-12 KinhNghiem">
        <asp:DropDownList ID="KinhNghiem" runat="server" CssClass="selectpicker"></asp:DropDownList>
    </div>
    <div class="col-md-12">
        <asp:Button ID="cmdSearch" runat="server" CssClass="cmdsearch" Text="Tìm kiếm ứng viên"></asp:Button>
    </div>
    <div class="clear"></div>
</div>
