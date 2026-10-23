<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomePage.ascx.vb" Inherits="DesktopModules.Modules.HomePage" %>
<div class="row"></div>
<div class="row">
    <div class="col-md-5 hidden-md">
        <div class="search-box">
            <div class="col-md-12">
                <asp:TextBox runat="server" class="TextBox txt-center" ID="txtSearch" placeholder="Mã số hồ sơ" onkeypress="return clickButton(event,'')" />
            </div>
            <div class="col-md-12">
                <span>Nhập vào mã số tiếp nhận để kiểm tra tình trạng xử lý hồ sơ.</span>
            </div>
            <div class="col-md-12">
                <asp:LinkButton Text="text" ID="cmSearch" CssClass="cmSearch" runat="server">
                        <img src="/image/images/view.png?dpi=150&quality=100" alt="Tìm kiếm" />Tra cứu hồ sơ
                </asp:LinkButton>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>
    </div>
    <div class="col-md-7">
        <div class="box-proce">
            <div class="col-md-12 pdbt20">
                <asp:DropDownList ID="drPortal" runat="server" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="clear"></div>
            <div class="col-md-6 col-bhtn1">
                <div class="box-send">
                    <asp:LinkButton ID="cmdBHTN" runat="server">
                        <img src="/image/bhtn/bhtn.png?dpi=150&quality=100&w=90" alt="BHTN" />
                        <div class="row">
                            Đăng ký 
                            <br />
                            trợ cấp thất nghiệp
                        </div>
                    </asp:LinkButton>
                </div>
            </div>
            <div class="col-md-6 col-bhtn2">
                <div class="box-send">
                    <asp:LinkButton ID="cmdHocNghe" runat="server">
                        <img src="/image/bhtn/hocnghe.png?dpi=150&quality=100&w=90" alt="Học nghề" />
                        <div class="row">
                            Đăng ký
                            <br />
                            hỗ trợ học nghề
                        </div>
                    </asp:LinkButton>
                </div>
            </div>

            <div class="clear-box"></div>
            <div class="col-md-6 col-bhtn1">
                <div class="box-send">
                    <asp:LinkButton ID="cmdTuVan" runat="server">
                        <img src="/image/bhtn/tuvan.png?dpi=150&quality=100&w=90" alt="Tư vấn" />
                        <div class="row">
                            Đăng ký tư vấn
                            <br />
                            giới thiệu việc làm
                        </div>
                    </asp:LinkButton>
                </div>
            </div>
            <div class="col-md-6 col-bhtn2">
                <div class="box-send">
                    <asp:LinkButton ID="cmdKhaiBao" runat="server">
                        <img src="/image/bhtn/thongbao.png?dpi=150&quality=100&w=90" alt="Thông báo" />
                        <div class="row">
                            Thông báo
                            <br />
                            tìm kiếm việc làm
                        </div>
                    </asp:LinkButton>
                </div>
            </div>
            <div class="col-md-4 col-bhtn1 none">
                <div class="box-send">
                    <asp:LinkButton ID="cmdXepHang" runat="server">
                        <img src="/image/bhtn/xephang.png?dpi=150&quality=100&w=90" alt="Xếp hàng" />
                        <div class="row">
                            Đăng ký
                            <br />
                            lấy số thứ tự
                        </div>
                    </asp:LinkButton>
                </div>
            </div>
            <div class="clear"></div>
            <div class="col-md-12">
                <%--<h1>CỔNG DỊCH VỤ CÔNG TRỰC TUYẾN</h1>
                <h2>CỤC VIỆC LÀM - BỘ LAO ĐỘNG THƯƠNG BINH VÀ XÃ HỘI</h2>
                <h3>Nơi thực hiện chức năng <b>"Một cửa điện tử"</b> cho phép tiếp nhận, xử lý, trả kết quả và tra cứu về tình trạng xử lý hồ sơ.</h3>--%>
                <h4>Để nộp hồ sơ, vui lòng chọn đơn vị tiếp nhận xử lý hồ sơ, sau đó điền đầy đủ thông tin rồi bấm nút nộp hồ sơ.</h4>
            </div>
            <div class="clear"></div>
        </div>
    </div>
    <div class="col-md-5 hidden-xs">
        <div class="search-box">
            <div class="col-md-12">
                <asp:TextBox runat="server" class="TextBox txt-center" ID="txtSearch1" placeholder="Mã số hồ sơ" onkeypress="return clickButton(event,'')" />
            </div>
            <div class="col-md-12">
                <span>Nhập vào số giấy biên nhận để kiểm tra tình trạng xử lý hồ sơ.</span>
            </div>
            <div class="col-md-12">
                <asp:LinkButton Text="text" ID="cmSearch1" CssClass="cmSearch" runat="server">
                        <img src="/image/images/view.png?dpi=150&quality=100" alt="Tìm kiếm" />Tra cứu hồ sơ
                </asp:LinkButton>
            </div>
            <div class="col-md-12 pdt10 ">
                <div id="container" style="width: 100%; height: 280px; margin: 0 auto"></div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>
    </div>

    <div class="clear"></div>
