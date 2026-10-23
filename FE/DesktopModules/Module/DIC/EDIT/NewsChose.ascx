<%@ Control Language="vb" Inherits="DesktopModules.Home.News_List" CodeFile="NewsChose.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">LẤY DỮ LIỆU THEO CHUYÊN MỤC</h3>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 lb">Chọn tỉnh thành</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="TinhTP" CssClass="selectpicker" runat="server" />
                </div>
                <div class="clr"></div>
                <div class="col-md-2 lb">Tên Server</div>
                <div class="col-md-4">
                    <asp:TextBox ID="ServerName" runat="server" CssClass="TextBox validate[required]" Text="103.101.163.14" />
                </div>
                <div class="clr"></div>
                <div class="col-md-2 lb ">Tài khoản</div>
                <div class="col-md-4">
                    <asp:TextBox ID="TaiKhoan" Text="sa" runat="server" CssClass="TextBox validate[required]" />
                </div>
                <div class="clr"></div>
                <div class="col-md-2 lb ">Mật khẩu</div>
                <div class="col-md-2 ">
                    <asp:TextBox ID="MatKhau" runat="server" TextMode="Password" CssClass="TextBox validate[required]" />
                    <asp:HiddenField runat="server" ID="hidPass" />
                </div>
                <div class="clr"></div>
                <div class="col-md-2 lb ">DataBases</div>
                <div class="col-md-4 ">
                    <asp:TextBox ID="drDataBases" runat="server" CssClass="TextBox validate[required]" />
                </div>
                <div class="col-md-2 pdt5">
                    <asp:LinkButton runat="server" ID="cmdConnect" Text="Kết nối" CssClass="cmdbtt Refresh" />
                </div>
                <div class="clr"></div>
                <div class="col-md-2 lb ">Chuyên mục gốc</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="drCategoryOld" runat="server" CssClass="selectpicker validate[required]" />
                </div>
                <div class="clr"></div>
                <div class="col-md-2 lb ">Chuyên mục mới</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="drCategoryNew" runat="server" CssClass="selectpicker validate[required]" />
                </div>
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>
<asp:Literal ID="lbMsg" runat="server" />

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmdbtt cmdExit" />
        <asp:Button ID="cmdRun" runat="server" Text="Lấy dữ liệu" CssClass="cmdbtt cmdSave" />
    </div>
</div>
