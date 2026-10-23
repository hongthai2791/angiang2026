<%@ Control Language="vb" CodeFile="APIView.ascx.vb" Inherits="Modules.APIView.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-7 pdl0">
                    <h3 class="box-title">Danh mục API thu thập (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-2 pdr0">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                        <ItemStyle BackColor="#fbf2ec" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                   <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsDelete" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để xóa?" />
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

                            <asp:TemplateColumn HeaderText="Tên API" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="TenAPI" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Kiểu API" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="KieuAPI" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>
                             <asp:TemplateColumn HeaderText="Lịch đồng bộ" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="LichDongBo" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Mô tả" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="GhiChu" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="25%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="CreatedDate" runat="server" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                             <asp:TemplateColumn HeaderText="Ghi dữ liệu" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsGhiDuLieu" Enabled="false" runat="server" CssClass="cs-select" ToolTip="Ghi dữ liệu" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/hover_unlock.png?w" alt="Active" title="Duyệt nội dung?" class="bCur bAct select" onclick="clickSelect('bAct','cAct');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsActive" Enabled="false" runat="server" CssClass="cs-select cAct" ToolTip="Chọn duyệt?" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
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
                        </Columns>
                    </asp:DataGrid>
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
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew cbclick" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');"/>
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drSort" />
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />
    </Triggers>
</asp:UpdatePanel>
