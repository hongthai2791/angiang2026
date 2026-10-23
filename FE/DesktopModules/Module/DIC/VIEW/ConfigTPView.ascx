<%@ Control Language="vb" CodeFile="ConfigTPView.ascx.vb" Inherits="Modules.ConfigTP.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách cấu hình hệ thống (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-3 pdr0">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                            <PagerStyle PageButtonCount="5" HorizontalAlign="Right" NextPageText="Next"
                                PrevPageText="Previous" CssClass="pagG" Mode="NumericPages" />
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_edit.png?w" alt="Edit" title="Chỉnh sửa" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Literal ID="IsEdit" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="3%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tỉnh/ thành phố" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="PortalName" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên miền" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="PortalAlias" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="35%" />
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
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew cbclick" />
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
    </Triggers>
</asp:UpdatePanel>
