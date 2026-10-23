<%@ Control Language="vb" CodeFile="CalcYear.ascx.vb" Inherits="Modules.Report.CalcYear" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Tổng hợp số liệu so sánh giữa các năm</h3>
        </div>
        <div class="col-md-6 alert alert-warning mgbt0">
            Chức năng này chạy dữ liệu từ các nhóm số liệu thô
        </div>
        <div class="col-md-1 lb text-center none">Tỉnh/TP</div>
        <div class="col-md-3 none">
            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
        </div>

        <div class="clear"></div>
    </div>
    <div class="box-body qlte">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 lb text-center">Loại biểu đồ</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drChartType" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 lb text-center">Loại dữ liệu</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drDataType" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-1 lb text-center">Kỳ trước</div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drYearFrom" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-1 lb text-center">Kỳ hiện tại</div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drYearTo" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">

                <div class="col-md-2 lb">Chọn nhóm chỉ tiêu</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="drGroup" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 txt-center lb">Chọn chỉ tiêu</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="drTarRow" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-5">
                    <asp:Literal runat="server" ID="litData" />
                </div>
                <div class="col-md-7">
                    <div id="chartForeCast1"></div>
                </div>
                <div class="clr"></div>
                <asp:Literal ID="lbmsg" runat="server"></asp:Literal>
                <div class="clear"></div>
            </div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button runat="server" ID="cmdView" Text="Xem kết quả" class="cmsbut cmdview"></asp:Button>
    </div>
</div>
<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
<script>
    $('#chartForeCast1').highcharts({
        credits: { enabled: false },
        chart: {
            type: '<%=ChartType%>'
        },
        title: {
            text: '<%=TitleChart%>'
        },
        xAxis: {
            categories: [<%=CategoryName%>],
            type: 'category'
        }, yAxis: {
            title: {
                text: '<%=TypeText%>'
            }

        },
        legend: {
            enabled: true,
            //align: 'right',
            //x: -30,
            //verticalAlign: 'top',
            //y: 25,
            //floating: true,
            //backgroundColor:
            //    Highcharts.defaultOptions.legend.backgroundColor || 'white',
            //borderColor: '#CCC',
            //borderWidth: 1
        },
        plotOptions: {
            series: {
                borderWidth: 0,
                dataLabels: {
                    enabled: true,
                    format: '{point.y:.<%=FloatF%>f}'
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span> ',
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.<%=FloatF%>f} </b><br/>'
        },

        series: [
                <%=DataChart1%>
        ]
    });

</script>

