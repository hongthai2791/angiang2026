<%@ Control Language="vb" CodeFile="RptInputView.ascx.vb" Inherits="Modules.RptInput.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">Danh sách mẫu nhập liệu đầu vào (<asp:Literal ID="litCount" runat="server" />)</h3>
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
                        <div class="col-md-2 lb">Tỉnh/ thành phố</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-2 txt-center lb">Nhóm chỉ tiêu</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="Group_ID" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
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
                                        <ItemStyle Width="15%" HorizontalAlign="Center" CssClass="UpdatedDate respo-view" />
                                        <HeaderStyle Width="15%" HorizontalAlign="Center" CssClass="UpdatedDate respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Nhóm chỉ tiêu" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="Group_ID" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="20%" CssClass="Group_ID respo-view" />
                                        <HeaderStyle Width="20%" CssClass="Group_ID respo-title" />
                                    </asp:TemplateColumn>
                                     <asp:TemplateColumn HeaderText="Thao tác" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="SaoChep" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" HorizontalAlign="Center" CssClass="SaoChep respo-view" />
                                    <HeaderStyle Width="15%" HorizontalAlign="Center" CssClass="SaoChep respo-title" />
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
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
    </Triggers>
</asp:UpdatePanel>
