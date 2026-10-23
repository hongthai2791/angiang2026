<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="Footer.ascx.vb" Inherits="DesktopModules.Home.Footer" %>
<%@ Register Src="~/admin/Captcha/VbCapchar.ascx" TagPrefix="uc1" TagName="VbCapchar" %>

<style type="text/css">
    #scroll-top a {
        bottom: 90px;
        right: 40px;
    }

    .pd0 {
        padding: 0 !important
    }

    .pdtp30 {
        padding: 30px 5px !important
    }

    .pdt20 {
        padding-top: 20px !important
    }

    .footer__link .ft-lg {
        padding-left: 6px;
        margin-top: 15px
    }

    .pdl5 {
        padding-left: 5px !important
    }

    .lienhemail .emailReg {
        font-size: 13px
    }

    .lieheapp {
        line-height: 24px !important;
        font-size: 14px !important;
        margin-top: -15px !important
    }

        .lieheapp div {
            line-height: 24px !important
        }

    .btn-gui {
        height: 42px !important;
    }

    .taiapp {
        z-index: 999;
        width: 100%;
        margin: 5px 0;
        padding: 5px 10px;
        /*border: 1px solid #ddd;*/
        border-radius: 5px;
        text-align: center
    }

    .lheapp {
        margin-top: 15px !important;
    }

    .box-head-name {
        margin-bottom: 0px !important;
    }

    .box-thong-ke {
        margin-bottom: 0px !important;
        padding: 0px 10px !important;
        margin-top: -5px;
    }

    .chat-web-manage {
        position: fixed;
        bottom: 25px;
        z-index: 9999;
        right: 38px;
    }

    .box_chat_div {
        position: fixed;
        bottom: 5px;
        right: 20px;
        z-index: 18000001;
    }

    .chat-web-manage .cbmb__icon_support {
        cursor: pointer;
        overflow: hidden;
    }

        .chat-web-manage .cbmb__icon_support img {
            width: 50px;
            height: 50px;
        }

    #box_chat_div .chat-icon-close {
        cursor: pointer;
        position: absolute;
        top: 17px;
        right: 20px;
        z-index: 2;
    }

    .fixskinchatbot {
        left: 38px !important;
        right: 0 !important;
    }
    .fixclose{
        right: 0 !important;
        left: 345px !important;
    }
</style>
<footer id="footer" class="footer">

    <div class=" container bg-main pd10 mgt10">
       
        <div class="clear"></div>
    </div>
    <div class="container ">
        <div class="col-md-6">
            <asp:Literal ID="litFooter" runat="server"></asp:Literal>
        </div>

        <div class="col-md-6">

            <div class="row pd30">
                <div class="col-md-12 pd0 lienhemail">
                    <div class="Ttlh pd0">
                        <div class="col-md-12 pd0 lheapp">
                            <div class="pdl5" style="font-size: 12px; font-weight: bold; color: #fff;">Ứng dụng hỗ trợ Người lao động, Nhà tuyển dụng</div>
                            <a href="javascript:;" target="_blank" rel="nofollow" class="col-md-6" title="Tải app ios">
                                <div class="taiapp ">
                                    <img class="img-responsive" src="/image/icon/ios.png" alt="tải app">
                                </div>
                            </a>
                            <a href="javascript:;" target="_blank" rel="nofollow" title="Tải app android" class="col-md-6">
                                <div class="taiapp">
                                    <img class="img-responsive" src="/image/icon/android.png" alt="tải app">
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
                <div class="col-md-12" style="text-align: center">
                    <asp:Literal ID="litFanpage" runat="server"></asp:Literal>
                </div>
                <div class="col-md-12 ">
                    <div class="box-thong-ke">
                        <div class="box-head-name">Thống kê</div>
                        <div class="row-tke">
                            Đang truy cập: <span><%=Convert.ToInt32(Application("gOnline")) %></span><div class="clear"></div>
                        </div>
                        <asp:Literal ID="OtherStatistic" runat="server" />
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
</footer>
<div class="copyright">
    <div class="container">
        <div class="col-md-12 pdl0 foot-social dflex">
            <asp:Literal ID="ltWeblink" runat="server" />
        </div>
    </div>
