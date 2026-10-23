<%@ Control Language="vb" CodeFile="CaTuVanEdit.ascx.vb" Inherits="Modules.CaTuVanEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin ca tư vấn</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên ca tư vấn</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="TieuDe" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Hinh thức</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="drHinhThuc" CssClass="selectpicker validate[required]" runat="server">
                            <asp:ListItem Value="1">Tư vấn trực tiếp</asp:ListItem>
                            <asp:ListItem Value="2">Tư vấn qua điện thoại</asp:ListItem>
                            <asp:ListItem Value="3">Tư vấn qua email</asp:ListItem>
                            <asp:ListItem Value="4">Tư vấn qua hình thức khác</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Loại tư vấn</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="drLoaiTuVan" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Thời lượng (Phút)</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="ThoiLuong" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Thời gian dự kiến<sup class="txt-red">*</sup></div>
                    <div class="col-md-2 rccalpopup">
                        <asp:TextBox ID="ThoiGianDuKien" autocomplete="off" placeholder="dd/mm/yyyy" CssClass=" datepicker TuNgay TextBox validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 txt-right lb">Thời gian thực tế<sup class="txt-red">*</sup></div>
                    <div class="col-md-2 rccalpopup">
                        <asp:TextBox ID="ThoiGianThucTe" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker DenNgay TextBox validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Địa điểm (nếu trực tiếp)</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="DiaDiem" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="MoTa" runat="server" Height="100" CssClass="TextBox" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Trạng thái</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="drTrangThai" CssClass="selectpicker" runat="server">
                            <asp:ListItem Value="1">Lên lịch</asp:ListItem>
                            <asp:ListItem Value="2">Dang diễn ra</asp:ListItem>
                            <asp:ListItem Value="3">Đã hoàn thành</asp:ListItem>
                            <asp:ListItem Value="4">Hủy</asp:ListItem>
                        </asp:DropDownList>
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

