<%@ Control Language="vb" CodeFile="Provide_DoiTuongEdit.ascx.vb" Inherits="Modules.DoiTuong.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .disabledbutton {
        pointer-events: none;
        opacity: 0.4;
        outline: none;
    }

    .cmsbtdelHo {
        background-image: url(/portals/_default/skins/vbn/images/del.png?w);
    }

    .box-infoHo .box-info {
    }

    .bgt1 {
        background: none
    }

    .box-infoHo .box-info .title-ho::after {
        background: none
    }

    .box-infoHo .box-info .title-ho {
        margin-bottom: 0
    }

    .datepicker {
        width: 100% !important
    }

    .boxg3 {
        background: none !important
    }

    /*.box-infoHo .bootstrap-select > .dropdown-toggle, .box-infoHo .TextBox {
    background-color: #e9f5ff;
}

html body .RadInput_Bootstrap .riTextBox, html body .RadInputMgr_Bootstrap {
   background-color: #e9f5ff;
}*/
    .TextBox:focus, .TextBox:hover, .TextBox:active {
        font-weight: bold
    }

    .bootstrap-select .dropdown-toggle:focus, .bootstrap-select > select.mobile-device:focus + .dropdown-toggle {
        font-weight: bold
    }
</style>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-8">
            <h3 class="box-title">Thông tin đối tượng</h3>

        </div>
        <div class="col-md-7 none">
            <div class="alert alert-warning mgbt0">
                <img src="/image/w1.png?w=18" alt="Note" />
                &nbsp; Nếu có sự thay đổi, bấm lưu lại trước khi chuyển sang tab khác
            </div>
        </div>
        <div class="col-md-4">
            <asp:Literal ID="txtYear" runat="server"></asp:Literal>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body1 box-infoHo">
            <div class="row box-info pd0 boxg1 none ">
                <div class="title-ho bgt1 bold">Địa chỉ thu thập</div>
                <div class="col-md-3 ">
                    <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="col-md-3 ">
                    <asp:DropDownList ID="drQuanHuyen" runat="server" AutoPostBack="true" CssClass="selectpicker drQuanHuyen validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="drPhuongXa" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="col-md-3 ">
                    <asp:DropDownList ID="drThonTo" runat="server" AutoPostBack="true" CssClass="selectpicker drThonTo validate[required]" />
                    <span class="required"></span>
                </div>
            </div>

            <div class="col-md-12 col-xs-12 pdl0 pdb0 pdt0 ">
                <div class="row box-info pd0 boxg1" style="min-height: 255px">
                    <div class="title-ho bgt1 bold">Thông tin cung lao động</div>
                    <div class="col-md-6 pdl0 none">
                        <div class="col-md-12 pdl0">Mã thành viên</div>
                        <div class="col-md-12 pdl0">
                            <asp:TextBox ID="MaDoiTuong" runat="server" Enabled="false" CssClass="TextBox validate[required] " />
                            <span class="required"></span>
                        </div>
                    </div>
                    <div class="col-md-6 pdr0 none ">
                        <div class="col-md-12 pdl0 pdb0 pdt0">Số thứ tự</div>
                        <div class="col-md-12 pdl0 pdb0 pdt0">
                            <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox" />
                        </div>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12 pdr0">
                        <div class="col-md-2 lb">1.Họ tên</div>
                        <div class="col-md-10 pdl0">
                            <asp:TextBox ID="HoTen" runat="server" CssClass="TextBox HoTen validate[required] uppercase" />
                            <span class="required"></span>
                        </div>
                    </div>
                    <div class="col-md-6 pdr0 none">
                        <div class="col-md-12 pdl0">1.1 Quan hệ (1xx)</div>
                        <div class="col-md-12 pdl0">
                            <asp:DropDownList ID="QuanHe" runat="server" CssClass="selectpicker QuanHe validate[required] " />
                            <span class="required"></span>
                        </div>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-6 pdr0 ">
                        <div class="col-md-4 lb">2.Ngày sinh</div>
                        <div class="col-md-8 pdl0 pdb0 pdt0">
                            <telerik:RadMaskedTextBox ID="NgaySinh" Mask="##/##/####" Width="100%" runat="server" CssClass="TextBox NgaySinh validate[required]" />
                            <%--<asp:TextBox ID="NgaySinh"  Width="100%" runat="server" CssClass="TextBox NgaySinh validate[required] datepicker"12.3.Nơi làm việc />--%>
                            <span class="required"></span>
                        </div>
                    </div>
                    <div class="col-md-6 pdr0">
                        <div class="col-md-4 lb">3.Giới tính</div>
                        <div class="col-md-8 pdl0">
                            <asp:DropDownList ID="drGioiTinh" runat="server" CssClass="selectpicker drGioiTinh validate[required]" />
                        </div>
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-6 pdr0">
                        <div class="col-md-4 lb">4.CCCD/CMND</div>
                        <div class="col-md-8 pdl0">
                            <asp:TextBox ID="CCCD" type="number" onblur="checkTrungCCCD()" runat="server" CssClass="TextBox CCCD uppercase validate[required,minSize[9],maxSize[12],custom[onlyNumberSp]]" />
                            <asp:TextBox Visible="false" ID="CCCD_CU" runat="server" />
                            <span class="required"></span>

                        </div>
                    </div>
                    <div class="col-md-6 pdr0">
                        <div class="col-md-4 lb">5.Mã số BHXH</div>
                        <div class="col-md-8 pdl0">
                            <asp:TextBox ID="SoBHXH" runat="server" CssClass="TextBox CCCD validate[maxSize[10],custom[number]" />
                        </div>
                    </div>

                    <asp:UpdatePanel runat="server" ID="pnThongTinHo">
                        <ContentTemplate>
                            <div class="col-md-12 pdr0 ">
                                <div class="col-md-2 lb">
                                    <div class="col-md-12">
                                        6.Nơi đăng ký thường trú
                                    </div>
                                </div>
                                <div class="col-md-10 pdl0">

                                    <div class="col-md-6 pdl0 noidangkytt">
                                        <asp:DropDownList ID="drTinhTP_TT" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP  validate[required]" />
                                    </div>
                                    <div class="col-md-6 pdl0 noidangkytt ">
                                        <asp:DropDownList ID="drQuanHuyen_TT" runat="server" AutoPostBack="true" CssClass="selectpicker drQuanHuyen  validate[required]" />

                                    </div>
                                    <div class="col-md-6 pdl0 noidangkytt">
                                        <asp:DropDownList ID="drPhuongXa_TT" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa validate[required] " />

                                    </div>
                                    <div class="col-md-6 pdl0 noidangkytt">
                                        <asp:DropDownList ID="drThonTo_TT" runat="server" CssClass="selectpicker drThonTo " />

                                    </div>
                                    <div class="col-md-12 pdl0 noidangkytt">
                                        <asp:TextBox ID="DiaChi_TT" onblur="nhayDenDTUT()" ToolTip="Nhập địa chỉ cụ thể (số nhà, đường phố)" placeholder="Nhập địa chỉ cụ thể (số nhà, đường phố)" runat="server" CssClass="TextBox DiaChi_HT" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 pdr0 ">
                                <div class="col-md-2 lb">
                                    7.Nơi ở hiện tại
                                            <div class="col-md-12">
                                                <sub>(Địa chỉ thu thập)</sub>
                                            </div>
                                </div>
                                <div class="col-md-10 pdr0 ">
                                    <div class="col-md-12  pdl0 none">
                                        <asp:CheckBox runat="server" ID="chkSuDungLaiThuongTru" OnCheckedChanged="chkSuDungLaiThuongTru_CheckedChanged" AutoPostBack="true" Text="Sử dụng lại địa chỉ thường trú/địa chỉ thu thập" />
                                    </div>
                                    <div class="col-md-6  pdl0">
                                        <asp:DropDownList ID="drTinhTP_HT" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP_HT   validate[required]" />
                                        <span class="required"></span>

                                    </div>
                                    <div class="col-md-6  pdl0">
                                        <asp:DropDownList ID="drQuanHuyen_HT" runat="server" AutoPostBack="true" CssClass="selectpicker drQuanHuyen_HT  validate[required] " />
                                        <span class="required"></span>

                                    </div>
                                    <div class="col-md-6 pdl0">
                                        <asp:DropDownList ID="drPhuongXa_HT" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa_HT  validate[required] " />
                                        <span class="required"></span>

                                    </div>
                                    <div class="col-md-6 pdl0">
                                        <asp:DropDownList ID="drThonTo_HT" runat="server" CssClass="selectpicker drThonTo_HT validate[required]" />
                                        <span class="required"></span>

                                    </div>
                                    <div class="col-md-12 pdl0">
                                        <asp:TextBox ID="DiaChi_HT" ToolTip="Nhập địa chỉ cụ thể (số nhà, đường phố)" placeholder="Nhập địa chỉ cụ thể (số nhà, đường phố)" runat="server" CssClass="TextBox DiaChi_HT" />
                                    </div>

                                    <div class="col-md-12  pdl0 ">
                                        <asp:CheckBox runat="server" ID="_IsDCTT" CssClass="IsDCTT" onchange="changeDiaChiTT();" Text="Nơi đăng ký thường trú khác Nơi ở hiện tại" />
                                    </div>
                                </div>
                            </div>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="col-md-12 pdr0 ">
                        <div class="col-md-2 lb">8.Đối tượng ưu tiên</div>
                        <div class="col-md-10">

                            <div class="col-md-6 pdl0">
                                <asp:CheckBox runat="server" Text="Người khuyết tật" ID="DTUT_NKT" />
                            </div>
                            <div class="col-md-6 pdl0">
                                <asp:CheckBox runat="server" Text="Thuộc hộ nghèo" ID="DTUT_HN" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-6 pdl0">
                                <asp:CheckBox runat="server" Text="Thuộc hộ cận nghèo" ID="DTUT_CN" />
                            </div>
                            <div class="col-md-6 pdl0">
                                <asp:CheckBox runat="server" Text="Thuộc hộ bị thu hồi đất" ID="DTUT_THUHOI" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-6 pdl0">
                                <asp:CheckBox runat="server" Text="Thân nhân của người có công cách mạng" ID="DTUT_NCC" />
                            </div>
                            <div class="col-md-2 pdl0">
                                <asp:CheckBox runat="server" CssClass="chkDTTS" onchange="checkDanTocTS()" Text="Dân tộc thiểu số" ID="DTUT_DTTS" />
                            </div>
                            <div class="col-md-4 cbDTTS pdr0">
                                <div class="col-md-12 pdl0">
                                    <asp:DropDownList ID="drDanToc" runat="server" CssClass="cbDTTS selectpicker drDanToc" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12 pdr0 ">
                        <div class="col-md-2 lb">9.Trình độ giáo dục</div>
                        <div class="col-md-10 pdl0 pdb0 pdt0">
                            <asp:DropDownList ID="TrinhDoGD" runat="server" onchange="checkTDGD();" CssClass="selectpicker TrinhDoGD  validate[required]" />
                            <span class="required"></span>

                        </div>
                    </div>
                    <div class="clear"></div>

                    <%--<div class="title-ho bgt2">9.Trình độ chuyên môn kỹ thuật cao nhất</div>--%>
                    <div class="col-md-12 pdr0 ">
                        <div class="col-md-2 lb">10.Trình độ chuyên môn</div>
                        <div class="col-md-10 pdl0 pdb0 pdt0">
                            <asp:DropDownList ID="TrinhDoCM" runat="server" onchange="checkLVDT();" CssClass="selectpicker TrinhDoCM validate[required] " />
                            <span class="required"></span>

                        </div>
                    </div>
                    <div class="col-md-12 pdr0 ">
                        <div class="col-md-3 lb">10.1. Chuyên ngành đào tạo</div>
                        <div class="col-md-9 pdl0 pdb0 pdt0">
                            <%--<asp:TextBox ID="ChuyenNganhDaoTao" runat="server" CssClass="TextBox  " />--%>
                            <asp:DropDownList ID="LinhVucDT" runat="server" CssClass="selectpicker LinhVucDT " />
                            <span class="required"></span>

                        </div>
                    </div>
                    <div class="col-md-12 col-xs-12  pdb0 pdt0">
                        <div class="col-md-3 lb">11.Tình trạng tham gia hoạt động kinh tế</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="_TTTGHDKT" runat="server" onchange="loadTTTGHDKT();" CssClass="selectpicker TTTGHDKT validate[required]">
                                <asp:ListItem Text="---Chọn tình trạng---" Value=""></asp:ListItem>
                                <asp:ListItem Text="1--Người có việc làm" Value="1"></asp:ListItem>
                                <asp:ListItem Text="2--Người thất nghiệp" Value="2"></asp:ListItem>
                                <asp:ListItem Text="3--Không tham gia hoạt động kinh tế" Value="3"></asp:ListItem>
                            </asp:DropDownList>
                            <span class="required"></span>
                            <%-- <div class="col-md-6">
                                        <asp:RadioButton runat="server" GroupName="TTTGHDKT" onchange="loadTTTGHDKT();" Checked="false" CssClass="rdCVL" ID="rdCVL" Text="Người có việc làm" />
                                    </div>
                                    <div class="col-md-6">
                                        <asp:RadioButton runat="server" GroupName="TTTGHDKT" onchange="loadTTTGHDKT();" Checked="false" CssClass="rdNTN" ID="rdNTN" Text="Người thất nghiệp" />
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-4 pdt5">
                                        <asp:RadioButton runat="server" GroupName="TTTGHDKT" onchange="loadTTTGHDKT();" Checked="false" CssClass="rdKTG" ID="rdKTG" Text="Không tham gia hoạt động kinh tế" />
                                    </div>--%>
                        </div>
                        <div class="col-md-5 boxg5" id="lydokhongthamgiahdkt">
                            <div class="col-md-5 lb">
                                Lý do không tham gia
                            </div>
                            <div class="col-md-7">

                                <asp:DropDownList ID="LyDoKhongThamGia" runat="server" CssClass="selectpicker LyDoKhongThamGia" />
                            </div>
                        </div>
                    </div>
                    <div class="row boxg3" id="box-ho-two">
                        <div class="col-md-12 lb bold">12.Đối với người có việc làm</div>
                        <div class="clear"></div>
                        <div class="col-md-12 pdr0 pdl0">
                            <div class="col-md-2  pdb0 pdt5 lb">12.1.Vị thế việc làm </div>
                            <div class="col-md-10 pdl0 pdb0 pdt0">
                                <asp:DropDownList ID="HinhThuc" runat="server" CssClass="selectpicker HinhThuc" />
                            </div>
                        </div>
                        <div class="col-md-12 pdr0 pdl0 ">
                            <div class="col-md-3  pdb0 pdt5 lb">12.2.Công việc cụ thể đang làm </div>
                            <div class="col-md-9 pdl0 pdb0 pdt0">
                                <div class="col-md-12">
                                    <asp:DropDownList ID="WorkJoin" runat="server" CssClass="selectpicker WorkJoin" />
                                </div>
                                <div class="col-md-3 pdb0 pdt5 lb">a) Tham gia BHXH   </div>
                                <div class="col-md-9">
                                    <asp:DropDownList runat="server" onchange="checkThamGiaBHXH()" CssClass="selectpicker _ThamGiaBHXH " ID="_ThamGiaBHXH">
                                        <asp:ListItem Text="1--Có" Value="1" />
                                        <asp:ListItem Text="0--Không" Value="0" />
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-12" id="loaiBHXH">
                                    <div class="col-md-3 pdb0 pdt5 lb">Loại BHXH</div>
                                    <div class="col-md-9">

                                        <asp:DropDownList runat="server" CssClass="selectpicker _ThamGiaBHXH_Loai " ID="_ThamGiaBHXH_Loai">
                                            <asp:ListItem Text="--Chọn--" Value="0" />
                                            <asp:ListItem Text="1--Bắt buộc" Value="1" />
                                            <asp:ListItem Text="2--Tự nguyện" Value="2" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3 pdb0 pdt5 lb">b) Hợp đồng lao động   </div>
                                <div class="col-md-9">
                                    <asp:DropDownList runat="server" onchange="checkHDLD()" CssClass="selectpicker _HDLD " ID="_HDLD">
                                        <asp:ListItem Text="1--Có" Value="1" />
                                        <asp:ListItem Text="0--Không" Value="0" />
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-12" id="loaiHDLD">

                                    <div class="col-md-3 lb">
                                        Loại HĐLĐ
                                    </div>
                                    <div class="col-md-9">
                                        <asp:DropDownList runat="server" CssClass="selectpicker _LoaiHDLD " ID="_LoaiHDLD">
                                            <asp:ListItem Text="--Chọn--" Value="0" />
                                            <asp:ListItem Text="1--HĐLĐ xác định thời hạn" Value="1" />
                                            <asp:ListItem Text="2--HĐLĐ không xác định thời hạn" Value="2" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-4 lb">
                                        Thời gian bắt đầu thực hiện HĐLĐ
                                    </div>
                                    <div class="col-md-8 ThoiGianHDLD">
                                        <telerik:RadMaskedTextBox Mask="##/##/####" Width="100%" runat="server" CssClass="TextBox" ID="_ThoiGianHDLD" />
                                        <%--<asp:TextBox runat="server" CssClass="datepicker" ID="_ThoiGianHDLD"></asp:TextBox>--%>
                                    </div>

                                </div>
                            </div>

                        </div>

                        <div class="col-md-12 pdr0 pdl0 ">
                            <div class="col-md-3 lb pdt5">12.3.Nơi làm việc</div>
                            <div class="col-md-9 pdl0 pdb0 pdt0">
                                <div class="col-md-12">
                                    <asp:TextBox ID="_DoanhNghiepLamViec" runat="server" CssClass="TextBox _DoanhNghiepLamViec" />
                                </div>
                                <div id="thongtinchitietNLV" class="row">
                                    <div class="col-md-3 pdb0 pdt5 lb">a) Loại hình nơi làm việc</div>
                                    <div class="col-md-5">
                                        <asp:DropDownList runat="server" onchange="checkLoaiHinhKT()" CssClass="selectpicker _LoaiHinhKT" ID="_LoaiHinhKT">
                                            <asp:ListItem Text="--- Chọn ---" Value="0" />
                                            <asp:ListItem Text="1--Hộ nông, lâm nghiệp, thủy sản" Value="1" />
                                            <asp:ListItem Text="2--Cá nhân lao động tự do" Value="2" />
                                            <asp:ListItem Text="3--Cơ sở kinh doanh cá thể" Value="3" />
                                            <asp:ListItem Text="4--Hợp tác xã" Value="4" />
                                            <asp:ListItem Text="5--Doanh nghiệp" Value="5" />
                                            <asp:ListItem Text="6--Khu vực nhà nước" Value="6" />
                                            <asp:ListItem Text="7--Đơn vị sự nghiệp ngoài nhà nước" Value="7" />
                                            <asp:ListItem Text="8--Khu vực nước ngoài" Value="8" />
                                            <asp:ListItem Text="9--Tổ chức đoàn thể khác" Value="9" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-4">
                                        <asp:DropDownList runat="server" CssClass="selectpicker _LoaiHinhKT_DN" ID="_LoaiHinhKT_DN">
                                            <asp:ListItem Text="--- Chọn ---" Value="" />
                                            <asp:ListItem Text="1--DN Nhà nước" Value="1" />
                                            <asp:ListItem Text="2--DN ngoài Nhà nước" Value="2" />
                                            <asp:ListItem Text="3--DN FDI" Value="3" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="clear"></div>

                                    <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                                        <ContentTemplate>
                                            <div class="col-md-3 pdb0 pdt5 lb">b) Địa chỉ nơi làm việc</div>
                                            <div class="col-md-9">
                                                
                                                <div class="col-md-12 pdl0 QuocGiaLV">
                                                    <asp:DropDownList ID="_QuocGiaLV" onchange="checkQuocGiaLamViec()" runat="server"  CssClass="selectpicker _QuocGiaLV" />
                                                </div>
                                                <div class="NoiLamViecTaiVietNam">


                                                <div class="col-md-12 pdl0 ">
                                                    <asp:CheckBox runat="server" ID="chkSuDungLaiThuongTruNLV" onchange="checkDCTT()" CssClass="chkSuDungLaiThuongTruNLV" Text="Sử dụng lại địa chỉ nơi ở hiện tại" />
                                                </div>
                                                <div class="col-md-6 pdl0 DiaChiNLV">
                                                    <asp:DropDownList ID="_MaTinh_NLV" runat="server" AutoPostBack="true" CssClass="selectpicker _MaTinh_NLV" />
                                                </div>
                                                <div class="col-md-6 pdl0 DiaChiNLV">
                                                    <asp:DropDownList ID="_MaHuyen_NLV" runat="server" AutoPostBack="true" CssClass="selectpicker _MaHuyen_NLV " />

                                                </div>
                                                <div class="col-md-6 pdl0 DiaChiNLV">
                                                    <asp:DropDownList ID="_MaXa_NLV" runat="server" AutoPostBack="true" CssClass="selectpicker _MaXa_NLV  " />

                                                </div>
                                                <div class="col-md-6 pdl0 DiaChiNLV">
                                                    <asp:DropDownList ID="_MaThon_NLV" runat="server" CssClass="selectpicker _MaThon_NLV " />

                                                </div>
                                                <div class="col-md-12 pdl0 DiaChiNLV">
                                                    <asp:TextBox ID="_DiaCHi_NLV" ToolTip="Nhập địa chỉ cụ thể (số nhà, đường phố)" placeholder="Nhập địa chỉ cụ thể (số nhà, đường phố)" runat="server" CssClass="TextBox DiaChi_HT" />
                                                </div>
                                                    
                                                </div>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-12 pdr0 none">
                            <div class="col-md-12 pdl0 pdb0 pdt0">11.3.Tỉnh thành nơi làm việc</div>
                            <div class="col-md-12 pdl0 pdb0 pdt0">
                                <asp:DropDownList ID="NoiLamViec" runat="server" CssClass="selectpicker NoiLamViec" />
                            </div>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-12 pdr0 none">
                            <div class="col-md-12 pdl0 pdb0 pdt0">11.3a.Địa chỉ làm việc</div>
                            <div class="col-md-12 pdl0 pdb0 pdt0">
                                <asp:TextBox ID="DiaChiLamViec" runat="server" CssClass="TextBox uppercase DiaChiLamViec" />
                            </div>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-12 pdr0 none">
                            <div class="col-md-12 pdl0 pdb0 pdt0">11.3b.Ngành nghề kinh doanh</div>
                            <div class="col-md-12 pdl0 pdb0 pdt0">
                                <asp:DropDownList ID="NganhNghe" runat="server" CssClass="selectpicker NganhNghe" />
                            </div>
                        </div>
                        <div class="clear"></div>
                        <%-- <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.3c.Loại hình kinh tế (9xx)</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="LoaiHinhKT" runat="server" CssClass="selectpicker LoaiHinhKT" />
                                        </div>
                                    </div>--%>
                        <div class="clear"></div>
                        <div class="col-md-12 pdr0 none">
                            <div class="col-md-12 pdl0 pdb0 pdt0">11.3d.Nước làm việc</div>
                            <div class="col-md-12 pdl0 pdb0 pdt0">
                                <asp:DropDownList ID="NuocLamViec" runat="server" CssClass=" NuocLamViec" />
                            </div>
                        </div>
                    </div>

                    <div class="col-md-12 col-xs-12 pdt0 pdb0 boxg4" id="box-ho-three">
                        <div class="col-md-2 bold lb">13. Người thất nghiệp</div>
                        <div class="col-md-4 pdl5 pdb0 pdt0 ">
                            <div class="col-md-12 pdl0 pdb0 pdt0">
                                <asp:DropDownList ID="LoaiThatNghiep" runat="server" CssClass="LoaiThatNghiep selectpicker" />
                                <%--<asp:DropDownList ID="LoaiThatNghiep" TabIndex="30" onchange="nextchange('', this,'ThoiGianThatNghiep','4');" runat="server" CssClass="LoaiThatNghiep selectpicker" />--%>
                            </div>
                        </div>
                        <div class="col-md-12 pdr0 hidden">
                            <div class="col-md-12 pdl0 pdb0 pdt0 lb">13.1.Thời gian thất nghiệp</div>
                            <div class="col-md-12 pdl0 pdb0 pdt0">
                                <asp:TextBox ID="ThoiGianThatNghiep" runat="server" CssClass="TextBox ThoiGianThatNghiep" />
                            </div>
                        </div>
                        <div class="col-md-2 lb pdb0 pdt5">13.1 Thời gian thất nghiệp</div>
                        <div class="col-md-4 pdl0 pdb0 pdt0">
                            <asp:DropDownList ID="drThoiGianThatNghiep" runat="server" CssClass="ThoiGianThatNghiep selectpicker " />
                        </div>
                        <div class="clear"></div>
                        <div class="row box-info pd0 boxg5 none">
                            <div class="title-ho bgt5">Đối với người không tham gia hoạt động kinh tế</div>
                            <div class="clear"></div>
                            <div class="col-md-12 pdr0  ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">12.Lý do không tham gia (12xx)</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                </div>
                            </div>
                            <div class="col-md-12 pdr0 none ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">13.Ghi chú</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox GhiChu" />
                                </div>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="row box-info pd0 boxg6 none">
                            <div class="title-ho bgt6">Biến động thông tin</div>
                            <div class="clear"></div>
                            <div class="col-md-12 pdr0 pdt10">
                                <div class="col-md-12 pdl0 pdb0">
                                    <asp:DropDownList ID="LoaiChuyen" runat="server" CssClass="selectpicker LoaiChuyen" />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 pdr0" style="padding-bottom: 12px;">
                                <div class="col-md-12 pdl0 pdb0 pdt5"></div>
                                <asp:CheckBox ID="CatChet" Text="Khai tử?" runat="server" CssClass="CheckBox CatChet" />
                            </div>
                        </div>
                    </div>

                    <div class="clear"></div>

                    <div class="col-md-2 lb pdb0 pdt5">14. Số điện thoại</div>
                    <div class="col-md-10 pdl0 pdb0 pdt0">
                        <asp:TextBox ID="_SoDienThoai" runat="server" CssClass="_SoDienThoai TextBox" />
                    </div>
                </div>
                <asp:Literal ID="litUpdate" runat="server" />

            </div>
            <div class="clrUp"></div>

        </div>
    </div>
