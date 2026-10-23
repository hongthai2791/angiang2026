<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Header.ascx.vb" Inherits="Modules.Main.View" %>
<a id="ctlView" runat="server" class="an1cai sidebar-toggle ctlview">
    <i class="fa fa-chevron-right" aria-hidden="true"></i>
</a>
<style>
    li.top-system > ul {
        margin-left: 10px
    }
</style>
<header class="main-header hidden-print">
    <a href="/<%=_tabName %>" title="Bàn làm việc" class="logo">
        <span class="logo-mini"><%=_tabName.ToUpper() %></span>
        <span class="logo-lg">
         <img src="/image/icon/logo-<%=_tabName %>.png?v=2.0" alt="logo" /> &nbsp; <%=_tabName.ToUpper() %> Admin
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
        <a class="logo system-name"><%=_SystemName %> </a>
        <%--<a style="color: #fff;" title="Bạn không nên ngồi máy tính quá lâu"><i class="fa fa-clock-o nut-homehd"></i><span id="clock"></span>,<span><%=DateTime.Now.ToString("dd/MM/yyyy") %></a></span>--%>
    </nav>
    <div class="clear"></div>
</header>

<script type="text/javascript">
    function ariaexpan(t) { if ($(t).hasClass("unnone")) { $(t).removeClass("unnone"); $(t).addClass("donone"); $("#ariaUser").removeClass("none"); $(".gbUser").removeClass("none"); } else { $(t).removeClass("donone"); $(t).addClass("unnone"); $("#ariaUser").addClass("none"); $(".gbUser").addClass("none"); } }

    var span = document.getElementById('clock');

    //function time() {
    //    var d = new Date();
    //    var s = d.getSeconds();
    //    var m = d.getMinutes();
    //    var h = d.getHours();
    //    span.textContent =
    //        ("0" + h).substr(-2) + ":" + ("0" + m).substr(-2) + ":" + ("0" + s).substr(-2);
    //}

    //setInterval(time, 1000);
    //var elem = document.documentElement;
    //function openFullscreen() {
    //    if (elem.requestFullscreen) {
    //        elem.requestFullscreen();
    //    } else if (elem.webkitRequestFullscreen) { /* Safari */
    //        elem.webkitRequestFullscreen();
    //    } else if (elem.msRequestFullscreen) { /* IE11 */
    //        elem.msRequestFullscreen();
    //    }
    //}

    /* Close fullscreen */
    function closeFullscreen() {
        if (document.exitFullscreen) {
            document.exitFullscreen();
        } else if (document.webkitExitFullscreen) { /* Safari */
            document.webkitExitFullscreen();
        } else if (document.msExitFullscreen) { /* IE11 */
            document.msExitFullscreen();
        }
    }
</script>
<asp:Panel ID="Pnview" runat="server" Visible="false">
    <script src="/Resources/libraries/jQuery/03_02_01/jquery.js?cdv=51" type="text/javascript"></script>
    <script src="/Resources/libraries/jQuery-UI/01_12_01/jquery-ui.js?cdv=51" type="text/javascript"></script>
    <script src="/Resources/Shared/Scripts/dnn.jquery.js?cdv=51" type="text/javascript"></script>
</asp:Panel>
