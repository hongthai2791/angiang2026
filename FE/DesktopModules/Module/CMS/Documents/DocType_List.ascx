<%@ Control Language="vb" Inherits="Dotnetnuke.Modules.View" CodeFile="DocType_List.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="DicPP" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">Danh sách loại văn bản</h3>
                    &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-8">
                            <asp:DropDownList ID="ddlPortal" runat="server" Width="100%" CssClass="selectpicker" AutoPostBack="true" />
                        </div>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                            <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:DataGrid ID="grdData" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#fbf2ec" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','check-dash');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkItems" runat="server" CssClass="check-dash" />
                                        </ItemTemplate>
                                        <ItemStyle Width="40px" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="40px" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsOrder" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="60px" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="60px" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tên loại văn bản" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="DocType_Name" runat="server"></asp:Literal>
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Mô tả" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="DocType_Des" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="25%" CssClass="NoCode respo-view" />
                                        <HeaderStyle Width="25%" CssClass="NoCode respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Phân loại" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="GroupID" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" CssClass="GroupID respo-view" />
                                        <HeaderStyle Width="15%" CssClass="GroupID respo-title" />
                                    </asp:TemplateColumn>
                               <%--     <asp:TemplateColumn>
                                        <HeaderTemplate>
                                            <img src="/image/images/hover_unlock.png" alt="Active" title="Hiển thị?" class="bCur bMen" onclick="clickSelect('bMen','cMen');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="IsActive" runat="server" CssClass="cMen" ToolTip="Chọn hiển thị?" />
                                        </ItemTemplate>
                                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="duyet respo-view" />
                                        <HeaderStyle Width="5%" HorizontalAlign="Center" CssClass="duyet respo-title" />
                                    </asp:TemplateColumn>--%>
                                </Columns> 
                            </asp:DataGrid>
                        </div>
                        <asp:Literal ID="litPage" runat="server" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmdbtt cmdNew" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmdbtt cmdDel" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
    </ContentTemplate>
</asp:UpdatePanel>