</div>
<div class="none">
    <asp:HiddenField ID="IdHo" Visible="false" runat="server" />
    <asp:HiddenField ID="IdKhau"  runat="server" />
    <asp:HiddenField ID="YearPro" Visible="false" runat="server" />
    <asp:HiddenField ID="IsLock" Visible="false" runat="server" />
    <asp:HiddenField ID="TrinhDoGDOld" Visible="false" runat="server" />
    <asp:HiddenField ID="TrinhDoCMOld" Visible="false" runat="server" />
    <asp:HiddenField ID="LinhVucDTOld" Visible="false" runat="server" />
    <asp:HiddenField ID="CongViecThamGiaOld" Visible="false" runat="server" />
    <asp:HiddenField ID="LyDoKhongThamGiaOld" Visible="false" runat="server" />
    <asp:HiddenField ID="IsNew" Visible="false" runat="server" />
    <asp:HiddenField ID="IsNewKhau" Visible="false" runat="server" />
    <asp:HiddenField ID="LoaiBienDongHo" Visible="false" Value="0" runat="server" />
    <asp:HiddenField ID="LoaiBienDongKhau" Visible="false" Value="0" runat="server" />
</div>
</div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="(F7) Đóng" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdReset" runat="server" Text="(F11) Làm mới" data-toggle="tooltip" ToolTip="Thông tin đã nhập sẽ bị xóa và không được lưu lại" CssClass="cmsbut Refresh" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="(F8) Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdAddTab" runat="server" Text="(F9) Lưu và Thêm đối tượng" data-toggle="tooltip" ToolTip="Thông tin đối tượng được lưu lại và hiển thị màn hình thêm mới" CssClass="cmsbut cmsbtnew" OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdAddHo" Visible="false" runat="server" Text="(F10) Thêm hộ mới" CssClass="cmsbut cmsbtrun" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdDelHo" Visible="false" runat="server" Text="(F3) Xóa hộ" CssClass="cmsbut cmsbtdelHo"></asp:Button>
                <asp:Button ID="cmdDelete" runat="server" Text="(F4) Xóa đối tượng" CssClass="cmsbut cmsbtdel" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdExport" runat="server" Text="Tải phiếu điều tra" OnClientClick="popdoc('exports'); return false;" CssClass="cmsbut cmsbtDownload cbclick" />

                <div class="clear"></div>
            </div>
        </div>
