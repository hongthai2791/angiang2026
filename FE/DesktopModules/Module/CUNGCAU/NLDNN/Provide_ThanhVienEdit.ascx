<%@ Control Language="vb" CodeFile="Provide_ThanhVienEdit.ascx.vb" Inherits="Modules.ThanhVien.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .datepicker {
        width: 100% !important
    }
</style>
<asp:UpdatePanel runat="server" ID="pnThongTinHo">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-4">
                    <h3 class="box-title">Thông tin đối tượng</h3>
                </div>

                <div class="clear"></div>
                <div class="col-md-12">
                    <asp:Literal ID="txtYear" runat="server"></asp:Literal>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body1 box-infoHo">

                    <div class="col-md-12 col-xs-12 pdl0 pdb0 pdt0 ">
                        <div class="row box-info pd0 boxg1" style="min-height: 255px">
                            <div class="title-ho bgt1">Thông tin chung</div>
                            <div class="col-md-6 pdl0 none">
                                <div class="col-md-12 pdl0">Mã đối tượng</div>
                                <div class="col-md-12 pdl0">
                                    <asp:TextBox ID="MaDoiTuong" runat="server" Enabled="false" CssClass="TextBox validate[required] " />
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="col-md-6 pdr0 none ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">Số thứ tự</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="IsOrder"  runat="server" CssClass="TextBox uppercase" />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-6 pdr0">
                                <div class="col-md-12 pdl0">1.Họ tên</div>
                                <div class="col-md-12 pdl0">
                                    <asp:TextBox ID="HoTen" runat="server" onkeypress="return nextfocus(1, this, event,'QuanHe',0);" CssClass="TextBox HoTen validate[required] uppercase" />
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="col-md-6 pdr0">
                                <div class="col-md-12 pdl0">2.Giới tính</div>
                                <div class="col-md-12 pdl0">
                                    <asp:DropDownList ID="drGioiTinh"  runat="server" CssClass="selectpicker drGioiTinh" />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-6 pdr0 ">
                                <div class="col-md-12 pdl0">3.Ngày sinh</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <telerik:RadMaskedTextBox ID="NgaySinh" Mask="##/##/####" Width="100%" runat="server" CssClass="TextBox NgaySinh validate[required]"></telerik:RadMaskedTextBox>
                                    <%--<asp:TextBox  Width="100%"  ID="NgaySinh" runat="server" TabIndex="8" CssClass="TextBox NgaySinh validate[required] datepicker" />--%>
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="col-md-6 pdr0 ">
                                <div class="col-md-12 pdl0">4.Quốc tịch</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="_QuocTich"  runat="server" CssClass="TextBox TrinhDoGD uppercase " />

                                    <span class="required"></span>
                                </div>
                            </div>

                            <div class="clear"></div>
                            <div class="col-md-6 pdr0">
                                <div class="col-md-12 pdl0">5.CCCD/Hộ chiếu</div>
                                <div class="col-md-12 pdl0">
                                    <asp:TextBox ID="CCCD" runat="server" CssClass="TextBox CCCD validate[required] uppercase " />
                                    <span class="required"></span>

                                </div>
                            </div>
                            <div class="col-md-6 pdr0 ">
                                <div class="col-md-12 pdl0">Ngày cấp</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:TextBox Width="100%" ID="_NgayCapHC" runat="server"  CssClass="TextBox NgaySinh datepicker " />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-6 pdr0 ">
                                <div class="col-md-12 pdl0">6.Trình độ</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="TrinhDoGD"  runat="server" CssClass="selectpicker TrinhDoGD " />
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="col-md-6 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">7.Chuyên môn đào tạo</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="TrinhDoCM"  runat="server" CssClass="selectpicker TrinhDoCM " />
                                </div>
                            </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                    <div class="col-md-12 col-xs-12 pdl0 pdb0 pdt0">
                        <div class="row box-info pd0  " id="box-ho-two" style="min-height: 458px;">
                            <div class="title-ho bgt3">Thông tin việc làm</div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">1.Số GPLĐ/GXN</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="_SoGP"  runat="server" CssClass="TextBox SoGP uppercase" />
                                </div>
                            </div>
                            <div class="col-md-4 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">Ngày cấp</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:TextBox Width="100%" HideOnBlur="true" ID="_NgayCP" runat="server" CssClass="TextBox NgayCP datepicker" />
                                </div>
                            </div>

                            <div class="col-md-4 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">Tình trạng cấp GPLĐ/GXN</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="TinhTrangCP"  runat="server" CssClass="selectpicker TinhTrangCP">
                                        <asp:ListItem Text="--- Chọn ---" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="Cấp mới" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Cấp lại" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Gia hạn" Value="3"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">2.Nơi làm việc</div>
                                <div class="col-md-2 pdl0 pdb0 pdt5">- Tên doanh nghiệp, tổ chức</div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="TenDoanhNghiep"  runat="server" CssClass="TextBox uppercase DiaChiLamViec  validate[required]" />
                                    <span class="required"></span>

                                </div>
                                <div class="col-md-1 pdl0 pdb0 pdt5">- Mã số</div>
                                <div class="col-md-5 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="MaDoanhNghiep" type="number" runat="server" CssClass="TextBox validate[required] uppercase" />
                                    <span class="required"></span>

                                </div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">- Địa chỉ</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
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
                                        <asp:DropDownList ID="drThonTo" runat="server" AutoPostBack="true" CssClass="selectpicker drThonTo " />
                                    </div>
                                </div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">- Loại hình doanh nghiệp, tổ chức làm việc</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="LoaiHinhKT"  runat="server" CssClass="selectpicker LoaiHinhKT" />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-4 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">3.Vị trí công việc</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="_ViTriCV"  runat="server" CssClass="selectpicker ViTriCV" />

                                </div>
                            </div>
                            <div class="col-md-4 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">4.Nghề công việc</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="_NgheCongViec"  runat="server" CssClass="selectpicker NgheCongViec" />

                                </div>
                            </div>
                            
                            <div class="col-md-46 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">5.Chức danh công việc</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="ChucDanhCV"  runat="server" CssClass="TextBox ChucDanhCV" />
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-6 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">6.Hình thức làm việc</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <asp:DropDownList ID="HinhThucLamViec"  runat="server" CssClass="selectpicker NgheCongViec" />
                                </div>
                            </div>
                            <div class="col-md-6 pdr0 ">
                                <div class="col-md-12 pdl0 pdb0 pdt0">7.Thời hạn làm việc (từ ngày.. đến..)</div>
                                <div class="col-md-12 pdl0 pdb0 pdt0">
                                    <div class="col-md-6 pdl0 pdb0 pdt0">

                                        <span class="required"></span>
                                        <asp:TextBox Width="100%" HideOnBlur="true" ID="_LVTuNgay" runat="server" CssClass="TextBox LVTuNgay validate[required] datepicker" />
                                    </div>
                                    <div class="col-md-6 pdl0 pdb0 pdt0">
                                        <span class="required"></span>
                                        <asp:TextBox Width="100%" HideOnBlur="true" ID="_LVDenNgay" runat="server" CssClass="TextBox LVDenNgay validate[required] datepicker" />
                                    </div>
                                </div>
                            </div>

                            <div class="clear"></div>
                        </div>
                </div>
                <div class="clrUp"></div>
                <asp:Literal ID="litUpdate" runat="server" />
            </div>
        </div>
        <div class="none">
            <asp:HiddenField ID="IdKhau" runat="server" />
            <asp:HiddenField ID="YearPro" runat="server" />
        </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="(F7) Đóng lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdReset" runat="server" Text="Làm mới" CssClass="cmsbut Refresh" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdCancel" runat="server" Text="Hủy" CssClass="cmsbut cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="(F8) Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdAddTab" runat="server" Text="(F9) Thêm đối tượng" CssClass="cmsbut cmsbtnew" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdDelete" runat="server" Text="(F4) Xóa" CssClass="cmsbut cmsbtdel" />
                <asp:Button ID="cmdExport" runat="server" Text="Tải phiếu điều tra" OnClientClick="popdoc('exports'); return false;" CssClass="cmsbut cmsbtDownload cbclick" />

                <div class="clear"></div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />
    </Triggers>
