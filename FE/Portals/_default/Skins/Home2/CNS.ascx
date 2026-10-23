<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/DIC/Main/LeftMenu.ascx" TagPrefix="dnn" TagName="MenuLeft" %>
<%@ Register Src="~/DesktopModules/Module/DIC/Main/Header.ascx" TagPrefix="dnn" TagName="Header" %>
<%@ Register Src="~/DesktopModules/Module/DIC/Main/HomeMain.ascx" TagPrefix="dnn" TagName="HomeMain" %>
<%--<%@ Register Src="~/DesktopModules/Module/DIC/Main/Firebase.ascx" TagPrefix="dnn" TagName="Firebase" %>--%>

<link rel="stylesheet" href="/Portals/_default/fonts/resource/font-awesome/css/font-awesome.min.css?v=6.0.0" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/skin.css?v=6.0.0" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/AdminLTE.min.css?v=6.0.1">
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/skin-blue.css?v=6.0.1">
<link rel="stylesheet" href="/js/validation/validationEngine.jquery.css?v=6.0.0" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/style.css?v=6.0.1" />
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/manager.css?v=7.1.1.5" />
<link rel="stylesheet" href="/js/validation/toastr.min.css?v=6.0.0" />
<link rel="stylesheet" href="/js/datetime/datetimepicker.css?v=6.0.0" />
<link rel="stylesheet" href="/js/respo-table/respo.style.css?v=6.0.0" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=6.0.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=6.0.0" />

<body>
    <div class="waiting none">
        <img style="top: 38%; left: calc(50% - 76px); position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
    </div>
    <div class="hold-transition sidebar-mini skin-blue-light bodyfake">
        <div class="wrapper">
            <dnn:Header runat="server" ID="Header1" />
            <dnn:MenuLeft runat="server" ID="MenuLeft1" />
            <div class="content-wrapper">
                <div id="ContentPane" runat="server" class="contentPane"></div>
                <dnn:HomeMain runat="server" ID="HomeMain1" />
            </div>
        </div>
    </div>
    <div id="scroll-top">
        <a href="#top" title="Về đầu trang" class="return-to-top" id="return-to-top"><i class="fa fa-chevron-up"></i></a>
    </div>
    <div id="messages" style="display: none;"></div>
    <%--<dnn:Firebase runat="server" ID="Firebase" />--%>
</body>

<script type="text/javascript" src="/js/base64.js?v=6.0.0"></script>
<script type="text/javascript" src="/portals/_default/skins/vbn/js/app.min.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine-vi.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/datetime/datetimepicker.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/toastr.min.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/respo-table/respo.table.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/nicescroll.js?v=6.0.0"></script>
<script type="text/javascript" src="/portals/_default/fonts/resource/js/jquery.slimscroll.min.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/jquery.cookie.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=6.0.0"></script>
<script type="text/javascript" src="/js/validation/jquery.mask.js?v=1.2"></script>

