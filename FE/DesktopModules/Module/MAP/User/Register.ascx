<%@ Control Language="vb" CodeFile="Register.ascx.vb" Inherits="Modules.Register.Left" AutoEventWireup="false" Explicit="True" %>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return register();" />
    </div>
</div>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thêm mới tài khoản người sử dụng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="col-md-6">
            <asp:Literal ID="lbMsg" runat="server" />

            <div class="clear"></div>
            <div class="col-md-12">
                Tên đăng nhập<span class="note">(*)</span>
            </div>
            <div class="col-md-12">
                <asp:TextBox ID="txtUserName" runat="server" onchange="checkname()" autocomplete="off" CssClass="TextBox txtUserName" /><br />
            </div>
            <div class="col-md-12">
                <div id="lbUserName" class="note1">Tên đăng nhập >=7 ký tự (chỉ bao gồm ký tự không dấu, số và dấu chấm [.]).</div>
            </div>
            <div class="clear"></div>
            <div class="col-md-12">
                Mật khẩu<span class="note">(*)</span>
            </div>
            <div class="col-md-12">
                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" autocomplete="off" CssClass="TextBox txtPassword" /><br />
            </div>
            <div class="col-md-12">
                <div id="lbPassword" class="note1">Mật khẩu có ít nhất 7 ký tự, bao gồm cả ký tự chữ, số, ký tự đặc biệt.</div>
            </div>
            <div class="clr"></div>
            <div class="col-md-12">
                Nhập lại mật khẩu<span class="note">(*)</span>
            </div>
            <div class="col-md-12">
                <asp:TextBox ID="txtRepPassword" runat="server" onchange="checkreppass()" autocomplete="off" TextMode="Password" CssClass="TextBox txtRepPassword" /><br />
            </div>
            <div class="col-md-12">
                <div id="col-md-7epPassword" class="not"></div>
            </div>
            <div class="clr"></div>
        </div>
        <div class="col-md-6">
            <div class="col-md-12">
                Họ và tên<span class="note">(*)</span>
            </div>
            <div class="col-md-12">
                <asp:TextBox ID="DisplayName" runat="server" CssClass="TextBox" /><br />
            </div>
            <div class="col-md-12">
                <div id="lbDisplayName" class="note1">Họ và tên chỉ bao gồm ký tự</div>
            </div>
            <div class="clear"></div>
            <div class="col-md-12">Email<span class="note">(*)</span></div>
            <div class="col-md-12">
                <asp:TextBox ID="txtEmail" onchange="checkmail()" runat="server" CssClass="TextBox txtEmail" /><br />
            </div>
            <div class="col-md-12">
                <div id="lbEmail" class="note1">Địa chỉ email phải đăng nhập xác thực được.</div>
            </div>
            <div class="clr"></div>
            <div class="col-md-12">Nhóm người dùng</div>
            <div class="col-md-12">
                <asp:DropDownList ID="drVaiTro" CssClass="selectpicker" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
        <asp:UpdatePanel runat="server" ID="ppod">
            <ContentTemplate>
                <div class="row">
                    <div class="col-md-6 col-xs-5">
                        <div class="col-md-12 txt-center">Tỉnh/ thành phố </div>
                        <asp:ListBox ID="TinhTP_All" runat="server" Height="160px" CssClass="scroll list-selectpicker" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                    </div>
                    <div class="col-md-1 col-xs-2 txt-center">
                        <div class="pdt30">
                            <asp:ImageButton ID="addTinh" ToolTip="Chọn tỉnh" ImageUrl="/image/next.png" runat="server" />
                        </div>
                        <div class="pdt30">
                            <asp:ImageButton ID="removeTinh" ToolTip="Bỏ chọn" ImageUrl="/image/back.png" runat="server" />
                        </div>
                    </div>
                    <div class="col-md-5 col-xs-5">
                        <div class="col-md-12 txt-center">Tỉnh/ thành phố tác nghiệp</div>
                        <asp:HiddenField ID="ID_TinhTP" Visible="false" runat="server" />
                        <asp:ListBox ID="TinhTP_Set" runat="server" CssClass="scroll list-active" Height="160px" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                    </div>
                    <div class="clr"></div>
                </div>
                <div class="row">
                    <div class="col-md-6 col-xs-5">
                        <div class="col-md-12 txt-center">Quận/ huyện</div>
                        <asp:ListBox ID="QuanHuyen_All" runat="server" Height="160px" CssClass="scroll list-selectpicker" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                    </div>
                    <div class="col-md-1 col-xs-2 txt-center">
                        <div class="pdt30">
                            <asp:ImageButton ID="addQuanHuyen" ToolTip="Chọn huyện" ImageUrl="/image/next.png" runat="server" />
                        </div>
                        <div class="pdt30">
                            <asp:ImageButton ID="removeQuanHuyen" ToolTip="Bỏ chọn" ImageUrl="/image/back.png" runat="server" />
                        </div>
                    </div>
                    <div class="col-md-5 col-xs-5">
                        <div class="col-md-12 txt-center">Quận/ huyện tác nghiệp</div>
                        <asp:HiddenField ID="ID_QuanHuyen" Visible="false" runat="server" />
                        <asp:ListBox ID="QuanHuyen_Set" runat="server" Height="160px" CssClass="scroll list-active" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                    </div>
                    <div class="clr"></div>
                </div>
                <div class="row">
                    <div class="col-md-6 col-xs-5">
                        <div class="col-md-12 txt-center">Xã/ phường</div>
                        <asp:ListBox ID="XaPhuong_All" runat="server" Height="160px" CssClass="scroll list-selectpicker" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                    </div>
                    <div class="col-md-1 col-xs-2 txt-center">
                        <div class="pdt30">
                            <asp:ImageButton ID="addXaPhuong" ToolTip="Chọn xã" ImageUrl="/image/next.png" runat="server" />
                        </div>
                        <div class="pdt30">
                            <asp:ImageButton ID="removeXaPhuong" ToolTip="Bỏ chọn" ImageUrl="/image/back.png" runat="server" />
                        </div>
                    </div>
                    <div class="col-md-5 col-xs-5">
                        <div class="col-md-12 txt-center">Xã/ phường tác nghiệp</div>
                        <asp:HiddenField ID="ID_XaPhuong" Visible="false" runat="server" />
                        <asp:ListBox ID="XaPhuong_Set" runat="server" Height="160px" CssClass="scroll list-active" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                    </div>
                    <div class="clr"></div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="addTinh" />
                <asp:AsyncPostBackTrigger ControlID="removeTinh" />
                <asp:AsyncPostBackTrigger ControlID="addQuanHuyen" />
                <asp:AsyncPostBackTrigger ControlID="removeQuanHuyen" />
                <asp:AsyncPostBackTrigger ControlID="addXaPhuong" />
                <asp:AsyncPostBackTrigger ControlID="removeXaPhuong" />
            </Triggers>
        </asp:UpdatePanel>
        <div class="clr"></div>
    </div>
    <div class="clr"></div>
