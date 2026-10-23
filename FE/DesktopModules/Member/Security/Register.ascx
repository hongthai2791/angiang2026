<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Register.ascx.vb" Inherits="Modules.MemberRegister.View" %>
<%@ Register Src="~/admin/Captcha/VbCapchar.ascx" TagPrefix="uc1" TagName="VbCapchar" %>
<div class="dnnClear">
    <%--  <div class="login-top-header ">
        <asp:Literal ID="litLogo" runat="server"></asp:Literal>
    </div>--%>

    <div class="col-md-12 box-login pdr0 ">
        <div class="col-md-6 pd30">
            <div class="grid login-grid">
              
            <div class="text-primary">
                <h2 class="large b">Bạn đang là ?</h2>
                </div>
                <div class="row pdt10">
                    <div class="col-md-6">
                        <asp:RadioButton ID="chCaNhan" Text="Người lao động tìm việc làm" GroupName="RadioButton" CssClass="RadioButton" runat="server" />
                    </div>
                    <div class="col-md-6">
                        <asp:RadioButton ID="chDoanhNghiep" Text="Doanh nghiệp tuyển dụng" Checked="true" GroupName="RadioButton" CssClass="RadioButton" runat="server" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row pdt10">
                    <div class="col-md-6">
                        <p>Họ đệm</p>
                        <asp:TextBox ID="FirstName" CssClass="form-control TextInput login-control validate[required]" autocomplete="off" PlaceHolder="Họ đệm" runat="server" />
                    </div>
                    <div class="col-md-6">
                        <p>Tên</p>
                        <asp:TextBox ID="LastName" CssClass="form-control TextInput login-control validate[required]" autocomplete="off" PlaceHolder="Tên gọi" runat="server" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row pdt10">
                    <div class="col-md-6">
                        <p>Email</p>
                        <asp:TextBox ID="txtEmail" onchange="checkmail()" autocomplete="off" CssClass="form-control TextInput txtEmail login-control validate[required, custom[email]]" PlaceHolder="Email" runat="server" />
                    </div>
                    <div class="col-md-6">
                        <p>Số điện thoại</p>
                        <asp:TextBox ID="txtSoDienThoai"  autocomplete="off" CssClass="form-control TextInput txtSoDienThoai login-control validate[required]" PlaceHolder="Số điện thoại" runat="server" />
                    </div>
                </div>
                <div class="row pdt10">
                    <div class="col-md-12">
                        <p>Mật Khẩu</p>
                        <asp:TextBox ID="txtPassword" TextMode="Password" autocomplete="off" PlaceHolder="Mật khẩu" CssClass="form-control TextInput login-control validate[required] minSize[7]" runat="server" />
                    </div>
                </div>
                <div class="row pdt10">
                    <div class="col-md-12">
                        <uc1:VbCapchar runat="server" ID="VbCapchar" />
                    </div>
                </div>
                <div class="row pdt10" style="text-align: center;">
                    <asp:LinkButton ID="cmdReg" CssClass="cmd-login btn-primary btn-sign" Text="Đăng ký mở tài khoản" runat="server" OnClientClick="return retunwaiting();" />
                </div>
                <div class="text-center m-b-none register pdt10">
                    <a href="/dang-nhap" title="Đăng nhập">Bạn đã là thành viên?<strong>&nbsp;Đăng nhập!</strong></a>
                </div>
                <%--<div class="login_footer">
            <div class="col-md-12">
                <span class="login_footer-span">
                    <a class="login_footer-text login_footer_term" target="_blank" href="/thoa-thuan-su-dung">Thỏa Thuận Sử Dụng</a>
                    <a class="login_footer-text" href="/quy-dinh-bao-mat" target="_blank">Quy Định Bảo Mật</a>
                </span>
            </div>
        </div>--%>
            </div>
        </div>
        
    <div class="col-md-6 pd30 right-login">
       <h2 class="large">Đăng ký thành viên nhanh chóng !</h2>
        <ul class="orange-cl purpose pd30">
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Thông tin đăng ký ngắn gọn</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Không cần kích hoạt tài khoản</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Đăng tin tuyển dụng miễn phí</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Đăng hồ sơ xin việc miễn phí</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Tìm kiếm ứng viên, việc làm dễ dàng</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Hỗ trợ, giải đáp đầy đủ, rõ ràng</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Tham gia sàn giao dịch việc làm trực tuyến</li>
            <li><i class="fa fa-check-square-o" aria-hidden="true"></i>&nbsp;Kết nối doanh nghiệp và người lao động nhanh chóng</li>
        </ul>
    </div>
    </div>
</div>
<script type="text/javascript" src="/resources/Shared/scripts/jquery/jquery.min.js?v=4.6.0.3.3.0"></script>
<link href="/portals/_default/skins/vbn/css/member.css?v=4.6.0.3.3.0" rel="stylesheet" />
<script type="text/javascript">
    function checkmail() {
        $.ajax({
            type: 'GET', url: '/api/admin/check.asmx/checkEmail?email=' + $(".txtEmail").val(), success: function (data) {
                var json = $.parseJSON($(data).find("string").text());
                if (json.data) {
                    if (json.data != "") {
                        $("#lbEmail").html(json.data);
                        notify('info', 'Email bạn nhập đã tồn tại hoặc không hợp lệ, vui lòng kiểm tra lại.', 'Thông báo', false);
                        $(".txtEmail").val("");
                    }
                };
            }
        });
    };
</script>
