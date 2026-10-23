<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Authors_Edit.ascx.vb" Inherits="DesktopModules.CongTacVien.CMS_AuthorsEdit" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">CHI TIẾT TÁC GIẢ, CỘNG TÁC VIÊN
            </h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-12">
                <div class="col-md-2 b pdt5">Chọn phân hệ</div>
                <div class="col-md-7">
                    <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]" Width="100%"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Phóng viên nhập bài </div>
                <div class="col-md-7">
                    <asp:DropDownList ID="RegisterUser" runat="server" CssClass="selectpicker validate[required]" Width="100%"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>

                <div class="col-md-2 b pdt5">Họ tên tác giả, CTV </div>
                <div class="col-md-7">
                    <asp:TextBox ID="FullName" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Bút danh đăng tin </div>
                <div class="col-md-7">
                    <asp:TextBox ID="PenName" runat="server" CssClass="TextBox  validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Số CMND/ Hộ chiếu</div>
                <div class="col-md-7">
                    <asp:TextBox ID="Indentify" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Ngày sinh</div>
                <div class="col-md-7">
                    <div class="rccalpopup date-pub">
                        <asp:TextBox ID="Birthday" runat="server" CssClass="TextBox datepicker"></asp:TextBox>
                    </div>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Địa chỉ liên hệ </div>
                <div class="col-md-7">
                    <asp:TextBox ID="Address" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Thư điện tử</div>
                <div class="col-md-7">
                    <asp:TextBox ID="Email" runat="server" CssClass="TextBox validate[custom[email]]"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Điện thoại</div>
                <div class="col-md-7">
                    <asp:TextBox ID="Phone" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Phân loại</div>
                <div class="col-md-7">
                    <asp:DropDownList ID="Regions" runat="server" CssClass="selectpicker" Width="100%">
                        <asp:ListItem Value="0" Text="Phóng viên tòa soạn"></asp:ListItem>
                        <asp:ListItem Value="1" Text="Cộng tác viên"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="col-md-12">

                <h2 class="TitleH2" style="margin-top: 20px;">THÔNG TIN TÀI KHOẢN NGÂN HÀNG</h2>
                <div class="col-md-2 b pdt5">Tên Ngân hàng</div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtNganHang" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Chi nhánh </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtDiaChiCN" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Tên chủ thẻ </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtTenTK" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Số tài khoản </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtSoTK" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
 
                <asp:HiddenField runat="server" ID="ItemID" />
                <asp:HiddenField runat="server" ID="PortalVal" />
            </div>
        </div>
    </div>
</div>
<script>
</script>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdDel" runat="server" Text="Xóa" CssClass="cmdbtt cmdDel" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
