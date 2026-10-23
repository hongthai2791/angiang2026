<%@ Control Language="vb" Inherits="TNDashboad.Dashboad.View" CodeFile="Dashboard.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register Src="~/DesktopModules/Module/MAP/Layer/MapDashboard.ascx" TagPrefix="uc1" TagName="MapDashboard" %>


<div class="box box-info vbContent">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">MAP | Quản trị bản đồ số</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-aqua"><i class="fa fa-file"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" title="Tổng số doanh nghiệp">Doanh nghiệp</span>
                            <span class="info-box-number" title="Tổng số doanh nghiệp"><%=DashNum1 %></span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-red"><i class="fa fa-check"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" title="Tổng số tin tuyển dụng">Tin tuyển dụng</span>
                            <span class="info-box-number"><%=DashNum2 %></span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-green"><i class="fa fa-comment"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" title="Tổng số bình luận">Có việc làm</span>
                            <span class="info-box-number"><%=DashNum3 %></span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-yellow"><i class="fa fa-play"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" title="Tổng số video">Lực lượng lao động</span>
                            <span class="info-box-number"><%=DashNum4 %></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
            <div class="row mgt30">
                <div class="col-md-6">
                    <div class="box">
                        <div id="containerTheoThang">
                        </div>
                    </div>
                </div>
                
                <div class="col-md-6">
                    <uc1:MapDashboard runat="server" ID="MapDashboard" />
                    </div>
            </div>
        </div>
    </div>
</div>
<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
<script>
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
            text: 'Biểu đồ thống kê tổng hợp'
        },
        xAxis: {
            categories: [
                'Năm 2019',
                'Năm 2020',
                'Năm 2021',
                'Năm 2022',
                'Năm 2023',
                'Năm 2024'
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
            name: 'Dân số 15+',
            data: [<%=valChart1%>]

        }, {
                name: 'Có việc làm',
                data: [<%=valChart2%>]

            }, {
                name: 'Lực lượng lao động',
                data: [<%=valChart3%>]

            }, {
                name: 'Thất nghiệp',
                data: [<%=valChart4%>]

            }]
    });
</script>


