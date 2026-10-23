<%@ Control Language="vb" Inherits="Home.Dashboad.View" CodeFile="Dashboard.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<style>
    .linkdash {
        text-align: right
    }

        .linkdash a {
            color: #780d0d;
            font-weight: 600;
            font-size: 12px;
            text-decoration: underline !important
        }

    .box {
        background: #f5f5f5 !important;
    }
</style>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Tổng quan dự báo thị trường lao động</h3>
        </div>
        <div class="col-md-1 col-xs-3 lb txt-center">Tỉnh/TP</div>
        <div class="col-md-2 col-xs-9">
            <asp:DropDownList runat="server" ID="TinhTP" AutoPostBack="true" CssClass="selectpicker" />
        </div>
        <div class="clear"></div>

        <div class="col-md-6 linkdash">
            <div id="chartForeCast1"></div>
            <asp:HyperLink Text="Xem dự báo chi tiết" runat="server" ID="hdFrc1" />
        </div>
        <div class="col-md-6 linkdash">
            <div id="chartForeCast2"></div>
            <asp:HyperLink Text="Xem dự báo chi tiết" runat="server" ID="hdFrc2" />
        </div>
        <div class="clear"></div>
        <div class="col-md-6 linkdash">
            <div id="chartForeCast3"></div>
            <asp:HyperLink Text="Xem dự báo chi tiết" runat="server" ID="hdFrc3" />
        </div>
        <div class="col-md-6 linkdash">
            <div id="chartForeCast4"></div>
            <asp:HyperLink Text="Xem dự báo chi tiết" runat="server" ID="hdFrc4" />
        </div>
    </div>

</div>
<asp:HiddenField runat="server" Visible="false" ID="ViewID" />
<asp:HiddenField runat="server" Visible="false" ID="TargetID" />
<script src="/js/validation/highcharts.js?v=1.2"></script>
<script>
    //15+
    $('#chartForeCast1').highcharts({
        colors: ['#0066ff', '#ED561B'],
        credits: { enabled: false },
        chart: {
            height: 270,
            type: 'column'
        },
        title: {
            text: '<%=TitleChart1%>'
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: 'Số lượng (<%=DonViTinh1%>)'
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
                    format: '{point.y:.0f}'
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span> ',
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.0f} <%=DonViTinh1%></b><br/>'
        },

        series: [
            {
                name: "Năm",
                colorByPoint: true,
                data: [
            <%=DataChart1%>

                ]
            }
        ]
    });
    //LUC LUONG LAO DONG
    $('#chartForeCast2').highcharts({
        colors: ['#99ff33', '#ffa31a'],
        credits: { enabled: false },
        chart: {
            height: 270,
            type: 'line'
        },
        title: {
            text: '<%=TitleChart2%>'
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: 'Số lượng (<%=DonViTinh2%>)'
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
                    format: '{point.y:.0f}'
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span> ',
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.0f} <%=DonViTinh2%></b><br/>'
        },

        series: [
            {
                name: "Năm",
                colorByPoint: true,
                data: [
            <%=DataChart2%>

                ]
            }
        ]
    });
    // TINH TRANG THAT NGHIEP
    $('#chartForeCast3').highcharts({
        colors: ['#009900', '#ffbf00'],
        credits: { enabled: false },
        chart: {
            height: 270,
            type: 'areaspline'
        },
        title: {
            text: '<%=TitleChart3%>'
        },
        legend: {
            layout: 'vertical',
            align: 'left',
            verticalAlign: 'top',
            x: 150,
            y: 100,
            floating: true,
            borderWidth: 1,
            backgroundColor:
                Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF'
        },
        xAxis: {
            categories: [<%=XYear3%>]
        },
        yAxis: {
            title: {
                text: 'Số lượng (<%=DonViTinh3%>)'
            }
        },
        tooltip: {
            shared: true,
            valueSuffix: ' <%=DonViTinh3%>',
            headerFormat: '<span style="font-size:11px">{series.name}</span> ',
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.0f} <%=DonViTinh3%></b><br/>'
        },
        credits: {
            enabled: false
        },
        plotOptions: {
            areaspline: {
                fillOpacity: 0.5
            }
        },
        series: [{
            name: 'Số lượng',
            data: [<%=DataChart3%>]
        }]
    });
    // CO VIEC LAM
    $('#chartForeCast4').highcharts({
        colors: ['#e66b1a', '#66ccff'],

        credits: { enabled: false },
        chart: {
            height: 270,
            zoomType: 'xy'
        },
        title: {
            text: '<%=TitleChart4%>'
        },
        xAxis: [{
            categories: [<%=XYear4%>],
            crosshair: true
        }],
        yAxis: [{ // Primary yAxis
            labels: {
                format: '{value}',
                style: {
                    color: Highcharts.getOptions().colors[1]
                }
            },
            title: {
                text: 'GDP (tỷ đồng)',
                style: {
                    color: Highcharts.getOptions().colors[1]
                }
            }
        }, { // Secondary yAxis
                title: {
                    text: 'Số lượng ( <%=DonViTinh4%>)',
                    style: {
                        color: Highcharts.getOptions().colors[0]
                    }
                },
                labels: {
                    format: '{value}',
                    style: {
                        color: Highcharts.getOptions().colors[0]
                    }
                },
                opposite: true
            }],
        tooltip: {
            shared: true,
             <%-- headerFormat: '<span style="font-size:11px">{series.name}</span> ',
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.0f} <%=DonViTinh4%></b><br/>'--%>
        },
        legend: {
            layout: 'vertical',
            align: 'left',
            x: 120,
            verticalAlign: 'top',
            y: 100,
            floating: true,
            backgroundColor:
                Highcharts.defaultOptions.legend.backgroundColor || // theme
                'rgba(255,255,255,0.25)'
        },
        series: [{
            name: 'Số lượng',
            type: 'column',
            yAxis: 1,
            data: [<%=DataChart4_1%>],
            tooltip: {
                valueSuffix: ' <%=DonViTinh4%>'
            }

        }, {
                name: 'GDP',
                type: 'spline',
                data: [<%=DataChart4_2%>],
                tooltip: {
                    valueSuffix: ' tỷ đồng'
                }
            }]
    });
</script>
