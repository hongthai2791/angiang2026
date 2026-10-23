<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="VideoList.ascx.vb" Inherits="DesktopModules.Media.Display.Control.VideoList" %>
<div class="row">
    <div class="box-video-player ">
        <div class="col-md-8 col-xs-12" runat="server" id="Left_panel">
            <div class="video-wrap">
                <div class="video">
                    <video width="100%" controls autoplay>
                        <asp:Literal ID="fileVideo" runat="server" />
                    </video>
                </div>
            </div>
        </div>
        <asp:Literal ID="litVideoPlay" runat="server"></asp:Literal>
        <div class="clear"></div>
    </div>
    <div class="clear"></div>
</div>
<div class="clear"></div>
<div class="row videolist">
    <asp:Literal ID="litVideoList" runat="server"></asp:Literal>
</div>
<asp:HiddenField ID="currPage" runat="server" Value="1" />
<asp:HiddenField ID="ItemID" Visible="false" runat="server" />
<asp:HiddenField ID="vUrl" runat="server" />
<script src="https://sp.zalo.me/plugins/sdk.js?v=2"></script>
<script type="text/javascript">
    function fnext(p) { changeurl(p); var link = "/api/home/medialist.ashx?t=2&p=" + p, msg = $.ajax({ url: link, async: false }).responseText; $(".ex_page").remove(), $(".videolist").html(msg); window.scrollTo(0, 540); };
    function changeurl(p) { var url = $("#<%=vUrl.ClientID%>").val(); url = url + "/p/" + p; window.history.pushState('', document.title, url); };
    var $window = $(window); var $videoWrap = $('.video-wrap'); var $video = $('.video');
    $window.on('scroll', function () { var windowScrollTop = $window.scrollTop(); var videoBottom = 500; var w = $("#Body").width(); if (w >= 768) { if (windowScrollTop > videoBottom) { $videoWrap.height(420); $video.addClass('stuck'); } else { $videoWrap.height('auto'); $video.removeClass('stuck'); } }; });
    (function (e, t, n) { var r, i = e.getElementsByTagName(t)[0]; if (e.getElementById(n)) return; r = e.createElement(t); r.id = n; r.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1"; i.parentNode.insertBefore(r, i) })(document, "script", "facebook-jssdk")
    window.___gcfg = { lang: "vi" }; (function () { var e = document.createElement("script"); e.type = "text/javascript"; e.async = true; e.src = "https://apis.google.com/js/platform.js"; var t = document.getElementsByTagName("script")[0]; t.parentNode.insertBefore(e, t) })()
</script>
