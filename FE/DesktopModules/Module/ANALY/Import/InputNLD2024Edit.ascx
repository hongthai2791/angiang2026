<%@ Control Language="vb" CodeFile="InputNLD2024Edit.ascx.vb" Inherits="Modules.Analy.Import.InputNLD2024Edit" AutoEventWireup="false" Explicit="True" %>
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
                    <a href="#tinhtrangvieclam">III.Thông tin về phiên giao dịch việc làm</a>
                </li>
                <li>
                    <a href="#tinhtrangthatnghiep" id="menutinhtrangthatnghiep">IV.Nhu cầu tìm kiếm việc làm trong nước</a>
                </li>
                <li>
                    <a href="#nhucautimkiemvieclam" id="menunhucautimkiemvieclam">V.Nhu cầu về việc làm ngoài nước</a>
                </li>
                <li>
                    <a href="#nhucauvieclamngoainuoc" id="menunhucauvieclamngoainuoc">VI.Nhu cầu học nghề</a>
                </li>
            </ol>
        </div>
        <div class="content-pks">
            <div class="box box-info box-infoHo" data-spy="scroll" data-target="#list-example" data-offset="0">

                <div class="box-body">
                    <div class="col-md-12 text-center h4" id="thongtinphieu">
                        <b class="title-pks">PHIẾU KHẢO SÁT
