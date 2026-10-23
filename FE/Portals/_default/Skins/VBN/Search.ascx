<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/Home/MenuMain.ascx" TagPrefix="uc1" TagName="Nav" %>
<%@ Register Src="~/DesktopModules/Module/Home/Footer.ascx" TagPrefix="Footer" TagName="Footer" %>
<%@ Register Src="~/DesktopModules/Module/Home/FindMode.ascx" TagPrefix="FindMode" TagName="FindMode" %>
<%@ Register Src="~/DesktopModules/Module/Sitemap/cssDefault.ascx" TagPrefix="FindMode" TagName="cssDefault" %>

<link href="/Portals/_default//Resource/font-awesome/css/font-awesome.min.css?v=5.0.0.7" rel="stylesheet" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
<FindMode:cssDefault runat="server" ID="cssDefault" />
<div class="body">
    <uc1:Nav runat="server" ID="Nav" />
    <div class="container hidden-login">
        <div class="row">
            <div class="col-md-12">
                <div class="default-contain"></div>
            </div>
            <div class="clear"></div>
            <div class="col-md-8" runat="server">
                <div id="leftPane_Search" runat="server"></div>
            </div>
            <div class="col-md-4" runat="server">
                <div id="rightPane_Search" runat="server"></div>
            </div>
            <div class="clear"></div>
            <div id="ContentPane" runat="server"></div>
            <div class="clear"></div>
        </div>
    </div>
    <div style="clear: both"></div>
    <div class="footter">
        <Footer:Footer runat="server" ID="Footer" />
    </div>
</div>
<FindMode:FindMode runat="server" ID="FindMode" />
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript">
    $(document).ready(function () { pageLoad(); });function changeUrl(newUrl) { window.history.pushState('', document.title, newUrl); };
    function pageLoad() { $('.selectpicker').selectpicker({ liveSearch: true }); };
</script>