<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>

<%@ Register Src="~/DesktopModules/Module/Home/Footer.ascx" TagPrefix="BT" TagName="Footer" %>
<%@ Register Src="~/DesktopModules/Module/Home/FindMode.ascx" TagPrefix="BT" TagName="FindMode" %>
<%@ Register Src="~/DesktopModules/Module/Sitemap/cssDefault.ascx" TagPrefix="BT" TagName="cssDefault" %>
<%@ Register Src="~/DesktopModules/Module/Home/BreadCrumb.ascx" TagPrefix="BT" TagName="BreadCrumb" %>
<%@ Register Src="~/DesktopModules/Module/Home/Lienhe.ascx" TagPrefix="BT" TagName="Lienhe" %>
<%@ Register Src="~/DesktopModules/Module/Home/LienHeCongTy.ascx" TagPrefix="BT" TagName="LienHeCongTy" %>
<%@ Register Src="~/DesktopModules/Module/Home/MenuMain.ascx" TagPrefix="BT" TagName="MenuMain" %>

<link href="/Portals/_default/Resource/font-awesome/css/font-awesome.min.css?v=5.0.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.carousel.min.css?v=5.1.0.9" rel="stylesheet" />
<link href="/portals/_default/resource/owlcarousel/assets/owl.theme.default.min.css?v=5.1.0.9" rel="stylesheet" />
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
                   
                <div class="col-md-8 contact-left">
                     <BT:Lienhe runat="server" id="Lienhe" />
                    <div class="clear"></div>
                    <div id="ContentPane" runat="server"></div>
                </div>
                
                <div class="col-md-4 contact-right">
                    <BT:LienHeCongTy runat="server" id="LienHeCongTy" />
                </div>
          
          </div>
            <div class="row">
                
               
            </div>

                <div class="col-md-8">
                   
                    <div id="LeftContent" runat="server"></div>
                </div>
                <div class="col-md-4">
                </div>
                <div class="clear"></div>
            </div>
        </div>
        <BT:Footer runat="server" ID="Footer" />
    </div>

<BT:FindMode runat="server" ID="FindMode" />

<script src="/js/validation/nicescroll.js?v=5.0.0.9"></script>
<script src="/portals/_default/resource/owlcarousel/owl.carousel.min.js?v=5.0.0.9"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>

<script src="/js/validation/nicescroll.js?v=5.0.0.9"></script>
<script type="text/javascript">
    $(document).ready(function () { pageLoad(); });function changeUrl(newUrl) { window.history.pushState('', document.title, newUrl); };
    function pageLoad() { $('.selectpicker').selectpicker({ liveSearch: true }); };
</script>
