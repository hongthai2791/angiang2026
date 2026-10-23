<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="TVGT_Edit.ascx.vb" Inherits="Modules.TVGT.Edit" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Hồ sơ đăng ký giới thiệu việc làm</h3>
        </div>
        <div class="col-md-3 txt-center">
            <asp:Literal ID="NoCode" runat="server"></asp:Literal>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <asp:Panel runat="server" CssClass="main-body" Enabled="false">
            <div class="row">
                <div class="col-md-2 pdt5 lb">Đơn vị xử lý</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drPortal" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Tên tôi là</div>
                <div class="col-md-4">
                    <asp:TextBox ID="HoTen" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Ngày sinh</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgaySinh" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" CssClass="NgaySinh TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Giới tính</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="GioiTinh" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Số CMND/CCCD</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoCMND" runat="server" CssClass="TextBox SoCMND validate[required, minSize[9],maxSize[12]]" MaxLength="12"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Nơi cấp</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="NoiCap" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Ngày cấp</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgayCap" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" CssClass="NgayCap TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Số sổ BHXN</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SoBHXH" runat="server" CssClass="TextBox validate[required, minSize[10]]" MaxLength="10"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Email</div>
                <div class="col-md-5">
                    <asp:TextBox ID="Email" runat="server" CssClass="TextBox validate[required, custom[email]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="none">
            <div class="row">
                <div class="col-md-2 pdt5 lb">Số điện thoại</div>
                <div class="col-md-4">
                    <asp:TextBox ID="DienThoai" runat="server" CssClass="TextBox validate[required,custom[phone], minSize[10]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Dân tộc</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="DanToc" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Tôn giáo</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TonGiao" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Số tài khoản</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoTaiKhoan" runat="server" CssClass="TextBox validate[minSize[10]]" MaxLength="10"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="NganHang" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-5">
                    <asp:DropDownList ID="ChiNhanhNH" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Nơi thường trú</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TT_TinhTP" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="TT_QuanHuyen" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TT_XaPhuong" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="TT_DuongPho" runat="server" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="required TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Chỗ ở hiện nay</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="CO_TinhTP" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="CO_QuanHuyen" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="CO_XaPhuong" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="CO_DuongPho" runat="server" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="required TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Sức khỏe</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SucKhoe" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Chiều cao</div>
                <div class="col-md-2">
                    <asp:TextBox ID="ChieuCao" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Cân nặng</div>
                <div class="col-md-2">
                    <asp:TextBox ID="CanNang" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Trình độ ngoại ngữ</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="NgoaiNgu" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Giáo dục phổ thông</div>
                <div class="col-md-2">
                    <asp:TextBox ID="GiaoDucPT" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Tin học</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="TinHoc" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Chuyên môn kỹ thuật</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="ChuyenMonKT" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 lb pdr0">Mức lương</div>
                <div class="col-md-2">
                    <asp:TextBox ID="MucLuong" runat="server" CssClass="TextBox MucLuong"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Lý do nghỉ</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="LyDoNghi" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Đã tìm việc tại</div>
                <div class="col-md-10">
                    <asp:TextBox ID="DaTimViecTai" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:DataGrid ID="grdAds" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                        <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                        <ItemStyle BackColor="#e9f7ff" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                                <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Chuyên ngành đào tạo">
                                <ItemTemplate>
                                    <asp:Literal ID="Specialized" runat="server" />
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                </ItemTemplate>
                                <ItemStyle CssClass="column-primary" />
                                <HeaderStyle CssClass="column-primary" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Trình độ chuyên môn kỹ thuật">
                                <ItemTemplate>
                                    <asp:Literal ID="LevelName" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="40%" CssClass="ChuyenMon respo-view" />
                                <HeaderStyle Width="40%" CssClass="ChuyenMon respo-title" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
                <div class="col-md-12">
                    <asp:DataGrid ID="grdAdc" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                        <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                        <ItemStyle BackColor="#e9f7ff" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                                <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tên đơn vị">
                                <ItemTemplate>
                                    <asp:Literal ID="Company" runat="server" />
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                </ItemTemplate>
                                <ItemStyle CssClass="column-primary" />
                                <HeaderStyle CssClass="column-primary" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Thời gian làm việc">
                                <ItemTemplate>
                                    <asp:Literal ID="TimeWork" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="20%" CssClass="ThoiGian respo-view" />
                                <HeaderStyle Width="20%" CssClass="ThoiGian respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Vị trí">
                                <ItemTemplate>
                                    <asp:Literal ID="Location" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="20%" CssClass="ViTri respo-view" />
                                <HeaderStyle Width="20%" CssClass="ViTri respo-title" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Kỹ năng nghề nghiệp</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="KyNangNghe" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Khả năng nổi trội</div>
                <div class="col-md-5">
                    <asp:TextBox ID="KhaNangNoiTroi" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
                </div>

            <div class="row box-info">
                <div class="none">

                <div class="col-md-12 boxtitle"><strong>Nhu cầu tư vấn, giới thiệu việc làm</strong></div>
                <div class="col-md-2"><strong>1. Tư vấn</strong></div>
                <div class="col-md-3">
                    <asp:CheckBox runat="server" Text="Chính sách, pháp luật về lao động" CssClass="CheckBox" ID="TuVan_ChinhSach" />
                </div>
                <div class="col-md-2">
                    <asp:CheckBox runat="server" Text="Việc làm" CssClass="CheckBox" ID="TuVan_ViecLam" />
                </div>
                <div class="col-md-3">
                    <asp:CheckBox runat="server" Text="Bảo hiểm thất nghiệp" CssClass="CheckBox" ID="TuVan_BHTN" />
                </div>
                <div class="col-md-1">
                    <asp:CheckBox runat="server" Text="Khác" CssClass="CheckBox" ID="TuVan_Khac" />
                </div>
                <div class="clear"></div>
                <div class="col-md-12"><strong>2. Giới thiệu việc làm</strong></div>
                <div class="clear"></div>
                    
                </div>
                <div class="col-md-2 pdt5 lb">Vị trí việc làm</div>
                <div class="col-md-3">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_ViTri"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Mức lương</div>
                <div class="col-md-2">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_MucLuong"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Công việc</div>
                <div class="col-md-3">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_CongViec"></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 pdt5 lb">Nơi làm việc</div>
                <div class="col-md-3">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_TinhTP" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_QuanHuyen"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Loại hình</div>
                <div class="col-md-3">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_LoaiHinh"></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 pdt5 lb">Điều kiện làm việc</div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="TextBox" runat="server" ID="GT_DieuKien"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Khác</div>
                <div class="col-md-4">
                    <asp:TextBox CssClass="TextBox" runat="server" ID="GT_Khac"></asp:TextBox>
                </div>
            </div>
        </asp:Panel>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdActive" runat="server" Text="Tiếp nhận" CssClass="cmsbut cmsbtfinish" />
        <button id="cmdReturn" runat="server" type="button" data-toggle="modal" data-target="#frmBCLai" class="cmsbut cmsbtreturn">Trả lại hồ sơ</button>
        <asp:Button ID="cmdExport" runat="server" OnClientClick="popPdfTVGT(); return false" Text="Tải phiếu đăng ký" CssClass="cmsbut cmdpdf cbclick" />

        <div class="clear"></div>
    </div>
