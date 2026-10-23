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
</style>

<section class="sptb download-app">
    <div class="container">
        <div class="section-title center-block text-center">
            <h2>ỨNG DỤNG</h2>
            <p>Ứng dụng hỗ trợ Người lao động, Nhà tuyển dụng</p>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="text-center text-wrap">
                    <div class="btn-list"><a href="javascript:void(0);" class="btn btn-primary btn-lg mb-sm-0"><i class="fa fa-apple fa-1x me-2"></i>App Store</a> <a href="javascript:void(0);" class="btn btn-secondary btn-lg mb-sm-0"><i class="fa fa-android fa-1x me-2"></i>Google Play</a> <a href="javascript:void(0);" class="btn btn-info btn-lg mb-0"><i class="fa fa-windows fa-1x me-2"></i>Windows</a> </div>
                </div>
            </div>
        </div>
    </div>
</section>

<footer id="footer" class="footer cover-image">
    <div class=" container bg-main pd10">
        <div class="col-md-12 pd0">
            <div class="col-md-6 pdbt10 pdl0 bgw pd10">
                <div class="hotline-box pd10 ">

                    <div class="tuyendung1">
                        <div class=" txt-tuyendung ">
                            <p>HỖ TRỢ NHÀ TUYỂN DỤNG</p>
                        </div>
                        <div style="margin-left: 5px;">
                            <div class="col-md-4">Hotline: </div>
                            <div class="col-md-8">
                                <span style="color: yellow;">
                                    <strong>
                                        <asp:Literal runat="server" ID="litNTD_Hotline" />
                                    </strong>
                                </span>
                                <div class="clear"></div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4">Email: </div>
                            <div class="col-md-8"><%=CMS.flCheck.SetupValue(0, "NTD_Email") %>  </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6 pdbt10 pdr0  bgw pd10">
                <div class="hotline-box pd10">
                    <div class="tuyendung">
                        <div class=" txt-laodong ">
                            <p>HỖ TRỢ NGƯỜI TÌM VIỆC</p>
                        </div>
                        <div style="margin-left: 5px;">
                            <div class="col-md-4">Hotline:</div>
                            <div class="col-md-8">
                                <span style="color: yellow;">
                                    <strong>
                                        <asp:Literal runat="server" ID="litNLD_Hotline" />
                                    </strong>
                                </span>
                                <div class="clear"></div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4">Email:   </div>
                            <div class="col-md-8"><%=CMS.flCheck.SetupValue(0, "NLD_Email") %></div>
                            <div class="clear"></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>
    </div>
    <div class="container ">
        <div class="col-md-6">
            <asp:Literal ID="litFooter" runat="server"></asp:Literal>
        </div>

        <div class="col-md-6">
            <div class="row pd30">
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
    <div class="text-white-50 border-top p-0">
        <div class="container">
            <div class="row d-flex">
                <div class="col-lg-8 col-sm-12  mt-2 mb-2 text-start ">Copyright © 2019 <a href="/" class="fs-14 text-white">vieclamnamdinh.gov.vn </a>. Designed with <span class="fa fa-heart text-danger"></span> by <a href="/" class="fs-14 text-white">Trung Tâm Việc Làm Tỉnh Nam Định</a> All rights reserved. </div>
                <div class="col-lg-4 col-sm-12 ms-auto mb-2 mt-2 d-none d-lg-block">
                    <ul class="social mb-0">
                        <li><a class="social-icon" href=""><i class="fa fa-facebook"></i></a></li>
                        <li><a class="social-icon" href=""><i class="fa fa-twitter"></i></a></li>
                        <li><a class="social-icon" href=""><i class="fa fa-rss"></i></a></li>
                        <li><a class="social-icon" href=""><i class="fa fa-youtube"></i></a></li>
                        <li><a class="social-icon" href=""><i class="fa fa-linkedin"></i></a></li>
                        <li><a class="social-icon" href=""><i class="fa fa-google-plus"></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="text-white p-0 border-top">
        <div class="container">
            <div class="p-2 text-center footer-links">
                <asp:Literal ID="ltWeblink" runat="server" />
            </div>
        </div>
    </div>
</footer>
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
        <img src="http://file.eportal.top/data/0/images/2023/12/04/host/logo.png" />
    </div>
</div>

<div id="box_chat_div" class="none dt" style="position: fixed; bottom: 5px; right: 20px; z-index: 18000001;">
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
    window.onscroll = function () { myOnscroll() };
    var header = $('.vbanner');
    var sticky = header.offsetTop;
    function myOnscroll() {
        if (window.pageYOffset > sticky) {
            header.addClass("sticky");
        } else {
            header.removeClass("sticky");
        }
    }
    $(window).scroll(function (e) {
        $el = $('.vbanner');
        $el.toggleClass('sticky', $(this).scrollTop() > 0);
    });
</script>
