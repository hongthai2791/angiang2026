<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="NewsRead.ascx.vb" Inherits="DesktopModules.Modules.Read" %>
<%@ Register TagPrefix="BT" TagName="COMMENT" Src="~/DesktopModules/Module/News/Comments.ascx" %>
<%@ Register Src="~/DesktopModules/Module/News/Related.ascx" TagPrefix="BT" TagName="Related" %>
<div class="detail-post hnoneview" enableviewstate="false" runat="server" id="viewhinone">
    <asp:Literal ID="Introduction" runat="server" />
    <h1 class="post-title">
        <asp:Literal ID="lbTitle" runat="server" Text="..."></asp:Literal>
    </h1>
    <div class="post-subinfo row">
        <div class="col-md-6 col-sm-12 lbPublishedDate">
            <asp:Literal ID="lbPublishedDate" runat="server"></asp:Literal>
        </div>
        <div class="col-md-6 col-sm-12 ">
            <div style="padding-bottom: 10px; float: right">
                <a onclick="preview()" rel="nofollow" href="javascript:;" class="printview" style="display: inline-block" title="Print">
                    <img src="/image/images/print.png?w" alt="print" /></a>
                <div style="display: inline-block; position: relative; top: -4px;" class='fb-like' data-href='<%=strFb %>' data-layout='button_count' data-action='like' data-show-faces='false' data-share='false'></div>
                <div style="display: inline-block; position: relative; top: -4px;" class="fb-share-button" data-href="<%=strFb %>" data-layout="button_count" data-size="small" data-mobile-iframe="true">
                    <a class="fb-xfbml-parse-ignore" rel="nofollow" target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=<%=strFb %>&amp;src=sdkpreparse">Chia sẻ</a>
                </div>
                <div class="zalo-share-button" style="position: relative; top: 7px;" data-href="<%=strFb %>" data-oaid="579745863508352884" data-layout="1" data-color="blue" data-customize="false"></div>
                <div class="clear"></div>
            </div>
        </div>
        <div class="clear"></div>
    </div>
    <div class="clear"></div>
    <div id="changesize" class="changesize">
        Kích cỡ font chữ
        <a href="javascript:;" rel="nofollow" class="fontDown" data-toggle="tooltip" title="Giảm kích cỡ font chữ">
            <img alt="A-" src="/image/images/a-.png?w=18" />
        </a>
        <a href="javascript:;" rel="nofollow" class="fontRefresh" data-toggle="tooltip" title="Kích cỡ font chữ mặc định">
            <img alt="A" src="/image/images/a.png?w=19" />
        </a>
        <a href="javascript:;" rel="nofollow" class="fontUp" data-toggle="tooltip" data-color="red" title="Tăng kích cỡ font chữ">
            <img alt="A+" src="/image/images/a_z.png?w=25" />
        </a>
    </div>
    <asp:Literal ID="lbSummary" runat="server" Text=""></asp:Literal>
    <div class="clear"></div>
    <asp:Literal ID="litRelate" runat="server" />
    <div class="clear"></div>
    <div class="post-content">
        <asp:Literal ID="lbContent" runat="server"></asp:Literal>
        <div class="clear"></div>
        <asp:Literal ID="litSEO" runat="server"></asp:Literal>
        <div class="clear"></div>
    </div>
    <div class="clear height-10"></div>
    <div class="col-md-12 col0">
        <div style="padding-bottom: 10px">
            <a onclick="preview()" rel="nofollow" href="javascript:;" class="printview" style="float: left; margin-right: 5px;" title="Print">
                <img src="/image/images/print.png?w" alt="print" /></a>
            <div style="float: left; margin-right: 5px;" class='fb-like' data-href='<%=strFb %>' data-layout='button_count' data-action='like' data-show-faces='false' data-share='false'></div>
            <div style="float: left;" class="fb-share-button" data-href="<%=strFb %>" data-layout="button_count" data-size="small" data-mobile-iframe="true">
                <a class="fb-xfbml-parse-ignore" rel="nofollow" target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=<%=strFb %>&amp;src=sdkpreparse">Chia sẻ</a>
            </div>
            <div class="zalo-share-button" style="margin-left: 3px;" data-href="<%=strFb %>" data-oaid="579745863508352884" data-layout="1" data-color="blue" data-customize="false"></div>
            <div class="clear"></div>
        </div>
    </div>
    <div class="clear"></div>
    <div class="post-tag">
        <asp:Literal ID="litTag" runat="server" />
        <div class="clear"></div>
    </div>
    <div class="clear"></div>
    <asp:Literal ID="lienQuan" runat="server"></asp:Literal>
    <div class="clear height-10"></div>
    <div class="clear"></div>
