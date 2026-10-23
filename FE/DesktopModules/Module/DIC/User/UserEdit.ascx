<%@ Control Language="vb" CodeFile="UserEdit.ascx.vb" Inherits="Modules.UserEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="ImgUser" Src="~/controls/filepickeruploader.ascx" %>

<asp:HiddenField ID="ItemId" runat="server" Visible="false" />
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin tài khoản người dùng</h3>
        </div>
    </div>
    <div class="box-body">
        <asp:Literal ID="lbMsg" runat="server" />
        <div class="clr"></div>
        <div class="col-md-2 pdt5 b">Tên tài khoản</div>
        <div class="col-md-6">
            <asp:TextBox ID="Username" runat="server" Width="50%" CssClass="txt validate[required,maxSize[99]]"></asp:TextBox>
        </div>
        <div class="clr"></div>
        <div class="col-md-2 pdt5 b">Họ tên</div>
        <div class="col-md-6">
            <asp:TextBox ID="DisplayName" runat="server" CssClass="txt validate[required,maxSize[128]]" Width="50%"></asp:TextBox>
        </div>
        <div class="clr"></div>
        <div class="col-md-2 pdt5 b">Email</div>
        <div class="col-md-6">
            <asp:TextBox ID="Email" runat="server" ReadOnly="true" CssClass="txt txtonly" Width="50%"></asp:TextBox>
        </div>
        <div class="clr"></div>
        <div class="col-md-2 pdt5 b">Điện thoại</div>
        <div class="col-md-6">
            <asp:TextBox ID="Telephone" runat="server" Width="50%" CssClass="txt"></asp:TextBox>
        </div>
        <div class="clr"></div>
        <div class="col-md-2 pdt5 b">Ngày đăng ký</div>
        <div class="col-md-6">
            <asp:TextBox ID="CreatedOnDate" ReadOnly="true" runat="server" Width="50%" CssClass="txt txtonly"></asp:TextBox>
        </div>
        <div class="clr"></div>
        <div class="col-md-2 pdt5 b">Thay đổi MK lần cuối</div>
        <div class="col-md-6">
            <asp:TextBox ID="LastPasswordChangeDate" ReadOnly="true" runat="server" Width="50%" CssClass="txt txtonly"></asp:TextBox>
        </div>
        <div class="clr"></div>
        <div class="col-md-2 pdt5 b">Đăng nhập lần cuối</div>
        <div class="col-md-6">
            <asp:TextBox ID="LastLoginDate" ReadOnly="true" runat="server" Width="50%" CssClass="txt txtonly"></asp:TextBox>
        </div>
        <div class="clr"></div>
        <asp:Panel ID="pnaLogo" CssClass="div100" runat="server">
            <div class="col-md-2 pdt5 b">Ảnh đại diện</div>
            <div class="col-md-6 file">
                <dnn:ImgUser ID="Photo" runat="server" UsePersonalFolder="true" Required="True" />
            </div>
        </asp:Panel>
        <div class="clr"></div>
        <asp:Panel ID="pnaView" CssClass="div100" runat="server" Visible="false">
            <div class="col-md-2 pdt5 b">Ảnh đại diện</div>
            <div class="col-md-6">
                <asp:Literal ID="litLogo" runat="server" />
            </div>
        </asp:Panel>

    </div>
    <div class="clr"></div>
    <asp:Literal ID="litUpdate" runat="server" />
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" OnClientClick=" return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form').validationEngine('validate'); " />
    </div>
</div>
<div class="clr"></div>
