<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Login.ascx.vb" Inherits="Modules.MemberLogin.View" %>
<%@ Register Src="~/admin/Captcha/VbCapchar.ascx" TagPrefix="uc1" TagName="VbCapchar" %>

<div class="col-md-12 box-login pdr0 ">
    <div class="col-md-6 pd30">
        <div class="grid login-grid">
            <div class="text-primary">
                <h2 class="large b">Chào mừng bạn đã quay trở lại!</h2>
            </div>
            <div class="row pdt10">
                <p>Email</p>
                <div class="form-group">

                    <i class="fa fa-user form-icon text-primary"></i>
                    <asp:TextBox ID="txtUsername" CssClass="form-control TextInput validate[required] pdl30" PlaceHolder="Tài khoản" runat="server" />
                </div>
            </div>
            <div class="row pdt10">
                <p>Mật Khẩu</p>
                <div class="form-group">

                    <i class="fa fa-key form-icon text-primary"></i>
                    <asp:TextBox ID="txtPassword" TextMode="Password" PlaceHolder="Mật khẩu" CssClass="form-control TextInput validate[required] pdl30" runat="server" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 col-xs-12 text-right forgot-password">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/quen-mat-khau" CssClass="inline m-t-sm forgot-password_text clickable" resourcekey="cmdPassword" Text="Quên mật khẩu?" />
                </div>
            </div>
            <div class="row pdt10">
                <uc1:VbCapchar runat="server" ID="VbCapchar" />
            </div>
            <div class="row pdt10" style="text-align: center;">
                <asp:LinkButton ID="cmdLogin" resourcekey="cmdLogin" CssClass="cmd-login btn-primary btn-sign" Text="Đăng nhập" runat="server" OnClientClick="return retunwaiting();" />
            </div>
            <div class="text-center m-b-none register pdt10">
                <a href="/dang-ky" title="Đăng ký">Bạn chưa có tài khoản?<strong> &nbsp;Đăng ký!</strong></a>
            </div>
        </div>
    </div>
    <div class="col-md-6 pd30 right-login">
       <h2 class="large">Đăng nhập để có trải nghiệm tốt hơn!</h2>
        <ul class="orange-cl purpose pd30">
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Đăng tin tuyển dụng miễn phí</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Đăng hồ sơ xin việc miễn phí</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Tìm kiếm ứng viên, việc làm dễ dàng</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Hỗ trợ, giải đáp đầy đủ, rõ ràng</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Tham gia sàn giao dịch việc làm trực tuyến</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Kết nối doanh nghiệp và người lao động nhanh chóng</li>
        </ul>
    </div>
</div>

<script type="text/javascript" src="/resources/Shared/scripts/jquery/jquery.min.js?v=4.6.0.3.3.0"></script>
<link href="/portals/_default/skins/vbn/css/member.css?v=4.6.0.3.3.0" rel="stylesheet" />
<script>
    $(document).on('keyup', function (e) {
        var code = e.keyCode || e.which;
        if (code == 119) { //Enter keycode
            eval($('.cmd-login').attr('href'));
        }
    });
</script>