</div>
<%--<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div style="display: none;">
            <asp:LinkButton ID="btnOpenSession" runat="server" Text="Mở lại" CssClass="btn btn-openmessage none" />
            <asp:LinkButton ID="btnCloseSession" runat="server" Text="Đóng lại" CssClass="btn btn-closeessage none" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>--%>

<!-- Load Facebook SDK for JavaScript -->
<div id="fb-root"></div>
<script>
    window.fbAsyncInit = function () {
        FB.init({
            xfbml: true,
            version: 'v8.0'
        });
    };

    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = 'https://connect.facebook.net/vi_VN/sdk/xfbml.customerchat.js';
        fjs.parentNode.insertBefore(js, fjs);
    }(document, 'script', 'facebook-jssdk'));</script>

<!-- Your Chat Plugin code -->
<div class="fb-customerchat"
    attribution="setup_tool"
    page_id="636767226428551">
</div>
<script>
    window.fbAsyncInit = function () { FB.init({ xfbml: true, version: 'v4.0' }); };
    (function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (d.getElementById(id)) return; js = d.createElement(s); js.id = id; js.src = 'https://connect.facebook.net/en_US/sdk/xfbml.customerchat.js'; fjs.parentNode.insertBefore(js, fjs); }(document, 'script', 'facebook-jssdk'));
</script>

<div id="chat-web-manage" class="chat-web-manage">
    <div class="cbmb__icon_support">
        <img src="/image/logochatbot.png" />
    </div>
</div>

<div id="box_chat_div" class="none dt box_chat_div">
    <div class="chat-icon-close">
        <svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
            <g opacity="0.45">
                <path d="M13.3054 11.9984L19.2773 6.03125C19.6382 5.67031 19.6382 5.08672 19.2773 4.72813C18.9164 4.36719 18.3328 4.36719 17.9742 4.72813L12 10.693L6.02573 4.72578C5.66479 4.36484 5.0812 4.36484 4.72261 4.72578C4.36167 5.08672 4.36167 5.67031 4.72261 6.02891L10.6945 11.9961L4.72261 17.9656C4.36167 18.3266 4.36167 18.9102 4.72261 19.2688C4.90308 19.4492 5.13979 19.5383 5.37417 19.5383C5.61089 19.5383 5.84526 19.4492 6.02573 19.2688L12 13.3016L17.9742 19.2711C18.1546 19.4516 18.389 19.5406 18.6257 19.5406C18.8625 19.5406 19.0968 19.4516 19.2773 19.2711C19.6382 18.9102 19.6382 18.3266 19.2773 17.968L13.3054 11.9984Z" fill="#000"></path>
            </g></svg>
    </div>
    <asp:Literal ID="lblLoadChatBot" runat="server" />
</div>

<script>
    $(document).ready(function () {
        $('.chat-web-manage').click(function (e) {
            $('#box_chat_div').removeClass('none');
            $.cookie('CK_eChat', 1);
            //eval($('.btn-openmessage').attr('href'));
        });
        $('.chat-icon-close').click(function (e) {
            $('#box_chat_div').addClass('none');
            $.cookie('CK_eChat', 0);
            //eval($('.btn-closeessage').attr('href'));
        });
    });
    function openchatbot(i) {
        if (!!$.cookie('CK_eChat')) {
            // have cookie
            //console.log($.cookie('CK_eChat'));
        } else {
            $.cookie('CK_eChat', i)
            //console.log($.cookie('CK_eChat'));
        }
        if ($.cookie('CK_eChat') == 1)
            $('#box_chat_div').removeClass('none');
        else
            $('#box_chat_div').addClass('none');
    }
    function checkchatbot(i,x) {
        if (i != 1) {
            $('#box_chat_div').addClass("fixskinchatbot");
            $('.chat-icon-close').addClass("fixclose");
        }
        else {
            $('.box_chat_div').removeClass("fixskinchatbot")
           
            $('.chat-icon-close').removeClass("fixclose");
        }
        if (x != 1)
            $('.chat-web-manage').addClass("fixskinchatbot");
        else
            $('.chat-web-manage').removeClass("fixskinchatbot")
    }
</script>
