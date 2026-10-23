<%@ Control Language="vb" AutoEventWireup="true" CodeFile="HomePage.ascx.vb" Inherits="Modules.HomePage.View" %>
<%@ Register Src="~/DesktopModules/Module/Home/AdminLogin.ascx" TagPrefix="uc1" TagName="AdminLogin" %>
<%@ Register Src="~/DesktopModules/Module/DIC/User/ResetPass.ascx" TagPrefix="uc1" TagName="ResetPass" %>

    
<div class="bg-bigtech">
    <div class="container bg-bhtn">
        <div class="row"></div>
        <div class="row">
            <div class="col-md-12 pdr0">
                <div class="search-box">
                    <uc1:AdminLogin runat="server" ID="AdminLogin" />
                    <uc1:ResetPass runat="server" ID="ResetPass" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>
<script type="text/javascript">$(function () { document.title = "<%=homeTitle%>"; });</script>
