<%@ Control Language="vb" CodeFile="InputNLDEdit.ascx.vb" Inherits="Modules.Analy.Import.InputNLDEdit" AutoEventWireup="false" Explicit="True" %>
<style>
    .tbCheckList {
        width: 98%;
    }

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

        <div class="left-col">
            <div class="left-title "><i class="fa fa-list-ol" aria-hidden="true"></i>&nbsp;MỤC LỤC</div>
            <ol id="list-example">
                <li>
                    <a href="#thongtinphieu">Thông tin phiếu</a>
                </li>
                <li>
                    <a href="#thongtinchung">I.Thông tin chung</a>
                </li>
                <li>
                    <a href="#trinhdokynang">II.Trình độ và kỹ năng</a>
                </li>
                <li>
                    <a href="#tinhtrangvieclam">III.Tình trạng việc làm</a>
                </li>
                <li>
                    <a href="#tinhtrangthatnghiep" id="menutinhtrangthatnghiep">IV.Tình trạng thất nghiệp</a>
                </li>
                <li>
                    <a href="#nhucautimkiemvieclam" id="menunhucautimkiemvieclam">V.Nhu cầu tìm kiếm việc làm trong nước</a>
                </li>
                <li>
                    <a href="#nhucauvieclamngoainuoc" id="menunhucauvieclamngoainuoc">VI.Nhu cầu về việc làm ngoài nước</a>
                </li>
                <li>
                    <a href="#dexuatkiengnhi" id="menudexuatkiengnhi">VI.Nhu cầu về việc làm ngoài nước</a>
                </li>
            </ol>
        </div>
        <div class="content-pks">
            <div class="box box-info box-infoHo" data-spy="scroll" data-target="#list-example" data-offset="0">

                <div class="box-body">
                    <div class="col-md-12 text-center h4" id="thongtinphieu">
                        <b class="title-pks">PHIẾU KHẢO SÁT
