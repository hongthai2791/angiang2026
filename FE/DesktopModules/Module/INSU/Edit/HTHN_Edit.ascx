<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="HTHN_Edit.ascx.vb" Inherits="Modules.HTHN.Edit" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Hồ sơ đăng ký hỗ trợ học nghề</h3>
        </div>
        <div class="col-md-3 txt-center">
            <asp:Literal ID="NoCode" runat="server"></asp:Literal>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <asp:Panel runat="server" CssClass="main-body" Enabled="false">
            <div class="row">
                <div class="col-md-2 lb pdt5">Đơn vị xử lý</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drPortal" runat="server" onchange="changefocus(this);" inext="HoTen" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Tên tôi là</div>
                <div class="col-md-4">
                    <asp:TextBox ID="HoTen" runat="server" onkeypress="return keydownfocus(event,'NgaySinh',0);" CssClass="TextBox HoTen validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 lb pdt5 txt-center">Ngày sinh</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgaySinh" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'GioiTinh',0);" CssClass="NgaySinh TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 lb pdt5 txt-center">Giới tính</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="GioiTinh" runat="server" onchange="changefocus(this);" inext="SoCMND" CssClass="selectpicker GioiTinh"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Số CMND/CCCD</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoCMND" runat="server" onkeypress="return keydownfocus(event,'NoiCap',0);" CssClass="TextBox SoCMND validate[required, minSize[9],maxSize[12]]" MaxLength="12"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 lb pdt5 txt-center">Nơi cấp</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="NoiCap" runat="server" onchange="changefocus(this);" inext="NgayCap" CssClass="selectpicker NoiCap validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 lb pdt5 txt-center">Ngày cấp</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgayCap" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'SoBHXH',0);" CssClass="NgayCap TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Số sổ BHXN</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SoBHXH" runat="server" onkeypress="return keydownfocus(event,'Email',0);" CssClass="TextBox SoBHXH validate[required, minSize[10]]" MaxLength="10"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 lb pdt5 txt-center">Email</div>
                <div class="col-md-5">
                    <asp:TextBox ID="Email" runat="server" onkeypress="return keydownfocus(event,'DienThoai',0);" CssClass="TextBox Email validate[required, custom[email]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Số điện thoại</div>
                <div class="col-md-4">
                    <asp:TextBox ID="DienThoai" runat="server" onkeypress="return keydownfocus(event,'DanToc',0);" CssClass="TextBox DienThoai validate[required,custom[phone], minSize[10]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 lb pdt5 txt-center">Dân tộc</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="DanToc" runat="server" onchange="changefocus(this);" inext="TonGiao" CssClass="selectpicker DanToc"></asp:DropDownList>
                </div>
                <div class="col-md-1 lb pdt5 txt-center">Tôn giáo</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TonGiao" onchange="changefocus(this);" inext="CO_TinhTP" runat="server" CssClass="selectpicker TonGiao"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Chỗ ở hiện nay</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="CO_TinhTP" inext="CO_QuanHuyen" runat="server" CssClass="selectpicker CO_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="CO_QuanHuyen" inext="CO_XaPhuong" runat="server" CssClass="selectpicker CO_QuanHuyen validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="CO_XaPhuong" onchange="changefocus(this);" inext="CO_DuongPho" runat="server" CssClass="selectpicker CO_XaPhuong validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="CO_DuongPho" runat="server" onkeypress="return keydownfocus(event,'ThangDong',0);" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="required TextBox CO_DuongPho validate[required]"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>

            <div class="row">
                <div class="col-md-2 lb pdt5">Số tháng đóng</div>
                <div class="col-md-4">
                    <asp:TextBox ID="ThangDong" runat="server" onkeypress="return keydownfocus(event,'ThangHuong',0);" CssClass="TextBox ThangDong validate[required, custom[integer]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 lb pdt5 txt-center">Số tháng hưởng</div>
                <div class="col-md-4">
                    <asp:TextBox ID="ThangHuong" runat="server" onkeypress="return keydownfocus(event,'QDH_So',0);" CssClass="TextBox ThangHuong validate[required, custom[integer]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Số quyết định hưởng</div>
                <div class="col-md-2">
                    <asp:TextBox ID="QDH_So" runat="server" onkeypress="return keydownfocus(event,'QDH_TuNgay',0);" CssClass="TextBox QDH_So validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 lb pdt5 txt-center">Được hưởng từ ngày</div>
                <div class="col-md-2">
                    <asp:TextBox placeholder="dd/mm/yyyy" data-mask="00/00/0000" ID="QDH_TuNgay" runat="server" onkeypress="return keydownfocus(event,'QDH_DenNgay',0);" CssClass="QDH_TuNgay TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 lb pdt5 txt-center">Hưởng đến hết ngày</div>
                <div class="col-md-2">
                    <asp:TextBox ID="QDH_DenNgay" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'CoSoDT',0);" CssClass="QDH_DenNgay TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Cơ sở đào tạo</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="CoSoDT" runat="server" inext="KhoaDT" CssClass="selectpicker CoSoDT validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Khóa đào tạo</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="KhoaDT" onchange="changefocus(this);" inext="ThoiGianDT" runat="server" CssClass="selectpicker KhoaDT validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 lb pdt5">Thời gian đào tạo</div>
                <div class="col-md-1">
                    <asp:TextBox ID="ThoiGianDT" runat="server" onkeypress="return keydownfocus(event,'HocPhi',0);" CssClass="TextBox ThoiGianDT"></asp:TextBox>
                </div>
                <div class="col-md-1 lb pdt5">(tháng)</div>
                <div class="col-md-1 lb pdt5 txt-center">Học phí</div>
                <div class="col-md-2">
                    <asp:TextBox ID="HocPhi" runat="server" onkeypress="return keydownfocus(event,'cbtsend',0);" CssClass="TextBox HocPhi"></asp:TextBox>
                </div>
                <div class="col-md-1 lb pdt5">(VNĐ)</div>
                <div class="clear"></div>
            </div>

            <div class="row">
                <div class="col-md-2 lb pdt5">Tệp đính kèm</div>
                <div class="col-md-10">
                    <div class="col-file">
                        <div class="file-up AttactFilePath">
                            <asp:Literal ID="litUp" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </asp:Panel>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdActive" runat="server" Text="Tiếp nhận & Chuyển chuyên môn" CssClass="cmsbut cmsbtfinish" />
        <button id="cmdReturn" runat="server" type="button" data-toggle="modal" data-target="#frmBCLai" class="cmsbut cmsbtreturn">Trả lại hồ sơ</button>
        <asp:Button ID="cmdExport" runat="server" OnClientClick="popPdfHTHN(); return false" Text="Tải phiếu đăng ký" CssClass="cmsbut cmdpdf cbclick" />

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
    function popPdfHTHN() {
        var pid = $("#<%=_pid%>").val(); var ID = $("#<%=ItemID.ClientID%>").val(); var dtype = ".docx"
        window.open("/api/insu/export.aspx?typeid=HTHN&pid=<%=_pid%>&ItemID=" + ID + "&dtype=" + dtype)
    };
    function tralai() {
        if ($("#<%=txtContent.ClientID%>").val() == "") { notify('info', 'Lý do trả lại không được trống.', 'Thông báo', false); return false; }
        else {
            var lydo = $("#<%=txtContent.ClientID%>").val(), id = $("#<%=ItemId.ClientID%>").val(), pid = "<%=_pid%>";
            if ((lydo != "") && (lydo != undefined)) { lydo = Base64.encode(lydo); }
            $.ajax({
                type: "GET", url: '/api/insu/common.asmx/traLai?pid=' + pid + "&id=" + id + "&lydo=" + lydo + "&type=Notification", success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data == "1") { notify('success', 'Đã gửi yêu cầu trả lại thành công.', 'Thông báo', false); backend('<%=ViewState("backUrl")%>'); }
                    else { notify('info', 'Có lỗi trong quá trình kết nối API.', 'Thông báo', false); };
                },
            });
        };
        $('#frmBCLai').modal('hide');
    };
</script>
