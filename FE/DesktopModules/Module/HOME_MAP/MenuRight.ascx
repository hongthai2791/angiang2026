<%@ Control Language="vb" EnableViewState="false" Inherits="DesktopModules.Modules.Home.MenuRight" CodeFile="MenuRight.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<style>
    
.shadow {
    box-shadow: 0 12px 24px rgba(0, 0, 0, 0.1) !important;
}
.bg-white {
    background-color: #fff;
}
.pd10 {
    padding: 10px;
}
    .menu-right {
        height:290px;
        overflow:auto;
        background-color: #2A80B9
    }
        .menu-right a, .menu-right i {
            color: #fff;
        }

        .menu-right ul li {
            list-style:none;
            padding: 5px 0
        }
</style>
<div class="menu-right flex career-box shadow bg-white pd10 ">
    <ul>

        <asp:Literal ID="litMenu" runat="server"></asp:Literal>

    </ul>
</div>