THU THẬP, CẬP NHẬT THÔNG TIN NGƯỜI LAO ĐỘNG</b>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12">
                        <div class="col-md-2 pdt5 text-danger strong">Thời điểm khảo sát <span class="red">*</span></div>
                        <div class="col-md-4 dflex">
                            <div class="col-md-6">
                                <asp:DropDownList ID="_ThangKhaoSat" Width="50px" runat="server" CssClass="selectpicker validate[required] " />
                            </div>
                            <div class="col-md-1 pdt5">
                                Năm
                            </div>
                            <div class="col-md-5 pdt5">

                                <asp:DropDownList ID="_NamKhaoSat" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-2 pdl0 pdt5  text-danger strong">Mã phiếu</div>
                        <div class="col-md-3 ">
                            <asp:TextBox ID="_MaDoiTuong" runat="server" CssClass="TextBox validate[required] " />
                        </div>
                    </div>
                    <div class="main-body1 ">

                        <div class="col-md-12 col-xs-12">
                            <div class="row box-info pd0 boxg1" id="thongtinchung" style="min-height: 255px">
                                <div class="title-ho bgt1">I.THÔNG TIN CHUNG</div>
                                <div class="col-md-6 pdr0 none ">
                                    <div class="col-md-12 pdl0 pdb0 pdt0">Số thứ tự</div>
                                    <div class="col-md-12 pdl0 pdb0 pdt0">
                                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 b pdt5">1.Họ tên <span class="red">*</span></div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="_HoTen" runat="server" CssClass="TextBox HoTen validate[required] uppercase" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">CMND/CCCD&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="_CMND" runat="server" CssClass="TextBox CCCD uppercase validate[custom[integer]]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">2.Ngày tháng năm sinh&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:TextBox Width="100%" ID="_NamSinh" runat="server" CssClass="TextBox NgaySinh validate[required]" placeholder="dd/mm/yyyy"/>
                                    <%--<telerik:RadMaskedTextBox Mask="##/##/####" Width="100%" HideOnBlur="true" ID="_NamSinh" runat="server"  CssClass="TextBox NgaySinh validate[required] " />--%>
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">Giới tính&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0">
                                    <asp:DropDownList ID="_GioiTinh" runat="server" CssClass="selectpicker drGioiTinh validate[required]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2  pdr0 pdt5 b">3.Dân tộc</div>
                                <div class="col-md-4 pdl0">
                                    <asp:DropDownList ID="_DanToc" runat="server" CssClass=" selectpicker drDanToc" />
                                </div>
                                <div class="col-md-2  pdr0 pdt5 b">Tôn giáo: </div>
                                <div class="col-md-4 pdl0">
                                    <asp:DropDownList ID="_TonGiao" runat="server" CssClass=" selectpicker drDanToc" />
                                </div>
                                <div class="clear"></div>
                                <asp:UpdatePanel runat="server" ID="pnDONVI">
                                    <ContentTemplate>
                                        <div class="col-md-2  pdr0 pdt5 b">4.Địa chỉ thường trú <span class="red">*</span></div>
                                        <div class="col-md-3 ">
                                            <asp:DropDownList ID="_MaTinh" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP validate[required]" />
                                        </div>
                                        <div class="col-md-3 ">
                                            <asp:DropDownList ID="_MaHuyen" runat="server" AutoPostBack="true" CssClass="selectpicker drQuanHuyen validate[required]" />
                                        </div>
                                        <div class="col-md-4">
                                            <asp:DropDownList ID="_MaXa" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa validate[required]" />
                                        </div>
                                        <div class="col-md-3 none">
                                            <asp:DropDownList ID="_MaThon" runat="server" AutoPostBack="true" CssClass="selectpicker drThonTo " />
                                        </div>
                                        <div class="col-md-2 pdr0">5.Nơi ở hiện tại <span class="red">*</span></div>
                                        <div class="col-md-1 pdr0">
                                            <asp:CheckBox runat="server" ID="chkSuDungLaiThuongTru" OnCheckedChanged="chkSuDungLaiThuongTru_CheckedChanged" AutoPostBack="true" ToolTip="Sử dụng lại địa chỉ thường trú" />
                                        </div>
                                        <div class="col-md-9">
                                            <asp:TextBox ID="DiaChi_HT" ToolTip="Nhập địa chỉ cụ thể (số nhà, đường phố)" placeholder="Nhập địa chỉ cụ thể (số nhà, đường phố)" runat="server" CssClass="TextBox DiaChi_HT validate[required]" />
                                        </div>
                                        <div class="clear"></div>
                                        <div class="col-md-4 ">
                                            <asp:DropDownList ID="_MaTinh_HT" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP validate[required] " />
                                        </div>
                                        <div class="col-md-4 ">
                                            <asp:DropDownList ID="_MaHuyen_HT" runat="server" AutoPostBack="true" CssClass="selectpicker drQuanHuyen validate[required]" />
                                        </div>
                                        <div class="col-md-4">
                                            <asp:DropDownList ID="_MaXa_HT" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa  validate[required]" />
                                        </div>
                                        <div class="col-md-6 none">
                                            <asp:DropDownList ID="_MaThon_HT" runat="server" CssClass="selectpicker drThonTo" />
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <div class="col-md-2  pdr0 pdt5 b">6.Số điện thoại&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="_SoDienThoai" runat="server" onkeypress="return nextfocus(1, this, event,'drGioiTinh',0);" CssClass="TextBox SoDienThoai validate[required] validate[custom[integer]]" />
                                </div>
                                <div class="col-md-2  pdr0 pdt5 b">Email</div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="_Email" runat="server" onkeypress="return nextfocus(1, this, event,'drGioiTinh',0);" CssClass="TextBox Email " />
                                </div>
                                <div class="col-md-2  pdr0 pdt5 b">7.Liên hệ khác (nếu có)</div>
                                <div class="col-md-10 pdl0">
                                    <asp:TextBox ID="_LienHeKhac" runat="server" onkeypress="return nextfocus(1, this, event,'drGioiTinh',0);" CssClass="TextBox Email " />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">8.Đối tượng ưu tiên</div>
                                <div class="col-md-10 pdl0">
                                    <asp:CheckBoxList runat="server" RepeatColumns="3" CssClass="tbCheckList" ID="_DTUT" />
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_DTUT_Khac" TextMode="MultiLine" Height="50" CssClass="TextBox"></asp:TextBox>

                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="row box-info pd0" id="trinhdokynang">
                                <div class="title-ho bgt1">II.	TRÌNH ĐỘ VÀ KỸ NĂNG CỦA NGƯỜI LAO ĐỘNG</div>
                                <div class="col-md-2 pdr0 pdt5 b">9.Trình độ giáo dục phổ thông</div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="_TrinhDoGD" runat="server" AutoPostBack="true" CssClass="selectpicker TrinhDoGD validate[required] " />
                                </div>
                                <div class="col-md-2 pdr0 pdt0 b">10.Trình độ chuyên môn kỹ thuật</div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="_TrinhDoCM" runat="server" CssClass="selectpicker TrinhDoCM " />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">11.Chuyên ngành đào tạo</div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="_ChuyenNganhDT" runat="server" CssClass="selectpicker LinhVucDT " />
                                </div>
                                <div class="col-md-12 pdr0 pdt5 b">12.Trình độ ngoại ngữ</div>
                                <div class="col-md-12 pdl5 pdb0 pdt0">
                                    <div class="col-md-2 pdr0 pdt5 b i">12.1 Ngoại ngữ 1: </div>
                                    <div class="col-md-2 pdr0 ">
                                        <asp:TextBox ID="_NN1_Ten" runat="server" CssClass="TextBox NgoaiNgu1 " />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 i">Loại bằng</div>
                                    <div class="col-md-2 pdr0 ">
                                        <asp:TextBox ID="_NN1_Loai" runat="server" CssClass="TextBox NN1_Loai " />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 i">Khả năng</div>
                                    <div class="col-md-2 pdr0 ">
                                        <asp:DropDownList ID="_NN1_MD" runat="server" CssClass="selectpicker KhaNangSuDung1 " />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdt5 b i">12.2 Ngoại ngữ 2: </div>
                                    <div class="col-md-2 pdr0 ">
                                        <asp:TextBox ID="_NN2_Ten" runat="server" CssClass="TextBox NgoaiNgu2 " />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 i">Loại bằng</div>
                                    <div class="col-md-2 pdr0 ">
                                        <asp:TextBox ID="_NN2_Loai" runat="server" CssClass="TextBox NN2_Loai " />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 i">Khả năng</div>
                                    <div class="col-md-2 pdr0 ">
                                        <asp:DropDownList ID="_NN2_MD" runat="server" CssClass="selectpicker KhaNangSuDung2 " />
                                    </div>
                                </div>
                                <div class="col-md-12 pdr0 pdt5 b">13.Trình độ tin học</div>
                                <div class="col-md-12 pdl5 pdb0 pdt0">
                                    <div class="col-md-2 pdr0 pdt5 b i">13.1 Tin học văn phòng: </div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:TextBox ID="_TH1_Ten" runat="server" CssClass="TextBox NgoaiNgu1 " />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 i">Khả năng</div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:DropDownList ID="_TH1_MD" runat="server" CssClass="selectpicker KhaNangSuDung1 " />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdt5 b i">13.2 Khác: </div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:TextBox ID="_TH2_Ten" runat="server" CssClass="TextBox NgoaiNgu1 " />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 i">Khả năng</div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:DropDownList ID="_TH2_MD" runat="server" CssClass="selectpicker KhaNangSuDung2 " />
                                    </div>

                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">14.Kỹ năng mềm</div>
                                <div class="col-md-10 pdl0">
                                    <asp:CheckBoxList runat="server" RepeatColumns="3" CssClass="tbCheckList" ID="_KyNangMem" />
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_KyNangMemKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">15.Trình trạng việc làm hiện nay</div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTGHDKT" Checked="true" CssClass="rdCVL" ID="_NCVL" Text="Người có việc làm" />
                                </div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTGHDKT" Checked="false" CssClass="rdNTN" ID="_NTN" Text="Người thất nghiệp" />
                                </div>
                                <div class="col-md-4 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTGHDKT" Checked="false" CssClass="rdKTG" ID="_KTGHDKT" Text="Không tham gia hoạt động kinh tế" />
                                </div>
                            </div>
                            <div class="row box-info pd0" id="tinhtrangvieclam">
                                <div class="title-ho bgt1">III.TÌNH TRẠNG VIỆC LÀM</div>
                                <div class="col-md-2 pdr0 pdt5 b">16. Công việc chính</div>
                                <div class="col-md-6 pdr0  ">
                                    <asp:TextBox runat="server" placeholder="Ghi rõ cụ thể" ID="_CongViecDangLam" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">Mã nghề cấp 4</div>
                                <div class="col-md-2 pdr0 ">
                                    <asp:TextBox runat="server" MaxLength="50" placeholder="Ghi mã cấp 4" ID="_NganhNghe" CssClass="TextBox validate[custom[integer]]"></asp:TextBox>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">17. Vị trí công việc</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="_HinhThuc" runat="server" CssClass="selectpicker HinhThuc" />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">18. Loại hợp đồng</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="_LoaiHopDong" runat="server" CssClass="selectpicker HinhThuc" />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">19.Đóng BHXH không?</div>
                                <div class="col-md-4 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="DongBHXH" Checked="false" CssClass="rdBHXH_Co" ID="_BHXH_Co" Text="Có" />
                                    </div>
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="DongBHXH" Checked="false" CssClass="rdBHXH_Khong" ID="_BHXH_Khong" Text="Không" />
                                    </div>
                                </div>
                                <div class="col-md-2 pdr0 pdt5 ">Loại BHXH</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="_LoaiBHXH" runat="server" CssClass="selectpicker LoaiBHXH">
                                        <asp:ListItem Text="Chọn nếu có đóng BHXH" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="Bảo hiểm xã hội bắt buộc" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Bảo hiểm xã hội tự nguyện" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">20.Thu nhập bình quân</div>
                                <div class="col-md-10 pdr0  ">
                                    <asp:TextBox runat="server" placeholder="nghìn đồng" ID="_ThuNhapBQ" CssClass="TextBox validate[custom[integer]]"></asp:TextBox>
                                </div>

                                <div class="clear"></div>
                                <div class="col-md-12 pdr0 pdt5 b">21.Số giờ thực tế đã làm trong 7 ngày qua:</div>
                                <div class="col-md-2 pdr0 pdt5 pdl5">- Làm công việc chính</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:TextBox runat="server" placeholder="nhập giá trị số" ID="_SoGioLamViecChinh" CssClass="TextBox validate[custom[integer]]"></asp:TextBox>
                                </div>
                                <div class="col-md-2 pdr0 pdt5">- Làm tất cả các công việc</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:TextBox runat="server" placeholder="nhập giá trị số" ID="_SoGioLamTatCa" CssClass="TextBox validate[custom[integer]]"></asp:TextBox>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">22.Có sẵn sàng làm thêm giờ?</div>
                                <div class="col-md-4 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="LamThemGio" Checked="false" CssClass="rdBHXH_Co" ID="_CoSSLamThem_Co" Text="Có" />
                                    </div>
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="LamThemGio" Checked="false" CssClass="rdBHXH_Khong" ID="_CoSSLamThem_Khong" Text="Không" />
                                    </div>
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">23.Vị trí công việc có phù hợp?</div>
                                <div class="col-md-4 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="ViTriCoPhuHop" Checked="false" CssClass="ViTriCoPhuHop_Co" ID="_ViTriCoPhuHop_Co" Text="Có" />
                                    </div>
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="ViTriCoPhuHop" Checked="false" CssClass="ViTriCoPhuHop_Khong" ID="_ViTriCoPhuHop_Khong" Text="Không" />
                                    </div>
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2 pdr0 pdt5 b">24.Tìm được việc qua kênh nào</div>
                                <div class="col-md-10 pdr0  ">
                                    <asp:CheckBoxList ID="KenhTimViec" runat="server" CssClass="tbCheckList" />
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_KenhKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-6 pdr0 pdt5 b">25.Có nhu cầu tìm việc trong thời gian tới không?</div>
                                <div class="col-md-6 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="CoNCTimViec" Checked="true" CssClass="CoNCTimViec" ID="_CoNCTimViec_Co" Text="Có" />
                                    </div>
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="CoNCTimViec" Checked="false" CssClass="KoNCTimViec" ID="_CoNCTimViec_Khong" Text="Không" />
                                    </div>
                                </div>
                            </div>
                            <div class="row box-info pd0" id="tinhtrangthatnghiep">
                                <div class="title-ho bgt1">IV.TÌNH TRẠNG THẤT NGHIỆP</div>
                                <div class="col-md-2 pdr0 pdt5 b">26. Thời gian thất nghiệp</div>
                                <div class="col-md-10 pdr0  ">
                                    <asp:DropDownList ID="_ThoiGianThatNghiep" runat="server" CssClass="selectpicker ThoiGianThatNghiep" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">27. Lý do thất nghiệp</div>
                                <div class="col-md-10 pdr0  ">
                                    <asp:RadioButtonList RepeatColumns="2" ID="_LyDoThatNghiep" runat="server" CssClass="tbCheckList LyDoThatNghiep" />
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_LyDoTNKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-6 pdr0 pdt5 b">28.Trong thời gian tới, có nhu cầu tìm kiếm việc làm không?</div>
                                <div class="col-md-6 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="_TN_CoNCTimViec" Checked="true" CssClass="TN_CoNCTimViec_Co" ID="_TN_CoNCTimViec_Co" Text="Có" />
                                    </div>
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="_TN_CoNCTimViec" Checked="false" CssClass="TN_CoNCTimViec_Khong" ID="_TN_CoNCTimViec_Khong" Text="Không" />
                                    </div>
                                </div>
                            </div>
                            <div class="row box-info pd0" id="nhucautimkiemvieclam">
                                <div class="title-ho bgt1">V.NHU CẦU TÌM KIẾM VIỆC LÀM TRONG NƯỚC</div>
                                <div class="col-md-2 pdr0 pdt5 b">29. Hình thức tìm kiếm</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="KenhTimViecTN" runat="server" CssClass="selectpicker KenhTimViecTN" />
                                </div>
                                <div class="col-md-6 pdr0">
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="KenhTNKhac" TextMode="MultiLine" Height="30" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="col-md-2 pdr0 b">30. Loại hình DN mong muốn</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="_LoaiHinhKT" runat="server" CssClass="selectpicker LoaiHinhKT" />
                                </div>
                                <div class="col-md-2 pdr0 b">31. Ngành SX của DN mong muốn</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:TextBox ID="_NganhNgheMongMuon" runat="server" CssClass="TextBox NganhNgheMongMuon" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 b">32. Tên công việc mong muốn</div>
                                <div class="col-md-10 pdr0  ">
                                    <asp:TextBox ID="_CVMongMuon" runat="server" CssClass="TextBox CVMongMuon" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 pdr0 pdl5 b i">32.1.Mô tả cụ thể công việc</div>
                                <div class="col-md-5 pdr0  ">
                                    <asp:TextBox ID="_CVMongMuonCuThe" runat="server" CssClass="TextBox CVMongMuonCuThe" />
                                </div>
                                <div class="col-md-2 pdr0 pdl5">Mã</div>
                                <div class="col-md-2 pdr0  ">
                                    <asp:TextBox ID="_MaCVMongMuon" runat="server" CssClass="TextBox MaCVMongMuon" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdl5 b i">32.2.Kinh nghiệm bao năm (nếu có)</div>
                                <div class="col-md-10">
                                    <asp:DropDownList ID="_KinhNghiemLV" runat="server" CssClass="selectpicker KinhNghiemLV" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdl5 b ">33. Chức vụ mong muốn</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="_ChucVuMongMuon" runat="server" CssClass="selectpicker ChucVuMongMuon" />
                                </div>
                                <div class="col-md-6 pdr0  ">
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_ChucVuKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2 pdr0 pdl5 b ">34. Địa bàn mong muốn</div>
                                <div class="col-md-2 pdr0  ">
                                    <asp:DropDownList ID="_DiaBanMongMuon" runat="server" CssClass="selectpicker DiaBanMongMuon" />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 i ">- Tỉnh/TP</div>
                                <div class="col-md-2 pdr0  ">
                                    <asp:DropDownList ID="_TinhTPMongMuon" runat="server" CssClass="selectpicker DiaBanMongMuon" />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 i ">- Quận/Huyện</div>
                                <div class="col-md-2 pdr0  ">
                                    <asp:DropDownList ID="_QuanHuyenMongMuon" runat="server" CssClass="selectpicker DiaBanMongMuon" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdl5 b ">35. Loại HĐ mong muốn</div>
                                <div class="col-md-3 pdr0  ">
                                    <asp:DropDownList ID="_LoaiHDMongMuon" runat="server" CssClass="selectpicker LoaiHDMongMuon" />
                                </div>
                                <div class="col-md-2 pdr0 pdl5 b ">36. Khả năng đáp ứng</div>
                                <div class="col-md-5 pdr0  ">
                                    <asp:CheckBoxList ID="_LoaiLamViec" RepeatColumns="3" runat="server" CssClass="tbCheckList LoaiLamViec" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdl5 b ">37. Hình thức LV mong muốn</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="_HinhThucLamViec" runat="server" CssClass="selectpicker HinhThucLamViec" />
                                </div>
                                <div class="col-md-2 pdr0 pdl5 b ">38. Mục đích LV mong muốn</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="_MucDichMongMuon" runat="server" CssClass="selectpicker MucDichMongMuon" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdl5 b ">39. Mức lương mong muốn</div>
                                <div class="col-md-10 pdr0  ">
                                    <asp:DropDownList ID="_MucLuongMongMuon" runat="server" CssClass="selectpicker MucLuongMongMuon" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdl5 b ">40. Chế độ phúc lợi</div>
                                <div class="col-md-10 pdr0  ">
                                    <asp:CheckBoxList RepeatColumns="3" ID="_CheDoPhucLoi" runat="server" CssClass="tbCheckList" />
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_CheDoPhucLoiKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdl5 b ">41. Dự kiến làm việc</div>
                                <div class="col-md-4 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="DuKienLamViec" Checked="false" CssClass="DuKienLamViec_Co" ID="_DuKienLamViec_Co" Text="Làm việc ngay" />
                                    </div>
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="DuKienLamViec" Checked="false" CssClass="DuKienLamViec_Khong" ID="_DuKienLamViec_Khong" Text="Làm việc sau" />
                                    </div>
                                    <asp:TextBox runat="server" placeholder="Ghi rõ số tháng có thể bắt đầu làm việc" ID="_SoThangDuKien" CssClass="TextBox validate[custom[integer]]"></asp:TextBox>

                                </div>
                                <div class="col-md-2 pdr0 pdl5 b ">42. H.thức tuyển dụng mong muốn</div>
                                <div class="col-md-4 pdr0  ">
                                    <asp:DropDownList ID="_HinhThucTuyenDung" runat="server" CssClass="selectpicker HinhThucTuyenDung" />

                                </div>
                            </div>

                            <div class="row box-info pd0" id="nhucauvieclamngoainuoc">
                                <div class="title-ho bgt1">VI.NHU CẦU VỀ VIỆC LÀM NGOÀI NƯỚC (XUẤT KHẨU LAO ĐỘNG)</div>
                                <div class="col-md-2 pdr0 pdl5 b ">43. Nhu cầu về việc làm xuất khẩu lao động</div>
                                <div class="col-md-10 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="NhuCauXuatKhau" Checked="true" CssClass="NhuCauXuatKhau_Khong" ID="_NhuCauXuatKhau_Khong" Text="Không có nhu cầu đi xuất khẩu lao động" />
                                    </div>
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="NhuCauXuatKhau" Checked="false" CssClass="NhuCauXuatKhau_Co" ID="_NhuCauXuatKhau_Co" Text="Có nhu cầu xuất khẩu lao động" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="nhucauxkld none">
                                        <div class="col-md-4 pdr0 pdl5 b ">-Chọn nước làm việc nếu có nhu cầu xuất khẩu</div>
                                        <div class="col-md-8 pdr0  ">
                                            <asp:DropDownList runat="server" ID="_NuocLamViec" CssClass="selectpicker"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="nhucauxkld none">
                                    <div class="col-md-2 pdr0 pdl5 b ">44. Mức lương mong muốn</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:TextBox runat="server" placeholder="Nhập giá trị số" ID="_MucLuongXuatKhau" CssClass="TextBox validate[custom[integer]]"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="row box-info pd0" id="dexuatkiengnhi">
                                <div class="title-ho bgt1">VII. ĐỀ XUẤT/KHUYẾN NGHỊ CỦA NGƯỜI LAO ĐỘNG</div>
                                <div class="col-md-12 pdr0  ">
                                    <asp:TextBox TextMode="MultiLine" Height="50" runat="server" ID="_DeXuatKienNghi" CssClass="TextBox"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="clrUp"></div>
                    </div>
                </div>
                <asp:Literal ID="litUpdate" runat="server" />

                <div class="none">
                    <asp:HiddenField ID="IdKhau" Visible="false" runat="server" />
                    <asp:HiddenField ID="YearPro" Visible="false" runat="server" />
                    <asp:HiddenField ID="IsLock" Visible="false" runat="server" />
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="(F7) Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="(F8) Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                <%--<asp:Button ID="cmdAddHo" runat="server" Text="(F10) Thêm phiếu mới" CssClass="cmsbut cmsbtrun" OnClientClick="return $('#Form').validationEngine('detach');" />--%>
                <asp:Button ID="cmdDelete" runat="server" Text="(F4) Xóa phiếu" CssClass="cmsbut cmsbtdel" />
                <div class="clear"></div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="_NuocLamViec" />
        <asp:AsyncPostBackTrigger ControlID="_HinhThuc" />
        <asp:AsyncPostBackTrigger ControlID="_LoaiHinhKT" />
        <asp:AsyncPostBackTrigger ControlID="_TrinhDoGD" />
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />
    </Triggers>
