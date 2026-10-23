<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="KBVL_Edit.ascx.vb" Inherits="Modules.KBVL.Edit" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Thông báo về việc tìm kiếm việc làm hàng tháng</h3>
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
                    <asp:DropDownList ID="drPortal" runat="server" onchange="changefocus(this);" inext="HoTen" CssClass="drPortal selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Tên tôi là</div>
                <div class="col-md-4">
                    <asp:TextBox ID="HoTen" runat="server" onkeypress="return keydownfocus(event,'NgaySinh',0);" CssClass="TextBox HoTen validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Ngày sinh</div>
                <div class="col-md-2">
                    <asp:TextBox ID="NgaySinh" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'GioiTinh',0);" CssClass="NgaySinh TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center pdr0">Giới tính</div>
                <div class="col-md-2">
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
                    <asp:TextBox ID="NgayCap" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'CO_TinhTP',0);" CssClass="NgayCap TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5 lb">Chỗ ở hiện nay</div>
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
                <%--<div class="col-md-2 pdt5 lb">Số nhà, đường, phố</div>--%>
                <div class="col-md-2 pdt5 lb">Địa chỉ</div>
                <div class="col-md-4">
                    <asp:TextBox ID="CO_DuongPho" runat="server" onkeypress="return keydownfocus(event,'DienThoai',0);" placeholder="Địa chỉ chi tiết" CssClass="required TextBox CO_DuongPho validate[required]"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Điện thoại</div>
                <div class="col-md-2">
                    <asp:TextBox ID="DienThoai" runat="server" onkeypress="return keydownfocus(event,'QD_Ngay',0);" CssClass="TextBox DienThoai validate[required, minSize[10]]" MaxLength="10"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Email</div>
                <div class="col-md-2">
                    <asp:TextBox ID="Email" runat="server" onkeypress="return keydownfocus(event,'DienThoai',0);" CssClass="TextBox Email validate[required, custom[email]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Theo Quyết định số</div>
                <div class="col-md-2">
                    <asp:TextBox ID="QD_So" runat="server" onkeypress="return keydownfocus(event,'QD_Ngay',0);" CssClass="TextBox QD_So validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Ngày ký QĐ</div>
                <div class="col-md-2">
                    <asp:TextBox placeholder="dd/mm/yyyy" data-mask="00/00/0000" ID="QD_Ngay" runat="server" onkeypress="return keydownfocus(event,'QD_ThangHuong',0);" CssClass="QD_Ngay TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Hưởng trợ cấp</div>
                <div class="col-md-1">
                    <asp:TextBox ID="QD_ThangHuong" runat="server" onkeypress="return keydownfocus(event,'QD_TuNgay',0);" CssClass="TextBox QD_ThangHuong validate[required, custom[integer]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-1 pdt5 lb">
                    (tháng)
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 lb">Hưởng từ ngày</div>
                <div class="col-md-2">
                    <asp:TextBox placeholder="dd/mm/yyyy" data-mask="00/00/0000" ID="QD_TuNgay" runat="server" onkeypress="return keydownfocus(event,'QD_DenNgay',0);" CssClass="QD_TuNgay TextBox validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-2 pdt5 lb txt-center">Đến hết ngày</div>
                <div class="col-md-2">
                    <asp:TextBox ID="QD_DenNgay" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" onkeypress="return keydownfocus(event,'QD_TinhTP',0);" CssClass="QD_DenNgay TextBox"></asp:TextBox>
                </div>
                <div class="col-md-1 pdt5 lb txt-center">Tại</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="QD_TinhTP" onchange="changefocus(this);" inext="TinhTrang" runat="server" CssClass="selectpicker QD_TinhTP validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>

                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-3 pdt5 lb">Tháng hưởng trợ cấp thất nghiệp thứ</div>
                <div class="col-md-1">
                    <asp:TextBox ID="ThangHuong" runat="server" onkeypress="return keydownfocus(event,'drPortal',0);" CssClass="TextBox HoTen validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 pdt5">
                      <asp:Literal ID="littkvl" runat="server" />
                  <%--  <a target="_blank" href="<%=linkTKVL %>">Xem file đính kèm</a>--%>
                  <%--  <a onclick="taifilevl()" title="Nhấn để tải file dữ liệu">
                        <img src="/image/images/Download.png" />
                        Tải file</a>--%>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-3 pdt5 lb">Tình trạng việc làm hiện nay</div>
                <div class="col-md-9 pdt5">
                    <asp:CheckBox ID="TinhTrang" GroupName="A" runat="server" Text="Không có việc làm" CssClass="CheckBox TinhTrang" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:TextBox ID="NeuCoVL" onkeypress="return keydownfocus(event,'cmsbtnew',0);" placeHolder="Có việc làm nhưng chưa giao kết HĐLĐ/HĐLV (ghi rõ tên đơn vị, địa chỉ, công việc đang làm)" runat="server" CssClass="TextBox NeuCoVL" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:TextBox ID="TT_Khac" onkeypress="return keydownfocus(event,'cmsbtnew',0);" placeHolder="Tình trạng khác (ốm đau, thai sản,…)" runat="server" CssClass="TextBox TT_Khac" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 pdt5 lb">Tôi thông báo kết quả tìm kiếm việc làm theo quy định, cụ thể như sau:</div>
                <div class="col-md-12">
                    <asp:DataGrid ID="grdData" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
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
                                    <asp:Literal ID="TenDonVi" runat="server" />
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                </ItemTemplate>
                                <ItemStyle CssClass="column-primary" />
                                <HeaderStyle CssClass="column-primary" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Địa chỉ">
                                <ItemTemplate>
                                    <asp:Literal ID="DiaChi" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="30%" CssClass="DiaChi respo-view" />
                                <HeaderStyle Width="30%" CssClass="DiaChi respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Người liên hệ">
                                <ItemTemplate>
                                    <asp:Literal ID="NguoiLienHe" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="15%" CssClass="NguoiLienHe respo-view" />
                                <HeaderStyle Width="15%" CssClass="NguoiLienHe respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Vị trí dự tuyển">
                                <ItemTemplate>
                                    <asp:Literal ID="ViTriDuTuyen" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="15%" CssClass="ViTriDuTuyen respo-view" />
                                <HeaderStyle Width="15%" CssClass="ViTriDuTuyen respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Kết quả">
                                <ItemTemplate>
                                    <asp:Literal ID="KetQua" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="10%" CssClass="KetQua respo-view" />
                                <HeaderStyle Width="10%" CssClass="KetQua respo-title" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
            </div>
        </asp:Panel>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdActive" runat="server" Text="Tiếp nhận & Chuyển chuyên môn" CssClass="cmsbut cmsbtfinish" />
        <button id="cmdReturn" runat="server" type="button" data-toggle="modal" data-target="#frmBCLai" class="cmsbut cmsbtreturn">Trả lại hồ sơ</button>
        <asp:Button ID="cmdExport" runat="server" OnClientClick="popPdfTKVL(); return false" Text="Tải phiếu đăng ký" CssClass="cmsbut cmdpdf cbclick" />
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
    function taifilevl() {
        var pid = $("#<%=_pid%>").val();
        var key = $("#<%=ItemID.ClientID %>").val();
        window.open("/api/insu/download.aspx?id="+ key + "&pid=" + pid);
    }
    function popPdfTKVL() {
        var pid = $("#<%=_pid%>").val();
        var ID = $("#<%=ItemID.ClientID%>").val();
        var dtype = ".docx";
        window.open("/api/insu/export.aspx?typeid=TKVL&pid=<%=_pid%>&ItemID=" + ID + "&dtype=" + dtype)
    };
    function tralai() {
        if ($("#<%=txtContent.ClientID%>").val() == "") { notify('info', 'Lý do trả lại không được trống.', 'Thông báo', false); return false; }
        else {
            var lydo = $("#<%=txtContent.ClientID%>").val(), id = $("#<%=ItemID.ClientID%>").val(), pid = "<%=_pid%>";
            if ((lydo != "") && (lydo != undefined)) { lydo = Base64.encode(lydo); }
            $.ajax({
                type: "GET", url: '/api/insu/common.asmx/traLai?pid=' + pid + "&id=" + id + "&lydo=" + lydo + "&type=Apprentice", success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data == "1") { notify('success', 'Đã gửi yêu cầu trả lại thành công.', 'Thông báo', false); backend('<%=ViewState("backUrl")%>'); }
                    else { notify('info', 'Có lỗi trong quá trình kết nối API.', 'Thông báo', false); };
                },
            });
        };
        $('#frmBCLai').modal('hide');
    };
</script>
