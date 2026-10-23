<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/MenuMain.ascx" TagPrefix="BT" TagName="MenuMain" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/Footer.ascx" TagPrefix="BT" TagName="Footer" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/Sitemap/AutoFeed.ascx" TagPrefix="BT" TagName="AutoFeed" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/FindMode.ascx" TagPrefix="BT" TagName="FindMode" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/Sitemap/cssDefault.ascx" TagPrefix="BT" TagName="cssDefault" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeQcLeft.ascx" TagPrefix="BT" TagName="HomeQcLeft" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeQcRight.ascx" TagPrefix="BT" TagName="HomeQcRight" %>


<link href="/Portals/_default/Resource/font-awesome/css/font-awesome.min.css?v=5.0.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.carousel.min.css?v=5.1.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.theme.default.min.css?v=5.1.0.9" rel="stylesheet" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" >
<link href="https://fonts.googleapis.com/css2?family=Be+Vietnam+Pro:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap" rel="stylesheet">
<BT:cssDefault runat="server" ID="cssDefault" />
<BT:AutoFeed runat="server" ID="AutoFeed" />
<div class="body">
    <div class="home-mainwork">
        <div class="header navbar navbar-static-top bs-docs-nav">
            <BT:MenuMain runat="server" ID="MenuMain" />
        </div>
        <BT:HomeQcLeft runat="server" ID="HomeQcLeft" />
        <div class="clear"></div>
        <BT:HomeQcRight runat="server" ID="HomeQcRight" />
        <div id="ContentPane" runat="server"></div>
        <div class="clear"></div>
        <div class="container">
            <div class="row">
                <div id="CenterPane" runat="server"></div>
                <div class="clear"></div>
            </div>
        </div>
        <div class="clear"></div>
        <div id="FullBottomPane" runat="server"></div>
        <div class="clear"></div>
        <BT:Footer runat="server" ID="Footer" />
    </div>
    <div class="clear"></div>
</div>
<BT:FindMode runat="server" ID="FindMode" />
<script type="text/javascript" src="/js/base64.js?v=6.0.0"></script>
<script src="/js/validation/nicescroll.js?v=5.0.0.9"></script>
<script src="/portals/_default/resource/owlcarousel/owl.carousel.min.js?v=5.0.0.9"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $("#dnn_ctr3611_ContentPane").addClass("none");
        $("#dnn_ctr3627_ContentPane").addClass("none");
        pageLoad();
        var osb5 = $("#owl-HomeBusiness"); osb5.owlCarousel({ autoplay: true, smartSpeed: 550, autoplayTimeout: 3500, nav: false, loop: false, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 6 } } });
        $("#prev-HomeBusiness").click(function () { osb5.trigger("prev.owl.carousel"); });
        $("#next-HomeBusiness").click(function () { osb5.trigger("next.owl.carousel"); });
        var osb1 = $('#owl-slidebanner'); osb1.owlCarousel({ autoplay: true, autoplayTimeout: 4000, nav: false, loop: true, dots: true, pagination: false, slideBy: 1, margin: 15, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-slbanner').click(function () { osb1.trigger('prev.owl.carousel'); }); $('#next-slbanner').click(function () { osb1.trigger('next.owl.carousel'); });
        var osb6 = $('#owl-slidenews'); osb6.owlCarousel({ autoplay: true, autoplayTimeout: 3000, nav: false, loop: true, dots: false, pagination: false, margin: 25, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 3 } } });
        var osb4 = $('#owl-doitac'); osb4.owlCarousel({ autoplay: true, autoplayTimeout: 5500, nav: false, loop: true, dots: true, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 3 }, 1000: { items: 4 } } }); $('#prev-doitac').click(function () { osb4.trigger('prev.owl.carousel'); }); $('#next-doitac').click(function () { osb4.trigger('next.owl.carousel'); });
        //var osb2 = $('#owl-HomeBusiness'); osb2.owlCarousel({ autoplay: true, autoplayTimeout: 3500, nav: false, loop: true, dots:false, pagination: false, responsive: { 0: { items: 2 }, 600: { items: 3 }, 1000: { items: 5 } } }); $('#prev-HomeBusiness').click(function () { osb2.trigger('prev.owl.carousel'); }); $('#next-HomeBusiness').click(function () { osb2.trigger('next.owl.carousel'); });
        var osb3 = $('#owl-HomeBannerTop'); osb3.owlCarousel({ autoplay: true, autoplayTimeout: 4500, nav: false, loop: true, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-HomeBannerTop').click(function () { osb3.trigger('prev.owl.carousel'); }); $('#next-HomeBannerTop').click(function () { osb3.trigger('next.owl.carousel'); });
    });
    //function pageLoad() { $('.selectpicker').selectpicker({ liveSearch: true }); };
    //$(window).scroll(function () {
    //    if ($(this).scrollTop() > 400) {
    //        if (!$('.home-quangcaoroll ').hasClass("nav-up")) { $('.home-quangcaoroll ').addClass("nav-up").fadeInt(); }
    //    } else {
    //        if ($('.home-quangcaoroll ').hasClass("nav-up")) { $('.home-quangcaoroll ').removeClass("nav-up").fadeInt(); }
    //    }
    //});

</script> 