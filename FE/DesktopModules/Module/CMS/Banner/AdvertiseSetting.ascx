<%@ Control Language="vb" CodeFile="AdvertiseSetting.ascx.vb" Inherits="Modules.CMS_AdvertiseSetting.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THIẾT LẬP CÀI ĐẶT HIỂN THỊ BANNER QUẢNG CÁO</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-12 pdl0">
                <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="col-md-12 pdl0">
                <div class="lbM">Module Banner quảng cáo</div>
            </div>
            <div class="clear"></div>
            <div class="ctable">
                <asp:DataGrid ID="grdBannerQuangCao" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                    <HeaderStyle Font-Bold="true" ForeColor="White" BackColor="#006699"></HeaderStyle>
                    <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                    <ItemStyle CssClass="TRgrid" BackColor="#F7FBFB" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderText="Order" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ModuleOrder" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="TabID" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TabID" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="PaneName" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="PaneName" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="TabModuleID" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TabModuleID" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Số dòng" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:TextBox ID="IsRow" runat="server" Width="100%" CssClass="TextBox center" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Slide" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:TextBox ID="Slide" runat="server" Width="100%" CssClass="TextBox center" />
                            </ItemTemplate>
                            <HeaderStyle Width="10%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Trang quảng cáo" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:DropDownList ID="PageLoca_ID" Width="100%" runat="server" CssClass="selectpicker" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                    <HeaderStyle HorizontalAlign="Center" CssClass="head" />
                </asp:DataGrid>
                <asp:HiddenField ID="HomeBanner" runat="server" Value="HomeBanner" Visible="false" />
                <div class="clrs"></div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmdbtt cmdExit" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" />
        <div class="clrs"></div>
    </div>
</div>
