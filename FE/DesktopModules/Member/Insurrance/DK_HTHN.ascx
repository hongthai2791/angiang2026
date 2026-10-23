<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="DK_HTHN.ascx.vb" Inherits="DesktopModules.Modules.HomePage" %>
<%@ Register Src="~/admin/Captcha/VbCapchar.ascx" TagPrefix="uc1" TagName="VbCapchar" %>

<div class="hs-bhtn">
    <div class="row">
        <div class="col-md-12">
            <h1 class="box-title">Hồ sơ đăng ký hỗ trợ học nghề </h1>
        </div>
    </div>
    <asp:UpdatePanel runat="server" ID="UP1">
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
                    <asp:TextBox ID="NgaySinh" placeholder="dd/mm/yyyy" MaxLength="10"  data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'GioiTinh',0);" CssClass="NgaySinh datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Giới tính</div>
                <div class="col-md-2">
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
                    <asp:TextBox ID="NgayCap" placeholder="dd/mm/yyyy" MaxLength="10"  data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'SoBHXH',0);" CssClass="NgayCap datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
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
                    <asp:DropDownList ID="TonGiao" onchange="changefocus(this);" inext="CO_TinhTP" runat="server" CssClass="selectpicker TonGiao"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Chỗ ở hiện nay</div>
                <div class="col-md-2 none ">
                    <asp:DropDownList ID="CO_TinhTP" inext="CO_QuanHuyen" runat="server" CssClass="selectpicker CO_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdl0  none ">
                    <asp:DropDownList ID="CO_XaPhuong" onchange="changefocus(this);" inext="CO_DuongPho" runat="server" CssClass="selectpicker CO_XaPhuong validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:TextBox ID="CO_DuongPho" runat="server" onkeypress="return keydownfocus(event,'ThangDong',0);" placeholder="Địa chỉ chi tiết" CssClass="required TextBox CO_DuongPho validate[required]"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>

            <div class="row none">
                <div class="col-md-2 pdt5">Số tháng đóng</div>
                <div class="col-md-4">
                    <asp:TextBox ID="ThangDong" runat="server" onkeypress="return keydownfocus(event,'ThangHuong',0);" CssClass="TextBox ThangDong validate[required, custom[integer]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 txt-right pdr0">Số tháng hưởng</div>
                <div class="col-md-4">
                    <asp:TextBox ID="ThangHuong" runat="server" onkeypress="return keydownfocus(event,'QDH_So',0);" CssClass="TextBox ThangHuong validate[required, custom[integer]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Số quyết định hưởng</div>
                <div class="col-md-2">
                    <asp:TextBox ID="QDH_So" runat="server" onkeypress="return keydownfocus(event,'QDH_TuNgay',0);" CssClass="TextBox QDH_So validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 txt-right">Được hưởng từ ngày</div>
                <div class="col-md-2">
                    <asp:TextBox placeholder="dd/mm/yyyy" MaxLength="10"  data-mask="00/00/0000" ID="QDH_TuNgay" runat="server" onkeypress="return keydownfocus(event,'QDH_DenNgay',0);" CssClass="QDH_TuNgay datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 txt-right">Hưởng đến hết ngày</div>
                <div class="col-md-2">
                    <asp:TextBox ID="QDH_DenNgay" placeholder="dd/mm/yyyy" MaxLength="10"  data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'CoSoDT',0);" CssClass="QDH_DenNgay datemask TextBox validate[custom[datepicker]]"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5">Cơ sở đào tạo</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="CoSoDT" runat="server" inext="KhoaDT" AutoPostBack="true" CssClass="selectpicker CoSoDT validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5 pdr0">Khóa đào tạo</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="KhoaDT" onchange="changefocus(this);" inext="ThoiGianDT" runat="server" CssClass="selectpicker KhoaDT validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5 pdr0">Thời gian đào tạo</div>
                <div class="col-md-1 pdr0">
                    <asp:TextBox ID="ThoiGianDT" runat="server" onkeypress="return keydownfocus(event,'HocPhi',0);" CssClass="TextBox ThoiGianDT"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5">(tháng)</div>
                <div class="col-md-1 pdt5 txt-right pdr0">Học phí</div>
                <div class="col-md-2">
                    <asp:TextBox ID="HocPhi" runat="server" onkeypress="return keydownfocus(event,'cbtsend',0);" CssClass="TextBox HocPhi"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5">(VNĐ)</div>
                <div class="clear"></div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="CO_TinhTP" />
            <asp:AsyncPostBackTrigger ControlID="CoSoDT" />
        </Triggers>
    </asp:UpdatePanel>
    
   
    <div class="row txt-center mgbt20 mgt20">
        <asp:Button ID="cmdSend" runat="server" CssClass="cmsbut cbtsend" Text="Nộp hồ sơ" OnClientClick="return $('#Form').validationEngine('validate');" />
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>

<asp:HiddenField ID="ItemID" runat="server" Visible="false" />
<asp:HiddenField ID="NoCode" runat="server" Visible="false" />
<asp:HiddenField ID="TenTepDK" runat="server" Visible="false" />
<asp:HiddenField ID="DuongDanDK" runat="server" Visible="false" />
