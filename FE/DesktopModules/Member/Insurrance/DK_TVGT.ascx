<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="DK_TVGT.ascx.vb" Inherits="DesktopModules.Modules.HomePage" %>
<div class="hs-bhtn">
    <div class="row">
        <div class="col-md-12">
            <div class="box-title">Đăng ký tư vấn - giới thiệu việc làm</div>
        </div>
    </div>
            <div class="row">
                <div class="col-md-2 pdt5">Kính gửi</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drPortal" AutoPostBack="true" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Tên tôi là</div>
                <div class="col-md-4">
                    <asp:TextBox ID="HoTen" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Ngày sinh</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgaySinh" placeholder="dd/mm/yyyy" MaxLength="10"  runat="server" CssClass="NgaySinh datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Giới tính</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="GioiTinh" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Số CMND/CCCD</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoCMND" runat="server" CssClass="TextBox SoCMND validate[required, minSize[9],maxSize[12]]" MaxLength="12"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Nơi cấp</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="NoiCap" runat="server" CssClass="selectpicker  validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Ngày cấp</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgayCap" placeholder="dd/mm/yyyy" MaxLength="10"   runat="server" CssClass="NgayCap datemask TextBox validate[required,custom[datepicker]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Số sổ BHXN</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SoBHXH" runat="server" CssClass="TextBox validate[required, minSize[10]]" MaxLength="10"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Email</div>
                <div class="col-md-5">
                    <asp:TextBox ID="Email" runat="server" CssClass="TextBox validate[required, custom[email]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Số điện thoại</div>
                <div class="col-md-4">
                    <asp:TextBox ID="DienThoai" runat="server" CssClass="TextBox validate[required,custom[phone], minSize[10]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Dân tộc</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="DanToc" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 txt-right pdr0">Tôn giáo</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TonGiao" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="none">

            <div class="row">
                <div class="col-md-2 pdt5">Số tài khoản</div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoTaiKhoan" runat="server" CssClass="TextBox validate[minSize[10]]" MaxLength="10"></asp:TextBox>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:DropDownList ID="NganHang" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-5 pdl0">
                    <asp:DropDownList ID="ChiNhanhNH" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                
    <asp:UpdatePanel runat="server" ID="UP1">
        <ContentTemplate>
                <div class="col-md-2 pdt5">Nơi thường trú</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TT_TinhTP" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0  ">
                    <asp:DropDownList ID="TT_QuanHuyen" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdl0  ">
                    <asp:DropDownList ID="TT_XaPhuong" runat="server" AutoPostBack="true" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:TextBox ID="TT_DuongPho" runat="server" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="required TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5">Chỗ ở hiện nay</div>
                <div class="col-md-2  ">
                    <asp:DropDownList ID="CO_TinhTP" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0  ">
                    <asp:DropDownList ID="CO_QuanHuyen" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdl0  ">
                    <asp:DropDownList ID="CO_XaPhuong" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdl0">
                    <asp:TextBox ID="CO_DuongPho" runat="server" placeholder="Thôn, tổ, đường phố, số nhà" CssClass="required TextBox"></asp:TextBox>
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
        </Triggers>
    </asp:UpdatePanel>
    <div class="row">
        <div class="col-md-2 pdt5">Sức khỏe</div>
        <div class="col-md-4  ">
            <asp:TextBox ID="SucKhoe" runat="server" CssClass="TextBox"></asp:TextBox>
        </div>
        <div class="col-md-1 pdt5 txt-right pdl0">Chiều cao</div>
        <div class="col-md-2 pdl0">
            <asp:TextBox ID="ChieuCao" runat="server" CssClass="TextBox"></asp:TextBox>
        </div>
        <div class="col-md-1 pdt5 txt-right pdr0 pdl0">Cân nặng</div>
        <div class="col-md-2">
            <asp:TextBox ID="CanNang" runat="server" CssClass="TextBox"></asp:TextBox>
        </div>
        <div class="clear"></div>
    </div>
    <div class="row">
        <div class="col-md-2 pdt5">Trình độ ngoại ngữ</div>
        <div class="col-md-3">
            <asp:DropDownList ID="NgoaiNgu" runat="server" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="col-md-1 pdt5 pdr0">Giáo dục PT</div>
        <div class="col-md-2">
            <asp:TextBox ID="GiaoDucPT" runat="server" CssClass="TextBox"></asp:TextBox>
        </div>
        <div class="col-md-1 pdt5 txt-right  pdl0">Tin học</div>
        <div class="col-md-3 pdl0">
            <asp:DropDownList ID="TinHoc" runat="server" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="clear"></div>
    </div>
    <div class="row">
        <div class="col-md-2 pdt5">Chuyên môn kỹ thuật</div>
        <div class="col-md-3">
            <asp:DropDownList ID="ChuyenMonKT" runat="server" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="col-md-1 pdt5 pdr0 ">Mức lương</div>
        <div class="col-md-2">
            <asp:TextBox ID="MucLuong" runat="server" CssClass="TextBox MucLuong"></asp:TextBox>
        </div>
        <div class="col-md-1 pdt5 txt-right pdl0">Lý do nghỉ</div>
        <div class="col-md-3 pdl0">
            <asp:DropDownList ID="LyDoNghi" runat="server" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="clear"></div>
    </div>
    <div class="row">
        <div class="col-md-2 pdt5">Đã tìm việc tại</div>
        <div class="col-md-10">
            <asp:TextBox ID="DaTimViecTai" runat="server" CssClass="TextBox"></asp:TextBox>
        </div>
        <div class="clear"></div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:UpdatePanel ID="C1" runat="server">
                <ContentTemplate>
                    <asp:DataGrid ID="grdAds" runat="server" CssClass="table-bordered respo-table table-pd0" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
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
                            <asp:TemplateColumn HeaderText="Chuyên ngành đào tạo">
                                <ItemTemplate>
                                    <asp:TextBox ID="Specialized" runat="server" CssClass="TextBox " />
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                </ItemTemplate>
                                <ItemStyle CssClass="column-primary" />
                                <HeaderStyle CssClass="column-primary" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Trình độ chuyên môn kỹ thuật">
                                <ItemTemplate>
                                    <asp:TextBox ID="LevelName" runat="server" CssClass="TextBox " />
                                </ItemTemplate>
                                <ItemStyle Width="40%" CssClass="ChuyenMon respo-view" />
                                <HeaderStyle Width="40%" CssClass="ChuyenMon respo-title" />
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
                                    <asp:Button ID="cmdAds" runat="server" ToolTip="Thêm dòng" CssClass="cmsbut-td cmsbtnew" OnClientClick="return $('#Form').validationEngine('detach');" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="cmdAds" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <div class="col-md-12">
            <asp:UpdatePanel ID="C2" runat="server">
                <ContentTemplate>
                    <asp:DataGrid ID="grdAdc" runat="server" CssClass="table-bordered respo-table table-pd0" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
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
                                    <asp:TextBox ID="Company" runat="server" CssClass="TextBox " />
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                </ItemTemplate>
                                <ItemStyle CssClass="column-primary" />
                                <HeaderStyle CssClass="column-primary" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Thời gian làm việc">
                                <ItemTemplate>
                                    <asp:TextBox ID="TimeWork" runat="server" CssClass="TextBox " />
                                </ItemTemplate>
                                <ItemStyle Width="20%" CssClass="ThoiGian respo-view" />
                                <HeaderStyle Width="20%" CssClass="ThoiGian respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Vị trí">
                                <ItemTemplate>
                                    <asp:TextBox ID="Location" runat="server" CssClass="TextBox " />
                                </ItemTemplate>
                                <ItemStyle Width="20%" CssClass="ViTri respo-view" />
                                <HeaderStyle Width="20%" CssClass="ViTri respo-title" />
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
                    <table cellspacing="0" id="tblRow2" runat="server" cellpadding="3" border="0" style="width: 100%; border-collapse: collapse; border-top: 0px!important">
                        <tbody>
                            <tr style="border-top: 0px!important; background: #fff;">
                                <td style="border-top: 0px!important; text-align: center; font-weight: bold;"></td>
                                <td style="border-top: 0px!important; text-align: center; width: 50px">
                                    <asp:Button ID="cmdAdc" runat="server" ToolTip="Thêm dòng" CssClass="cmsbut-td cmsbtnew" OnClientClick="return $('#Form').validationEngine('detach');" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="cmdAdc" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2 pdt5">Kỹ năng nghề nghiệp</div>
        <div class="col-md-3">
            <asp:DropDownList ID="KyNangNghe" runat="server" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="col-md-2 pdt5 txt-right">Khả năng nổi trội</div>
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
        
        </div>
         
        <div class="clear"></div>
        <div class="col-md-2 pdt5">Vị trí việc làm</div>
        <div class="col-md-3">
            <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_ViTri"></asp:DropDownList>
        </div>
        <div class="col-md-1 pdt5 txt-right">Mức lương</div>
        <div class="col-md-2">
            <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_MucLuong"></asp:DropDownList>
        </div>
        <div class="col-md-1 pdt5 txt-right">Công việc</div>
        <div class="col-md-3">
            <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_CongViec"></asp:DropDownList>
        </div>
        <div class="clear"></div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="col-md-2 pdt5">Nơi làm việc</div>
                <div class="col-md-3">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_TinhTP" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_QuanHuyen"></asp:DropDownList>
                </div>
                <div class="col-md-1 pdt5 txt-right">Loại hình</div>
                <div class="col-md-3">
                    <asp:DropDownList CssClass="selectpicker" runat="server" ID="GT_LoaiHinh"></asp:DropDownList>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="GT_TinhTP" />
            </Triggers>
        </asp:UpdatePanel>
        <div class="clear"></div>
        <div class="col-md-2 pdt5">Điều kiện làm việc</div>
        <div class="col-md-5">
            <asp:TextBox CssClass="TextBox" runat="server" ID="GT_DieuKien"></asp:TextBox>
        </div>
        <div class="col-md-1 pdt5 txt-right">Khác</div>
        <div class="col-md-4">
            <asp:TextBox CssClass="TextBox" runat="server" ID="GT_Khac"></asp:TextBox>
        </div>
    </div>
</div>
<div class="row txt-center mgbt20 mgt20">
        <asp:Button ID="cmdSave" runat="server" CssClass="cmsbut cmdsave" Text="Lưu lại" OnClientClick="return $('#Form').validationEngine('validate');" />
    <asp:Button ID="cmdDelete" runat="server" CssClass="cmsbut cmsbtdel " Text="Hủy tư vấn" OnClientClick="return $('#Form').validationEngine('detach');" />

    <asp:Button ID="cmdSend" runat="server" CssClass="cmsbut cbtsend" Text="Nộp hồ sơ" OnClientClick="return $('#Form').validationEngine('validate');" />
    <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
</div>
<script type="text/javascript">
    function delrows(t) {
        if (confirm("Bạn có muốn xóa dòng này đi không?")) {
            $(t).parents("tr").remove(); notify('success', 'Đã xóa dòng lựa chọn thành công.', 'Thông báo', false);
        };
    };
</script>

    <asp:HiddenField ID="ItemID" runat="server" Visible="false" />
    <asp:HiddenField ID="NoCode" runat="server" Visible="false" />