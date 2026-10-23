<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Mar_DNThamGia.ascx.vb" Inherits="Modules.SVL.DNThamGia.View" %>
<%@ Register Src="~/DesktopModules/Module/Work/POPUP/MAR_BusinessView.ascx" TagPrefix="uc1" TagName="BusinessView" %>

<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="row">
            <div class="col-md-6">
                <asp:TextBox ID="DNThamGia_Find" placeHolder="Nhập vào tên doanh nghiệp cần tìm" CssClass="std med" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Button ID="cmdDNThamGia_Search" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('detach');" Text="Tìm doanh nghiệp" />
                <asp:Button ID="cmdDNThamGia_Active" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('validate'); " Text="Duyệt tham gia" />
                <asp:Button ID="cmdDNThamGia_Delete" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('detach');" Text="Gỡ khỏi phiên" />
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
                                <asp:Literal ID="Business_Vn" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ContactMobile" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="Address" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="30%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Bàn" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:TextBox ID="SoBan" runat="server" CssClass="tx-ban" />
                            </ItemTemplate>
                            <HeaderStyle Width="7%" HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Duyệt" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TinhTrang" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="5%" HorizontalAlign="Center" />
                            <ItemStyle Width="5%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Tin đăng" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TinTuyenDung" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="7%" HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        
                        <asp:TemplateColumn HeaderText="Thay thế" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                                             <asp:Literal ID="ThayThe" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="7%" HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
        <script type="text/javascript">
            function nexttab1(pa) {
                $("#<%=DNThamGia_currPage.ClientID %>").val(pa);
                $("#<%=cmdDNThamGia_Next.ClientID %>").click();
            };
        </script>
        <asp:HiddenField ID="DNThamGia_currPage" runat="server" Value="1" />
        <asp:HiddenField ID="DNThamGia_ItemID" Visible="false" runat="server" />
        <asp:Button ID="cmdDNThamGia_Next" runat="server" CssClass="none" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdDNThamGia_Next" />
    </Triggers>
</asp:UpdatePanel>
<uc1:BusinessView runat="server" ID="ctlBusinessView" />
