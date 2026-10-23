<%@ Control Language="vb" AutoEventWireup="true" CodeFile="JobuserAdd.ascx.vb" Inherits="Modules.Vbn.View" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<style>
    .ms {
        position: absolute;
        top: 50%;
        right: 10px;
        transform: translateY(-50%);
    }
</style>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin hồ sơ tìm việc làm</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            
     <asp:Label runat="server" ID="lblDownLoad" Style="display: none;"></asp:Label>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="none" runat="server" id="pnKhongDung" visible="false">
                            <div class="col-md-2 lb">Người tìm việc <sup class="txt-red">*</sup></div>
                            <div class="col-md-10">
                                <asp:DropDownList ID="UserAdmin" Enabled="false" AutoPostBack="true" CssClass="selectpicker validate[required]" runat="server" />
                                <span class="required"></span>
                            </div>

                            <div class="clear"></div>
                            <div class="col-md-2 lb">Ngày đăng
                                    <span class="required label-required"></span>

                            </div>
                            <div class="col-md-2 ">
                                <div class="rccalpopup">
                                    <asp:TextBox ID="StartDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-2 txt-center lb">Ngày hết hạn
                                    <span class="required label-required"></span>

                            </div>
                            <div class="col-md-2 ">
                                <div class="rccalpopup">
                                    <asp:TextBox ID="EndDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-2 txt-center lb">Hồ sơ đã duyệt </div>
                            <div class="co-md-2 pdt5">
                                <asp:CheckBox ID="IsApproval" CssClass="cs-select" runat="server" />
                            </div>
                                </div>
                        </div>
                        <div class="col-xs-12 none">
                            <div class="card-box">
                                <div class="row">
                                    <div class="title5">
                                        <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin người lao động
                                    </div>
                                </div>
                                <div class="member-card">
                                    <div class="form-group text-center">
                                        <h3>
                                            <asp:Literal ID="DisplayName" runat="server">
                                            </asp:Literal>
                                        </h3>
                                    </div>
                                    <%--<div class="form-group">
                                        <i class="mdi mdi-account-circle"></i>Tài khoản: 
                                        <asp:Literal ID="Account" runat="server"></asp:Literal>
                                    </div>--%>
                                    <div class="form-group">
                                        <i class="mdi mdi-account-card-details">Số CCCD/CMND: </i>
                                        <asp:Literal ID="CCCD" runat="server"></asp:Literal>
                                    </div>

                                    <div class="form-group">
                                        Mã số BHXH:
                                        <asp:Literal ID="BHXH" runat="server"></asp:Literal>
                                    </div>
                                    <div class="form-group">
                                        <i class="ti-email"></i>Email:
                                        <asp:Literal ID="Email" runat="server"></asp:Literal>
                                    </div>
                                    <div class="form-group">
                                        <i class="ti-headphone-alt"></i>Điện thoại:<asp:Literal ID="SDT" runat="server"></asp:Literal>
                                    </div>
                                    <div class="form-group">
                                        <i class="mdi mdi-cake-variant"></i>Ngày sinh:
                                        <asp:Literal ID="NgaySinh" runat="server"></asp:Literal>
                                    </div>

                                    <div class="form-group">
                                        Giới tính:
                                        <asp:Literal ID="GioiTinh" runat="server"></asp:Literal>
                                    </div>

                                    <div class="form-group">
                                        Dân tộc:
                                        <asp:Literal ID="DanToc" runat="server"></asp:Literal>
                                    </div>
                                    <div class="form-group">
                                        Tôn giáo:
                                        <asp:Literal ID="TonGiao" runat="server"></asp:Literal>
                                    </div>
                                    <div class="form-group">
                                        Địa chỉ thường trú:
                                        <asp:Literal ID="DiaChi1" runat="server"></asp:Literal>
                                    </div>
                                    <div class="form-group">
                                        Nơi ở hiện nay:
                                        <asp:Literal ID="DiaChi2" runat="server"></asp:Literal>
                                    </div>
                                </div>

                            </div>
                            <!-- end card-box -->
                        </div>
                    </div>

                </ContentTemplate>
            </asp:UpdatePanel>

            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Việc làm mong muốn
                </div>
            </div>
            <div class="row">
                <div class="clear"></div>
                <div class="col-sm-4 col-md-3 col-lg-2 lb">Tên công việc <sup class="txt-red">*</sup></div>
                <div class="col-sm-8 col-md-9 col-lg-10">
                    <asp:TextBox ID="Title" runat="server" MaxLength="250" CssClass="TextBox validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-sm-4 col-md-3 col-lg-2 lb">Loại hình doanh nghiệp <sup class="txt-red">*</sup></div>
                <div class="col-sm-8 col-md-9 col-lg-4">
                    <asp:DropDownList ID="drLoaiHinhDoanhNghiep" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker validate[required]" runat="server" />
                    <asp:HiddenField ID="HidLoaiHinhDoanhNghiep" runat="server" />
                </div>
                <div class="col-sm-4 col-md-3 col-lg-1 lb text-right">Hợp đồng</div>
                <div class="col-sm-8 col-md-9 col-lg-5">
                    <asp:DropDownList ID="ContractType_Option" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidContractType" runat="server" />
                </div>
                <div class="clear"></div>
                <div class="col-md-6">
                    <div class="row">
                        <div class="title5">
                            <img src="/image/note_edit.png" alt="logo" />&nbsp;Mô tả công việc
                        </div>
                    </div>
                    <div class="col-md-12 telerik-editor">
                        <asp:TextBox ID="Description" runat="server" Text="" CssClass="TextBox" TextMode="MultiLine" Height="300px" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="col-md-6 pdl0">
                    <div class="row">
                        <div class="title5">
                            <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin ngành nghề
                        </div>
                    </div>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Mã nghề <sup class="txt-red">*</sup></div>
                            <div class="col-sm-8 col-md-9 col-lg-10">
                                <asp:DropDownList ID="Career_ID" CssClass="nganhnghe selectpicker validate[required]" AutoPostBack="true" runat="server" />
                                <span class="required"></span>
                            </div>
                            <div class="clear"></div>

                            <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Cấp 1</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="txtMaNgheCap1" runat="server" Text="" CssClass="TextBox" />
                            </div>
                            <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Cấp 2</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="txtMaNgheCap2" runat="server" Text="" CssClass="TextBox" />
                            </div>
                            <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Cấp 3</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="txtMaNgheCap3" runat="server" Text="" CssClass="TextBox" />
                            </div>
                            <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Cấp 4</div>
                            <div class="col-sm-8 col-md-9 col-lg-4">
                                <asp:TextBox ID="txtMaNgheCap4" runat="server" Text="" CssClass="TextBox" />
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="row">
                        <div class="title5">
                            <img src="/image/note_edit.png" alt="logo" />&nbsp;Chức vụ
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Chức vụ <sup class="txt-red">*</sup></div>
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <div class="col-sm-4 col-md-5 col-lg-4">
                                    <asp:DropDownList ID="LevelDesired" CssClass="selectpicker validate[required]" runat="server" AutoPostBack="true" />
                                </div>
                                <asp:Panel runat="server" ID="pnlLevelDesiredOther" Visible="false">
                                    <div class="col-sm-4 col-md-4 col-lg-6">
                                        <asp:TextBox ID="LevelDesiredOther" runat="server" MaxLength="250" CssClass="TextBox" placeholder="Ghi rõ..." />
                                    </div>
                                </asp:Panel>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="LevelDesired" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                    <div class="row">
                        <div class="title5">
                            <img src="/image/note_edit.png" alt="logo" />&nbsp;Kinh nghiệm làm việc trong lĩnh vực cần tìm
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Kinh nghiệm</div>
                        <div class="col-sm-8 col-md-9 col-lg-10">
                            <asp:DropDownList ID="Experience_ID" CssClass="selectpicker" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Nơi ưu tiên làm việc
                </div>
            </div>

            <div class="row">
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>
                        <div class="col-sm-4 col-md-3 col-lg-2 lb">
                            Ưu tiên 1: Tỉnh
                            <asp:CheckBox CssClass="chkMultiple Checkbox right" AutoPostBack="true" runat="server" ID="chkMultiple" ToolTip="Tích để chọn nhiều tỉnh thành phố" Visible="false" />
                        </div>
                        <div class="col-sm-8 col-md-9 col-lg-4" runat="server" id="divSelectTP">
                            <asp:DropDownList ID="TinhTP" AutoPostBack="true" CssClass="selectpicker TinhTP" runat="server" />
                            <asp:DropDownList ID="TinhTPMulti" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="none selectpicker TinhTP" runat="server" />
                        </div>

                        <div class="col-sm-4 col-md-3 col-lg-2 lb">
                            Phường/ Xã/ KCN/ KKT
                        </div>
                        <div class="col-sm-8 col-md-3 col-lg-2 none" runat="server" id="divSelectKCN">
                            <asp:DropDownList ID="drNoiLamViecHuyen" AutoPostBack="true" CssClass="selectpicker" runat="server" />
                        </div>

                        <div class="col-sm-8 col-md-9 col-lg-4" runat="server" id="divSelectQH">
                            <asp:DropDownList ID="QuanHuyen" multiple="multiple" onchange="getMultiple();" data-actions-box="true" CssClass="selectpicker QuanHuyen" runat="server" />
                            <asp:HiddenField ID="HidQuanHuyen" runat="server" />
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    </Triggers>
                </asp:UpdatePanel>
                <div class="clear"></div>
                <asp:UpdatePanel runat="server" ID="UpdatePanel2">
                    <ContentTemplate>
                        <div class="col-sm-4 col-md-3 col-lg-2 lb">
                            Ưu tiên 2: Tỉnh
                            <asp:CheckBox CssClass="chkMultiple Checkbox right" AutoPostBack="true" runat="server" ID="chkMultiple2" ToolTip="Tích để chọn nhiều tỉnh thành phố" Visible="false" />
                        </div>
                        <div class="col-sm-8 col-md-9 col-lg-4" runat="server" id="divSelectTP2">
                            <asp:DropDownList ID="TinhTP2" AutoPostBack="true" CssClass="selectpicker TinhTP1 " runat="server" />
                            <asp:DropDownList ID="TinhTPMulti2" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="none selectpicker TinhTP2" runat="server" />
                        </div>

                        <div class="col-sm-4 col-md-3 col-lg-2 lb">
                             Phường/ Xã/ KCN/ KKT
                        </div>
                        <div class="col-sm-8 col-md-3 col-lg-2 none" runat="server" id="divSelectKCN2">
                            <asp:DropDownList ID="drNoiLamViecHuyen2" AutoPostBack="true" CssClass="selectpicker" runat="server" />
                        </div>

                        <div class="col-sm-8 col-md-9 col-lg-4" runat="server" id="divSelectQH2">
                            <asp:DropDownList ID="QuanHuyen2" multiple="multiple" onchange="getMultiple();" data-actions-box="true" CssClass="selectpicker QuanHuyen2" runat="server" />
                            <asp:HiddenField ID="HidQuanHuyen2" runat="server" />
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="TinhTP2" />
                    </Triggers>
                </asp:UpdatePanel>
                <div class="clear"></div>
            </div>

            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Khả năng đáp ứng
                </div>
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
                    <span class="col-xs-12 col-sm-12 lb text-md-left text-lg-right">Đi biệt phái</span>
                </label>
                <div class="col-sm-8 col-md-1 pdt5" style="min-height: 32px">
                    <asp:CheckBox ID="IsDiBietPhai" CssClass="cs-select" runat="server" />
                </div>
                <div class="clear"></div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb">Hình thức làm việc</div>
                <div class="col-sm-8 col-md-9 col-lg-4">
                    <asp:DropDownList ID="TypeOf_ID" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidTypeOf" runat="server" />
                </div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Mục đích làm việc</div>
                <div class="col-sm-8 col-md-9 col-lg-4">
                    <asp:DropDownList ID="MucDich_ID" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidMucDich" runat="server" />
                </div>
                <div class="clear"></div>
            </div>

            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Mức lương, Chế độ phúc lợi
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 pdl0">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="col-md-12 pdl0">
                                <div class="col-sm-4 col-md-6 col-lg-4 lb">Kiểu lương hưởng <sup class="txt-red">*</sup></div>
                                <div class="col-sm-8 col-md-6 col-lg-8">
                                    <asp:DropDownList ID="Salary_ID" CssClass="selectpicker validate[required]" AutoPostBack="true" runat="server" />
                                    <span class="required"></span>
                                </div>

                                <asp:Panel ID="pnlSalary_Option" runat="server" Visible="false">
                                    <div class="col-sm-4 col-md-6 col-lg-4 lb">Mức lương <sup class="txt-red">*</sup></div>
                                    <asp:Panel ID="pnlSalary_Option_Choose" runat="server">
                                        <div id="salary-option" class="col-sm-8 col-md-6 col-lg-8">
                                            <asp:DropDownList ID="Salary_Option" CssClass="selectpicker validate[required]" runat="server" />
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlSalary_Input_Choose" runat="server" Visible="false">
                                        <div id="salary-input" class="col-sm-8 col-md-9 col-lg-8">
                                            <asp:TextBox ID="Salary_Text" runat="server" CssClass="TextBox" />
                                            <asp:Literal ID="Salary_Text_DVT" runat="server"></asp:Literal>
                                        </div>
                                    </asp:Panel>
                                </asp:Panel>

                                <div class="col-md-12 lb none">Hình thức nộp</div>
                                <div class="col-md-12">
                                    <asp:TextBox ID="SubmissionSend" Visible="false" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="127px" />
                                </div>
                                <div class="clear"></div>
                                <label for="<%=chkThoaThuan.ClientID %>" class="left col-lg-4 pd0" style="max-height: 32px">
                                    <span class="col-xs-12 col-sm-12 lb">Thỏa thuận khi phỏng vấn</span>
                                </label>
                                <div class="col-sm-1 col-md-1 pdt5 col-lg-2" style="min-height: 32px">
                                    <asp:CheckBox ID="chkThoaThuan" CssClass="cs-select" runat="server" />
                                </div>
                                <label for="<%=chkHoaHong.ClientID %>" class="left col-lg-4 pd0" style="max-height: 32px">
                                    <span class="col-xs-12 col-sm-12 lb">Hoa hồng theo doanh thu/sản phẩm</span>
                                </label>
                                <div class="col-sm-1 col-md-1 pdt5 col-lg-2" style="min-height: 32px">
                                    <asp:CheckBox ID="chkHoaHong" CssClass="cs-select" runat="server" />
                                </div>
                                <div class="clear"></div>
                            </div>

                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Salary_Option" />
                        </Triggers>
                    </asp:UpdatePanel>

                    <div class="col-sm-4 col-md-6 col-lg-4 lb">Hỗ trợ ăn</div>
                    <div class="col-sm-8 col-md-6 col-lg-8">
                        <asp:DropDownList ID="drHoTroAn" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                        <asp:HiddenField ID="HidHoTroAn" runat="server" />
                    </div>

                    <div class="col-sm-4 col-md-6 col-lg-4 lb">Phúc lợi</div>
                    <div class="col-sm-8 col-md-6 col-lg-8">
                        <asp:DropDownList ID="drPhucLoi" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="phucloi selectpicker" runat="server" />
                        <asp:HiddenField ID="HidPhucLoi" runat="server" />
                    </div>

                    <div class="col-sm-4 col-md-6 col-lg-4 lb">Xe đưa đón</div>
                    <div class="col-sm-8 col-md-6 col-lg-8">
                        <asp:DropDownList ID="drXeDuaDon" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="xeduadon selectpicker" runat="server" />
                        <asp:HiddenField ID="HidXeDuaDon" runat="server" />
                    </div>

                    <div class="col-sm-4 col-md-6 col-lg-4 lb">Hỗ trợ</div>
                    <div class="col-sm-8 col-md-6 col-lg-8">
                        <asp:DropDownList ID="drPhucLoiKhac" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="xeduadon selectpicker" runat="server" />
                        <asp:HiddenField ID="HidPhucLoiKhac" runat="server" />
                    </div>
                </div>
                <div class="col-sm-12 col-md-6 pdl0">

                    <div class="col-sm-12 col-md-12 col-lg-12 lb">Chế độ phúc lợi khác</div>
                    <div class="col-sm-12 telerik-editor">
                        <asp:TextBox ID="txtPhucLoiKhac" runat="server" Text="" CssClass="TextBox" TextMode="MultiLine" Height="225px" PlaceHolder="Các chế độ phúc lợi khác" />
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Điều kiện làm việc, Thời gian đi làm
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4 col-md-3 col-lg-2 lb">Nơi làm việc</div>
                <div class="col-sm-8 col-md-3 col-lg-4">
                    <asp:DropDownList ID="drNoiLamViec" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidNoiLamViec" runat="server" />
                </div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Trọng lượng nâng</div>
                <div class="col-sm-8 col-md-3 col-lg-4">
                    <asp:DropDownList ID="drNoiLamViecTrongLuong" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidNoiLamViecTrongLuong" runat="server" />
                </div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb">Đứng hoặc đi lại</div>
                <div class="col-sm-8 col-md-3 col-lg-4">
                    <asp:DropDownList ID="drNoiLamViecDiLai" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidNoiLamViecDiLai" runat="server" />
                </div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Nghe nói</div>
                <div class="col-sm-8 col-md-3 col-lg-4">
                    <asp:DropDownList ID="drNoiLamViecNgheNoi" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidNoiLamViecNgheNoi" runat="server" />
                </div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb">Thị lực</div>
                <div class="col-sm-8 col-md-3 col-lg-4">
                    <asp:DropDownList ID="drNoiLamViecThiLuc" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidNoiLamViecThiLuc" runat="server" />
                </div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Thao tác bằng tay</div>
                <div class="col-sm-8 col-md-3 col-lg-4">
                    <asp:DropDownList ID="drNoiLamViecThaoTacBangTay" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidNoiLamViecThaoTacBangTay" runat="server" />
                </div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb">Dùng 2 tay</div>
                <div class="col-sm-8 col-md-3 col-lg-4">
                    <asp:DropDownList ID="drNoiLamViecDung2Tay" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker" runat="server" />
                    <asp:HiddenField ID="HidNoiLamViecDung2Tay" runat="server" />
                </div>

                <div class="col-sm-4 col-md-3 col-lg-2 lb text-md-left text-lg-right">Sẵn sàng làm việc</div>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="col-sm-4 col-md-2 col-lg-2">
                            <%--<asp:DropDownList ID="Needs_ID" CssClass="selectpicker" runat="server" />--%>
                            <asp:DropDownList ID="drSanSangLamViec" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <asp:Panel runat="server" ID="pnlSanSangLamViec" Visible="false">
                            <div class="rccalpopup col-sm-4 col-md-1 col-lg-2">
                                <asp:TextBox ID="TextSanSangLamViec" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox" runat="server" />
                            </div>
                            <%--<div class="col-sm-4 col-md-1 col-lg-2">
                                <asp:TextBox ID="TextSanSangLamViec" runat="server" MaxLength="250" CssClass="TextBox" placeholder="..."/>
                                <span class="ms">tháng</span>
                            </div>--%>
                        </asp:Panel>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="drSanSangLamViec" />
                    </Triggers>

                </asp:UpdatePanel>
            </div>
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Hình thức tuyển dụng
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4 col-md-3 col-lg-2 lb">Hình thức <sup class="txt-red">*</sup></div>
                <div class="col-sm-8 col-md-9 col-lg-4">
                    <asp:DropDownList ID="drHinhThucTuyenDung" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker validate[required]" runat="server" />
                    <span class="required"></span>
                    <asp:HiddenField ID="HidHinhThucTuyenDung" runat="server" />
                </div>

            </div>
            <div class="row">
    <div class="title5">
        <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin người tham khảo
    </div>
