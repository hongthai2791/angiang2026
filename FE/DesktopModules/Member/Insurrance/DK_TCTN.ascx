<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="DK_TCTN.ascx.vb" Inherits="DesktopModules.Modules.HomePage" %>
<div class="hs-bhtn">
    <div class="row">
        <div class="col-md-12">
            <h1 class="box-title">Đăng ký hưởng trợ cấp thất nghiệp</h1>
            <asp:Label runat="server" ID="lbTrangThai"></asp:Label>
        </div>
    </div>
    <asp:UpdatePanel runat="server" ID="UP1" UpdateMode="Always">
        <ContentTemplate>
            <div class="row">
                <div class="col-md-2 pdt5">Kính gửi</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drPortal" AutoPostBack="true" runat="server" onchange="changefocus(this);" inext="HoTen" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Tên tôi là</div>
                <div class="col-md-4">
                    <asp:TextBox ID="HoTen" runat="server" onkeypress="return keydownfocus(event,'NgaySinh',0);" CssClass="TextBox HoTen validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Ngày sinh</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgaySinh" runat="server" onkeypress="return keydownfocus(event,'GioiTinh',0);" placeholder="dd/mm/yyyy" MaxLength="10" CssClass="NgaySinh datemask TextBox validate[required,custom[datepicker]] datepicker"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Giới tính</div>
                <div class="col-md-2 isSex">
                    <asp:DropDownList ID="GioiTinh" runat="server" onchange="changefocus(this);" inext="SoCMND" CssClass="selectpicker GioiTinh"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Số CMND/CCCD</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoCMND" runat="server" onkeypress="return keydownfocus(event,'NoiCap',0);" CssClass="TextBox SoCMND validate[required, minSize[9],maxSize[12]]" MaxLength="12"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Nơi cấp</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="NoiCap" runat="server" onchange="changefocus(this);" inext="NgayCap" CssClass="selectpicker NoiCap validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Ngày cấp</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgayCap" runat="server" onkeypress="return keydownfocus(event,'SoBHXH',0);" placeholder="dd/mm/yyyy" MaxLength="10" CssClass="NgayCap datemask TextBox validate[required,custom[datepicker]] datepicker"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Số sổ BHXN</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SoBHXH" runat="server" onkeypress="return keydownfocus(event,'Email',0);" CssClass="TextBox SoBHXH validate[required, minSize[10]]" MaxLength="10"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Email</div>
                <div class="col-md-5">
                    <asp:TextBox ID="Email" runat="server" onkeypress="return keydownfocus(event,'DienThoai',0);" CssClass="TextBox Email validate[required, custom[email]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>

            <div class="row">
                <div class="col-md-2 pdt5">Số điện thoại</div>
                <div class="col-md-4">
                    <asp:TextBox ID="DienThoai" runat="server" onkeypress="return keydownfocus(event,'DanToc',0);" CssClass="TextBox DienThoai validate[required,custom[phone], minSize[10]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Dân tộc</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="DanToc" runat="server" onchange="changefocus(this);" inext="TonGiao" CssClass="selectpicker DanToc"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Tôn giáo</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TonGiao" runat="server" onchange="changefocus(this);" inext="SoTaiKhoan" CssClass="selectpicker TonGiao"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">

                <div class="col-md-2 pdt5">Dịch vụ tư vấn</div>
                <div class="col-md-10">
                    <asp:DropDownList runat="server" ID="LoaiDVTV" CssClass="selectpicker DVTV"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="none">
                <div class="row">
                    <div class="col-md-2 pdt5">Số tài khoản</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="SoTaiKhoan" runat="server" onkeypress="return keydownfocus(event,'NganHang',0);" CssClass="TextBox SoTaiKhoan validate[minSize[10]]" MaxLength="10"></asp:TextBox>
                    </div>
                    <div class="col-md-2 pdt5 txt-right">Tại ngân hàng</div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="NganHang" runat="server" inext="ChiNhanhNH" CssClass="selectpicker NganHang" AutoPostBack="true"></asp:DropDownList>
                    </div>

                    <div class="clear"></div>
                </div>
                <div class="row">
                    <div class="col-md-2 pdt5">Mở tại chi nhánh</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ChiNhanhNH" runat="server" onchange="changefocus(this);" inext="TT_TinhTP" CssClass="selectpicker ChiNhanhNH"></asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row">
                    <div class="col-md-2 pdt5">Nơi thường trú</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="TT_TinhTP" runat="server" inext="TT_QuanHuyen" CssClass="selectpicker TT_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-3 pdl0  ">
                        <asp:DropDownList ID="TT_QuanHuyen" runat="server" inext="TT_XaPhuong" CssClass="selectpicker TT_QuanHuyen validate[required]" AutoPostBack="true"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 pdl0  ">
                        <asp:DropDownList ID="TT_XaPhuong" runat="server" AutoPostBack="true" CssClass="selectpicker TT_XaPhuong validate[required]"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-3 pdl0">
                        <asp:TextBox ID="TT_DuongPho" runat="server" onkeypress="return keydownfocus(event,'CO_TinhTP',0);" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="required TT_DuongPho TextBox"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row">
                    <div class="col-md-2 pdt5">Chỗ ở hiện nay</div>
                    <div class="col-md-2  ">
                        <asp:DropDownList ID="CO_TinhTP" runat="server" inext="CO_QuanHuyen" CssClass="selectpicker CO_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-3 pdl0  ">
                        <asp:DropDownList ID="CO_QuanHuyen" runat="server" inext="CO_XaPhuong" CssClass="selectpicker CO_QuanHuyen validate[required]" AutoPostBack="true"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 pdl0  ">
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
                    <div class="col-md-2 pdt5">Ngành nghề đào tạo</div>
                    <div class="col-md-5  ">
                        <asp:DropDownList ID="NganhDT" runat="server" onchange="changefocus(this);" inext="TrinhDo" CssClass="selectpicker NganhDT validate[required]"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-1 pdt5 txt-right pdr0 pdl0">Trình độ</div>
                    <div class="col-md-4  ">
                        <asp:DropDownList ID="TrinhDo" runat="server" onchange="changefocus(this);" inext="NgayNghiViec" CssClass="selectpicker TrinhDo"></asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row">
                    <div class="col-md-2 pdt5">Ngày nghỉ việc</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="NgayNghiViec" runat="server" onkeypress="return keydownfocus(event,'ThangDong',0);" placeholder="dd/mm/yyyy" MaxLength="10" CssClass="datemask TextBox NgayNghiViec validate[required,custom[datepicker]]"></asp:TextBox>
                        <span class="required"></span>

                    </div>
                    <div class="col-md-1 pdt5 txt-right pdr0 pdl0">Tháng đóng</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="ThangDong" runat="server" onkeypress="return keydownfocus(event,'LoaiHD',0);" CssClass="TextBox ThangDong validate[required, custom[integer]]"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-1 pdt5 txt-right pdr0 pdl0">Loại hợp đồng</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="LoaiHD" runat="server" onchange="changefocus(this);" inext="TenCT" CssClass="selectpicker LoaiHD"></asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row">
                    <div class="col-md-2 pdt5">Tên đơn vị</div>
                    <div class="col-md-7">
                        <asp:TextBox ID="TenCT" runat="server" onkeypress="return keydownfocus(event,'SoDKKD',0);" CssClass="TextBox TenCT validate[required]"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-1 pdt5 txt-right pdr0 pdl0">Số ĐKKD</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="SoDKKD" runat="server" onkeypress="return keydownfocus(event,'CT_TinhTP',0);" CssClass="TextBox SoDKKD "></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row">
                    <div class="col-md-2 pdt5">Địa chỉ đơn vị</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="CT_TinhTP" runat="server" inext="CT_QuanHuyen" CssClass="selectpicker CT_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-3 pdl0  ">
                        <asp:DropDownList ID="CT_QuanHuyen" runat="server" inext="CT_XaPhuong" CssClass="selectpicker CT_QuanHuyen validate[required]" AutoPostBack="true"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 pdl0  ">
                        <asp:DropDownList ID="CT_XaPhuong" runat="server" onchange="changefocus(this);" inext="CT_DuongPho" CssClass="selectpicker CT_XaPhuong validate[required]"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="col-md-3 pdl0">
                        <asp:TextBox ID="CT_DuongPho" runat="server" onkeypress="return keydownfocus(event,'NoiNhanTCTN',0);" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="CT_DuongPho TextBox"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row">
                    <div class="col-md-2 pdt5">Nơi nhận TCTN</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="NoiNhanTCTN" runat="server" onchange="changefocus(this);" inext="NoiDKKCB" CssClass="selectpicker NoiNhanTCTN"></asp:DropDownList>
                    </div>
                    <div class="col-md-2 pdt5 txt-right pdr0 pdl0">Nơi đăng ký KCB</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="NoiDKKCB" runat="server" onchange="changefocus(this);" inext="NguyenNhanNV" CssClass="selectpicker NoiDKKCB"></asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="CO_TinhTP" />
            <asp:AsyncPostBackTrigger ControlID="CO_QuanHuyen" />
            <asp:AsyncPostBackTrigger ControlID="TT_TinhTP" />
            <asp:AsyncPostBackTrigger ControlID="TT_QuanHuyen" />
            <asp:AsyncPostBackTrigger ControlID="NganHang" />
            <asp:AsyncPostBackTrigger ControlID="drPortal" />
            <asp:AsyncPostBackTrigger ControlID="CT_TinhTP" />
            <asp:AsyncPostBackTrigger ControlID="CT_QuanHuyen" />
        </Triggers>
    </asp:UpdatePanel>
    <div class="row none">
        <div class="col-md-2 pdt5  pdr0">Nguyên nhân nghỉ việc</div>
        <div class="col-md-10">
            <asp:DropDownList ID="NguyenNhanNV" runat="server" onchange="changefocus(this);" inext="NgheTruocNghi" CssClass="selectpicker NguyenNhanNV validate[required]"></asp:DropDownList>
            <span class="required"></span>
        </div>
    </div>
    <div class="row none">
        <div class="col-md-2 pdt5 pdr0">Nghề làm trước nghỉ việc</div>
        <div class="col-md-10">
            <asp:DropDownList ID="NgheTruocNghi" runat="server" onchange="changefocus(this);" inext="NganhTruocNghi" CssClass="selectpicker NgheTruocNghi"></asp:DropDownList>
            <span class="required"></span>
        </div>
        <div class="clear"></div>
    </div>
    <div class="row none">
        <div class="col-md-2 pdt5 pdr0">Ngành làm trước nghỉ việc</div>
        <div class="col-md-10">
            <asp:DropDownList ID="NganhTruocNghi" runat="server" onchange="changefocus(this);" inext="cbtsend" CssClass="selectpicker NganhTruocNghi validate[required]"></asp:DropDownList>
            <span class="required"></span>
        </div>
        <div class="clear"></div>
    </div>
    <div class="row none">
        <div class="col-md-2 pdt5">Tệp đính kèm</div>
        <div class="col-md-10">
            <div class="col-file">
                <asp:FileUpload ID="AttactFilePath" accept=".pdf,.jpg,.png" AllowMultiple="false" CssClass="none AttactFilePath" onchange="setValue(this,'AttactFilePath');" runat="server" />
                <div class="cmsbut cmsbtselect left" onclick="triggerUpload('AttactFilePath');">Chọn tệp .pdf,.jpg,.png</div>
                <div class="file-up AttactFilePath">
                    <asp:Literal ID="litUp" runat="server" />
                </div>
            </div>
        </div>
        <div class="clear"></div>
    </div>

