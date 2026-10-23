<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeVideo.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeVideo" %>
<%@ Register Src="~/DesktopModules/Module/Home/HomeNews.ascx" TagPrefix="uc1" TagName="HomeNews" %>

<style>
    .i-content-video {
        border-radius: 5px;
        box-shadow: 0px 1px 4px 0px rgba(0, 0, 0, 0.25);
    }

    .icon-video {
        position: absolute;
        left: calc(50% - 19px);
        top: calc(50% - 40px);
        color: #fff;
        font-size: 23px;
        transition: 200ms;
        -moz-transition: all ease-in-out 300ms;
        opacity: 0;
        border: 2px solid #fff;
        padding: 5px 8px 5px 8px;
        border-radius: 500%;
    }

    .box-new-img-video img {
        height: 155px;
        width: 100%;
        max-width: 100%;
    }

    .home-box-news-video p {
        font-family: Roboto-Bold;
        padding: 5px 10px;
        text-align: left;
        font-size: 15px;
        margin-bottom: 0px;
        color: #3C65F5;
        height: 50px;
        overflow: hidden;
        font-weight: 500;
        background-color: #f5f3f3;
    }
    .home-box-news-video p:hover{
         color: #05264E;
    }

    .home-box-news-video:hover .icon-video {
        opacity: 1;
    }

    .home-box-news-video:hover {
        transform: scale(1.01);
    }

    .box-w-title-video {
        width: 850px;
        margin-right: auto;
        margin-left: auto;
        padding-bottom: 5px;
    }

    .nav-pills > li {
        text-align: center !important;
    }

        .nav-pills > li.active > a {
            background-color: white !important;
            font-size: 20px !important;
            color: black !important;
            font-family: 'Roboto-Medium' !important;
            border-bottom: 5px solid #ea4848;
        }

        .nav-pills > li > a {
            border-radius: 0px !important;
        }

        .nav-pills > li > a {
            background-color: white !important;
            font-size: 20px !important;
            font-family: Roboto-Regular !important;
        }

    .alignment {
        border-bottom: 2px solid #e3e3e3;
        margin: 20px 5px;
    }

    .width-Distance {
        width: 250px;
        margin-right: auto;
    }
</style>
<div class="bg-white ">
    <div class="container pd10" style="position: relative">
        <div class="col-md-6 bg-main pd10" style="position: relative">
            <div class="cate-title">
                <h4><a style="display: inline-block" href="/video" title="Video"><i class="fa fa-video-camera "></i>&nbsp;Video
                </a></h4>
            </div>
            <asp:Literal ID="litNews" runat="server" Text="Video giới thiệu"></asp:Literal>
            <div class="link-readmore mgt10">
                <a href="/video"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a>
            </div>
        </div>

        <div class="col-md-6 ">
            <uc1:HomeNews runat="server" ID="HomeNews" />
            <div class="link-readmore">
                <a href="/cam-nang-nghe-nghiep"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a>
            </div>
        </div>
    </div>
</div>

