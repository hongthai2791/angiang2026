<%@ Control Language="vb" CodeFile="CalcSimple.ascx.vb" Inherits="Modules.Report.CalcSimple" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Tổng hợp số liệu một chiều</h3>
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
                <div class="col-md-2 lb">Loại biểu đồ</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drChartType" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 lb text-center">Loại dữ liệu</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drDataType" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 lb text-center">Kỳ dữ liệu</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drYear" runat="server" CssClass="selectpicker"></asp:DropDownList>
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
                <div class="row" id="chartForeCast1"></div>
            </div>
            <div class="clr"></div>
            <asp:Literal ID="lbmsg" runat="server"></asp:Literal>
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
            type: 'category'
        }, yAxis: {
            title: {
                text: '<%=TypeText%>'
            }

        },
        legend: {
            enabled: false
        },
        plotOptions: {
            series: {
                borderWidth: 0,
                dataLabels: {
                    enabled: true,
                    format: '{point.y:.<%=FloatF%>}'
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span> ',
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.<%=FloatF%>} </b><br/>'
        },

        series: [
            {
                name: "",
                colorByPoint: <%=PoinType%>,
                data: [
            <%=DataChart1%>
                ]
            }
        ]
    });

</script>

