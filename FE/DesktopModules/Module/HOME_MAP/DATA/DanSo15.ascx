<%@ Control Language="vb" CodeFile="DanSo15.ascx.vb" Inherits="Modules.DanSo15.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>


<link href="/Portals/_default/leaflet/leaflet.css" rel="stylesheet" />
<link rel="stylesheet" href="/Portals/_default/leaflet/Control.FullScreen.css" />
<div class="box box-info">

    <div class="box-body">
        <div class="main-body ">
            <div class="row">
                <div class="col-md-3" style="padding: 0;">
                    <div class="text-center text-uppercase bg-green text-bg-primary title-map" style="color: #fff;">BẢN ĐỒ NHÓM DÂN SỐ 15+</div>
                    <div class="px-3" id="search-box">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Chỉ tiêu</label>
                            <asp:DropDownList runat="server" ID="drTargtes" CssClass="selectpicker mt10"></asp:DropDownList>
                        </div>
                        <%--<div class="form-group">
                            <label>Quận/huyện</label>
                            <asp:DropDownList runat="server" ID="drQuanHuyen" CssClass="selectpicker mt10"></asp:DropDownList>
                        </div>--%>
                        <div class="form-group">
                            <label>Phường/xã</label>
                            <asp:DropDownList runat="server" ID="drPhuongXa" CssClass="selectpicker mt10"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Thôn/tổ</label>
                            <asp:DropDownList runat="server" ID="drThonto" CssClass="selectpicker mt10"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputEmail1">Màu</label>
                            <asp:DropDownList runat="server" ID="drColor" CssClass="selectpicker mt10"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputEmail1">Năm</label>
                            <asp:DropDownList runat="server" ID="drNamBC" CssClass="selectpicker mt10"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Button Width="100%" runat="server" ID="btnViewMap" OnClick="btnViewMap_Click" CssClass="btn btn-primary" Text="Xem dữ liệu" />
                    </div>
                </div>
                <div class="col-md-9">
                    <div style="width: 100%; height: 585px;" id="map"></div>
                </div>
            </div>
            <div class="row mt10">
                <div class="col-md-3" style="padding: 0;">
                    <div class="text-center text-uppercase bg-green text-bg-primary title-map" style="color: #fff;">SỐ LIỆU DỰ BÁO & BIỂU ĐỒ</div>
                    <div class="px-3 pd10">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Khoảng quan sát</label>
                            <div class="mt10">

                                <telerik:RadNumericTextBox Width="45%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year1" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                                - 
                            <telerik:RadNumericTextBox Width="45%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year2" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>

                            </div>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputEmail1">Số năm dự báo</label>
                            <telerik:RadNumericTextBox Width="93%" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" MinValue="1" MaxValue="7" ID="txtSoNam" CssClass="TextBox mt10" Value="5" runat="server"></telerik:RadNumericTextBox>

                        </div>
                        <div class="row">
                            <asp:Button Width="100%" runat="server" ID="btnViewAnaly" OnClick="btnViewMap_Click" CssClass="btn btn-primary" Text="Xem dữ liệu" />
                        </div>
                        <div class="panel panel-warning pd10 mt10">
                            <p>- Màu&nbsp;<span class="fa fa-circle" style="color: yellowgreen"></span>&nbsp;là ký hiệu dự báo của các năm tương lai </p>
                            <p>- Phương pháp dự báo: <b style="line-height: 25px;">Dựa trên phương pháp hồi qui đa biến</b> </p>
                            - Ký tự <b>(*)</b>  là ký hiệu dự báo của các năm tương lai
                   
                        </div>
                    </div>
                </div>

                <div class="col-md-9">
                    <div style="width: 100%;">
                        <div class="col-md-4 pd10" style="background-color: #fff;">

                            <div>
                                Dự báo chỉ tiêu
                <asp:Literal runat="server" ID="ltTitle"></asp:Literal>
                            </div>
                            <asp:DataGrid ID="grdAnalytic" runat="server" CssClass="table-bordered respo-table mt10" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
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
                        </div>
                        <div class="col-md-4">
                            <div id="chartForeCast1"></div>
                        </div>
                        <div class="col-md-4">
                            <div id="chartForeCast2"></div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div class="clr clUp"></div>
