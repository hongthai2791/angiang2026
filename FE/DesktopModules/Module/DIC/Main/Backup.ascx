<%@ Control Language="vb" Inherits="Modules.TN_AdvertiseView.View" AutoEventWireup="false" CodeFile="Backup.ascx.vb" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border pdb0">
                <div class="col-sm-12">
                    <h3 class="box-title">Sao lưu, phục hồi dữ liệu</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle Width="5%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên tệp sao lưu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="BackupName" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày sao lưu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="BackupDate" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                    <HeaderStyle Width="25%" />
                                    <ItemStyle Width="25%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle"  HeaderText="Chọn">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsActive" runat="server" CssClass="cs-select cMen" ToolTip="Chọn gửi mail?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle Width="5%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBackup" runat="server" Text="Sao lưu dữ liệu" CssClass="cmsbut cmsbtupdate cbclick" />
                <asp:Button ID="cmdRestore" runat="server" Text="Phục hồi dữ liệu" CssClass="cmsbut cmsbtdel"  />
            </div>
        </div>
        <asp:Literal ID="lbMsg" runat="server" />
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
</asp:UpdatePanel>