</asp:UpdatePanel>
<asp:Literal runat="server" ID="ltMessage"></asp:Literal>
<script type="text/javascript">
    $(".bodyfake").addClass("sidebar-collapse")
    document.onkeydown = function (e) { if (e.keyCode == 118) { $(".cmsback").click(); } else if (e.keyCode === 119) { $(".cmsbtupdate").click(); } else if (e.keyCode === 120) { $(".cmsbtnew").click(); } else if (e.keyCode === 121) { $(".cmsbtrun").click(); } else if (e.keyCode === 115) { $(".cmsbtdel").click(); } else if (e.keyCode === 114) { $(".cmsbtdelHo").click(); } };
    function setFullScreen() { if ($(document.body).hasClass("fullScreen")) { $(document.body).removeClass("fullScreen"); } else { $(document.body).addClass("fullScreen"); } }
    $('body').on('keydown', '.drTinhTP > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drTinhTP > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drTinhTP').selectpicker('toggle'); return false; } else { $(".drQuanHuyen").focus(); } } });
    $('body').on('keydown', '.drQuanHuyen > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drQuanHuyen > button").attr("title"); if (vl === "--- Quận/huyện ---") { $('.drQuanHuyen').selectpicker('toggle'); return false; } else { $(".drPhuongXa").focus(); } } });
    $('body').on('keydown', '.drPhuongXa > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drPhuongXa > button").attr("title"); if (vl === "--- Phường/xã ---") { $('.drPhuongXa').selectpicker('toggle'); return false; } else { $(".drThonTo").focus(); } } });
    $('body').on('keydown', '.drThonTo > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drThonTo > button").attr("title"); if (vl === "--- Thôn/tổ ---") { $('.drThonTo').selectpicker('toggle'); return false; } else { $(".MaHo").focus(); } } });
    $('body').on('keydown', '.LoaiHo > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".LoaiHo > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.LoaiHo').selectpicker('toggle'); return false; } else { $(".drSo").focus(); } } });
    $('body').on('keydown', '.drSo > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drSo > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drSo').selectpicker('toggle'); return false; } else { $(".DiaChi").focus(); } } });
    $('body').on('keydown', '.QuanHe > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".QuanHe > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.QuanHe').selectpicker('toggle'); return false; } else { $(".drDanToc").focus(); } } });
    $('body').on('keydown', '.drDanToc > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drDanToc > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drDanToc').selectpicker('toggle'); return false; } else { $(".CCCD").focus(); } } });
    $('body').on('keydown', '.CCCD > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".CCCD > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.CCCD').selectpicker('toggle'); return false; } else { $(".drGioiTinh").focus(); } } });
    $('body').on('keydown', '.drGioiTinh > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drGioiTinh > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drGioiTinh').selectpicker('toggle'); return false; } else { $(".NgaySinh").focus(); } } });
    $('body').on('keydown', '.TrinhDoGD > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".TrinhDoGD > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.TrinhDoGD').selectpicker('toggle'); return false; } else { $(".TrinhDoCM").focus(); } } });
    $('body').on('keydown', '.TrinhDoCM > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { $(".LinhVucDT").focus(); } });
    $('body').on('keydown', '.LinhVucDT > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { $(".WorkJoin").focus(); } });
    $('body').on('keydown', '.WorkJoin > button.dropdown-toggle', function (e) { console.log(e.keyCode); if (e.keyCode === 13) { removethatnghiep(); removeKtg(); var vl = $(".WorkJoin > button").attr("title"); if (vl === "0--Không có việc làm") { $(".LoaiThatNghiep").focus(); } else { $(".NoiLamViec").focus(); } } });
    $('body').on('keydown', '.NoiLamViec > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); var vl = $(".NoiLamViec > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.NoiLamViec').selectpicker('toggle'); return false; } else { $(".NganhNghe").focus(); } } });
    $('body').on('keydown', '.NganhNghe > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); $(".NuocLamViec").focus(); } });
    $('body').on('keydown', '.NuocLamViec > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); $(".DiaChiLamViec").focus(); } });
    $('body').on('keydown', '.HinhThuc > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); var vl = $(".HinhThuc > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.HinhThuc').selectpicker('toggle'); return false; } else { $(".LoaiHinhKT").focus(); } } });
    $('body').on('keydown', '.LoaiHinhKT > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); var vl = $(".LoaiHinhKT > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.LoaiHinhKT').selectpicker('toggle'); return false; } else { $(".LoaiChuyen").focus(); } } });
    $('body').on('keydown', '.LoaiChuyen > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".LoaiChuyen > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.LoaiChuyen').selectpicker('toggle'); return false; } else { $(".CatChet input").focus(); } } });
    $('body').on('keydown', '.LoaiThatNghiep > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removecvl(); removeKtg(); $(".ThoiGianThatNghiep").focus(); } });
    $('body').on('keydown', '.LyDoKhongThamGia > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removecvl(); $(".GhiChu").focus(); } });
    $('body').on('keydown', '.thonToMenuLeft > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { $(".keyMenuLeft").focus(); } });
    $('body').on('keydown', '.keyMenuLeft', function (e) { if (e.keyCode === 13) { $(".timKiemMenuLeft").click(); } });
    function nextchange(ct, th, nt, id) { if (id === "1") { removethatnghiep(); removeKtg(); $("." + nt).focus(); } else if (id === "5") { removethatnghiep(); removecvl(); $("." + nt).focus(); } else if (id === "4") { removecvl(); removeKtg(); $("." + nt).focus(); } else if (id === "2") { $("." + nt + " input").focus(); } else if (id === "3") { removethatnghiep(); removeKtg(); if ($(th).val() != "") { $("." + nt).focus(); } else { $("." + ct).focus(); } } else { if ($(th).val() != "") { $("." + nt).focus(); } } };
    function nextfocus(ac, th, e, nt, et) { if (e.keyCode === 13) { if (et === 1) { $("." + nt).click(); } else { if (ac === 1) { if ($(th).val() != "") { $("." + nt).focus(); } else { $("." + nt).focus(); } } else { $("." + nt).focus(); } } return false; } else { return true; } };
    function pageLoad() { $('body').scrollspy({ target: '#list-example' }); var minStartDate = new Date(2015, 09, 26); var maxStartDate = new Date(2019, 09, 26); $('.datepicker').datetimepicker({ timepicker: false, minDate: minStartDate, maxDate: maxStartDate, format: 'd/m/Y', mask: false, closeOnDateSelect: true }); };
    $('.rdCVL').click(function () {
        loadstatuswork(1);
    });
    $('.rdNTN').click(function () {
        loadstatuswork(2);
    });
    $('.rdKTG').click(function () {
        loadstatuswork(3);
    });
    $('.CoNCTimViec').click(function () {
        loadstatus25(1);
    });
    $('.KoNCTimViec').click(function () {
        loadstatus25(0);
    });
    $('.TN_CoNCTimViec_Co').click(function () {
        loadstatus28(1);
    });
    $('.TN_CoNCTimViec_Khong').click(function () {
        loadstatus28(0);
    });
    $('.NhuCauXuatKhau_Khong').click(function () {
        nhucauxkld(1);
    });
    $('.NhuCauXuatKhau_Co').click(function () {
        nhucauxkld(0);
    });
    function loadstatuswork(isActive) {
        $('#menutinhtrangthatnghiep').addClass('none');
        $('#menunhucautimkiemvieclam').addClass('none');
        $('#menunhucauvieclamngoainuoc').addClass('none');
        $('#menudexuatkiengnhi').addClass('none');
        //
        $('#tinhtrangvieclam').addClass('none');
        $('#tinhtrangthatnghiep').addClass('none');
        $('#nhucautimkiemvieclam').addClass('none');
        $('#nhucauvieclamngoainuoc').addClass('none');
        $('#dexuatkiengnhi').addClass('none');
        if (isActive == 1) {
            $('#menutinhtrangthatnghiep').removeClass('none');
            $('#menunhucautimkiemvieclam').removeClass('none');
            $('#menunhucauvieclamngoainuoc').removeClass('none');
            $('#menudexuatkiengnhi').removeClass('none');
            //
            $('#tinhtrangvieclam').removeClass('none');
            $('#tinhtrangthatnghiep').removeClass('none');
            $('#nhucautimkiemvieclam').removeClass('none');
            $('#nhucauvieclamngoainuoc').removeClass('none');
            $('#dexuatkiengnhi').removeClass('none');
        }
        if (isActive == 2) {
            $('#menutinhtrangthatnghiep').removeClass('none');
            $('#tinhtrangthatnghiep').removeClass('none');
        }
    }
    function loadstatus25(i) {
        if (i == 1) {
            $('#tinhtrangthatnghiep').removeClass('none');
            $('#nhucautimkiemvieclam').removeClass('none');
            $('#nhucauvieclamngoainuoc').removeClass('none');
            $('#dexuatkiengnhi').removeClass('none');
        }
        else {
            $('#tinhtrangthatnghiep').addClass('none');
            $('#nhucautimkiemvieclam').addClass('none');
            $('#nhucauvieclamngoainuoc').addClass('none');
            $('#dexuatkiengnhi').addClass('none');
        }
    }
    function loadstatus28(i) {
        if (i == 1) {
            $('#nhucautimkiemvieclam').removeClass('none');
            $('#nhucauvieclamngoainuoc').removeClass('none');
            $('#dexuatkiengnhi').removeClass('none');
        }
        else {
            $('#nhucautimkiemvieclam').addClass('none');
            $('#nhucauvieclamngoainuoc').addClass('none');
            $('#dexuatkiengnhi').addClass('none');
        }
    }
    function nhucauxkld(i) {
        if (i == 1)
            $('.nhucauxkld').addClass('none');
        else
            $('.nhucauxkld').removeClass('none');
    }
</script>
