<%@ Control Language="C#" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Admin.Users.Passwords" CodeFile="Passwords.ascx.cs" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<link href="/DesktopModules/Admin/Security/module.css" rel="stylesheet" />
<script src="/DesktopModules/Admin/Security/Scripts/dnn.PasswordComparer.js"></script>
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="box-job" style="margin-top: 20px">
            <div class="box-body" style="padding: 10px">
                <div class="header-title-h3">Thay đổi mật khẩu</div>
                <div class="dnnForm dnnPassword dnnClear" id="dnnPassword">
                    <asp:Panel ID="pnlChange" runat="server">
                        <div id="oldPasswordRow" runat="server" class="dnnFormItem">
                            <div class="col-md-4 b">
                                <dnn:Label ID="plOldPassword" runat="server" ControlName="txtOldPassword" />
                            </div>
                            <div class="col-md-8">
                                <asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password" size="25" MaxLength="128" CssClass="TextBox validate[required]" />
                            </div>
                        </div>
                        <div class="dnnFormItem">
                            <div class="col-md-4 b">
                                <dnn:Label ID="plNewPassword" runat="server" ControlName="txtNewPassword" />
                            </div>
                            <div class="col-md-8">
                                <asp:Panel ID="passwordContainer" runat="server" ViewStateMode="Disabled">
                                    <asp:TextBox ID="txtNewPassword" runat="server" CssClass="TextBox validate[required]" TextMode="Password" size="25" MaxLength="20" />
                                </asp:Panel>
                            </div>
                        </div>
                        <div class="dnnFormItem">
                            <div class="col-md-4 b">
                                <dnn:Label ID="plNewConfirm" runat="server" ControlName="txtNewConfirm" />
                            </div>
                            <div class="col-md-8">
                                <asp:TextBox ID="txtNewConfirm" runat="server" TextMode="Password" size="25" MaxLength="128" CssClass="password-confirm  TextBox validate[required]" />
                            </div>
                        </div>
                        <br />
                        <div class="clr"></div>
                        <div class="col-md-4 b">
                        </div>
                        <div class="col-md-8">
                            <div class="dnnFormItem">
                                <dnn:Label ID="plLastChanged" runat="server" ControlName="lblLastChanged" />
                                <asp:Label ID="lblLastChanged" runat="server" ViewStateMode="Disabled" />
                            </div>
                            <div class="dnnFormItem none">
                                <dnn:Label ID="plExpires" runat="server" ControlName="lblExpires" />
                                <asp:Label ID="lblExpires" runat="server" ViewStateMode="Disabled" />
                            </div>
                        </div>

                        <div id="captchaRow" runat="server" visible="false" class="dnnFormItem dnnCaptcha">
                            <dnn:Label ID="captchaLabel" ControlName="ctlCaptcha" runat="server" />
                            <dnn:CaptchaControl ID="ctlCaptcha" CaptchaWidth="130" CaptchaHeight="40" ErrorStyle-CssClass="dnnFormMessage dnnFormError dnnCaptcha" runat="server" />
                        </div>
                        <div class="dnnClear"></div>
                    </asp:Panel>
                    <div id="formReset" runat="server" visible="false">
                        <asp:Panel ID="pnlReset" runat="server" ViewStateMode="Disabled">
                            <h2 class="dnnFormSectionHead">
                                <asp:Label ID="lblResetHeading" runat="server" resourceKey="ResetPassword" /></h2>
                            <div class="dnnFormItem">
                                <asp:Label ID="lblResetHelp" runat="server"></asp:Label>
                            </div>
                            <div id="questionRow" runat="server" class="dnnFormItem">
                                <dnn:Label ID="plQuestion" runat="server" ControlName="lblQuestion" />
                                <asp:Label ID="lblQuestion" runat="server" />
                            </div>
                            <div id="answerRow" runat="server" class="dnnFormItem">
                                <dnn:Label ID="plAnswer" runat="server" ControlName="txtAnswer" />
                                <asp:TextBox ID="txtAnswer" runat="server" size="25" MaxLength="20" />
                            </div>
                        </asp:Panel>
                        <asp:Panel ID="pnlQA" runat="server" ViewStateMode="Disabled">
                            <div class="dnnFormItem">
                                <asp:Label ID="lblChangeQA" runat="server" resourceKey="ChangeQA" />
                            </div>
                            <div class="dnnFormItem">
                                <asp:Label ID="lblQAHelp" resourcekey="QAHelp" CssClass="Normal" runat="server" />
                            </div>
                            <div class="dnnFormItem">
                                <dnn:Label ID="plQAPassword" runat="server" ControlName="txtQAPassword" />
                                <asp:TextBox ID="txtQAPassword" runat="server" TextMode="Password" size="25" MaxLength="20" />
                            </div>
                            <div class="dnnFormItem">
                                <dnn:Label ID="plEditQuestion" runat="server" ControlName="lblQuetxtEditQuestionstion" />
                                <asp:TextBox ID="txtEditQuestion" runat="server" size="25" MaxLength="20" />
                            </div>
                            <div class="dnnFormItem">
                                <dnn:Label ID="plEditAnswer" runat="server" ControlName="txtEditAnswer" />
                                <asp:TextBox ID="txtEditAnswer" runat="server" size="25" MaxLength="20" />
                            </div>
                        </asp:Panel>

                        <ul class="dnnActions dnnClear">
                            <li>
                                <asp:LinkButton ID="cmdReset" runat="server" CssClass="dnnPrimaryAction" resourcekey="ResetPassword" ViewStateMode="Disabled" /></li>
                            <li>
                                <asp:LinkButton ID="cmdUserReset" runat="server" CssClass="dnnPrimaryAction" resourcekey="ResetPassword" Visible="False" ViewStateMode="Disabled" /></li>
                            <li>
                                <asp:LinkButton ID="cmdUpdateQA" runat="server" CssClass="dnnSecondaryAction" resourcekey="SaveQA" ViewStateMode="Disabled" /></li>
                        </ul>
                    </div>
                    <asp:Literal ID="litChange" runat="server"></asp:Literal>
                    <div class="col-md-4">&nbsp;</div>
                    <div class="col-md-8" style="margin-top: 20px">
                        <asp:Button ID="cmdUpdate" runat="server" Text="Đổi mật khẩu" CssClass="cmsbutv cmsbtupdate" OnClientClick="return retunwaiting();" />
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
    </Triggers>
</asp:UpdatePanel>