</div>
<div class="row">
    <table border="1" class="tbl">
        <tr>
           <td  width="5%" class="hdTitle center">STT</td> 
        <td  width="12%"class="hdTitle">Họ tên</td>
        <td width="12%" class="hdTitle">Chức vụ</td>
        <td class="hdTitle">Nơi công tác</td>
        <td width="12%" class="hdTitle">Số điện thoại</td>
        <td width="12%" class="hdTitle">Email</td>
        <td width="12%" class="hdTitle">Mối quan hệ</td>
        <td width="5%" class="hdTitle center"><i class="fa fa-trash"></i></td>
        </tr>
        <tr>
           <td class="">1</td> 
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_HoTen"></asp:TextBox>
            <asp:HiddenField runat="server" ID="HF_NTK1_ID" Value="0" Visible="false"/>
        </td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_ChucVu"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_NoiCongTac"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_SoDienThoai"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_Email"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_MoiQuanHe"></asp:TextBox></td> 
            <td class=""><asp:LinkButton ToolTip="Xóa người tham khảo" runat="server" ID="btnXoa1" OnClick="btnXoa1_Click" CssClass="btn btn-danger"><i class="fa fa-trash"></i></asp:LinkButton></td>
        </tr>
        <tr>
           <td class="">2</td> 
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_HoTen"></asp:TextBox>
            <asp:HiddenField runat="server" ID="HF_NTK2_ID" Value="0" Visible="false"/>

        </td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_ChucVu"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_NoiCongTac"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_SoDienThoai"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_Email"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_MoiQuanHe"></asp:TextBox></td>
            <td class=""><asp:LinkButton ToolTip="Xóa người tham khảo" runat="server" ID="btnXoa2" OnClick="btnXoa2_Click" CssClass="btn btn-danger"><i class="fa fa-trash"></i></asp:LinkButton></td>
        </tr>
        <tr>
           <td class="">3</td> 
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK3_HoTen"></asp:TextBox>
            <asp:HiddenField runat="server" ID="HF_NTK3_ID" Value="0" Visible="false"/>

        </td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK3_ChucVu"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK3_NoiCongTac"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK3_SoDienThoai"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK3_Email"></asp:TextBox></td>
        <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK3_MoiQuanHe"></asp:TextBox></td>
            <td class=""><asp:LinkButton ToolTip="Xóa người tham khảo" runat="server" ID="btnXoa3" OnClick="btnXoa3_Click" CssClass="btn btn-danger"><i class="fa fa-trash"></i></asp:LinkButton></td>
        </tr>
    </table>
