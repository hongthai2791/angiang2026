<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="ThietLapList.ascx.vb" Inherits="DesktopModules.Modules.Reports.Reports1" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Danh sách kỳ cập nhật Cầu lao động (<asp:Literal ID="litCount" runat="server" />)</h3>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker TinhTP" />
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
                                <asp:Literal ID="STT" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="5%" HorizontalAlign="Center" />
                            <ItemStyle Width="5%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                            <HeaderTemplate>
                                <img src="/portals/_default/skins/vbn/images/hover_edit.png?w" alt="Edit" title="Chỉnh sửa" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Literal ID="IsEdit" runat="server"></asp:Literal>
                            </ItemTemplate>
                            <HeaderStyle Width="4%" HorizontalAlign="Center" />
                            <ItemStyle Width="4%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Năm cập nhập" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="Years_ID" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Hạn cập nhập thông tin" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ToDate" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="15%" />
                            <ItemStyle Width="15%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Nội dung gửi thông báo qua email cho doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="Contents" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Trạng thái" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:CheckBox CssClass="CheckBox" ToolTip="Sử dụng" Enabled="false" ID="TrangThai" runat="server" />
                            </ItemTemplate>
                            <ItemStyle  Width="10%" HorizontalAlign="Center" />
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                            <HeaderTemplate>
                                <img src="/portals/_default/skins/vbn/images/hover_unlock.png?w" alt="Edit" title="Khóa kỳ" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="IsLock" ToolTip="Khóa lại" runat="server" CssClass="CheckBox" Enabled="false" />
                            </ItemTemplate>
                            <HeaderStyle Width="4%" HorizontalAlign="Center" />
                            <ItemStyle Width="4%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Tác nghiệp" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ThaoTac" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div class="row">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <asp:Literal ID="lbMsg" runat="server"></asp:Literal>
            <asp:HiddenField ID="currPage" runat="server" Visible="false" />
            <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        </div>
    </div>
    <div class="fix-btt-toolbar">
        <div>
            <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew cbclick" />
        </div>
    </div>
</div>