</div>
<div class="clear pdt10"></div>
<BT:COMMENT runat="server" ID="vbComment" />
<BT:Related runat="server" ID="Related" />
<div class="clear"></div>
<asp:HiddenField ID="ItemID" runat="server" />
<script src="https://sp.zalo.me/plugins/sdk.js?v=2" type="text/javascript"></script>
<script type="text/javascript">
    function preview() { var left = (screen.width / 2) - 400, top = (screen.height / 2) - 300; return window.open("/preview/pid/<%=Me.PortalId%>/newid/" + $(<%=ItemID.ClientID%>).val(), "Related news", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=800, height=600, top=20, left=' + left); };
    $(function () { $(".post-content table").each(function (e) { if (($(this).attr("align") == "center") && ($(this).attr("style") == null)) { $(this).attr("style", "margin:0 auto"); } }); $(".bg-v3home-block-category").remove(); });
    function fonterror() { $(".post-content table").each(function (e) { if ($(this).attr("width") == "200") { $(this).removeAttr("width"); } }); var html = $(".post-content").html(); for (i = 0; i < html.length; i++) { html = html.replace('ô%3ḅ', 'ộ'); html = html.replace('ê%3ḅ', 'ệ'); html = html.replace('â%3ḅ', 'ậ'); html = html.replace('Ô%3ḅ', 'Ộ'); html = html.replace('Ê%3ḅ', 'Ệ'); html = html.replace('Â%3ḅ', 'Ậ'); } $(".post-content").html(html); }; $(document).ready(function () { fonterror(); });
    $(document).ready(function () {
        //Reset font-size
        var titleSize = $('.post-title').css('font-size'); /* Kích thước tiêu đề*/
        var desSize = $('.detail-post .post-summary h2').css('font-size'); /* Kích thước mô tả*/
        var dateSize = $('.detail-post .post-subinfo .lbPublishedDate').css('font-size'); /* Kích thước ngày đăng*/
        var paraSize = $('.post-content p').css('font-size');/* Kích thước nội dung*/
        $(".fontRefresh").click(function () {
            $('.post-title').css('font-size', titleSize);
            $('.detail-post .post-summary h2').css('font-size', desSize);
            $('.detail-post .post-subinfo .lbPublishedDate').css('font-size', dateSize);
            $('.post-content p').css('font-size', paraSize);
            return false;
        });
        //Tăng kích cỡ font size
        $(".fontUp").click(function () {
            var currTitleSize = $('.post-title').css('font-size'); var incTitsize = parseFloat(currTitleSize, 10); var newTitsize = incTitsize + 1; $('.post-title').css('font-size', newTitsize);
            var currDesSize = $('.detail-post .post-summary h2').css('font-size'); var incDessize = parseFloat(currDesSize, 10); var newDessize = incDessize + 1; $('.detail-post .post-summary h2').css('font-size', newDessize);
            var currDateSize = $('.detail-post .post-subinfo .lbPublishedDate').css('font-size'); var incDatesize = parseFloat(currDateSize, 10); var newDatesize = incDatesize + 1; $('.detail-post .post-subinfo .lbPublishedDate').css('font-size', newDatesize);
            var currParaSize = $('.post-content p').css('font-size'); var incParasize = parseFloat(currParaSize, 10); var newParasize = incParasize + 1; $('.post-content p').css('font-size', newParasize);
            return false;
        });
        //GIảm kích cỡ fontsize
        $(".fontDown").click(function () {
            var currentfontsize = $('.post-title').css('font-size'); var decTitsize = parseFloat(currentfontsize, 10); var newTitsize = decTitsize - 1; $('.post-title').css('font-size', newTitsize);
            var currDesSize = $('.detail-post .post-summary h2').css('font-size'); var incDessize = parseFloat(currDesSize, 10); var newDessize = incDessize - 1; $('.detail-post .post-summary h2').css('font-size', newDessize);
            var currDateSize = $('.detail-post .post-subinfo .lbPublishedDate').css('font-size'); var incDatesize = parseFloat(currDateSize, 10); var newDatesize = incDatesize - 1; $('.detail-post .post-subinfo .lbPublishedDate').css('font-size', newDatesize);
            var currParaSize = $('.post-content p').css('font-size'); var incParasize = parseFloat(currParaSize, 10); var newParasize = incParasize - 1; $('.post-content p').css('font-size', newParasize);
            return false;
        });
    });
    window.___gcfg = { lang: "vi" }; (function () { var e = document.createElement("script"); e.type = "text/javascript"; e.async = true; e.src = "https://apis.google.com/js/platform.js"; var t = document.getElementsByTagName("script")[0]; t.parentNode.insertBefore(e, t) })()
</script>
