<%@ Control Language="vb" CodeFile="DTNGHE_NgheDaoTaoEdit.ascx.vb" Inherits="Modules.DTNGHE_NgheDaoTaoEdit.Edit" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <h3 class="box-title">Thông tin Nghề đào tạo</h3>
            </div>
            <div class="box-body">
                <div class="col-md-2 lb">Mã nghề</div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtCode" CssClass="TextBox validate[required]" runat="server" /></div>
                <div class="clear"></div>
                <div class="col-md-2 lb">Tên nghề</div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtName" CssClass="TextBox validate[required]" runat="server" /></div>
                <div class="clear"></div>
                <div class="col-md-2 lb">Thứ tự</div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtIsOrder" CssClass="TextBox" runat="server" /></div>
                <div class="clear"></div>
                <div class="col-md-2 lb">Hoạt động</div>
                <div class="col-md-10">
                    <asp:CheckBox ID="chkIsActive" CssClass="CheckBox" runat="server" Checked="true" /></div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" />
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
            <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" />
            </div>

        </div>
        <asp:HiddenField ID="ItemId" runat="server" Value="0" />
    </ContentTemplate>
</asp:UpdatePanel>
