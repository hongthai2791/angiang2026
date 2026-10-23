<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="DK_KBVL.ascx.vb" Inherits="DesktopModules.Modules.HomePage" %>
<%@ Register Src="~/admin/Captcha/VbCapchar.ascx" TagPrefix="uc1" TagName="VbCapchar" %>

<div class="hs-bhtn">
    <div class="row">
        <div class="col-md-12">
            <h1 class="box-title mgbt0 pdbt0">THÔNG BÁO VỀ VIỆC TÌM KIẾM VIỆC LÀM </h1>
        </div>
        <div class="col-md-12">
            <div class="col-md-7 txt-right pdt5">Tháng hưởng trợ cấp thất nghiệp thứ</div>
            <div class="col-md-1">
                <asp:TextBox ID="ThangHuong" runat="server" onkeypress="return keydownfocus(event,'drPortal',0);" CssClass="TextBox HoTen validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="clear"></div>
        </div>
    </div>
    <asp:UpdatePanel runat="server" ID="UP1">
        <ContentTemplate>
            <div class="row">
                <div class="col-md-2 pdt5">Kính gửi</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drPortal" runat="server" onchange="changefocus(this);" inext="HoTen" CssClass="drPortal selectpicker validate[required]"></asp:DropDownList>
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
                    <asp:TextBox ID="NgaySinh" placeholder="dd/mm/yyyy" MaxLength="10" runat="server" onkeypress="return keydownfocus(event,'GioiTinh',0);" CssClass="NgaySinh datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
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
                    <asp:TextBox ID="NgayCap" placeholder="dd/mm/yyyy" MaxLength="10" runat="server" onkeypress="return keydownfocus(event,'CO_TinhTP',0);" CssClass="NgayCap datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>

            <div class="row none">
                <div class="col-md-2 pdt5">Chỗ ở hiện nay</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="CO_TinhTP" inext="CO_QuanHuyen" runat="server" CssClass="selectpicker CO_TinhTP validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="CO_QuanHuyen" inext="CO_XaPhuong" runat="server" CssClass="selectpicker CO_QuanHuyen validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-4">
                    <asp:DropDownList ID="CO_XaPhuong" onchange="changefocus(this);" inext="CO_DuongPho" runat="server" CssClass="selectpicker CO_XaPhuong validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Địa chỉ</div>
                <div class="col-md-4">
                    <asp:TextBox ID="CO_DuongPho" runat="server" onkeypress="return keydownfocus(event,'DienThoai',0);" placeholder="Địa chỉ chi tiết" CssClass="required TextBox CO_DuongPho validate[required]"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 txt-right">Điện thoại</div>
                <div class="col-md-2">
                    <asp:TextBox ID="DienThoai" runat="server" onkeypress="return keydownfocus(event,'QD_Ngay',0);" CssClass="TextBox DienThoai validate[required, minSize[10]]" MaxLength="10"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right">Email</div>
                <div class="col-md-2">
                    <asp:TextBox ID="Email" runat="server" onkeypress="return keydownfocus(event,'DienThoai',0);" CssClass="TextBox Email validate[required, custom[email]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Theo Quyết định số</div>
                <div class="col-md-2">
                    <asp:TextBox ID="QD_So" runat="server" onkeypress="return keydownfocus(event,'QD_Ngay',0);" CssClass="TextBox QD_So validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 txt-right">Ngày ký QĐ</div>
                <div class="col-md-2">
                    <asp:TextBox placeholder="dd/mm/yyyy" MaxLength="10"  data-mask="00/00/0000" ID="QD_Ngay" runat="server" onkeypress="return keydownfocus(event,'QD_ThangHuong',0);" CssClass="QD_Ngay datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 txt-right">Hưởng trợ cấp</div>
                <div class="col-md-1">
                    <asp:TextBox ID="QD_ThangHuong" runat="server" onkeypress="return keydownfocus(event,'QD_TuNgay',0);" CssClass="TextBox QD_ThangHuong validate[required, custom[integer]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5">
                    (tháng)
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Hưởng từ ngày</div>
                <div class="col-md-2">
                    <asp:TextBox placeholder="dd/mm/yyyy" MaxLength="10"   ID="QD_TuNgay" runat="server" onkeypress="return keydownfocus(event,'QD_DenNgay',0);" CssClass="QD_TuNgay datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 txt-right">Đến hết ngày</div>
                <div class="col-md-2">
                    <asp:TextBox ID="QD_DenNgay" placeholder="dd/mm/yyyy" MaxLength="10"  runat="server" onkeypress="return keydownfocus(event,'QD_TinhTP',0);" CssClass="QD_DenNgay datemask TextBox validate[custom[datepicker]]"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 txt-right">Tại</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="QD_TinhTP" onchange="changefocus(this);" inext="TinhTrang" runat="server" CssClass="selectpicker QD_TinhTP validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>

                <div class="clear"></div>
            </div>
            <div class="col-md-3 pdt5">Tình trạng việc làm hiện nay:</div>
            <div class="col-md-9">
                <asp:CheckBox ID="TinhTrang" GroupName="A" runat="server" Text="Không có việc làm" CssClass="CheckBox TinhTrang" />
            </div>
            <div class="clear"></div>
            <div class="col-md-12">
                <asp:TextBox ID="NeuCoVL" onkeypress="return keydownfocus(event,'cmsbtnew',0);" placeHolder="Có việc làm nhưng chưa giao kết HĐLĐ/HĐLV (ghi rõ tên đơn vị, địa chỉ, công việc đang làm)" runat="server" CssClass="TextBox NeuCoVL" />
            </div>
            <div class="clear"></div>
            <div class="col-md-12">
                <asp:TextBox ID="TT_Khac" onkeypress="return keydownfocus(event,'cmsbtnew',0);" placeHolder="Tình trạng khác (ốm đau, thai sản,…)" runat="server" CssClass="TextBox TT_Khac" />
            </div>
            <div class="clear"></div>
            <div class="col-md-12 pdt5">Tôi thông báo kết quả tìm kiếm việc làm theo quy định, cụ thể như sau:</div>
            <div class="col-md-12">
                <asp:DataGrid ID="grdData" runat="server" CssClass="table-bordered respo-table table-pd0" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                    <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                    <ItemStyle BackColor="#e9f7ff" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderText="STT">
                            <ItemTemplate>
                                <asp:TextBox ID="IsOrder" ReadOnly="true" runat="server" CssClass="TextBox txt-center " />
                            </ItemTemplate>
                            <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                            <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Tên đơn vị">
                            <ItemTemplate>
                                <asp:TextBox ID="TenDonVi" runat="server" CssClass="TextBox " />
                                <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="column-primary" />
                            <HeaderStyle CssClass="column-primary" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Địa chỉ">
                            <ItemTemplate>
                                <asp:TextBox ID="DiaChi" runat="server" CssClass="TextBox " />
                            </ItemTemplate>
                            <ItemStyle Width="30%" CssClass="DiaChi respo-view" />
                            <HeaderStyle Width="30%" CssClass="DiaChi respo-title" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Người liên hệ">
                            <ItemTemplate>
                                <asp:TextBox ID="NguoiLienHe" runat="server" CssClass="TextBox " />
                            </ItemTemplate>
                            <ItemStyle Width="15%" CssClass="NguoiLienHe respo-view" />
                            <HeaderStyle Width="15%" CssClass="NguoiLienHe respo-title" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Vị trí dự tuyển">
                            <ItemTemplate>
                                <asp:TextBox ID="ViTriDuTuyen" runat="server" CssClass="TextBox " />
                            </ItemTemplate>
                            <ItemStyle Width="15%" CssClass="ViTriDuTuyen respo-view" />
                            <HeaderStyle Width="15%" CssClass="ViTriDuTuyen respo-title" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Kết quả">
                            <ItemTemplate>
                                <asp:TextBox ID="KetQua" runat="server" CssClass="TextBox " />
                            </ItemTemplate>
                            <ItemStyle Width="10%" CssClass="KetQua respo-view" />
                            <HeaderStyle Width="10%" CssClass="KetQua respo-title" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Xóa">
                            <ItemTemplate>
                                <asp:Literal ID="IsDelete" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="50px" HorizontalAlign="Center" CssClass="IsDelete respo-title" />
                            <ItemStyle Width="50px" HorizontalAlign="Center" CssClass="IsDelete respo-view" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
                <table cellspacing="0" id="tblRow1" runat="server" cellpadding="3" border="0" style="width: 100%; border-collapse: collapse; border-top: 0px!important">
                    <tbody>
                        <tr style="border-top: 0px!important; background: #fff;">
                            <td style="border-top: 0px!important; text-align: center; font-weight: bold;"></td>
                            <td style="border-top: 0px!important; text-align: center; width: 50px">
                                <asp:Button ID="cmdAdd" runat="server" ToolTip="Thêm dòng" CssClass="cmsbut-td cmsbtnew" OnClientClick="return $('#Form').validationEngine('detach');" />
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="CO_TinhTP" />
            <asp:AsyncPostBackTrigger ControlID="CO_QuanHuyen" />
            <asp:AsyncPostBackTrigger ControlID="cmdAdd" />
        </Triggers>
    </asp:UpdatePanel>
   
    <div class="row txt-center mgbt20 mgt20">
        <asp:Button ID="cmdSend" runat="server" CssClass="cmsbut cbtsend" Text="Nộp hồ sơ" OnClientClick="return $('#Form').validationEngine('validate');" />
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>

    <asp:HiddenField ID="ItemID" runat="server" Visible="false" />
    <asp:HiddenField ID="NoCode" runat="server" Visible="false" />