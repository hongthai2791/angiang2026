<%@ Control Language="vb" CodeFile="Report2_1.ascx.vb" Inherits="Modules.Report.RPT01" AutoEventWireup="false" Explicit="True" %>
<style>
    .lbchk label, td label {
        padding-left: 5px !important;
    }
</style>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Phân tích chỉ tiêu mối quan hệ giữa thị trường lao động với các yếu tố</h3>
        </div>
        
        <div class="col-md-6 alert alert-warning mgbt0">
                Chức năng này chạy dữ liệu từ các nhóm chỉ tiêu tổng hợp
        </div>
        <div class="col-md-3 none">
            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="col-md-2 none">
            <asp:DropDownList ID="ChooseData_ID" runat="server" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body qlte">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 lb">Chọn nhóm chỉ tiêu</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="drGroup" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 txt-center lb">Kỳ BC trước</div>
                <div class="col-md-1 ">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="YearFrom" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-2 lb text-center">Kỳ BC hiện tại</div>
                <div class="col-md-1">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="YearTo" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <fieldset style="min-height: 480px">
                        <legend>Nhóm chính</legend>
                        <div class="col-md-12">
                            <asp:Panel runat="server" ID="pnCot" ClientIDMode="Static"></asp:Panel>
                        </div>
                        <asp:Literal ID="ltrLink" runat="server" />
                        <div class="col-md-12 mgt10">
                            <a href="#demo" class="box-title" data-toggle="collapse" title="Click để thu nhỏ hoặc hiển thị nội dung">Phân tích chỉ tiêu</a>
                        </div>
                        <div class="col-md-12 contents-analytic collapse in" id="demo">
                            <asp:Literal runat="server" ID="ltrPhanTich" />
                        </div>
                    </fieldset>
                </div>
                <div class="col-md-6">
                    <fieldset style="min-height: 480px">
                        <legend>Yếu tố khác</legend>
                        <div class="col-md-12">
                            <div class="col-md-12">
                                <asp:Panel runat="server" ID="pnGDP" ClientIDMode="Static"></asp:Panel>
                            </div>
                        </div>
                        <div class="col-md-12 mgt10">
                        <a href="#demo2" class="box-title" data-toggle="collapse" title="Click để thu nhỏ hoặc hiển thị nội dung">Phân tích chỉ tiêu</a>
                            </div>
                        <div class="col-md-12 contents-analytic collapse in" id="demo2">
                            <asp:Literal runat="server" ID="ltrPhanTich2" />
                        </div>
                    </fieldset>
                </div>
            </div>
            <div class="clr"></div>
            <asp:Literal ID="lbmsg" runat="server"></asp:Literal>
        </div>
    </div>
</div>

<asp:HiddenField ID="_TargetsID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="ASXH_ID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="_ParentID" Value="-1" runat="server" Visible="false" />
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdView" runat="server" Text="Xem kết quả" CssClass="cmsbut cmdview" />
        <asp:Button ID="cmdSettings" runat="server" CssClass="cmdbtt cmdSettings" Text="Thiết lập" Visible="false" />
    </div>
</div>

<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
<script type="text/javascript">
    
    $('#pnCot').highcharts({
        colors: ['#50B432', '#ED561B'],
        credits: { enabled: false },
        chart: { type: 'column' },
        title: { text: '<%=TitleChart%>' },
        xAxis: { categories: [ <%=TextAxis%>] },
        yAxis: { min: 0, title: { text: 'Số lượng (<%=DonViTinh%>)' } },
        tooltip: {
            headerFormat: '<span style="font-size:10px">Chỉ tiêu: {point.key}</span><table>',
            pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
                '<td style="padding:0"><b>{point.y:,.0f} <%=DonViTinh%></b></td></tr>',
            footerFormat: '</table>',
            shared: true, useHTML: true
        },
        plotOptions: { column: { pointPadding: 0.2, borderWidth: 0 } },
        exporting: { enabled: true },
        series: [{
            name: <%=Year1%>, data: [<%=ValueChart1%>]
        }, { name: <%=Year2%>, data: [<%=ValueChart2%>] }]
    });
    $('#pnGDP').highcharts({
        colors: ['#50B432', '#ED561B'],
        credits: { enabled: false },
        chart: { type: 'spline' },
        title: { text: 'Biểu đồ số liệu Tổng sản phẩm (GDPR)' },
        xAxis: { categories: [ <%=TextAxis2%>] },
        yAxis: { min: 0, title: { text: 'GDP (tỷ đồng)' } },
        plotOptions: { column: { pointPadding: 0.2, borderWidth: 0 } },
        exporting: { enabled: true },
        series: [{
            name: <%=Year1%>, data: [<%=ValueChart3%>]
        }, { name: <%=Year2%>, data: [<%=ValueChart4%>] }]
    });
</script>