</div>
<script type="text/javascript" src="/js/validation/highcharts.js?v=2.1.5"></script>
<script type="text/javascript" src="/js/validation/exporting.js?v=2.1.5"></script>

<script>
    function showSearch() { if ($("#txtSearch").val() == "") { return false; } else { doSearchSite("txtSearch"); } };
    function replace(e) { for (i = 0; i < e.length; i++) { e = e.replace(".", "-1A"); e = e.replace(":", "-2A"); e = e.replace('"', "-3A"); e = e.replace('`', "-4A"); e = e.replace('!', "-5A"); e = e.replace("'", "-6A"); e = e.replace("@", "-1B"); e = e.replace("#", "-2B"); e = e.replace("$", "-3B"); e = e.replace('^', "-4B"); e = e.replace('&', "-5B"); e = e.replace('*', "-6B"); e = e.replace("(", "-1C"); e = e.replace(")", "-2C"); e = e.replace("|", "-3C"); e = e.replace('{', "-4C"); e = e.replace('}', "-5C"); e = e.replace('?', "-6C"); e = e.replace('+', "-7C"); e = e.replace("~", "-1D"); e = e.replace(" ", "-"); e = e.replace("<", "-3D"); e = e.replace('>', "-4D"); e = e.replace('/', "-5D"); e = e.replace("'\'".replace("'", ''), '-6D'); e = e.replace('_', "-2D"); } return e; }
    function doSearchSite(id) { var url = "<%=DotNetNuke.EPORTAL.flReg.UrlAlias %>/tim-kiem"; var e = ""; var link = window.location.href; e = $("#" + id).val().trim(), e = replace(e), "" != e.toString() && (window.location.href = url + "/q/" + encodeURI(e)) };
    $("#<%=txtSearch.ClientID%>").on("keypress", function (e) { var n = e ? e : window.event; if (n.keyCode == 13) { return clickButton(event, '<%=cmSearch.ClientID%>'); } });
    Highcharts.chart('container', {
        chart: { plotBackgroundColor: null, plotBorderWidth: null, plotShadow: false, type: 'pie' },
        credits: { enabled: false }, title: { text: '' },
        tooltip: { pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>' },
        accessibility: { point: { valueSuffix: '%' } },
        plotOptions: {
            pie: { allowPointSelect: true, cursor: 'pointer', dataLabels: { enabled: false }, showInLegend: true }
        },
        series: [{
            name: 'Brands', colorByPoint: true,
            data: [
                { name: 'Đăng ký trợ cấp thất nghiệp', y: 61.41, sliced: true, selected: true },
                { name: 'Đăng ký học nghề', y: 11.84 },
                { name: 'Đăng ký tư vấn giới thiệu việc làm', y: 10.85 },
                { name: 'Thông báo tìm kiếm việc làm', y: 4.67 }]
        }]
    });
</script>
