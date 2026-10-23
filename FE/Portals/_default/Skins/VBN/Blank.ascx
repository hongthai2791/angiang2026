<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/Home/MenuMain.ascx" TagPrefix="BT" TagName="MenuMain" %>
<%@ Register Src="~/DesktopModules/Module/Home/Footer.ascx" TagPrefix="BT" TagName="Footer" %>
<%@ Register Src="~/DesktopModules/Module/Home/FindMode.ascx" TagPrefix="BT" TagName="FindMode" %>
<%@ Register Src="~/DesktopModules/Module/Sitemap/cssDefault.ascx" TagPrefix="BT" TagName="cssDefault" %>
<%@ Register Src="~/DesktopModules/Module/Home/BreadCrumb.ascx" TagPrefix="BT" TagName="BreadCrumb" %>
<%@ Register Src="~/DesktopModules/Member/Security/Login.ascx" TagPrefix="BT" TagName="Login" %>


<link href="/Portals/_default/Resource/font-awesome/css/font-awesome.min.css?v=5.0.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.carousel.min.css?v=5.1.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.theme.default.min.css?v=5.1.0.9" rel="stylesheet" />
<link rel="stylesheet" href="/js/validation/validationEngine.jquery.css?v=1.0.1" />
<link rel="stylesheet" href="/js/validation/toastr.min.css?v=6.0.0" />
<link rel="stylesheet" href="/js/datetime/datetimepicker.css?v=6.0.0" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
<BT:cssDefault runat="server" ID="cssDefault" />
<div class="body default">
    <div class="hidden-login">
        <div class="header navbar navbar-static-top bs-docs-nav">
            <BT:MenuMain runat="server" ID="MenuMain" />
        </div>
        <div class="row">
            <div id="TopPanel" runat="server"></div>
        </div>
        <div class="container ">
            <BT:BreadCrumb runat="server" ID="BreadCrumb" />
            <div class="row">
                <div class="col-md-12">
                    <div id="ContentPane" runat="server"></div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-8">
                    <div id="LeftContent" runat="server"></div>
                </div>
                <div class="col-md-4">

                    <div id="RightContent" runat="server"></div>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
        <BT:Footer runat="server" ID="Footer" />
    </div>
</div>
<BT:FindMode runat="server" ID="FindMode" />
<script src="/js/validation/nicescroll.js?v=5.0.0.9"></script>
<script src="/portals/_default/resource/owlcarousel/owl.carousel.min.js?v=5.0.0.9"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine-vi.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/datetime/datetimepicker.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/toastr.min.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/respo-table/respo.table.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/nicescroll.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/jquery.mask.js?v=1.2"></script>
<script type="text/javascript">
    $(document).ready(function () {
        var osb1 = $('#owl-slidebanner'); osb1.owlCarousel({ autoplay: true, autoplayTimeout: 4000, nav: false, loop: true, dots: true, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-slbanner').click(function () { osb1.trigger('prev.owl.carousel'); }); $('#next-slbanner').click(function () { osb1.trigger('next.owl.carousel'); });
        pageLoad();
    }); function changeUrl(newUrl) { window.history.pushState('', document.title, newUrl); };
    function pageLoad() {
        $('.selectpicker').selectpicker({ liveSearch: true }); $("#Form").validationEngine({ prettySelect: true }); $(".scroll,.inner.open,.modal-content").niceScroll();
        $('.rccalpopup').click(function () { $(this).find(".timepicker").datetimepicker('show'); $(this).find(".datepicker").datetimepicker('show'); });
        $(".timepicker").datetimepicker({ timepicker: true, format: 'd/m/Y H:i', mask: false, closeOnDateSelect: true }); $('.datepicker').datetimepicker({ timepicker: false, format: 'd/m/Y', mask: false, closeOnDateSelect: true }); if ($(".box-title").html() != undefined) { document.title = $(".box-title").html() }; $(".html-home").removeAttr("style");
        jQuery(function () { jQuery(window).scroll(function () { if (jQuery(this).scrollTop() > 0) { jQuery('#return-to-top').fadeIn(); } else { jQuery('#return-to-top').fadeOut(); } }); jQuery('a#return-to-top').click(function () { jQuery('body,html').animate({ scrollTop: 0 }, 300); return false; }); });
        $(".datemask").mask("00/00/0000");
    };
    function waiting() { $(".waiting").removeClass("none") };
    function removewaiting() { $(".waiting").addClass("none") };
    function retunwaiting() { if ($('#Form').validationEngine('validate') == true) { waiting(); return true } else { return false; } };
</script>
