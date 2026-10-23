<%@ Control Language="vb" CodeFile="LichHenEdit.ascx.vb" Inherits="Modules.LichHenEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin lịch hẹn</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Họ và tên</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TieuDe" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Số điện thoại</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="SoDienThoai" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Ngày phỏng vấn</div>
                    <div class="col-md-4">
                         <asp:TextBox ID="NgayPhongVan" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Giờ phỏng vấn</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="GioPhongVan" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Vị trí</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="ViTri" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Google meeting</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="GoogleMeeting" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="MoTa" runat="server" Height="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Kết quả phỏng vấn</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="drTrangThai" CssClass="selectpicker validate[required]" runat="server">
                            <asp:ListItem Value="0">--- Chọn kết quả ---</asp:ListItem>
                            <asp:ListItem Value="1">Được tuyển dụng</asp:ListItem>
                            <asp:ListItem Value="2">Đang chờ phản hồi</asp:ListItem>
                            <asp:ListItem Value="3">Không được tuyển</asp:ListItem>
                            <asp:ListItem Value="4">Tạm hoãn</asp:ListItem>
                            <asp:ListItem Value="5">Hủy bỏ</asp:ListItem>
                            <asp:ListItem Value="6">Chưa đủ tiêu chuẩn</asp:ListItem>
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
                        <asp:Button ID="cmdGoogleMeeting" runat="server" TabIndex="9" Text="Kết nối google meeting" CssClass="cmsbut" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
