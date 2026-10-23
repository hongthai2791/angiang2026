<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Member/Main/LeftMenu.ascx" TagPrefix="dnn" TagName="MenuLeft" %>
<%--<%@ Register Src="~/DesktopModules/Member/Main/Header.ascx" TagPrefix="dnn" TagName="Header" %>--%>
<%@ Register Src="~/DesktopModules/Member/Main/HomeMain.ascx" TagPrefix="dnn" TagName="HomeMain" %>
<%@ Register Src="~/DesktopModules/Module/Home/MenuMain.ascx" TagPrefix="BT" TagName="MenuMain" %>
<%@ Register Src="~/DesktopModules/Module/Home/Footer.ascx" TagPrefix="BT" TagName="Footer" %>
<%@ Register Src="~/DesktopModules/Module/Home/FindMode.ascx" TagPrefix="BT" TagName="FindMode" %>
<%@ Register Src="~/DesktopModules/Module/Sitemap/cssDefault.ascx" TagPrefix="BT" TagName="cssDefault" %>
<%--<%@ Register Src="~/DesktopModules/Module/Home/BreadCrumb.ascx" TagPrefix="BT" TagName="BreadCrumb" %>
<%@ Register Src="~/DesktopModules/Module/Home/HomeSlider.ascx" TagPrefix="BT" TagName="HomeSlider" %>
<%@ Register Src="~/DesktopModules/Module/Home/SearchAdv.ascx" TagPrefix="BT" TagName="SearchAdv" %>--%>




<link rel="stylesheet" href="/Portals/_default/fonts/resource/font-awesome/css/font-awesome.min.css?v=4.5.3" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/skin.css?v=6.0.0.0" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/AdminLTE.min.css?v=6.0.0.0">
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/skin-blue.css?v=6.0.0.0">
<link rel="stylesheet" href="/js/validation/validationEngine.jquery.css?v=6.0.0.0" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/style.css?v=6.0.0.0" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/manager.css?v=7.1.1.1" />
<link rel="stylesheet" href="/js/validation/toastr.min.css?v=6.0.0.0" />
<link rel="stylesheet" href="/js/datetime/datetimepicker.css?v=6.0.0.0" />
<link rel="stylesheet" href="/js/respo-table/respo.style.css?v=6.0.0.0" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=6.0.0.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=6.0.0.0" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.carousel.min.css?v=5.1.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.theme.default.min.css?v=5.1.0.9" rel="stylesheet" />

<BT:cssDefault runat="server" ID="cssDefault" />

<link rel="stylesheet" href="/portals/_default/skins/vbn/css/bhtn.css?v=1.1.1" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/member.css?v=1.1.1" />
<div class="body default">
    <div class="hidden-login">
        <div class="header navbar navbar-static-top bs-docs-nav">
            <BT:MenuMain runat="server" ID="MenuMain" />
        </div>
        <%-- <BT:SearchAdv runat="server" ID="SearchAdv" />
            <BT:HomeSlider runat="server" ID="HomeSlider" />--%>
        <section class="sptb">
            <div class="container ">
                <%--<BT:BreadCrumb runat="server" ID="BreadCrumb" />--%>
                <div class="row">
                    <dnn:MenuLeft runat="server" ID="MenuLeft1" />
                    <div class="content-wrapper">
                        <div id="ContentPane" runat="server" class="contentPane"></div>
                        <dnn:HomeMain runat="server" ID="HomeMain" />
                    </div>
                </div>
            </div>
        </section>
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
<div class="waiting none">
    <img style="top: 38%; left: calc(50% - 76px); position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
</div>

