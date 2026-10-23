<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Active.ascx.vb" Inherits="Modules.MemberActive.View" %>
<%@ Register Src="~/admin/Captcha/VbCapchar.ascx" TagPrefix="uc1" TagName="VbCapchar" %>
<div class="dnnClear">
    <div class="login-top-header ">
             <asp:Literal ID="litLogo" runat="server"></asp:Literal>
    </div>
    <div class="grid login-grid">
        <asp:Literal ID="litRes" runat="server" />
        <asp:Panel ID="pnew" runat="server">
            <div class="member-login-title">
                <h3>Kích hoạt tài khoản thành viên đăng ký</h3>
            </div>
            <div style="font-family: Tahoma; font-size: 16px; width: 100%; line-height: 24px; margin: 30px auto; margin-bottom: 30px;">
                <br />
                <div style="padding-bottom: 10px">Cảm ơn bạn đã đăng ký mở tài khoản tại <%=EPORTAL.flReg.WebConfig("works") %></div>
                <div style="padding-bottom: 10px">
                    Bạn đã kích hoạt tài khoản tại  <%=EPORTAL.flReg.WebConfig("works") %> thành công. Vui lòng bấm vào đây để <a href="<%=EPORTAL.flReg.UrlAlias %>" title="Đăng nhập vào hệ thống">đăng nhập</a> vào hệ thống.
                </div>
            </div>
            <div style="font-family: Tahoma; font-size: 18px; text-align: right; width: 90%; margin: 0 auto; margin-bottom: 30px;">
                <div style="padding-bottom: 10px">Trân trọng!</div>
                Ban quản trị 
            </div>
        </asp:Panel>
    </div>
</div>
<link href="/portals/_default/skins/vbn/css/member.css?v=4.6.0.3.3.0" rel="stylesheet" />
