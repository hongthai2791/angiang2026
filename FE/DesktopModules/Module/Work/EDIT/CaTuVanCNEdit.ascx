<%@ Control Language="vb" CodeFile="CaTuVanCNEdit.ascx.vb" Inherits="Modules.CaTuVanCNEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin ca tư vấn cá nhân</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Họ và tên</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="HoTen" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Giới tính</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="drGioiTinh" CssClass="selectpicker validate[required]" runat="server">
                            <asp:ListItem Value="0">--- Chọn giới tính ----</asp:ListItem>
                            <asp:ListItem Value="1">Nam</asp:ListItem>
                            <asp:ListItem Value="2">Nữ</asp:ListItem>
                            <asp:ListItem Value="3">Khác</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Ngày sinh</div>
                    <div class="col-md-2 rccalpopup">
                        <asp:TextBox ID="NgaySinh" autocomplete="off" placeholder="dd/mm/yyyy" CssClass=" datepicker TuNgay TextBox" runat="server" />
                    </div>
                    <div class="col-md-2 lb">CCCD</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="CCCD" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Nơi ở hiện tại</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="NoiOHT" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Thời lượng (Phút)</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="ThoiLuong" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 txt-right lb">Thời gian thực tế<sup class="txt-red">*</sup></div>
                    <div class="col-md-2 rccalpopup">
                        <asp:TextBox ID="ThoiGianThucTe" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker DenNgay TextBox validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Số lượng</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="SoLuong" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="MoTa" runat="server" Height="100" CssClass="TextBox" />
                        <span class="required"></span>
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
            <asp:HiddenField ID="IdCaTV" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

