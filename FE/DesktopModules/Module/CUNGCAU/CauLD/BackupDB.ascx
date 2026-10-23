<%@ Control Language="vb" AutoEventWireup="true" CodeFile="BackupDB.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<asp:UpdatePanel ID="pop" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Sao lưu dữ liệu kỳ nhập liệu</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 hidden-xs"></div>
                    <div class="col-md-4">
                        <div class="col-md-12">
                            <div class="backup-title">Đơn vị sao lưu</div>
                        </div>
                        <div class="col-md-12">
                            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="col-md-12">
                            <div class="backup-title">Năm sao lưu dữ liệu</div>
                        </div>
                        <div class="col-md-12">
                            <div class="backup-year">
                                <asp:Literal ID="Years" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-2 hidden-xs"></div>
                    <div class="clear"></div>
                    <div class="col-md-12 txt-center">
                        <asp:Button ID="cmdBackup" OnClientClick="waiting();" runat="server" Text="Sao lưu dữ liệu" CssClass="cmdbackup" />
                    </div>
                    <asp:Literal ID="lbMsg" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="cmdBackup" />
    </Triggers>
</asp:UpdatePanel>



