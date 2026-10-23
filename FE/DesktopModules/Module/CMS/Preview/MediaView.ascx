<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="MediaView.ascx.vb" Inherits="DesktopModules.Media.Manager.Media_View" %>
<%@ Register TagPrefix="TN" Namespace="TNControls" Assembly="VideoPlayer" %>
<%= strCssCn %>
<div id="vlistplay" runat="server" class="vlistplay">
    <div class="box-video-player">
        <div style="width: 600px; margin: 0px auto">
            <TN:VideoPlayer ID="_PlayVideo" runat="server" Skin="glow" Width="100%"></TN:VideoPlayer>
        </div>
        <asp:Literal ID="litVideoPlay" runat="server"></asp:Literal>
    </div>
</div>

 