</asp:UpdatePanel>
<script type="text/javascript">
    document.onkeydown = function (e) { if (e.keyCode == 118) { $(".cmsback").click(); } else if (e.keyCode === 119) { $(".cmsbtupdate").click(); } else if (e.keyCode === 120) { $(".cmsbtnew").click(); } else if (e.keyCode === 121) { $(".cmsbtrun").click(); } else if (e.keyCode === 115) { $(".cmsbtdel").click(); } };
    function setFullScreen() { if ($(document.body).hasClass("fullScreen")) { $(document.body).removeClass("fullScreen"); } else { $(document.body).addClass("fullScreen"); } }
    $('body').on('keydown', '.drTinhTP > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drTinhTP > button").attr("title"); if (vl === "- - - Chọn - - -") { $('.drTinhTP').selectpicker('toggle'); return false; } else { $(".drQuanHuyen").focus(); } } });
    $('body').on('keydown', '.drQuanHuyen > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drQuanHuyen > button").attr("title"); if (vl === "--- Quận/huyện ---") { $('.drQuanHuyen').selectpicker('toggle'); return false; } else { $(".drPhuongXa").focus(); } } });
    $('body').on('keydown', '.drPhuongXa > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drPhuongXa > button").attr("title"); if (vl === "--- Phường/xã ---") { $('.drPhuongXa').selectpicker('toggle'); return false; } else { $(".drThonTo").focus(); } } });
    $('body').on('keydown', '.drThonTo > button.dropdown-toggle', function (e) { if (e.keyCode === 13) { var vl = $(".drThonTo > button").attr("title"); if (vl === "--- Thôn/tổ ---") { $('.drThonTo').selectpicker('toggle'); return false; } else { $(".MaHo").focus(); } } });

    $('body').on('keydown', '.keyMenuLeft', function (e) { if (e.keyCode === 13) { $(".timKiemMenuLeft").click(); } });
    function nextchange(ct, th, nt, id) { if (id === "1") { removethatnghiep(); removeKtg(); $("." + nt).focus(); } else if (id === "5") { removethatnghiep(); removecvl(); $("." + nt).focus(); } else if (id === "4") { removecvl(); removeKtg(); $("." + nt).focus(); } else if (id === "2") { $("." + nt + " input").focus(); } else if (id === "3") { removethatnghiep(); removeKtg(); if ($(th).val() != "") { $("." + nt).focus(); } else { $("." + ct).focus(); } } else { if ($(th).val() != "") { $("." + nt).focus(); } } };
    function nextfocus(ac, th, e, nt, et) { if (e.keyCode === 13) { if (et === 1) { $("." + nt).click(); } else { if (ac === 1) { if ($(th).val() != "") { $("." + nt).focus(); } else { $("." + nt).focus(); } } else { $("." + nt).focus(); } } return false; } else { return true; } };
    function pageLoad() { var minStartDate = new Date(2015, 09, 26); var maxStartDate = new Date(2019, 09, 26); $('#<%=NgaySinh.ClientID%>').mask('__/__/____', { placeholder: "#" }); $('.datepicker').datetimepicker({ timepicker: false, minDate: minStartDate, maxDate: maxStartDate, format: 'd/m/Y', mask: false, closeOnDateSelect: true }); };

    function exports() {
        var bcID = $("#<%=IdKhau.ClientID %>").val(); var year = $("#<%=YearPro.ClientID %>").val()
        var dtype = $("#docx:checked").val(); if (dtype == "true") { dtype = ".docx" } else { dtype = ".pdf" }
        window.open("/exports?page=work&view=ExNLDNN&typeid=PhieuDTNLDNN&bcID=" + bcID + "&year=" + year + "&dtype=" + dtype);
    };
</script>
