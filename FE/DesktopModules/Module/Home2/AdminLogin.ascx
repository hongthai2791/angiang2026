<%@ Control Language="vb" AutoEventWireup="true" CodeFile="AdminLogin.ascx.vb" Inherits="Modules.AdminLogin.View" %>
<link href="/Portals/_default/Skins/vbn/css/loginnew.css?v=1.1" rel="stylesheet" />
<asp:Panel runat="server" ID="plogin" class="dnnForm dnnLoginService dnnClear">
    <div class="login-box animated fadeInDown">
        <div class="login-box-cont">
            <div class="login-box-body">
               <div style="text-align: center; font-size:50px;color:#fff">
                   <i class="fa fa-sign-in"></i>
                </div>
               <div class="login-header"> ĐĂNG NHẬP HỆ THỐNG </div>
                <%--<h5>(EPORTAL v2.0)</h5>--%>
                <span class="label">Tên tài khoản</span>
                <div class="input-group">
                  
                    <asp:TextBox ID="txtUsername" CssClass="bt-control" PlaceHolder="Tài khoản" runat="server" />
                </div>
                <span class="label">Mật khẩu</span>
                <div class="input-group">
                   
                    <asp:TextBox ID="txtPassword" TextMode="Password" PlaceHolder="Mật khẩu" CssClass="bt-control" runat="server" />
                </div>
                <div class="dnnFormItem input-group">
                    <div class="i-control ">
                        <asp:Literal ID="lbmsg" runat="server"></asp:Literal>
                    </div>
                </div>
                <div class="dnnFormItem" style="text-align: center; padding-top: 10px">
                    <asp:LinkButton ID="cmdLogin" resourcekey="cmdLogin" CssClass="btn btn-primary btn-block full-width m-b bblue" Text="Đăng nhập" runat="server" CausesValidation="false" />
                    <div class="forgot-pass">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/home/page/reset-password" resourcekey="cmdPassword" Text="Quên mật khẩu" />&nbsp;<i class="fa fa-question-circle"></i>
                    </div>
                </div>
                <asp:Label ID="lblLogin" runat="server" AssociatedControlID="cmdLogin" Visible="false" CssClass="dnnFormLabel" ViewStateMode="Disabled" />
                <div class="clear"></div>
                <div class="login-box-cont-right"></div>
            </div>
        </div>
        <div class="login-box-right"></div>
    </div>
</asp:Panel>
<script type="text/javascript">

    function clickButton(e, t) { var n = e ? e : window.event; var r = document.getElementById(t); if (r) { if (n.keyCode == 13) { r.click(); return false } } }
</script>
