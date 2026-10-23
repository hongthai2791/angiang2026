<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/Home/MenuMain.ascx" TagPrefix="BT" TagName="MenuMain" %>
<%@ Register Src="~/DesktopModules/Module/Home/Footer.ascx" TagPrefix="BT" TagName="Footer" %>
<%@ Register Src="~/DesktopModules/Module/Home/FindMode.ascx" TagPrefix="BT" TagName="FindMode" %>
<%@ Register Src="~/DesktopModules/Module/News/VideoList.ascx" TagPrefix="BT" TagName="VideoList" %>
<%@ Register Src="~/DesktopModules/Module/Sitemap/cssDefault.ascx" TagPrefix="BT" TagName="cssDefault" %>

<link href="/Portals/_default//Resource/font-awesome/css/font-awesome.min.css?v=5.1.0.9" rel="stylesheet" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />

<BT:cssDefault runat="server" ID="cssDefault" />
<div class="body">
    <div class="hidden-login">
        <div class="header navbar navbar-static-top bs-docs-nav">
            <BT:MenuMain runat="server" ID="Nav" />
        </div>
        <div class="container">
            <div class="row">
                <div id="ContentPane" runat="server"></div>
                <div class="col-md-12">
                    <div class="default-contain"></div>
                </div>
                <div class="col-md-12">
                    <BT:VideoList runat="server" ID="VideoList" />
                </div>
            </div>
        </div>
        <BT:Footer runat="server" ID="Footer" />
    </div>
</div>

<BT:FindMode runat="server" ID="FindMode" />
<script src="/js/scrollbar/jquery.mCustomScrollbar.concat.min.js?v=5.0.0.9"></script>
<script src="/js/scrollbar/jquery.mCustomScrollbar.min.js?v=5.0.0.9"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
