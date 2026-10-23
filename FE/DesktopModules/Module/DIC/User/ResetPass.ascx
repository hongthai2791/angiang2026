<%@ Control Language="vb" CodeFile="ResetPass.ascx.vb" ClientIDMode="Static" Inherits="DotNetNuke.EPORTAL.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="upResetPass" runat="server" Visible="false">
    <ContentTemplate>
        <div class="login-box animated fadeInDown">
            <div class="login-box-left"></div>
            <div class="login-box-top"></div>
            <div class="login-box-cont">
                <div class="login-box-body">
                    <div class="login-box-cont-left"></div>
                    LẤY LẠI MẬT KHẨU
                     <div class="input-group pdt20">
                         <div class="input-group-addon">
                             <i class="fa fa-user" aria-hidden="true"></i>
                         </div>
                         <asp:TextBox runat="server" ID="LogEmail" onkeyup="resetlabel();" CssClass="bt-control LogEmail" autocomplete="off" TabIndex="8" onkeypress="return clickButton(event)" placeholder="Email, tài khoản đăng nhập"></asp:TextBox>
                     </div>
                    <div class="dnnFormItem input-group">
                        <div class="i-control ">
                            <asp:Literal ID="lbmsg" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="row" style="margin-top: 20px;">
                        <div class="col-md-6">
                            <asp:Button ID="cmdReset" runat="server" TabIndex="23" CssClass="btn btn-primary btn-block full-width m-b bblue" Text="Khôi phục mật khẩu"></asp:Button>
                        </div>
                        <div class="col-md-6">
                            <asp:Button ID="cmdBack" runat="server" TabIndex="24" CssClass="btn btn-primary btn-block full-width m-b bcan" Text="Hủy bỏ"></asp:Button>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear"></div>
                    <div class="login-box-cont-right"></div>
                </div>
            </div>
            <div class="login-box-right"></div>
        </div>
        <div class="clear"></div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdReset" />
    </Triggers>
</asp:UpdatePanel>
<script type="text/javascript">
    function ReloadSite(s) { setTimeout(function () { location.reload(); }, s); }; function resetlabel() { $(".lbg").html(""); };
</script>

