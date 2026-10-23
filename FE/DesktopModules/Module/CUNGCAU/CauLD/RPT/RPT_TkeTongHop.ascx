<%@ Control Language="vb" CodeFile="RPT_TkeTongHop.ascx.vb" Inherits="Modules.DTNGHE_ThongKeView.View" %>


<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thống kê biến động theo tình trạng</h3>

        </div>
          
    </div>
    <div class="box-body">
        <div class="row">
           <%-- <div class="col-md-2 ">
                <asp:DropDownList ID="drType" runat="server" AutoPostBack="true" CssClass="selectpicker " />
            </div>--%>
       <%--     <div class="col-md-2 lb pdt5">Khoảng số lượng</div>
            <div class="col-md-2 ">
              <asp:TextBox runat="server" CssClass="TextBox" placeholder="Từ" ID="txtFrom" Text="0" Width="50" ></asp:TextBox>
              -
                <asp:TextBox runat="server"  CssClass="TextBox" placeholder="Đến" ID="txtTo" Text="50" Width="50" ></asp:TextBox>
                 </div>--%>
              <div class="col-md-3 ">
      <asp:DropDownList ID="PhuongXa" runat="server" AutoPostBack="true" CssClass="selectpicker PhuongXa" />
  </div>
  <div class="col-md-2 ">
      <asp:DropDownList ID="TrangThai" runat="server" AutoPostBack="true" CssClass="selectpicker " />
  </div>
  <div class="col-md-2">
      <asp:DropDownList ID="drYear" CssClass="selectpicker" AutoPostBack="true" runat="server" />
  </div>
            <div class="col-md-5">
            <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm theo tên, email, sđt doanh nghiệp..." CssClass="timKiemD" Columns="20" Width="100%" />
            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                  </div>
        </div>
        <div id="chartContainer" style="width: 100%; height: 400px;"></div>
    </div>
</div>

<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>

<script type="text/javascript">
    document.addEventListener('DOMContentLoaded', function () {
        Highcharts.chart('chartContainer', {
            // *** THAY ĐỔI: Bộ màu mới cho biểu đồ ***
            colors: [
                '#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',
                '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a'
            ],
            credits: { enabled: false },
            chart: {
                type: 'column',
            },
            // Trục hoành (X) - hiển thị tên ngành nghề
            xAxis: {
                type: 'category', // Trục X dạng danh mục
                title: {
                    text: 'Loại biến động'
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
                text: 'Thống kê biến động theo tình trạng'
            },
            // Tooltip khi di chuột vào cột
            tooltip: {
                headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
                pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}</b> DN<br/>'
            },
            // Chuỗi dữ liệu
            series: [{
                name: 'Số lượng doanh nghiệp',
                colorByPoint: true, // Giữ màu sắc cho từng cột
                data: chartData     // Dữ liệu từ code-behind vẫn giữ nguyên định dạng
            }]

        });
    });
</script>
