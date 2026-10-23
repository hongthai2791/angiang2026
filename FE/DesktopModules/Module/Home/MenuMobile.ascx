<%@ Control Language="vb" EnableViewState="false" Inherits="DesktopModules.Modules.Home.MenuMobile" CodeFile="MenuMobile.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div id="pushplaceholder" style="display: none;">
    <span class="close-menu" style="display: none" id="closeMobileMenu" onclick="return closemenu();"><i class="fa fa-times" aria-hidden="true"></i></span>
    <nav class="pushy pushy-left">
        <ul>
            <li>
                <a href="<%# EPORTAL.flReg.UrlAlias%>">Trang chủ</a>
            </li>
            <asp:Literal ID="litMenu" runat="server"></asp:Literal>
        </ul>
    </nav>
    <div class="site-overlay"></div>
    <div id="pushycontainer">
        <div class="menu-btn">
            <i class="fa fa-bars f1d6 cc-blwh"></i>
        </div>
    </div>
</div>
<script type="text/javascript">
    $(function () {
        function e() { o.toggleClass(f), s.toggleClass(i), a.toggleClass(c), r.toggleClass(m) }; function t() { o.addClass(f), s.animate({ left: "0px" }, p), a.animate({ left: d }, p), r.animate({ left: d }, p) };
        function n() { o.removeClass(f), s.animate({ left: "-" + d }, p), a.animate({ left: "0px" }, p), r.animate({ left: "0px" }, p) };
        var s = $(".pushy"), o = $("body"), a = $("#pushycontainer"), r = $(".push"), l = $(".site-overlay"), i = "pushy-left pushy-open", f = "pushy-active", c = "container-push", m = "push-push", u = $(".menu-btn, .pushy a, #pushycontainerDesktop"), p = 200, d = s.width() + "px";
        if (cssTransforms3d = function () {
            var e = document.createElement("p"), t = !1, n = { webkitTransform: "-webkit-transform", OTransform: "-o-transform", msTransform: "-ms-transform", MozTransform: "-moz-transform", transform: "transform" };
            document.body.insertBefore(e, null); for (var s in n) void 0 !== e.style[s] && (e.style[s] = "translate3d(1px,1px,1px)", t = window.getComputedStyle(e).getPropertyValue(n[s]));
            return document.body.removeChild(e), void 0 !== t && t.length > 0 && "none" !== t
        }(), $("#pushplaceholder").css({ display: "inline-block", "float": "right" }), cssTransforms3d) u.click(function () { e() }), l.click(function () { e() });
        else { s.css({ left: "-" + d }), a.css({ "overflow-x": "hidden" }); var h = !0; u.click(function () { h ? (t(), h = !1) : (n(), h = !0) }), l.click(function () { h ? (t(), h = !1) : (n(), h = !0) }) }
    });
    function closemenu() { $('.pushy.pushy-open').removeClass("pushy-open").addClass("pushy-left"); $("#Body").removeClass("pushy-active"); };
</script>
