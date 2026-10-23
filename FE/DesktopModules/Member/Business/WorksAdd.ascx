<%@ Control Language="vb" AutoEventWireup="true" CodeFile="WorksAdd.ascx.vb" Inherits="Modules.EPORTAL.View" %>

<style>
    .ms {
        position: absolute;
        top: 50%;
        right: 10px;
        transform: translateY(-50%);
    }

    .tbCheckList {
        width: 100%;
    }
    
.txt-red {
    font-weight: 600;
}
</style>
<div class="box box-info ">
    <asp:Label runat="server" ID="lblDownLoad" Style="display: none;"></asp:Label>
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin tuyển dụng việc làm</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row none">
                <div class="col-md-2">Đăng từ ngày <span class="txt-red">*</span></div>
                <div class="col-md-2 rccalpopup">
                    <asp:TextBox ID="StartDate" autocomplete="off" placeholder="dd/mm/yyyy" CssClass=" datepicker TuNgay TextBox validate[required]" runat="server" />
                </div>
                <div class="col-md-2 txt-right">Đến hết ngày <span class="txt-red">*</span></div>
                <div class="col-md-2 rccalpopup">
                    <asp:TextBox ID="EndDate" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker DenNgay TextBox validate[required]" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;1. Thông tin tuyển dụng
            </div>
            <div class="row pdt10">
                <div class="col-md-2 lb">Tên công việc <span class="txt-red">*</span></div>
                <div class="col-md-6">
                    <asp:TextBox ID="Title" runat="server" MaxLength="250" CssClass="TextBox validate[required] " />
                </div>
                <div class="col-md-2 lb">Số lượng <span class="txt-red">*</span></div>
                <div class="col-md-2 ">
                    <asp:TextBox ID="Quantity" runat="server" Text="1" CssClass="TextBox center validate[required, custom[number]] " />
                </div>
                <div class="col-md-2  lb none">Hạn nộp hồ sơ <span class="txt-red">*</span></div>
                <div class="col-md-2 rccalpopup none">
                    <asp:TextBox ID="ExpiredDate" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker NopHS TextBox validate[required]" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row none">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin tuyển dụng
                </div>
            </div>
            <div class="row">
                <div class="col-md-6  none">
                    <div class="col-md-4 pdl0">Mức lương <span class="txt-red">*</span></div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="Salary_ID" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdl0">Kinh nghiệm làm việc <span class="txt-red">*</span></div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="Experience_ID" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12 pdl0 none">Hình thức nộp</div>
                    <div class="col-md-12 pdl0">
                        <asp:TextBox ID="SubmissionSend" Visible="false" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="127px" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdl0">Trình độ chuyên môn <span class="txt-red">*</span></div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="Level_ID" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4">Vị trí tuyển dụng <span class="txt-red">*</span></div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="JobPlace_ID" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="col-md-6 pdr0">

                    <div class="col-md-2 none txt-right">Giới tính <span class="txt-red">*</span></div>
                    <div class="col-md-4 none">
                        <asp:DropDownList ID="Gender_ID" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 none">Độ tuổi</div>
                    <div class="col-md-9 none">
                        <asp:TextBox ID="Ages" runat="server" Text="Từ 18 đến 35" CssClass="TextBox " />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 none" style="padding: 10px 5px">Tính chất công việc <span class="txt-red">*</span></div>
                    <div class="col-md-9 none">
                        <asp:DropDownList ID="TypeOf_ID" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 none" style="padding: 0px 7px">Ngành nghề <span class="txt-red">*</span></div>
                    <div class="col-md-9 none">
                        <asp:DropDownList ID="Career_ID" multiple="multiple" data-actions-box="true" CssClass="nganhnghe selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 none">Thời gian làm việc</div>
                    <div class="col-md-9 none">
                        <asp:TextBox ID="WorkTime" runat="server" Text="Từ 8h đến 17h hàng ngày" CssClass="TextBox " />
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row none">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin yêu cầu
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="title5">
                        <img src="/image/note_edit.png" alt="logo" />&nbsp;Mô tả công việc <span class="txt-red">*</span>
                    </div>
                    <div class="col-md-12">
                        <asp:TextBox ID="Description" runat="server" CssClass="TextBox validate[required] " TextMode="MultiLine" Height="190px" />
                    </div>
                    <div class="col-md-12 none">Quyền lợi người lao động</div>
                    <div class="col-md-12 none">
                        <asp:TextBox ID="Benefit" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100px" />
                    </div>
                </div>

                <div class="col-md-6">
                    <div class="title5">
                        <img src="/image/note_edit.png" alt="logo" />Thông tin nghề nghiệp
                    </div>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="col-sm-4 col-md-3 col-lg-2  lb text-lg-right">Mã <span class="txt-red">*</span></div>
                            <div class="col-sm-8 col-md-9 col-lg-10">
                                <asp:DropDownList ID="MaNghe_Id" CssClass="nganhnghe selectpicker validate[required] " AutoPostBack="true" runat="server" />
                            </div>
                            <div class="clear"></div>

                            <div class="col-sm-4 col-md-3 col-lg-2  lb text-lg-right">Cấp 1</div>
                            <div class="col-sm-8 col-md-9 col-lg-4 ">
                                <asp:TextBox ID="MaNgheCap1" runat="server" Text="" CssClass="TextBox" Enabled="False"/>
                            </div>
                            <div class="col-sm-4 col-md-3 col-lg-2  lb text-lg-right">Cấp 2</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="MaNgheCap2" runat="server" Text="" CssClass="TextBox" Enabled="False"/>
                            </div>
                            <div class="col-sm-4 col-md-3 col-lg-2  lb text-lg-right">Cấp 3</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="MaNgheCap3" runat="server" Text="" CssClass="TextBox" Enabled="False"/>
                            </div>
                            <div class="col-sm-4 col-md-3 col-lg-2  lb text-lg-right">Cấp 4</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="MaNgheCap4" runat="server" Text="" CssClass="TextBox" Enabled="False"/>
                            </div>

                        </ContentTemplate>
                    </asp:UpdatePanel>

                    <div class="clear"></div>
                    <div class="col-md-3 lb">Chức vụ <span class="txt-red">*</span></div>
                    <div class="col-md-9">
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <div class="col-sm-4 col-md-5 col-lg-4">
                                    <asp:DropDownList ID="LevelDesired" CssClass="selectpicker validate[required] " runat="server" AutoPostBack="true" />
                                </div>
                                <asp:Panel runat="server" ID="pnlLevelDesiredOther" Visible="false">
                                    <div class="col-sm-8 col-md-7 col-lg-8">
                                        <asp:TextBox ID="LevelDesiredOther" runat="server" MaxLength="250" CssClass="TextBox" placeholder="Ghi rõ..." />
                                    </div>
                                </asp:Panel>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="LevelDesired" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <div class="col-md-6 pdr0 none">
                    <div class="col-md-12">Yêu cầu công việc <span class="txt-red">*</span></div>
                    <div class="col-md-12">
                        <asp:TextBox ID="Requirement" runat="server" CssClass="TextBox validate[required]" TextMode="MultiLine" Height="100px" />
                    </div>
                    <div class="col-md-12">Yêu cầu hồ sơ</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="RequirementsProfile" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100px" />
                    </div>
                </div>
                <div class="clear"></div>
            </div>

            <div class="row none">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin mở rộng theo thông tư/nghị định mới
                </div>
            </div>

            <div class="row">
                <div class="col-md-12">
                    <div class="title5">
                        <img src="/image/note_edit.png" alt="logo" />&nbsp;Trình độ học vấn
                    </div>
                    <div class="col-sm-4 col-md-3 col-lg-2  lb text-lg-right">Trình độ học vấn <span class="txt-red">*</span></div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="TrinhDoHocVan" CssClass="selectpicker validate[required]" runat="server" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2  lb text-lg-right">Trình độ CMKT <span class="txt-red">*</span></div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="TrinhDoChuyenMon" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb  text-lg-right">Chuyên ngành đào tạo</div>
                    <div class="col-sm-8 col-md-9 col-lg-10">
                        <asp:TextBox ID="ChuyenNganhDaoTao" runat="server" Text="" CssClass="TextBox" placeholder="Chuyên ngành đào tạo" />
                    </div>
                    <div class="clear"></div>
                </div>

                <div class="col-md-12">

                    <div class="title5">
                        <img src="/image/note_edit.png" alt="logo" />&nbsp;Trình độ khác
                    </div>
                    <div class="col-sm-4 col-md-3 col-lg-2  lb">Trình độ khác 1</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:TextBox ID="TrinhDoKhac" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2  text-xl-right lb">Trình độ khác 2</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:TextBox ID="TrinhDoKhac2" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2  lb">Trình độ kỹ năng nghề</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:TextBox ID="KyNangNghe" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2  text-xl-right lb">Kỹ năng nghề bậc</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:TextBox ID="KyNangNgheBac" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Trình độ ngoại ngữ
                </div>
                <div class="row">
                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Ngoại ngữ 1</div>
                    <div class="col-sm-8 col-md-9 col-lg-2">
                        <asp:TextBox ID="NgoaiNgu1" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb text-xl-right">Chứng chỉ</div>
                    <div class="col-sm-8 col-md-9 col-lg-2">
                        <asp:TextBox ID="NgoaiNgu1ChungChi" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Khả năng sử dụng</div>
                    <div class="col-sm-8 col-md-9 col-lg-2">
                        <asp:DropDownList ID="TrinhDoNgoaiNgu1" CssClass="selectpicker" runat="server" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row">
                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Ngoại ngữ 2</div>
                    <div class="col-sm-8 col-md-9 col-lg-2">
                        <asp:TextBox ID="NgoaiNgu2" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb text-xl-right">Chứng chỉ</div>
                    <div class="col-sm-8 col-md-9 col-lg-2">
                        <asp:TextBox ID="NgoaiNgu2ChungChi" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Khả năng sử dụng</div>
                    <div class="col-sm-8 col-md-9 col-lg-2">
                        <asp:DropDownList ID="TrinhDoNgoaiNgu2" CssClass="selectpicker" runat="server" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Trình độ tin học
                </div>
                <div class="row">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="col-sm-4 col-md-3 col-lg-2 lb">
                                Tin học văn phòng
                            </div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="TrinhDoTinHoc" runat="server" Text="" CssClass="TextBox" placeholder="Word, Powerpoint,..." />
                            </div>

                            <div class="col-sm-4 col-md-3 col-lg-2 lb text-xl-right">Khả năng sử dụng</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:DropDownList ID="TrinhDoTinHoc_KhaNang" CssClass="selectpicker" runat="server" />
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="TrinhDoTinHoc" />
                        </Triggers>
                    </asp:UpdatePanel>
                    <div class="clear"></div>
                </div>

                <div class="row">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="col-sm-4 col-md-3 col-lg-2 lb">
                                Trình độ khác
                            </div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="TrinhDoTinHoc_Khac" runat="server" Text="" CssClass="TextBox" placeholder="Phát âm chuẩn, đam mê giáo dục" />
                            </div>

                            <div class="col-sm-4 col-md-3 col-lg-2 lb text-xl-right">Khả năng sử dụng</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:DropDownList ID="TrinhDoTinHoc_Khac_KhaNang" CssClass="selectpicker" runat="server" />
                            </div>
                            <div class="clear"></div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="TrinhDoTinHoc_Khac" />
                        </Triggers>
                    </asp:UpdatePanel>
                    <div class="clear"></div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Kỹ năng mềm
                </div>
                <div class="row">
                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Kỹ năng mềm</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="KyNangMem" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="kynangmem selectpicker" runat="server" />
                        <asp:HiddenField ID="HidKyNangMem" runat="server" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb text-xl-right">Yêu cầu kinh nghiệm</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="YeuCauKinhNghiem" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Nơi làm việc dự kiến
                </div>
                <div class="row">
                    <asp:UpdatePanel runat="server" ID="uptinh">
                        <ContentTemplate>
                            <div class="col-md-2  lb">Nơi làm việc <span class="txt-red">*</span></div>
                            <div class="col-md-4" runat="server" id="divSelectTP">
                                <asp:DropDownList ID="TinhTP" AutoPostBack="true" CssClass="selectpicker TinhTP validate[required]" runat="server" />
                                <%--<asp:DropDownList ID="TinhTPMulti" onchange="getMultiple(); " multiple="multiple" data-actions-box="true" CssClass="none selectpicker TinhTP2 validate[required]" runat="server" />--%>
                            </div>
                            <div class="col-md-3" runat="server" id="divSelectPX">
                                <asp:DropDownList ID="PhuongXa" CssClass="selectpicker PhuongXa" runat="server" />
                                <asp:HiddenField ID="HidPhuongXa" runat="server" />
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                        </Triggers>
                    </asp:UpdatePanel>

                    <div class="clear"></div>
                </div>

                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Loại hợp đồng lao động
                </div>
                <div class="row">
                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Loại hợp đồng</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="ContractType_Option" CssClass="selectpicker" runat="server" />
                    </div>
                    <div class="clear"></div>

                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Yêu cầu thêm
                </div>
                <div class="row">
                    <label for="<%=IsLamCa.ClientID %>" class="left col-xs-4 col-sm-4 col-md-3 col-lg-2 pd0" style="max-height: 32px">
                        <span class="col-xs-12 col-sm-12 lb">Làm ca</span>
                    </label>
                    <div class="col-sm-8 col-md-1 pdt5" style="min-height: 32px">
                        <asp:CheckBox ID="IsLamCa" CssClass="cs-select" runat="server" />
                    </div>

                    <label for="<%=IsDiCongTac.ClientID %>" class="left col-xs-4 col-sm-4 col-md-3 col-lg-2 pd0" style="max-height: 32px">
                        <span class="col-xs-12 col-sm-12 lb">Đi công tác</span>
                    </label>
                    <div class="col-sm-8 col-md-1 pdt5" style="min-height: 32px">
                        <asp:CheckBox ID="IsDiCongTac" CssClass="cs-select" runat="server" />
                    </div>

                    <label for="<%=IsDiBietPhai.ClientID %>" class="left col-xs-4 col-sm-4 col-md-3 col-lg-2 pd0" style="max-height: 32px">
                        <span class="col-xs-12 col-sm-12 lb text-xl-right">Đi biệt phái</span>
                    </label>
                    <div class="col-sm-8 col-md-1 pdt5" style="min-height: 32px">
                        <asp:CheckBox ID="IsDiBietPhai" CssClass="cs-select" runat="server" />
                    </div>
                    <div class="clear"></div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Hình thức làm việc <span class="txt-red">*</span></div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="HinhThucLamViec" CssClass="selectpicker validate[required]" runat="server" />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb text-xl-right">Mục đích làm việc</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="MucDich_ID" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Mức lương
                </div>
                <div class="row">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="col-md-12 pdl0">
                                <div class="col-sm-4 col-md-3 col-lg-2 lb">Chọn kiểu lương <span class="txt-red">*</span></div>
                                <div class="col-sm-8 col-md-9 col-lg-4">
                                    <asp:DropDownList ID="KieuLuong" CssClass="selectpicker validate[required]" AutoPostBack="true" runat="server" />
                                </div>

                                <asp:Panel ID="pnlSalary_Option" runat="server">
                                    <div class="col-sm-4 col-md-3 col-lg-2 lb text-xl-right">Mức lương <span class="txt-red">*</span></div>
                                    <asp:Panel ID="pnlSalary_Option_Choose" runat="server">
                                        <div id="salary-option" class="col-sm-8 col-md-9 col-lg-4">
                                            <asp:DropDownList ID="Salary_Option" CssClass="selectpicker validate[required]" runat="server" />
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlSalary_Input_Choose" runat="server" Visible="false">
                                        <div id="salary-input" class="col-sm-8 col-md-9 col-lg-4">
                                            <asp:TextBox ID="Salary_Text" runat="server" CssClass="TextBox" />
                                            <asp:Literal ID="Salary_Text_DVT" runat="server"></asp:Literal>
                                        </div>
                                    </asp:Panel>
                                </asp:Panel>
                                <div class="clear"></div>
                                <label for="<%=chkThoaThuan.ClientID %>" class="left col-md-3 pd0" style="max-height: 32px">
                                    <span class="col-xs-12 col-sm-12 lb">Thỏa thuận khi phỏng vấn</span>
                                </label>
                                <div class="col-md-3 pdt5 " style="min-height: 32px">
                                    <asp:CheckBox ID="chkThoaThuan" CssClass="cs-select" runat="server" />
                                </div>
                                <div class="col-md-4 lb">Hoa hồng theo doanh thu/sản phẩm</div>
                                <div class="col-md-2 pdt5" style="min-height: 32px">
                                    <asp:CheckBox ID="IsHoaHong" CssClass="cs-select" runat="server" />
                                </div>

                                <div class="col-md-12 lb none">Hình thức nộp</div>
                                <div class="col-md-12">
                                    <asp:TextBox ID="HinhThucNop" Visible="false" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="127px" />
                                </div>
                                <div class="clear"></div>
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Salary_Option" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Chế độ phúc lợi
                </div>
                <div class="row">
                    <div class=" col-md-3 lb">Hỗ trợ ăn </div>
                    <div class=" col-md-3 ">
                        <asp:DropDownList ID="HoTroAn" CssClass="selectpicker" runat="server" />
                    </div>

                    <div class="col-md-3 lb text-lg-right">Phúc lợi </div>
                    <div class=" col-md-3">
                        <asp:DropDownList ID="PhucLoi" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="phucloi selectpicker " runat="server" />
                        <asp:HiddenField ID="HidPhucLoi" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 lb">Xe đưa đón </div>
                    <div class=" col-md-3">
                        <asp:DropDownList ID="XeDuaDon" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="xeduadon selectpicker " runat="server" />
                        <asp:HiddenField ID="HidXeDuaDon" runat="server" />
                    </div>

                    <div class=" col-md-3  lb text-lg-right">Hỗ trợ </div>
                    <div class=" col-md-3 ">
                        <asp:DropDownList ID="HoTro" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="xeduadon selectpicker " runat="server" />
                        <asp:HiddenField ID="HidHoTro" runat="server" />
                    </div>
                    
                    <div class="clear"></div>
                    <div class="col-md-3  lb">Khác</div>
                    <div class=" col-md-9">
                        <asp:TextBox ID="PhucLoiKhac" runat="server" Text="" CssClass="TextBox" placeholder="" />
                    </div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Điều kiện làm việc
                </div>
                <div class="row">
                    <div class="col-md-3  lb">Nơi làm việc </div>
                    <div class="col-md-3 ">
                        <asp:DropDownList ID="NoiLamViec" CssClass="selectpicker " runat="server" />
                    </div>

                    <div class="col-md-3 lb text-lg-right">Trọng lượng nâng </div>
                    <div class="col-md-3 ">
                        <asp:DropDownList ID="NoiLamViecTrongLuong" CssClass="selectpicker " runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3  lb">Đứng hoặc đi lại </div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="NoiLamViecDiLai" CssClass="selectpicker " runat="server" />
                    </div>

                    <div class="col-md-3 lb text-lg-right">Nghe nói </div>
                    <div class="col-md-3 ">
                        <asp:DropDownList ID="NoiLamViecNgheNoi" CssClass="selectpicker " runat="server" />
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-3 lb">Thị lực </div>
                    <div class="col-md-3 ">
                        <asp:DropDownList ID="NoiLamViecThiLuc" CssClass="selectpicker " runat="server" />
                    </div>

                    <div class="col-md-3 lb text-lg-right">Thao tác bằng tay </div>
                    <div class="col-md-3 ">
                        <asp:DropDownList ID="NoiLamViecThaoTacBangTay" CssClass="selectpicker " runat="server" />
                    </div>
                    
                    <div class="clear"></div>
                    <div class="col-md-3 lb">Dùng 2 tay </div>
                    <div class="col-md-3 ">
                        <asp:DropDownList ID="NoiLamViecDung2Tay" CssClass="selectpicker " runat="server" />
                    </div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Đối tượng ưu tiên
                </div>
                <div class="row">
                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Đối tượng ưu tiên</div>
                    <div class="col-sm-8 col-md-9 col-lg-10">
                        <asp:DropDownList ID="DoiTuongUuTien" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                        <asp:HiddenField ID="HidDoiTuongUuTien" runat="server" />
                    </div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Hình thức tuyển dụng
                </div>
                <div class="row">
                    <div class=" col-md-3 lb">Hình thức tuyển dụng</div>
                    <div class="col-md-3 ">
                        <asp:DropDownList ID="HinhThucTuyenDung" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                        <asp:HiddenField ID="HidHinhThucTuyenDung" runat="server" />
                    </div>

                    <div class=" col-md-3 lb text-xl-right">Thời hạn tuyển dụng <span class="txt-red">*</span></div>
                    <div class="col-md-3">
                        <div class="rccalpopup">
                            <asp:TextBox ID="ThoiHanTuyenDung" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker NopHS TextBox validate[required]" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Mong muốn của doanh nghiệp đối với TTDVVL
                </div>
                <div class="row">
                    <div class="col-md-2 lb">Mong muốn doanh nghiệp</div>
                    <div class="col-md-10">
                        <asp:DropDownList runat="server" CssClass="selectpicker" ID="MongMuonDN" />
                    </div>
                </div>
            </div>
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;2. Thông tin người liên hệ tuyển dụng
            </div>
            <div class="row">
                <div class="col-md-2 lb">Nhà tuyển dụng <span class="txt-red">*</span></div>
                <div class="col-md-10">
                    <asp:TextBox ID="Business_Name" Enabled="false" onchange="setBusiness()" runat="server" CssClass="TextBox validate[required]" />
                            <asp:HiddenField ID="Business_ID" runat="server" Visible="false" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 lb">Địa chỉ liên hệ</div>
                <div class="col-md-7">
                    <asp:TextBox ID="ContactAddress" Enabled="false" runat="server" CssClass="TextBox" />
                </div>
                <div class="col-md-1 lb txt-center">MST <span class="txt-red">*</span></div>
                <div class="col-md-2">
                    <asp:TextBox ID="TaxCode" runat="server" Enabled="false" CssClass="TextBox validate[required,minSize[10]]" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-6" style="padding: 0;">
                    <div class="row">
                        <div class="col-md-4 lb">Người liên hệ <span class="txt-red">*</span></div>
                        <div class="col-md-8">
                            <asp:TextBox ID="ContactUser" runat="server" CssClass="TextBox validate[required]" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-4 lb">Điện thoại <span class="txt-red">*</span></div>
                        <div class="col-md-8">
                            <asp:TextBox ID="ContactMobile" runat="server" CssClass="TextBox validate[required]" />
                        </div>
                        <div class="col-md-4 lb">Email liên hệ  <span class="txt-red">*</span></div>
                        <div class="col-md-8">
                            <asp:TextBox ID="ContactEmail" runat="server" CssClass="TextBox validate[required, custom[email]]" />
                           
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
                <div class="col-md-6 pdr0">
                    <div class="row">
                        <div class="col-md-12 lb">Hình thức liên hệ khác (nếu có)</div>
                        <div class="col-md-12">
                            <asp:TextBox ID="ContactDes" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="70" />
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
                
            <div class="row ">
                <div class="col-md-2">Hồ sơ đã duyệt</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsApproval" Enabled="false" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-1 txt-right" title="Chọn làm tin nổi bật trên trang chủ">Tin nổi bật</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsHot" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-2 txt-right" title="Thông tin doanh nghiệp sẽ được ẩn đi và thay thế bằng thông tin của trung tâm DVVL">Dấu thông tin DN</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsFast" ToolTip="Thông tin doanh nghiệp sẽ được ẩn đi và thay thế bằng thông tin của trung tâm DVVL" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-1 txt-right" title="Chọn làm tin đăng gấp ngoài trang chủ">Đăng gấp</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsUrgent" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-1 txt-right" title="Ghim tin này lên đầu ngoài trang chủ">Ghim tin</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsGhim" ToolTip="Ghim tin này lên đầu ngoài trang chủ" CssClass="cs-select" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin vị trí trên bản đồ
            </div>
            <div class="row">
                <div class="col-sm-6">
                    <div class="col-md-4 lb">Lat (Vĩ độ)</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtLat" runat="server" CssClass="TextBox " />
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="col-md-3  lb">Lng (Kinh độ) </div>
                    <div class="col-md-9 ">
                        <asp:TextBox ID="txtLng" runat="server" CssClass="TextBox " />
                    </div>
                </div>
                <div class="clear"></div>
            </div>
                <div class="clear"></div>
            </div>

        </div>
        <div class="clr clUp "></div>
        <asp:Literal ID="litUpdate" runat="server" />
    </div>
    <asp:HiddenField ID="ItemID" runat="server" Visible="true" />
    <asp:HiddenField ID="HF_ID" runat="server" Visible="true" />
    <asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
    <asp:HiddenField ID="hidBusinessID" runat="server" />
    <asp:HiddenField ID="CareerID" runat="server" />
    <asp:HiddenField ID="HidTinhTP" runat="server" />
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" ToolTip="Lưu và đóng màn hình nhập tin này lại" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="getMultiple(); return checkThongTin();" />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');" />
        <div class="clr"></div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $("#<%=Business_Name.ClientID %>").change(function () {
            setBusiness()
        });
        $("#<%=Business_Name.ClientID %>").keyup(function () {
            setBusiness()
        });
    });
    function setBusiness() {
        var tp = $(".TinhTP").val();
        var qh = $(".QuanHuyen").val();
        $("#<%=hidBusinessID.ClientID %>").val("");
        $("#<%=ContactEmail.ClientID %>").val("");
        $("#<%=ContactMobile.ClientID %>").val("");
        $("#<%=ContactUser.ClientID %>").val("");
        $("#<%=ContactAddress.ClientID %>").val("");
        $("#<%=TaxCode.ClientID %>").val("");
        $("#<%=Business_Name.ClientID %>").autocomplete({
            source: function (request, response) {
                $.ajax({
                    dataType: "json", type: "POST", url: '/api/work/search.asmx/findBusiness',
                    data: "{'search': '" + request.term + "','tp':'" + tp + "','qh':'" + qh + "'}", contentType: "application/json; charset=utf-8",
                    success: function (data) {
                        response($.map(data.d, function (item) {
                            return {
                                label: item.Business_Vn,
                                val: item.Business_ID,
                                ContactUser: item.ContactUser,
                                ContactMobile: item.ContactMobile,
                                ContactEmail: item.ContactEmail,
                                TaxCode: item.TaxCode,
                                Address: item.Address
                            }
                        }))
                    }
                });
            },
            select: function (e, i) {
                $("#<%=hidBusinessID.ClientID %>").val(i.item.val);
                $("#<%=ContactEmail.ClientID %>").val(i.item.ContactEmail);
                $("#<%=ContactMobile.ClientID %>").val(i.item.ContactMobile);
                $("#<%=ContactUser.ClientID %>").val(i.item.ContactUser);
                $("#<%=TaxCode.ClientID %>").val(i.item.TaxCode);
                $("#<%=ContactAddress.ClientID %>").val(i.item.Address);
            },
            minLength: 0,
        }).focus(function () { $(this).autocomplete('search', $(this).val()) });
    };
    function checkThongTin() {
        if ($('#Form').validationEngine('validate') == true) {

            //if ($(".TuNgay").val() == "") {
            //    notify('info', 'Bạn chưa nhập ngày đăng tin.', 'Thông báo', false);
            //    $(".TuNgay").focus(); return false;
            //}

            //if ($(".DenNgay").val() == "") {
            //    notify('info', 'Bạn chưa nhập ngày hết hạn đăng tin.', 'Thông báo', false);
            //    $(".DenNgay").focus(); return false;
            //}
            //else {
            //    var kq = $(".TuNgay").val().split("/");
            //    var date1 = new Date(kq[1] + "/" + kq[0] + "/" + kq[2]).setHours(0, 0, 0, 0);

            //    kq = $(".DenNgay").val().split("/");
            //    var date2 = new Date(kq[1] + "/" + kq[0] + "/" + kq[2]).setHours(0, 0, 0, 0);
            //    if (date1.valueOf() > date2.valueOf()) {
            //        notify('info', 'Ngày hết hạn đăng tin phải lớn hơn ngay đăng tin.', 'Thông báo', false);
            //        $(".DenNgay").focus(); return false;
            //    }
            //}
            //if ($(".NopHS").val() == "") {
            //    notify('info', 'Bạn chưa nhập ngày hết hạn nộp hồ sơ.', 'Thông báo', false);
            //    $(".NopHS").focus(); return false;
            //}
            //else {
            //    var kq = $(".TuNgay").val().split("/");
            //    var date1 = new Date(kq[1] + "/" + kq[0] + "/" + kq[2]).setHours(0, 0, 0, 0);

            //    kq = $(".NopHS").val().split("/");
            //    var date2 = new Date(kq[1] + "/" + kq[0] + "/" + kq[2]).setHours(0, 0, 0, 0);
            //    if (date1.valueOf() > date2.valueOf()) {
            //        notify('info', 'Ngày hết hạn nộp hồ sơ phải lớn hơn ngày đăng tin.', 'Thông báo', false);
            //        $(".NopHS").focus(); return false;
            //    }
            //}
            return true;
        }
        else {
            return false
        }
    };
    function setMultiple() {
        <%--var vdata = $('#<%= HidTinhTP.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
            $('#<%= TinhTPMulti.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= TinhTPMulti.ClientID%>").trigger('selectpicker:updated');
        });--%>
        values = $('#<%= CareerID.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=Career_ID.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=Career_ID.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidKyNangMem.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=KyNangMem.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=KyNangMem.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidPhucLoi.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=PhucLoi.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=PhucLoi.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidXeDuaDon.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=XeDuaDon.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=XeDuaDon.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidHoTro.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=HoTro.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=HoTro.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidDoiTuongUuTien.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=DoiTuongUuTien.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=DoiTuongUuTien.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidHinhThucTuyenDung.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=HinhThucTuyenDung.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=HinhThucTuyenDung.ClientID %>").trigger('selectpicker:updated');
        });
    };
    function getMultiple() {
       <%-- $('#<%=HidTinhTP.ClientID%>').val($("#<%= TinhTPMulti.ClientID%>").val());--%>
        $('#<%= CareerID.ClientID%>').val($("#<%=Career_ID.ClientID %>").val()); 
        $('#<%=HidKyNangMem.ClientID%>').val($("#<%=KyNangMem.ClientID %>").val()); $('#<%=HidPhucLoi.ClientID%>').val($("#<%=PhucLoi.ClientID %>").val()); $('#<%=HidXeDuaDon.ClientID%>').val($("#<%=XeDuaDon.ClientID %>").val());
        $('#<%=HidHoTro.ClientID%>').val($("#<%=HoTro.ClientID %>").val()); $('#<%=HidDoiTuongUuTien.ClientID%>').val($("#<%=DoiTuongUuTien.ClientID %>").val());$('#<%=HidHinhThucTuyenDung.ClientID%>').val($("#<%=HinhThucTuyenDung.ClientID %>").val());
    }
</script>

