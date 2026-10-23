<%@ Control Language="vb" CodeFile="CaTuVanDNEdit.ascx.vb" Inherits="Modules.CaTuVanDNEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin ca tư vấn tập thể</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên doanh nghiệp</div>
                    <div class="col-md-6">
                        <asp:TextBox ID="TenDoanhNghiep" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Mã số thuế</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="MST" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Địa chỉ doanh nghiệp</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="DiaChi" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Tên người đại diện</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenNguoiDD" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Số điện thoại</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="SDTNguoiDD" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="col-md-2 lb">Email</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="EmailNguoiDD" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="col-md-2 lb">Địa chỉ</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="DiaChiNguoiDD" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="col-md-2 lb">Liên hệ khác</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="LienHeKhacNguoiDD" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Thời lượng (Phút)</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="ThoiLuong" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
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

