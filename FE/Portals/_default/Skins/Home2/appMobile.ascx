<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/News/ReadApp.ascx" TagPrefix="BT" TagName="ReadApp" %>

<link href="/Portals/_default/Resource/font-awesome/css/font-awesome.min.css?v=5.0.0.9" rel="stylesheet" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/vi.css?v=4.6.0.3.3.0" />
<div class="body default">
    <div class="container">
        <div id="ContentPane" runat="server">
            <BT:ReadApp runat="server" ID="ReadApp" />
        </div>
    </div>
</div>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript">
    $(function () { $(".post-content table").each(function (e) { if ($(this).attr("width") == "200") { $(this).removeAttr("width"); } }); $(".search").click(function () { doSearchSite("seach-box"); }); $(".scroll").niceScroll(); $("#seach-box").keydown(function (e) { var c = window.event ? e.keyCode : e.keyCode; return 13 == c ? (doSearchSite("seach-box"), !1) : void 0 }); jQuery(function () { jQuery(window).scroll(function () { if (jQuery(this).scrollTop() > 0) { jQuery('#return-to-top').fadeIn(); } else { jQuery('#return-to-top').fadeOut(); } }); jQuery('a#return-to-top').click(function () { jQuery('body,html').animate({ scrollTop: 0 }, 300); return false; }); }); });
    function clickButton(e, t) { var n = e ? e : window.event; var r = document.getElementById(t); if (r) { if (n.keyCode == 13) { r.click(); return false } } }
    function replace(e) { for (i = 0; i < e.length; i++) { e = e.replace(".", "-1A"); e = e.replace(":", "-2A"); e = e.replace('"', "-3A"); e = e.replace('`', "-4A"); e = e.replace('!', "-5A"); e = e.replace("'", "-6A"); e = e.replace("@", "-1B"); e = e.replace("#", "-2B"); e = e.replace("$", "-3B"); e = e.replace('^', "-4B"); e = e.replace('&', "-5B"); e = e.replace('*', "-6B"); e = e.replace("(", "-1C"); e = e.replace(")", "-2C"); e = e.replace("|", "-3C"); e = e.replace('{', "-4C"); e = e.replace('}', "-5C"); e = e.replace('?', "-6C"); e = e.replace('+', "-7C"); e = e.replace("~", "-1D"); e = e.replace(" ", "-"); e = e.replace("<", "-3D"); e = e.replace('>', "-4D"); e = e.replace('/', "-5D"); e = e.replace("'\'".replace("'", ''), '-6D'); e = e.replace('_', "-2D"); } return e; }
    $(".an1cai").click(function () { if ($(".personalBarContainer").hasClass("andi")) { $(".personalBarContainer").removeClass("andi"); $("#Body").attr("style", "margin-left:60px!important;"); } else { $(".personalBarContainer").addClass("andi"); $("#Body").removeAttr("style"); } $(".personalBarContainer").removeAttr("style"); }); $(".personalBarContainer").addClass("andi"); function changeUrl(newUrl) { window.history.pushState('', document.title, newUrl); };
</script>