THU THẬP, CẬP NHẬT THÔNG TIN SÀN VIỆC LÀM V2</b>
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
                                <div class="col-md-2 pdr0 pdt5 b">2.Năm sinh&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:TextBox Width="100%" ID="_NamSinh" runat="server" CssClass="TextBox NgaySinh validate[required] validate[custom[dateVN]]" placeholder="dd/mm/yyyy" />
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
                                <div class="col-md-2  pdr0 pdt5 b">4.Tôn giáo: </div>
                                <div class="col-md-4 pdl0">
                                    <asp:DropDownList ID="_TonGiao" runat="server" CssClass=" selectpicker drDanToc" />
                                </div>
                                <div class="clear"></div>
                                <asp:UpdatePanel runat="server" ID="pnDONVI">
                                    <ContentTemplate>
                                        <div class="col-md-2  pdr0 pdt5 b">5.Địa chỉ thường trú <span class="red">*</span></div>
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
                                        <div class="col-md-2 pdr0">6.Nơi ở hiện tại <span class="red">*</span></div>
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
                                <div class="col-md-2  pdr0 pdt5 b">7.Số điện thoại&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="_SoDienThoai" runat="server" onkeypress="return nextfocus(1, this, event,'drGioiTinh',0);" CssClass="TextBox SoDienThoai validate[required] validate[custom[integer]]" />
                                </div>
                                <div class="col-md-2  pdr0 pdt5 b">8.Email</div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="_Email" runat="server" onkeypress="return nextfocus(1, this, event,'drGioiTinh',0);" CssClass="TextBox Email " />
                                </div>
                                <div class="col-md-2  pdr0 pdt5 b">9.Liên hệ khác (nếu có)</div>
                                <div class="col-md-10 pdl0">
                                    <asp:TextBox ID="_LienHeKhac" runat="server" onkeypress="return nextfocus(1, this, event,'drGioiTinh',0);" CssClass="TextBox Email " />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">10.Đối tượng ưu tiên</div>
                                <div class="col-md-10 pdl0">
                                    <asp:CheckBoxList runat="server" RepeatColumns="3" CssClass="tbCheckList" ID="_DTUT" />
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_DTUT_Khac" TextMode="MultiLine" Height="50" CssClass="TextBox"></asp:TextBox>

                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">Ngày cập nhật&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:TextBox Width="100%" ID="_NgayCapNhat" runat="server" CssClass="TextBox NgaySinh validate[required] validate[custom[dateVN]]" placeholder="dd/mm/yyyy" />
                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="row box-info pd0" id="trinhdokynang">
                                <div class="title-ho bgt1">II.	TRÌNH ĐỘ VÀ KỸ NĂNG CỦA NGƯỜI LAO ĐỘNG</div>
                                <div class="col-md-2 pdr0 pdt5 b">11.Trình độ học vấn&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="_TrinhDoGD" runat="server" AutoPostBack="true" CssClass="selectpicker TrinhDoGD validate[required] " />
                                </div>
                                <div class="col-md-2 pdr0 pdt0 b">12.Trình độ chuyên môn kỹ thuật</div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="_TrinhDoCM" runat="server" CssClass="selectpicker TrinhDoCM validate[required]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">13.Chuyên ngành đào tạo</div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="_ChuyenNganhDT" runat="server" CssClass="selectpicker LinhVucDT " />
                                </div>
                                <div class="col-md-12 pdr0 pdt5 b">14.Trình độ ngoại ngữ</div>
                                <div class="col-md-12 pdl5 pdb0 pdt0">
                                    <div class="col-md-2 pdr0 pdt5 b i">14.1 Ngoại ngữ 1: </div>
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
                                    <div class="col-md-2 pdr0 pdt5 b i">14.2 Ngoại ngữ 2: </div>
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
                                <div class="col-md-12 pdr0 pdt5 b">15.Trình độ tin học</div>
                                <div class="col-md-12 pdl5 pdb0 pdt0">
                                    <div class="col-md-2 pdr0 pdt5 b i">15.1 Tin học văn phòng: </div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:TextBox ID="_TH1_Ten" runat="server" CssClass="TextBox NgoaiNgu1 " />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 i">Khả năng</div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:DropDownList ID="_TH1_MD" runat="server" CssClass="selectpicker KhaNangSuDung1 " />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdt5 b i">15.2 Khác: </div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:TextBox ID="_TH2_Ten" runat="server" CssClass="TextBox NgoaiNgu1 " />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 i">Khả năng</div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:DropDownList ID="_TH2_MD" runat="server" CssClass="selectpicker KhaNangSuDung2 " />
                                    </div>

                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">16.Kỹ năng mềm</div>
                                <div class="col-md-10 pdl0">
                                    <asp:CheckBoxList runat="server" RepeatColumns="3" CssClass="tbCheckList" ID="_KyNangMem" />
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_KyNangMemKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">17.Anh/chị đã từng đi làm bao giờ chưa</div>
                                <div class="col-md-2 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTGHDKT" Checked="true" CssClass="rdCVL" ID="_DaTungDiLamCo" Text="Có" />
                                </div>
                                <div class="col-md-2 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTGHDKT" Checked="false" CssClass="rdNTN" ID="_DaTungDiLamKo" Text="Không" />
                                </div>
                                <div class="clear"></div>
                                <div class="cau17note">
                                    <div class="col-md-2 pdt5">
                                    </div>
                                    <div class="col-md-10 pdt5">
                                        <asp:TextBox runat="server" placeholder="Nếu Có ghi cụ thể tên công việc có kinh nghiệm nhất (ghi rõ thời gian, chức vụ)" ID="_DaTungDiLamNote" TextMode="MultiLine" Height="60" MaxLength="500" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="cau18-21">
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdt5 b">18.Mức lương đạt được</div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:DropDownList ID="dropMucLuong" runat="server" CssClass="selectpicker MucLuong" />
                                    </div>
                                    <div class="col-md-2 pdr0 pdt5 b">19.Vị trí việc làm/nghề nghiệp của anh/chị</div>
                                    <div class="col-md-4 pdr0 ">
                                        <asp:DropDownList ID="dropViTriViecLam" runat="server" CssClass="selectpicker ViTriViecLam" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdt5 b">20.Vị trí công việc có phù hợp?</div>
                                    <div class="col-md-4 pdr0  ">
                                        <div class="col-md-6 pdt5">
                                            <asp:RadioButton runat="server" GroupName="ViTriCoPhuHop" Checked="false" CssClass="ViTriCoPhuHop_Co" ID="_ViTriCoPhuHop_Co" Text="Có" />
                                        </div>
                                        <div class="col-md-6 pdt5">
                                            <asp:RadioButton runat="server" GroupName="ViTriCoPhuHop" Checked="false" CssClass="ViTriCoPhuHop_Khong" ID="_ViTriCoPhuHop_Khong" Text="Không" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdt5 b">21.Tìm được việc qua kênh nào</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:CheckBoxList ID="_KenhTimViec" runat="server" CssClass="tbCheckList" />
                                        <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_KenhTimKiemKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="cau22">
                                    <div class="col-md-2 pdr0 pdt5 b">22.Đã từng đi làm việc ở nước ngoài </div>
                                    <div class="col-md-2 pdt5">
                                        <asp:RadioButton runat="server" GroupName="TTTLVONN" Checked="false" CssClass="rdLVNNCo" ID="_LamViecONNCo" Text="Có" />
                                    </div>
                                    <div class="col-md-2 pdt5">
                                        <asp:RadioButton runat="server" GroupName="TTTLVONN" Checked="false" CssClass="rdLVNNKo" ID="_LamViecONNKo" Text="Không" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="cau22note">
                                        <div class="col-md-2 pdt5">
                                        </div>
                                        <div class="col-md-10 pdt5">
                                            <asp:TextBox runat="server" placeholder="Nếu Có ghi cụ thể tên công việc có kinh nghiệm nhất (ghi rõ thời gian, chức vụ)" ID="LamViecONNNote" TextMode="MultiLine" Height="60" MaxLength="500" CssClass="TextBox"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="cau23">
                                    <div class="col-md-12 pdr0 pdt5 b">23.Tình trạng việc làm hiện nay</div>
                                    <div class="col-md-12">
                                        <div class="col-md-2 pdr0 pdt5 b i">23.1 Trình trạng việc</div>
                                        <div class="col-md-10 pdr0">
                                            <asp:RadioButtonList RepeatColumns="2" ID="rdTinhTrangViecLam" runat="server" CssClass="tbCheckList TinhTrangViecLam" />
                                            <asp:TextBox runat="server" placeholder="Ghi thông tin rõ cụ thể" ID="_TinhTrangViecLamDetail" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                        </div>
                                        <div class="clear"></div>
                                        <div class="col-md-2 pdr0 pdt5 b i">23.2 Khác</div>
                                        <div class="col-md-10 pdr0">
                                            <asp:TextBox runat="server" placeholder="Nếu khác cần ghi rõ cụ thể" ID="_TinhTrangViecLamNote" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="cau24">
                                    <div class="col-md-2 pdr0 pdt5 b">24.Nguyên nhân chưa tìm được việc làm</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:CheckBoxList RepeatColumns="2" ID="cbNguyenNhanCTVL" runat="server" CssClass="tbCheckList NguyenNhanCTVL" />
                                        <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_NguyenNhanCTVLKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="cau25">
                                    <div class="col-md-2 pdr0 pdt5 b">25.Lý do tham gia Phiên giao dịch việc làm/Ngày giao dịch việc làm này</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:CheckBoxList RepeatColumns="2" ID="cbLyDoPGDVL" runat="server" CssClass="tbCheckList LyDoPGDVL" />
                                        <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_LyDoPGDVLKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">26.Đã từng sử dụng website của Trung tâm</div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTWeb" Checked="false" CssClass="rdWebDT" ID="_SuDungWebDT" Text="Đã từng sử dụng rất lâu rồi" />
                                </div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTWeb" Checked="false" CssClass="rdWebSD" ID="_SuDungWebSD" Text="Sử dụng thường xuyên" />
                                </div>
                                <div class="col-md-4 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTWeb" Checked="false" CssClass="rdWebChua" ID="_SuDungWebChua" Text="Chưa từng sử dụng" />
                                </div>
                                <div class="clear"></div>
                                <div class="cau27">
                                    <div class="col-md-12 pdr0 pdt5 b">27. Góp ý để website đáp ứng tốt hơn nhu cầu của người lao động</div>
                                    <div class="col-md-12 pdl5 pdb0 pdt0">
                                        <div class="col-md-2 pdr0 pdt5 b i">27.a.Về bố cục/giao diện website</div>
                                        <div class="col-md-10 pdr0 ">
                                            <asp:TextBox ID="_WebBoCuc" runat="server" TextMode="MultiLine" Height="60" MaxLength="500" CssClass="TextBox WebBoCuc " />
                                        </div>
                                    </div>
                                    <div class="col-md-12 pdl5 pdb0 pdt0">
                                        <div class="col-md-2 pdr0 pdt5 b i">27.b.Về nội dung/thông tin website</div>
                                        <div class="col-md-10 pdr0 ">
                                            <asp:TextBox ID="_WebNoiDung" runat="server" TextMode="MultiLine" Height="60" MaxLength="500" CssClass="TextBox WebNoiDung " />
                                        </div>
                                    </div>
                                    <div class="col-md-12 pdl5 pdb0 pdt0">
                                        <div class="col-md-2 pdr0 pdt5 b i">27.c.Khác</div>
                                        <div class="col-md-10 pdr0 ">
                                            <asp:TextBox ID="_WebKhac" runat="server" TextMode="MultiLine" Height="60" MaxLength="500" CssClass="TextBox WebKhac" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="cau28">
                                    <div class="col-md-2 pdr0 pdt5 b">28.Kiến nghị gì đê nâng cao chất lượng phục vụ của Trung tâm</div>
                                    <div class="col-md-10 pdr0 ">
                                        <asp:TextBox ID="_KienNghiPhucVu" runat="server" TextMode="MultiLine" Height="60" MaxLength="500" CssClass="TextBox KienNghiPhucVu " />
                                    </div>
                                </div>
                            </div>

                            <div class="row box-info pd0" id="tinhtrangvieclam">
                                <div class="title-ho bgt1">III.THÔNG TIN VỀ PHIÊN GIAO DỊCH VIỆC LÀM</div>
                                <div class="col-md-2 pdr0 pdt5 b">29. Địa điểm mong muốn tham gia phiên giao dịch việc làm</div>
                                <div class="col-md-4 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTDDMM" Checked="true" CssClass="rdDDMMCo" ID="rdDiaDiemMongMuonCo" Text="Ngay tại huyện, thị xã, thành phố nơi cư trú" />
                                </div>
                                <div class="col-md-4 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTDDMM" Checked="false" CssClass="rdDDMMKo" ID="rdDiaDiemMongMuonKo" Text="Tại Trung tâm Dịch vụ việc làm tỉnh An Giang" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">30.Thời gian tổ chức phiên giao dịch việc làm/ngày hội việc làm mong muốn</div>
                                <div class="col-md-10 pdr0  ">
                                    <asp:RadioButtonList RepeatColumns="2" ID="rdThoiGianToChuc" runat="server" CssClass="tbCheckList ThoiGianToChuc" />
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_ThoiGianToChucKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">31.Từng tham gia Phiên giao dịch việc làm trực tuyến</div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTTTG" Checked="true" CssClass="rdDTTG" ID="rdTungThamGiaCo" Text="Có" />
                                </div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTTTG" Checked="false" CssClass="rdDTTG" ID="rdTungThamGiaKo" Text="Không" />
                                </div>
                                <div class="col-md-4 pdr0  none">
                                    <asp:DropDownList ID="_HinhThuc" runat="server" CssClass="selectpicker HinhThuc" />
                                </div>
                            </div>



                            <div class="row box-info pd0" id="tinhtrangthatnghiep">
                                <div class="title-ho bgt1">IV.NHU CẦU TÌM KIẾM VIỆC LÀM TRONG NƯỚC</div>
                                <div class="col-md-2 pdr0 pdt5 b">32.Nhu cầu về việc làm</div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTNHUCAU" Checked="false" CssClass="rdNhuCauKo" ID="rdNhuCauViecLamKo" Text="Không có nhu cầu việc làm" />
                                </div>
                                <div class="col-md-3 pdt5">
                                    <asp:RadioButton runat="server" GroupName="TTTNHUCAU" Checked="true" CssClass="rdNhuCauCo" ID="rdNhuCauViecLamCo" Text="Có nhu cầu việc làm" />
                                </div>
                                <div class="clear"></div>
                                <div class="cau32">
                                    <div class="col-md-2 pdr0 b">33.Loại hình DN mong muốn</div>
                                    <div class="col-md-4 pdr0  ">
                                        <asp:DropDownList ID="_LoaiHinhKT" runat="server" CssClass="selectpicker LoaiHinhKT" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 b">34. Ngành SX của DN mong muốn</div>
                                    <div class="col-md-4 pdr0  ">
                                        <asp:TextBox ID="_MongMuonLamViec" runat="server" CssClass="TextBox NganhNgheMongMuon" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 b">35. Tên công việc mong muốn</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:TextBox ID="_TenCongViec" runat="server" CssClass="TextBox TenCongViec" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdl5 pdb0 pdt0">
                                        <div class="col-md-3 pdr0 pdl5 b i">35.1.Mô tả cụ thể công việc</div>
                                        <div class="col-md-5 pdr0  ">
                                            <asp:TextBox ID="_MoTaCongViec" runat="server" CssClass="TextBox MoTaCongViec" />
                                        </div>
                                    </div>
                                    <div class="col-md-12 pdl5 pdb0 pdt0">
                                        <div class="col-md-3 pdr0 pdl5 b i">35.2.Có kinh nghiệm trong công việc </div>
                                        <div class="col-md-3 pdt5">
                                            <asp:RadioButton runat="server" GroupName="TTTKNCV" Checked="true" CssClass="rdKNCVCo" ID="rdKinhNghiemCongViecCo" Text="Có" />
                                        </div>
                                        <div class="col-md-3 pdt5">
                                            <asp:RadioButton runat="server" GroupName="TTTKNCV" Checked="false" CssClass="rdKNCVKo" ID="rdKinhNghiemCongViecKo" Text="Không" />
                                        </div>
                                        <div class="clear"></div>
                                        <div class="col-md-4 pdr0">
                                            <asp:DropDownList ID="dropKinhNghiemBLCongViec" runat="server" CssClass="selectpicker KinhNghiemBLCongViec" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdl5 b ">36.Chức vụ mong muốn</div>
                                    <div class="col-md-4 pdr0  ">
                                        <asp:DropDownList ID="_ChucVuMongMuon" runat="server" CssClass="selectpicker ChucVuMongMuon" />
                                    </div>
                                    <div class="col-md-6 pdr0  ">
                                        <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_ChucVuMongMuonKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdl5 b ">37.Địa bàn mong muốn</div>
                                    <div class="col-md-2 pdr0  ">
                                        <asp:DropDownList ID="_DiaBanMongMuon" runat="server" CssClass="selectpicker DiaBanMongMuon" />
                                    </div>
                                    <div class="cau37 none">
                                        <div class="col-md-2 pdr0 pdt5 i ">- Tỉnh/TP</div>
                                        <div class="col-md-2 pdr0  ">
                                            <asp:DropDownList ID="_TinhTPMongMuon" runat="server" CssClass="selectpicker" />
                                        </div>
                                        <div class="col-md-2 pdr0 pdt5 i ">- Quận/Huyện</div>
                                        <div class="col-md-2 pdr0  ">
                                            <asp:DropDownList ID="_QuanHuyenMongMuon" runat="server" CssClass="selectpicker" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdl5 b ">38.Loại HĐ mong muốn</div>
                                    <div class="col-md-3 pdr0  ">
                                        <asp:DropDownList ID="_LoaiHDMongMuon" runat="server" CssClass="selectpicker LoaiHDMongMuon" />
                                    </div>
                                    <div class="col-md-2 pdr0 pdl5 b ">39.Khả năng đáp ứng</div>
                                    <div class="col-md-5 pdr0  ">
                                        <asp:CheckBoxList ID="_LoaiLamViec" RepeatColumns="3" runat="server" CssClass="tbCheckList LoaiLamViec" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdl5 b ">40.Hình thức LV mong muốn</div>
                                    <div class="col-md-4 pdr0  ">
                                        <asp:DropDownList ID="_HinhThucLamViec" runat="server" CssClass="selectpicker HinhThucLamViec" />
                                    </div>
                                    <div class="col-md-2 pdr0 pdl5 b ">41.Mục đích LV mong muốn</div>
                                    <div class="col-md-4 pdr0  ">
                                        <asp:DropDownList ID="_MucDichMongMuon" runat="server" CssClass="selectpicker MucDichMongMuon" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdl5 b ">42.Mức lương mong muốn</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:DropDownList ID="_MucLuongMongMuon" runat="server" CssClass="selectpicker MucLuongMongMuon" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdl5 b ">43.Chế độ phúc lợi</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:CheckBoxList RepeatColumns="3" ID="_CheDoPhucLoi" runat="server" CssClass="tbCheckList" />
                                        <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="_CheDoPhucLoiKhac" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-2 pdr0 pdl5 b ">44.Dự kiến làm việc</div>
                                    <div class="col-md-4 pdr0  ">
                                        <div class="col-md-6 pdt5">
                                            <asp:RadioButton runat="server" GroupName="DuKienLamViec" Checked="True" CssClass="DuKienLamViec_Co" ID="_DuKienLamViec_Co" Text="Làm việc ngay" />
                                        </div>
                                        <div class="col-md-6 pdt5">
                                            <asp:RadioButton runat="server" GroupName="DuKienLamViec" Checked="false" CssClass="DuKienLamViec_Khong" ID="_DuKienLamViec_Khong" Text="Làm việc sau" />
                                        </div>
                                        <asp:TextBox runat="server" placeholder="Ghi rõ số tháng có thể bắt đầu làm việc" ID="_SoThangDuKien" CssClass="TextBox validate[custom[integer]]"></asp:TextBox>

                                    </div>
                                    <div class="col-md-2 pdr0 pdl5 b ">45.Hình thức tuyển dụng</div>
                                    <div class="col-md-4 pdr0  ">
                                        <asp:DropDownList ID="_HinhThucTuyenDung" runat="server" CssClass="selectpicker HinhThucTuyenDung" />
                                    </div>
                                </div>

                            </div>
                            <div class="row box-info pd0" id="nhucautimkiemvieclam">
                                <div class="title-ho bgt1">V.NHU CẦU TÌM KIẾM VIỆC LÀM NGOÀI NƯỚC</div>
                                <div class="col-md-2 pdr0 pdl5 b ">46.Nhu cầu về việc làm xuất khẩu lao động</div>
                                <div class="col-md-10 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="NhuCauXuatKhau" Checked="false" CssClass="NhuCauXuatKhau_Khong" ID="_NhuCauXuatKhau_Khong" Text="Không có nhu cầu đi xuất khẩu lao động" />
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
                                <div class="nhucauxkld">
                                    <div class="col-md-2 pdr0 pdl5 b ">47.Tên công việc mong muốn tìm</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:TextBox runat="server" placeholder="Tên công việc" ID="_CongViecMongMuonXKLD" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:TextBox runat="server" placeholder="Mô tả cụ thể công việc" ID="_CongViecMongMuonXKLDNote" TextMode="MultiLine" Height="60" MaxLength="500" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="clear"></div>
                                <div class="nhucauxkld">
                                    <div class="col-md-2 pdr0 pdl5 b ">48.Mức lương mong muốn</div>
                                    <div class="col-md-10 pdr0  ">
                                        <asp:TextBox runat="server" placeholder="Nhập giá trị số" ID="_MucLuongXKLD" CssClass="TextBox validate[custom[integer]]"></asp:TextBox>
                                    </div>
                                </div>

                            </div>

                            <div class="row box-info pd0" id="nhucauvieclamngoainuoc">
                                <div class="title-ho bgt1">VI.NHU CẦU HỌC NGHỀ</div>
                                <div class="col-md-2 pdr0 pdl5 b ">49.Nhu cầu được học nghề</div>
                                <div class="col-md-10 pdr0  ">
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="NhuCauHocNghe" Checked="false" CssClass="NhuCauHocNghe_Khong" ID="rdNhuCauHocNgheKo" Text="Không có nhu cầu học nghề" />
                                    </div>
                                    <div class="col-md-6 pdt5">
                                        <asp:RadioButton runat="server" GroupName="NhuCauHocNghe" Checked="true" CssClass="NhuCauHocNghe_Co" ID="rdNhuCauHocNgheCo" Text="Có nhu cầu học nghề" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="cau50">
                                        <div class="col-md-12 pdt5">
                                            <asp:TextBox runat="server" placeholder="Ghi cụ thể nghề muốn học" ID="_NhuCauHocNgheNote" TextMode="MultiLine" Height="20" CssClass="TextBox"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="cau50">
                                    <div class="col-md-2 pdr0 pdl5 b ">50.Thời gian học nghề</div>
                                    <div class="col-md-10 pdr0  ">
                                        <div class="col-md-6 pdt5">
                                            <asp:RadioButton runat="server" GroupName="ThoiGianHocNghe" Checked="true" CssClass="ThoiGianHocNghe3T" ID="rdThoiGianHocNghe3T" Text="Đào tạo nghề dưới 03 tháng" />
                                        </div>
                                        <div class="col-md-6 pdt5">
                                            <asp:RadioButton runat="server" GroupName="ThoiGianHocNghe" Checked="false" CssClass="ThoiGianHocNghe12T" ID="rdThoiGianHocNghe12T" Text="Sơ cấp nghề (từ 03 tháng đến dưới 12 tháng)" />
                                        </div>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdl5 b ">51.Nhu cầu nguyện vọng khác</div>
                                <div class="col-md-12 pdr0  ">
                                    <asp:TextBox TextMode="MultiLine" placeholder="Nhu cầu nguyện vọng khác" Height="80" runat="server" ID="_NhuCauNguyenVongKhac" CssClass="TextBox"></asp:TextBox>
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
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới phiếu" CssClass="cmsbut cmsbtnew cbclick" OnClientClick="return $('#Form').validationEngine('detach');" />
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
    $(document).ready(function () {
        eventChangeF();
    });
    function eventChangeF() {
        $('.rdCVL').click(function () {
            loadstatuswork(0);
        });
        $('.rdNTN').click(function () {
            loadstatuswork(1);
        });
        $('.rdLVNNCo').click(function () {
            $('.cau22note').removeClass('none');
            loadstatuswork(1);
        });
        $('.rdLVNNKo').click(function () {
            $('.cau22note').addClass('none');
            loadstatuswork(2);
        });
        $('#dnn_HomeMain1_ctl00_rdTinhTrangViecLam_0').click(function () {
            loadstatuswork(4);
        });
        $('#dnn_HomeMain1_ctl00_rdTinhTrangViecLam_1').click(function () {
            loadstatuswork(4);
        });
        $('#dnn_HomeMain1_ctl00_rdTinhTrangViecLam_2').click(function () {
            loadstatuswork(3);
        });
        $('#dnn_HomeMain1_ctl00_rdTinhTrangViecLam_1').click(function () {
            loadstatuswork(4);
        });
        $('.rdWebDT').click(function () {
            loadstatuswork2(1);
        });
        $('.rdWebSD').click(function () {
            loadstatuswork2(1);
        });
        $('.rdWebChua').click(function () {
            loadstatuswork2(2);
        });
        $('.rdNhuCauCo').click(function () {
            loadstatuswork3(1);
        });
        $('.rdNhuCauKo').click(function () {
            loadstatuswork3(0);
        });
        $('.NhuCauHocNghe_Co').click(function () {
            loadstatuswork4(1);
        });
        $('.NhuCauHocNghe_Khong').click(function () {
            loadstatuswork4(0);
        });
        $('.NhuCauXuatKhau_Khong').click(function () {
            nhucauxkld(1);
        });
        $('.NhuCauXuatKhau_Co').click(function () {
            nhucauxkld(0);
        });
        $(".DiaBanMongMuon").change(function () {
            if ($('option:selected', this).val() == 3)
                diabanmongmuon(0);
            else
                diabanmongmuon(1);
        });
    }

    function loadstatuswork(isActive) {
        $('.cau17note').removeClass('none');
        $('.cau22').addClass('none');
        $('.cau23').addClass('none');
        $('.cau24').addClass('none');
        $('.cau25').addClass('none');
        $('.cau18-21').removeClass('none');

        if (isActive == 1) { // câu 17
            $('.cau22').removeClass('none');
            $('.cau17note').addClass('none');
            $('.cau18-21').addClass('none');
        }
        if (isActive == 2) { // câu 22
            $('.cau22').removeClass('none');
            $('.cau23').removeClass('none');
            $('.cau17note').addClass('none');
        }
        if (isActive == 3) { // câu 24
            $('.cau22').removeClass('none');
            $('.cau23').removeClass('none');
            $('.cau24').removeClass('none');
            $('.cau17note').addClass('none');
        }
        if (isActive == 4) { // câu 25
            $('.cau22').removeClass('none');
            $('.cau23').removeClass('none');
            $('.cau25').removeClass('none');
            $('.cau17note').addClass('none');
        }
    }
    function loadstatuswork2(isActive) {
        $('.cau27').addClass('none');
        $('.cau28').addClass('none');
        if (isActive == 1) {
            $('.cau27').removeClass('none');
        }
        if (isActive == 2) {
            $('.cau28').removeClass('none');
        }
    }
    function loadstatuswork3(isActive) {
        $('.cau32').addClass('none');
        if (isActive == 1) {
            $('.cau32').removeClass('none');
        } else
            $('.cau32').addClass('none');
    }
    function loadstatuswork4(isActive) {
        $('.cau50').addClass('none');
        if (isActive == 1) {
            $('.cau50').removeClass('none');
        }
    }
    function nhucauxkld(i) {
        if (i == 1)
            $('.nhucauxkld').addClass('none');
        else
            $('.nhucauxkld').removeClass('none');
    }
    function diabanmongmuon(i) {
        if (i == 1)
            $('.cau37').addClass('none');
        else
            $('.cau37').removeClass('none');
    }
</script>