</div>


<div class="row txt-center mgbt20 mgt20">
    <asp:Button ID="cmdSave" runat="server" CssClass="cmsbut cmdsave" Text="Lưu lại" OnClientClick="return $('#Form').validationEngine('validate');" />
    <asp:Button ID="cmdDelete" runat="server" CssClass="cmsbut cmsbtdel " Text="Hủy tư vấn" OnClientClick="return $('#Form').validationEngine('detach');" />
    <asp:Button ID="cmdSend" runat="server" CssClass="cmsbut cbtsend" Text="Nộp hồ sơ" OnClientClick="return $('#Form').validationEngine('validate');" />
       <asp:LinkButton  id="cmdPrint" runat="server" type="button" OnClientClick="popPdfPhieuHen(); return false"  CssClass="cmsbut cmsbtreturn">Tải phiếu hẹn</asp:LinkButton>

    <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
</div>

<asp:HiddenField ID="ItemID" runat="server"  />
<asp:HiddenField ID="NoCode" runat="server" Visible="false" />
<asp:HiddenField ID="TenTepDK" runat="server" Visible="false" />
<asp:HiddenField ID="DuongDanDK" runat="server" Visible="false" />
<script>

    function popPdfPhieuHen() {
        var pid = $("#<%=_pid%>").val();
        var ID = $("#<%=ItemID.ClientID%>").val();
        var dtype = ".docx";
        window.open("/api/insu/export.aspx?typeid=PHIEUHEN&pid=<%=_pid%>&ItemID=" + ID + "&dtype=" + dtype)
    };
</script>