<script type="text/javascript">
    $(document).ready(function () {
        $("form").bind("keypress", function (e) {
            if (e.keyCode == 13) {
                return false;
            }
        });
        loadDiaChiTT(); checkDanTocTS(); checkLVDT(); loadTDGD()
        loadTTTGHDKT(); changeNoiLamViec(); checkLoaiHinhKT();
        checkThamGiaBHXH();
        checkHDLD();
        checkQuocGiaLamViec();
        checkDCTT();
        disableTab();

        //$(".disabledbutton").attr('disabled', 'disabled');
        //$(".disabledbutton").attr('disabled', 'disabled');
        //$(".disabledbutton div").attr('disabled', 'disabled');
        //$(".disabledbutton input").attr('disabled', 'disabled');
        //$(".disabledbutton select").attr('disabled', 'disabled');
    });
    function checkTrungCCCD() {
        $.ajax({
            type: "GET", url: '/api/work/cungld.asmx/CheckTrungCCCD?&tinhTP=' + $("#<%=drTinhTP.ClientID %>").val() + '&cccd=' + $("#<%=CCCD.ClientID %>").val() + '&id=' + $("#<%=IdKhau.ClientID %>").val(),
            success: function (data) {
                var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                    if (json.data != "") {
                        notify('warning', ''+ json.data +'' , 'Thông báo', false);
                        return false;
                    } else {
                        return true;
                    }
                };
            },
        });
    }
    function nhayDenDTUT() {
        if ($('.IsDCTT').find('input:checked').length > 0) {
            $('#<%=DTUT_NKT.ClientID %>').focus();
        }
    }
    function disableTab() {
        $(".disabledbutton").attr("tabIndex", "-1");
        $(".disabledbutton div").attr("tabIndex", "-1");
        $(".disabledbutton input").attr("tabIndex", "-1");
        $(".disabledbutton select").attr("tabIndex", "-1");

    }
    function checkDCTT() {
        if ($('.chkSuDungLaiThuongTruNLV').find('input:checked').length > 0) {

            $(".DiaChiNLV").addClass("disabledbutton");
            $(".DiaChiNLV").attr("tabIndex", "-1");
            $(".DiaChiNLV div").attr("tabIndex", "-1");
            $(".DiaChiNLV input").attr("tabIndex", "-1");
            $(".DiaChiNLV select").attr("tabIndex", "-1");
            $(".DiaChiNLV button").attr("tabIndex", "-1");

        }
        else {

            $(".DiaChiNLV").removeClass("disabledbutton");
            $(".DiaChiNLV").removeAttr("tabIndex", "-1");
            $(".DiaChiNLV div").removeAttr("tabIndex", "-1");
            $(".DiaChiNLV input").removeAttr("tabIndex", "-1");
            $(".DiaChiNLV select").removeAttr("tabIndex", "-1");
            $(".DiaChiNLV button").removeAttr("tabIndex", "-1");
        }
    }
    function checkQuocGiaLamViec() {
        if ($("#<%=_QuocGiaLV.ClientID%>").val() == "1" || $("#<%=_QuocGiaLV.ClientID%>").val() == "") {
            $(".NoiLamViecTaiVietNam").removeClass("disabledbutton");
            $(".NoiLamViecTaiVietNam").removeAttr("tabIndex", "-1");
            $(".NoiLamViecTaiVietNam div").removeAttr("tabIndex", "-1");
            $(".NoiLamViecTaiVietNam input").removeAttr("tabIndex", "-1");
            $(".NoiLamViecTaiVietNam select").removeAttr("tabIndex", "-1");
            $(".NoiLamViecTaiVietNam button").removeAttr("tabIndex", "-1");
        }
        else {

            $(".NoiLamViecTaiVietNam").addClass("disabledbutton");
            $(".NoiLamViecTaiVietNam").attr("tabIndex", "-1");
            $(".NoiLamViecTaiVietNam div").attr("tabIndex", "-1");
            $(".NoiLamViecTaiVietNam input").attr("tabIndex", "-1");
            $(".NoiLamViecTaiVietNam select").attr("tabIndex", "-1");
            $(".NoiLamViecTaiVietNam button").attr("tabIndex", "-1");

        }
    }
    function loadDiaChiTT() {
        if ($('.IsDCTT').find('input:checked').length > 0) {
            $(".noidangkytt").removeClass("disabledbutton");
            $(".noidangkytt").removeAttr("tabIndex", "-1");
            $(".noidangkytt div").removeAttr("tabIndex", "-1");
            $(".noidangkytt input").removeAttr("tabIndex", "-1");
            $(".noidangkytt select").removeAttr("tabIndex", "-1");
        }
        else {
            $(".noidangkytt").addClass("disabledbutton");
            $(".noidangkytt").attr("tabIndex", "-1");
            $(".noidangkytt div").attr("tabIndex", "-1");
            $(".noidangkytt input").attr("tabIndex", "-1");
            $(".noidangkytt select").attr("tabIndex", "-1");
        }
    }
    function changeDiaChiTT() {
        if ($('.IsDCTT').find('input:checked').length > 0) {
            $(".noidangkytt").removeClass("disabledbutton");
            $(".noidangkytt").removeAttr("tabIndex", "-1");
            $(".noidangkytt div").removeAttr("tabIndex", "-1");
            $(".noidangkytt input").removeAttr("tabIndex", "-1");
            $(".noidangkytt select").removeAttr("tabIndex", "-1");
            $(".drTinhTP").focus();
        }
        else {
            $(".noidangkytt").addClass("disabledbutton");
        }
    }
    function checkLoaiHinhKT() {
        if ($('#<%=_LoaiHinhKT.ClientID%>').val() == "5") {

            $('._LoaiHinhKT_DN').removeClass("disabledbutton");
            $("._LoaiHinhKT_DN").removeAttr("tabIndex", "-1");
            $("._LoaiHinhKT_DN div").removeAttr("tabIndex", "-1");
            $("._LoaiHinhKT_DN input").removeAttr("tabIndex", "-1");
            $("._LoaiHinhKT_DN select").removeAttr("tabIndex", "-1");
            $("._LoaiHinhKT_DN button").removeAttr("tabIndex", "-1");
        }
        else {

            $('._LoaiHinhKT_DN').addClass("disabledbutton");
            $("._LoaiHinhKT_DN").attr("tabIndex", "-1");
            $("._LoaiHinhKT_DN div").attr("tabIndex", "-1");
            $("._LoaiHinhKT_DN input").attr("tabIndex", "-1");
            $("._LoaiHinhKT_DN select").attr("tabIndex", "-1");
            $("._LoaiHinhKT_DN button").attr("tabIndex", "-1");

            //$('._LoaiHinhKT_DN').val("");
            //$('._LoaiHinhKT_DN').selectpicker('refresh');

        }
    }
    function checkThamGiaBHXH() {

        if ($('#<%=_ThamGiaBHXH.ClientID %>').val() == 1) {



            $('._ThamGiaBHXH_Loai').removeClass("disabledbutton");
            $("._ThamGiaBHXH_Loai").removeAttr("tabIndex", "-1");
            $("._ThamGiaBHXH_Loai div").removeAttr("tabIndex", "-1");
            $("._ThamGiaBHXH_Loai input").removeAttr("tabIndex", "-1");
            $("._ThamGiaBHXH_Loai select").removeAttr("tabIndex", "-1");
            $("._ThamGiaBHXH_Loai button").removeAttr("tabIndex", "-1");


        } else {
            $('._ThamGiaBHXH_Loai').addClass("disabledbutton");
            $("._ThamGiaBHXH_Loai").attr("tabIndex", "-1");
            $("._ThamGiaBHXH_Loai div").attr("tabIndex", "-1");
            $("._ThamGiaBHXH_Loai input").attr("tabIndex", "-1");
            $("._ThamGiaBHXH_Loai button").attr("tabIndex", "-1");

            $('#<%=_ThamGiaBHXH_Loai.ClientID %>').val("0");
            $("#<%=_ThamGiaBHXH_Loai.ClientID%>").selectpicker('refresh');
        }
    }
    function checkHDLD() {

        if ($('#<%=_HDLD.ClientID %>').val() == 1) {

            $('._LoaiHDLD').removeClass("disabledbutton");
            $("._LoaiHDLD").removeAttr("tabIndex", "-1");
            $("._LoaiHDLD div").removeAttr("tabIndex", "-1");
            $("._LoaiHDLD input").removeAttr("tabIndex", "-1");
            $("._LoaiHDLD select").removeAttr("tabIndex", "-1");
            $("._LoaiHDLD button").removeAttr("tabIndex", "-1");

            $('.ThoiGianHDLD').removeClass("disabledbutton");
            $(".ThoiGianHDLD").removeAttr("tabIndex", "-1");
            $(".ThoiGianHDLD input").removeAttr("tabIndex", "-1");
        }
        else {

            $('._LoaiHDLD').addClass("disabledbutton");
            $("._LoaiHDLD").attr("tabIndex", "-1");
            $("._LoaiHDLD div").attr("tabIndex", "-1");
            $("._LoaiHDLD input").attr("tabIndex", "-1");
            $("._LoaiHDLD select").attr("tabIndex", "-1");
            $("._LoaiHDLD button").attr("tabIndex", "-1");

            $('.ThoiGianHDLD').addClass("disabledbutton");
            $(".ThoiGianHDLD").attr("tabIndex", "-1");
            $(".ThoiGianHDLD input").attr("tabIndex", "-1");

            $('#<%=_LoaiHDLD.ClientID %>').val("0");
            $("#<%=_LoaiHDLD.ClientID%>").selectpicker('refresh');
        }
    }
    function checkDanTocTS() {
        if ($('.chkDTTS').find('input:checked').length > 0) {
            $('.cbDTTS').fadeIn();
        }
        else {
            $('.cbDTTS').fadeOut();
        }
    }
    function checkLVDT() {
        if ($('#<%= TrinhDoCM.ClientID %>').val() == 16) {
            $('.LinhVucDT').addClass("disabledbutton");

            $(".LinhVucDT").attr("tabIndex", "-1");
            $(".LinhVucDT div").attr("tabIndex", "-1");
            $(".LinhVucDT input").attr("tabIndex", "-1");
            $(".LinhVucDT select").attr("tabIndex", "-1");
            $(".LinhVucDT button").attr("tabIndex", "-1");
            $('#<%=LinhVucDT.ClientID %>').val("");
            $("#<%=LinhVucDT.ClientID%>").selectpicker('refresh');
        }
        else {
            $('.LinhVucDT').removeClass("disabledbutton");
            $(".LinhVucDT").removeAttr("tabIndex", "-1");
            $(".LinhVucDT div").removeAttr("tabIndex", "-1");
            $(".LinhVucDT input").removeAttr("tabIndex", "-1");
            $(".LinhVucDT select").removeAttr("tabIndex", "-1");
            $(".LinhVucDT button").removeAttr("tabIndex", "-1");
        }
    }
    function loadTDGD() {
        if ($('#<%= TrinhDoGD.ClientID %>').val() == 18 || $('#<%= TrinhDoGD.ClientID %>').val() == 19) {
            $("#<%=TrinhDoCM.ClientID%> option[value*='21']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='22']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='23']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='24']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='25']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='26']").prop('disabled', true);
        }
        else {
            $("#<%=TrinhDoGD.ClientID%> option[value*='21']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='22']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='23']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='24']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='25']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='26']").prop('enable', true);
        }
    }
    function checkTDGD() {
        if ($('#<%=TrinhDoGD.ClientID%>').val() == 21) {

            $("#<%=TrinhDoCM.ClientID%> option[value*='22']").removeProp('disabled');
            $("#<%=TrinhDoCM.ClientID%> option[value*='24']").removeProp('disabled');
            $("#<%=TrinhDoCM.ClientID%> option[value*='25']").removeProp('disabled');
            $("#<%=TrinhDoCM.ClientID%> option[value*='26']").removeProp('disabled');
            $("#<%=TrinhDoCM.ClientID%> option[value*='22']").removeAttr('disabled');
            $("#<%=TrinhDoCM.ClientID%> option[value*='24']").removeAttr('disabled');
            $("#<%=TrinhDoCM.ClientID%> option[value*='25']").removeAttr('disabled');
            $("#<%=TrinhDoCM.ClientID%> option[value*='26']").removeAttr('disabled');

            $("#<%=TrinhDoCM.ClientID%> option[value*='22']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='24']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='25']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='26']").prop('enable', true);

            $('#<%=TrinhDoCM.ClientID %>').val("");
            $("#<%=TrinhDoCM.ClientID%>").selectpicker('refresh');

            $('#<%=LinhVucDT.ClientID %>').val("");
            $("#<%=LinhVucDT.ClientID%>").selectpicker('refresh');
        }
        else {

            $("#<%=TrinhDoCM.ClientID%> option[value*='22']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='24']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='25']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='26']").prop('disabled', true);

            $('#<%=TrinhDoCM.ClientID %>').val("");
            $("#<%=TrinhDoCM.ClientID%>").selectpicker('refresh');


        }
    }
    function loadDanTocTS() {

    };

    function loadTTTGHDKT() {
        $('.boxg5').addClass("hidden");

        if ($('#<%=_TTTGHDKT.ClientID %>').val() == "") {
            $('.boxg5').addClass("hidden");
            $('.boxg4').addClass("disabledbutton");
            $('.boxg3').addClass("disabledbutton");

            $(".boxg4").attr("tabIndex", "-1");
            $(".boxg4 div").attr("tabIndex", "-1");
            $(".boxg4 input").attr("tabIndex", "-1");
            $(".boxg4 select").attr("tabIndex", "-1");

            $(".boxg3").attr("tabIndex", "-1");
            $(".boxg3 div").attr("tabIndex", "-1");
            $(".boxg3 input").attr("tabIndex", "-1");
            $(".boxg3 select").attr("tabIndex", "-1");
            $(".boxg3 button").attr("tabIndex", "-1");

          <%--  $('#<%=LoaiThatNghiep.ClientID %>').val("");
            $("#<%=LoaiThatNghiep.ClientID%>").selectpicker('refresh');

            $('#<%=drThoiGianThatNghiep.ClientID %>').val("");
            $("#<%=drThoiGianThatNghiep.ClientID%>").selectpicker('refresh');

            $('#<%=LyDoKhongThamGia.ClientID%>').val("");
            $("#<%=LyDoKhongThamGia.ClientID%>").selectpicker('refresh');--%>


        }
        if ($('#<%=_TTTGHDKT.ClientID %>').val() == "3") {
            $('.boxg5').removeClass("hidden");
            $('.boxg4').addClass("disabledbutton");
            $('.boxg3').addClass("disabledbutton");

            $(".boxg4").attr("tabIndex", "-1");
            $(".boxg4 div").attr("tabIndex", "-1");
            $(".boxg4 input").attr("tabIndex", "-1");
            $(".boxg4 select").attr("tabIndex", "-1");
            $(".boxg3").attr("tabIndex", "-1");
            $(".boxg3 div").attr("tabIndex", "-1");
            $(".boxg3 input").attr("tabIndex", "-1");
            $(".boxg3 select").attr("tabIndex", "-1");
            $(".boxg3 button").attr("tabIndex", "-1");

            $('#<%=LoaiThatNghiep.ClientID %>').val("");
            $("#<%=LoaiThatNghiep.ClientID%>").selectpicker('refresh');

            $('#<%=drThoiGianThatNghiep.ClientID %>').val("");
            $("#<%=drThoiGianThatNghiep.ClientID%>").selectpicker('refresh');
            //clear co viec lam
            //HinhThuc=""

            $('#<%=HinhThuc.ClientID %>').val("");
            $("#<%=HinhThuc.ClientID%>").selectpicker('refresh');
            //WorkJoin=0

            $('#<%=WorkJoin.ClientID %>').val("");
            $("#<%=WorkJoin.ClientID%>").selectpicker('refresh');
            //_ThamGiaBHXH=0

            $('#<%=_ThamGiaBHXH.ClientID %>').val("0");
            $("#<%=_ThamGiaBHXH.ClientID%>").selectpicker('refresh');
            //_ThamGiaBHXH_Loai=0

            $('#<%=_ThamGiaBHXH_Loai.ClientID %>').val("0");
            $("#<%=_ThamGiaBHXH_Loai.ClientID%>").selectpicker('refresh');
            //_HDLD=0

            $('#<%=_HDLD.ClientID %>').val("0");
            $("#<%=_HDLD.ClientID%>").selectpicker('refresh');
            //_LoaiHDLD=0

            $('#<%=_LoaiHDLD.ClientID %>').val("0");
            $("#<%=_LoaiHDLD.ClientID%>").selectpicker('refresh');
            //_ThoiGianHDLD = "__/__/____"

            $('#<%=_ThoiGianHDLD.ClientID %>').val("__/__/____");
            //_DoanhNghiepLamViec =""

            $('#<%=_DoanhNghiepLamViec.ClientID %>').val("");
            //_LoaiHinhKT=0
            $('#<%=_LoaiHinhKT.ClientID %>').val("0");
            $("#<%=_LoaiHinhKT.ClientID%>").selectpicker('refresh');
            //LoaiHinhKT_DN=0

            $('#<%=_LoaiHinhKT_DN.ClientID%>').val("");
            $("#<%=_LoaiHinhKT_DN.ClientID%>").selectpicker('refresh');
            //_MaTinh_NLV = ""

            $('#<%=_MaTinh_NLV.ClientID %>').val("");
            $("#<%=_MaTinh_NLV.ClientID%>").selectpicker('refresh');
            //_MaHuyen_NLV=""

            $('#<%=_MaHuyen_NLV.ClientID %>').val("");
            $("#<%=_MaHuyen_NLV.ClientID%>").selectpicker('refresh');
            //_MaXa_NLV=""

            $('#<%=_MaXa_NLV.ClientID %>').val("");
            $("#<%=_MaXa_NLV.ClientID%>").selectpicker('refresh');
            //_MaThon_NLV=""

            $('#<%=_MaThon_NLV.ClientID %>').val("");
            $("#<%=_MaThon_NLV.ClientID%>").selectpicker('refresh');
            //_DiaCHi_NLV=""
            $('#<%=_DiaCHi_NLV.ClientID %>').val("");
        }
        if ($('#<%=_TTTGHDKT.ClientID %>').val() == "2") {
            $('.boxg5').addClass("hidden");
            $('.boxg4').removeClass("disabledbutton");
            $('.boxg3').addClass("disabledbutton");

            $(".boxg4").removeAttr("tabIndex", "-1");
            $(".boxg4 div").removeAttr("tabIndex", "-1");
            $(".boxg4 input").removeAttr("tabIndex", "-1");
            $(".boxg4 select").removeAttr("tabIndex", "-1");

            $(".boxg3").attr("tabIndex", "-1");
            $(".boxg3 div").attr("tabIndex", "-1");
            $(".boxg3 input").attr("tabIndex", "-1");
            $(".boxg3 select").attr("tabIndex", "-1");
            $(".boxg3 button").attr("tabIndex", "-1");

            //clear co viec lam
            //HinhThuc=""

            $('#<%=HinhThuc.ClientID %>').val("");
            $("#<%=HinhThuc.ClientID%>").selectpicker('refresh');
            //WorkJoin=0

            $('#<%=WorkJoin.ClientID %>').val("");
            $("#<%=WorkJoin.ClientID%>").selectpicker('refresh');
            //_ThamGiaBHXH=0

            $('#<%=_ThamGiaBHXH.ClientID %>').val("0");
            $("#<%=_ThamGiaBHXH.ClientID%>").selectpicker('refresh');
            //_ThamGiaBHXH_Loai=0

            $('#<%=_ThamGiaBHXH_Loai.ClientID %>').val("0");
            $("#<%=_ThamGiaBHXH_Loai.ClientID%>").selectpicker('refresh');
            //_HDLD=0

            $('#<%=_HDLD.ClientID %>').val("0");
            $("#<%=_HDLD.ClientID%>").selectpicker('refresh');
            //_LoaiHDLD=0

            $('#<%=_LoaiHDLD.ClientID %>').val("0");
            $("#<%=_LoaiHDLD.ClientID%>").selectpicker('refresh');
            //_ThoiGianHDLD = "__/__/____"

            $('#<%=_ThoiGianHDLD.ClientID %>').val("__/__/____");
            //_DoanhNghiepLamViec =""

            $('#<%=_DoanhNghiepLamViec.ClientID %>').val("");
            //_LoaiHinhKT=0
            $('#<%=_LoaiHinhKT.ClientID %>').val("0");
            $("#<%=_LoaiHinhKT.ClientID%>").selectpicker('refresh');
            //LoaiHinhKT_DN=0

            $('#<%=_LoaiHinhKT_DN.ClientID%>').val("");
            $("#<%=_LoaiHinhKT_DN.ClientID%>").selectpicker('refresh');
            //_MaTinh_NLV = ""

            $('#<%=_MaTinh_NLV.ClientID %>').val("");
            $("#<%=_MaTinh_NLV.ClientID%>").selectpicker('refresh');
            //_MaHuyen_NLV=""

            $('#<%=_MaHuyen_NLV.ClientID %>').val("");
            $("#<%=_MaHuyen_NLV.ClientID%>").selectpicker('refresh');
            //_MaXa_NLV=""

            $('#<%=_MaXa_NLV.ClientID %>').val("");
            $("#<%=_MaXa_NLV.ClientID%>").selectpicker('refresh');
            //_MaThon_NLV=""

            $('#<%=_MaThon_NLV.ClientID %>').val("");
            $("#<%=_MaThon_NLV.ClientID%>").selectpicker('refresh');
            //_DiaCHi_NLV=""
            $('#<%=_DiaCHi_NLV.ClientID %>').val("");


            $('#<%=LyDoKhongThamGia.ClientID%>').val("");
            $("#<%=LyDoKhongThamGia.ClientID%>").selectpicker('refresh')
        }
        if ($('#<%=_TTTGHDKT.ClientID %>').val() == 1) {
            $('.boxg5').addClass("hidden");
            $('.boxg4').addClass("disabledbutton");
            $('.boxg3').removeClass("disabledbutton");

            $(".boxg3").removeAttr("tabIndex", "-1");
            $(".boxg3 div").removeAttr("tabIndex", "-1");
            $(".boxg3 input").removeAttr("tabIndex", "-1");
            $(".boxg3 select").removeAttr("tabIndex", "-1");
            $(".boxg3 button").removeAttr("tabIndex", "-1");

            $(".boxg4").attr("tabIndex", "-1");
            $(".boxg4 div").attr("tabIndex", "-1");
            $(".boxg4 input").attr("tabIndex", "-1");
            $(".boxg4 select").attr("tabIndex", "-1");

            $('#<%=LoaiThatNghiep.ClientID %>').val("");
            $("#<%=LoaiThatNghiep.ClientID%>").selectpicker('refresh');

            $('#<%=drThoiGianThatNghiep.ClientID %>').val("");
            $("#<%=drThoiGianThatNghiep.ClientID%>").selectpicker('refresh');


            $('#<%=LyDoKhongThamGia.ClientID%>').val("");
            $("#<%=LyDoKhongThamGia.ClientID%>").selectpicker('refresh');
        }
    };
    function changeNoiLamViec() {
      <%--  if ($('#<%=_DoanhNghiepLamViec.ClientID%>').val().length > 0) {
            $('#thongtinchitietNLV').removeClass("disabledbutton");
        }
        else {
            $('#thongtinchitietNLV').addClass("disabledbutton");
        }--%>
    };

    document.onkeydown = function (e) {
        if (e.keyCode == 118) { $(".cmsback").click(); }
        else if (e.keyCode === 119) { $(".cmsbtupdate").click(); }
        else if (e.keyCode === 120) { $(".cmsbtnew").click(); }
        else if (e.keyCode === 121) { $(".cmsbtrun").click(); }
        else if (e.keyCode === 115) { $(".cmsbtdel").click(); }
        else if (e.keyCode === 114) { $(".cmsbtdelHo").click(); }
    };
    function setFullScreen() { if ($(document.body).hasClass("fullScreen")) { $(document.body).removeClass("fullScreen"); } else { $(document.body).addClass("fullScreen"); } }
    //$('body').on('keydown', '.drTinhTP > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drTinhTP > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drTinhTP').selectpicker('toggle'); return false; } else { $(".drQuanHuyen").focus(); } } });
    //$('body').on('keydown', '.drQuanHuyen > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drQuanHuyen > button").attr("title"); if (vl === "--- Quận/huyện ---") { $('.drQuanHuyen').selectpicker('toggle'); return false; } else { $(".drPhuongXa").focus(); } } });
    //$('body').on('keydown', '.drPhuongXa > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drPhuongXa > button").attr("title"); if (vl === "--- Phường/xã ---") { $('.drPhuongXa').selectpicker('toggle'); return false; } else { $(".drThonTo").focus(); } } });
    //$('body').on('keydown', '.drThonTo > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drThonTo > button").attr("title"); if (vl === "--- Thôn/tổ ---") { $('.drThonTo').selectpicker('toggle'); return false; } else { $(".MaHo").focus(); } } });
    //$('body').on('keydown', '.LoaiHo > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".LoaiHo > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.LoaiHo').selectpicker('toggle'); return false; } else { $(".drSo").focus(); } } });
    //$('body').on('keydown', '.drSo > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drSo > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drSo').selectpicker('toggle'); return false; } else { $(".DiaChi").focus(); } } });
    //$('body').on('keydown', '.QuanHe > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".QuanHe > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.QuanHe').selectpicker('toggle'); return false; } else { $(".drDanToc").focus(); } } });
    //$('body').on('keydown', '.drDanToc > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drDanToc > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drDanToc').selectpicker('toggle'); return false; } else { $(".CCCD").focus(); } } });
    //$('body').on('keydown', '.CCCD > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".CCCD > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.CCCD').selectpicker('toggle'); return false; } else { $(".drGioiTinh").focus(); } } });
    //$('body').on('keydown', '.drGioiTinh > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drGioiTinh > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drGioiTinh').selectpicker('toggle'); return false; } else { $(".NgaySinh").focus(); } } });
    //$('body').on('keydown', '.TrinhDoGD > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".TrinhDoGD > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.TrinhDoGD').selectpicker('toggle'); return false; } else { $(".TrinhDoCM").focus(); } } });
    //$('body').on('keydown', '.TrinhDoCM > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { $(".LinhVucDT").focus(); } });
    //$('body').on('keydown', '.LinhVucDT > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { $(".WorkJoin").focus(); } });
    //$('body').on('keydown', '.WorkJoin > button.dropdown-toggle', function (e) { console.log(e.keyCode); if (e.keyCode === 13) { removethatnghiep(); removeKtg(); var vl = $(".WorkJoin > button").attr("title"); if (vl === "0--Không có việc làm") { $(".LoaiThatNghiep").focus(); } else { $(".NoiLamViec").focus(); } } });
    //$('body').on('keydown', '.NoiLamViec > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); var vl = $(".NoiLamViec > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.NoiLamViec').selectpicker('toggle'); return false; } else { $(".NganhNghe").focus(); } } });
    //$('body').on('keydown', '.NganhNghe > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); $(".NuocLamViec").focus(); } });
    //$('body').on('keydown', '.NuocLamViec > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); $(".DiaChiLamViec").focus(); } });
    //$('body').on('keydown', '.HinhThuc > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); var vl = $(".HinhThuc > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.HinhThuc').selectpicker('toggle'); return false; } else { $(".LoaiHinhKT").focus(); } } });
    //$('body').on('keydown', '.LoaiHinhKT > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removeKtg(); var vl = $(".LoaiHinhKT > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.LoaiHinhKT').selectpicker('toggle'); return false; } else { $(".LoaiChuyen").focus(); } } });
    //$('body').on('keydown', '.LoaiChuyen > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".LoaiChuyen > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.LoaiChuyen').selectpicker('toggle'); return false; } else { $(".CatChet input").focus(); } } });
    //$('body').on('keydown', '.LoaiThatNghiep > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removecvl(); removeKtg(); $(".ThoiGianThatNghiep").focus(); } });
    //$('body').on('keydown', '.LyDoKhongThamGia > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { removethatnghiep(); removecvl(); $(".GhiChu").focus(); } });
    //$('body').on('keydown', '.thonToMenuLeft > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { $(".keyMenuLeft").focus(); } });
    //$('body').on('keydown', '.keyMenuLeft', function (e) { if (e.keyCode === 13) { $(".timKiemMenuLeft").click(); } });
    function nextchange(ct, th, nt, id) { if (id === "1") { removethatnghiep(); removeKtg(); $("." + nt).focus(); } else if (id === "5") { removethatnghiep(); removecvl(); $("." + nt).focus(); } else if (id === "4") { removecvl(); removeKtg(); $("." + nt).focus(); } else if (id === "2") { $("." + nt + " input").focus(); } else if (id === "3") { removethatnghiep(); removeKtg(); if ($(th).val() != "") { $("." + nt).focus(); } else { $("." + ct).focus(); } } else { if ($(th).val() != "") { $("." + nt).focus(); } } };
    //function nextfocus(ac, th, e, nt, et) { if (e.keyCode === 13) { if (et === 1) { $("." + nt).click(); } else { if (ac === 1) { if ($(th).val() != "") { $("." + nt).focus(); } else { $("." + nt).focus(); } } else { $("." + nt).focus(); } } return false; } else { return true; } };
    function nextfocus2(th) { $("." + th).focus(); };

    function pageLoad() { var minStartDate = new Date(2015, 09, 26); var maxStartDate = new Date(2019, 09, 26); $('#<%=TrinhDoCM.ClientID%>').mask('__/__/____', { placeholder: "#" }); $('.datepicker').datetimepicker({ timepicker: false, minDate: minStartDate, maxDate: maxStartDate, format: 'd/m/Y', mask: false, closeOnDateSelect: true }); };
    function removethatnghiep() { $("#<%=LoaiThatNghiep.ClientID%>").val(""); $("#<%=ThoiGianThatNghiep.ClientID%>").val(""); $("#<%=LoaiThatNghiep.ClientID%>").selectpicker('refresh'); $("#<%=ThoiGianThatNghiep.ClientID%>").selectpicker('refresh'); };
    function removeKtg() {
        $("#<%=LyDoKhongThamGia.ClientID%>").val("");
        $("#<%=LyDoKhongThamGia.ClientID%>").selectpicker('refresh').trigger('change');
        $("#<%=GhiChu.ClientID%>").val("");
    };
    function removecvl() {
        $("#<%=WorkJoin.ClientID%>").val(""); $("#<%=NoiLamViec.ClientID%>").val(""); $("#<%=NganhNghe.ClientID%>").val(""); $("#<%=NuocLamViec.ClientID%>").val(""); $("#<%=HinhThuc.ClientID%>").val("");
        $("#<%=DiaChiLamViec.ClientID%>").val("");
        $("#<%=WorkJoin.ClientID%>").selectpicker('refresh'); $("#<%=NoiLamViec.ClientID%>").selectpicker('refresh'); $("#<%=NganhNghe.ClientID%>").selectpicker('refresh'); $("#<%=NuocLamViec.ClientID%>").selectpicker('refresh'); $("#<%=HinhThuc.ClientID%>").selectpicker('refresh');
        $("#<%=DiaChiLamViec.ClientID%>").selectpicker('refresh');
    };

    function exports() {
        var bcID = $("#<%=IdKhau.ClientID %>").val(); var year = $("#<%=YearPro.ClientID %>").val()
        var dtype = $("#docx:checked").val(); if (dtype == "true") { dtype = ".docx" } else { dtype = ".pdf" }
        window.open("/exports?page=work&view=ExCungLD&typeid=PhieuDTCUNG&bcID=" + bcID + "&year=" + year + "&dtype=" + dtype);
    };
</script>
