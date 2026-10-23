<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Royalties_List.ascx.vb" Inherits="DesktopModules.DanhMuc.PhongBan.inc_list" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">DANH MỤC ĐỊNH MỨC NHUẬN BÚT</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-6">
                    <asp:DropDownList ID="ddlPortal" CssClass="selectpicker" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="Years" CssClass="selectpicker" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="Months" CssClass="selectpicker" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="ctable-respo">
                    <asp:DataGrid ID="drgViewData" Width="100%" DataKeyField="ID" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                        <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                        <ItemStyle BackColor="#f5f5f5" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <telerik:RadNumericTextBox ID="Orders" Width="40px" runat="server" CssClass="grdtxt center" NumberFormat-AllowRounding="false" NumberFormat-GroupSeparator="" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Mã định mức" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="MaDM" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Nhuận bút" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Price" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Mô tả" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Description" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="20%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Loại định mức" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Type" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="20%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Người cập nhật" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="CreateUser" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="15%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="CreateDate" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderText="Thao tác">
                                <ItemTemplate>
                                    <asp:Literal ID="IsEdit" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
            </div>
            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
            <asp:HiddenField ID="litCount" runat="server" />
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdNew" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm mới" />
    </div>
</div>