<script type="text/javascript" src="/js/base64.js?v=6.0.0.0"></script>
<script src="/portals/_default/resource/owlcarousel/owl.carousel.min.js?v=5.0.0.9"></script>
<script type="text/javascript" src="/portals/_default/skins/vbn/js/app.min.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine-vi.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/datetime/datetimepicker.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/validation/toastr.min.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/respo-table/respo.table.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/validation/nicescroll.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/portals/_default/fonts/resource/js/jquery.slimscroll.min.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/jquery.cookie.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=6.0.0.0"></script>
<script src="/js/validation/jquery.mask.js?v=1.2"></script>

<script type="text/javascript">

    function pageLoad() { $('.selectpicker').selectpicker({ liveSearch: true }); };
    $(".an1cai").click(function () { if ($(".personalBarContainer").hasClass("andi")) { $(".personalBarContainer").removeClass("andi"); $("#Body").attr("style", "margin-left:60px!important"); } else { $(".personalBarContainer").addClass("andi"); $("#Body").removeAttr("style"); } $(".personalBarContainer").removeAttr("style"); }); $(".personalBarContainer").addClass("andi");
    function removewaiting() { $(".waiting").addClass("none") }; function waiting() { $(".waiting").removeClass("none") };
    function onFileSelected(e, t) { var n = e.target.files[0]; var r = new FileReader; var i = document.getElementById("" + t + ""); i.title = n.name; r.onload = function (e) { i.src = e.target.result }; r.readAsDataURL(n) }
    function clickSelect(i, c) { if ($("." + i).hasClass("select")) { $("." + i).removeClass("select"); $("." + c).each(function (e) { if ($(this).find("input").attr("disabled") != "disabled") $(this).find("input").prop("checked", false); }) } else { $("." + i).addClass("select"); $("." + c).each(function (e) { if ($(this).find("input").attr("disabled") != "disabled") $(this).find("input").prop("checked", true); }) } }; function clickButton(e, t) { var n = e ? e : window.event; var r = document.getElementById(t); if (r) { if (n.keyCode == 13) { r.click(); return false } } }
    function fadeOut() { jQuery('body,html').animate({ scrollTop: 0 }, 300); return false; } function onFileSelected(e) { var t = e.target.files[0]; var n = new FileReader; var r = document.getElementById("pimg"); r.title = t.name; n.onload = function (e) { r.src = e.target.result }; n.readAsDataURL(t) }
    function changeUrl(newUrl) { window.history.pushState('', document.title, newUrl); };
    function backend(url) { setTimeout(function () { window.location = url; }, 2000); }; function triggerUpload(id) { $("." + id).click(); };
    function toloadurl() { setTimeout(function () { location.reload(); }, 2000) };
    function retunwaiting() { if ($('#Form').validationEngine('validate') == true) { waiting(); return true } else { return false; } };
    function setValue(myFile, id) { var fileCount = myFile.files; var htm = ""; for (i = 0; i <= fileCount.length - 1; i++) { var file = myFile.files[i]; var filename = file.name; var type = filename.substr(filename.lastIndexOf('.') + 1, 3); if ((type == "doc") || (type == "xls") || (type == "pdf") || (type == "png") || (type == "jpg")) { htm = htm + "<span class='file-list'>" + filename + "</span>"; } } $("." + id).html(htm); };
    function pupChild(pid, id) { waiting(); $.ajax({ type: 'GET', url: '/api/child/getchild.asmx/GetDetailChild?pid=' + pid + '&id=' + id, success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".main-contents").html(json.data); removewaiting(); $("#showPopup").modal('show'); }; }, }); };
    function pageLoad() {
        $('.selectpicker').selectpicker({ liveSearch: true }); $("#Form").validationEngine({ prettySelect: true }); $(".scroll,.inner.open,.modal-content").niceScroll();
        $('.rccalpopup').click(function () { $(this).find(".timepicker").datetimepicker('show'); $(this).find(".datepicker").datetimepicker('show'); });
        $(".timepicker").datetimepicker({ timepicker: true, format: 'd/m/Y H:i', mask: false, closeOnDateSelect: true });
        $('.datepicker').datetimepicker({ timepicker: false, format: 'd/m/Y', mask: false, closeOnDateSelect: true });
        if ($(".box-title").html() != undefined) { document.title = $(".box-title").html() }; $(".html-home").removeAttr("style");
    };
    $(document).ready(function () {
        var osb1 = $('#owl-slidebanner'); osb1.owlCarousel({ autoplay: true, autoplayTimeout: 4000, nav: false, loop: true, dots: true, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 4 } } }); $('#prev-slbanner').click(function () { osb1.trigger('prev.owl.carousel'); }); $('#next-slbanner').click(function () { osb1.trigger('next.owl.carousel'); });
        pageLoad(); jQuery(window).scroll(function () { if (jQuery(this).scrollTop() > 30) { jQuery('#return-to-top').fadeIn(); } else { jQuery('#return-to-top').fadeOut(); } }); $.each($("ul.reToolbar.Bootstrap li"), function () { if ($(this).find("a").attr("title") == "Toggle Full Screen Mode") { $(this).find("a").attr('onclick', 'setFullScreen();'); } });
    });
    function removeValue(id, value) { var arrTemp = $('#' + id).val(); var sResult = ""; var arr = new Array(); arr = arrTemp.split(";"); for (var i = 0; i < arr.length; i++) { if (arr[i] && arr[i] != value) { sResult += ";" + arr[i]; } } $('#' + id).val(sResult.substring(1, sResult.length)); };
    function addValue(id, value) { var NotExists = ($('#' + id).val().indexOf(value) == -1); if (NotExists) { if ($('#' + id).val() == '' || $('#' + id).val() == null) $('#' + id).val(value); else $('#' + id).val($('#' + id).val() + ';' + value); } return NotExists; };
    function changekey(id) { var link = "/api/admin/idcookie.ashx?i=" + id, msg = $.ajax({ url: link, async: false }).responseText; $(".IdKey").html(msg); };
    function setFullScreen() { if ($(document.body).hasClass("fullScreen")) { $(document.body).removeClass("fullScreen"); } else { $(document.body).addClass("fullScreen"); } }
    function setTrangThaiUV(pid, rid, t, isflag, us) {
        var isVal = $(t).prop('checked'); var val = $(t).val();
        if (val == "Đã xem") { $("input[value='Đã xem']").prop("disabled", true); }
        $.ajax({
            type: 'GET', url: '/api/work/works.asmx/SetTrangThaiUV?pid=' + pid + '&rid=' + rid + '&isval=' + isVal + '&isflag=' + isflag + '&username=' + us,
            success: function (data) { var json = $.parseJSON($(data).find("string").text()); },
        });
        var cls = $(t).attr("class"); if (isVal == true) { $("input.m-" + cls).attr("checked", "checked"); } else { $("input.m-" + cls).removeAttr("checked"); } notify('success', 'Đã cập nhật lại trạng thái.', 'Thông báo', false);
    };
    function setGTVL(pid, rid, t, isflag, us) {
        var isVal = $(t).prop('checked'); var val = $(t).val();
        if (val == "Đã xem") { $("input[value='Đã xem']").prop("disabled", true); }
        $.ajax({
            type: 'GET', url: '/api/work/works.asmx/setGTVL?pid=' + pid + '&rid=' + rid + '&isval=' + isVal + '&isflag=' + isflag + '&username=' + us,
            success: function (data) { var json = $.parseJSON($(data).find("string").text()); },
        });
        var cls = $(t).attr("class"); if (isVal == true) { $("input.m-" + cls).attr("checked", "checked"); } else { $("input.m-" + cls).removeAttr("checked"); } notify('success', 'Đã cập nhật lại trạng thái.', 'Thông báo', false);
    };
</script>
<div class="IdKey none"></div>
<div id="showPopup" class="modal fade">
    <div class="modal-dialog modal-lg">
        <div class="modal-content main-contents"></div>
    </div>
</div>