</div>
<asp:HiddenField ID="Error2" Value="" runat="server" />
<asp:HiddenField ID="Error0" Value="" runat="server" />
<asp:HiddenField ID="Error1" Value="" runat="server" />
<asp:HiddenField ID="_ProType" runat="server" Visible="false" />
<script type="text/javascript">
    function register() {
        var l = /^[a-zA-Z-Đ-đ]+/, a = $("#DisplayName").val(), e = a.match(l);
        if ($("#lbDisplayName").html(""), null == e) return $("#DisplayName").focus(), $("#lbDisplayName").html("Họ và tên không hợp lệ (chỉ bao gồm ký tự)."), !1;
        if (l = /^[A-Za-z0-9-.@]+$/, a = $(".txtUserName").val(), $("#lbUserName").removeClass("not"), $("#lbUserName").addClass("note1"), $("#lbUserName").html("Tên đăng nhập >=5 ký tự (chỉ bao gồm ký tự không dấu, số và dấu chấm [.])."), e = a.match(l), null == e) return $(".txtUserName").focus(), $("#lbUserName").removeClass("note1"), $("#lbUserName").addClass("not"), !1;
        if (a.length < 5) return $(".txtUserName").focus(), $("#lbUserName").removeClass("note1"), $("#lbUserName").addClass("not"), !1; if ("er" == $("#userok").val()) return $("#lbUserName").html("Tên đăng nhập không hợp lệ, vui lòng nhập lại!"), $(".txtUserName").focus(), $("#lbUserName").removeClass("note1"), $("#lbUserName").addClass("not"), !1; var n = $(".txtPassword").val();
        if (n.length < 7 || "" == n.trim()) return $(".txtPassword").focus(), $("#lbPassword").removeClass("note1"), $("#lbPassword").addClass("not"), $("#lbPassword").html("Mật khẩu có ít nhất 7 ký tự, bao gồm cả ký tự chữ, số, ký tự đặc biệt."), !1; if ("" == $(".txtRepPassword").val()) return $(".txtRepPassword").focus(), $("#col-md-7epPassword").html("Hãy nhập xác nhận mật khẩu truy cập."), !1;
        if ($(".txtRepPassword").val() != $(".txtPassword").val()) return $(".txtRepPassword").focus(), $("#col-md-7epPassword").html("Mật khẩu xác nhận không khớp, vui lòng nhập lại."), !1; if (a == n) return $(".txtPassword").focus(), $("#lbPassword").html("Tên đăng nhập và mật khẩu truy cập không được giống nhau."), !1; $("#lbEmail").html(""); var s = $(".txtEmail").val();
        if ("" == s) return $("#lbEmail").html("Bạn chưa nhập vào email liên hệ."), $(".txtEmail").focus(), !1; var t = /^[A-Za-z0-9]+([_\.\-]?[A-Za-z0-9])*@[A-Za-z0-9]+([\.\-]?[A-Za-z0-9]+)*(\.[A-Za-z]+)+$/, h = s.match(t); return null == h ? ($(".txtEmail").focus(), $("#lbEmail").html("Địa chỉ Email không hợp lệ, vui lòng nhập lại."), !1) : "er" == $(".txtEmailok").val() ? ($("#lbEmail").html("Email không hợp lệ hoặc đã được sử dụng!"), $(".txtEmail").focus(), !1) : !0
    };
    function checkname(t, c) {
        $("#<%=Error0.ClientID%>").val(""); $("#lbUserName").removeClass("not"); $("#lbUserName").addClass("note1"); $("#lbUserName").html("Bạn có thể sử dụng tên đăng nhập này");
        if ($(".txtUserName").val() != "") {
            $.ajax({
                type: 'GET', url: '/api/admin/check.asmx/checkUname?uname=' + $(".txtUserName").val(), success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data) {
                        if (json.data != "") {
                            $("#lbUserName").removeClass("note1"); $("#lbUserName").addClass("not");
                            $("#lbUserName").html(json.data); $("#<%=Error0.ClientID%>").val("er");
                        }
                    };
                },
            });
        }
    };
    function checkmail() {
        var l = /^[A-Za-z0-9]+([_\.\-]?[A-Za-z0-9])*@[A-Za-z0-9]+([\.\-]?[A-Za-z0-9]+)*(\.[A-Za-z]+)+$/, a = $(".txtEmail").val(), e = a.match(l);
        $("#lbEmail").html(""); $("#<%=Error1.ClientID%>").val("");
        if (null == e) {
            return $(".txtEmail").focus(), $("#lbEmail").html("Email không hợp lệ !");
        }
        else {
            $.ajax({
                type: 'GET', url: '/api/admin/check.asmx/checkEmail?email=' + $(".txtEmail").val(), success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data) { if (json.data != "") { $("#lbEmail").html(json.data); $("#<%=Error1.ClientID%>").val("er"); } };
                }
            });
        }
    };
    function checkreppass() {
        if ($(".txtRepPassword").val() != $(".txtPassword").val()) {
            $("#<%=Error2.ClientID%>").val("er");
            $(".txtRepPassword").focus();
            $("#col-md-7epPassword").html("Mật khẩu xác nhận không khớp, vui lòng nhập lại.");
            return false;
        }
        else {
            $("#lbPassword").removeClass("not");
            $("#lbPassword").addClass("note1");
            $("#col-md-7epPassword").html("")
            $("#<%=Error2.ClientID%>").val("");
            return true;
        }
    };
</script>
