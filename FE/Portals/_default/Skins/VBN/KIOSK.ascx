<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/Sitemap/cssDefault.ascx" TagPrefix="BT" TagName="cssDefault" %>
<%@ Register Src="~/DesktopModules/Module/HOME_TRACUU/MAIN.ascx" TagPrefix="BT" TagName="MAIN" %>






<link href="/Portals/_default/Resource/font-awesome/css/font-awesome.min.css?v=5.0.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.carousel.min.css?v=5.1.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.theme.default.min.css?v=5.1.0.9" rel="stylesheet" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
<link href="/Portals/_default/Skins/VBN/css/kiosk.css?v=1.0.0.1" rel="stylesheet" />
<BT:cssDefault runat="server" ID="cssDefault" />
   <div class="waiting none" style="z-index:999999">
       <img style="top: 38%; left: calc(50% - 76px); position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
   </div>
<div class="body ">
        <div class="header">
        <div class="kiosk-banner">
            <img src="../../../image/logoangiang_2025.png" />
</div>
    </div>
    <div class="col-md-12">
    <div id="ContentPane" runat="server"></div>
    </div>
</div>
<script src="/portals/_default/resource/owlcarousel/owl.carousel.min.js?v=5.0.0.9"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>

<script type="text/javascript">
    function removewaiting() { $(".waiting").addClass("none") }; function waiting() { $(".waiting").removeClass("none") };
</script>