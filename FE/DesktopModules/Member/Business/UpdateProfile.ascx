<%@ Control Language="vb" AutoEventWireup="true" CodeFile="UpdateProfile.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<div class="box box-info ">
    <div class="box-header with-border ">
        <div class="col-md-12 ">
            <h3 class="box-title">Cập nhật thông tin biến động lao động trong doanh nghiệp</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:UpdatePanel runat="server" ID="p">
                <ContentTemplate>
                    <div class="col-md-6">
                        <div class="row ">
                            <div class="col-md-4 b pdt5">Mã doanh nghiệp</div>
                            <div class="col-md-2">
                                <asp:TextBox ID="MaDN1" runat="server" Enabled="false" MaxLength="5" CssClass="txt-center enabled std med validate[required]" />
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="MaDN2" runat="server" Enabled="false" MaxLength="5" CssClass="txt-center enabled std med validate[required]" />
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="MaDN3" runat="server" Enabled="false" MaxLength="5" CssClass="txt-center enabled std med validate[required]" />
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="MaDN4" runat="server" Enabled="false" MaxLength="5" CssClass="txt-center enabled std med validate[required]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 b pdt5">1. Tên doanh nghiệp</div>
                            <div class="col-md-8">
                                <asp:TextBox ID="TenDoanhNghiep" runat="server" CssClass="std med validate[required]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdt5">Mã số ĐKKD</div>
                            <div class="col-md-8">
                                <asp:TextBox ID="TaxCode" runat="server" CssClass="std med validate[required]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 b pdt5">2. Điện thoại</div>
                            <div class="col-md-8">
                                <asp:TextBox ID="Mobile" runat="server" CssClass="std med validate[required]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdt5">Fax</div>
                            <div class="col-md-8">
                                <asp:TextBox ID="Fax" runat="server" CssClass="std med" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdt5">Email</div>
                            <div class="col-md-8">
                                <asp:TextBox ID="Email" runat="server" CssClass="std med" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdt5">Website</div>
                            <div class="col-md-8">
                                <asp:TextBox ID="Website" runat="server" CssClass="std med" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 b pdt5">3. Tình trạng hoạt động</div>
                            <div class="col-md-8">
                                <asp:DropDownList ID="TinhTrang" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="clear"></div>

                            <div class="col-md-12 b pdt5">4.Địa chỉ doanh nghiệp</div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdt5">-Tỉnh/ thành phố</div>
                            <div class="col-md-8">
                                <asp:DropDownList ID="TinhTP" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdt5">-Xã/ Phường</div>
                            <div class="col-md-8">
                                <asp:DropDownList ID="XaPhuong" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdt5">-Thành thị/nông thôn</div>
                            <div class="col-md-8">
                                <asp:DropDownList ID="TT_NT" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdt5">- Thôn, ấp, số nhà</div>
                            <div class="col-md-8">
                                <asp:TextBox ID="SoNha" runat="server" CssClass="std med" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 b pdt5">5. Khu công nghiệp, CX</div>
                            <div class="col-md-8">
                                <asp:DropDownList ID="KhuCN_ID" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 b pdt5">6. Loại hình DN/HTX</div>
                            <div class="col-md-8">
                                <asp:DropDownList ID="LoaiHinh_ID" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 b pdt5">7. Ngành nghề</div>
                            <div class="col-md-8">
                                <asp:DropDownList ID="NganhNghe" runat="server" CssClass="selectpicker NganhNghe" />
                                <asp:HiddenField ID="Nganh_Nghe" runat="server" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 b pdt5">8. Số lao động làm việc trong DN</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="LD_TongSo" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">- Số lao động ngoại tỉnh</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="LD_NgoaiTinh" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">- Số lao động trực tiếp</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="LD_TrucTiep" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">- Số lao động nữ</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="LD_Nu" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">- Tổng số lao động đã ký hợp đồng</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="LD_HD_Tong" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">- Số lao động nữ đã ký hợp đồng</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="LD_HD_Nu" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">- Tổng số lao động người nước ngoài</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="LD_NuocNgoai_Tong" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">- Số lao động nữ người nước ngoài</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="LD_NuocNgoai_Nu" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">- Số lao động đã tốt nghiệp phổ thông</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="LD_PhoThong" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b ">9. Số lao động làm việc trong doanh nghiệp chia theo trình độ CMKT</div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">9.1. Không có trình độ CMKT</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="CMKT_Khong" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">9.2. Công nhân kỹ thuật không bằng cấp/ chứng chỉ</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="CMKT_BangCap" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">9.3. Đào tạo thường xuyên</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="CMKT_DaoTao" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">9.4. Sơ cấp nghề</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="CMKT_SoCap" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                    <div class="col-md-6 pdt5">
                        <div class="row pdt5">
                            <div class="col-md-12 b pdt5">9. Số lao động làm việc trong doanh nghiệp chia theo trình độ CMKT</div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">9.5. Trung cấp</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="CMKT_TrungCap" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">9.6. Cao đẳng</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="CMKT_CaoDang" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">9.7. Đại học trở lên</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="CMKT_DaiHoc" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b  pdt5">10. Số lao động làm việc trong doanh nghiệp chia theo lĩnh vực GDĐT</div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">10.1. Kinh tế - Xã hội</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="GDDT_KTXH" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">10.2. Khoa học tự nhiên</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="GDDT_KHTN" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">10.3. Kỹ thuật và công nghệ</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="GDDT_KTCN" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">10.4. Nông nghiệp, lâm nghiệp, thủy sản và thú y</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="GDDT_NongNghiep" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">10.5. Y tế, môi trường và các dịch vụ khác</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="GDDT_YTe" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">10.6. Chưa qua đào tạo</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="GDDT_Khac" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b  pdt5">11. Số lao động làm việc trong doanh nghiệp chia theo nhóm nghề chính</div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">11.1. Nhà lãnh đạo trong các ngành, các cấp, các đơn vị</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Nhom_LanhDao" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">11.2. Nhà chuyên môn bậc cao/ trung</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Nhom_ChuyenMon" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">11.3. Nhân viên trợ lý văn phòng</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Nhom_TroLy" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">11.4. Nhân viên dịch vụ và bán hàng</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Nhom_DichVu" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">11.5. Lao động có kỹ năng trong lĩnh vực nông nghiệp</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Nhom_NongNghiep" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">11.6. Lao động thủ công và các nghề nghiệp có liên quan</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Nhom_ThuCong" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">11.7. Thợ lắp ráp và vận hành máy móc, thiết bị</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Nhom_Tho" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">11.8. Lao động giản đơn</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Nhom_DonGian" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b  ">12. Tiền lương</div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">12.1. Tiền lương bình quân trong 6 tháng đầu năm</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="TL_BinhQuan" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">12.2. Tiền lương thấp nhất trong 6 tháng đầu năm</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="TL_ThapNhat" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">12.3. Tiền lương cao nhất trong 6 tháng đầu năm</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="TL_CaoNhat" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b  pdt5">13. Nhu cầu tuyển dụng lao động chia theo chuyên môn kỹ thuật</div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">13.1. Không có trình độ chuyên môn kỹ thuật</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Chia_Khong" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">13.2. Công nhân kỹ thuật không bằng/ chứng chỉ</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Chia_BangCap" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">13.3. Đào tạo thường xuyên</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Chia_DaoTao" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">13.4. Sơ cấp nghề</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Chia_SoCap" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">13.5. Trung cấp</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Chia_TrungCap" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">13.6. Cao đẳng</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Chia_CaoDang" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-8 pdt5">13.7. Đại học trở lên</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="Chia_DaiHoc" runat="server" CssClass="txt-center std med validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    <asp:AsyncPostBackTrigger ControlID="XaPhuong" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="clr clUp  pdt5"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
    <asp:HiddenField ID="Business_ID" runat="server" Visible="true" />
    </div>
</div>
<div class="row text-center pd10 pdt5">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form').validationEngine('validate'); " />
        <div class="clr pdt5"></div>
    </div>
</div>
