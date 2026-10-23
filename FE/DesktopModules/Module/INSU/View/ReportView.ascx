<%@ Control Language="vb" CodeFile="ReportView.ascx.vb" Inherits="Modules.ReportView.View" %>


<div class="box box-info">
    <div class="box-header with-border">
        <h3 class="box-title">Thống kê đăng ký</h3>
    </div>
    <div class="box-body">
        <div id="chartContainer" style="width:100%; height:400px;"></div>
    </div>
</div>

<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>

<script type="text/javascript">
    document.addEventListener('DOMContentLoaded', function () {
        Highcharts.chart('chartContainer', {
            credits: { enabled: false },
            chart: {
                type: 'column',
            },
            // Trục hoành (X) - hiển thị tên ngành nghề
            xAxis: {
                type: 'category', // Trục X dạng danh mục
                title: {
                    text: 'Dịch vụ'
                }
            },
            // Trục tung (Y) - hiển thị số lượng
            yAxis: {
                min: 0,
                title: {
                    text: 'Số lượng'
                },
                allowDecimals: false // Không hiển thị số thập phân
            },
            // Chú giải (legend) có thể không cần thiết cho biểu đồ một chuỗi dữ liệu
            legend: {
                enabled: false
            },
            plotOptions: {
                column: {
                    pointPadding: 0.2,
                    borderWidth: 0
                }
            },
            exporting: { enabled: true },
            title: {
                text: 'Thống kê đăng ký theo dịch vụ'
            },
            // Tooltip khi di chuột vào cột
            tooltip: {
                headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
                pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}</b> <br/>'
            },
            // Chuỗi dữ liệu
            series: [{
                name: 'Số lượng ',
                colorByPoint: true, // Giữ màu sắc cho từng cột
                data: chartData     // Dữ liệu từ code-behind vẫn giữ nguyên định dạng
            }]
            
        });
    });
</script>