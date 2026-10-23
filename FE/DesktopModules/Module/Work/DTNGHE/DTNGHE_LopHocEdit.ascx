<%@ Control Language="vb" CodeFile="DTNGHE_LopHocEdit.ascx.vb" Inherits="Modules.DTNGHE_LopHocEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin chi tiết Lớp học</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên lớp học</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="TenLopHoc" runat="server" MaxLength="255" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 lb">Nghề đào tạo</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="drNgheDaoTao" CssClass="selectpicker validate[required]" runat="server" />
    <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    
                    <div class="col-md-2 lb">Ngày khai giảng<sup class="txt-red">*</sup></div>
                    <div class="col-md-4 rccalpopup">
                        <asp:TextBox ID="NgayKhaiGiang" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                    </div>

                    <div class="col-md-2 txt-right lb">Ngày kết thúc<sup class="txt-red">*</sup></div>
                    <div class="col-md-4 rccalpopup">
                        <asp:TextBox ID="NgayKetThuc" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                    
                    <hr style="border-top: 1px dotted #ccc;"/>
                    <div class="col-md-2 lb">Tên giảng viên</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="TenGiangVien" runat="server" MaxLength="500" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    
                    <div class="col-md-2 lb">Liên hệ giảng viên</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="ThongTinLienHeGV" runat="server" MaxLength="500" CssClass="TextBox" placeholder="SĐT hoặc Email..."/>
                    </div>
                    <div class="clear"></div>
                    
                    <hr style="border-top: 1px dotted #ccc;"/>
                    <div class="col-md-2 lb">Đơn vị chủ trì</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="DonViChuTri" runat="server" MaxLength="255" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    
                    <div class="col-md-2 lb">Địa điểm học</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="DiaDiemHoc" runat="server" MaxLength="500" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    
                    <div class="col-md-2 lb">Thời gian đào tạo</div>
                    <div class="col-md-4">
                      <asp:DropDownList ID="drThoiGianDaoTao" CssClass="selectpicker" runat="server" />
                    </div>
                    <div class="col-md-2 txt-right lb">Kinh phí (VNĐ)</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="KinhPhi" runat="server" MaxLength="18" CssClass="TextBox validate[custom[number]]" placeholder="Chỉ nhập số..."/>
                    </div>
                    <div class="clear"></div>
                    
                    <div class="col-md-2 lb">Sĩ số tối đa</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="SoLuongToiDa" runat="server" MaxLength="3" CssClass="TextBox validate[custom[integer]]" placeholder="Chỉ nhập số..."/>
                    </div>
                    <div class="col-md-2 txt-right lb">Trạng thái</div>
                    <div class="col-md-4">
                         <asp:DropDownList ID="drTrangThai" CssClass="selectpicker" runat="server">
                            <asp:ListItem Value="1">Sắp mở</asp:ListItem>
                            <asp:ListItem Value="2">Đang diễn ra</asp:ListItem>
                            <asp:ListItem Value="3">Đã kết thúc</asp:ListItem>
                            <asp:ListItem Value="4">Đã hủy</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                    
                     <div class="col-md-2 lb">Ghi chú</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100px" />
                    </div>
                    <div class="clear"></div>

                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
                        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" />
                        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>