<%@ Control Language="vb" CodeFile="CalcGroup.ascx.vb" Inherits="Modules.Report.CalcGroup" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Tổng hợp số liệu giữa các nhóm chỉ tiêu</h3>
        </div>

        <div class="col-md-6 alert alert-warning mgbt0">
            Chức năng này chạy dữ liệu từ các nhóm số liệu thô
        </div>
        <div class="col-md-1 lb text-center none">Tỉnh/TP</div>
        <div class="col-md-3 none">
            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
        </div>

        <div class="clear"></div>
    </div>
    <div class="box-body qlte">
        <div class="main-body">
            <div class="col-md-2 lb text-center">Loại biểu đồ</div>
            <div class="col-md-2">
                <asp:DropDownList ID="drChartType" runat="server" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="col-md-2 lb text-center">Loại dữ liệu</div>
            <div class="col-md-2">
                <asp:DropDownList ID="drDataType" runat="server" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="col-md-2 lb text-center">Kỳ dữ liệu</div>
            <div class="col-md-2">
                <asp:DropDownList ID="drYear" runat="server" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="clear"></div>
            <asp:UpdatePanel runat="server" ID="upGroup1">
                <ContentTemplate>
                    <div class="col-md-6 pdl0">
                        <div class="col-md-4 lb text-center">Nhóm chỉ tiêu 1</div>
                        <div class="col-md-8">
                            <asp:DropDownList ID="drGroup1" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-4  text-center lb">Chỉ tiêu nhóm 1</div>
                        <div class="col-md-8">
                            <asp:DropDownList ID="drTarRow" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-4 text-center lb">Danh mục nhóm 1</div>
                        <div class="col-md-8">
                            <asp:DropDownList ID="drCateTar" data-actions-box="true" multiple="multiple" runat="server" CssClass="selectpicker"></asp:DropDownList>
                            <asp:HiddenField ID="HidCateTar" runat="server" />
                        </div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="drGroup1" />
                    <asp:AsyncPostBackTrigger ControlID="drTarRow" />
                    <asp:AsyncPostBackTrigger ControlID="drCateTar" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:UpdatePanel runat="server" ID="upGroup2">
                <ContentTemplate>
                    <div class="col-md-6">
                        <div class="col-md-4 lb text-center">Nhóm chỉ tiêu 2</div>
                        <div class="col-md-8">
                            <asp:DropDownList ID="drGroup2" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-4 text-center  lb">Chỉ tiêu nhóm 2</div>
                        <div class="col-md-8">
                            <asp:DropDownList ID="drTarRow2" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-4 text-center lb">Danh mục nhóm 2</div>
                        <div class="col-md-8">
                            <asp:DropDownList ID="drCateTar2" data-actions-box="true" multiple="multiple" runat="server" CssClass="selectpicker"></asp:DropDownList>
                            <asp:HiddenField ID="HidCateTar2" runat="server" />
                        </div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="drGroup2" />
                    <asp:AsyncPostBackTrigger ControlID="drTarRow2" />
                    <asp:AsyncPostBackTrigger ControlID="drCateTar2" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="clear"></div>
            <div class="row">
                <div class="col-md-5">
                    <asp:Literal runat="server" ID="litData" />
                </div>

                <div class="col-md-7">
                    <div id="chartForeCast1"></div>
                </div>
                <div class="clr"></div>
                <asp:Literal ID="lbmsg" runat="server"></asp:Literal>
                <div class="clear"></div>
            </div>
        </div>
    </div>

    <div class="fix-btt-toolbar">
        <div>
            <asp:Button runat="server" ID="cmdView" OnClientClick="getMultiple();" Text="Xem kết quả" class="cmsbut cmdview"></asp:Button>
        </div>
    </div>
    <script src="/js/validation/highcharts.js?v=1.2"></script>
    <script src="/js/validation/exporting.js?v=1.2"></script>
    <script>
        function setMultiple() {
            var vdata = $('#<%= HidCateTar.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
                $('#<%= drCateTar.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
                $("#<%= drCateTar.ClientID%>").trigger('selectpicker:updated');
            });
            var vdata2 = $('#<%= HidCateTar2.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
                $('#<%= drCateTar2.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= drCateTar2.ClientID%>").trigger('selectpicker:updated');
        });
        };
        function getMultiple() {
            $('#<%= HidCateTar.ClientID%>').val($("#<%= drCateTar.ClientID%>").val());
            $('#<%= HidCateTar2.ClientID%>').val($("#<%= drCateTar2.ClientID%>").val());
        };
        $('#chartForeCast1').highcharts({
            //colors: ['#00c0ef', '#ED561B'],
            credits: { enabled: false },
            chart: {
                type: '<%=ChartType%>'
            },
            title: {
                text: '<%=TitleChart%>'
            },
            xAxis: {
                categories: [<%=CategoryName%>],
                type: 'category'
            }, yAxis: {
                title: {
                    text: '<%=TypeText%>'
                }

            },
            legend: {
                enabled: true,
                //align: 'right',
                //x: -30,
                //verticalAlign: 'top',
                //y: 25,
                //floating: true,
                //backgroundColor:
                //    Highcharts.defaultOptions.legend.backgroundColor || 'white',
                //borderColor: '#CCC',
                //borderWidth: 1
            },
            plotOptions: {
                series: {
                    borderWidth: 0,
                    dataLabels: {
                        enabled: true,
                        format: '{point.y:.<%=FloatF%>}'
                    }
                }
            },

            tooltip: {
                headerFormat: '<span style="font-size:11px">{series.name}</span> ',
                pointFormat: '<span > {point.name}</span>: <b> {point.y:.<%=FloatF%>} </b><br/>'
            },

            series: [
                <%=DataChart1%>
            ]
        });


    </script>
