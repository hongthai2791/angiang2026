<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="MenuMain.ascx.vb" Inherits="DesktopModules.Modules.Home.MenuMain" %>
<%@ Register TagPrefix="CNS" TagName="MENUMOBILE" Src="~/DesktopModules/Module/Home/MenuMobile.ascx" %>
<%@ Register TagPrefix="CNS" TagName="MENUHOME" Src="~/DesktopModules/Module/Home/MenuHome.ascx" %>
<%@ Register Src="~/DesktopModules/Module/Home/MenuTop.ascx" TagPrefix="TN" TagName="MenuTop" %>
<style>
    /*.hidden-login .navbar {
        margin-bottom: -1px;
    }

    .vbanner {
        background: #042E51;
    }

        .vbanner .main-menu ul > li > a {
            color: #fff;
        }

        .vbanner .phone-contact a {
            color: #fff !important;
        }

        .vbanner .cc-blwh {
            color: #fff
        }*/
    .pushy > ul > li > ul > li > a {
        text-align: left;
    }

    .pushy > ul > li > a {
        text-align: left;
    }
</style>

<a id="ctlView" runat="server" class="an1cai sidebar-toggle ctlview"><i class="fa fa-chevron-right" aria-hidden="true"></i></a>
<div class="menu-top">
    <div class="container">
        <div class="col-md-6 hidden-xs">
            <i class="fa fa-phone"></i>&nbsp;<%=EPORTAL.flReg.WebConfig("Hotline") %>&nbsp;&nbsp;
            <i class="fa fa-envelope-o "></i>&nbsp;Email: <%=EPORTAL.flReg.WebConfig("Email") %>
        </div>
        <div class="col-md-6 col-xs-12 right-box">
           <asp:Literal runat="server" id="ltAccount"></asp:Literal>
            
            <a href="/lien-he" class="btnLienHe" title="Liên hệ"><i class="fa fa-user-plus"></i> Liên hệ</a>
            <CNS:MENUMOBILE runat="server" ID="MenuMobile" />
        </div>
    </div>

</div>
<div class="vbanner">
    <div class="container">
        <div class="row">
            <div class="col-md-3 col-xs-12">
                <asp:Literal ID="litBanner" runat="server" />
                <div class="clear"></div>
            </div>
            <div class="col-md-9 vmenu">

                <div class="clear"></div>
                <CNS:MENUHOME ID="MENUHOME" runat="server" />
                <div class="clear"></div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var path = location.pathname;
    $('.main-menu li').each(function (index) { var link = $(this).find('a').attr('href'); if (path == link) { $(this).addClass('active'); $(this).find('a').css("color", "#333"); } });
    var an = true, w = 360; if ($(window).width() < 350) { w = $(window).width() - 80; } else if ($(window).width() < 767) { w = $(window).width() - 65; }
    function searchclick() { if (an == true) { $('#seach-box').show().animate({ width: w, left: -(w + 10) }); $('#seach-box').focus(); an = false; } else { if ($("#seach-box").val() != "") { doSearchSite("seach-box"); return false; } else { $('#seach-box').animate({ left: 0, width: 0 }).hide(); an = true; } } };
</script>
