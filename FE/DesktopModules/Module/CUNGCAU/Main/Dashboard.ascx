<%@ Control Language="vb" Inherits="Home.Dashboad.View" CodeFile="Dashboard.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Hệ thống quản lý nhập tin cung cầu <%=Now.Year %></h3>
        </div>
         <asp:UpdatePanel runat="server">
     <ContentTemplate>
     <div class="clear"></div>
     <div class="col-md-2  lb">Tỉnh/TP</div>
     <div class="col-md-4">
         <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker " />
     </div>
     <div class="col-md-2  lb">Quận/huyện</div>
     <div class="col-md-4">
         <asp:DropDownList ID="drQuanHuyen" AutoPostBack="true" runat="server" CssClass="selectpicker " />
     </div>
     <div class="clear"></div>
     <div class="col-md-2 lb">Phường/xã</div>
     <div class="col-md-4">
         <asp:DropDownList ID="drPhuongXa" AutoPostBack="true" runat="server" CssClass="selectpicker " />
     </div>
     </ContentTemplate>

 </asp:UpdatePanel>
     <div class="col-md-2 lb">Năm BC</div>
     <div class="col-md-2">
         <asp:DropDownList ID="drYear" runat="server" CssClass="selectpicker " />
     </div>
     <div class="col-md-2">
         <asp:Button ID="cmdRefresh" runat="server" Text="Xem dữ liệu" CssClass="cmsbut cmdview" />
     </div>
     <div class="clear"></div>
    </div>
       <div class="box-body">
        <div class="main-body">
            
            <div class="row">
                <div class="col-md-4  col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-aqua"><i class="fa fa-users"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text">Tổng số lao động</span>
                            <span class="info-box-number" ><%=chartInfo.TotalNum1 %></span>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-red"><i class="fa fa-male"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text" >Số lao động Nam</span>
                            <span class="info-box-number"><%=chartInfo.TotalNum2 %></span>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-xs-12">
                    <div class="info-box">
                        <span class="info-box-icon bg-green"><i class="fa fa-female"></i></span>

                        <div class="info-box-content">
                            <span class="info-box-text">Số lao động nữ</span>
                            <span class="info-box-number"><%=chartInfo.TotalNum3 %></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="box">
                    <div id="containerChart">

                    </div>
                </div>
            </div>
        </div>
    </div>

    <asp:HiddenField ID="YearPro" runat="server" Visible="false" />
    <asp:HiddenField ID="IsNow" runat="server" Visible="false" />
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
     $('#containerChart').highcharts({
        credits: { enabled: false },
        chart: {
            type: 'column'
        },
        title: {
            text: 'Biểu đồ thống kê LĐ theo tình trạng tham gia HĐKT'
        },
        xAxis: {
            categories: [
                'Lao động có việc làm',
                'Lao động thất nghiệp',
                'Không hoạt động kinh tế'
            ]
        },
        yAxis: {
            min: 0,
            title: {
                text: ''
            }
        },
        tooltip: {
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
        series:  [{
            name: 'Số người',
            data: [<%=chartInfo.Num1 %>, <%=chartInfo.Num2 %>, <%=chartInfo.Num3 %>]
         }]
     });
</script>