<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Breadcum.ascx.vb" Inherits="Modules.Breadcum.View" %>
<div class="row new-breadcrum">
   <a href="/<%=Me.PortalSettings.ActiveTab.TabName %>"><i class="fa fa-home"></i></a> / Chúc bạn một ngày tốt lành <i title="Bạn không nên ngồi máy tính quá lâu nhé!" class="fa fa-heart"></i>
     <br /><div class="pdt5"><i class="fa fa-clock-o ">&nbsp;</i><span id="clock"></span>,<span><%=DateTime.Now.ToString("dd/MM/yyyy") %></span></div>
      <%--<br /> (e-Portal v<%=EPORTAL.flReg.WebConfig("BuildVersion") %>, build <%=EPORTAL.flReg.WebConfig("BuildDate") %>)--%>
</div>
<script>
    var span = document.getElementById('clock');

    function time() {
        var d = new Date();
        var s = d.getSeconds();
        var m = d.getMinutes();
        var h = d.getHours();
        span.textContent =
            ("0" + h).substr(-2) + ":" + ("0" + m).substr(-2) + ":" + ("0" + s).substr(-2);
    }

    setInterval(time, 1000);
    var elem = document.documentElement;
    function openFullscreen() {
        if (elem.requestFullscreen) {
            elem.requestFullscreen();
        } else if (elem.webkitRequestFullscreen) { /* Safari */
            elem.webkitRequestFullscreen();
        } else if (elem.msRequestFullscreen) { /* IE11 */
            elem.msRequestFullscreen();
        }
    }

</script>