</div>

<asp:HiddenField ID="TargetID" Value="0" runat="server" Visible="false" />
<%--<script src="/js/rageslider.js"></script>--%>

<script src="/Portals/_default/leaflet/leaflet-src.js"></script>
<script src="/Portals/_default/leaflet/Control.FullScreen.js"></script>

<script src="/portals/_default/resource/owlcarousel/owl.carousel.min.js?v=5.0.0.9"></script>
<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <asp:TextBox ID="TargetCode" runat="server" CssClass="BD_TargetCode hidden" />
        <asp:TextBox ID="MaHuyen" runat="server" CssClass="BD_MaHuyen hidden" />
        <asp:TextBox ID="MaXa" runat="server" CssClass="BD_MaXa hidden" />
        <asp:TextBox ID="MaThon" runat="server" CssClass="BD_MaThon hidden" />
        <asp:TextBox ID="MauSac" runat="server" CssClass="BD_MauSac hidden" />
        <asp:TextBox ID="NamBC" runat="server" CssClass="BD_NamBC hidden" />
        <asp:TextBox ID="Map_MaTinh" runat="server" CssClass="Map_MaTinh hidden" />
        <asp:TextBox ID="Map_TenTinh" runat="server" CssClass="Map_TenTinh hidden" />
        <asp:TextBox ID="Map_Lat" runat="server" CssClass="Map_Lat hidden" />
        <asp:TextBox ID="Map_Lng" runat="server" CssClass="Map_Lng hidden" />
        <asp:TextBox ID="Map_Zoom" runat="server" CssClass="Map_Zoom hidden" />
        <asp:TextBox ID="Map_MaxBounds" runat="server" CssClass="Map_MaxBounds hidden" />
    </ContentTemplate>
</asp:UpdatePanel>

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
                text: 'Số lượng '
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
            type: 'pie'
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
</script>

