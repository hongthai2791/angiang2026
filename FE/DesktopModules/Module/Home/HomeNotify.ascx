<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeNotify.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeBanner" %>
<%@ Register Src="~/DesktopModules/Module/Home/HomeBannerTop.ascx" TagPrefix="uc1" TagName="HomeBannerTop" %>
<%@ Register Src="~/DesktopModules/Module/Home/HotNews.ascx" TagPrefix="uc1" TagName="HotNews" %>

<style>
    .new-titlecc {
        font-size: 14px;
        font-family: Roboto-Medium;
    }

    .New-tt {
        color: #d02525;
        background-color: #f7ec2b;
        padding: 1px 5px;
        border-radius: 3px;
    }

    .home-notify {
        text-align: center;
    }

        .home-notify h4 {
            text-align: left;
        }

            .home-notify h4 a {
                font-family: Roboto-Medium;
                font-size: 20px;
                margin-bottom: 30px;
                color: #000;
                text-transform: uppercase
            }

    .cont-size a {
        font-size: 14px;
    }

    .conten-nd-tt {
        overflow: hidden;
        height: 170px;
        text-align: justify;
        padding: 0px 10px;
    }

    .conten-title-tt {
        font-weight: bold;
        text-align: left !important;
    }

    .conten-sumary {
        font-size: 14px;
        padding: 5px 0px;
    }

    .conten-sumary-tt a i {
        color: #2cade3;
        padding-right: 5px;
    }

    .prev-HomeBanner-tt {
        top: calc(70% - 0px);
        left: -17px;
        opacity: .6;
        display: block;
        width: 50px;
        height: 50px;
        border-radius: 50%;
        position: absolute;
        z-index: 9;
    }

    .next-HomeBanner-tt {
        top: calc(70% - 0px);
        right: 0;
        opacity: .6;
        display: block;
        width: 40px;
        height: 40px;
        border-radius: 50%;
        position: absolute;
        z-index: 9;
    }

    .prev-HomeBanner-tt i {
        font-size: 30px;
        color: black;
        text-align: center;
        padding: 5px 15px;
        cursor: pointer;
    }

    .next-HomeBanner-tt i {
        font-size: 30px;
        color: black;
        text-align: center;
        padding: 5px 15px 5px 35px;
        cursor: pointer;
    }
</style>
<div class=" row  mar-news">
        <asp:Literal ID="litNew" runat="server"></asp:Literal>
</div>
<div class="container home-notify bg-main pd10" style="position: relative">
    <%--<uc1:HomeBannerTop runat="server" ID="HomeBannerTop" />--%>
    <uc1:HotNews runat="server" ID="HotNews" />
</div>

