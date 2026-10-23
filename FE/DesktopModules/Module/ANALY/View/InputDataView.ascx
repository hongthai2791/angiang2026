<%@ Control Language="vb" CodeFile="InputDataView.ascx.vb" Inherits="Modules.InputData.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">
                        <asp:Literal ID="litTitle" runat="server" />
                        (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-1 txt-center lb">Tỉnh/TP</div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-2 lb txt-center">Năm báo cáo</div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Years_ID" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-2 lb txt-center">Tình trạng</div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTrang" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:DataGrid ID="grdData" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                                <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
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
                                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsOrder" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tên mẫu nhập liệu" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="Temp_Name" runat="server" />
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Năm nhập liệu" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="Years_ID" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" HorizontalAlign="Center" CssClass="Years_ID respo-view" />
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" CssClass="Years_ID respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="UpdatedDate" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" HorizontalAlign="Center" CssClass="UpdatedDate respo-view" />
                                        <HeaderStyle Width="12%" HorizontalAlign="Center" CssClass="UpdatedDate respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn Visible="false" HeaderText="Tình trạng" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="TrangThai" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" CssClass="TinhTrang respo-view" />
                                        <HeaderStyle Width="12%" CssClass="TinhTrang respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Thao tác" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ToolTip="Xóa dữ liệu báo cáo và khởi tạo lại mới mẫu nhập liệu này" OnCommand="lnkNewRpt_Command" OnClientClick="return confirm('Bạn có chắc chắn muốn khởi tạo lại mẫu này?<br/><b>Lưu ý: Toàn bộ dữ liệu sẽ bị xóa, mẫu nhập liệu sẽ khởi tạo lại mới hoàn toàn!</b>')" Text="Khởi tạo lại mẫu" CssClass="btn btn-warning" ID="lnkNewRpt" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" HorizontalAlign="Center" CssClass="SendDate respo-view" />
                                        <HeaderStyle Width="12%" HorizontalAlign="Center" CssClass="SendDate respo-title" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
                <asp:Panel runat="server" ID="pHot" CssClass="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdSetting" runat="server" Text="Thiết lập" CssClass="cmsbut cmdSettings" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <div class="clear"></div>
                    </div>
                </asp:Panel>
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="GroupID" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="Years_ID" />
        <asp:AsyncPostBackTrigger ControlID="TinhTrang" />
    </Triggers>
</asp:UpdatePanel>
