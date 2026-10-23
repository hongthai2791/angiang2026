<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeSlider.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeSlider" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/SearchAdv.ascx" TagPrefix="uc1" TagName="SearchAdv" %>

<div class="home-view">
    <%--<uc1:SearchAdv runat="server" ID="SearchAdv" />--%>
    <div class="box-div homeslide">
        <asp:Literal ID="litSlide" runat="server" />
    </div>
    <div class="clear"></div>
</div>
