<%@ Control Language="VB" AutoEventWireup="false" CodeFile="DocSettings.ascx.vb" Inherits="DesktopModules.Modules.DocSettings" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thiết lập hiển thị quản lý văn bản</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-12 lb">Tiêu đề danh sách hiển thị</div>
                <div class="col-md-12">
                    <asp:TextBox ID="DOC_LIST_TITLE" runat="server" CssClass="TextBox  validate[required]" />
                </div>
                <div class="clear"></div>
                <div class="col-md-12 lb">Nhóm văn bản hiển thị dữ liệu</div>
                <div class="col-md-12">
                    <asp:DropDownList ID="DOC_LIST_GROUP" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
    </div>
</div>
