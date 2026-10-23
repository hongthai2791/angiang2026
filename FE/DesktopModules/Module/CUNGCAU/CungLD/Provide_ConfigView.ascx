<%@ Control Language="vb" CodeFile="Provide_ConfigView.ascx.vb" Inherits="Modules.Education.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách kỳ nhập liệu  (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-1 lb txt-center">Tỉnh/TP</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drTrangThai" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="drPageSize" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#fbf2ec" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_edit.png?w" alt="Edit" title="Chỉnh sửa" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Literal ID="IsEdit" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên đơn vị" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TenDonVi" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Kỳ dữ liệu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="KyNhapLieu" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="25%" />
                                    <ItemStyle Width="25%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Người lập" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CreatedUser" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày lập" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CreatedDate" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Trạng thái" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:CheckBox CssClass="CheckBox" ToolTip="Sử dụng" Enabled="false" ID="TrangThai" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_unlock.png?w" alt="Edit" title="Khóa kỳ" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsLock" ToolTip="Khóa lại" runat="server" CssClass="CheckBox" Enabled="false" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
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
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdNew" runat="server" Text="Tạo mới" CssClass="cmsbut cmsbtnew cbclick" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="drTrangThai" />
    </Triggers>
</asp:UpdatePanel>
