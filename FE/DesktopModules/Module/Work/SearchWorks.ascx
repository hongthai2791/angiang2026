<%@ Control Language="VB" AutoEventWireup="false" CodeFile="SearchWorks.ascx.vb" Inherits="DesktopModules.Modules.Work.SearchWorks" %>
<div class="box-search-job search-work">
    <div class="col-md-12">
        <asp:TextBox ID="txtSearch" runat="server" CssClass="TextBox" placeHolder="Nhập từ khóa"></asp:TextBox>
    </div>
    <div class="col-md-12 ViTri">
        <asp:DropDownList ID="ViTri" runat="server" CssClass="selectpicker"></asp:DropDownList>
    </div>
    <div class="col-md-12 NganhNghe">
        <asp:DropDownList ID="NganhNghe" runat="server" CssClass="selectpicker"></asp:DropDownList>
    </div>
    <div class="col-md-12 TinhTP">
        <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker"></asp:DropDownList>
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
    <div class="col-md-12 GioiTinh">
        <asp:DropDownList ID="GioiTinh" runat="server" CssClass="selectpicker"></asp:DropDownList>
    </div>
    <div class="col-md-12 pdbt0">
        <asp:LinkButton ID="cmdSearch" runat="server" CssClass="cmdsearch swork lksearch" Text="Tìm kiếm việc làm"></asp:LinkButton>
        <%--<asp:Button ID="cmdSearch" runat="server" CssClass="cmdsearch swork" Text="Tìm kiếm việc làm"></asp:Button>--%>
    </div>
    <div class="clear"></div>
</div>
