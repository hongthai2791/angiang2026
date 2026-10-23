<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="Footer.ascx.vb" Inherits="DesktopModules.Home.Footer" %>
<%@ Register Src="~/admin/Captcha/VbCapchar.ascx" TagPrefix="uc1" TagName="VbCapchar" %>

<script>
    window.fbAsyncInit = function () { FB.init({ xfbml: true, version: 'v4.0' }); };
    (function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (d.getElementById(id)) return; js = d.createElement(s); js.id = id; js.src = 'https://connect.facebook.net/en_US/sdk/xfbml.customerchat.js'; fjs.parentNode.insertBefore(js, fjs); }(document, 'script', 'facebook-jssdk'));
</script>



