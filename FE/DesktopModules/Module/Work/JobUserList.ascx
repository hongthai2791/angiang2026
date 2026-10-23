<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="JobUserList.ascx.vb" Inherits="DesktopModules.Modules.Work.WorksList" %>
<div class="box_list_works">
    <div class="home-jobuser">
        <asp:Literal ID="litVal" runat="server"></asp:Literal>
    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="SearchID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="CareerID" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="SalaryID" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="TinhTP" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="ExperienceId" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="CareerCode" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="CareerName" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="vUrl" runat="server" Visible="false" />
<asp:HiddenField ID="Title" Value="" runat="server" Visible="false" />
