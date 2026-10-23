<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Category_List.ascx.vb" Inherits="DesktopModules.Modules.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-10">
                    <h3 class="box-title">DANH SÁCH QUẢN TRỊ LOẠI TIN BÀI</h3>
                </div>
                <div class="col-md-2 pdr0">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-8">
                        <asp:DropDownList ID="ddlPortal" CssClass="selectpicker" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList>
                    </div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="drlType" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                    <div class="col-md-2 pdt5 b">
                        <asp:CheckBox ID="IsActive" Checked="true" runat="server" AutoPostBack="true" CssClass="CheckBox" Text="Còn sử dụng?"></asp:CheckBox>
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="drgViewData" Width="100%" DataKeyField="CategoryId" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkItemsTop" ToolTip="Chọn để xóa" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','check-dash');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkItems" ToolTip="Chọn để xóa" runat="server" CssClass="check-dash" />
                                        </ItemTemplate>
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Thứ tự">
                                        <ItemTemplate>
                                            <asp:TextBox ID="IsOrder" CssClass="TextBox Center" runat="server"></asp:TextBox>
                                        </ItemTemplate>
                                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tên loại tin bài">
                                        <ItemTemplate>
                                            <asp:Literal ID="CategoryName" runat="server"></asp:Literal>
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Mã loại tin bài">
                                        <ItemTemplate>
                                            <asp:Literal ID="CategoryId" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" HorizontalAlign="Center" CssClass="CategoryId respo-view" />
                                        <HeaderStyle HorizontalAlign="Center" CssClass="CategoryId respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="TabID">
                                        <ItemTemplate>
                                            <asp:Literal ID="TabID" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" HorizontalAlign="Center" CssClass="TabID respo-view" />
                                        <HeaderStyle HorizontalAlign="Center" CssClass="TabID respo-title" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm mới" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" />
                <asp:Button ID="cmdDel" runat="server" CssClass="cmdbtt cmdDel" Text="Xóa" />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
