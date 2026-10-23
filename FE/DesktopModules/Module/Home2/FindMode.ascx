<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="FindMode.ascx.vb" Inherits="DesktopModules.Modules.Home.FindMode" %>
<link rel="stylesheet" href="/js/validation/toastr.min.css?v=4.6.0.3.3.0" />
<link rel="stylesheet" href="/js/validation/validationEngine.jquery.css?v=4.6.0.3.3.0" />

<div class="fixed-mobile hidden-lg" runat="server" visible="false">
    <div class="btnTop"><span class="ti-arrow-up"></span></div>
    <div id="pushycontainer">
        <div class="hidden-lg menu-btn"><i class="fa fa-bars f1d6 cc-blwh" style="font-size: 16px; cursor: pointer;"></i></div>
    </div>
    <div style="clear: both;"></div>
    <div class="searchbox-mobile">
        <div class="btn-searchmt">
            <a title="Tìm kiếm" class="searchbox-enter"><i class="fa fa-search search3" aria-hidden="true" style="font-size: 15px"></i></a>
        </div>
        <div class="searchbox-mobile input" id="txt-keysearchmobile">
            <input class="searchbox-mobile textbox text-search3" onkeypress="return clickButton(event,'seach-box3')" id="seach-box3" placeholder="Tìm kiếm">
        </div>
    </div>
</div>

<div id="scroll-top">
    <a href="#top" title="Về đầu trang" class="return-to-top" id="return-to-top"><i class="fa fa-chevron-up"></i></a>
</div>
<script type="text/javascript" src="/js/validation/toastr.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine-vi.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/validation/nicescroll.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/jquery.cookie.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript">
    var an = true; $(function () {
        $(".dbox").remove(); $(".post-content table").each(function (e) { if ($(this).attr("width") == "200") { $(this).removeAttr("width"); } }); $(".search").click(function () { doSearchSite("seach-box"); }); $(".scroll").niceScroll(); $("#seach-box").keydown(function (e) { var c = window.event ? e.keyCode : e.keyCode; return 13 == c ? (doSearchSite("seach-box"), !1) : void 0 }); $("#txt-keysearchmobile").hide(); $(".searchbox-enter").click(function () { if (an == true) { $("#txt-keysearchmobile").show("slide", { direction: "right" }, 300); an = false; } else { $("#txt-keysearchmobile").hide(); an = true; } }); $(".body").click(function () { $("#txt-keysearchmobile").hide("slide", { direction: "right" }, 300); });
        jQuery(function () { jQuery(window).scroll(function () { if (jQuery(this).scrollTop() > 0) { jQuery('#return-to-top').fadeIn(); } else { jQuery('#return-to-top').fadeOut(); } }); jQuery('a#return-to-top').click(function () { jQuery('body,html').animate({ scrollTop: 0 }, 300); return false; }); });
    });
    function clickButton(e, t) { var n = e ? e : window.event; var r = document.getElementById(t); if (r) { if (n.keyCode == 13) { r.click(); return false } } }
    function replace(e) { for (i = 0; i < e.length; i++) { e = e.replace(".", "-1A"); e = e.replace(":", "-2A"); e = e.replace('"', "-3A"); e = e.replace('`', "-4A"); e = e.replace('!', "-5A"); e = e.replace("'", "-6A"); e = e.replace("@", "-1B"); e = e.replace("#", "-2B"); e = e.replace("$", "-3B"); e = e.replace('^', "-4B"); e = e.replace('&', "-5B"); e = e.replace('*', "-6B"); e = e.replace("(", "-1C"); e = e.replace(")", "-2C"); e = e.replace("|", "-3C"); e = e.replace('{', "-4C"); e = e.replace('}', "-5C"); e = e.replace('?', "-6C"); e = e.replace('+', "-7C"); e = e.replace("~", "-1D"); e = e.replace(" ", "-"); e = e.replace("<", "-3D"); e = e.replace('>', "-4D"); e = e.replace('/', "-5D"); e = e.replace("'\'".replace("'", ''), '-6D'); e = e.replace('_', "-2D"); } return e; }
    function doSearchSite(id) { var url = "<%=DotNetNuke.EPORTAL.flReg.UrlAlias %>/tim-kiem"; var e = ""; var link = window.location.href; e = $("#" + id).val().trim(), e = replace(e), "" != e.toString() && (window.location.href = url + "/q/" + encodeURI(e)) };
    $(".an1cai").click(function () { if ($(".personalBarContainer").hasClass("andi")) { $(".personalBarContainer").removeClass("andi"); $("#Body").attr("style", "margin-left:60px!important;"); } else { $(".personalBarContainer").addClass("andi"); $("#Body").removeAttr("style"); } $(".personalBarContainer").removeAttr("style"); }); $(".personalBarContainer").addClass("andi"); function changeUrl(newUrl) { window.history.pushState('', document.title, newUrl); };
    function pageLoad() { $(".scroll").niceScroll(); $("#Form").validationEngine({ prettySelect: true }); }; $(document).ready(function () { pageLoad(); });
</script>
