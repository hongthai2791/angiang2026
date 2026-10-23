<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="TCTN_Edit.ascx.vb" Inherits="Modules.TCTN.Edit" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">HỒ SƠ ĐĂNG KÝ HƯỞNG TRỢ CẤP THẤT NGHIỆP</h3>
        </div>
        <div class="col-md-3 txt-center">
            <asp:Literal ID="NoCode" runat="server"></asp:Literal>
            <asp:HiddenField  ID="HidNoCode" runat="server"></asp:HiddenField>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <asp:Panel runat="server" CssClass="main-body" >
            <div class="row">
                <div class="col-md-2 pdt5 lb">Đơn vị xử lý</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drPortal" runat="server" onchange="changefocus(this);" inext="HoTen" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Tên tôi là</div>
                <div class="col-md-4">
                    <asp:TextBox ID="HoTen" runat="server" onkeypress="return keydownfocus(event,'NgaySinh',0);" CssClass="TextBox HoTen validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Ngày sinh</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgaySinh" runat="server" onkeypress="return keydownfocus(event,'GioiTinh',0);" placeholder="dd/mm/yyyy" data-mask="00/00/0000" CssClass="NgaySinh TextBox validate[required,custom[datepicker]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Giới tính</div>
                <div class="col-md-2 isSex">
                    <asp:DropDownList ID="GioiTinh" runat="server" onchange="changefocus(this);" inext="SoCMND" CssClass="selectpicker GioiTinh"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Số CMND/CCCD</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoCMND" runat="server" onkeypress="return keydownfocus(event,'NoiCap',0);" CssClass="TextBox SoCMND validate[required, minSize[9],maxSize[12]]" MaxLength="12"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Nơi cấp</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="NoiCap" runat="server" onchange="changefocus(this);" inext="NgayCap" CssClass="selectpicker NoiCap validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Ngày cấp</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgayCap" runat="server" onkeypress="return keydownfocus(event,'SoBHXH',0);" placeholder="dd/mm/yyyy" data-mask="00/00/0000" CssClass="NgayCap TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Số sổ BHXN</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SoBHXH" runat="server" onkeypress="return keydownfocus(event,'Email',0);" CssClass="TextBox SoBHXH validate[required, minSize[10]]" MaxLength="10"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Email</div>
                <div class="col-md-5">
                    <asp:TextBox ID="Email" runat="server" onkeypress="return keydownfocus(event,'DienThoai',0);" CssClass="TextBox Email validate[required, custom[email]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Số điện thoại</div>
                <div class="col-md-4">
                    <asp:TextBox ID="DienThoai" runat="server" onkeypress="return keydownfocus(event,'DanToc',0);" CssClass="TextBox DienThoai validate[required,custom[phone], minSize[10]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Dân tộc</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="DanToc" runat="server" onchange="changefocus(this);" inext="TonGiao" CssClass="selectpicker DanToc"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Tôn giáo</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TonGiao" runat="server" onchange="changefocus(this);" inext="SoTaiKhoan" CssClass="selectpicker TonGiao"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="none">

            <div class="row">
                <div class="col-md-2 pdt5 lb">Số tài khoản</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoTaiKhoan" runat="server" onkeypress="return keydownfocus(event,'NganHang',0);" CssClass="TextBox SoTaiKhoan validate[minSize[10]]" MaxLength="10"></asp:TextBox>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Tại ngân hàng</div>
                <div class="col-md-6">
                    <asp:DropDownList ID="NganHang" runat="server" inext="ChiNhanhNH" CssClass="selectpicker NganHang" AutoPostBack="true"></asp:DropDownList>
                </div>

                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Mở tại chi nhánh</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ChiNhanhNH" runat="server" onchange="changefocus(this);" inext="TT_TinhTP" CssClass="selectpicker ChiNhanhNH"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Nơi thường trú</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TT_TinhTP" runat="server" inext="TT_QuanHuyen" CssClass="selectpicker TT_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:DropDownList ID="TT_QuanHuyen" runat="server" inext="TT_XaPhuong" CssClass="selectpicker TT_QuanHuyen validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdl0">
                    <asp:DropDownList ID="TT_XaPhuong" runat="server" CssClass="selectpicker TT_XaPhuong validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:TextBox ID="TT_DuongPho" runat="server" onkeypress="return keydownfocus(event,'CO_TinhTP',0);" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="required TT_DuongPho TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Chỗ ở hiện nay</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="CO_TinhTP" runat="server" inext="CO_QuanHuyen" CssClass="selectpicker CO_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:DropDownList ID="CO_QuanHuyen" runat="server" inext="CO_XaPhuong" CssClass="selectpicker CO_QuanHuyen validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdl0">
                    <asp:DropDownList ID="CO_XaPhuong" runat="server" onchange="changefocus(this);" inext="CO_DuongPho" CssClass="selectpicker CO_XaPhuong validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:TextBox ID="CO_DuongPho" runat="server" onkeypress="return keydownfocus(event,'NganhDT',0);" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="TextBox CO_DuongPho validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Ngành nghề đào tạo</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="NganhDT" runat="server" onchange="changefocus(this);" inext="TrinhDo" CssClass="selectpicker NganhDT validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Trình độ đào tạo</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="TrinhDo" runat="server" onchange="changefocus(this);" inext="NgayNghiViec" CssClass="selectpicker TrinhDo"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Ngày nghỉ việc</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgayNghiViec" runat="server" onkeypress="return keydownfocus(event,'ThangDong',0);" placeholder="dd/mm/yyyy" data-mask="00/00/0000" CssClass="datemask TextBox NgayNghiViec validate[required]"></asp:TextBox>
                    <span class="required"></span>

                </div>
                <div class="col-md-2 pdt5 lb txt-center">Tháng đóng</div>
                <div class="col-md-1">
                    <asp:TextBox ID="ThangDong" runat="server" onkeypress="return keydownfocus(event,'LoaiHD',0);" CssClass="TextBox ThangDong validate[required, custom[integer]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Loại hợp đồng</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="LoaiHD" runat="server" onchange="changefocus(this);" inext="TenCT" CssClass="selectpicker LoaiHD"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Tên đơn vị</div>
                <div class="col-md-7">
                    <asp:TextBox ID="CongTy" runat="server" onkeypress="return keydownfocus(event,'SoDKKD',0);" CssClass="TextBox TenCT validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Số ĐKKD</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoDKKD" runat="server" onkeypress="return keydownfocus(event,'CT_TinhTP',0);" CssClass="TextBox SoDKKD"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Địa chỉ đơn vị</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="CT_TinhTP" runat="server" inext="CT_QuanHuyen" CssClass="selectpicker CT_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:DropDownList ID="CT_QuanHuyen" runat="server" inext="CT_XaPhuong" CssClass="selectpicker CT_QuanHuyen validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdl0">
                    <asp:DropDownList ID="CT_XaPhuong" runat="server" onchange="changefocus(this);" inext="CT_DuongPho" CssClass="selectpicker CT_XaPhuong validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:TextBox ID="CT_DuongPho" runat="server" onkeypress="return keydownfocus(event,'NoiNhanTCTN',0);" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="CT_DuongPho TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Nơi nhận TCTN</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="NoiNhanTCTN" runat="server" onchange="changefocus(this);" inext="NoiDKKCB" CssClass="selectpicker NoiNhanTCTN"></asp:DropDownList>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Nơi đăng ký KCB</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="NoiDKKCB" runat="server" onchange="changefocus(this);" inext="NguyenNhanNV" CssClass="selectpicker NoiDKKCB"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb pdr0">Nguyên nhân nghỉ việc</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="NguyenNhanNV" runat="server" onchange="changefocus(this);" inext="NgheTruocNghi" CssClass="selectpicker NguyenNhanNV validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb pdr0">Nghề làm trước nghỉ việc</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="NgheTruocNghi" runat="server" onchange="changefocus(this);" inext="NganhTruocNghi" CssClass="selectpicker NgheTruocNghi"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb pdr0">Ngành làm trước nghỉ việc</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="NganhTruocNghi" runat="server" onchange="changefocus(this);" inext="cbtsend" CssClass="selectpicker NganhTruocNghi validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Tệp đính kèm</div>
                <div class="col-md-10">
                    <div class="col-file">
                        <div class="file-up AttactFilePath">
                            <asp:Literal ID="litUp" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
                
            </div>
        <asp:Panel runat="server" ID="pnPhieuHen">
            <div class="row">
                <div class="col-md-2 pdt5 lb">Ngày hẹn trả kết quả</div>
                <div class="col-md-2">
                    <asp:TextBox ID="_NgayHenTra" runat="server" onkeypress="return keydownfocus(event,'GioiTinh',0);" placeholder="dd/mm/yyyy" data-mask="00/00/0000" CssClass="NgaySinh TextBox validate[required,custom[datepicker]]"></asp:TextBox>
     
                </div>
                   <asp:LinkButton id="cmdPhieuHen" runat="server" type="button"   CssClass="cmsbut cmsbtupdate">Lập phiếu hẹn</asp:LinkButton>
    <asp:LinkButton  id="cmdPrint" runat="server" type="button" OnClientClick="popPdfPhieuHen(); return false"  CssClass="cmsbut cmsbtreturn">Tải phiếu hẹn</asp:LinkButton>

                <div class="clear"></div>
            </div>
        </asp:Panel>
        </asp:Panel>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdActive" runat="server" Text="Tiếp nhận " CssClass="cmsbut cmsbtfinish" />
        <button id="cmdReturn" runat="server" type="button" data-toggle="modal" data-target="#frmBCLai" class="cmsbut cmsbtreturn">Trả lại hồ sơ</button>
        <asp:Button ID="cmdExport"  runat="server" OnClientClick="popPdfTCTN(); return false" Text="Tải phiếu đăng ký" CssClass="cmsbut cmdpdf cbclick" />
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
    function showAppointmentModal(hoTen, ngayHen, gioHen, diaDiem, noiDung) {
        $("#appointmentModal").modal('show');
    }
    function popPdfTCTN() {
        var pid = $("#<%=_pid%>").val();
        var ID = $("#<%=ItemID.ClientID%>").val();
        var dtype = ".docx";
        window.open("/api/insu/export.aspx?typeid=TCTN&pid=<%=_pid%>&ItemID=" + ID + "&dtype=" + dtype)
    };
    function popPdfPhieuHen() {
        var pid = $("#<%=_pid%>").val();
        var ID = $("#<%=ItemID.ClientID%>").val();
        var dtype = ".docx";
        window.open("/api/insu/export.aspx?typeid=PHIEUHEN&pid=<%=_pid%>&ItemID=" + ID + "&dtype=" + dtype)
    };
    function tralai() {
        if ($("#<%=txtContent.ClientID%>").val() == "") { notify('info', 'Lý do trả lại không được trống.', 'Thông báo', false); return false; }
        else {
            var lydo = $("#<%=txtContent.ClientID%>").val(), id = $("#<%=ItemID.ClientID%>").val(), pid = "<%=_pid%>";
            if ((lydo != "") && (lydo != undefined)) { lydo = Base64.encode(lydo); }
            $.ajax({
                type: "GET", url: '/api/insu/common.asmx/traLai?pid=' + pid + "&id=" + id + "&lydo=" + lydo + "&type=ProSubsi", success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data == "1") { notify('success', 'Đã gửi yêu cầu trả lại thành công.', 'Thông báo', false); backend('<%=ViewState("backUrl")%>'); }
                    else { notify('info', 'Có lỗi trong quá trình kết nối API.', 'Thông báo', false); };
                },
            });
        };
        $('#frmBCLai').modal('hide');
    };
</script>
