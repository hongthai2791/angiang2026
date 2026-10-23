<%@ Control Language="vb" CodeFile="DayOffView.ascx.vb" Inherits="Modules.DayOffView.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="DicPP" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-7 pdl0">
                    <h3 class="box-title">Danh sách ngày nghỉ, nghỉ lễ tết (<asp:Literal ID="litCount" runat="server" />)</h3>
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

            <div class="clr"></div>
            <div class="box-body">
                <div class="main-body">
                    <div class="ctable-respo">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#fbf2ec" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_trash.png" alt="Del" title="Xóa nội dung?" class="bCur bDel" onclick="clickSelect('bDel','cDel');" />
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
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Diễn giải" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DayOff_Name" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thời gian nghỉ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DayOff_Day" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="40%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CreatedDate" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="12%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_unlock.png" alt="Active" title="Duyệt nội dung?" class="bCur bAct select" onclick="clickSelect('bAct','cAct');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsActive" runat="server" CssClass="cs-select cAct" ToolTip="Chọn duyệt?" />
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
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew cbclick" />
                <asp:Button ID="cmdActive" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" />
            </div>
        </div>
        <div class="clr">
            <asp:HiddenField ID="currPage" runat="server" Visible="false" />
            <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
