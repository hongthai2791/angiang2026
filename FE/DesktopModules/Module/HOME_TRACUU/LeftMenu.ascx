<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="LeftMenu.ascx.vb" Inherits="DesktopModules.Modules.Home.LeftMenu" %>
 
<script type="text/javascript">
    var path = location.pathname;
    $('.main-menu li').each(function (index) { var link = $(this).find('a').attr('href'); if (path == link) { $(this).addClass('active'); $(this).find('a').css("color", "#333"); } });
    var an = true, w = 360; if ($(window).width() < 350) { w = $(window).width() - 80; } else if ($(window).width() < 767) { w = $(window).width() - 65; }
    function searchclick() { if (an == true) { $('#seach-box').show().animate({ width: w, left: -(w + 10) }); $('#seach-box').focus(); an = false; } else { if ($("#seach-box").val() != "") { doSearchSite("seach-box"); return false; } else { $('#seach-box').animate({ left: 0, width: 0 }).hide(); an = true; } } };
</script>
