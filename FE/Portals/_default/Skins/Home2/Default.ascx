<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<%@ Register Src="~/DesktopModules/Module/Home/MenuMain.ascx" TagPrefix="BT" TagName="MenuMain" %>
<%@ Register Src="~/DesktopModules/Module/Home/Footer.ascx" TagPrefix="BT" TagName="Footer" %>
<%@ Register Src="~/DesktopModules/Module/Home/FindMode.ascx" TagPrefix="BT" TagName="FindMode" %>
<%@ Register Src="~/DesktopModules/Module/News/NewsMain.ascx" TagPrefix="BT" TagName="NewsMain" %>
<%@ Register Src="~/DesktopModules/Module/Sitemap/cssDefault.ascx" TagPrefix="BT" TagName="cssDefault" %>
<%@ Register Src="~/DesktopModules/Module/Home/BreadCrumb.ascx" TagPrefix="BT" TagName="BreadCrumb" %>
<%@ Register Src="~/DesktopModules/Module/Work/SearchJobUser.ascx" TagPrefix="BT" TagName="SearchJobUser" %>
<%@ Register Src="~/DesktopModules/Module/Work/SearchWorks.ascx" TagPrefix="BT" TagName="SearchWorks" %>
<%@ Register Src="~/DesktopModules/Module/Work/WorksNews.ascx" TagPrefix="BT" TagName="WorksNews" %>

<link href="/Portals/_default//Resource/font-awesome/css/font-awesome.min.css?v=5.0.0.9" rel="stylesheet" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
<BT:cssDefault runat="server" ID="cssDefault" />
<div class="body default">
    <div class="hidden-login">
        <div class="header navbar navbar-static-top bs-docs-nav">
            <BT:MenuMain runat="server" ID="MenuMain" />
        </div>
        <div class="container ">
            <BT:BreadCrumb runat="server" ID="BreadCrumb" />
            <div class="row">
                <div class="col-md-12">
                    <div id="ContentPane" runat="server"></div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-8 box-left">
                    <BT:NewsMain runat="server" ID="NewsMain" />
                    <div class="clear"></div>
                    <div id="LeftContent" runat="server"></div>
                </div>
                <div class="col-md-4">
                    <BT:SearchJobUser runat="server" ID="SearchJobUser" />
                    <div class="clear"></div>
                    <BT:SearchWorks runat="server" ID="SearchWorks" />
                    <div class="clear"></div>
                    <BT:WorksNews runat="server" ID="WorksNews" />
                    <div class="clear"></div>
                    <div id="RightContent" runat="server"></div>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
        <BT:Footer runat="server" ID="Footer" />
    </div>
</div>
<BT:FindMode runat="server" ID="FindMode" />

<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>

<script src="/js/validation/nicescroll.js?v=5.0.0.9"></script>
<script type="text/javascript">
    $(document).ready(function () { pageLoad(); });function changeUrl(newUrl) { window.history.pushState('', document.title, newUrl); };
    function pageLoad() { $('.selectpicker').selectpicker({ liveSearch: true }); };
</script>