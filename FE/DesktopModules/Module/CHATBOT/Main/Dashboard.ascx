<%@ Control Language="vb" Inherits="TNDashboad.Dashboad.View" CodeFile="Dashboard.ascx.vb" AutoEventWireup="false" Explicit="True" %>

<div class="box box-info vbContent">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">CHATBOT | Quản trị Chatbot</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-aqua"><i class="fa fa-file"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" title="Tổng số từ khóa">Tổng số từ khóa</span>
                            <span class="info-box-number" title="Tổng số từ khóa"><%=DashNum1 %></span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-red"><i class="fa fa-list"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" title="Tổng số kịch bản">Số kịch bản</span>
                            <span class="info-box-number"><%=DashNum2 %></span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-green"><i class="fa fa-comment"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" title="Tổng số đào tạo">Tổng số đào tạo</span>
                            <span class="info-box-number"><%=DashNum3 %></span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-yellow"><i class="fa fa-file-o"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" title="Tổng số câu mẫu">Số câu mẫu</span>
                            <span class="info-box-number"><%=DashNum4 %></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
            <div class="row">
                <div class="box">
                    <div id="containerTheoThang">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
<script>
    var currentDate = new Date();
    var month1 = new Date().getMonth() + 1;
    var month2 = addMonths(currentDate, -1).getMonth() + 1;
    var month3 = addMonths(currentDate, -1).getMonth() + 1;
    var month4 = addMonths(currentDate, -1).getMonth() + 1;
    var month5 = addMonths(currentDate, -1).getMonth() + 1;
    var month6 = addMonths(currentDate, -1).getMonth() + 1;

    $('.info-box-number').each(function () {
        $(this).prop('Counter', 0).animate({
            Counter: $(this).text()
        }, {
                duration: 2000,
                easing: 'swing',
                step: function (now) {
                    $(this).text(Math.ceil(now));
                }
            });
    });

    $('#containerTheoThang').highcharts({
        credits: { enabled: false },
        chart: {
            type: 'column'
        },
        title: {
            text: 'Biểu đồ thống kê hội thoại'
        },
        xAxis: {
            categories: [
                'Tháng ' + month1,
                'Tháng ' + month2,
                'Tháng ' + month3,
                'Tháng ' + month4,
                'Tháng ' + month5,
                'Tháng ' + month6
            ]
        },
        yAxis: {
            min: 0,
            title: {
                text: ''
            }
        },
        tooltip: {
            headerFormat: '<span style="font-size:10px">Số liệu: {point.key}</span><table>',
            pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
                '<td style="padding:0"><b>{point.y:.0f}</b></td></tr>',
            footerFormat: '</table>',
            shared: true,
            useHTML: true
        },
        plotOptions: {
            column: {
                pointPadding: 0.2,
                borderWidth: 0
            }
        },
        exporting: { enabled: true },
        series: [{
            name: 'Hội thoại',
            data: [<%=valChart1%>],
            color: '#0090ff'
        }
        ]
    });

    function addMonths(date, months) {
        date.setMonth(date.getMonth() + months);
        return date;
    }
</script>