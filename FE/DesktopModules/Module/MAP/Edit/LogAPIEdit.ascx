<%@ Control Language="vb" CodeFile="LogAPIEdit.ascx.vb" Inherits="Modules.LogAPIEdit.Edit" AutoEventWireup="false" Explicit="True" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin lịch sử đồng bộ API</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Mã lịch sử</div>
                    <div class="col-md-10">
                        <div class="bug-id">
                            <asp:Literal ID="Buglog_ID" runat="server" />
                        </div>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Lịch sử</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="200px" TextMode="MultiLine" />
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemView" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
