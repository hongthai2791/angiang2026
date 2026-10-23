<%@ Control Language="vb" CodeFile="UserConfigEdit.ascx.vb" Inherits="Modules.UserConfig.Edit" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="ImgUser" Src="~/controls/filepickeruploader.ascx" %>
<asp:HiddenField ID="ItemId" runat="server" Visible="false" />
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-7">
            <h3 class="box-title">Thông tin tài khoản người dùng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="clr"></div>
        <div class="row">
            <div class="col-md-7">
                <div class="col-md-3 lb">Tên tài khoản</div>
                <div class="col-md-9">
                    <asp:TextBox ID="Username" runat="server" CssClass="TextBox validate[required,maxSize[99]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clr"></div>
                <div class="col-md-3 lb">Họ tên</div>
                <div class="col-md-9">
                    <asp:TextBox ID="DisplayName" runat="server" CssClass="TextBox validate[required,maxSize[128]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clr"></div>
                <div class="col-md-3 lb">Email</div>
                <div class="col-md-9">
                    <asp:TextBox ID="Email" runat="server" ReadOnly="true" CssClass="TextBox txtonly"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clr"></div>
                <div class="col-md-3 lb">Điện thoại</div>
                <div class="col-md-9">
                    <asp:TextBox ID="Telephone" runat="server" CssClass="txt"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">Giới tính</div>
                <div class="col-md-9 b">
                    <asp:DropDownList ID="Gender" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">Ngày sinh</div>
                <div class="col-md-9 b">
                    <asp:TextBox ID="DateOfBirth" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">Địa chỉ</div>
                <div class="col-md-9 b">
                    <asp:TextBox ID="Address" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clr"></div>
                <div class="clr"></div>
                <div class="col-md-3 lb">CMND/CCCD</div>
                <div class="col-md-9">
                    <asp:TextBox ID="CMND" runat="server" CssClass="txt txtonly" placeholder="Nhập Chứng minh nhân dân/ căn cước công dân"></asp:TextBox>
                </div>
                <div class="col-md-3 lb">Ngày đăng ký</div>
                <div class="col-md-9">
                    <asp:TextBox ID="CreatedOnDate" ReadOnly="true" runat="server" CssClass="TextBox txtonly"></asp:TextBox>
                </div>
                <div class="clr"></div>
                <div class="col-md-3 lb">Thay đổi MK lần cuối</div>
                <div class="col-md-9">
                    <asp:TextBox ID="LastPasswordChangeDate" ReadOnly="true" runat="server" CssClass="TextBox txtonly"></asp:TextBox>
                </div>
                <div class="clr"></div>
                <div class="col-md-3 lb">Đăng nhập lần cuối</div>
                <div class="col-md-9">
                    <asp:TextBox ID="LastLoginDate" ReadOnly="true" runat="server" CssClass="TextBox txtonly"></asp:TextBox>
                </div>
                <div class="clr"></div>
                <asp:Panel ID="pnaLogo" CssClass="div100" runat="server">
                    <div class="col-md-3 lb">Ảnh đại diện</div>
                    <div class="col-md-9 file">
                        <dnn:ImgUser ID="Photo" runat="server" UsePersonalFolder="true" Required="True" />
                    </div>
                </asp:Panel>
                <div class="clr"></div>
                <asp:Panel ID="pnaView" CssClass="div100" runat="server" Visible="false">
                    <div class="col-md-3 lb">Ảnh đại diện</div>
                    <div class="col-md-9">
                        <asp:Literal ID="litLogo" runat="server" />
                    </div>
                </asp:Panel>
                <div class="clr"></div>
            </div>
            <div class="col-md-5">
                <div style="border: 1px solid #ddd; padding: 10px;">
                    <div class="col-md-12 TitleH2"><b>Đặt lại mật khẩu</b></div>
                    <div class="col-md-12 pdt10">
                        Mật khẩu mới (<span style="color: red">*</span>)
                    </div>
                    <div class="col-md-12">
                        <asp:TextBox CssClass="TextBox" ID="txtNewPassword" placeHolder="Mật khẩu tối thiểu 7 ký tự" TextMode="Password" runat="server" MaxLength="100"></asp:TextBox><br />
                    </div>
                    <div class="col-md-12 pdt10">
                        Nhập lại mật khẩu (<span style="color: red">*</span>)
                    </div>
                    <div class="col-md-12">
                        <asp:TextBox CssClass="TextBox" ID="txtNewConfirm" placeHolder="Nhập lại mật khẩu" runat="server" TextMode="Password" MaxLength="100"></asp:TextBox>
                    </div>
                    <div class="col-md-12 txt-center pdt30">
                        <asp:Button ID="lnkResetPassword" OnClientClick=" return $('#Form').validationEngine('detach');"  CssClass="cmdbtt cmdSave btSet" Text="Đặt lại mật khẩu" runat="server"></asp:Button>
                    </div>
                    <div class="col-md-12 pdt10">
                        <asp:Literal ID="litUpdate" runat="server" />
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
            <div class="clr"></div>
        </div>
    </div>
    <asp:HiddenField ID="_PortalID" runat="server" Visible="false" />
    <asp:HiddenField ID="UsTinh" runat="server" Visible="false" />
    <asp:HiddenField ID="UsHuyen" runat="server" Visible="false" />
    <asp:HiddenField ID="UsXa" runat="server" Visible="false" />
    <asp:HiddenField ID="UsSubMod" runat="server" Visible="false" />
    <asp:HiddenField ID="UsVaiTro" runat="server" Visible="false" />
</div>

<div class="clr"></div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" OnClientClick=" return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdChange" runat="server" Text="Yêu cầu đổi mật khẩu" CssClass="cmsbut cmsbtchange" />
    </div>
</div>
