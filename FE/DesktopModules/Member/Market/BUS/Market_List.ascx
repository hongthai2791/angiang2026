<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Market_List.ascx.vb" Inherits="Modules.SVL.Market_List.View" %>
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-sm-6">
                    <h3 class="box-title">Danh sách phiên giao dịch (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-sm-6">
                    <div class="col-sm-5">
                        <asp:DropDownList ID="drSort" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                    </div>
                    <div class="col-sm-2">
                        <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                    </div>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                        <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                    </div>
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
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thời gian bắt đầu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ThoiGian" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                    <HeaderStyle Width="18%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Phiên giao dịch" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="PhienGiaoDich" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thông tin giao dịch" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ThongTin" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                    <HeaderStyle Width="28%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderText="Tham gia">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsEdit" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                    <HeaderStyle Width="7%" />
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
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="IsLang" runat="server" Visible="false" />
        <asp:HiddenField ID="PhienGD_ID" runat="server" />
        <asp:HiddenField ID="Business_ID" runat="server" Visible="false" />
        <asp:Button ID="cmdSend" runat="server" CssClass="none" />
        <script>
            function thamgia(id) {
                $("#<%=PhienGD_ID.ClientID%>").val(id);
                $("#<%=cmdSend.ClientID%>").click();
            };
        </script>

    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdSend" />
    </Triggers>
</asp:UpdatePanel>