<script>
    var vrtimeout = 2000;
    var cities = [];
    var dataMap = [];
    var currentCity;
    var currentWard;
    //var makers = [];
    var markers = new L.FeatureGroup();
    var polylines = new L.FeatureGroup();
    var map;

    // Cấu hình backend để thay đổi được link map
    var pathAPI = 'https://tile.thunderforest.com/atlas/{z}/{x}/{y}.png?apikey=4bb0d1f946264840adc87b746159a513';
    var vietNamMarkers = [];
    //this.initQuanHuyen();
    this.GetDataLayers();
    //this.initCity();

    function addMarker(e) {
        // Add marker to map at click location; add popup window
        var strProp = "";
        if (e.type == 0) {
            strProp =
                `
                 <div>
                         Tỉnh TP: <strong>`+ e.city?.name + `</strong>
                 </div>
             `;
        }
        else if (e.type == 1) {
            strProp =
                `
                      <div>
                            Đơn vị HC: <strong>`+ e.ward.tenQuan + `</strong><br>
                            Tổng số: `+ e.ward.soLieu + `
                    </div>
                 `;

            var newMarker = new L.marker(e.latlng, {
                icon: L.divIcon({
                    iconSize: new L.Point(16, 16),
                    className: "icon-xa maker-wardId-" + e.ward.districtId
                })
            })
                .bindPopup(strProp)
                .on('click', function (data) {
                    setView(e.ward.lat, e.ward.lng, e.ward.zoom, e);
                });

            var polyline = L.polygon(reFormatData(e.ward.points), { color: e.ward.color, fillColor: e.ward.border_color, weight: 0, opacity: 0.5, fillOpacity: 0.1 })
                .on('click', function (data) {
                    setView(e.ward.lat, e.ward.lng, e.ward.zoom, e);
                });
            polyline.on('mouseover', function (e) {
                var wardId = e.sourceTarget.districtId;
                for (const [key, value] of Object.entries(markers["_layers"])) {
                    if (value.districtId == wardId) {
                        setPolylineHover(wardId, 1);
                        value.openPopup()
                        break;
                    }
                }
            });
            polyline.districtId = e.ward.districtId;
            newMarker.districtId = e.ward.districtId;
            markers.addLayer(newMarker);
            polylines.addLayer(polyline);
        }
        else if (e.type == 2) {
            strProp =
                `
          <div>
            Đơn vị HC: <strong>`+ e.ward.tenXa + `</strong><br>
            Tổng số: `+ e.ward.soLieu + `
    </div>
     `;
            var newMarker = new L.marker(e.latlng, {
                icon: L.divIcon({
                    iconSize: new L.Point(16, 16),
                    className: "icon-xa maker-wardId-" + e.ward.wardId
                })
            })
                .bindPopup(strProp)
                .on('click', function (data) {
                    setView(e.ward.lat, e.ward.lng, e.ward.zoom, e);
                });

            var polyline = L.polygon(reFormatData(e.ward.points), { color: e.ward.color, fillColor: e.ward.border_color, weight: 0, opacity: 0.5, fillOpacity: 0.1 })
                .on('click', function (data) {
                    setView(e.ward.lat, e.ward.lng, e.ward.zoom, e);
                });
            polyline.on('mouseover', function (e) {
                var wardId = e.sourceTarget.wardId;
                for (const [key, value] of Object.entries(markers["_layers"])) {
                    if (value.wardId == wardId) {
                        setPolylineHover(wardId, 2);
                        value.openPopup()
                        break;
                    }
                }
            });
            polyline.wardId = e.ward.wardId;
            newMarker.wardId = e.ward.wardId;
            markers.addLayer(newMarker);
            polylines.addLayer(polyline);
        }
        else {
            strProp =
                `
                  <div>
                    Đơn vị HC: <strong>`+ e.ward.tenXa + `</strong><br>
                    Tổng số: `+ e.ward.soLieu + `
            </div>
             `;
            var newMarker = new L.marker(e.latlng, {
                icon: L.divIcon({
                    iconSize: new L.Point(16, 16),
                    className: "icon-xa maker-wardId-" + e.ward.villageId
                })
            })
                .bindPopup(strProp)
                .on('click', function (data) {
                    setView(e.ward.lat, e.ward.lng, e.ward.zoom, e);
                });

            var polyline = L.polygon(reFormatData(e.ward.points), { color: e.ward.color, fillColor: e.ward.border_color, weight: 0, opacity: 0.5, fillOpacity: 0.1 })
                .on('click', function (data) {
                    setView(e.ward.lat, e.ward.lng, e.ward.zoom, e);
                });
            polyline.on('mouseover', function (e) {
                var wardId = e.sourceTarget.villageId;
                for (const [key, value] of Object.entries(markers["_layers"])) {
                    if (value.villageId == wardId) {
                        setPolylineHover(wardId, 2);
                        value.openPopup()
                        break;
                    }
                }
            });
            polyline.villageId = e.ward.villageId;
            newMarker.villageId = e.ward.villageId;
            markers.addLayer(newMarker);
            polylines.addLayer(polyline);
        }

    }

    function initMap() {
        this.map = L.map('map', {
            attributionControl: false, // để ko hiện watermark nữa, nếu bị liên hệ đòi thì nhớ open nha
            center: [currentCity.lat, currentCity.lng], // Tọa độ mặc định, ví dụ Hà Nội
            zoom: currentCity.zoom,
            //maxZoom: 10,
            minZoom: 10,
            maxBounds: currentCity.maxBounds,
            layers: [
                L.tileLayer(pathAPI, {
                    attribution: ''
                })
            ]
        });

        this.bindHoangSaTruongSa();

        for (i = 0; i < this.cities.length; i++) {
            this.addMarker({ latlng: { lat: cities[i].lat, lng: cities[i].lng }, type: 0, city: cities[i], name: cities[i].name });
            this.addPolygon(cities[i]);
            if (this.cities[i].wards != null) {
                var wards = this.cities[i].wards;
                for (var y = 0; y < wards.length; y++) {
                    this.addMarker({ latlng: { lat: wards[y].lat, lng: wards[y].lng }, type: wards[y].kieu, city: this.cities[i], name: wards[y].name, ward: wards[y] });
                }
            }
        }

        this.map.addLayer(this.markers);
        this.map.addLayer(this.polylines);
    }

    function addPolygon(city) {
        if (city.wards != undefined && city.wards != null) {
            for (var i = 0; i < city.wards.length; i++) {
                var polyline = L.polygon(reFormatData(city.wards[i].points), { color: city.wards[i].color, fillColor: city.wards[i].border_color, weight: 0.5, opacity: 0.5, fillOpacity: 0.1 }).addTo(map);;
            }
        }
    }

    function selectWard(e) {
        var wardId = $("#drPhuongXa").val();
        this.currentWard = this.currentCity?.wards.find(x => x.wardId == wardId);

        if (this.currentWard != null) {
            this.setView(this.currentWard.lat, this.currentWard.lng, this.currentWard.zoom);
            $(".maker-wardId-" + wardId).click();
        }
        setPolylineWeight(wardId);
    }

    function setPolylineWeight(wardId) {
        if (polylines) {
            for (var key in polylines._layers) {
                if (polylines._layers.hasOwnProperty(key)) {
                    if (polylines._layers[key].wardId == wardId) {
                        polylines._layers[key].setStyle({ weight: 5, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else {
                        polylines._layers[key].setStyle({ weight: 0, opacity: 0, fillOpacity: 0 });
                    }
                }
            }
        }
    }

    function setCurrentView() {
        this.map.setView({ lat: currentCity.lat, lng: currentCity.lng }, currentCity.zoom);
        this.map.setMaxBounds(currentCity.maxBounds);
    }

    function setView(lat, lng, zoom, e) {
        this.map.setView({ lat: lat, lng: lng }, zoom);

        if (e != undefined && e != null) {
            if (e.type == 0) {

            }
            else if (e.type == 1) {
                $(".maker-wardId-" + e.ward?.districtId).click();
                setPolylineWeightQH(e.ward?.districtId);
            }
            else {
                $(".maker-wardId-" + e.ward?.id).click();
                setPolylineWeight(e.ward?.id);
            }
        }
    }
    function setPolylineHover(wardId, type) {
        if (polylines) {
            for (var key in polylines._layers) {
                if (polylines._layers.hasOwnProperty(key)) {
                    if (wardId == 0) {
                        polylines._layers[key].setStyle({ weight: 1, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else if ((polylines._layers[key].districtId == wardId & type == 1) || (polylines._layers[key].wardId == wardId & type == 2)) {
                        polylines._layers[key].setStyle({ weight: 5, opacity: 0.5, fillOpacity: 0.6 });
                    }
                    else {
                        polylines._layers[key].setStyle({ weight: 0, opacity: 0.5, fillOpacity: 0.1 });
                    }
                }
            }
        }
    }

    function setPolylineWeight(wardId) {
        if (polylines) {
            for (var key in polylines._layers) {
                if (polylines._layers.hasOwnProperty(key)) {
                    if (wardId == 0) {
                        polylines._layers[key].setStyle({ weight: 1, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    if (polylines._layers[key].wardId == wardId) {
                        polylines._layers[key].setStyle({ weight: 5, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else {
                        polylines._layers[key].setStyle({ weight: 0, opacity: 0, fillOpacity: 0 });
                    }
                }
            }
        }
    }
    function setPolylineWeightQH(wardId) {
        if (polylines) {
            for (var key in polylines._layers) {
                if (polylines._layers.hasOwnProperty(key)) {
                    if (wardId == 0) {
                        polylines._layers[key].setStyle({ weight: 1, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else if (polylines._layers[key].districtId == wardId) {
                        polylines._layers[key].setStyle({ weight: 2, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else {
                        polylines._layers[key].setStyle({ weight: 0, opacity: 0, fillOpacity: 0 });
                    }
                }
            }
        }
    }

    //function initQuanHuyen() {
    //    $.ajax({
    //        type: 'POST',
    //        url: '/API/map/common.asmx/Get_RegionalQHPX',
    //        data: { MaHuyen: 0 },
    //        success: function (res) {
    //            setTimeout(function () {
    //                if (res.status == 2) {
    //                    var str = "";
    //                    for (i = 0; i < res.data.length; ++i) {
    //                        str += "<option value=" + res.data[i].regional_ID + ">" + res.data[i].regional_Name + "</option>";
    //                    }
    //                    $("#drQuanHuyen").append(str);
    //                    return;
    //                }
    //                else
    //                    return;
    //            }, vrtimeout);
    //        }
    //    });
    //}

    //function selectQuanHuyen(e) {
    //    retunwaiting();
    //    var cityId = $("#drQuanHuyen").val();
    //    if (cityId != "0") {
    //        $.ajax({
    //            type: 'POST',
    //            url: '/API/map/common.asmx/Get_RegionalQHPX',
    //            data: { MaHuyen: cityId },
    //            success: function (res) {
    //                setTimeout(function () {
    //                    if (res.status == 2) {
    //                        var str = "";
    //                        str += "<option value=0>--- Phường Xã ---</option>";
    //                        for (i = 0; i < res.data.length; ++i) {
    //                            str += "<option value=" + res.data[i].regional_ID + ">" + res.data[i].regional_Name + "</option>";
    //                        }
    //                        $("#drPhuongXa").html(str);
    //                        removewaiting();
    //                        return;
    //                    }
    //                    else {
    //                        removewaiting();
    //                        return;
    //                    }


    //                }, vrtimeout);
    //            }
    //        });
    //    }
    //    else {
    //        var str = "";
    //        str += "<option value=0>--- Phường Xã ---</option>";
    //        $("#drPhuongXa").html(str);
    //        removewaiting();
    //    }


    //    this.currentWard = this.currentCity?.wards.find(x => x.districtId == cityId);

    //    if (this.currentWard != null) {
    //        this.setView(this.currentWard.lat, this.currentWard.lng, this.currentWard.zoom);
    //        $(".maker-wardId-" + cityId).click();
    //    }
    //    setPolylineWeightQH(cityId);
    //}


    function reFormatData(oldArray) {
        var newArray = [];
        for (var z = 0; z < oldArray.length; z++) {
            var newItem = [];
            newItem.push(oldArray[z][1]);
            newItem.push(oldArray[z][0]);
            newArray.push(newItem);
        }
        return newArray;
    }

    function bindHoangSaTruongSa() {
        var myIconTruongSa = L.divIcon({
            iconSize: new L.Point(16, 16),
            html: "<div class='vietNamToiYeu'>QĐ. Trường Sa</div>"
        });

        var myIconHoangSa = L.divIcon({
            iconSize: new L.Point(16, 16),
            html: "<div class='vietNamToiYeu'>QĐ. Hoàng Sa</div>"
        });

        var marker = L.marker([16.0668391, 112.5897093], { icon: myIconHoangSa });
        marker.addTo(map);

        var marker2 = L.marker([8.5099703, 112.2203673], { icon: myIconTruongSa });
        marker2.addTo(map);
    }


    //function GetDataLayers() {
    //    $.ajax({
    //        type: 'POST',
    //        url: '/API/map/common.asmx/Get_LopBanDo_List_Search_By',
    //        data: { targetGroup: 1 },
    //        success: function (res) {
    //            setTimeout(function () {
    //                if (res.status == 2) {
    //                    var _item = {};
    //                    for (i = 0; i < res.data.length; ++i) {
    //                        _item = {};
    //                        _item.id = res.data[i].id;
    //                        _item.districtId = res.data[i].maHuyen;
    //                        _item.wardId = res.data[i].maXa;
    //                        _item.lat = res.data[i].viDo;
    //                        _item.lng = res.data[i].kinhDo;
    //                        _item.zoom = 12;
    //                        _item.name = res.data[i].tenLop;
    //                        _item.color = res.data[i].thuocTinh;
    //                        //_item.border_color = "#444";
    //                        _item.border_color = res.data[i].thuocTinh;
    //                        try {
    //                            _item.points = JSON.parse(res.data[i].ghiChu);
    //                        } catch (err) {
    //                            _item.points = "";
    //                        }
    //                        dataMap.push(_item);
    //                    }
    //                    initCity();
    //                    return;
    //                }
    //                else
    //                    return;
    //            }, vrtimeout);
    //        }
    //    });
    //}
   function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".");
}
    function GetDataLayers() {
        $.ajax({
            type: 'POST',
            url: '/API/map/common.asmx/HOME_MAP_DATA_ListData_By_List',
            data: { maHuyen: $('.BD_MaHuyen').val(), maXa: $('.BD_MaXa').val(), maThon: $('.BD_MaThon').val(), tarCode: $('.BD_TargetCode').val(), color: $('.BD_MauSac').val(), namBC: $('.BD_NamBC').val() },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 2) {
                        var _item = {};
                        for (i = 0; i < res.data.length; ++i) {
                            _item = {};
                            _item.id = res.data[i].id;
                            _item.districtId = res.data[i].maHuyen;
                            _item.tenQuan = res.data[i].tenQuan;
                            _item.wardId = res.data[i].maXa;
                            _item.tenXa = res.data[i].tenXa;
                            _item.villageId = res.data[i].maThon;
                            _item.tenThon = res.data[i].tenThon;
                            _item.lat = res.data[i].viDo;
                            _item.lng = res.data[i].kinhDo;
                            _item.zoom = 12;
                            _item.name = res.data[i].tenLop;
                            _item.color = res.data[i].mauSac;
                            _item.border_color = res.data[i].mauSac;
                            _item.soLieu = numberWithCommas(res.data[i].soLieu);
                            _item.kieu = res.data[i].kieu;
                            try {
                                _item.points = JSON.parse(res.data[i].ghiChu);
                            } catch (err) {
                                _item.points = "";
                            }
                            dataMap.push(_item);
                        }
                        initCity();
                        return;
                    }
                    else
                    {
                        initCity();
                        return;
                    }
                }, vrtimeout);
            }
        });
    }
    function initCity() {
        this.cities = [];
        this.cities.push({
            id: $('.Map_MaTinh').val(), name: $('.Map_TenTinh').val(), maxBounds: JSON.parse($('.Map_MaxBounds').val()), lat: $('.Map_Lat').val(), lng: $('.Map_Lng').val(), isDefault: true, zoom: $('.Map_Zoom').val(),
            wards: dataMap
        });
        // , Phải init get từ database về trước các danh mục và full tất cả data mới gọi hàm initMap, khi đó mình chỉ thao tác trên data có sẵn ko cần phải gọi về server
        //this.initSelectCities();
        this.currentCity = this.cities.find(x => x.isDefault);
        if (this.currentCity) {
            this.initMap();
        }
        else {
            notify('error', 'Chưa set mặc định tỉnh/TP nào focus vào đầu tiên.', 'Thông báo', false);
        }

        // create fullscreen control
        var fsControl = L.control.fullscreen();
        // add fullscreen control to the map
        map.addControl(fsControl);

        // detect fullscreen toggling
        map.on('enterFullscreen', function () {
            if (window.console) window.console.log('enterFullscreen');
        });
        map.on('exitFullscreen', function () {
            if (window.console) window.console.log('exitFullscreen');
        });
    }

</script>
