<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="ReadApp.ascx.vb" Inherits="DesktopModules.Modules.Read" %>
<div class="detail-post hnoneview" enableviewstate="false" runat="server" id="viewhinone">
    <asp:Literal ID="Introduction" runat="server" />
    <h1 class="post-title">
        <asp:Literal ID="lbTitle" runat="server" Text="..."></asp:Literal>
    </h1>
    <div class="post-subinfo row">
        <div class="col-md-6 col-sm-12 lbPublishedDate">
            <asp:Literal ID="lbPublishedDate" runat="server"></asp:Literal>
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
    <div class="post-content">
        <asp:Literal ID="lbContent" runat="server"></asp:Literal>
        <div class="clear"></div>
    </div>
    <div class="clear height-10"></div>
    <div class="post-tag">
        <asp:Literal ID="litTag" runat="server" />
        <div class="clear"></div>
    </div>
    <div class="clear height-10"></div>
    <div class="clear"></div>
</div>
<div class="clear"></div>
<asp:HiddenField ID="ItemID" runat="server" Visible="false" />
<script type="text/javascript">
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
</script>
