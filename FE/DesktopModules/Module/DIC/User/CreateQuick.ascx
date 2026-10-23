<%@ Control Language="vb" CodeFile="CreateQuick.ascx.vb" Inherits="Modules.Registers.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="$('#Form').validationEngine('detach');"/>
        <asp:Button ID="cmdUpdate" runat="server" Text="Tạo tài khoản" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
    </div>
</div>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thêm mới danh sách tài khoản người sử dụng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="col-md-2 pdt5">Nhóm người dùng</div>
        <div class="col-md-4">
            <asp:DropDownList ID="drVaiTro" CssClass="selectpicker validate[required]" runat="server" />
            <span class="required"></span>
        </div>
        <div class="col-md-2 pdt5 txt-right">Mật khẩu khởi tạo</div>
        <div class="col-md-4">
            <asp:TextBox ID="txtPassword" CssClass="TextBox validate[required]" runat="server" />
            <span class="required"></span>
        </div>
        <div class="clear"></div>
        <div class="row">
            <div class="col-md-4">
                <asp:DropDownList ID="TinhTP" CssClass="selectpicker validate[required]" AutoPostBack="true" runat="server" />
                <span class="required"></span>
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="QuanHuyen" CssClass="selectpicker" AutoPostBack="true" runat="server" />
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="XaPhuong" CssClass="selectpicker" AutoPostBack="true" runat="server" />
            </div>
        </div>
        <div class="clear"></div>
        <div class="col-md-12">
            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                <ItemStyle BackColor="#fbf2ec" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="IsOrder" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="5%" HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Tài khoản đăng nhập" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:TextBox ID="Username" runat="server" CssClass="TextBox" />
                        </ItemTemplate>
                        <HeaderStyle Width="25%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Tên người dùng" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:TextBox ID="DisplayName" runat="server" CssClass="TextBox" />
                            <asp:TextBox ID="XaPhuong" runat="server" CssClass="TextBox" Visible="false" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Email" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:TextBox ID="Email" runat="server" CssClass="TextBox" />
                            <asp:TextBox ID="QuanHuyen" runat="server" CssClass="TextBox" Visible="false" />
                        </ItemTemplate>
                        <HeaderStyle Width="30%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                        <HeaderTemplate>
                            <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="IsNews" Checked="true" runat="server" CssClass="cs-select cDel" />
                        </ItemTemplate>
                        <HeaderStyle Width="5%" HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>
        <div class="clr"></div>
    </div>
    <div class="clr"></div>
</div>
