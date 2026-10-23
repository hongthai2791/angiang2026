<%@ Control Language="VB" AutoEventWireup="false" CodeFile="FAQ.ascx.vb" Inherits="DesktopModules.Modules.Home.FAQ" %>
<%@ Register TagPrefix="dnn" TagName="VbCapchar" Src="~/admin/Captcha/VbCapchar.ascx" %>
<%@ Register Src="~/DesktopModules/Module/Home/LienHeCongTy.ascx" TagPrefix="BT" TagName="LienHeCongTy" %>

<asp:UpdatePanel runat="server" ID="P">
    <ContentTemplate>
        <div class="col-md-8 contact-left">
            <div class="frlienhe frFAQ">
                <div class=" row border-evelope">
                <div class="row">
                    <div class="col-md-12 lienh">
                        <h3><i class="fa fa-question-circle-o "></i>&nbsp; Đặt câu hỏi cho chúng tôi</h3>
                    </div>
                </div>
                <div class="row">
                    <asp:Literal ID="lbMsg" runat="server" />

                    <div class="col-md-12 lhn">
                        <span class="icon-lh"><i class="fa fa-user icon"></i></span>
                        <asp:TextBox ID="FullName" CssClass="form-control validate[required] form-control-lh " placeholder="Tên của bạn (*)" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="col-md-7 pdl0">

                    <div class="col-md-12 lhn">
                        <span class="icon-lh"><i class="fa fa-envelope icon"></i></span>
                        <asp:TextBox ID="Email" CssClass="form-control validate[required] form-control-lh" placeholder="Email liên hệ (*)" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-5 pdr0">

                    <div class="col-md-12 lhn">
                        <span class="icon-lh"><i class="fa fa-phone" aria-hidden="true"></i></span>
                        <asp:TextBox ID="Tel" CssClass="form-control validate[required] form-control-lh " placeholder="Số điện thoại (*)" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">

                    <div class="col-md-12 lhn">
                        <span class="icon-lh"><i class="fa fa-comments-o" aria-hidden="true"></i></span>
                        <asp:TextBox TextMode="MultiLine" MaxLength="300" ID="Contents" runat="server" placeholder="Nhập tối đa 500 ký tự" CssClass="form-control validate[required] form-control-lh" length="500" Height="80px" ></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12 lhn">
                        <dnn:VbCapchar ID="ctlCaptcha" runat="server" />
                    </div>
                </div>

                <div class="clear"></div>
                <div class="col-md-12 bt-contact" style="text-align: center">
                    <asp:Button ID="cmdSend" runat="server" OnClientClick="return $('#Form').validationEngine('validate')" Text="Gửi câu hỏi" class="btn btn-success"></asp:Button>
                    <asp:Button ID="cmdBack" runat="server" Text="Làm lại" class="btn"></asp:Button>
                </div>
                    </div>
                <div class="row pdt10">
                    <span class="title_text_line">Danh sách câu hỏi</span>
                </div>
                <div class="row pdt10">
                    <asp:Literal runat="server" ID="ltQues"></asp:Literal>
                </div>
                </div>
            </div>
        </div>
        </div>
        <div class="col-md-4 contact-right">
            <BT:LienHeCongTy runat="server" ID="LienHeCongTy" />
        </div>
        <div class="clear"></div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdSend" />
    </Triggers>
</asp:UpdatePanel>

