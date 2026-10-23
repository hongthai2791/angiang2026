<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="MenuMain.ascx.vb" Inherits="DesktopModules.Modules.Home.MenuMain" %>
<%@ Register TagPrefix="CNS" TagName="MENUMOBILE" Src="~/DesktopModules/Module/HOME_MAP/MenuMobile.ascx" %>
<%@ Register TagPrefix="CNS" TagName="MENUHOME" Src="~/DesktopModules/Module/HOME_MAP/MenuHome.ascx" %>
<%@ Register Src="~/DesktopModules/Module/Home/MenuTop.ascx" TagPrefix="TN" TagName="MenuTop" %>
<style>
    .pushy > ul > li > ul > li > a {
        text-align: left;
    }

    .pushy > ul > li > a {
        text-align: left;
    }
</style>

<a id="ctlView" runat="server" class="an1cai sidebar-toggle ctlview"><i class="fa fa-chevron-right" aria-hidden="true"></i></a>
<div class="menu-top" runat="server" id="divSupperAccount" visible="false" >
    <div class="container">
        <div class="col-md-6 col-xs-12 right-box">
           <asp:Literal runat="server" id="ltAccount"></asp:Literal>
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
            <CNS:MENUMOBILE runat="server" ID="MenuMobile" />

    </div>
</div>
<script type="text/javascript">
    var path = location.pathname;
    $('.main-menu li').each(function (index) { var link = $(this).find('a').attr('href'); if (path == link) { $(this).addClass('active'); $(this).find('a').css("color", "#333"); } });
    var an = true, w = 360; if ($(window).width() < 350) { w = $(window).width() - 80; } else if ($(window).width() < 767) { w = $(window).width() - 65; }
    function searchclick() { if (an == true) { $('#seach-box').show().animate({ width: w, left: -(w + 10) }); $('#seach-box').focus(); an = false; } else { if ($("#seach-box").val() != "") { doSearchSite("seach-box"); return false; } else { $('#seach-box').animate({ left: 0, width: 0 }).hide(); an = true; } } };
</script>
