<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="BaoCaoTongHop.ascx.vb" Inherits="DesktopModules.Modules.Reports.BaoCaoTongHop" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-8">
            <h3 class="box-title">THÔNG TIN VỀ SỐ LAO ĐỘNG ĐẦU KỲ - CUỐI KỲ</h3>
        </div>
        <div class="col-md-2">
            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker TinhTP" />
        </div>
        <div class="col-md-2">
            <asp:Button ID="cmdTongHop" Text="Tổng hợp lại" CssClass="cmsbut cmdTH" runat="server" />
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 hidden-xs txt-center lb">Quận/ huyện</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="QuanHuyen" runat="server" CssClass="selectpicker QuanHuyen" />
                </div>
                <div class="col-md-2 col-xs-4 txt-center lb">Năm báo cáo</div>
                <div class="col-md-1 col-xs-8">
                    <asp:DropDownList ID="Years_ID" runat="server" CssClass="selectpicker Years_ID" />
                </div>
                <div class="col-md-2 col-xs-4 txt-center lb">Kỳ báo cáo</div>
                <div class="col-md-2 col-xs-8">
                    <asp:DropDownList ID="Period_ID" runat="server" CssClass="selectpicker Period_ID" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <table border="1" class="pro-ctable" width="100%" cellspacing="0" style="font-family: Times New Roman;">
                        <tr style="text-align: center; color: #fff; font-weight: bold; vertical-align: middle;">
                            <td style="" class="hdTitle" rowspan="2">STT</td>
                            <td style="width: 130px;" class="hdTitle" rowspan="2">Quận/Huyện</td>
                            <td style="width: 70px;" class="hdTitle" rowspan="2">Thời điểm</td>
                            <td colspan="2" style="" class="hdTitle">Tổng số LĐ</td>
                            <td colspan="6" style="" class="hdTitle">Trình độ chuyên môn kỹ thuật</td>
                            <td colspan="4" style="" class="hdTitle">Loại HĐLĐ/ hợp đồng làm việc</td>
                            <td rowspan="2" style="" class="hdTitle">Tổng số người tham gia BHTN</td>
                        </tr>
                        <tr style="text-align: center; color: #fff; font-weight: bold; vertical-align: middle;">
                            <td style="" class="hdTitle">Tổng số</td>
                            <td style="" class="hdTitle">Trong đó nữ</td>
                            <td style="" class="hdTitle">CN kỹ thuật không bằng</td>
                            <td style="" class="hdTitle">Chứng chỉ nghề ngắn hạn dưới 3 tháng</td>
                            <td style="" class="hdTitle">Sơ cấp từ 3-12 tháng</td>
                            <td style="" class="hdTitle">Trung cấp</td>
                            <td style="" class="hdTitle">Cao đẳng</td>
                            <td style="" class="hdTitle">ĐH trở lên</td>
                            <td style="" class="hdTitle">Không xác định thời hạn</td>
                            <td style="" class="hdTitle">Từ đủ 12 tháng đến 36 tháng</td>
                            <td style="" class="hdTitle">Từ đủ 3 tháng đến dưới 12 tháng</td>
                            <td style="" class="hdTitle">Dưới 3 tháng</td>
                        </tr>
                        <asp:Literal ID="litbc" runat="server"></asp:Literal>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class="fix-btt-toolbar">
        <div>
            <asp:Button ID="cmdView" Text="Xem báo cáo" CssClass="cmsbut cmsbtrun" runat="server" />
            <asp:Button ID="cmdExport" Text="Xuất ra excel" CssClass="cmsbut cmdExcel" OnClientClick="popexp('exports'); return false;" runat="server" />
        </div>
    </div>
</div>
<script type="text/javascript">
    function exports() {
        var tp = $("#<%=TinhTP.ClientID %>").val();
        var qh = $("#<%=QuanHuyen.ClientID %>").val();
        var kyBC = $("#<%=Period_ID.ClientID %>").val();
        var year = $("#<%=Years_ID.ClientID %>").val();
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/exports?page=work&view=ExCauLD&typeid=BCTH_DauCuoi&pid=0&tp=" + tp + "&qh=" + qh + "&kyBC=" + kyBC + "&year=" + year + "&dtype=" + dtype);
        return false;
    };

</script>
