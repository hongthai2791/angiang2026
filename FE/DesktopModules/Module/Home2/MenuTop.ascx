<%@ Control Language="vb" EnableViewState="false" Inherits="DesktopModules.Modules.Home.MenuTop" CodeFile="MenuTop.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="menu-top">
    <ul class="menu-top-home">
        <li><a href="<%=EPORTAL.flReg.UrlAlias  %>"><i class="fa fa-home" aria-hidden="true" style="color: #333;"></i></a></li>
        <asp:Literal ID="litMenu" runat="server"></asp:Literal>
    </ul>
    <div class="clear"></div>
    <div class="div-box">
        <div class="search-box">
            <div class="form-group">
                <input type="text" class="form-control" id="seach-box" placeholder="Tìm kiếm">
                <div class="btn-search"><a title="Tìm kiếm"><i class="fa fa-search" style="font-size: 16px; color: #fff;"></i></a></div>
            </div>
        </div>
    </div>
</div>
