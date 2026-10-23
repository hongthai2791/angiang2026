<%@ Control Language="VB" AutoEventWireup="false" CodeFile="DS_ViecLam.ascx.vb" Inherits="Modules.SVL.DS_ViecLam.View" %>
<asp:HiddenField ID="DoanhNghiep_ID" runat="server" Value="" />
<asp:HiddenField ID="Business_ID" runat="server" Value="" />
<asp:HiddenField ID="ItemID" Visible="false" runat="server" />
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="col-md-6">
            <asp:TextBox ID="txtFind" placeHolder="Nhập tiêu đề tin cần tìm" CssClass="std med" runat="server" />
        </div>
        <div class="col-md-6">
            <asp:Button ID="cmdSearch" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('detach');" Text="Tìm việc làm" />
            <asp:Button ID="cmdAdd" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('validate'); " Text="Thêm vào phiên" />
        </div>
        <div class="clear"></div>
        <div class="row">
            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                <ItemStyle BackColor="#f8f4f1" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                        <HeaderTemplate>
                            <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel1');" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="IsSelect" runat="server" CssClass="cs-select cDel1" ToolTip="Chọn tin?" />
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
                    <asp:TemplateColumn HeaderText="Tin tuyển dụng" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="Title" runat="server" />
                            <asp:HiddenField ID="Work_ID" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="30%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Thông tin tuyển dụng" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="Infomation" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Thời hạn" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="DateTime" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="20%" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
