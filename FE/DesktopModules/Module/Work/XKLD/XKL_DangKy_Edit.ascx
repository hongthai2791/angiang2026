<%@ Control Language="vb" CodeFile="XKL_DangKy_Edit.ascx.vb" Inherits="Modules.XKL_DangKy.Edit" AutoEventWireup="false" Explicit="True" %>
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

        <div class="">
            <div class="box box-info box-infoHo" data-spy="scroll" data-target="#list-example" data-offset="0">
                <div class="box-body col-md-12 pb10">
                    <div class="col-md-12 text-center h4" id="thongtinphieu">
                        <b class="title-pks">PHIẾU ĐĂNG KÝ THÔNG TIN ĐI LÀM VIỆC CÓ THỜI HẠN Ở NƯỚC NGOÀI THEO HỢP ĐỒNG TẠI<span class="red">*</span>
                              
                        </b>
                              <div class="col-md-8 pdl0"> <asp:TextBox ID="QuocGia" runat="server" CssClass="TextBox validate[required]" /> </div>
  <div class="col-md-4 pdl0"><asp:DropDownList ID="drYear" runat="server" Width="100%" CssClass="selectpicker" AutoPostBack="true" /></div>
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
                                <div class="col-md-2 pdr0 b pdt5">- Họ tên <span class="red">*</span></div>
                                <div class="col-md-10 pdl0">
                                    <asp:TextBox ID="HoTen" runat="server" CssClass="TextBox HoTen validate[required] uppercase" />
                                </div>

                                <div class="col-md-2 pdr0 pdt5 b">- Ngày tháng năm sinh&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:TextBox Width="100%" ID="NgaySinh" runat="server" CssClass="TextBox NgaySinh datepicker validate[required] " />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">Giới tính&nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0">
                                    <asp:DropDownList ID="drGioiTinh" runat="server" CssClass="selectpicker drGioiTinh validate[required]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdl0 b pdt5">- CMND/CCCD&nbsp;<span class="red">*</span></div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="CCCD" runat="server" CssClass="TextBox CCCD  validate[required] uppercase" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">Ngày cấp</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="NgayCap" runat="server" CssClass="TextBox datepicker" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">Nơi cấp</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="NoiCap" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2  pdr0 pdt5 b">- Dân tộc</div>
                                <div class="col-md-10 pdl0">
                                    <asp:DropDownList ID="drDanToc" runat="server" CssClass=" selectpicker drDanToc" />
                                </div>

                                <div class="col-md-2 pdr0 pdt5 b">- Thuộc loại đối tượng</div>
                                <div class="col-md-10 pdl0">
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="BĐXN" CssClass="tbCheckList" ID="LoaiDT_XS" />

                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="Hộ GĐ thuộc diện CS" CssClass="tbCheckList" ID="LoaiDT_CS" />

                                    </div>
                                    <div class="col-md-3">
                                        <asp:CheckBox runat="server" Text="Khác" CssClass="tbCheckList" ID="LoaiDT_Khac" />

                                    </div>
                                    <div class="col-md-3">
                                        <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="LoaiDT_Khac_Txt" TextMode="MultiLine" Height="30" CssClass="TextBox"></asp:TextBox>

                                    </div>

                                </div>
                                <div class="col-md-2 pdl0 b pdt5">Trình độ VH</div>
                                <div class="col-md-10 pdl0">
                                    <asp:DropDownList ID="drTDVH" runat="server" CssClass="selectpicker" />
                                </div>

                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 b pdt5">Tay nghề</div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="TayNghe" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">Số tháng làm việc</div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="SoThangLamViec" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt0 b">Bằng nghề (nếu có)</div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="BangNghe" runat="server" CssClass="selectpicker" />

                                </div>
                                <div class="col-md-2 pdr0 pdt0 b">Nghề nghiệp hiện nay</div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="NgheNghiep" runat="server" CssClass="selectpicker" />

                                </div>
                                <div class="clear"></div>
                                <asp:UpdatePanel runat="server" ID="pnDONVI">
                                    <ContentTemplate>
                                        <div class="col-md-2  pdr0 pdt5 b">- Địa chỉ thường trú</div>
                                        <div class="col-md-2 ">
                                            <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP validate[required]" />
                                        </div>
                                        <div class="col-md-2">
                                            <asp:DropDownList ID="drPhuongXa" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa validate[required]" />
                                        </div>
                                        <div class="col-md-2  pdr0 pdt5 b">-Địa chỉ cụ thể</div>
                                        <div class="col-md-4">
                                            <asp:TextBox ID="DiaChi" ToolTip="Nhập địa chỉ cụ thể (số nhà, đường phố)" placeholder="Nhập địa chỉ cụ thể (số nhà, đường phố)" runat="server" CssClass="TextBox DiaChi_HT" />
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>

                                <div class="clear"></div>

                                <div class="col-md-2  pdr0 pdt5 b">- Điện thoại</div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="SoDienThoai" runat="server" CssClass="TextBox SoDienThoai  validate[required]" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">- Điện thoại người thân</div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="DienThoai_Khac" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2  pdr0 pdt5 b">Email</div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="Email" runat="server" CssClass="TextBox Email " />
                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="row box-info pd0" id="trinhdokynang">
                                <div class="title-ho bgt1">2. Tình trạng sức khỏe</div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 b pdt5">Chiều cao/Cân nặng</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="ChieuCao" runat="server" CssClass="TextBox" placeholder="cm" />
                                </div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="CanNang" runat="server" CssClass="TextBox" placeholder="kg" />
                                </div>
                                <div class="col-md-6 pdl0">
                                    <asp:CheckBox ID="MuMau" runat="server" Text="Mù màu" CssClass="tbCheckList" />
                                    <asp:CheckBox ID="VetXamTro" runat="server" Text="Xăm trổ" CssClass="tbCheckList" />
                                    <asp:CheckBox ID="TinhTrangHonNhan" runat="server" Text="Đã kết hôn" CssClass="tbCheckList" />
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2 pdr0 b pdt5">Thị lực/Thuận tay</div>
                                <div class="col-md-2 pdl0">
                                    <div class="col-md-4 pdr0 b pdt5">Mắt trái    </div>
                                    <div class="col-md-8 pdl0">
                                        <asp:TextBox ID="ThiLuc_1" runat="server" CssClass="TextBox" />
                                    </div>
                                </div>
                                <div class="col-md-2 pdl0">
                                    <div class="col-md-4 pdr0 b pdt5">Mắt phải    </div>
                                    <div class="col-md-8 pdl0">
                                        <asp:TextBox ID="ThiLuc_2" runat="server" CssClass="TextBox" />
                                    </div>
                                </div>
                                <div class="col-md-6 pdl0">
                                    <asp:CheckBox ID="ThuanTay_1" runat="server" Text="Tay trái" CssClass="tbCheckList" />
                                    <asp:CheckBox ID="ThuanTay_2" runat="server" Text="Tay phải" CssClass="tbCheckList" />
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2 title-ho bgt1">THỜI GIAN ĐĂNG KÝ</div>
                                <div class="col-md-10 pdl0">
                                    <asp:TextBox runat="server" ID="ThoiGianDangKy" CssClass="TextBox datepicker validate[required]"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row box-info pd0" id="thongtingiadinh">
                                <div class="title-ho bgt1">3. Tình trạng gia đình  </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdl0 b pdt5">- Họ tên cha</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="Cha_HoTen" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">- Tuổi</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="Cha_Tuoi" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">- Nghề nghiệp</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="Cha_NgheNghiep" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdl0 b pdt5">- Họ tên mẹ</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="Me_HoTen" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">- Tuổi</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="Me_Tuoi" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="col-md-2 pdl0 b pdt5">- Nghề nghiệp</div>
                                <div class="col-md-2 pdl0">
                                    <asp:TextBox ID="ME_NgheNghiep" runat="server" CssClass="TextBox" />
                                </div>
                            </div>

                            <div class="row box-info pd0" id="GHICHUtxt">
                                <div class="title-ho bgt1">4. Ghi chú của trung tâm </div>
                                <div class="clear"></div>
                                <div class="col-md-10 pdl0">
                                    <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="50" />
                                </div>
                                <div class="clear"></div>

                                <div class="col-md-2 pdl0 b pdt5">- Thời gian đăng ký</div>
                                <div class="col-md-4 pdl0">
                                    <asp:TextBox ID="SignDate" runat="server" CssClass="TextBox datepicker  validate[required]" />
                                </div>
                            </div>
                        </div>
                        <div class="clrUp"></div>
                    </div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>

                <div class="none">
                    <asp:HiddenField ID="ItemID" Visible="false" runat="server" />
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
                <div class="">
                    <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                </div>
            </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
    </Triggers>
</asp:UpdatePanel>
<asp:Literal runat="server" ID="ltMessage"></asp:Literal>