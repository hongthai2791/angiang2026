<%@ Control Language="VB" AutoEventWireup="true" ViewStateMode="Enabled" CodeFile="Mar_DNMoiTG.ascx.vb" Inherits="Modules.SVL.Mar_DNMoiTG.View" %>
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="row">
            <div class="col-md-6">
                <asp:TextBox ID="DNMoiTG_Find" placeHolder="Nhập vào tên doanh nghiệp cần tìm" CssClass="std med" runat="server" />
            </div>
            <div class="col-md-4">
                <asp:Button ID="cmdDNMoiTG_Search" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('detach');" Text="Tìm doanh nghiệp" />
                <asp:Button ID="cmdDNMoiTG_Add" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('validate'); " Text="Thêm vào phiên" />
                <asp:Button ID="cmdDNMoiTG_Email" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('detach');" Text="Gửi thư mời" />
            </div>
              <div class="col-md-2">
                <asp:DropDownList AutoPostBack="true" ID="drtrangthai"  CssClass="selectpicker" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                    <ItemStyle BackColor="#f8f4f1" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                            <HeaderTemplate>
                                <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="IsCheck" runat="server" CssClass="cs-select cDel" ToolTip="Chọn" />
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
                        <asp:TemplateColumn HeaderText="Tên doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:HiddenField ID="Business_ID" runat="server" />
                                <asp:Literal ID="Business_Vn" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Người đại diện" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ContactUser" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="15%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ContactMobile" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                        </asp:TemplateColumn>   
                        <asp:TemplateColumn HeaderText="Mã số thuế" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TaxCode" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="Address" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="30%" />
                        </asp:TemplateColumn>
                         <asp:TemplateColumn HeaderText="Trạng thái" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="Trangthai" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
        <asp:HiddenField ID="DNMoiTG_currPage" runat="server" />
        <asp:HiddenField ID="DNMoiTG_ItemID" Visible="false" runat="server" />
        <asp:Button ID="cmdDNMoiTG_Next" runat="server" CssClass="none" />
        <script type="text/javascript">
            function nexttab2(pa) {
                $("#<%=DNMoiTG_currPage.ClientID %>").val(pa);
                $("#<%=cmdDNMoiTG_Next.ClientID %>").click();
            };
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdDNMoiTG_Search" />
        <asp:AsyncPostBackTrigger ControlID="cmdDNMoiTG_Add" />
        <asp:AsyncPostBackTrigger ControlID="cmdDNMoiTG_Email" />
        <asp:AsyncPostBackTrigger ControlID="cmdDNMoiTG_Next" />
    </Triggers>
</asp:UpdatePanel>
