<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Department_List.ascx.vb" Inherits="DesktopModules.DanhMuc.PhongBan.inc_list" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">DANH SÁCH PHÒNG BAN </h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-12">
                <asp:DropDownList ID="ddlPortal" CssClass="selectpicker" runat="server" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="row">
                <div class="ctable-respo">
                    <asp:DataGrid ID="drgViewData" Width="100%" DataKeyField="ID" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                        <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                        <ItemStyle BackColor="#f5f5f5" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:BoundColumn HeaderText="Code" DataField="ID" Visible="false" ItemStyle-Width="30" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundColumn HeaderText="STT" DataField="OrderNumber" HeaderStyle-Width="4%" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                            <asp:TemplateColumn HeaderStyle-Width="7%" HeaderText="Trang chính" Visible="false">
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsGroup" runat="server" Checked='<%# DataBinder.Eval(Container.DataItem,"IsGroup") %>' />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-Width="7%" HeaderText="Trang con" Visible="false">
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsSub" runat="server" Checked='<%# DataBinder.Eval(Container.DataItem,"IsSub") %>' />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:BoundColumn HeaderText="Tên phòng ban" DataField="TenPhongBan" ItemStyle-HorizontalAlign="Left" />
                            <asp:BoundColumn HeaderText="Mô tả" DataField="MoTa" />
                            <asp:TemplateColumn HeaderText="Sửa">
                                <ItemTemplate>
                                    <asp:ImageButton ID="imb_edit" ToolTip="Chỉnh sửa" CommandName="imb_edit" ImageUrl="/image/images/F-edit.png" AlternateText="Sửa" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="5%" HorizontalAlign="Center" />
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Quy trình">
                                <ItemTemplate>
                                    <asp:HyperLink ID="hplWF" ToolTip="Edit workflow" NavigateUrl='<%#"/" & Me.PortalSettings.ActiveTab.TabName & "/edit/workflow/page/" & Request.Item("view") & "/itemid/" & DataBinder.Eval(Container.DataItem, "ID") %>' runat="server">
                                        <asp:Image ID="viewWF" ImageUrl="~/images/icon_hostsettings_16px.gif" AlternateText="Chỉnh sửa luồng xử lý" runat="server" />
                                    </asp:HyperLink>
                                </ItemTemplate>
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                                <HeaderStyle Width="10%" HorizontalAlign="Center" />
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
    </div>
</div>
