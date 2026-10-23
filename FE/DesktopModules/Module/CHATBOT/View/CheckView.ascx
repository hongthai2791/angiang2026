<%@ Control Language="vb" CodeFile="CheckView.ascx.vb" Inherits="Modules.CheckView.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-8 pdl0">
                    <h3 class="box-title">Kiểm tra, dự đoán độ chính xác</h3>
                </div>
                <div class="col-md-4 pdr0">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-12">
                        <h3 class="box-title">Danh sách ý định</h3>
                    </div>
                    <div class="col-md-12">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#fbf2ec" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>

                                <asp:TemplateColumn HeaderText="Tên ý định" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TenYDinh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Xếp hạng %" HeaderStyle-CssClass="hdTitle">
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
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="col-md-12">
                        <h3 class="box-title">Danh sách thực thể</h3>
                    </div>
                    <div class="col-md-12">
                        <asp:DataGrid ID="grdData2" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#fbf2ec" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>

                                <asp:TemplateColumn HeaderText="Tên thực thể" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TenYDinh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Xếp hạng %" HeaderStyle-CssClass="hdTitle">
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
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <%--  <asp:AsyncPostBackTrigger ControlID="drSort" />
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />--%>
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <%-- <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />--%>
    </Triggers>
</asp:UpdatePanel>
