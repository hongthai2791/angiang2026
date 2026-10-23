<%@ Control Language="vb" AutoEventWireup="true" CodeFile="InputDNEdit.ascx.vb" Inherits="Modules.Analy.Import.InputDNEdit" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <style>
            .box-infoHo div, .box-infoHo font, .box-infoHo span, .box-infoHo td, .box-infoHo tr {
                font-size: 14px !important;
            }
        </style>
        <link rel="stylesheet" href="/portals/_default/skins/vbn/css/pks.css?v=1.0.1" />
        <div class="left-col">
            <div class="left-title "><i class="fa fa-list-ol" aria-hidden="true"></i>&nbsp;MỤC LỤC</div>
            <ol>
                <li>
                    <a href="#thongtinphieu">Thông tin phiếu</a>
                </li>
                <li>
                    <a href="#thongtinchung">I.Thông tin chung</a>
                </li>
                <li>
                    <a href="#trinhdokynang">II.Tình hình sử dụng lao động</a>
                </li>
                <li>
                    <a href="#tinhtrangvieclam">III.Nhu cầu tuyển dụng trong thời gian tới</a>
                </li>
                <li id="menutinhtrangthatnghiep">
                    <a href="#tinhtrangthatnghiep">IV.Khuyến nghị của doanh nghiệp</a>
                </li>
            </ol>
        </div>
        <div class="content-pks">

            <div class="box box-info box-infoHo">

                <div class="box-body">
                    <div class="col-md-12 text-center h4">
                        <b class="title-pks">PHIẾU KHẢO SÁT
