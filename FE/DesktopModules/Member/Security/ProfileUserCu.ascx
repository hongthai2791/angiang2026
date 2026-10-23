<%@ Control Language="vb" CodeFile="ProfileUserCu.ascx.vb" Inherits="Modules.UserEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="ImgUser" Src="~/controls/filepickeruploader.ascx" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin tài khoản của bạn</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="clr"></div>
            <div class="col-md-2 lb">Tài khoản đăng nhập</div>
            <div class="col-md-4">
                <asp:TextBox ID="Username" runat="server" CssClass="txt validate[required,maxSize[99]]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="col-md-2 txt-center lb">Email đăng ký</div>
            <div class="col-md-4">
                <asp:TextBox ID="Email" runat="server" ReadOnly="true" CssClass="txt txtonly"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Họ và tên</div>
            <div class="col-md-4">
                <asp:TextBox ID="DisplayName" runat="server" CssClass="txt validate[required,maxSize[128]]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="col-md-2 txt-center lb">Điện thoại</div>
            <div class="col-md-4">
                <asp:TextBox ID="Telephone" runat="server" placeHolder="Bạn phải cập nhật vào số điện thoại liên hệ trước khi tiếp tục" CssClass="txt validate[required,custom[phone]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Giới tính</div>
            <div class="col-md-4">
                <asp:DropDownList ID="GioiTinh" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                <span class="required"></span>
            </div>
            <div class="col-md-2 txt-center lb">Ngày sinh</div>
            <div class="col-md-4">
                <asp:TextBox ID="NgaySinh" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Địa chỉ liên hệ</div>
            <div class="col-md-10">
                <asp:TextBox ID="Address" runat="server" CssClass="txt validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
              <div class="clr"></div>
             <div class="col-md-2 lb">CMND/CCCD</div>
            <div class="col-md-4">
                <asp:TextBox ID="CMND" runat="server" CssClass="txt txtonly " placeholder="Chứng minh nhân dân/ căn cước công dân"></asp:TextBox>
            </div>
            <div class="col-md-2 txt-center lb">Ngày đăng ký</div>
            <div class="col-md-4">
                <asp:TextBox ID="CreatedOnDate" ReadOnly="true" runat="server" CssClass="txt txtonly"></asp:TextBox>
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Thay đổi MK lần cuối</div>
            <div class="col-md-4">
                <asp:TextBox ID="LastPasswordChangeDate" ReadOnly="true" runat="server" CssClass="txt txtonly"></asp:TextBox>
            </div>
            <div class="col-md-2 txt-center lb">Đăng nhập lần cuối</div>
            <div class="col-md-4">
                <asp:TextBox ID="LastLoginDate" ReadOnly="true" runat="server" CssClass="txt txtonly"></asp:TextBox>
            </div>
            <div class="clr"></div>
            <asp:Panel ID="pnaLogo" CssClass="div100" runat="server">
                <div class="col-md-2  lb">Ảnh đại diện</div>
                <div class="col-md-10 file">
                    <dnn:ImgUser ID="Photo" runat="server" UsePersonalFolder="true" Required="True" />
                </div>
            </asp:Panel>
            <div class="clr"></div>
            <asp:Panel ID="pnaView" CssClass="div100" runat="server" Visible="false">
                <div class="col-md-2 lb">Ảnh đại diện</div>
                <div class="col-md-10">
                    <asp:Literal ID="litLogo" runat="server" />
                </div>
            </asp:Panel>
        </div>
        <div class="clr"></div>
        <asp:Literal ID="litUpdate" runat="server" />
        <div class="clr"></div>
        <asp:Literal ID="lbMsg" runat="server" />
        <div class="clr"></div>
    </div>
</div>

<div class="clr"></div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" OnClientClick=" return $('#Form').validationEngine('detach');" />
     <%--   <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form').validationEngine('validate'); " />--%>
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form') " />
    </div>
</div>
<asp:HiddenField ID="UsTinh" runat="server" Visible="false" />
<asp:HiddenField ID="UsHuyen" runat="server" Visible="false" />
<asp:HiddenField ID="UsXa" runat="server" Visible="false" />
<asp:HiddenField ID="UsVaiTro" runat="server" Visible="false" />
<asp:HiddenField ID="UsSubMod" runat="server" Visible="false" />
