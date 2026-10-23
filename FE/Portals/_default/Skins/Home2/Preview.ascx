<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/Preview/Preview.ascx" TagPrefix="uc1" TagName="Preview" %>
<%@ Register Src="~/DesktopModules/Module/Sitemap/cssDefault.ascx" TagPrefix="FindMode" TagName="cssDefault" %>

<link href="/Portals/_default/Resource/font-awesome/css/font-awesome.min.css?v=5.0.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.carousel.min.css?v=5.1.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.theme.default.min.css?v=5.1.0.9" rel="stylesheet" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
<FindMode:cssDefault runat="server" ID="cssDefault" />
<div class="body Preview">
    <div id="ContentPane" runat="server" class="popupPane"></div>
    <uc1:Preview runat="server" ID="Preview" />
</div>
<div id="scroll-top">
    <a href="#top" title="Về đầu trang" class="return-to-top" id="return-to-top"><i class="fa fa-chevron-up"></i></a>
</div>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript">
    function CloseMySelf(sender) { window.close(); return false; };
    jQuery(document).ready(function () {
        $(".personalBarContainer").addClass("andi"); $('.selectpicker').selectpicker({ liveSearch: true });
        jQuery(function () {
            jQuery(window).scroll(function () { if (jQuery(this).scrollTop() > 0) { jQuery('#scroll-top').fadeIn(); } else { jQuery('#scroll-top').fadeOut(); } });
            jQuery('#scroll-top a').click(function () { jQuery('body,html').animate({ scrollTop: 0 }, 300); return false; });
        });
    });
    (function (e, t, n) { var r, i = e.getElementsByTagName(t)[0]; if (e.getElementById(n)) return; r = e.createElement(t); r.id = n; r.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1"; i.parentNode.insertBefore(r, i) })(document, "script", "facebook-jssdk")
    window.___gcfg = { lang: "vi" }; (function () { var e = document.createElement("script"); e.type = "text/javascript"; e.async = true; e.src = "https://apis.google.com/js/platform.js"; var t = document.getElementsByTagName("script")[0]; t.parentNode.insertBefore(e, t) })()
</script>
