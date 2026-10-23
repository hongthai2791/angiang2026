<%@ Control Language="vb" EnableViewState="false" Inherits="DesktopModules.Modules.Home.MenuHome" CodeFile="MenuHome.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="hidden-sm hidden-xs">
    <div class="main-menu flex">
        <ul>
            <asp:Literal ID="litMenu" runat="server"></asp:Literal>
            <li class="recruit">
                <a class="for-bus btn" href="<%=EPORTAL.flReg.WebConfig("member") %>" title='Dành cho người tìm việc'>
                    <p class='name-recruit'><i class="fa fa-plus-circle"></i> ĐĂNG TIN</p>
                </a>
                <%--<a  class="for-bus" href="<%=EPORTAL.flReg.WebConfig("member") %>" title='Giành cho nhà tuyển dụng'>
                    <p class='name-recruit'>Nhà tuyển dụng</p>
                </a>--%>

            </li>
        </ul>

    </div>
</div>
