<%@ Control Language="vb" CodeFile="Report2.ascx.vb" Inherits="Modules.Report.view" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Lựa chọn các chỉ tiêu đầu ra của dự báo </h3>
        </div>
        
        <div class="col-md-6 alert alert-warning mgbt0">
                Chức năng này chạy dữ liệu từ các nhóm chỉ tiêu tổng hợp
        </div>
        <div class="col-md-3 none">
            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:UpdatePanel ID="upReport2" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-2 lb">Chọn nhóm chỉ tiêu</div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="drGroupID" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drTagetID" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 ">
                            <asp:DropDownList ID="ChartType_ID" CssClass="selectpicker" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="drGroupID" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="row">
                <div class="col-md-2 pdt5">
                    <a style="color: brown; font-weight: bold" title="Chọn dữ liệu của quá khứ để phân tích"><i class="fa fa-exchange"></i>&nbsp;Khoảng quan sát</a>
                </div>
                <div class="col-md-3">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year1" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-3">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year2" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-2 text-right pdt5">
                    <strong>Số năm &nbsp;  <i title="Số năm dự báo" class="fa fa-question-circle"></i></strong>
                </div>
                <div class="col-md-2">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" MinValue="1" MaxValue="7" ID="txtSoNam" CssClass="TextBox" Value="5" runat="server"></telerik:RadNumericTextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="col-md-4">
                <div class="col-md-12">
                    <div class="h5-title">Bảng thống kê số liệu</div>
                </div>
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
                <div class="row">
                    <p>- Ghi chú: Màu  <span class="fa fa-circle" style="color: yellowgreen; padding-top: 10px"></span>&nbsp;là ký hiệu dự báo của các năm tương lai</p>
                    <strong>Lưu ý:</strong> &nbsp; Dữ liệu được tổng hợp từ các kết quả đã lưu lại từ phần dự báo
                </div>
            </div>
            <div class="col-md-8">
                <div class="col-md-12 pdr0">
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
                <div class="col-md-12 panel panel-warning pd5 green">
                    <p>- Phương pháp dự báo: <b style="line-height: 25px">Dựa trên phương pháp hồi qui bình phương tối thiểu, hồi qui đa biến</b> </p>
                    - Ghi chú: Ký tự <b>(*)</b> là ký hiệu dự báo của các năm tương lai
                </div>
            </div>
            <div class="clear"></div>
        </div>
        <asp:Literal runat="server" ID="litPage"></asp:Literal>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
        <asp:Button ID="cmdRefresh" runat="server" Text="Xem kết quả" CssClass="cmsbut Refresh cbclick " OnClientClick="return retunwaiting();" />
    </div>
</div>

<asp:HiddenField ID="ItemID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="TargetID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="GroupID" Value="0" runat="server" Visible="false" />
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
