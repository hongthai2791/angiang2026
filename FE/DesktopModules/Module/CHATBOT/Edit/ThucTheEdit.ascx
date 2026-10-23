<%@ Control Language="vb" CodeFile="ThucTheEdit.ascx.vb" Inherits="Modules.ThucTheEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin thực thể</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên thực thể</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenThucThe" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div> 
                    <%--<asp:Panel ID="pnArea" Visible="false" runat="server">
                        <div class="col-md-2  txt-center lb">Khu vực</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drArea" runat="server" CssClass="selectpicker validate[required]" />
                            <span class="required"></span>
                        </div>
                    </asp:Panel>--%>
                    
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                     <div class="clr"></div>
                    <div class="col-md-2 lb">Màu nổi bật</div>
                    <div class="col-md-4" style="background:#808080;color:#fff;padding:5px;">
                        <asp:DropDownList ID="dropColor" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="Transparent">Không màu</asp:ListItem>
                            <asp:ListItem Value="#cc0202">Màu đỏ</asp:ListItem>
                            <asp:ListItem Value="#fcf22d">Màu vàng</asp:ListItem>
                            <asp:ListItem Value="#305dff">Màu xanh dương</asp:ListItem>
                            <asp:ListItem Value="#00bc0c">Màu xanh lá</asp:ListItem>
                            <asp:ListItem Value="#7100bc">Màu tím</asp:ListItem>
                            <asp:ListItem Value="#d800d8">Màu hồng</asp:ListItem>
                            <asp:ListItem Value="#eaa800">Màu cam</asp:ListItem>
                            <asp:ListItem Value="#02d6dd">Màu xanh da trời</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Thứ tự hiển thị</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                    </div>
                     <div class="col-md-2 txt-center lb">Sử dụng </div>
                    <div class="col-md-4">
                        <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

