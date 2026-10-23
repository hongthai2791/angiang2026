<%@ Control Language="vb" CodeFile="AnalyView2.ascx.vb" Inherits="Modules.Targets.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Dự báo chỉ tiêu
                <asp:Literal runat="server" ID="ltTitle"></asp:Literal></h3>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 pdt5">
                    <span style="font-weight: bold" title="Chọn dữ liệu của quá khứ để phân tích"><i class="fa fa-exchange"></i>&nbsp;Khoảng quan sát</span>
                </div>
                <div class="col-md-2">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year1" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-2">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year2" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-2 text-right pdt5">
                    <strong><i title="Số năm dự báo" class="fa fa-question-circle"></i>&nbsp;Số năm dự báo</strong>
                </div>
                <div class="col-md-1">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" MinValue="1" MaxValue="7" ID="txtSoNam" CssClass="TextBox" Value="5" runat="server"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="ChartType_ID" CssClass="selectpicker" runat="server" />
                </div>
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
                            <ItemStyle HorizontalAlign="Center" Width="20%" CssClass="column-primary" />
                            <HeaderStyle HorizontalAlign="Center" Width="20%" CssClass="column-primary" />
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
                        <asp:TemplateColumn HeaderText="GDP">
                            <ItemTemplate>
                                <div class="col-sm-12 pd0">
                                    <asp:Literal ID="Data2" runat="server" />
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
                        <asp:TemplateColumn HeaderText="Hệ số b" Visible="false">
                            <ItemTemplate>
                                <div class="col-sm-12 pd0">
                                    <asp:TextBox ID="HeSoB" type="number" runat="server" CssClass="TextBox noborder" />
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
                <div class="col-md-12">
                    <div class="h5-title" style="width: 100%">
                        <asp:DropDownList ID="drScene" CssClass="selectpicker" runat="server" />
                    </div>
                </div>
                <asp:DataGrid ID="grdKichBan" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                    <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                    <ItemStyle BackColor="#fbf2ec" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderText="STT">
                            <ItemTemplate>
                                <asp:Literal runat="server" ID="IsOrder" />
                            </ItemTemplate>
                            <ItemStyle Width="11%" CssClass="respo-view" />
                            <HeaderStyle Width="11%" CssClass="respo-title" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Năm">
                            <ItemTemplate>
                                <asp:Literal runat="server" ID="txtYear" />
                            </ItemTemplate>
                            <ItemStyle Width="20%" CssClass="column-primary" />
                            <HeaderStyle Width="20%" CssClass="column-primary" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Số liệu">
                            <ItemTemplate>
                                <div class="col-sm-12 pd0">
                                    <asp:Literal ID="Data1" runat="server" />
                                </div>
                            </ItemTemplate>
                            <ItemStyle CssClass="Contents respo-view" />
                            <HeaderStyle CssClass="Contents respo-title" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div class="col-md-8">
                <div class="col-md-12">

                    <%--cot--%>
                    <asp:Panel runat="server" Visible="false" ID="pnchart1">
                        <div class="row">
                            <div id="chartForeCast"></div>
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
                    <div class="panel panel-warning pd5 ">
                        <p>- Phương pháp dự báo: <b style="line-height: 25px;">Dựa trên phương pháp hồi qui bình phương tối thiểu, hồi qui đa biến</b> </p>
                        - Ký tự <b>(*)</b> là ký hiệu dự báo của các năm tương lai
                    </div>
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
        <asp:Button ID="cmdRefresh" runat="server" Text="Xem kết quả dự báo" CssClass="cmsbut Refresh cbclick " OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại kết quả" CssClass="cmsbut cmdsave " OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdSettings" runat="server" CssClass="cmdbtt cmdSettings" Text="Thiết lập" Visible="false" />
    </div>
</div>
<asp:HiddenField ID="ItemID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="TargetID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="GroupID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="GroupGPD_ID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="TargetGDP_ID" Value="0" runat="server" Visible="false" />
<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
<script>
    $('#chartForeCast').highcharts({
        colors: ['#00c0ef', '#ED561B', '#99ff33'],
        credits: { enabled: false },
        chart: {
            zoomType: 'xy'
        },
        title: {
            text: '<%=TitleChart%>'
        },
        xAxis: [{
            categories: [<%=XYear%>],
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
                    text: 'Số lượng ( <%=DonViTinh%>)',
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
        series: [{
            name: 'Số lượng',
            type: 'column',
            yAxis: 1,
            data: [<%=DataChart1%>],
            tooltip: {
                valueSuffix: ' <%=DonViTinh%>'
            }

        },
        <%=GDPValue%>
        ]
    });
    $('#chartForeCast2').highcharts({
        colors: ['#00c0ef', '#ED561B', '#99ff33'],
        credits: { enabled: false },
        chart: {
            zoomType: 'xy'
        },
        title: {
            text: '<%=TitleChart%>'
        },
        xAxis: [{
            categories: [<%=XYear%>],
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
                    text: 'Số lượng ( <%=DonViTinh%>)',
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
        series: [{
            name: 'Số lượng',
            type: 'line',
            yAxis: 1,
            data: [<%=DataChart1%>],
            tooltip: {
                valueSuffix: ' <%=DonViTinh%>'
            }

        },
        <%=GDPValue%>
        ]
    });
    $('#chartForeCast3').highcharts({
        colors: ['#00c0ef', '#ED561B', '#99ff33'],
        credits: { enabled: false },
        chart: {
            zoomType: 'xy'
        },
        title: {
            text: '<%=TitleChart%>'
        },
        xAxis: [{
            categories: [<%=XYear%>],
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
                    text: 'Số lượng ( <%=DonViTinh%>)',
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
        series: [{
            name: 'Số lượng',
            type: 'areaspline',
            yAxis: 1,
            data: [<%=DataChart1%>],
            tooltip: {
                valueSuffix: ' <%=DonViTinh%>'
            }

        },
        <%=GDPValue%>
        ]
    });
   
</script>
