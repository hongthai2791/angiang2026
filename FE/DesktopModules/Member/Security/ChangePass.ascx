<%@ Control Language="C#" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Admin.Users.Passwords" CodeFile="ChangePass.ascx.cs" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<link href="/DesktopModules/Admin/Security/module.css" rel="stylesheet" />
<link href="/Resources/Shared/stylesheets/dnn.PasswordStrength.css" rel="stylesheet" />
<script src="/Resources/Shared/scripts/dnn.jquery.tooltip.js" type="text/javascript"></script>
<script src="/Resources/Shared/scripts/dnn.PasswordStrength.js"></script>
<script src="/DesktopModules/Admin/Security/Scripts/dnn.PasswordComparer.js"></script>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-sm-12">
            <h3 class="box-title">Thay đổi mật khẩu đăng nhập hệ thống</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:UpdatePanel runat="server" ID="pageView">
                <ContentTemplate>
                    <div class="dnnForm dnnPassword dnnClear content-pass" id="dnnPassword">
                        <asp:Panel ID="pnlChange" runat="server">
                            <div id="oldPasswordRow" runat="server" class="dnnFormItem">
                                <div class="col-md-4 txt-right">
                                    Mật khẩu hiện tại
                                </div>
                                <div class="col-md-6">
                                    <asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password" size="25" MaxLength="128" CssClass="TextBox validate[required]" />
                                </div>
                            </div>
                            <div class="dnnFormItem">
                                <div class="col-md-4 txt-right">Nhập vào mật khẩu mới</div>
                                <div class="col-md-6">
                                    <asp:Panel ID="passwordContainer" runat="server" ViewStateMode="Disabled">
                                        <asp:TextBox ID="txtNewPassword" runat="server" CssClass="TextBox validate[required]" TextMode="Password" size="25" MaxLength="20" />
                                    </asp:Panel>
                                </div>
                            </div>
                            <div class="dnnFormItem">
                                <div class="col-md-4 txt-right">Nhập lại mật khẩu mới</div>
                                <div class="col-md-6">
                                    <asp:TextBox ID="txtNewConfirm" runat="server" TextMode="Password" size="25" MaxLength="128" CssClass="password-confirm TextBox validate[required]" />
                                </div>
                            </div>
                            <div class="clr"></div>
                            <asp:Literal ID="litChange" runat="server"></asp:Literal>
                            <asp:Button ID="cmdUpdate" runat="server" Text="Đổi lại mật khẩu" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />

                        </asp:Panel>
                    </div>


                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="box-header with-border">
                <div class="col-sm-12">
                    <h3 class="box-title">Gửi yêu cầu khôi phục mật khẩu</h3>
                </div>
            </div>
            <div class="col-md-12 pd10">
               <p>Bạn sẽ nhận được thư khôi phục mật khẩu vào email <asp:Label runat="server" Enabled="false" ToolTip="Bạn không thể sửa email này, đây là email bạn đã đăng ký trước đó" ID="emailForgotPast" ></asp:Label></p>
                <asp:LinkButton ID="cmdReset" ToolTip="Sau khi bấm khôi phục mật khẩu, vui lòng kiểm tra hòm thư để nhận mật khẩu mới" runat="server" Text="Gửi yêu cầu khôi phục mật khẩu" CssClass=" btn btn-danger" />
            </div>

        </div>
    </div>
</div>
