<%@ Control Language="vb" CodeFile="ResetPass.ascx.vb" ClientIDMode="Static" Inherits="DotNetNuke.EPORTAL.View" AutoEventWireup="false" Explicit="True" %>
<div class="col-md-12 box-login pdr0 pd30">
    <div class="grid login-grid">
    <div class="text-primary">
                <h2 class="large b">Lấy lại mật khẩu!</h2>
            </div>
        <div class="row pdt10">

        <div class="col-md-6" >
            <div class="col-md-12" style="margin-bottom: 10px;">
                <p>Vui lòng cung cấp Email đã đăng ký</p>
                <asp:TextBox runat="server" ID="LogEmail" CssClass="form-control TextInput login-control validate[required]" autocomplete="off" TabIndex="8" onkeypress="return clickButton(event)" placeholder="Email, tài khoản đăng nhập"></asp:TextBox>
                
        <div class="row lbg">
            <asp:Literal ID="lbMsg" runat="server" />
        </div>
        <div class="row" style="margin-top: 20px;">
            <div class="col-md-6">
                <asp:Button ID="cmdReset" runat="server" TabIndex="23" OnClientClick="return retunwaiting();"  CssClass="btn btn-danger btn-block full-width m-b bblue" Text="Khôi phục mật khẩu"></asp:Button>
            </div>
            <div class="col-md-6">
                <asp:Button ID="cmdBack" runat="server" TabIndex="24" OnClientClick="return $('#Form').validationEngine('detach');" CssClass="btn btn-default btn-block full-width m-b bcan" Text="Hủy bỏ"></asp:Button>
            </div>
        </div>
            </div>

        </div>
              <div class="col-md-6 pd30 right-login">
       <h2 class="large">Hướng dẫn khôi phục mật khẩu !</h2>
        <ul class="orange-cl purpose pd30">
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Nhập đúng email bạn đã dùng để đăng ký tài khoản</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Kiểm tra thư hệ thống gửi trong hộp thư đến hoặc thư mục spam của email</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Làm theo hướng dẫn trong nội dung email</li>
        </ul>
    </div>
        </div>
    </div>
</div>
<script type="text/javascript" src="/resources/Shared/scripts/jquery/jquery.min.js?v=4.6.0.3.3.0"></script>
<link href="/portals/_default/skins/vbn/css/member.css?v=4.6.0.3.3.0" rel="stylesheet" />
