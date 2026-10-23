<%@ Control Language="C#" Inherits="DotNetNuke.Modules.Admin.Authentication.DNN.Login" AutoEventWireup="false" CodeBehind="Login.ascx.cs" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.UI.WebControls.Internal" Assembly="DotNetNuke.Web" %>
<link href="/Portals/_default/Skins/vbn/css/login.css" rel="stylesheet" />
<div class="dnnForm dnnLoginService dnnClear">
    <div class="box-login">
        <div class="box-login-logo">
            <h3>ĐĂNG NHẬP</h3>
        </div>
        <div class="dnnFormItem">
            <div class="dnnLabel none">
                <asp:Label ID="plUsername" AssociatedControlID="txtUsername" runat="server" CssClass="dnnFormLabel" />
            </div>
            <div class="i-control">
                <i class="fa fa-user" aria-hidden="true"></i>
                <asp:TextBox ID="txtUsername" autocomplete="off" CssClass="login-control" PlaceHolder="Tài khoản" runat="server" />
            </div>
        </div>
        <div class="dnnFormItem ">
            <div class="dnnLabel none">
                <asp:Label ID="plPassword" AssociatedControlID="txtPassword" runat="server" resourcekey="Password" CssClass="dnnFormLabel" ViewStateMode="Disabled" />
            </div>
            <div class="i-control">
                <i class="fa fa-unlock-alt" aria-hidden="true"></i>
                <asp:TextBox ID="txtPassword" autocomplete="off" TextMode="Password" PlaceHolder="Mật khẩu" CssClass="login-control" runat="server" />
            </div>
        </div>
        <div class="dnnFormItem" id="divCaptcha1" runat="server" visible="false">
            <asp:Label ID="plCaptcha" AssociatedControlID="ctlCaptcha" runat="server" resourcekey="Captcha" CssClass="dnnFormLabel" />
        </div>
        <div class="dnnFormItem dnnCaptcha" id="divCaptcha2" runat="server" visible="false">
            <dnn:CaptchaControl ID="ctlCaptcha" CaptchaWidth="130" CaptchaHeight="40" runat="server" ErrorStyle-CssClass="dnnFormMessage dnnFormError dnnCaptcha" ViewStateMode="Disabled" />
        </div>
        <div class="dnnFormItem" style="text-align: center;">
            <asp:Label ID="lblLogin" runat="server" AssociatedControlID="cmdLogin" Visible="false" CssClass="dnnFormLabel" ViewStateMode="Disabled" />
            <asp:LinkButton ID="cmdLogin" resourcekey="cmdLogin" CssClass="dnnPrimaryAction cmd-login" Text="Login" runat="server" CausesValidation="false" />
            <asp:HyperLink ID="cancelLink" runat="server" CssClass="dnnSecondaryAction none" resourcekey="cmdCancel" CausesValidation="false" />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/home/page/reset-password" CssClass="dnnSecondaryAction cmd-pasword" resourcekey="cmdPassword" ViewStateMode="Disabled" />
        </div>
        <div class="dnnFormItem none">
            <asp:Label ID="lblLoginRememberMe" runat="server" CssClass="dnnFormLabel" />
            <span class="dnnLoginRememberMe">
                <asp:CheckBox ID="chkCookie" resourcekey="Remember" runat="server" /></span>
        </div>
        <div class="dnnFormItem none">
            <span class="dnnFormLabel">&nbsp;</span>
            <div class="dnnLoginActions">
                <ul class="dnnActions dnnClear">
                    <li id="liRegister" runat="server">
                        <asp:HyperLink ID="registerLink" runat="server" CssClass="dnnSecondaryAction" resourcekey="cmdRegister" ViewStateMode="Disabled" /></li>
                    <li>
                        <asp:HyperLink ID="passwordLink" runat="server" CssClass="dnnSecondaryAction cmd-pasword" resourcekey="cmdPassword" ViewStateMode="Disabled" />
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
<dnn:DnnScriptBlock runat="server">
    <script type="text/javascript">
        (function ($, Sys) {
            function setUpLogin() {
                var actionLinks = $("a#dnn_ctr<%=ModuleId > Null.NullInteger ? ModuleId.ToString() : ""%>_Login_Login_DNN_cmdLogin");
                actionLinks.click(function () { if ($(this).hasClass("dnnDisabledAction")) { return false; } actionLinks.addClass("dnnDisabledAction"); });
            }
            $(document).ready(function () {
                document.title = "Hệ thống Cổng thông tin điện tử";
                $(document).on('keydown', '.dnnLoginService', function (e) {
                    if ($(e.target).is('input:text,input:password') && e.keyCode === 13) {
                        var $loginButton = $('#dnn_ctr<%=ModuleId > Null.NullInteger ? ModuleId.ToString() : ""%>_Login_Login_DNN_cmdLogin');
                        if ($loginButton.hasClass("dnnDisabledAction")) { return false; }
                        $loginButton.addClass("dnnDisabledAction"); window.setTimeout(function () { eval($loginButton.attr('href')); }, 100); e.preventDefault(); return false;
                    }
                });
                setUpLogin();
                Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () { setUpLogin(); });
            });
        }(jQuery, window.Sys));
    </script>
</dnn:DnnScriptBlock>
