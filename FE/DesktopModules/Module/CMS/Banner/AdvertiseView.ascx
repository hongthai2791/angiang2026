<%@ Control Language="vb" Inherits="Modules.CMS_AdvertiseView.View" AutoEventWireup="false" CodeFile="AdvertiseView.ascx.vb" Explicit="True" %>
<asp:UpdatePanel ID="DicPP" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">DANH SÁCH BANNER QUẢNG CÁO</h3>
                    &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-sm-6 pdl0">
                        <asp:DropDownList ID="ddlPortal" CssClass="dllclass selectpicker" AutoPostBack="true" runat="server" />
                    </div>
                    <div class="col-sm-6 pdr0">
                        <div class="col-md-3 b txt-right">Vị trí quảng cáo</div>
                        <div class="col-md-9 pdr0">
                            <asp:DropDownList ID="PageLoca_ID" CssClass="dllclass selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="grdData" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle Font-Bold="true" ForeColor="White" BackColor="#002282"></HeaderStyle>
                                <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                                <ItemStyle CssClass="TRgrid" BackColor="#F7FBFB" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','check-dash');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkItems" runat="server" CssClass="check-dash" />
                                        </ItemTemplate>
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox grdtxt center validate[required, custom[integer]]" />
                                        </ItemTemplate>
                                        <ItemStyle Width="60" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="60" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tên banner quảng cáo">
                                        <ItemTemplate>
                                            <asp:Literal ID="Advertise_Name" runat="server"></asp:Literal>
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Vị trí quảng cáo">
                                        <ItemTemplate>
                                            <asp:Literal ID="PageLoca_Name" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="30%" CssClass="chuyenmuc respo-view" />
                                        <HeaderStyle Width="30%" CssClass="chuyenmuc respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn>
                                        <HeaderTemplate>
                                            <img src="/image/images/hover_unlock.png" alt="Active" title="Hiển thị?" class="bCur bMen" onclick="clickSelect('bMen','cMen');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="IsActive" runat="server" CssClass="CheckBox cMen" ToolTip="Chọn hiển thị?" />
                                        </ItemTemplate>
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="duyet respo-view" />
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="duyet respo-title" />
                                    </asp:TemplateColumn>

                                </Columns>
                                <HeaderStyle CssClass="head" />
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                </div>
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
</asp:UpdatePanel>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmdbtt cmdNew" />
        <asp:Button ID="cmdActive" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmdbtt cmdDel" />
        <asp:Button ID="cmdSetting" runat="server" Text="Cài đặt hiển thị" CssClass="cmdbtt cmdSettings" />
    </div>
</div>
