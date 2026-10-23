<%@ Control Language="vb" CodeFile="UserProfile.ascx.vb" Inherits="Modules.UserProfile.Edit" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="ImgUser" Src="~/controls/filepickeruploader.ascx" %>
<%@ Register TagPrefix="dnn" TagName="EUI" Src="~/DesktopModules/Module/DIC/User/EditUsers.ascx" %>
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/profile.css?v=6.0.0" />

<asp:HiddenField ID="ItemId" runat="server" Visible="false" Value="0" />
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="container ">
            <div class="box_list_works row">
                <div class="col-md-3">
                    <div class="left-menu-home">
                        <asp:Literal ID="litLeft" runat="server" />
                        <script src="/DesktopModules/Admin/Security/Scripts/dnn.PasswordComparer.js"></script>
                        <script src="/Resources/Shared/scripts/dnn.PasswordStrength.js"></script>
                        <script src="/Resources/Shared/scripts/dnn.jquery.tooltip.js"></script>
                        <link href="/Resources/Shared/stylesheets/dnn.PasswordStrength.css" rel="stylesheet" />
                    </div>

                </div>
                <div class="col-md-9">

                    <div class="box-job" id="page1" runat="server" visible="false" >
                        <div class="box-body" style="padding: 10px;">
                            <asp:Literal ID="lbMsg" runat="server" />
                            <div class="header-title-h3">Thông tin tài khoản cá nhân</div>
                            <div class="clear"></div>
                            <div class="row btop10">
                                <div class="col-md-3">Tên tài khoản</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Username" runat="server" ReadOnly="true" CssClass="txt txtonly"></asp:TextBox>
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="row btop10">
                                <div class="col-md-3">Họ tên</div>
                                <div class="col-md-4">
                                    <asp:TextBox ID="DisplayName" runat="server" CssClass="txt validate[required,maxSize[128]]"></asp:TextBox>
                                    <span class="required"></span>
                                </div>
                                <div class="col-md-2 pdt5 txt-right">CMND/CCCD</div>
                                <div class="col-md-3">
                                    <asp:TextBox ID="CMND" runat="server" CssClass="txt validate[required,maxSize[12]]"></asp:TextBox>
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="row btop10">
                                <div class="col-md-3">Email</div>
                                <div class="col-md-4">
                                    <asp:TextBox ID="Email" runat="server" ReadOnly="true" CssClass="txt txtonly"></asp:TextBox>
                                    <span class="required"></span>
                                </div>
                                <div class="col-md-2 pdt5 txt-right">Điện thoại</div>
                                <div class="col-md-3">
                                    <asp:TextBox ID="Telephone" runat="server" CssClass="txt"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row btop10">
                                <div class="col-md-3">Ngày sinh</div>
                                <div class="col-md-4">
                                    <asp:TextBox ID="DateOfBirth" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" CssClass="txt"></asp:TextBox>
                                </div>
                                <div class="col-md-2 pdt5 txt-right">Giới tính</div>
                                <div class="col-md-3">
                                    <asp:DropDownList ID="Gender" runat="server" CssClass="selectpicker"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="row btop10">
                                <div class="col-md-3">Địa chỉ</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Address" runat="server" CssClass="txt"></asp:TextBox>
                                </div>
                            </div>
                            <asp:Panel ID="pnaLogo" CssClass="row btop10" runat="server">
                                <div class="col-md-3">Ảnh đại diện</div>
                                <div class="col-md-9 file">
                                    <dnn:ImgUser ID="Photo" runat="server" UsePersonalFolder="true" Required="True" />
                                </div>
                            </asp:Panel>
                            <asp:Panel ID="pnaView" CssClass="row btop10" runat="server" Visible="false">
                                <div class="col-md-3">Ảnh đại diện</div>
                                <div class="col-md-9">
                                    <asp:Literal ID="litLogo" runat="server" />
                                </div>
                            </asp:Panel>
                            <div class="btn-btx-us" style="margin-left: 25%">
                                <asp:Button ID="cmdUpdate" runat="server" Text="Cập nhật thông tin" CssClass="cmsbutv" OnClientClick="waiting(); return $('#Form').validationEngine('validate'); " />
                            </div>
                        </div>
                    </div>
                    <div id="page2" runat="server" visible="true" style="margin-top: -30px;">
                        <dnn:EUI runat="server" ID="EditUser" />
                        <div class="clear"></div>
                    </div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
    </Triggers>
</asp:UpdatePanel>
<asp:HiddenField ID="UsTinh" runat="server" Visible="false" />
<asp:HiddenField ID="UsHuyen" runat="server" Visible="false" />
<asp:HiddenField ID="UsXa" runat="server" Visible="false" />
<asp:HiddenField ID="UsSubMod" runat="server" Visible="false" />
<asp:HiddenField ID="UsVaiTro" runat="server" Visible="false" />
