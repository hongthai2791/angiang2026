<%@ Control Language="vb" CodeFile="LogHistory.ascx.vb" ClientIDMode="Static" Inherits="DotNetNuke.EPORTAL.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-7">
            <h3 class="box-title">Lịch sử đăng nhập (<asp:Literal ID="litCount" runat="server" />)</h3>
        </div>
    </div>

    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                    <ItemStyle BackColor="#f8f4f1" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="IsOrder" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="4%" HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Ngày đăng nhập" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="LoginDate" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Thiết bị đăng nhập" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ThietBi" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="25%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Trạng thái" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TrangThai" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="20%" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div class="row">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="row lbg">
                <asp:Literal ID="lbMsg" runat="server" />
            </div>
        </div>
    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
