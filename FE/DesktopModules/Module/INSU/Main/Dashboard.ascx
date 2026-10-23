<%@ Control Language="vb" Inherits="Home.Dashboad.View" CodeFile="Dashboard.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info dash-box">
    <div class="box-header with-border">
        <div class="col-md-7">
            <h3 class="box-title">Hệ thống Bảo hiểm thất nghiệp Việt Nam</h3>
        </div>
        <div class="col-md-5">
            <asp:DropDownList ID="drPortal" runat="server" AutoPostBack="true" CssClass="selectpicker validate[required]"></asp:DropDownList>
            <span class="required"></span>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body dash-new">
        <div class="row">
            <div class="col-md-6">
                <div class="info-box">
                    <span class="info-box-icon bg-aqua"><i class="fa fa-exclamation-circle"></i></span>
                    <div class="info-box-content ">
                        <span class="info-box-text" title="Số hồ sơ đăng ký trợ cấp TN">Số hồ sơ đăng ký trợ cấp TN</span>
                        <span class="info-box-number" title="Số hồ sơ đăng ký trợ cấp TN"><%=TotalTN %></span>
                        <div class="col-md-12 pdt5">
                            <a class="btn btn-info btn-sm ad-click-event" href="/insu/view/tvct-moi-nop" title="Click để xem hồ sơ mới nộp">Hồ sơ mới nộp</a>
                            <a class="btn btn-warning btn-sm ad-click-event" href="/insu/view/tvct-tiep-nhan" title="Click để xem hồ sơ đã tiếp nhận">Hồ sơ đã tiếp nhận</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="info-box">
                    <span class="info-box-icon bg-red"><i class="fa fa-car "></i></span>
                    <div class="info-box-content ">
                        <span class="info-box-text" title="Số hồ sơ đăng ký trợ cấp TN">Số hồ sơ đăng ký học nghề</span>
                        <span class="info-box-number" title="Số hồ sơ đăng ký trợ cấp TN"><%=TotalHN %></span>
                        <div class="col-md-12 pdt5">
                            <a class="btn btn-info btn-sm ad-click-event" href="/insu/view/dkhn-moi-mop" title="Click để xem hồ sơ mới nộp">Hồ sơ mới nộp</a>
                            <a class="btn btn-warning btn-sm ad-click-event" href="/insu/view/dkhn-tiep-nhan" title="Click để xem hồ sơ đã tiếp nhận">Hồ sơ đã tiếp nhận</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="info-box">
                    <span class="info-box-icon bg-green"><i class="fa fa-registered"></i></span>
                    <div class="info-box-content ">
                        <span class="info-box-text" title="Số hồ sơ đăng ký tư vấn GTVL">Số hồ sơ đăng ký tư vấn GTVL</span>
                        <span class="info-box-number" title="Số hồ sơ đăng ký tư vấn GTVL"><%=TotalGT %></span>
                        <div class="col-md-12 pdt5">
                            <a class="btn btn-info btn-sm ad-click-event" href="/insu/view/gtvt-moi-nop" title="Click để xem hồ sơ mới nộp">Hồ sơ mới nộp</a>
                            <a class="btn btn-warning btn-sm ad-click-event" href="/insu/view/gtvt-tiep-nhan" title="Click để xem hồ sơ đã tiếp nhận">Hồ sơ đã tiếp nhận</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="info-box">
                    <span class="info-box-icon bg-yellow"><i class="fa fa-comments"></i></span>
                    <div class="info-box-content ">
                        <span class="info-box-text" title="Số hồ sơ thông báo tìm kiếm việc làm">Số hồ sơ thông báo tìm kiếm việc làm</span>
                        <span class="info-box-number" title="Số hồ sơ thông báo tìm kiếm việc làm"><%=TotalVL %></span>
                        <div class="col-md-12 pdt5">
                            <a class="btn btn-info btn-sm ad-click-event" href="/insu/view/tbvl-moi-nop" title="Click để xem hồ sơ mới nộp">Hồ sơ mới nộp</a>
                            <a class="btn btn-warning btn-sm ad-click-event" href="/insu/view/tbvl-tiep-nhan" title="Click để xem hồ sơ đã tiếp nhận">Hồ sơ đã tiếp nhận</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div id="chartTKHoSo"></div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>
<asp:HiddenField runat="server" Visible="false" ID="ViewID" />

<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
<script>
    $('#chartTKHoSo').highcharts({
        colors: ['#0066ff', '#ED561B', '#999966'],
        credits: { enabled: false },
        chart: {
            type: 'column'
        },
        title: {
            text: 'Thống kê tình trạng hồ sơ'
        },
        xAxis: {
            categories: [
                'Đăng ký trợ cấp TN',
                'Đăng ký học nghề',
                'Đăng ký tư vấn GTVL',
                'Thông báo tìm kiếm VL'
            ],
            crosshair: true
        },
        yAxis: {
            min: 0,
            title: {
                text: 'Hồ sơ'
            }
        },
        tooltip: {
            headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
            pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
                '<td style="padding:0"><b>{point.y:.1f} hồ sơ</b></td></tr>',
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
        series: [{
            name: 'Hồ sơ mới nộp',
            data: [<%=DataMN%>]

        }, {
                name: 'Hồ sơ đã tiếp nhận',
                data: [<%=DataTN%>]

            }]
    });
</script>