</div>
    <div class="clr clUp "></div>
    <asp:Literal ID="litUpdate" runat="server" />
</div>
        <asp:HiddenField ID="HF_ID" runat="server" Visible="true" />
        <asp:HiddenField ID="HF_CreatedDate" runat="server" Visible="true" />
<asp:HiddenField ID="ItemID" runat="server" Visible="true" />
<asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
<asp:HiddenField ID="HidTinhTP" runat="server" />
<asp:HiddenField ID="HidTinhTP2" runat="server" />
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="getMultiple(); return $('#Form').validationEngine('validate');" />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');" />
    </div>
</div>
<script type="text/javascript">
    function setMultiple() {
        var values = $('#<%= HidTinhTP.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $('#<%= TinhTPMulti.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= TinhTPMulti.ClientID%>").trigger('selectpicker:updated');
        });
        var values = $('#<%= HidTinhTP2.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $('#<%= TinhTPMulti2.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= TinhTPMulti2.ClientID%>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidQuanHuyen.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $('#<%= QuanHuyen.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= QuanHuyen.ClientID%>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidQuanHuyen2.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $('#<%= QuanHuyen2.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= QuanHuyen2.ClientID%>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidPhucLoi.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drPhucLoi.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drPhucLoi.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidXeDuaDon.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drXeDuaDon.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drXeDuaDon.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidPhucLoiKhac.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drPhucLoiKhac.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drPhucLoiKhac.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidLoaiHinhDoanhNghiep.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drLoaiHinhDoanhNghiep.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drLoaiHinhDoanhNghiep.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidHinhThucTuyenDung.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drHinhThucTuyenDung.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drHinhThucTuyenDung.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidContractType.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=ContractType_Option.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=ContractType_Option.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidTypeOf.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=TypeOf_ID.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=TypeOf_ID.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidMucDich.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=MucDich_ID.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=MucDich_ID.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidHoTroAn.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drHoTroAn.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drHoTroAn.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidNoiLamViec.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drNoiLamViec.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drNoiLamViec.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidNoiLamViecTrongLuong.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drNoiLamViecTrongLuong.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drNoiLamViecTrongLuong.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidNoiLamViecTrongLuong.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drNoiLamViecTrongLuong.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drNoiLamViecTrongLuong.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidNoiLamViecDiLai.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drNoiLamViecDiLai.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drNoiLamViecDiLai.ClientID %>").trigger('selectpicker:updated');
        });

        values = $('#<%= HidNoiLamViecNgheNoi.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drNoiLamViecNgheNoi.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drNoiLamViecNgheNoi.ClientID %>").trigger('selectpicker:updated');
        });

        values = $('#<%= HidNoiLamViecThiLuc.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drNoiLamViecThiLuc.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drNoiLamViecThiLuc.ClientID %>").trigger('selectpicker:updated');
        });

        values = $('#<%= HidNoiLamViecThaoTacBangTay.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drNoiLamViecThaoTacBangTay.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drNoiLamViecThaoTacBangTay.ClientID %>").trigger('selectpicker:updated');
        });

        values = $('#<%= HidNoiLamViecDung2Tay.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=drNoiLamViecDung2Tay.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=drNoiLamViecDung2Tay.ClientID %>").trigger('selectpicker:updated');
        });

    };
    function getMultiple() {
        $('#<%=HidTinhTP.ClientID%>').val($("#<%= TinhTPMulti.ClientID%>").val());
        $('#<%=HidTinhTP2.ClientID%>').val($("#<%= TinhTPMulti2.ClientID%>").val());
        $('#<%=HidQuanHuyen.ClientID%>').val($("#<%= QuanHuyen.ClientID%>").val());
        $('#<%=HidQuanHuyen2.ClientID%>').val($("#<%= QuanHuyen2.ClientID%>").val());
        $('#<%=HidPhucLoi.ClientID%>').val($("#<%=drPhucLoi.ClientID %>").val());
        $('#<%=HidXeDuaDon.ClientID%>').val($("#<%=drXeDuaDon.ClientID %>").val());
        $('#<%=HidPhucLoiKhac.ClientID%>').val($("#<%=drPhucLoiKhac.ClientID %>").val());
        $('#<%=HidHinhThucTuyenDung.ClientID%>').val($("#<%=drHinhThucTuyenDung.ClientID %>").val());
        $('#<%=HidLoaiHinhDoanhNghiep.ClientID%>').val($("#<%= drLoaiHinhDoanhNghiep.ClientID%>").val());
        $('#<%=HidContractType.ClientID%>').val($("#<%= ContractType_Option.ClientID%>").val());
        $('#<%=HidTypeOf.ClientID%>').val($("#<%= TypeOf_ID.ClientID%>").val());
        $('#<%=HidMucDich.ClientID%>').val($("#<%= MucDich_ID.ClientID%>").val());
        $('#<%=HidHoTroAn.ClientID%>').val($("#<%= drHoTroAn.ClientID%>").val());

        $('#<%=HidNoiLamViec.ClientID%>').val($("#<%= drNoiLamViec.ClientID%>").val());
        $('#<%=HidNoiLamViecTrongLuong.ClientID%>').val($("#<%= drNoiLamViecTrongLuong.ClientID%>").val());
        $('#<%=HidNoiLamViecDiLai.ClientID%>').val($("#<%= drNoiLamViecDiLai.ClientID%>").val());
        $('#<%=HidNoiLamViecNgheNoi.ClientID%>').val($("#<%= drNoiLamViecNgheNoi.ClientID%>").val());
        $('#<%=HidNoiLamViecThiLuc.ClientID%>').val($("#<%= drNoiLamViecThiLuc.ClientID%>").val());
        $('#<%=HidNoiLamViecThaoTacBangTay.ClientID%>').val($("#<%= drNoiLamViecThaoTacBangTay.ClientID%>").val());
        $('#<%=HidNoiLamViecDung2Tay.ClientID%>').val($("#<%= drNoiLamViecDung2Tay.ClientID%>").val());
    };
</script>