</div>
<asp:HiddenField ID="ItemID" runat="server" />
<div class="modal fade " id="frmBCLai" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-md">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Trả lại hồ sơ</h5>
            </div>
            <div class="moda-body">
                <div class="col-md-12">Nhập lý do trả lại:</div>
                <div class="col-md-12">
                    <asp:TextBox ID="txtContent" TextMode="MultiLine" runat="server" Height="200" Width="100%"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng lại</button>
                <button type="button" onclick="tralai();" class="btn btn-primary">Gửi yêu cầu</button>
            </div>
        </div>
    </div>
</div>

<script type="text/javascript">
    function popPdfTVGT() {
        var pid = $("#<%=_pid%>").val();
        var ID = $("#<%=ItemID.ClientID%>").val();
        var dtype = ".docx";
        window.open("/api/insu/export.aspx?typeid=TVGT&pid=<%=_pid%>&ItemID=" + ID + "&dtype=" + dtype)
    };
    function tralai() {
        if ($("#<%=txtContent.ClientID%>").val() == "") { notify('info', 'Lý do trả lại không được trống.', 'Thông báo', false); return false; }
        else {
            var lydo = $("#<%=txtContent.ClientID%>").val(), id = $("#<%=ItemID.ClientID%>").val(), pid = "<%=_pid%>";
            if ((lydo != "") && (lydo != undefined)) { lydo = Base64.encode(lydo); }
            $.ajax({
                type: "GET", url: '/api/insu/common.asmx/traLai?pid=' + pid + "&id=" + id + "&lydo=" + lydo + "&type=Advisory", success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data == "1") { notify('success', 'Đã gửi yêu cầu trả lại thành công.', 'Thông báo', false); backend('<%=ViewState("backUrl")%>'); }
                    else { notify('info', 'Có lỗi trong quá trình kết nối API.', 'Thông báo', false); };
                },
            });
        };
        $('#frmBCLai').modal('hide');
    };
</script>
