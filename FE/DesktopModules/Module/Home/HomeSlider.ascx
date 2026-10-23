<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeSlider.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeSlider" %>
<style>
    
.New-tt {
    color: red;
    background-color: yellow;
    padding: 5px 8px;
    border-radius: 3px;
    font-size:11px
}
</style>
<%--<%@ Register Src="~/DesktopModules/Module/Home/SearchAdv.ascx" TagPrefix="uc1" TagName="SearchAdv" %>--%>
<div class="home-view">
    <%--<uc1:SearchAdv runat="server" ID="SearchAdv" />--%>
    <div class="box-div homeslide">
        <asp:Literal ID="litSlide" runat="server" />
    </div>
    
<div class=" row  mar-news">
        <asp:Literal ID="litNew" runat="server"></asp:Literal>
</div>
    <div class="clear"></div>
</div>
