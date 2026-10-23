<%@ Control Language="vb" CodeFile="Provide_HoGDEdit.ascx.vb" Inherits="Modules.HoGD.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .disabledbutton {
        pointer-events: none;
        opacity: 0.4;
    }.cmsbtdelHo {
    background-image: url(/portals/_default/skins/vbn/images/del.png?w);
}
</style>
<asp:UpdatePanel runat="server" ID="pnThongTinHo">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-3">
                    <h3 class="box-title">Thông tin hộ gia đình</h3>
                </div>
                <div class="col-md-7">
                    <div class="alert alert-warning mgbt0">
                        <img src="/image/w1.png?w=18" alt="Note" />
                        &nbsp; Nếu có sự thay đổi, bấm lưu lại trước khi chuyển sang tab khác
                    </div>
                </div>
                <div class="col-md-2">
                    <asp:Literal ID="txtYear" runat="server"></asp:Literal>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body1 box-infoHo">
                    <telerik:RadTabStrip OnTabClick="tabClick" runat="server" ID="rdHo" MultiPageID="radMultiHo">
                    </telerik:RadTabStrip>
                    <telerik:RadMultiPage runat="server" ID="radMultiHo" SelectedIndex="0" CssClass="innerMultiPage">
                        <telerik:RadPageView runat="server" ID="inFoHo">
                            <div class="row pdt10 boxHoGD">
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
                                <div class="col-md-3">
                                    <asp:DropDownList ID="drThonTo" runat="server" AutoPostBack="true" CssClass="selectpicker drThonTo validate[required]" />
                                    <span class="required"></span>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 pdl0">
                                    <div class="col-md-12 pdl0">Mã hộ</div>
                                    <div class="col-md-12 pdl0">
                                        <asp:TextBox ID="MaHo" runat="server"CssClass="TextBox MaHo validate[required]" />
                                        <span class="required"></span>
                                    </div>
                                </div>
                                <div class="col-md-3 pdr0">
                                    <div class="col-md-12 pdl0">Họ tên</div>
                                    <div class="col-md-12 pdl0">
                                        <asp:TextBox ID="TenChuHo" runat="server"  CssClass="TextBox TenChuHo uppercase validate[required]" />
                                        <span class="required"></span>
                                    </div>
                                </div>
                                <div class="col-md-3 pdr0">
                                    <div class="col-md-12 pdl0">Loại hộ</div>
                                    <div class="col-md-12 pdl0">
                                        <asp:DropDownList ID="LoaiHo" runat="server"  CssClass="selectpicker LoaiHo validate[required]" />
                                        <span class="required"></span>
                                    </div>
                                </div>
                                <div class="col-md-3 pdr0">
                                    <div class="col-md-12 pdl0">Số thành viên</div>
                                    <div class="col-md-12 pdl0">
                                        <asp:TextBox ID="SoNhanKhau" Enabled="false" runat="server" CssClass="TextBox SoNhanKhau" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 pdr0 pdl0">
                                    <div class="col-md-12 pdl0 pdb0 pdt0">Số sổ</div>
                                    <div class="col-md-12 pdl0 pdb0 pdt0">
                                        <asp:DropDownList ID="drSo" runat="server" onchange="nextchange('', this,'DiaChi','drSo');" CssClass="selectpicker drSo" />
                                    </div>
                                </div>
                                <div class="col-md-9 pdr0 ">
                                    <div class="col-md-12 pdl0 pdb0 pdt0">Số nhà/Đường phố</div>
                                    <div class="col-md-12 pdl0 pdb0 pdt0">
                                        <asp:TextBox ID="DiaChi" runat="server"  CssClass="TextBox uppercase DiaChi" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                                    <ItemStyle BackColor="#fbf2ec" />
                                    <AlternatingItemStyle BackColor="#ffffff" />
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                            <ItemTemplate>
                                                <asp:Literal ID="STT" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Họ tên thành viên" HeaderStyle-CssClass="hdTitle">
                                            <ItemTemplate>
                                                <asp:Literal ID="HoTen" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Left" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Quan hệ" HeaderStyle-CssClass="hdTitle">
                                            <ItemTemplate>
                                                <asp:Literal ID="QuanHe" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="12%" HorizontalAlign="Left" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Giới tính" HeaderStyle-CssClass="hdTitle">
                                            <ItemTemplate>
                                                <asp:Literal ID="GioiTinh" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="12%" HorizontalAlign="Left" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Dân tộc" HeaderStyle-CssClass="hdTitle">
                                            <ItemTemplate>
                                                <asp:Literal ID="DanToc" runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Ngày sinh" HeaderStyle-CssClass="hdTitle">
                                            <ItemTemplate>
                                                <asp:Literal ID="NgaySinh" runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Loại biến động" HeaderStyle-CssClass="hdTitle">
                                            <ItemTemplate>
                                                <asp:Literal ID="LoaiBienDong" runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Khai tử" HeaderStyle-CssClass="hdTitle">
                                            <ItemTemplate>
                                                <asp:Literal ID="CatChet" runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        </asp:TemplateColumn>
                                    </Columns>
                                </asp:DataGrid>
                            </div>
                        </telerik:RadPageView>
                        <telerik:RadPageView runat="server" Visible="false" ID="infoTV">
                            <div class="col-md-4 col-xs-12 pdl0 pdb0 pdt0 ">
                                <div class="row box-info pd0 boxg1" style="min-height: 255px">
                                    <div class="title-ho bgt1">Thông tin chung</div>
                                    <div class="col-md-6 pdl0 none">
                                        <div class="col-md-12 pdl0">Mã thành viên</div>
                                        <div class="col-md-12 pdl0">
                                            <asp:TextBox ID="MaDoiTuong" TabIndex="1" runat="server" Enabled="false" CssClass="TextBox validate[required] " />
                                            <span class="required"></span>
                                        </div>
                                    </div>
                                    <div class="col-md-6 pdr0 none ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">Số thứ tự</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:TextBox ID="IsOrder" TabIndex="2" runat="server" CssClass="TextBox" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-6 pdr0">
                                        <div class="col-md-12 pdl0">1.Họ tên</div>
                                        <div class="col-md-12 pdl0">
                                            <asp:TextBox ID="HoTen" TabIndex="3" runat="server"  CssClass="TextBox HoTen validate[required] uppercase" />
                                            <span class="required"></span>
                                        </div>
                                    </div>
                                    <div class="col-md-6 pdr0">
                                        <div class="col-md-12 pdl0">1.1 Quan hệ (1xx)</div>
                                        <div class="col-md-12 pdl0">
                                            <asp:DropDownList ID="QuanHe" TabIndex="4" runat="server"  CssClass="selectpicker QuanHe validate[required] " />
                                            <span class="required"></span>
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-6 pdr0 ">
                                        <div class="col-md-12 pdl0">2.Ngày sinh</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <telerik:RadMaskedTextBox Mask="##/##/####" Width="100%" HideOnBlur="true" ID="NgaySinh" runat="server" TabIndex="5" CssClass="TextBox NgaySinh validate[required] " />
                                            <span class="required"></span>
                                        </div>
                                    </div>
                                    <div class="col-md-6 pdr0">
                                        <div class="col-md-12 pdl0">3.Giới tính</div>
                                        <div class="col-md-12 pdl0">
                                            <asp:DropDownList ID="drGioiTinh" TabIndex="6" runat="server"  CssClass="selectpicker drGioiTinh" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>

                                    <div class="col-md-12 pdr0">
                                        <div class="col-md-12 pdl0">4.CCCD/Hộ chiếu</div>
                                        <div class="col-md-12 pdl0">
                                            <asp:TextBox ID="CCCD" TabIndex="7" runat="server"  CssClass="TextBox CCCD uppercase" />
                                        </div>
                                    </div>
                                    <asp:UpdatePanel runat="server" ID="pnDONVI">
                                        <ContentTemplate>
                                            <div class="col-md-12 pdr0 ">
                                                <div class="col-md-4 pdr0">6.Nơi ở hiện tại</div>
                                                <div class="col-md-8 pdr0">
                                                    <asp:CheckBox runat="server" TabIndex="8" ID="chkSuDungLaiThuongTru" OnCheckedChanged="chkSuDungLaiThuongTru_CheckedChanged" AutoPostBack="true" Text="Sử dụng lại địa chỉ chủ hộ" />
                                                </div>
                                                <div class="col-md-6 ">
                                                    <asp:DropDownList ID="drTinhTP_HT" TabIndex="9" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP " />
                                                </div>
                                                <div class="col-md-6 ">
                                                    <asp:DropDownList ID="drQuanHuyen_HT" TabIndex="10" runat="server" AutoPostBack="true" CssClass="selectpicker drQuanHuyen " />
                                                </div>
                                                <div class="col-md-6">
                                                    <asp:DropDownList ID="drPhuongXa_HT" TabIndex="11" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa " />
                                                </div>
                                                <div class="col-md-6">
                                                    <asp:DropDownList ID="drThonTo_HT" TabIndex="12" runat="server" CssClass="selectpicker drThonTo" />
                                                </div>
                                    <div class="clear"></div>
                                                <div class="col-md-12">
                                                    <asp:TextBox ID="DiaChi_HT" ToolTip="Nhập địa chỉ cụ thể (số nhà, đường phố)" placeholder="Nhập địa chỉ cụ thể (số nhà, đường phố)" TabIndex="12" runat="server" CssClass="TextBox DiaChi_HT" />
                                                </div>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0">7.Đối tượng ưu tiên</div>
                                        <div class="col-md-6 pdl0">
                                            <asp:CheckBox runat="server" TabIndex="13" Text="Người khuyết tật" ID="DTUT_NKT" />
                                        </div>
                                        <div class="col-md-6 pdl0">
                                            <asp:CheckBox runat="server" TabIndex="14" Text="Hộ nghèo, CN" ID="DTUT_HN" />

                                        </div>
                                        <div class="clear"></div>
                                        <div class="col-md-6 pdl0">
                                            <asp:CheckBox runat="server" TabIndex="15" CssClass="chkDTTS" onchange="loadDanTocTS()" Text="Dân tộc thiểu số" ID="DTUT_DTTS" />

                                        </div>
                                        <div class="col-md-6 cbDTTS pdr0">
                                            <div class="col-md-12 pdl0">
                                                <asp:DropDownList ID="drDanToc" TabIndex="16" runat="server" onchange="nextchange('', this,'CCCD','drDanToc');" CssClass="cbDTTS selectpicker drDanToc" />
                                                <span class="required"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0">8.Trình độ giáo dục (4xx)</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="TrinhDoGD" TabIndex="17" runat="server" AutoPostBack="true" CssClass="selectpicker TrinhDoGD validate[required] " />
                                            <span class="required"></span>
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                </div>
                                <div class="row box-info pd0" id="box-ho-one">
                                    <div class="title-ho bgt2">9.Trình độ chuyên môn kỹ thuật cao nhất</div>
                                    <div class="row pdl5 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">9.1.Trình độ chuyên môn</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="TrinhDoCM" TabIndex="18" runat="server" onchange="nextchange('', this,'LinhVucDT','TrinhDoCM');checkLVDT();loadDanTocTS()" CssClass="selectpicker TrinhDoCM " />
                                        </div>
                                    </div>
                                    <div class="row pdl5 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">9.2.Chuyên ngành đào tạo</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <%--<asp:TextBox ID="ChuyenNganhDaoTao" runat="server" CssClass="TextBox  " />--%>
                                            <asp:DropDownList ID="LinhVucDT" TabIndex="19" runat="server" onchange="nextchange('', this,'WorkJoin','LinhVucDT');" CssClass="selectpicker LinhVucDT " />
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-4 col-xs-12 pdl0 pdb0 pdt0">
                                <div class="row box-info pd0  boxgtthdkt" id="box-ho-ten">
                                    <div class="title-ho bgt3" style="background: #fccff8;">10.Tình trạng tham gia hoạt động kinh tế</div>
                                    <div class="pdt10"></div>
                                    <div class="col-md-6">
                                        <asp:RadioButton runat="server" GroupName="TTTGHDKT" TabIndex="20" onchange="loadTTTGHDKT();" Checked="false" CssClass="rdCVL" ID="rdCVL" Text="Người có việc làm"  />
                                    </div>
                                    <div class="col-md-6">
                                        <asp:RadioButton runat="server" GroupName="TTTGHDKT" TabIndex="21" onchange="loadTTTGHDKT();" Checked="false" CssClass="rdNTN"  ID="rdNTN" Text="Người thất nghiệp"  />
                                    </div>  <div class="clear"></div>
                                    <div class="col-md-12">
                                        <asp:RadioButton runat="server" GroupName="TTTGHDKT" TabIndex="22" onchange="loadTTTGHDKT();" Checked="false" CssClass="rdKTG"  ID="rdKTG" Text="Không tham gia hoạt động kinh tế"  />
                                    </div>
                                </div>
                                <div class="row box-info pd0  boxg3" id="box-ho-two" style="min-height: 458px;">
                                    <div class="title-ho bgt3">11.Đối với người có việc làm</div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.1.Vị thế việc làm (8xx)</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="HinhThuc" TabIndex="23" onchange="nextchange('', this,'LoaiHinhKT','1');" runat="server" CssClass="selectpicker HinhThuc" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.2.Công việc tham gia (6xx)</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="WorkJoin" TabIndex="24" onchange="nextchange('LoaiThatNghiep', this,'NoiLamViec','3');" runat="server" CssClass="selectpicker WorkJoin" />
                                        </div>
                                    </div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.3.Tỉnh thành nơi làm việc</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="NoiLamViec" TabIndex="25" onchange="nextchange('', this,'NganhNghe','1');" runat="server" CssClass="selectpicker NoiLamViec" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.3a.Địa chỉ làm việc</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:TextBox ID="DiaChiLamViec" TabIndex="27"  runat="server" CssClass="TextBox uppercase DiaChiLamViec" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.3b.Ngành nghề kinh doanh</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="NganhNghe" TabIndex="28" runat="server" onchange="nextchange('', this,'NuocLamViec','1');" CssClass="selectpicker NganhNghe" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.3c.Loại hình kinh tế (9xx)</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="LoaiHinhKT" TabIndex="29" onchange="nextchange('', this,'LoaiChuyen','1');" runat="server" CssClass="selectpicker LoaiHinhKT" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.3d.Nước làm việc</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="NuocLamViec" TabIndex="30" onchange="nextchange('', this,'DiaChiLamViec','1');" runat="server" CssClass="selectpicker NuocLamViec" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4 col-xs-12 pd0" id="box-ho-three">
                                <div class="row box-info pd0 boxg4">
                                    <div class="title-ho bgt4">Với người thất nghiệp</div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdl5 pdb0 pdt0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">10.Loại thất nghiệp (10xx)</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="LoaiThatNghiep" TabIndex="30" onchange="nextchange('', this,'ThoiGianThatNghiep','4');" runat="server" CssClass="LoaiThatNghiep selectpicker" />
                                        </div>
                                    </div>
                                    <div class="col-md-12 pdr0 hidden">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">11.Thời gian thất nghiệp</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:TextBox ID="ThoiGianThatNghiep" TabIndex="31" o runat="server" CssClass="TextBox ThoiGianThatNghiep" />
                                        </div>
                                    </div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">12.1 Thời gian thất nghiệp</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="drThoiGianThatNghiep" TabIndex="32" onchange="nextchange('', this,'LyDoKhongThamGia','4');" runat="server" CssClass="ThoiGianThatNghiep selectpicker" />

                                            <%--  <div class="col-md-6 pdl0">
                                                <asp:CheckBox runat="server" Text="Dưới 3 tháng" />
                                            </div>
                                            <div class="col-md-6 pdl0">
                                                <asp:CheckBox runat="server" Text="Từ 3 tháng đến 1 năm" />
                                            </div>
                                            <div class="col-md-12 pdl0">
                                                <asp:CheckBox runat="server" Text="Trên 1 năm" />
                                            </div>--%>
                                          
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                </div>
                                <div class="row box-info pd0 boxg5">
                                    <div class="title-ho bgt5">Đối với người không tham gia hoạt động kinh tế</div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">12.Lý do không tham gia (12xx)</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:DropDownList ID="LyDoKhongThamGia" TabIndex="33" onchange="nextchange('', this,'GhiChu','5');" runat="server" CssClass="selectpicker LyDoKhongThamGia" />
                                        </div>
                                    </div>
                                    <div class="col-md-12 pdr0 ">
                                        <div class="col-md-12 pdl0 pdb0 pdt0">13.Ghi chú</div>
                                        <div class="col-md-12 pdl0 pdb0 pdt0">
                                            <asp:TextBox ID="GhiChu" TabIndex="34" runat="server"  CssClass="TextBox GhiChu" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                </div>
                                <div class="row box-info pd0 boxg6">
                                    <div class="title-ho bgt6">Biến động thông tin</div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0 pdt10">
                                        <div class="col-md-12 pdl0 pdb0">
                                            <asp:DropDownList ID="LoaiChuyen" onchange="nextchange('', this,'CatChet','2');" TabIndex="35" runat="server" CssClass="selectpicker LoaiChuyen" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdr0" style="padding-bottom: 12px;">
                                        <div class="col-md-12 pdl0 pdb0 pdt5"></div>
                                        <asp:CheckBox ID="CatChet" Text="Khai tử?" TabIndex="36" runat="server" CssClass="CheckBox CatChet"  />
                                    </div>
                                </div>
                            </div>
                        </telerik:RadPageView>
                    </telerik:RadMultiPage>
                    <div class="clrUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
            </div>
            <div class="none">
                <asp:HiddenField ID="IdHo" Visible="false" runat="server" />
                <asp:HiddenField ID="IdKhau" Visible="false" runat="server" />
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
                <asp:Button ID="cmdBack" runat="server" Text="(F7) Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="(F8) Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdAddTab" runat="server" Text="(F9) Thêm thành viên" CssClass="cmsbut cmsbtnew" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdAddHo" runat="server" Text="(F10) Thêm hộ mới" CssClass="cmsbut cmsbtrun" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdDelHo" Visible="false" runat="server" Text="(F3) Xóa hộ" CssClass="cmsbut cmsbtdelHo" ></asp:Button>
                <asp:Button ID="cmdDelete" runat="server" Text="(F4) Xóa khẩu" CssClass="cmsbut cmsbtdel" />
                <div class="clear"></div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdAddTab" />
        <asp:AsyncPostBackTrigger ControlID="WorkJoin" />
        <asp:AsyncPostBackTrigger ControlID="NoiLamViec" />
        <asp:AsyncPostBackTrigger ControlID="NuocLamViec" />
        <asp:AsyncPostBackTrigger ControlID="HinhThuc" />
        <asp:AsyncPostBackTrigger ControlID="LoaiHinhKT" />
        <asp:AsyncPostBackTrigger ControlID="LoaiThatNghiep" />
        <asp:AsyncPostBackTrigger ControlID="LyDoKhongThamGia" />
        <asp:AsyncPostBackTrigger ControlID="TrinhDoGD" />
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />
    </Triggers>
