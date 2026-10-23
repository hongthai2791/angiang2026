<%@ Control Language="vb" Inherits="Home.Dashboad.View" CodeFile="Dashboard.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Hệ thống quản lý danh mục dùng chung</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:Literal ID="litTBao" runat="server"></asp:Literal>
            <div id="container" style="height: 500px; width: 500px; margin: 30px auto"></div>
        </div>
    </div>
</div>

<script src="/js/validation/highcharts.js?v=1.7"></script>
<script src="/js/validation/highcharts-more.js?v=1.7"></script>

<script type="text/javascript">
    function getNow() {
        var now = new Date();
        return {
            hours: now.getHours() + now.getMinutes() / 60,
            minutes: now.getMinutes() * 12 / 60 + now.getSeconds() * 12 / 3600,
            seconds: now.getSeconds() * 12 / 60
        };
    }
    function pad(number, length) { return new Array((length || 2) + 1 - String(number).length).join(0) + number; }
    var now = getNow();
    Highcharts.chart('container', {
        chart: { type: 'gauge', plotBackgroundColor: null, plotBackgroundImage: null, plotBorderWidth: 0, plotShadow: false, height: '80%' },
        credits: { enabled: false }, title: { text: '' },
        pane: {
            background: [{
            }, {
                backgroundColor: Highcharts.svg ? {
                    radialGradient: { cx: 0.5, cy: -0.4, r: 1.9 },
                    stops: [[0.5, 'rgba(255, 255, 255, 0.2)'], [0.5, 'rgba(200, 200, 200, 0.2)']]
                } : null
            }]
        },
        yAxis: {
            labels: { distance: -20 },
            min: 0, max: 12, lineWidth: 0, showFirstLabel: false,
            minorTickInterval: 'auto', minorTickWidth: 1, minorTickLength: 5,
            minorTickPosition: 'inside', minorGridLineWidth: 0, minorTickColor: '#666',
            tickInterval: 1, tickWidth: 2, tickPosition: 'inside', tickLength: 10, tickColor: '#666',
            title: {
                text: 'EPORTAL VIET NAM',
                style: { color: '#0da28e', fontWeight: 'normal', fontSize: '8px', lineHeight: '10px' }, y: 10
            }
        },
        tooltip: { formatter: function () { return this.series.chart.tooltipText; } },
        series: [{
            data: [{
                id: 'hour', y: now.hours, dial: { radius: '60%', baseWidth: 4, baseLength: '95%', rearLength: 0 }
            }, {
                id: 'minute', y: now.minutes, dial: { baseLength: '95%', rearLength: 0 }
            }, { id: 'second', y: now.seconds, dial: { radius: '100%', baseWidth: 1, rearLength: '20%' } }],
            animation: false, dataLabels: { enabled: false }
        }]
    },
        function (chart) {
            setInterval(function () {
                now = getNow();
                if (chart.axes) {
                    var hour = chart.get('hour'),
                        minute = chart.get('minute'),
                        second = chart.get('second'),
                        animation = now.seconds === 0 ?
                            false : { easing: 'easeOutBounce' };

                    chart.tooltipText =
                        pad(Math.floor(now.hours), 2) + ':' +
                        pad(Math.floor(now.minutes * 5), 2) + ':' +
                        pad(now.seconds * 5, 2);

                    hour.update(now.hours, true, animation);
                    minute.update(now.minutes, true, animation);
                    second.update(now.seconds, true, animation);
                }
            }, 1000);
        });
    Math.easeOutBounce = function (pos) {
        if ((pos) < (1 / 2.75)) { return (7.5625 * pos * pos); }
        if (pos < (2 / 2.75)) { return (7.5625 * (pos -= (1.5 / 2.75)) * pos + 0.75); }
        if (pos < (2.5 / 2.75)) { return (7.5625 * (pos -= (2.25 / 2.75)) * pos + 0.9375); }
        return (7.5625 * (pos -= (2.625 / 2.75)) * pos + 0.984375);
    };

</script>
