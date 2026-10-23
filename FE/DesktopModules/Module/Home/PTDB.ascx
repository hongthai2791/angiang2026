<%@ Control Language="VB" AutoEventWireup="false" CodeFile="PTDB.ascx.vb" Inherits="DesktopModules.Modules.PTDB" %>
<link href="../../../Portals/_default/Skins/VBN/css/Skin.css?v=2.1" rel="stylesheet" />
<link href="../../../Portals/_default/Skins/VBN/css/member.css?v=2.1" rel="stylesheet" />
<div class="detail-post row hnoneview">
    <h1 class="post-title pd10">
        <asp:Literal ID="lbTitle" runat="server" Text="..."></asp:Literal>
    </h1>
    <div class="col-md-4">
        <asp:DataGrid ID="grdAnalytic" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
            <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
            <ItemStyle BackColor="#fbf2ec" />
            <AlternatingItemStyle BackColor="#ffffff" />
            <Columns>
                <asp:TemplateColumn HeaderText="STT">
                    <ItemTemplate>
                        <asp:Literal runat="server" ID="IsOrder" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="11%" CssClass="respo-view" />
                    <HeaderStyle HorizontalAlign="Center" Width="11%" CssClass="respo-title" />
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Năm">
                    <ItemTemplate>
                        <asp:Literal runat="server" ID="txtYear" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" Width="30%" CssClass="column-primary" />
                    <HeaderStyle HorizontalAlign="Center" Width="30%" CssClass="column-primary" />
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Số liệu">
                    <ItemTemplate>
                        <div class="col-sm-12 pd0">
                            <asp:Literal ID="Data1" runat="server" />
                        </div>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" CssClass="Contents respo-view" />
                    <HeaderStyle HorizontalAlign="Center" CssClass="Contents respo-title" />
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="IsFlag">
                    <ItemTemplate>
                        <div class="col-sm-12 pd0">
                            <asp:TextBox ID="IsFlag" type="number" runat="server" CssClass="TextBox noborder" />
                        </div>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" CssClass="Contents respo-view none" />
                    <HeaderStyle HorizontalAlign="Center" CssClass="Contents respo-title none" />
                </asp:TemplateColumn>
            </Columns>
        </asp:DataGrid>
        <div class="row pdt5">
            - Màu  <span class="fa fa-circle" style="color: yellowgreen"></span>&nbsp; là ký hiệu dự báo của các năm tương lai
        </div>
    </div>
    <div class="col-md-8">
        <div class="col-md-12">
            <%--cot--%>
            <asp:Panel runat="server" Visible="false" ID="pnchart1">
                <div class="row">
                    <div id="chartForeCast1"></div>
                </div>
            </asp:Panel>
            <%--duong--%>
            <asp:Panel runat="server" Visible="false" ID="pnchart2">
                <div class="row">
                    <div id="chartForeCast2"></div>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" Visible="false" ID="pnchart3">
                <%--duong khu vuc--%>
                <div class="row">
                    <div id="chartForeCast3"></div>
                </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <div class="panel panel-warning pd5">
                Ký tự <b>(*)</b>  là ký hiệu dự báo của các năm tương lai
            </div>
        </div>
    </div>

</div>

<script src="/js/rageslider.js"></script>
<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
<script>
    $('#chartForeCast1').highcharts({
        colors: ['#00c0ef', '#ED561B'],
        credits: { enabled: false },
        chart: {
            type: 'column'
        },
        title: {
            text: '<%=TitleChart%>'
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: 'Số lượng (<%=DonViTinh%>)'
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
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.0f} <%=DonViTinh%></b><br/>'
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

    $('#chartForeCast2').highcharts({
        colors: ['#99ff33', '#ffa31a'],
        credits: { enabled: false },
        chart: {
            type: 'line'
        },
        title: {
            text: '<%=TitleChart%>'
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: 'Số lượng (<%=DonViTinh%>)'
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
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.0f} <%=DonViTinh%></b><br/>'
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
    $('#chartForeCast3').highcharts({
        colors: ['#009900', '#ffbf00'],
        credits: { enabled: false },
        chart: {
            type: 'areaspline'
        },
        title: {
            text: '<%=TitleChart%>'
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
            categories: [<%=XYear%>]
        },
        yAxis: {
            title: {
                text: 'Số lượng (<%=DonViTinh%>)'
            }
        },
        tooltip: {
            shared: true,
            valueSuffix: ' <%=DonViTinh%>',
            headerFormat: '<span style="font-size:11px">{series.name}</span> ',
            pointFormat: '<span > {point.name}</span>: <b> {point.y:.0f} <%=DonViTinh%></b><br/>'
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
            data: [<%=DataChart1%>]
        }]
    });
</script>
