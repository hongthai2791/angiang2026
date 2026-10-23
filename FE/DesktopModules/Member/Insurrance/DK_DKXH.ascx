<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="DK_DKXH.ascx.vb" Inherits="DesktopModules.Modules.HomePage" %>
<%@ Register Src="~/admin/Captcha/VbCapchar.ascx" TagPrefix="uc1" TagName="VbCapchar" %>

<div class="hs-bhtn">
    <div class="row">
        <div class="col-md-12">
            <h1 class="box-title mgbt0 pdbt0">ĐĂNG KÝ LẤY SỐ TỰ ĐỘNG</h1>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <div class="col-md-12">Ngày đăng ký</div>
            <div class="col-md-12">
                <asp:TextBox ID="NgayDangKy" runat="server" ReadOnly="true" CssClass="TextBox NgayDangKy validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="col-md-12">
                <div id="container" style="height: 300px;"></div>
                <div class="clear"></div>
            </div>
            <div class="clear"></div>
            <div class="row toolbar-dk">
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
            </div>
        </div>
        <div class="col-md-8 mgt30">
            <div class="col-md-12 ">
                <div class="row">
                    <div class="col-md-2 pdt5">Kính gửi</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="drPortal" runat="server" onchange="changefocus(this);" inext="HoTen" CssClass="drPortal selectpicker validate[required]"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                </div>
                <div class="col-md-2 lb">Vệ tinh</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="VeTinh" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="clear"></div>
                    <div class="col-md-4 pdt5">Họ và tên</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="HoTen" runat="server" onkeypress="return keydownfocus(event,'NgaySinh',0);" CssClass="TextBox HoTen validate[required]"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdt5">Điện thoại</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="DienThoai" runat="server" onkeypress="return keydownfocus(event,'QD_Ngay',0);" CssClass="TextBox DienThoai validate[required, minSize[10]]" MaxLength="10"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdt5 ">Email liên hệ</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="Email" runat="server" onkeypress="return keydownfocus(event,'DienThoai',0);" CssClass="TextBox Email validate[required, custom[email]]"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
            <div class="clear"></div>
            <div class="col-md-12 ">
                <div class="row">
                    <div class="col-md-12 ds-layso">DANH SÁCH DỊCH VỤ ĐĂNG KÝ LẤY SỐ</div>
                    <div class="col-md-12 ">
                        <table class="table-bordered respo-table" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                            <tbody>
                                <tr class="head hdTitle">
                                    <td class="fix-column STT" style="width: 4%; text-align: center">STT</td>
                                    <td class="column-primary" style="width: 70%;">Dịch vụ đăng ký</td>
                                    <td class="DangKy respo-title" style="width: 26%; text-align: center">Đăng ký lấy số</td>
                                </tr>
                                <tr class="xephang" style="background-color: #E9F7FF;">
                                    <td class="fix-column STT" style="width: 4%; text-align: center">1</td>
                                    <td class="column-primary" style="width: 70%;">Nộp hồ sơ đăng ký hưởng bảo hiểm thất nghiệp
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                    </td>
                                    <td class="DangKy respo-view" style="width: 26%; text-align: center">
                                        <asp:Button ID="cmdDK1" runat="server" CssClass="cmsbut cblayso" Text="Lấy số" />
                                    </td>
                                </tr>
                                <tr class="xephang" style="background-color: #FFF;">
                                    <td class="fix-column STT" style="width: 4%; text-align: center">2</td>
                                    <td class="column-primary" style="width: 70%;">Nộp hồ sơ đăng ký hỗ trợ học nghề
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                    </td>
                                    <td class="DangKy respo-view" style="width: 26%; text-align: center">
                                        <asp:Button ID="cmdDK2" runat="server" CssClass="cmsbut cblayso" Text="Lấy số" />
                                    </td>
                                </tr>
                                <tr class="xephang" style="background-color: #E9F7FF;">
                                    <td class="fix-column STT" style="width: 4%; text-align: center">3</td>
                                    <td class="column-primary" style="width: 70%;">Nộp hồ sơ đăng ký tư vấn, giới thiệu việc làm
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                    </td>
                                    <td class="DangKy respo-view" style="width: 26%; text-align: center">
                                        <asp:Button ID="cmdDK3" runat="server" CssClass="cmsbut cblayso" Text="Lấy số" />
                                    </td>
                                </tr>
                                <tr class="xephang" style="background-color: #FFF;">
                                    <td class="fix-column STT" style="width: 4%; text-align: center">4</td>
                                    <td class="column-primary" style="width: 70%;">Nộp hồ sơ đăng ký thông báo tìm kiếm việc làm
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                    </td>
                                    <td class="DangKy respo-view" style="width: 26%; text-align: center">
                                        <asp:Button ID="cmdDK4" runat="server" CssClass="cmsbut cblayso" Text="Lấy số" />
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>
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
        chart: { type: 'gauge', plotBackgroundColor: null, plotBackgroundImage: null, plotBorderWidth: 0, plotShadow: false, height: '300px' },
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
                text: 'GMT/UTC +7 HÀ NỘI',
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
    function thongbao() { $("#dkxhTbao").modal("show"); $(".personalBarContainer").addClass("andi"); };
</script>
<div class="modal dangky" role="dialog" id="dkxhTbao">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title">Thông báo</h5>
            </div>
            <div class="modal-body">
                <asp:Literal ID="lbThongBao" runat="server"></asp:Literal>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
            </div>
        </div>
    </div>
</div>