</asp:UpdatePanel>
<script type="text/javascript">
    $(document).ready(function () {
        loadDanTocTS(); loadTTTGHDKT();
    });
    function loadDanTocTS() {
        debugger;
        if ($('.chkDTTS').find('input:checked').length > 0) {
            $('.cbDTTS').fadeIn();
        }
        else {
            $('.cbDTTS').fadeOut();
        }
        if ($('#<%= DTUT_DTTS.ClientID %>').is(':checked')) {
            $('.cbDTTS').fadeIn();
        }
        else {
            $('.cbDTTS').fadeOut();
        }
        if ($('#<%= TrinhDoCM.ClientID %>').val() == 16) {
            $('.LinhVucDT').addClass("disabledbutton");
        }
        else { $('.LinhVucDT').removeClass("disabledbutton"); }

        if ($('#<%= TrinhDoGD.ClientID %>').val() == 18 || $('#<%= TrinhDoGD.ClientID %>').val() == 19) {
            $("#<%=TrinhDoCM.ClientID%> option[value*='21']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='22']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='23']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='24']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='25']").prop('disabled', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='26']").prop('disabled', true);
        }
        else {
            $("#<%=TrinhDoCM.ClientID%> option[value*='21']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='22']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='23']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='24']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='25']").prop('enable', true);
            $("#<%=TrinhDoCM.ClientID%> option[value*='26']").prop('enable', true);
        }

      
    };

    function loadTTTGHDKT() {
        if ($('.rdNTN').find('input:checked').length > 0) {
            $('.boxg4').removeClass("disabledbutton");
            $('.boxg5').addClass("disabledbutton");
            $('.boxg3').addClass("disabledbutton");

        }
        if ($('.rdCVL').find('input:checked').length > 0) {
            $('.boxg4').addClass("disabledbutton");
            $('.boxg5').addClass("disabledbutton");
            $('.boxg3').removeClass("disabledbutton");
        }
        if ($('.rdKTG').find('input:checked').length > 0) {
            $('.boxg4').addClass("disabledbutton");
            $('.boxg5').removeClass("disabledbutton");
            $('.boxg3').addClass("disabledbutton");
        }
       
    };


    document.onkeydown = function (e) { if (e.keyCode == 118) { $(".cmsback").click(); } else if (e.keyCode === 119) { $(".cmsbtupdate").click(); } else if (e.keyCode === 120) { $(".cmsbtnew").click(); } else if (e.keyCode === 121) { $(".cmsbtrun").click(); } else if (e.keyCode === 115) { $(".cmsbtdel").click(); } else if (e.keyCode === 114) { $(".cmsbtdelHo").click(); }};
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
    function pageLoad() { var minStartDate = new Date(2015, 09, 26); var maxStartDate = new Date(2019, 09, 26); $('#<%=NgaySinh.ClientID%>').mask('__/__/____', { placeholder: "#" }); $('.datepicker').datetimepicker({ timepicker: false, minDate: minStartDate, maxDate: maxStartDate, format: 'd/m/Y', mask: false, closeOnDateSelect: true }); };
    function removethatnghiep() { $("#<%=LoaiThatNghiep.ClientID%>").val(""); $("#<%=ThoiGianThatNghiep.ClientID%>").val(""); $("#<%=LoaiThatNghiep.ClientID%>").selectpicker('refresh'); $("#<%=ThoiGianThatNghiep.ClientID%>").selectpicker('refresh'); };
    function removeKtg() { $("#<%=LyDoKhongThamGia.ClientID%>").val(""); $("#<%=LyDoKhongThamGia.ClientID%>").selectpicker('refresh'); $("#<%=GhiChu.ClientID%>").val(""); };
    function removecvl() { $("#<%=WorkJoin.ClientID%>").val(""); $("#<%=NoiLamViec.ClientID%>").val(""); $("#<%=NganhNghe.ClientID%>").val(""); $("#<%=NuocLamViec.ClientID%>").val(""); $("#<%=HinhThuc.ClientID%>").val(""); $("#<%=LoaiHinhKT.ClientID%>").val(""); $("#<%=DiaChiLamViec.ClientID%>").val(""); $("#<%=WorkJoin.ClientID%>").selectpicker('refresh'); $("#<%=NoiLamViec.ClientID%>").selectpicker('refresh'); $("#<%=NganhNghe.ClientID%>").selectpicker('refresh'); $("#<%=NuocLamViec.ClientID%>").selectpicker('refresh'); $("#<%=HinhThuc.ClientID%>").selectpicker('refresh'); $("#<%=LoaiHinhKT.ClientID%>").selectpicker('refresh'); $("#<%=DiaChiLamViec.ClientID%>").selectpicker('refresh'); };
    function checkLVDT() { if ($("#<%=TrinhDoCM.ClientID%> option:selected").val() == 16) { $(".WorkJoin").focus(); } else { $(".LinhVucDT").focus(); } };
</script>
