<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Header.ascx.vb" Inherits="Modules.Main.View" %>
<a id="ctlView" runat="server" class="an1cai sidebar-toggle ctlview">
    <i class="fa fa-chevron-right" aria-hidden="true"></i>
</a>
<header class="main-header hidden-print">
    <a href="/<%=_tabName %>" title="Bàn làm việc" class="logo">
        <span class="logo-mini">  <%=_tabName.ToUpper() %></span>
        <span class="logo-lg">
            <img src="/image/icon/logo-<%=_tabName %>.png?v=2.1" alt="logo" />
        </span>
    </a>
    <nav class="navbar navbar-static-top" role="navigation">
        <a href="/#" class="sidebar-toggle" data-toggle="offcanvas" role="button">
            <span class="sr-only">Menu</span>
        </a>
        <div class="navbar-custom-menu">
            <asp:Literal ID="litU" runat="server" />
        </div>
        <div class="main-menu">
            <asp:Literal ID="litMenu" runat="server" />
        </div>
    </nav>
    <div class="clear"></div>
</header>

<script type="text/javascript">
    function ariaexpan(t) { if ($(t).hasClass("unnone")) { $(t).removeClass("unnone"); $(t).addClass("donone"); $("#ariaUser").removeClass("none"); $(".gbUser").removeClass("none"); } else { $(t).removeClass("donone"); $(t).addClass("unnone"); $("#ariaUser").addClass("none"); $(".gbUser").addClass("none"); } }
</script>
<asp:Panel ID="Pnview" runat="server" Visible="false">
    <script src="/Resources/libraries/jQuery/03_02_01/jquery.js?cdv=51" type="text/javascript"></script>
    <script src="/Resources/libraries/jQuery-UI/01_12_01/jquery-ui.js?cdv=51" type="text/javascript"></script>
    <script src="/Resources/Shared/Scripts/dnn.jquery.js?cdv=51" type="text/javascript"></script>
</asp:Panel>

<asp:Panel ID="pnFile" runat="server" Visible="false">
    <script src="/Resources/Shared/Scripts/jquery/jquery.fileupload.js?cdv=51" type="text/javascript"></script>
    <script src="/Resources/Shared/Components/FileUpload/dnn.FileUpload.js?cdv=51" type="text/javascript"></script>
</asp:Panel>
