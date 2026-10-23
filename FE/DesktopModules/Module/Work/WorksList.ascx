<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="WorksList.ascx.vb" Inherits="DesktopModules.Modules.Work.WorksList" %>
<div class="box_list_works">
    <asp:Literal ID="litHot" runat="server"></asp:Literal>
    <asp:Literal ID="litVal" runat="server"></asp:Literal>
</div>
<asp:HiddenField ID="currPage" Value="1" runat="server" Visible="false" />
<asp:HiddenField ID="CareerID" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="TinhTP" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="EducationID" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="JobPlaceID" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="SalaryID" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="Experienceid" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="Genner" Value="-1" runat="server" Visible="false" />
<asp:HiddenField ID="SearchID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="Title" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="CareerName" Value="" runat="server" Visible="false" />
<asp:HiddenField ID="vUrl" Value="" runat="server" Visible="false" />

