<%@ Control Language="vb" CodeFile="HomeModule.ascx.vb" Inherits="Modules.Main_HomeModule.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <asp:Label runat="server" ID="lblMessage" Visible="false"></asp:Label>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Cấu hình module chức năng hệ thống</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="row">
                    <label class="col-md-1 lb pdr0">Chức năng</label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="Parent_ID" AutoPostBack="true" runat="server" CssClass="dllclass selectpicker" />
                    </div>
                    <div class="col-md-2 pdt5">
                        <asp:Button ID="cmdAdd" runat="server" Text="Thêm dòng" CssClass="cmsbut cmsAnew cmsbAdd" />
                    </div>
                    <label class="col-md-2 lb txt-center">Mã xác nhận</label>
                    <div class="col-md-2">
                        <asp:TextBox ID="KeyCode" autocomplete="on" aria-label="Content" TextMode="Password" runat="server" CssClass="TextBox" />
                    </div>
                </div>
                <div class="row">
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                        <PagerStyle PageButtonCount="5" HorizontalAlign="Right" NextPageText="Next"
                            PrevPageText="Previous" CssClass="pagG" Mode="NumericPages" />
                        <ItemStyle BackColor="#fbf2ec" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/hover_trash.png?w" alt="Del" title="Xóa nội dung?" class="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsDelete" runat="server" CssClass="cs-select cDel" ToolTip="Đánh dấu để xóa" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="3%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <telerik:RadNumericTextBox ID="IsOrder" Width="100%" runat="server" CssClass="grdtxt center" NumberFormat-AllowRounding="false" NumberFormat-GroupSeparator="" />
                                </ItemTemplate>
                                <ItemStyle Width="4%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Module Src" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:TextBox ID="ModuleSrc" Width="100%" runat="server" CssClass="grdtxt" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle Width="17%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Module Name" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:TextBox ID="ModuleName" Width="100%" runat="server" CssClass="grdtxt" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="ctlView" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:TextBox ID="ctlView" Width="100%" runat="server" CssClass="grdtxt" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="ctlEdit" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:TextBox ID="ctlEdit" Width="100%" runat="server" CssClass="grdtxt" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Images" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:TextBox ID="Img" Width="100%" runat="server" CssClass="grdtxt" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/main.png?w" alt="IsAdmin" title="Quản trị" class="bCur bAdm select" onclick="clickSelect('bAdm','cAdm');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsAdmin" runat="server" CssClass="cs-select cAdm" ToolTip="Quản trị" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="3%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/hover_edit.png?w" alt="IsUser" title="Người dùng" class="bCur bAus select" onclick="clickSelect('bAus','cAus');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsUser" runat="server" CssClass="cs-select cAus" ToolTip="Người dùng" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="3%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/hover_unlock.png?w" alt="Status" title="Status" class="bCur bSta select" onclick="clickSelect('bSta','cSta');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="Status" runat="server" CssClass="cs-select cSta" ToolTip="Status" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="3%" />
                            </asp:TemplateColumn>
                        </Columns>
                        <HeaderStyle HorizontalAlign="Center" CssClass="head1" />
                    </asp:DataGrid>
                </div>
                <div class="row">
                    <asp:Literal ID="lbMsg" runat="server" />
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" />

            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

