<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Lienhe.ascx.vb" Inherits="DesktopModules.Modules.Home.Lienhe" %>
<%@ Register TagPrefix="dnn" TagName="VbCapchar" Src="~/admin/Captcha/VbCapchar.ascx" %>
 
<asp:UpdatePanel runat="server" ID="P">
    <ContentTemplate>

        <div class="frlienhe">

            <div class="row">
                <div class="col-md-12 lienh">
                    <h3>Liên hệ với chúng tôi</h3>
                </div>
            </div>
            <div class="row">
                <asp:Literal ID="lbMsg" runat="server" />

                <div class="col-md-12 lhn">
                    <span class="icon-lh"><i class="fa fa-user icon"></i></span>
                    <asp:TextBox ID="FullName" CssClass="form-control validate[required] form-control-lh " placeholder="Tên của bạn (*)" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="row">

                <div class="col-md-12 lhn">
                    <span class="icon-lh"><i class="fa fa-envelope icon"></i></span>
                    <asp:TextBox ID="Email" CssClass="form-control validate[required] form-control-lh" placeholder="Email liên hệ (*)" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">

                <div class="col-md-12 lhn">
                    <span class="icon-lh"><i class="fa fa-phone" aria-hidden="true"></i></span>
                    <asp:TextBox ID="Tel" CssClass="form-control validate[required] form-control-lh " placeholder="Số điện thoại (*)" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">

                <div class="col-md-12 lhn">
                    <span class="icon-lh"><i class="fa fa-comments-o" aria-hidden="true"></i></span>
                    <asp:TextBox TextMode="MultiLine" ID="Contents" runat="server" CssClass="form-control validate[required] form-control-lh" Height="100px" placeholder="Nội dung liên hệ (*)"></asp:TextBox>
                </div>
            </div>
          
            <div class="row">

                <div class="col-md-12 lhn">
                    <dnn:VbCapchar ID="ctlCaptcha" runat="server" />
                </div>
            </div>

            <div class="clear"></div>
            <div class="col-md-12 bt-contact" style="text-align: center">
                <asp:Button ID="cmdSend" runat="server" OnClientClick="return $('#Form').validationEngine('validate')" Text="Gửi liên hệ" class="btn btn-success"></asp:Button>
                <asp:Button ID="cmdBack" runat="server" Text="Hủy bỏ" class="btn"></asp:Button>
            </div>
        </div>
        <div class="clear"></div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdSend" />
    </Triggers>
</asp:UpdatePanel>