<script type="text/javascript">
    $(".an1cai").click(function () { if ($(".personalBarContainer").hasClass("andi")) { $(".personalBarContainer").removeClass("andi"); $("#Body").attr("style", "margin-left:60px!important"); } else { $(".personalBarContainer").addClass("andi"); $("#Body").removeAttr("style"); } $(".personalBarContainer").removeAttr("style"); }); $(".personalBarContainer").addClass("andi");
    function removewaiting() { $(".waiting").addClass("none") }; function waiting() { $(".waiting").removeClass("none") };
    function removewaiting1() { $(".waiting1").addClass("none") }; function waiting1() { $(".waiting1").removeClass("none") };
    function onFileSelected(e, t) { var n = e.target.files[0]; var r = new FileReader; var i = document.getElementById("" + t + ""); i.title = n.name; r.onload = function (e) { i.src = e.target.result }; r.readAsDataURL(n) }
    function nhuanbut(id, pid, type, us) { var left = ($("#Body").width() / 2) - 450, top = ($("#Body").height() / 2) - 300; return window.open("/desktopmodules/module/cms/config/nhuanBut.aspx?pid=" + pid + "&itemid=" + id + "&type=" + type + "&us=" + us, "Chấm nhuận bút", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=900, height=500, top=auto, left=' + left); };
    function clickSelect(i, c) { if ($("." + i).hasClass("select")) { $("." + i).removeClass("select"); $("." + c).each(function (e) { if ($(this).find("input").attr("disabled") != "disabled") $(this).find("input").prop("checked", false); }) } else { $("." + i).addClass("select"); $("." + c).each(function (e) { if ($(this).find("input").attr("disabled") != "disabled") $(this).find("input").prop("checked", true); }) } };    function onSelect(t) { if ($(t).hasClass("select")) { $(t).removeClass("select"); } else { $(t).addClass("select"); } };
    function popHistory(w, h, id, pid) { var left = ($("#Body").width() / 2) - (w / 2); var top = ($("#Body").height() / 2) - (h / 2); return window.open("/preview/view/his-new/pid/" + pid + "/itemid/" + id, "Lịch sử biên tập tin", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=auto, left=' + left); };
    function popHistoryM(w, h, id, pid) { var left = ($("#Body").width() / 2) - (w / 2); var top = ($("#Body").height() / 2) - (h / 2); return window.open("/preview/view/his-media/pid/" + pid + "/itemid/" + id, "Lịch sử biên tập video, audio", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=auto, left=' + left); };
    function preview(id, pid) { var left = ($("#Body").width() / 2) - 400, top = ($("#Body").height() / 2) - 300; return window.open("/preview/pid/" + pid + "/newid/" + id + "/f/1", "Nội dung tin bài", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=800, height=600, top=auto, left=' + left); };
    function previewM(id, pid) { var left = ($("#Body").width() / 2) - 320, top = ($("#Body").height() / 2) - 250; return window.open("/preview/view/media/pid/" + pid + "/itemid/" + id, "Xem nội dung media", 'toolbar=no, location=yes, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=800, height=600, top=auto, left=' + left); };
    function appview(id, pid) { var left = ($("#Body").width() / 2) - 400, top = ($("#Body").height() / 2) - 300; return window.open("/preview/view/app/pid/" + pid + "/newid/" + id + "", "Nội dung tin bài", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=800, height=600, top=auto, left=' + left); };
    function appviewM(id, pid) { var left = ($("#Body").width() / 2) - 320, top = ($("#Body").height() / 2) - 250; return window.open("/preview/view/app/pid/" + pid + "/itemid/" + id, "Xem nội dung media", 'toolbar=no, location=yes, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=800, height=600, top=auto, left=' + left); };
    function mobileview(id, pid) { var left = ($("#Body").width() / 2) - 400, top = ($("#Body").height() / 2) - 300; return window.open("/preview/view/mobile-new/pid/" + pid + "/newid/" + id + "", "Nội dung tin bài", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=800, height=600, top=auto, left=' + left); };
    function mobileviewM(id, pid) { var left = ($("#Body").width() / 2) - 320, top = ($("#Body").height() / 2) - 250; return window.open("/preview/view/mobile-video/pid/" + pid + "/itemid/" + id, "Xem nội dung media", 'toolbar=no, location=yes, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=800, height=600, top=auto, left=' + left); };

    function popVersion(w, h, id, pid, lang) {
        if (lang === "soci") {
            var left = 0; var top = 0; var width = $("#Body").width(); var height = $("#Body").height(); return window.open("/preview/view/soci/itemid/" + id + "/pid/" + pid, "Lịch sử thay đổi nội dung", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + width + ', height=' + height + ', top=' + top + ', left=' + left);
        }
        else if (lang === "train") {
            var left = 0; var top = 0; var width = $("#Body").width(); var height = $("#Body").height(); return window.open("/preview/view/train/itemid/" + id + "/pid/" + pid, "Lịch sử thay đổi nội dung", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + width + ', height=' + height + ', top=' + top + ', left=' + left);
        }
        else { var left = ($("#Body").width() / 2) - (w / 2); var top = ($("#Body").height() / 2) - (h / 2); return window.open("/preview/view/version/itemid/" + id + "/pid/" + pid + "/lang/" + lang, "Bản dịch tiếng Việt", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=auto, left=' + left); }
    };
    function clickButton(e, t) { var n = e ? e : window.event; var r = document.getElementById(t); if (r) { if (n.keyCode == 13) { r.click(); return false } } }
    function fadeOut() { jQuery('body,html').animate({ scrollTop: 0 }, 300); return false; } function onFileSelected(e) { var t = e.target.files[0]; var n = new FileReader; var r = document.getElementById("pimg"); r.title = t.name; n.onload = function (e) { r.src = e.target.result }; n.readAsDataURL(t) }
    function changeUrl(newUrl) { window.history.pushState('', document.title, newUrl); };
    function backend(url) { setTimeout(function () { window.location = url; }, 2000); };
    function triggerUpload(id) { $("." + id).click(); };
    function toloadurl() { setTimeout(function () { location.reload(); }, 2000) };
    function retunwaiting() { if ($('#Form').validationEngine('validate') == true) { waiting(); return true } else { return false; } };
    function setValue(myFile, id) { var fileCount = myFile.files; var htm = ""; for (i = 0; i <= fileCount.length - 1; i++) { var file = myFile.files[i]; var filename = file.name; var type = filename.substr(filename.lastIndexOf('.') + 1, 3); if ((type == "doc") || (type == "xls") || (type == "pdf") || (type == "png") || (type == "jpg")) { htm = htm + "<span class='file-list'>" + filename + "</span>"; } } $("." + id).html(htm); };
    function pupChild(pid, id) { waiting(); $.ajax({ type: 'GET', url: '/api/child/getchild.asmx/GetDetailChild?pid=' + pid + '&id=' + id, success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".main-contents").html(json.data); removewaiting(); $("#showPopup").modal('show'); }; }, }); };
    function pageLoad() {
        $('.selectpicker').selectpicker({ liveSearch: true }); $("#Form").validationEngine({ prettySelect: true }); $(".scroll,.inner.open,.modal-content").niceScroll();
        $('.rccalpopup').click(function () { $(this).find(".timepicker").datetimepicker('show'); $(this).find(".datepicker").datetimepicker('show'); });
        $(".timepicker").datetimepicker({ timepicker: true, format: 'd/m/Y H:i', mask: false, closeOnDateSelect: true }); $('.datepicker').datetimepicker({ timepicker: false, format: 'd/m/Y', mask: false, closeOnDateSelect: true }); if ($(".box-title").html() != undefined) { document.title = $(".box-title").html() }; $(".html-home").removeAttr("style");
        jQuery(function () { jQuery(window).scroll(function () { if (jQuery(this).scrollTop() > 0) { jQuery('#return-to-top').fadeIn(); } else { jQuery('#return-to-top').fadeOut(); } }); jQuery('a#return-to-top').click(function () { jQuery('body,html').animate({ scrollTop: 0 }, 300); return false; }); });
        $(".datemask").mask("00/00/0000");
    };
    function movetr(t) { var row = $(t).parents("tr:first"); if ($(t).is(".up")) { row.insertBefore(row.prev()); } else { row.insertAfter(row.next()); } };
    function trmove(t) { var row = $(t).parents("tr:first"); if ($(t).is(".up") && row.prevAll().length > 1) { row.insertBefore(row.prev()); } else if ($(this).is(".down") && row.nextAll().length > 0) { row.insertAfter(row.next()); } else { return false; } };
    $(document).ready(function () { pageLoad(); $.each($("ul.reToolbar.Bootstrap li"), function () { if ($(this).find("a").attr("title") == "Toggle Full Screen Mode") { $(this).find("a").attr('onclick', 'setFullScreen();'); } }); });
    //document.onkeydown = function (e) { if (e.ctrlKey && (e.keyCode === 67 || e.keyCode === 86 || e.keyCode === 85 || e.keyCode === 117)) { return false; } };
    //$(document).keydown(function (event) { if (event.keyCode == 123) { return false; } else if (event.ctrlKey && event.shiftKey && event.keyCode == 73) { return false; } });
    //window.oncontextmenu = function () { return false; }
    function removeValue(id, value) { var arrTemp = $('#' + id).val(); var sResult = ""; var arr = new Array(); arr = arrTemp.split(";"); for (var i = 0; i < arr.length; i++) { if (arr[i] && arr[i] != value) { sResult += ";" + arr[i]; } } $('#' + id).val(sResult.substring(1, sResult.length)); };
    function addValue(id, value) { var NotExists = ($('#' + id).val().indexOf(value) == -1); if (NotExists) { if ($('#' + id).val() == '' || $('#' + id).val() == null) $('#' + id).val(value); else $('#' + id).val($('#' + id).val() + ';' + value); } return NotExists; };
    function changekey(id) { var link = "/api/admin/idcookie.ashx?i=" + id, msg = $.ajax({ url: link, async: false }).responseText; $(".IdKey").html(msg); };
    function setFullScreen() { if ($(document.body).hasClass("fullScreen")) { $(document.body).removeClass("fullScreen"); } else { $(document.body).addClass("fullScreen"); } }
    //$('.main-body').on('keydown', 'input.TextBox', function (e) {
    //    var self = $(this), form = self.parents('form:eq(0)'), focusable, next;
    //    if (e.keyCode == 13) {
    //        focusable = form.find('input.TextBox,button.dropdown-toggle, textarea.TextBox, span > input').filter(':visible:not([readonly]):enabled');
    //        next = focusable.eq(focusable.index(this) + 1); if (next.length) { next.focus(); } return false;
    //    }
    //});
    //$('.main-body').on('keydown', 'button.dropdown-toggle', function (e) {
    //    var self = $(this), form = self.parents('form:eq(0)'), focusable, next;
    //    if (e.keyCode == 13) {
    //        focusable = form.find('input.TextBox,button.dropdown-toggle, textarea.TextBox, span > input').filter(':visible:not([readonly]):enabled');
    //        next = focusable.eq(focusable.index(this) + 1); if (next.length) { next.focus(); } return false;
    //    }
    //});
    //$('.main-body').on('keydown', 'textarea', function (e) {
    //    var self = $(this), form = self.parents('form:eq(0)'), focusable, next;
    //    //if (e.keyCode == 39) {
    //    //    focusable = form.find('input.TextBox,button.dropdown-toggle, textarea.TextBox, span > input').filter(':visible:not([readonly]):enabled');
    //    //    next = focusable.eq(focusable.index(this) + 1); if (next.length) { next.focus(); } return false;
    //    //}
    //});
    function popexp(fu) {
        var hml = "<div class='login-top-header '></div><div class='grid login-grid'>";
        hml += "<div class='member-login-title'><h3>Bạn cần tải file về dưới dạng</h3></div>";
        hml += "<div class='row'><input id='xlsx' type='radio' name='xlsx' checked value='true'>&nbsp;Excel Workbook (.xlsx)</div>";
        hml += "<div class='row pdt10'><input id='xls' type='radio' name='xlsx' value='true'>&nbsp;Excel 97 - 2003 Workbook (.xls)</div>";
        hml += "<div class='row txt-center pd20'>";
        hml += "<input type='submit' name='cmdDownload' onclick='popclose(); return " + fu + "();' value='Tải file excel' class='cmsbut cmsbtDownload cmdcol'></div>";
        hml += "<div class='clear'></div></div>";
        $(".main-contents").html(hml); $("#showPopup").modal('show');
    };
    function popclose() { $('#showPopup').modal('hide'); };
    $(".aedit").click(function () { waiting(); });
    $('Body').on('keydown', '.dropdown > button.dropdown-toggle', function (e) { var inext = $(this).parent(".dropdown").find("select").attr('inext'); if (e.keyCode === 13) { $("." + inext).focus(); } });
    //$('Body').on('keydown', 'textarea', function (e) { if (e.keyCode === 39) { var inext = $(this).attr('inext'); $("." + inext).focus(); } });

    function changefocus(t) { var inext = $(t).attr('inext'); $("." + inext).focus(); };
    function keydownfocus(e, ifocus, esave) { if (e.keyCode === 13) { if (esave === 1) { $("." + ifocus).click(); } else { $("." + ifocus).focus(); } return false; } else { return true; } };
    function formatMoney(event, t) {
        if (event.which >= 37 && event.which <= 40) { event.preventDefault(); }
        var $this = $(t);
        var num = $this.val().replace(/,/gi, "").split("").reverse().join("");
        var num2 = RemoveRougeChar(num.replace(/(.{3})/g, "$1,").split("").reverse().join(""));
        $this.val(num2);
    };
    function RemoveRougeChar(convertString) {
        if (convertString.substring(0, 1) == ",") { return convertString.substring(1, convertString.length); }
        return convertString;
    };
</script>
<div class="IdKey none"></div>
<div id="showPopup" class="modal fade">
    <div class="modal-dialog modal-lg">
        <div class="modal-content main-contents" style="max-height: 500px">
        </div>
    </div>
</div>
