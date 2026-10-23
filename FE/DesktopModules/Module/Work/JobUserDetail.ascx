<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="JobUserDetail.ascx.vb" Inherits="DesktopModules.Modules.Read" %>
<div class="box-jobuser">
    <div class="detail-jobuser">
        <div class="row">
            <h1 class="title_details">
                <asp:Literal ID="Title" runat="server"></asp:Literal></h1>
            <div class="col-md-3 pdl0 logo-jobus">
                <div class="row data_jobuser_avatar">
                    <%--<asp:Literal ID="JobUser_Img" runat="server"></asp:Literal>--%>
                    <div class="clear"></div>
                </div>
                <div class="row mgt10">
                    <div style="display: inline-block; position: relative;" class='fb-like' data-href='<%=strFb %>' data-layout='button_count' data-action='like' data-show-faces='false' data-share='false'></div>
                    <div class="clear"></div>
                </div>
                <div class="row mgt10">
                    <div style="display: inline-block; position: relative;" class="fb-share-button" data-href="<%=strFb %>" data-layout="button_count" data-size="small" data-mobile-iframe="true">
                        <a class="fb-xfbml-parse-ignore" rel="nofollow" target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=<%=strFb %>&amp;src=sdkpreparse">Chia sẻ</a>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row mgt10">
                    <div class="zalo-share-button" style="position: relative;" data-href="<%=strFb %>" data-oaid="579745863508352884" data-layout="1" data-color="blue" data-customize="false"></div>
                    <div class="clear"></div>
                </div>
            </div>
            <div class="col-md-9 pdl0 pdr0">
                <p class="title-jobus">
                    <asp:Literal ID="JobUser_Vn" runat="server"></asp:Literal>
                    <a href="<%=linkSend %>" style="float: right;" title="Lưu hồ sơ" target="_blank" rel="nofollow" class="text_grey2 "><span class="line-icon"><i class="icon-star icon_free_style"></i><span class="pl_28" style="color: #04b0b7">&nbsp;Lưu hồ sơ </span></span></a>
                </p>
                <div class="clear"></div>
                <div class="info-comdetail">
                    <asp:Literal ID="litInfo" runat="server"></asp:Literal>
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>
    </div>
    <div class="detail-jobuser">
        <div class="row">
            <span class="title_details">Thông tin trình độ, kinh nghiệm</span>
        </div>
        <div class="row pdt10">
            <asp:Literal ID="ltTrinhDo" runat="server"></asp:Literal>
        </div>
    </div>
    <div class="detail-jobuser">
        <div class="row">
            <span class="title_details">Thông tin mục tiêu, kỹ năng</span>
        </div>
        <div class="row pdt10">
            <asp:Literal ID="ltrMucTieu" runat="server"></asp:Literal>
        </div>
    </div>
    <div class="clear"></div>
</div>

<asp:Literal ID="litSEO" runat="server"></asp:Literal>
<asp:HiddenField ID="ItemID" runat="server" />
<asp:HiddenField ID="vUrl" Value="" runat="server" Visible="false" />
<script src="https://sp.zalo.me/plugins/sdk.js?v=2" type="text/javascript"></script>
<script type="text/javascript">
    function getavatar(ID) {
        var ID = $("#<%=ItemID.ClientID%>").val();
        $.ajax({
            type: 'GET', url: '<%=EPORTAL.flReg.WebConfig("member")%>/api/work/home.asmx/getavatar?id=' + ID,
            success: function (data) {
                var json = $.parseJSON($(data).find("string").text());
                if (json.data) {
                    $(".data_jobuser_avatar").html(json.data);
                };
            },
        });
    };
    jQuery(document).ready(function () { getavatar($("#<%=ItemID.ClientID%>").val()); });
    (function (e, t, n) { var r, i = e.getElementsByTagName(t)[0]; if (e.getElementById(n)) return; r = e.createElement(t); r.id = n; r.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1"; i.parentNode.insertBefore(r, i) })(document, "script", "facebook-jssdk")
    window.___gcfg = { lang: "vi" }; (function () { var e = document.createElement("script"); e.type = "text/javascript"; e.async = true; e.src = "https://apis.google.com/js/platform.js"; var t = document.getElementsByTagName("script")[0]; t.parentNode.insertBefore(e, t) })()
</script>
