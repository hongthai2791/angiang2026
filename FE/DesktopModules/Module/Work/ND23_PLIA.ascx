<%@ Control Language="vb" CodeFile="ND23_PLIA.ascx.vb" Inherits="Modules.ND23_PLIA.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .disabledbutton {
        pointer-events: none;
        opacity: 0.4;
    }

    .cmsbtdelHo {
        background-image: url(/portals/_default/skins/vbn/images/del.png?w);
    }
</style>
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/pks.css?v=1.0.1" />

<asp:UpdatePanel runat="server" ID="pnThongTinHo">
    <ContentTemplate>
        <asp:Panel runat="server" Visible="false" ID="pnDangKyTVL">
        <div class="left-col">
            <div class="left-title "><i class="fa fa-list-ol" aria-hidden="true"></i>&nbsp;MỤC LỤC</div>
            <ol id="list-example">
                <li>
                    <a href="#thongtinchung">Thông tin chung</a>
                </li>
                <li>
                    <a href="#trinhdokynang">Thông tin lương, phúc lợi</a>
                </li>
                <li>
                    <a href="#tinhtrangvieclam">Thông tin khác</a>
                </li>

            </ol>
        </div>
        <div class="content-pks">
            <div class="box box-info box-infoHo" data-spy="scroll" data-target="#list-example" data-offset="0">
                <div class="box-body col-md-12 pb10">
                    <div class="col-md-12 text-center h4" id="thongtinphieu">
                        <b class="title-pks">PHIẾU ĐĂNG KÝ TÌM VIỆC LÀM
                        </b>
                        <br />
                        <i>(Dành cho người lao động)</i>
                    </div>
                    <div class="clear"></div>

                    <div class="main-body1 ">

                        <div class="col-md-12 col-xs-12">
                            <div class="row box-info pd0 boxg1" id="thongtinchung" style="min-height: 255px">
                                <div class="title-ho bgt1">1.THÔNG TIN CÁ NHÂN</div>
                                <div class="col-md-6 pdr0 none ">
                                    <div class="col-md-12 pdl0 pdb0 pdt0">Số thứ tự</div>
                                    <div class="col-md-12 pdl0 pdb0 pdt0">
                                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 b pdt5">1.Việc làm mong muốn <span class="red">*</span></div>
                                <div class="col-md-10 pdl0">
                                    <asp:TextBox ID="VLMM" runat="server" CssClass="TextBox" />

                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdl0 b pdt5">2.Loại hình doanh nghiệp&nbsp;<span class="red">*</span></div>
                                <div class="col-md-10 pdl0 pdt5">
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Nhà nước" CssClass="tbCheckList" ID="LHDN_NN" />

                                    </div>
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Ngoài nhà nước" CssClass="tbCheckList" ID="LHDN_NGNN" />

                                    </div>
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Có vốn đầu tư nước ngoài" CssClass="tbCheckList" ID="LHDN_VDTNN" />

                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">3.Tên công việc&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="TenCongViec" runat="server" CssClass="TextBox CCCD" />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">4.Mô tả công việc&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0">
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2  pdr0 pdt5 b">5. Mã nghề</div>
                                <div class="col-md-10 pdl0 pdt5">
                                    <div class="col-md-6">
                                        <div class="col-md-2">Cấp 1: </div>
                                        <div class="col-md-10">
                                            <asp:TextBox Enabled="false" runat="server" ID="MN_CAP1" CssClass="TextBox"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="col-md-2">Cấp 2: </div>
                                        <div class="col-md-10">
                                            <asp:TextBox Enabled="false" runat="server" ID="MN_CAP2" CssClass="TextBox"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="col-md-2">Cấp 3: </div>
                                        <div class="col-md-10">
                                            <asp:TextBox Enabled="false" runat="server" ID="MN_CAP3" CssClass="TextBox"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="col-md-2">Cấp 4: </div>
                                        <div class="col-md-10">
                                            <asp:TextBox Enabled="false" runat="server" ID="MN_CAP4" CssClass="TextBox"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">6.Chức vụ</div>
                                <div class="col-md-10 pdl0 pdt5">
                                    <div class="col-md-4">
                                        <asp:RadioButton runat="server" ID="CV_NV" GroupName="ChucVuMM" Text="Nhân viên" />
                                    </div>
                                    <div class="col-md-4">
                                        <asp:RadioButton runat="server" ID="CV_QL" GroupName="ChucVuMM" Text="Quản lý" />

                                    </div>
                                    <div class="col-md-4">
                                        <asp:RadioButton runat="server" ID="CV_LD" GroupName="ChucVuMM" Text="Lãnh đạo" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-4">
                                        <asp:RadioButton runat="server" ID="CV_KHAC" GroupName="ChucVuMM" Text="Khác" />
                                    </div>
                                    <div class="col-md-8">
                                        <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="CV_KHAC_TEXT" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-2  pdr0 pdt5 b">7.Kinh nghiệm làm việc trong lĩnh vực cần tìm</div>
                                <div class="col-md-10 pdl0">
                                    <div class="col-md-4">
                                        <asp:RadioButton runat="server" GroupName="KNLV" Text="Không có" CssClass="tbCheckList" ID="KN_KC" />

                                    </div>
                                    <div class="col-md-4">
                                        <asp:RadioButton runat="server" GroupName="KNLV" Text="Dưới 1 năm" CssClass="tbCheckList" ID="KN_DUOI1NAM" />

                                    </div>
                                    <div class="col-md-4">
                                        <asp:RadioButton runat="server" GroupName="KNLV" Text="Từ 1 đến 2 năm" CssClass="tbCheckList" ID="KN_1DEN2NAM" />

                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-6">
                                        <asp:RadioButton runat="server" GroupName="KNLV" Text="Từ 2 đến 5 năm" CssClass="tbCheckList" ID="KN_2DEN5NAM" />
                                    </div>
                                    <div class="col-md-6">
                                        <asp:RadioButton runat="server" GroupName="KNLV" Text="Trên 5 năm" CssClass="tbCheckList" ID="KN_TREN5NAM" />
                                    </div>
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2  pdr0 pdt5 b">8.Nơi làm việc ưu tiên</div>
                                <div class="col-md-10 pdl0">
                                    <div class="col-md-2">Ưu tiên 1: </div>
                                    <div class="col-md-1">Tỉnh: </div>
                                    <div class="col-md-3">
                                        <asp:TextBox runat="server" ID="NLVUT1_TINH" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                    <div class="col-md-2">Quận/huyện/KCN: </div>
                                    <div class="col-md-4">
                                        <asp:TextBox runat="server" ID="NLVUT1_QHKCN" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2">Ưu tiên 2: </div>
                                    <div class="col-md-1">Tỉnh: </div>
                                    <div class="col-md-3">
                                        <asp:TextBox runat="server" ID="NLVUT2_TINH" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                    <div class="col-md-2">Quận/huyện/KCN: </div>
                                    <div class="col-md-4">
                                        <asp:TextBox runat="server" ID="NLVUT2_QHKCN" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-md-2  pdr0 pdt5 b">9.Loại hợp đồng lao động</div>
                                <div class="col-md-10 pdl0 pdt5">
                                    <div class="col-md-6">
                                        <asp:CheckBox runat="server" Text="Không xác định thời hạn" CssClass="tbCheckList" ID="LHD_KXD" />
                                    </div>
                                    <div class="col-md-6">
                                        <asp:CheckBox runat="server" Text="Xác định thời hạn dưới 12 tháng" CssClass="tbCheckList" ID="LHD_DUOI12T" />
                                    </div>
                                    <div class="clear"></div>

                                    <div class="col-md-6">
                                        <asp:CheckBox runat="server" Text="Xác định thời hạn từ 12 đến 36 tháng" CssClass="tbCheckList" ID="LHD_12DEN36" />
                                    </div>
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2  pdr0 pdt5 b">10.Khả năng đáp ứng</div>
                                <div class="col-md-10 pdl0 pdt5">
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Làm ca" CssClass="tbCheckList" ID="KNDU_LC" />
                                    </div>
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Đi công tác" CssClass="tbCheckList" ID="KNDU_CT" />
                                    </div>
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Đi biệt phái" CssClass="tbCheckList" ID="KNDU_BP" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">11.Hình thức làm việc</div>
                                <div class="col-md-10 pdl0">
                                    <div class="col-md-6">
                                        <asp:RadioButton runat="server" GroupName="HTLV" Text="Toàn thời gian" CssClass="tbCheckList" ID="HTLV_TTG" />
                                    </div>
                                    <div class="col-md-6">
                                        <asp:RadioButton runat="server" GroupName="HTLV" Text="Bán thời gian" CssClass="tbCheckList" ID="HTLV_BTG" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2  pdr0 pdt5 b">12.Mục đích làm việc</div>
                                <div class="col-md-10 pdl0 pdt5">
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Làm việc lâu dài" CssClass="tbCheckList" ID="MDLV_LD" />
                                    </div>
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Làm việc tạm thời" CssClass="tbCheckList" ID="MDLV_TT" />
                                    </div>
                                    <div class="col-md-4">
                                        <asp:CheckBox runat="server" Text="Làm thêm" CssClass="tbCheckList" ID="MDLV_LT" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2  pdr0 pdt5 b">13.Mức lương</div>
                                <div class="col-md-10 pdl0 pdt5">

                                    <div class="col-md-12">- Lương tháng:</div>
                                    <div class="col-md-2">
                                        <asp:RadioButton runat="server" GroupName="ML_THANG" Text="Dưới 5 triệu" ID="ML_DUOI5" />
                                    </div>
                                    <div class="col-md-2">
                                        <asp:RadioButton runat="server" GroupName="ML_THANG" Text="5-10 triệu" ID="ML_5DEN10" />
                                    </div>
                                    <div class="col-md-2">
                                        <asp:RadioButton runat="server" GroupName="ML_THANG" Text="10-20 triệu" ID="ML_10DEN20" />
                                    </div>

                                    <div class="col-md-3">
                                        <asp:RadioButton runat="server" GroupName="ML_THANG" Text="20-50 triệu" ID="ML_20DEN50" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:RadioButton runat="server" GroupName="ML_THANG" Text=">50 triệu" ID="ML_TREN50" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2">
                                        <asp:CheckBox runat="server" Text="Lương ngày:" ID="ML_NGAY" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:TextBox runat="server" ID="ML_NGAY_TEXT" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                    <div class="col-md-2 pdt5">vnđ/ngày</div>
                                    <div class="clear"></div>
                                    <div class="col-md-2">
                                        <asp:CheckBox runat="server" Text="Lương giờ:" ID="ML_GIO" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:TextBox runat="server" ID="ML_GIO_TEXT" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                    <div class="col-md-2 pdt5">vnđ/giờ</div>
                                    <div class="clear"></div>
                                    <div class="col-md-6">
                                        <asp:CheckBox runat="server" Text="Thỏa thuận khi phỏng vấn" ID="ML_THOATHUAN" />
                                    </div>
                                    <div class="col-md-6">
                                        <asp:CheckBox runat="server" Text="Hoa hồng theo doanh thu/sản phẩm" ID="ML_HOAHONG" />
                                    </div>
                                </div>
                            </div>
                            <div class="row box-info pd0" id="trinhdokynang">
                                <div class="title-ho bgt1">CHẾ ĐỘ PHÚC LỢI</div>
                                <div class="col-md-2 pdr0 pdt5 b">14. Hỗ trợ ăn</div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="1 bữa" CssClass="tbCheckList" ID="HTA_1BUA" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="2 bữa" CssClass="tbCheckList" ID="HTA_2BUA" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="3 bữa" CssClass="tbCheckList" ID="HTA_3BUA" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="Bằng tiền" CssClass="tbCheckList" ID="HTA_TIEN" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="Đóng BHXH, BHYT,BHTN" CssClass="tbCheckList" ID="PC_BHXH" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="BH Nhân thọ" CssClass="tbCheckList" ID="PC_BHNT" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="Trợ cấp thôi việc" CssClass="tbCheckList" ID="PC_THOIVIEC" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="Nhà trẻ" CssClass="tbCheckList" ID="PC_NHATRE" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="Xe đưa đón" CssClass="tbCheckList" ID="PC_XE" />
                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="Hỗ trợ đi lại" CssClass="tbCheckList" ID="PC_HOTRODILAI" />
                                    </div>
                                    <div class="col-md-2">
                                        <asp:CheckBox runat="server" Text="Ký túc xá" CssClass="tbCheckList" ID="PC_KTXH" />
                                    </div>
                                    <div class="col-md-2">
                                        <asp:CheckBox runat="server" Text="Hỗ trợ nhà ở" CssClass="tbCheckList" ID="PC_HTNO" />
                                    </div>
                                    <div class="col-md-2">
                                        <asp:CheckBox runat="server" Text="Đào tạo" CssClass="tbCheckList" ID="PC_DAOTAO" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-6">
                                        <asp:CheckBox runat="server" Text="Lối đi/thiết bị hỗ trợ cho NKT" CssClass="tbCheckList" ID="PC_NKT" />
                                    </div>
                                    <div class="col-md-6">
                                        <asp:CheckBox runat="server" Text="Cơ hội thăng tiến" CssClass="tbCheckList" ID="PC_CHTT" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2">
                                        <asp:CheckBox runat="server" Text="Khác" CssClass="tbCheckList" ID="PC_KHAC" />
                                    </div>
                                    <div class="col-md-10">
                                        <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="PC_KHAC_TEXT" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clear"></div>

                                <div class="title-ho bgt1">ĐIỀU KIỆN LÀM VIỆC</div>
                                <div class="col-md-2 pdr0 pdt5 b">15. Nơi làm việc</div>
                                <div class="col-md-4">
                                    <asp:RadioButton runat="server" GroupName="NOILAMVIEC" Text="Trong nhà" ID="NLV_TN" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="NOILAMVIEC" Text="Ngoài trời" ID="NLV_NT" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="NOILAMVIEC" Text="Hỗn hợp" ID="NLV_HH" />
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2 pdr0 pdt5 b">16. Trọng lượng nâng</div>
                                <div class="col-md-4">
                                    <asp:RadioButton runat="server" GroupName="TRONGLUONGNANG" Text="Trong nhà" ID="NLTLN_DUOI5V_TN" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="TRONGLUONGNANG" Text="Ngoài trời" ID="TLN_5DEN20" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="TRONGLUONGNANG" Text="Hỗn hợp" ID="TLN_TREN20" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">17. Đứng hoặc đi lại</div>
                                <div class="col-md-4">
                                    <asp:RadioButton runat="server" GroupName="DUNGHOACDILAI" Text="Hầu như không có" ID="DILAI_KC" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="DUNGHOACDILAI" Text="Mức trung bình" ID="DILAI_TB" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="DUNGHOACDILAI" Text="Cần đứng/đi lại nhiều" ID="DILAI_NHIEU" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">18. Nghe nói</div>
                                <div class="col-md-4">
                                    <asp:RadioButton runat="server" GroupName="NGHENOI" Text="Không cần thiết" ID="NGHENOI_KCT" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="NGHENOI" Text="Nghe nói cơ bản" ID="NGHENOI_CB" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="NGHENOI" Text="Quan trọng" ID="NGHENOI_QT" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">19. Thị lực</div>
                                <div class="col-md-5">
                                    <asp:RadioButton runat="server" GroupName="THILUC" Text="Mức bình thường" ID="THILUC_BT" />
                                </div>
                                <div class="col-md-5">
                                    <asp:RadioButton runat="server" GroupName="THILUC" Text="Nhìn được vật/chi tiết nhỏ" ID="THILUC_CHITIET" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">20. Thao tác bằng tay</div>
                                <div class="col-md-4">
                                    <asp:RadioButton runat="server" GroupName="THAOTACTAY" Text="Lắp ráp đồ vật lớn" ID="THAOTACTAY_VL" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="THAOTACTAY" Text="Lắp ráp đồ vật nhỏ" ID="THAOTACTAY_VN" />
                                </div>
                                <div class="col-md-3">
                                    <asp:RadioButton runat="server" GroupName="THAOTACTAY" Text="Lắp ráp đồ vật rất nhỏ" ID="THAOTACTAY_VRN" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">21. Dùng 2 tay</div>
                                <div class="col-md-2">
                                    <asp:RadioButton runat="server" GroupName="DUNG2TAY" Text="Cần 2 tay" ID="DUNGTAY_2TAY" />
                                </div>
                                <div class="col-md-2">
                                    <asp:RadioButton runat="server" GroupName="DUNG2TAY" Text="Đôi khi cần 2 tay" ID="DUNGTAY_DKC2TAY" />
                                </div>
                                <div class="col-md-2">
                                    <asp:RadioButton runat="server" GroupName="DUNG2TAY" Text="Chỉ cần 1 tay" ID="DUNGTAY_1TAY" />
                                </div>
                                <div class="col-md-2">
                                    <asp:RadioButton runat="server" GroupName="DUNG2TAY" Text="Trái" ID="DUNGTAY_TRAI" />
                                </div>
                                <div class="col-md-2">
                                    <asp:RadioButton runat="server" GroupName="DUNG2TAY" Text="Phải" ID="DUNGTAY_PHAI" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 title-ho bgt1">SẴN SÀNG LÀM VIỆC</div>

                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="SANSANGLV" Text="Làm việc ngay" ID="SANSANG_LVN" />
                                </div>
                                <div class="col-md-2 pdt5">
                                    <asp:RadioButton runat="server" GroupName="SANSANGLV" Text="Làm việc sau" ID="SANSANG_LVS" />
                                </div>
                                <div class="col-md-4 ">
                                    <asp:TextBox runat="server" ID="SANSANG_LVS_TEXT" CssClass="TextBox"></asp:TextBox> 
                                </div>
                                <div class="col-md-1 pdt5">tháng</div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">HÌNH THỨC TUYỂN DỤNG</div>
                                <div class="col-md-2 pdt5">
                                    <asp:RadioButton runat="server" GroupName="HINHTHUCTD" Text="Trực tiếp" ID="HTTD_TT" />
                                </div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="HINHTHUCTD" Text="Qua điện thoại" ID="HTTD_DT" />
                                </div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="HINHTHUCTD" Text="Phỏng vấn online" ID="HTTD_PV" />
                                </div>
                                <div class="col-md-2 pdt5">
                                    <asp:RadioButton runat="server" GroupName="HINHTHUCTD" Text="Nộp CV" ID="HTTD_CV" />
                                </div>
                            </div>
                        </div>
                        <div class="clrUp"></div>
                    </div>
                    <asp:Literal ID="litUpdate" runat="server" />
                    <div class="col-md-12 txt-center mgb10 mgt10">
                        <asp:Button ID="cmdUpdate" runat="server" Text="Hoàn thành phiếu" CssClass="btn btn-success" OnClientClick="return retunwaiting();" />
                    </div>
                </div>

                <div class="none">
                    <asp:HiddenField ID="IdKhau" Visible="false" runat="server" />
                    <asp:HiddenField ID="YearPro" Visible="false" runat="server" />
                    <asp:HiddenField ID="IsLock" Visible="false" runat="server" />
                </div>
            </div>
        </div>

        </asp:Panel>
    
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
    </Triggers>
</asp:UpdatePanel>
<asp:Literal runat="server" ID="ltMessage"></asp:Literal>