THU THẬP, CẬP NHẬT THÔNG TIN NHU CẦU SỬ DỤNG LAO ĐỘNG TRONG CÁC LOẠI HÌNH DOANH NGHIỆP
                        </b>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12" id="thongtinphieu">
                        <div class="col-md-3 pdt5 text-danger strong">Thời điểm khảo sát <span class="red">*</span></div>
                        <div class="col-md-4 dflex">
                            <div class="col-md-4">
                                <asp:DropDownList ID="ThangKhaoSat" Width="50px" runat="server" CssClass="selectpicker validate[required] " />
                            </div>
                            <div class="col-md-4 pdt5">
                                <asp:DropDownList ID="drYear" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-2 pdl0 pdt5  text-danger strong">Mã phiếu</div>
                        <div class="col-md-3 ">
                            <asp:TextBox ID="MaDoiTuong" runat="server" CssClass="TextBox validate[required] " />
                        </div>
                    </div>
                    <div class="main-body">
                        <div class="row box-info pd0 boxg1" id="thongtinchung">
                            <div class="title-ho bgt1">I.THÔNG TIN CHUNG CỦA DOANH NGHIỆP</div>

                            <div class="col-md-2 b pdt5 ">1. Tên doanh nghiệp</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="TenDoanhNghiep" runat="server" CssClass="TextBox TenDoanhNghiep validate[required]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2 pdt5 b">2. Mã số ĐKKD</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="MaSDDKD" runat="server" CssClass="TextBox TaxCode validate[required]" />
                            </div>
                            <div class="col-md-2 pdt5 b">3. Loại hình DN/HTX</div>
                            <div class="col-md-4">
                                <asp:DropDownList ID="LoaiHinh_Id" inext="Mobile" runat="server" CssClass="selectpicker LoaiHinh_ID validate[required]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2 pdt5 b">4. Địa chỉ</div>
                            <div class="col-md-2">
                                <asp:DropDownList ID="TinhTP" AutoPostBack="true" runat="server" CssClass="selectpicker TinhTP validate[required]" />
                            </div>
                            <div class="col-md-2 pdt5 i">- Quận/ Huyện</div>
                            <div class="col-md-2">
                                <asp:DropDownList ID="QuanHuyen" AutoPostBack="true" runat="server" CssClass="selectpicker QuanHuyen validate[required]" />
                            </div>
                            <div class="col-md-2 pdt5 i">- Xã/ Phường</div>
                            <div class="col-md-2">
                                <asp:DropDownList ID="XaPhuong" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2 pdt5 b">5. Địa chỉ cụ thể</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="SoNha" onkeypress="return keydownfocus(event,'KhuCN_ID',0);" runat="server" CssClass="TextBox SoNha validate[required]" />
                            </div>
                            <div class="col-md-2">- Khu công nghiệp/KKT</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="KCNKKT" onkeypress="return keydownfocus(event,'KCNKKT',0);" runat="server" CssClass="TextBox KCNKKT" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2 b pdt5">6. Điện thoại</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="SoDienThoai" runat="server" CssClass="TextBox SoDienThoai validate[required] validate[custom[integer]]" />
                            </div>
                            <div class="col-md-2 i">- Email</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="Email" runat="server" CssClass="TextBox Email validate[required] validate[custom[email]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2 b pdt5">7. Website</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="Website" runat="server" CssClass="TextBox Website validate[required]" />
                            </div>
                            <div class="col-md-2 b pdt5">8. Năm thành lập</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="NamThanhLap" runat="server" CssClass="TextBox NamThanhLap validate[required] validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12  b pdt5">9. Ngành sản xuất - kinh doanh chính</div>
                            <div class="col-md-12">
                                <asp:CheckBoxList ID="NganhNghe_Id" RepeatColumns="2" runat="server" CssClass="selectpicker NganhNghe" />
                            </div>
                        </div>
                        <div class="row box-info pd0 boxg1" id="trinhdokynang">
                            <div class="title-ho bgt1">II.TÌNH HÌNH SỬ DỤNG LAO ĐỘNG TRONG DOANH NGHIỆP</div>
                            <div class="clear"></div>
                            <div class="col-md-2 b pdt5">10. Quy mô lao động (người)</div>
                            <div class="col-md-10">
                                <asp:DropDownList ID="QuyMoLaoDong_Id" onchange="changefocus(this);" inext="LD_TongSo" runat="server" CssClass="selectpicker QuyMoLaoDong validate[required]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2 b pdt5">11. Tổng số lao động (người)</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="TongSoLaoDong" onkeypress="return keydownfocus(event,'TongSoLaoDong',0);" runat="server" CssClass="txt-center TongSoLaoDong TextBox validate[required] validate[custom[integer]]" />
                            </div>
                            <div class="col-md-2 i pdt5">- Lao động nữ (người)</div>
                            <div class="col-md-4 ">
                                <asp:TextBox ID="TongSoLaoDongNu" runat="server" onkeypress="return keydownfocus(event,'TongSoLaoDongNu',0);" CssClass="txt-center TongSoLaoDongNu TextBox validate[required] validate[custom[integer]]" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">12. Số lao động theo loại lao động (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Chia theo loại lao động</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Số lao động ngoại tỉnh</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNgoaiTinh" onkeypress="return keydownfocus(event,'SoLDNgoaiTinh',0);" runat="server" CssClass="txt-center SoLDNgoaiTinh TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNgoaiTinhNu" onkeypress="return keydownfocus(event,'SoLDNgoaiTinhNu',0);" runat="server" CssClass="txt-center SoLDNgoaiTinhNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Số lao động trực tiếp</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTrucTiep" onkeypress="return keydownfocus(event,'SoLDTrucTiep',0);" runat="server" CssClass="txt-center SoLDTrucTiep TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTrucTiepNu" onkeypress="return keydownfocus(event,'SoLDTrucTiepNu',0);" runat="server" CssClass="txt-center SoLDTrucTiepNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Số lao động gián tiếp</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDGianTiep" onkeypress="return keydownfocus(event,'SoLDGianTiep',0);" runat="server" CssClass="txt-center SoLDGianTiep TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDGianTiepNu" onkeypress="return keydownfocus(event,'SoLDGianTiepNu',0);" runat="server" CssClass="txt-center SoLDGianTiepNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Số lao động đã ký hợp đồng lao động</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDDaKyHopDong" onkeypress="return keydownfocus(event,'SoLDDaKyHopDong',0);" runat="server" CssClass="txt-center SoLDDaKyHopDong TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDDaKyHopDongNu" onkeypress="return keydownfocus(event,'SoLDDaKyHopDongNu',0);" runat="server" CssClass="txt-center SoLDDaKyHopDongNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Số lao động tham gia BHXH bắt buộc</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDBHXH" onkeypress="return keydownfocus(event,'SoLDBHXH',0);" runat="server" CssClass="txt-center SoLDBHXH TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDBHXHNu" onkeypress="return keydownfocus(event,'SoLDBHXHNu',0);" runat="server" CssClass="txt-center SoLDBHXHNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Số lao động trên 35 tuổi</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTren35" onkeypress="return keydownfocus(event,'SoLDTren35',0);" runat="server" CssClass="txt-center SoLDTren35 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTren35Nu" onkeypress="return keydownfocus(event,'SoLDTren35Nu',0);" runat="server" CssClass="txt-center SoLDTren35Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Số lao động là người nước ngoài</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNguoiNN" onkeypress="return keydownfocus(event,'SoLDNguoiNN',0);" runat="server" CssClass="txt-center SoLDNguoiNN TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNguoiNNNu" onkeypress="return keydownfocus(event,'SoLDNguoiNNNu',0);" runat="server" CssClass="txt-center SoLDNguoiNNNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Số lao động đã tốt nghiệp Trung học phổ thông</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTHPT" onkeypress="return keydownfocus(event,'SoLDTHPT',0);" runat="server" CssClass="txt-center SoLDTHPT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTHPTNu" onkeypress="return keydownfocus(event,'SoLDTHPTNu',0);" runat="server" CssClass="txt-center SoLDTHPTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">13. Số lao động theo trình độ chuyên môn kỹ thuật (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Trình độ chuyên môn kỹ thuật</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Không có trình độ chuyên môn kỹ thuật</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDKhongCo" onkeypress="return keydownfocus(event,'SoLDTDKhongCo',0);" runat="server" CssClass="txt-center key13_tong SoLDTDKhongCo TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDKhongCoNu" onkeypress="return keydownfocus(event,'SoLDTDKhongCoNu',0);" runat="server" CssClass="txt-center key13_tongnu SoLDTDKhongCoNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Công nhân kỹ thuật không có bằng/chứng chỉ</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDCongNhan" onkeypress="return keydownfocus(event,'SoLDTDCongNhan',0);" runat="server" CssClass="txt-center key13_tong SoLDTDCongNhan TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDCongNhanNu" onkeypress="return keydownfocus(event,'SoLDTDCongNhanNu',0);" runat="server" CssClass="txt-center key13_tongnu SoLDTDCongNhanNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Đào tạo nghề dưới 03 tháng</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDDaoTao" onkeypress="return keydownfocus(event,'SoLDTDDaoTao',0);" runat="server" CssClass="txt-center key13_tong SoLDTDDaoTao TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDDaoTaoNu" onkeypress="return keydownfocus(event,'SoLDTDDaoTaoNu',0);" runat="server" CssClass="txt-center key13_tongnu SoLDTDDaoTaoNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Sơ cấp nghề</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDSoCap" onkeypress="return keydownfocus(event,'SoLDTDSoCap',0);" runat="server" CssClass="txt-center key13_tong SoLDTDSoCap TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDSoCapNu" onkeypress="return keydownfocus(event,'SoLDTDSoCapNu',0);" runat="server" CssClass="txt-center key13_tongnu SoLDTDSoCapNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Trung cấp</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTrungCap" onkeypress="return keydownfocus(event,'SoLDTDTrungCap',0);" runat="server" CssClass="txt-center key13_tong SoLDTDTrungCap TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTrungCapNu" onkeypress="return keydownfocus(event,'SoLDTDTrungCapNu',0);" runat="server" CssClass="txt-center key13_tongnu SoLDTDTrungCapNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Cao đẳng</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDCaoDang" onkeypress="return keydownfocus(event,'SoLDTDCaoDang',0);" runat="server" CssClass="txt-center key13_tong SoLDTDCaoDang TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDCaoDangNu" onkeypress="return keydownfocus(event,'SoLDTDCaoDangNu',0);" runat="server" CssClass="txt-center key13_tongnu SoLDTDCaoDangNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Đại học trở lên</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDDaiHoc" onkeypress="return keydownfocus(event,'SoLDTDDaiHoc',0);" runat="server" CssClass="txt-center key13_tong SoLDTDDaiHoc TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDDaiHocNu" onkeypress="return keydownfocus(event,'SoLDTDDaiHocNu',0);" runat="server" CssClass="txt-center key13_tongnu SoLDTDDaiHocNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo13" onkeypress="return keydownfocus(event,'TongSo13',0);" runat="server" CssClass="txt-center TongSo13 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo13Nu" onkeypress="return keydownfocus(event,'TongSo13Nu',0);" runat="server" CssClass="txt-center TongSo13Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">14. Số lao động theo lĩnh vực giáo dục - đào tạo (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Lĩnh vực giáo dục - đào tạo</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Chương trình cơ bản/CT xóa mù/CT giáo dục chuyên biệt</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVChuongTrinh" onkeypress="return keydownfocus(event,'SoLDLVChuongTrinh',0);" runat="server" CssClass="txt-center key14_tong SoLDLVChuongTrinh TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVChuongTrinhNu" onkeypress="return keydownfocus(event,'SoLDLVChuongTrinhNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVChuongTrinhNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Khoa học giáo dục và đào tạo giáo viên</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhoaHoc" onkeypress="return keydownfocus(event,'SoLDLVKhoaHoc',0);" runat="server" CssClass="txt-center key14_tong SoLDLVKhoaHoc TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhoaHocNu" onkeypress="return keydownfocus(event,'SoLDLVKhoaHocNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVKhoaHocNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Nghệ thuật</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVNgheThuat" onkeypress="return keydownfocus(event,'SoLDLVNgheThuat',0);" runat="server" CssClass="txt-center key14_tong SoLDLVNgheThuat TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVNgheThuatNu" onkeypress="return keydownfocus(event,'SoLDLVNgheThuatNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVNgheThuatNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Nhân văn</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVNhanVan" onkeypress="return keydownfocus(event,'SoLDLVNhanVan',0);" runat="server" CssClass="txt-center key14_tong SoLDLVNhanVan TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVNhanVanNu" onkeypress="return keydownfocus(event,'SoLDLVNhanVanNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVNhanVanNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Khoa học xã hội và hành vi</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhoaHocXH" onkeypress="return keydownfocus(event,'SoLDLVKhoaHocXH',0);" runat="server" CssClass="txt-center key14_tong SoLDLVKhoaHocXH TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhoaHocXHNu" onkeypress="return keydownfocus(event,'SoLDLVKhoaHocXHNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVKhoaHocXHNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Báo chí và thông tin</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVBaoTri" onkeypress="return keydownfocus(event,'SoLDLVBaoTri',0);" runat="server" CssClass="txt-center key14_tong SoLDLVBaoTri TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVBaoTriNu" onkeypress="return keydownfocus(event,'SoLDLVBaoTriNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVBaoTriNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Kinh doanh và quản lý</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKinhDoanh" onkeypress="return keydownfocus(event,'SoLDLVKinhDoanh',0);" runat="server" CssClass="txt-center key14_tong SoLDLVKinhDoanh TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKinhDoanhNu" onkeypress="return keydownfocus(event,'SoLDLVKinhDoanhNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDTDDaiHocNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Pháp luật</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVPhapLuat" onkeypress="return keydownfocus(event,'SoLDLVPhapLuat',0);" runat="server" CssClass="txt-center key14_tong SoLDLVPhapLuat TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVPhapLuatNu" onkeypress="return keydownfocus(event,'SoLDLVPhapLuatNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVPhapLuatNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Khoa học sự sống</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhoaHocSS" onkeypress="return keydownfocus(event,'SoLDLVKhoaHocSS',0);" runat="server" CssClass="txt-center key14_tong SoLDLVKhoaHocSS TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhoaHocSSNu" onkeypress="return keydownfocus(event,'SoLDLVKhoaHocSSNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVKhoaHocSSNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Khoa học tự nhiên</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhoaHocTN" onkeypress="return keydownfocus(event,'SoLDLVKhoaHocTN',0);" runat="server" CssClass="txt-center key14_tong SoLDLVKhoaHocTN TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhoaHocTNNu" onkeypress="return keydownfocus(event,'SoLDLVKhoaHocTNNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVKhoaHocTNNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Toán và thống kê</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVToan" onkeypress="return keydownfocus(event,'SoLDLVToan',0);" runat="server" CssClass="txt-center key14_tong SoLDLVToan TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVToanNu" onkeypress="return keydownfocus(event,'SoLDLVToanNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVToanNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Máy tính và CNTT</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVMayTinh" onkeypress="return keydownfocus(event,'SoLDLVMayTinh',0);" runat="server" CssClass="txt-center key14_tong SoLDLVMayTinh TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVMayTinhNu" onkeypress="return keydownfocus(event,'SoLDLVMayTinhNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVMayTinhNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Công nghệ kỹ thuật</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVCongNghe" onkeypress="return keydownfocus(event,'SoLDLVCongNghe',0);" runat="server" CssClass="txt-center key14_tong SoLDLVCongNghe TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVCongNgheNu" onkeypress="return keydownfocus(event,'SoLDLVCongNgheNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVCongNgheNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Kỹ thuật</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKyThuat" onkeypress="return keydownfocus(event,'SoLDLVKyThuat',0);" runat="server" CssClass="txt-center key14_tong SoLDLVKyThuat TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKyThuatNu" onkeypress="return keydownfocus(event,'SoLDLVKyThuatNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVKyThuatNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Sản xuất và chế biến</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVSanXuat" onkeypress="return keydownfocus(event,'SoLDLVSanXuat',0);" runat="server" CssClass="txt-center key14_tong SoLDLVSanXuat TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVSanXuatNu" onkeypress="return keydownfocus(event,'SoLDLVSanXuatNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDTDDaiHocNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Kiến trúc và xây dựng</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKienTruc" onkeypress="return keydownfocus(event,'SoLDLVKienTruc',0);" runat="server" CssClass="txt-center key14_tong SoLDLVKienTruc TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKienTrucNu" onkeypress="return keydownfocus(event,'SoLDLVKienTrucNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVKienTrucNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Nông, lâm nghiệp và thủy sản</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVNongLam" onkeypress="return keydownfocus(event,'SoLDLVNongLam',0);" runat="server" CssClass="txt-center key14_tong SoLDLVNongLam TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVNongLamNu" onkeypress="return keydownfocus(event,'SoLDLVNongLamNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVNongLamNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Thú y</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVThuY" onkeypress="return keydownfocus(event,'SoLDLVThuY',0);" runat="server" CssClass="txt-center key14_tong SoLDLVThuY TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVThuYNu" onkeypress="return keydownfocus(event,'SoLDLVThuYNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVThuYNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Sức khỏe</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVSucKhoe" onkeypress="return keydownfocus(event,'SoLDLVSucKhoe',0);" runat="server" CssClass="txt-center key14_tong SoLDLVSucKhoe TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVSucKhoeNu" onkeypress="return keydownfocus(event,'SoLDLVSucKhoeNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVSucKhoeNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Dịch vụ xã hội</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVDichVuXH" onkeypress="return keydownfocus(event,'SoLDLVDichVuXH',0);" runat="server" CssClass="txt-center key14_tong SoLDLVDichVuXH TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVDichVuXHNu" onkeypress="return keydownfocus(event,'SoLDLVDichVuXHNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVDichVuXHNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Du lịch, khách sạn, thể thao và dịch vụ cá nhân</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVDuLich" onkeypress="return keydownfocus(event,'SoLDLVDuLich',0);" runat="server" CssClass="txt-center key14_tong SoLDLVDuLich TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVDuLichNu" onkeypress="return keydownfocus(event,'SoLDLVDuLichNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVDuLichNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Dịch vụ vận tải</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVDichVuVT" onkeypress="return keydownfocus(event,'SoLDLVDichVuVT',0);" runat="server" CssClass="txt-center key14_tong SoLDLVDichVuVT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVDichVuVTNu" onkeypress="return keydownfocus(event,'SoLDLVDichVuVTNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVDichVuVTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Môi trường và bảo vệ môi trường</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVMoiTruong" onkeypress="return keydownfocus(event,'SoLDLVMoiTruong',0);" runat="server" CssClass="txt-center key14_tong SoLDLVMoiTruong TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVMoiTruongNu" onkeypress="return keydownfocus(event,'SoLDLVMoiTruongNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVMoiTruongNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>An ninh, quốc phòng</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVAnNinh" onkeypress="return keydownfocus(event,'SoLDLVAnNinh',0);" runat="server" CssClass="txt-center key14_tong SoLDLVAnNinh TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVAnNinhNu" onkeypress="return keydownfocus(event,'SoLDLVAnNinhNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVAnNinhNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Khác</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhac" onkeypress="return keydownfocus(event,'SoLDLVKhac',0);" runat="server" CssClass="txt-center key14_tong SoLDLVKhac TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDLVKhacNu" onkeypress="return keydownfocus(event,'SoLDLVKhacNu',0);" runat="server" CssClass="txt-center key14_tongnu SoLDLVKhacNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo14" onkeypress="return keydownfocus(event,'TongSo14',0);" runat="server" CssClass="txt-center TongSo14 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo14Nu" onkeypress="return keydownfocus(event,'TongSo14Nu',0);" runat="server" CssClass="txt-center TongSo14Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">15. Số lao động theo nhóm nghề (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Mã nghề cấp 2</th>
                                        <th scope="col">Tên gọi nghề nghiệp</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td class="w-10">1</td>
                                        <td>Lãnh đạo doanh nghiệp</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNLanhDao" onkeypress="return keydownfocus(event,'SoLDNNLanhDao',0);" runat="server" CssClass="txt-center key15_tong SoLDNNLanhDao TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNLanhDaoNu" onkeypress="return keydownfocus(event,'SoLDNNLanhDaoNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNLanhDaoNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10">2</td>
                                        <td>Chuyên môn kỹ thuật bậc cao</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNKyThuatBC" onkeypress="return keydownfocus(event,'SoLDNNKyThuatBC',0);" runat="server" CssClass="txt-center key15_tong SoLDNNKyThuatBC TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNKyThuatBCNu" onkeypress="return keydownfocus(event,'SoLDNNKyThuatBCNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNKyThuatBCNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10">3</td>
                                        <td>Chuyên môn kỹ thuật bậc trung</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNKyThuatBT" onkeypress="return keydownfocus(event,'SoLDNNKyThuatBT',0);" runat="server" CssClass="txt-center key15_tong SoLDNNKyThuatBT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNKyThuatBTNu" onkeypress="return keydownfocus(event,'SoLDNNKyThuatBTNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNKyThuatBTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10">4</td>
                                        <td>Nhân viên (nghề nghiệp sơ cấp, nhân viên văn phòng)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNNhanVienNghe" onkeypress="return keydownfocus(event,'SoLDNNNhanVienNghe',0);" runat="server" CssClass="txt-center key15_tong SoLDNNNhanVienNghe TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNNhanVienNgheNu" onkeypress="return keydownfocus(event,'SoLDNNNhanVienNgheNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNNhanVienNgheNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10">5</td>
                                        <td>Nhân viên dịch vụ cá nhân, bảo vệ trật tự - an toàn xã hội và bán hàng có kỹ thuật</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNNhanVienDV" onkeypress="return keydownfocus(event,'SoLDNNNhanVienDV',0);" runat="server" CssClass="txt-center key15_tong SoLDNNNhanVienDV TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNNhanVienDVNu" onkeypress="return keydownfocus(event,'SoLDNNNhanVienDVNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNNhanVienDVNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10">6</td>
                                        <td>Lao động có kỹ thuật trong nông nghiệp, lâm nghiệp và thủy sản</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNLaoDongCoKT" onkeypress="return keydownfocus(event,'SoLDNNLaoDongCoKT',0);" runat="server" CssClass="txt-center key15_tong SoLDNNLaoDongCoKT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNLaoDongCoKTNu" onkeypress="return keydownfocus(event,'SoLDNNLaoDongCoKTNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNLaoDongCoKTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10">7</td>
                                        <td>Thợ thủ công có kỹ thuật và các thợ kỹ thuật khác có liên quan</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNThoThuCong" onkeypress="return keydownfocus(event,'SoLDNNThoThuCong',0);" runat="server" CssClass="txt-center key15_tong SoLDNNThoThuCong TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNThoThuCongNu" onkeypress="return keydownfocus(event,'SoLDNNThoThuCongNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNThoThuCongNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10">8</td>
                                        <td>Thợ có kỹ thuật lắp ráp và vận hành máy móc, thiết bị</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNThoKyThuat" onkeypress="return keydownfocus(event,'SoLDNNThoKyThuat',0);" runat="server" CssClass="txt-center key15_tong SoLDNNThoKyThuat TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNThoKyThuatNu" onkeypress="return keydownfocus(event,'SoLDNNThoKyThuatNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNThoKyThuatNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10">9</td>
                                        <td>Lao động phổ thông</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNLaoDongPT" onkeypress="return keydownfocus(event,'SoLDNNLaoDongPT',0);" runat="server" CssClass="txt-center key15_tong SoLDNNLaoDongPT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDNNLaoDongPTNu" onkeypress="return keydownfocus(event,'SoLDNNLaoDongPTNu',0);" runat="server" CssClass="txt-center key15_tongnu SoLDNNLaoDongPTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2"><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo15" onkeypress="return keydownfocus(event,'TongSo15',0);" runat="server" CssClass="txt-center TongSo15 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo15Nu" onkeypress="return keydownfocus(event,'TongSo15Nu',0);" runat="server" CssClass="txt-center TongSo15Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">16. Số lao động theo trình độ ngoại ngữ và tin học (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Về ngoại ngữ</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Ngoại ngữ (tiếng Anh)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTiengAnh" onkeypress="return keydownfocus(event,'SoLDTDTiengAnh',0);" runat="server" CssClass="txt-center key_tong16nn SoLDTDTiengAnh TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTiengAnhNu" onkeypress="return keydownfocus(event,'SoLDTDTiengAnhNu',0);" runat="server" CssClass="txt-center key_tong16nnnu SoLDTDTiengAnhNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Ngoại ngữ (tiếng Trung)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTiengTrung" onkeypress="return keydownfocus(event,'SoLDTDTiengTrung',0);" runat="server" CssClass="txt-center key_tong16nn SoLDTDTiengTrung TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTiengTrungNu" onkeypress="return keydownfocus(event,'SoLDTDTiengTrungNu',0);" runat="server" CssClass="txt-center key_tong16nnnu SoLDTDTiengTrungNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Ngoại ngữ (tiếng Nhật, tiếng Hàn)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTiengNhat" onkeypress="return keydownfocus(event,'SoLDTDTiengNhat',0);" runat="server" CssClass="txt-center key_tong16nn SoLDTDTiengNhat TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTiengNhatNu" onkeypress="return keydownfocus(event,'SoLDTDTiengNhatNu',0);" runat="server" CssClass="txt-center txt-center key_tong16nnnu SoLDTDTiengNhatNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Ngoại ngữ khác </td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTiengKhac" onkeypress="return keydownfocus(event,'SoLDTDTiengKhac',0);" runat="server" CssClass="txt-center key_tong16nn SoLDTDTiengKhac TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTiengKhacNu" onkeypress="return keydownfocus(event,'SoLDTDTiengKhacNu',0);" runat="server" CssClass="txt-center txt-center key_tong16nnnu SoLDTDTiengKhacNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo16NN" onkeypress="return keydownfocus(event,'TongSo16NN',0);" runat="server" CssClass="txt-center TongSo16NN TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo16NNNu" onkeypress="return keydownfocus(event,'TongSo16NNNu',0);" runat="server" CssClass="txt-center TongSo16NNNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Về tin học</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tin học cơ bản (Word, Excel, Powerpoint)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTinHocCB" onkeypress="return keydownfocus(event,'SoLDTDTinHocCB',0);" runat="server" CssClass="txt-center key_tong16th SoLDTDTinHocCB TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTinHocCBNu" onkeypress="return keydownfocus(event,'SoLDTDTinHocCBNu',0);" runat="server" CssClass="txt-center key_tong16thnu SoLDTDTinHocCBNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Tin học nâng cao (sử dụng được các phần mềm)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTinHocNC" onkeypress="return keydownfocus(event,'SoLDTDTinHocNC',0);" runat="server" CssClass="txt-center key_tong16th SoLDTDTinHocNC TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTinHocNCNu" onkeypress="return keydownfocus(event,'SoLDTDTinHocNCNu',0);" runat="server" CssClass="txt-center key_tong16thnu SoLDTDTinHocNCNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Tin học nâng cao (lập trình, thiết kế phần mềm….)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTinHocNC2" onkeypress="return keydownfocus(event,'SoLDTDTinHocNC2',0);" runat="server" CssClass="txt-center key_tong16th SoLDTDTinHocNC2 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="SoLDTDTinHocNC2Nu" onkeypress="return keydownfocus(event,'SoLDTDTinHocNC2Nu',0);" runat="server" CssClass="txt-center key_tong16thnu SoLDTDTinHocNC2Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo16TH" onkeypress="return keydownfocus(event,'TongSo16TH',0);" runat="server" CssClass="txt-center TongSo16TH TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo16THNu" onkeypress="return keydownfocus(event,'TongSo16THNu',0);" runat="server" CssClass="txt-center TongSo16THNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">17.Tiền lương: (1.000đ/người/tháng)</div>
                            <div class="col-md-12 ">
                                <div class="col-md-6 i pdt5">
                                    - Tiền lương bình quân 6 tháng đầu năm
                                </div>
                                <div class="col-md-6">
                                    <asp:TextBox ID="TienLuongBinhQuan" placeholder="Nhập giá trị số" runat="server" CssClass="TextBox validate[custom[integer]]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-6 i pdt5">
                                    - Tiền lương thấp nhất trong 6 tháng đầu năm
                                </div>
                                <div class="col-md-6">
                                    <asp:TextBox ID="TienLuongThapNhat" placeholder="Nhập giá trị số" runat="server" CssClass="TextBox validate[custom[integer]]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-6 i pdt5">
                                    - Tiền lương cao nhất trong 6 tháng đầu năm
                                </div>
                                <div class="col-md-6">
                                    <asp:TextBox ID="TienLuongCaoNhat" placeholder="Nhập giá trị số" runat="server" CssClass="TextBox validate[custom[integer]]" />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">18. Đánh giá của doanh nghiệp về mức độ đáp ứng kỹ năng của người lao động phân theo nhóm nghề</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Mã nghề cấp 2</th>
                                        <th scope="col">Tên gọi nghề nghiệp</th>
                                        <th scope="col">3 kỹ năng quan trọng nhất</th>
                                        <th scope="col">Mức độ đáp ứng</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td colspan="4"><b>Đánh giá</b></td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">1</td>
                                        <td rowspan="3">Lãnh đạo doanh nghiệp</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia11KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia11MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia12KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia12MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia13KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia13MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">2</td>
                                        <td rowspan="3">Chuyên môn kỹ thuật bậc cao</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia21KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia21MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia22KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia22MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia23KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia23MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">3</td>
                                        <td rowspan="3">Chuyên môn kỹ thuật bậc trung</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia31KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia31MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia32KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia32MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia33KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia33MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">4</td>
                                        <td rowspan="3">Nhân viên (nghề nghiệp sơ cấp, nhân viên văn phòng)</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia41KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia41MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia42KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia42MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia43KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia43MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">5</td>
                                        <td rowspan="3">Nhân viên dịch vụ cá nhân, bảo vệ trật tự - an toàn xã hội và bán hàng có kỹ thuật</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia51KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia51MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia52KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia52MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia53KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia53MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">6</td>
                                        <td rowspan="3">Lao động có kỹ thuật trong nông nghiệp, lâm nghiệp và thủy sản</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia61KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia61MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia62KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia62MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia63KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia63MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">7</td>
                                        <td rowspan="3">Thợ thủ công có kỹ thuật và các thợ kỹ thuật khác có liên quan</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia71KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia71MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia72KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia72MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia73KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia73MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">8</td>
                                        <td rowspan="3">Thợ có kỹ thuật lắp ráp và vận hành máy móc, thiết bị</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia81KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia81MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia82KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia82MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia83KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia83MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-10" rowspan="3">9</td>
                                        <td rowspan="3">Lao động phổ thông</td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia91KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia91MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia92KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia92MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia93KN" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                        <td class="w-25">
                                            <asp:DropDownList ID="DanhGia93MD" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                        </div>
                        <div class="row box-info pd0 boxg1" id="tinhtrangvieclam">
                            <div class="title-ho bgt1">III.Nhu cầu tuyển dụng trong thời gian tới</div>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">19. Nhu cầu tuyển dụng lao động phân theo nhóm ngành kinh tế (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Nhóm ngành kinh tế</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Nông, lâm nghiệp và thủy sản</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauNNNongLam" onkeypress="return keydownfocus(event,'NhuCauNNNongLam',0);" runat="server" CssClass="txt-center key_tong19 NhuCauNNNongLam TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauNNNongLamNu" onkeypress="return keydownfocus(event,'NhuCauNNNongLamNu',0);" runat="server" CssClass="txt-center key_tong19nu NhuCauNNNongLamNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Công nghiệp và xây dựng</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauNNCongNghiep" onkeypress="return keydownfocus(event,'NhuCauNNCongNghiep',0);" runat="server" CssClass="txt-center key_tong19 NhuCauNNCongNghiep TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauNNCongNghiepNu" onkeypress="return keydownfocus(event,'NhuCauNNCongNghiepNu',0);" runat="server" CssClass="txt-center key_tong19nu NhuCauNNCongNghiepNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Thương mại và dịch vụ</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauNNThuongMai" onkeypress="return keydownfocus(event,'NhuCauNNThuongMai',0);" runat="server" CssClass="txt-center key_tong19 NhuCauNNThuongMai TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauNNThuongMaiNu" onkeypress="return keydownfocus(event,'NhuCauNNThuongMaiNu',0);" runat="server" CssClass="txt-center key_tong19nu NhuCauNNThuongMaiNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo19" onkeypress="return keydownfocus(event,'TongSo19',0);" runat="server" CssClass="txt-center TongSo19 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo19Nu" onkeypress="return keydownfocus(event,'TongSo19Nu',0);" runat="server" CssClass="txt-center TongSo19Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">20. Nhu cầu tuyển dụng lao động theo trình độ chuyên môn kỹ thuật (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Trình độ chuyên môn kỹ thuật</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Lãnh đạo không có TĐ CMKT</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDLanhDao" onkeypress="return keydownfocus(event,'NhuCauTDLanhDao',0);" runat="server" CssClass="txt-center key_tong20 NhuCauTDLanhDao TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDLanhDaoNu" onkeypress="return keydownfocus(event,'NhuCauTDLanhDaoNu',0);" runat="server" CssClass="txt-center key_tong20nu NhuCauTDLanhDaoNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Sơ cấp</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDSoCap" onkeypress="return keydownfocus(event,'NhuCauTDSoCap',0);" runat="server" CssClass="txt-center key_tong20 NhuCauTDSoCap TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDSoCapNu" onkeypress="return keydownfocus(event,'NhuCauTDSoCapNu',0);" runat="server" CssClass="txt-center key_tong20nu NhuCauTDSoCapNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Trung cấp</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTrungCap" onkeypress="return keydownfocus(event,'NhuCauTDTrungCap',0);" runat="server" CssClass="txt-center key_tong20 NhuCauTDTrungCap TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTrungCapNu" onkeypress="return keydownfocus(event,'NhuCauTDTrungCapNu',0);" runat="server" CssClass="txt-center key_tong20nu NhuCauTDTrungCapNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Cao đẳng</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDCaoDang" onkeypress="return keydownfocus(event,'NhuCauTDCaoDang',0);" runat="server" CssClass="txt-center key_tong20 NhuCauTDCaoDang TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDCaoDangNu" onkeypress="return keydownfocus(event,'NhuCauTDCaoDangNu',0);" runat="server" CssClass="txt-center key_tong20nu NhuCauTDCaoDangNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Đại học trở lên</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDDaiHoc" onkeypress="return keydownfocus(event,'NhuCauTDDaiHoc',0);" runat="server" CssClass="txt-center key_tong20 NhuCauTDDaiHoc TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDDaiHocNu" onkeypress="return keydownfocus(event,'NhuCauTDDaiHocNu',0);" runat="server" CssClass="txt-center key_tong20nu NhuCauTDDaiHocNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo20" onkeypress="return keydownfocus(event,'TongSo20',0);" runat="server" CssClass="txt-center TongSo20 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo20Nu" onkeypress="return keydownfocus(event,'TongSo20Nu',0);" runat="server" CssClass="txt-center TongSo20Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">21. Nhu cầu tuyển dụng lao động của doanh nghiệp theo nhóm nghề (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Nhóm nghề (vị trí tuyển dụng)</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Lãnh đạo doanh nghiệp</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauLDNNLanhDao" onkeypress="return keydownfocus(event,'NhuCauLDNNLanhDao',0);" runat="server" CssClass="txt-center key_tong21 NhuCauLDNNLanhDao TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNLanhDaoNu" onkeypress="return keydownfocus(event,'NhuCauTDNNLanhDaoNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNLanhDaoNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Chuyên môn kỹ thuật bậc cao</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNChuyenMonBC" onkeypress="return keydownfocus(event,'NhuCauTDNNChuyenMonBC',0);" runat="server" CssClass="txt-center key_tong21 NhuCauTDNNChuyenMonBC TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNChuyenMonBCNu" onkeypress="return keydownfocus(event,'NhuCauTDNNChuyenMonBCNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNChuyenMonBCNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Chuyên môn kỹ thuật bậc trung</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNChuyenMocBT" onkeypress="return keydownfocus(event,'NhuCauTDNNChuyenMocBT',0);" runat="server" CssClass="txt-center key_tong21 NhuCauTDNNChuyenMocBT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNChuyenMonBTNu" onkeypress="return keydownfocus(event,'NhuCauTDNNChuyenMonBTNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNChuyenMonBTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Nhân viên (nghề nghiệp sơ cấp, nhân viên văn phòng)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNNhanVienNN" onkeypress="return keydownfocus(event,'NhuCauTDNNNhanVienNN',0);" runat="server" CssClass="txt-center key_tong21 NhuCauTDNNNhanVienNN TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNNhanVienNNNu" onkeypress="return keydownfocus(event,'NhuCauTDNNNhanVienNNNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNNhanVienNNNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Nhân viên dịch vụ cá nhân, bảo vệ trật tự - an toàn xã hội và bán hàng có kỹ thuật</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNNhanVienDV" onkeypress="return keydownfocus(event,'NhuCauTDNNNhanVienDV',0);" runat="server" CssClass="txt-center key_tong21 NhuCauTDNNNhanVienDV TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNNhanVienDVNu" onkeypress="return keydownfocus(event,'NhuCauTDNNNhanVienDVNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNNhanVienDVNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Lao động có kỹ thuật trong nông nghiệp, lâm nghiệp và thủy sản</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNLaoDongKT" onkeypress="return keydownfocus(event,'NhuCauTDNNLaoDongKT',0);" runat="server" CssClass="txt-center key_tong21 NhuCauTDNNLaoDongKT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNLaoDongKTNu" onkeypress="return keydownfocus(event,'NhuCauTDNNLaoDongKTNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNLaoDongKTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Thợ thủ công có kỹ thuật và các thợ kỹ thuật  khác có liên quan</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNThoTC" onkeypress="return keydownfocus(event,'NhuCauTDNNThoTC',0);" runat="server" CssClass="txt-center key_tong21 NhuCauTDNNThoTC TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNThoTCNu" onkeypress="return keydownfocus(event,'NhuCauTDNNThoTCNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNThoTCNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Thợ có kỹ thuật lắp ráp và vận hành máy móc, thiết bị</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNThoKT" onkeypress="return keydownfocus(event,'NhuCauTDNNThoKT',0);" runat="server" CssClass="txt-center key_tong21 NhuCauTDNNThoKT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNThoKTNu" onkeypress="return keydownfocus(event,'NhuCauTDNNThoKTNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNThoKTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Lao động phổ thông</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNLaoDongPT" onkeypress="return keydownfocus(event,'NhuCauTDNNLaoDongPT',0);" runat="server" CssClass="txt-center key_tong21 NhuCauTDNNLaoDongPT TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDNNLaoDongPTNu" onkeypress="return keydownfocus(event,'NhuCauTDNNLaoDongPTNu',0);" runat="server" CssClass="txt-center key_tong21nu NhuCauTDNNLaoDongPTNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo21" onkeypress="return keydownfocus(event,'TongSo21',0);" runat="server" CssClass="txt-center TongSo21 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo21Nu" onkeypress="return keydownfocus(event,'TongSo21Nu',0);" runat="server" CssClass="txt-center TongSo21Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">22. Nhu cầu tuyển dụng lao động của doanh nghiệp theo trình độ ngoại ngữ và tin học (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Yêu cầu về ngoại ngữ</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Ngoại ngữ (tiếng Anh)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTiengAnh" onkeypress="return keydownfocus(event,'NhuCauTDTDTiengAnh',0);" runat="server" CssClass="txt-center key_tong22nn NhuCauTDTDTiengAnh TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTiengAnhNu" onkeypress="return keydownfocus(event,'NhuCauTDTDTiengAnhNu',0);" runat="server" CssClass="txt-center key_tong22nnnu NhuCauTDTDTiengAnhNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Ngoại ngữ (tiếng Trung)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTiengTrung" onkeypress="return keydownfocus(event,'NhuCauTDTDTiengTrung',0);" runat="server" CssClass="txt-center key_tong22nn NhuCauTDTDTiengTrung TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTiengTrungNu" onkeypress="return keydownfocus(event,'NhuCauTDTDTiengTrungNu',0);" runat="server" CssClass="txt-center key_tong22nnnu NhuCauTDTDTiengTrungNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Ngoại ngữ (tiếng Nhật, tiếng Hàn)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTiengHN" onkeypress="return keydownfocus(event,'NhuCauTDTDTiengHN',0);" runat="server" CssClass="txt-center key_tong22nn NhuCauTDTDTiengHN TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTiengHNNu" onkeypress="return keydownfocus(event,'NhuCauTDTDTiengHNNu',0);" runat="server" CssClass="txt-center key_tong22nnnu NhuCauTDTDTiengHNNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Ngoại ngữ khác </td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTiengKhac" onkeypress="return keydownfocus(event,'NhuCauTDTDTiengKhac',0);" runat="server" CssClass="txt-center key_tong22nn NhuCauTDTDTiengKhac TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTiengKhacNu" onkeypress="return keydownfocus(event,'NhuCauTDTDTiengKhacNu',0);" runat="server" CssClass="txt-center key_tong22nnnu NhuCauTDTDTiengKhacNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo22NN" onkeypress="return keydownfocus(event,'TongSo22NN',0);" runat="server" CssClass="txt-center TongSo22NN TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo22NNNu" onkeypress="return keydownfocus(event,'TongSo22NNNu',0);" runat="server" CssClass="txt-center TongSo22NNNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Yêu cầu về tin học</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tin học cơ bản (Word, Excel, Powerpoint)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTinHocCB" onkeypress="return keydownfocus(event,'NhuCauTDTDTinHocCB',0);" runat="server" CssClass="txt-center key_tong22th NhuCauTDTDTinHocCB TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTinHocCBNu" onkeypress="return keydownfocus(event,'NhuCauTDTDTinHocCBNu',0);" runat="server" CssClass="txt-center key_tong22thnu NhuCauTDTDTinHocCBNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Tin học nâng cao (sử dụng được các phần mềm)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTinHocNC" onkeypress="return keydownfocus(event,'NhuCauTDTDTinHocNC',0);" runat="server" CssClass="txt-center key_tong22th NhuCauTDTDTinHocNC TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTinHocNCNu" onkeypress="return keydownfocus(event,'NhuCauTDTDTinHocNCNu',0);" runat="server" CssClass="txt-center key_tong22thnu NhuCauTDTDTinHocNCNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Tin học nâng cao (lập trình, thiết kế phần mềm….)</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTinHocNC2" onkeypress="return keydownfocus(event,'NhuCauTDTDTinHocNC2',0);" runat="server" CssClass="txt-center key_tong22th NhuCauTDTDTinHocNC2 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDTDTinHocNC2Nu" onkeypress="return keydownfocus(event,'NhuCauTDTDTinHocNC2Nu',0);" runat="server" CssClass="txt-center key_tong22thnu NhuCauTDTDTinHocNC2Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td><span class="lbl-right">TỔNG</span></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo22TH" onkeypress="return keydownfocus(event,'TongSo22TH',0);" runat="server" CssClass="txt-center TongSo22TH TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="TongSo22THNu" onkeypress="return keydownfocus(event,'TongSo22THNu',0);" runat="server" CssClass="txt-center TongSo22THNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">23. Nhu cầu tuyển dụng lao động của doanh nghiệp theo mức lương (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Theo mức lương</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Thỏa thuận</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDMLThoaThuan" onkeypress="return keydownfocus(event,'NhuCauTDMLThoaThuan',0);" runat="server" CssClass="txt-center NhuCauTDMLThoaThuan TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDMLThoaThuanNu" onkeypress="return keydownfocus(event,'NhuCauTDMLThoaThuanNu',0);" runat="server" CssClass="txt-center NhuCauTDMLThoaThuanNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 3 đến 5 triệu</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML3" onkeypress="return keydownfocus(event,'NhuCauTDML3',0);" runat="server" CssClass="txt-center NhuCauTDML3 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML3Nu" onkeypress="return keydownfocus(event,'NhuCauTDML3Nu',0);" runat="server" CssClass="txt-center NhuCauTDML3Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 5 đến 7 triệu</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML5" onkeypress="return keydownfocus(event,'NhuCauTDML5',0);" runat="server" CssClass="txt-center NhuCauTDML5 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML5Nu" onkeypress="return keydownfocus(event,'NhuCauTDML5Nu',0);" runat="server" CssClass="txt-center NhuCauTDML5Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 7 đến 10 triệu</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML7" onkeypress="return keydownfocus(event,'NhuCauTDML7',0);" runat="server" CssClass="txt-center NhuCauTDML7 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML7Nu" onkeypress="return keydownfocus(event,'NhuCauTDML7Nu',0);" runat="server" CssClass="txt-center NhuCauTDML7Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 10 đến 15 triệu</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML10" onkeypress="return keydownfocus(event,'NhuCauTDML10',0);" runat="server" CssClass="txt-center NhuCauTDML10 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML10Nu" onkeypress="return keydownfocus(event,'NhuCauTDML10Nu',0);" runat="server" CssClass="txt-center NhuCauTDML10Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 15 triệu trở lên</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML15" onkeypress="return keydownfocus(event,'NhuCauTDML15',0);" runat="server" CssClass="txt-center NhuCauTDML15 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTDML15Nu" onkeypress="return keydownfocus(event,'NhuCauTDML15Nu',0);" runat="server" CssClass="txt-center NhuCauTDML15Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">24. Nhu cầu tuyển dụng lao động của doanh nghiệp theo kinh nghiệm làm việc (người)</div>
                            <div class="clear"></div>
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th scope="col">Kinh nghiệm làm việc</th>
                                        <th scope="col">Số lượng</th>
                                        <th scope="col">Trong đó: nữ</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Chưa có kinh nghiệm</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKNChua" onkeypress="return keydownfocus(event,'NhuCauTBKNChua',0);" runat="server" CssClass="txt-center NhuCauTBKNChua TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKNChuaNu" onkeypress="return keydownfocus(event,'NhuCauTBKNChuaNu',0);" runat="server" CssClass="txt-center NhuCauTBKNChuaNu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 1 đến dưới 3 năm</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKN1" onkeypress="return keydownfocus(event,'NhuCauTBKN1',0);" runat="server" CssClass="txt-center NhuCauTBKN1 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKN1Nu" onkeypress="return keydownfocus(event,'NhuCauTBKN1Nu',0);" runat="server" CssClass="txt-center NhuCauTBKN1Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 3 đến dưới 5 năm</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKN3" onkeypress="return keydownfocus(event,'NhuCauTBKN3',0);" runat="server" CssClass="txt-center NhuCauTBKN3 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKN3Nu" onkeypress="return keydownfocus(event,'NhuCauTBKN3Nu',0);" runat="server" CssClass="txt-center NhuCauTBKN3Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 5 năm trở lên</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKN5" onkeypress="return keydownfocus(event,'NhuCauTBKN5',0);" runat="server" CssClass="txt-center NhuCauTBKN5 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKN5Nu" onkeypress="return keydownfocus(event,'NhuCauTBKN5Nu',0);" runat="server" CssClass="txt-center NhuCauTBKN5Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td>Từ 10 triệu trở lên</td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKN10" onkeypress="return keydownfocus(event,'NhuCauTBKN10',0);" runat="server" CssClass="txt-center NhuCauTBKN10 TextBox validate[custom[integer]]" /></td>
                                        <td class="w-25">
                                            <asp:TextBox ID="NhuCauTBKN10Nu" onkeypress="return keydownfocus(event,'NhuCauTBKN10Nu',0);" runat="server" CssClass="txt-center NhuCauTBKN10Nu TextBox validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="clear"></div>
                            <div class="col-md-6 b pdt5">25. Doanh nghiệp có gặp khó khăn trong việc tuyển dụng lao động không?</div>
                            <div class="col-md-1 pdt5">
                                <asp:RadioButton runat="server" GroupName="TTTGHDKT" Checked="false" CssClass="rdDNCKK" ID="KhoKhanTDLDCo" Text="Có" />
                            </div>
                            <div class="col-md-1 pdt5">
                                <asp:RadioButton runat="server" GroupName="TTTGHDKT" Checked="true" CssClass="rdDNKKK" ID="KhoKhanTDLDKhong" Text="Không" />
                            </div>
                            <div class="clear"></div>
                            <div class="dnkhokhanco none">
                                <div class="row p-10">
                                    <div class="col-md-3 b pdt5">&nbsp;&nbsp;a. Khó khăn từ phía người lao động</div>
                                    <div class="col-md-9">
                                        <asp:CheckBoxList ID="KhoKhanPhiaLD" RepeatColumns="2" runat="server" CssClass="tbCheckList" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="row p-10">
                                    <div class="col-md-3 b pdt5">&nbsp;&nbsp;b. Khó khăn từ phía doanh nghiệp</div>
                                    <div class="col-md-9">
                                        <asp:CheckBoxList ID="KhoKhanPhiaDN" RepeatColumns="2" runat="server" CssClass="tbCheckList" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 b pdt5">&nbsp;&nbsp;Khác (Ghi cụ thể)</div>
                                <div class="col-md-10">
                                    <asp:TextBox ID="KhoKhanPhiaDNKhac" runat="server" CssClass="TextBox KhoKhanPhiaDNKhac" />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="26banhomtt">
                                <div class="col-md-12 b pdt5">26. Xin cho biết 3 nhóm trình độ CMKT và 3 nhóm nghề khó tuyển dụng nhất trong vòng 1 năm qua của doanh nghiệp?</div>
                                <div class="clear"></div>
                                <div class="row p-10">
                                    <div class="col-md-3 b pdt5">&nbsp;&nbsp;a.	3 nhóm trình độ CMKT khó tuyển dụng nhất</div>
                                    <div class="col-md-9">
                                        <asp:CheckBoxList ID="NhomTrinhDoCMKT" RepeatColumns="2" runat="server" CssClass="tbCheckList" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="row p-10">
                                    <div class="col-md-3 b pdt5">&nbsp;&nbsp;b.	3 nhóm nghề khó tuyển dụng nhất</div>
                                    <div class="col-md-9">
                                        <asp:CheckBoxList ID="NhomNgheKTD" RepeatColumns="2" runat="server" CssClass="tbCheckList" />
                                    </div>
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">27. Doanh nghiệp tuyển lao động qua các hình thức nào là chủ yếu?</div>
                            <div class="col-md-12">
                                <asp:CheckBoxList ID="HinhThucTuyenDung" RepeatColumns="2" runat="server" CssClass="tbCheckList" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2 b pdt5">&nbsp;&nbsp;Khác (Ghi cụ thể)</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="HinhThucTuyenDungKhac" MaxLength="250" runat="server" CssClass="TextBox TenDoanhNghiep" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-6 b pdt5">28. Doanh nghiệp đã từng liên kết, phối hợp với các Trung tâm Dịch vụ việc làm trên địa bàn không?</div>
                            <div class="col-md-1 pdt5">
                                <asp:RadioButton runat="server" GroupName="DNDTLK" Checked="false" CssClass="rdDNLKCo" ID="TungLienKetCo" Text="Có" />
                            </div>
                            <div class="col-md-1 pdt5">
                                <asp:RadioButton runat="server" GroupName="DNDTLK" Checked="true" CssClass="rdDNLKKhong" ID="TungLienKetKhong" Text="Không" />
                            </div>
                            <div class="clear"></div>
                            <div class="row dnhoptac none">
                                <div class="col-md-12">
                                    <asp:CheckBoxList ID="DaHopTac" RepeatColumns="2" runat="server" CssClass="tbCheckList" />
                                </div>
                                <div class="col-md-3 pdt5 b">Khác (ghi cụ thể)</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="DaHopTacKhac" runat="server" CssClass="TextBox DaHopTacKhac" />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 b pdt5">29. Doanh nghiệp có gặp khó khăn/vướng mắc gì trong hợp tác với các Trung tâm dịch vụ việc làm không? (ghi cụ thể khó khăn/vướng mắc hoặc đề xuất để tăng hiệu quả hợp tác)</div>
                            <div class="col-md-12">
                                <asp:TextBox ID="KhoKhanVuongMac" MaxLength="500" TextMode="MultiLine" Height="60" runat="server" CssClass="TextBox TenDoanhNghiep" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="row box-info pd0 boxg1" id="tinhtrangthatnghiep">
                            <div class="title-ho bgt1">IV.KHUYẾN NGHỊ CỦA DOANH NGHIỆP</div>
                            <div class="clear"></div>
                            <div class="col-md-12">
                                <asp:TextBox ID="KhuyenNghi" TextMode="MultiLine" Height="200" runat="server" CssClass="TextBox TenDoanhNghiep" />
                            </div>
                        </div>
                        <asp:Literal ID="litUpdate" runat="server" />
                    </div>
                    <asp:HiddenField ID="ItemID" runat="server" Visible="true" />
                </div>
            </div>
            <div class="fix-btt-toolbar pdt5">
                <div>
                    <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                    <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate " OnClientClick="return $('#Form').validationEngine('validate'); " />
                    <%--  <asp:Button ID="cmdExport" runat="server" Text="Tải phiếu điều tra" OnClientClick="popdoc('exports'); return false;" CssClass="cmsbut cmsbtDownload cbclick" />--%>
                    <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmdDel cbclick" />
                    <div class="clr pdt5"></div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
<script>
    $(document).ready(function () {
        $('.rdDNCKK').click(function () {
            loaddnkhokhanco(1);
        });
        $('.rdDNKKK').click(function () {
            loaddnkhokhanco(0);
        });
        $('.rdDNLKCo').click(function () {
            loaddnhoptac(1);
        });
        $('.rdDNLKKhong').click(function () {
            loaddnhoptac(0);
        });
        loadchange();
    });

    function loaddnkhokhanco(isActive) {
        $('.dnkhokhanco').addClass('none');
        $('.26banhomtt').addClass('none');
        if (isActive > 0) {
            $('.dnkhokhanco').removeClass('none');
            $('.26banhomtt').addClass('none');
        }
        else {
            $('.dnkhokhanco').addClass('none');
            $('.26banhomtt').removeClass('none');
        }
    }
    
    function loaddnhoptac(isActive) {
        $('.dnhoptac').addClass('none');
        if (isActive > 0) {
            $('.dnhoptac').removeClass('none');
            $('#tinhtrangthatnghiep').addClass('none');
            $('#menutinhtrangthatnghiep').addClass('none');
        }
        else {
            $('.dnhoptac').addClass('none');
            $('#tinhtrangthatnghiep').removeClass('none');
            $('#menutinhtrangthatnghiep').removeClass('none');
        }
    }
    function loadchange() {
        $(".key13_tong").on("keyup change", function (e) {
            var _tongso13 = 0;
            $('.key13_tong').each(function () {
                _tongso13 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo13').val(_tongso13);
        })
        $(".key13_tongnu").on("keyup change", function (e) {
            var _tongso13nu = 0;
            $('.key13_tongnu').each(function () {
                _tongso13nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo13Nu').val(_tongso13nu);
        })
        $(".key14_tong").on("keyup change", function (e) {
            var _tongso14 = 0;
            $('.key14_tong').each(function () {
                _tongso14 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo14').val(_tongso14);
        })
        $(".key14_tongnu").on("keyup change", function (e) {
            var _tongso14nu = 0;
            $('.key14_tongnu').each(function () {
                _tongso14nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo14Nu').val(_tongso14nu);
        })
        $(".key15_tong").on("keyup change", function (e) {
            var _tongso15 = 0;
            $('.key15_tong').each(function () {
                _tongso15 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo15').val(_tongso15);
        })
        $(".key15_tongnu").on("keyup change", function (e) {
            var _tongso15nu = 0;
            $('.key15_tongnu').each(function () {
                _tongso15nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo15Nu').val(_tongso15nu);
        })
        $(".key_tong16nn").on("keyup change", function (e) {
            var _tongso16 = 0;
            $('.key_tong16nn').each(function () {
                _tongso16 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo16NN').val(_tongso16);
        })
        $(".key_tong16nnnu").on("keyup change", function (e) {
            var _tongso16nu = 0;
            $('.key_tong16nnnu').each(function () {
                _tongso16nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo16NNNu').val(_tongso16nu);
        })
        $(".key_tong16th").on("keyup change", function (e) {
            var _tongso16 = 0;
            $('.key_tong16th').each(function () {
                _tongso16 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo16TH').val(_tongso16);
        })
        $(".key_tong16thnu").on("keyup change", function (e) {
            var _tongso16nu = 0;
            $('.key_tong16thnu').each(function () {
                _tongso16nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo16THNu').val(_tongso16nu);
        })
        $(".key_tong19").on("keyup change", function (e) {
            var _tongso19 = 0;
            $('.key_tong19').each(function () {
                _tongso19 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo19').val(_tongso19);
        })
        $(".key_tong19nu").on("keyup change", function (e) {
            var _tongso19nu = 0;
            $('.key_tong19nu').each(function () {
                _tongso19nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo19Nu').val(_tongso19nu);
        })
        $(".key_tong20").on("keyup change", function (e) {
            var _tongso20 = 0;
            $('.key_tong20').each(function () {
                _tongso20 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo20').val(_tongso20);
        })
        $(".key_tong20nu").on("keyup change", function (e) {
            var _tongso20nu = 0;
            $('.key_tong20nu').each(function () {
                _tongso20nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo20Nu').val(_tongso20nu);
        })
        $(".key_tong21").on("keyup change", function (e) {
            var _tongso21 = 0;
            $('.key_tong21').each(function () {
                _tongso21 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo21').val(_tongso21);
        })
        $(".key_tong21nu").on("keyup change", function (e) {
            var _tongso21nu = 0;
            $('.key_tong21nu').each(function () {
                _tongso21nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo21Nu').val(_tongso21nu);
        })
        $(".key_tong22nn").on("keyup change", function (e) {
            var _tongso22 = 0;
            $('.key_tong22nn').each(function () {
                _tongso22 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo22NN').val(_tongso22);
        })
        $(".key_tong22nnnu").on("keyup change", function (e) {
            var _tongso22nu = 0;
            $('.key_tong22nnnu').each(function () {
                _tongso22nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo22NNNu').val(_tongso22nu);
        })
        $(".key_tong22th").on("keyup change", function (e) {
            var _tongso22 = 0;
            $('.key_tong22th').each(function () {
                _tongso22 += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo22TH').val(_tongso22);
        })
        $(".key_tong22thnu").on("keyup change", function (e) {
            var _tongso22nu = 0;
            $('.key_tong22thnu').each(function () {
                _tongso22nu += parseInt($(this).val(), 10) || 0
            })
            $('.TongSo22THNu').val(_tongso22nu);
        })
    }
    
</script>
