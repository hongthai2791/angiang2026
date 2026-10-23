<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Main.ascx.vb" Inherits="DotNetNuke.Modules.Main" %>
<asp:PlaceHolder ID="plControl" runat="server"></asp:PlaceHolder>
<div class="clear" id="lbm" runat="server"></div>
<asp:Button ID="cmdSetting" CssClass="bt-vb-settings" runat="server" Text="Settings" Visible="false" />
<style>.bt-vb-settings:hover {opacity:1;background-color:#f135f8;color:#fff}.bt-vb-settings {z-index:99;opacity:0.1; background: rgba(227, 242, 247, 0.35) url(/desktopmodules/module/addmodule/settings.png?w) 5px no-repeat;border: 0 !important;height: 26px;padding: 4px;padding-left: 26px;top: 3px;left: 3px;position: absolute;}</style>
