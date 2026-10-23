<%@ Control Language="vb" CodeFile="DTNGHE_ThoiGianDaoTaoView.ascx.vb" Inherits="Modules.DTNGHE_ThoiGianDaoTaoView.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <h3 class="box-title">Danh mục Thời gian đào tạo (<asp:Literal ID="litCount" runat="server" />)</h3>
            </div>
            <div class="box-body">
                 <div class="main-body">
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" Width="100%">
                        <ItemStyle BackColor="#fbf2ec" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                     <asp:CheckBox ID="IsDelete" runat="server" CssClass="cDel" />
                                </ItemTemplate>
                                  <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                  <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Code" HeaderText="Mã" HeaderStyle-CssClass="hdTitle" >
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Name" HeaderText="Tên thời gian đào tạo" HeaderStyle-CssClass="hdTitle" />
                            <asp:BoundColumn DataField="IsOrder" HeaderText="Thứ tự" HeaderStyle-CssClass="hdTitle" >
                                  <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                  <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundColumn>
                            <asp:TemplateColumn HeaderText="Hoạt động" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                     <asp:CheckBox ID="IsActive" runat="server" Enabled="false" />
                                </ItemTemplate>
                                  <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                  <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                              <HeaderTemplate>
                                  <img src="/portals/_default/skins/vbn/images/hover_edit.png?w" alt="Edit" title="Xem chi tiết" />
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
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>