<%@ Control Language="vb" CodeFile="MapProvinceView.ascx.vb" Inherits="Modules.MapProvinceView.View" AutoEventWireup="false" Explicit="True" %>

<link href="/Portals/_default/leaflet/leaflet.css" rel="stylesheet" />
<link rel="stylesheet" href="/Portals/_default/leaflet/Control.FullScreen.css" />
<style>
    .waiting {
        z-index: 9999;
    }

    .selectRG {
        height: 33px;
        font-size: 14px;
    }

        .selectRG option {
            font-size: 14px;
        }

    .all-map-content {
        position: relative;
        width: 100%;
    }

    .fix-form-map {
        width: 100%;
        position: absolute;
        left: 0;
        right: 0;
        top: 10px;
        height: 0px;
        z-index: 999;
    }

    .form-map {
        width: 750px;
        background: #fff;
        margin: 0 auto;
        border: 1px solid #eee;
        padding: 10px;
    }

    .form-select {
        width: 200px;
    }

    .form-label {
        position: relative;
        top: 6px;
        font-weight: bold;
    }

    .vietNamToiYeu {
        line-height: 12px;
        position: absolute;
        font-size: 16px;
        padding: 5px 2px;
        background: #fff;
        border-radius: 5px;
        color: #bf1515;
        z-index: 9999;
        font-size: 11px;
        top: -2px;
        left: -2px;
        width: 100px;
        text-align: center;
        font-size: 12px;
        font-weight: bold;
    }

    .icon-vietnamToiYeu {
        width: 20px;
        height: 20px;
    }

    .coVietNam {
        width: 40px;
    }

    .vietNamToiYeu:before, .vietNamToiYeu:after {
        border: none !important;
        display: none;
    }

    .info-box .icon i {
        font-size: 31px;
    }
        .icon-xa
{
        background-color: #0f5132;
        border-radius: 50px;
        border: 2px solid #43dd48;
}
</style>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12 pdl0">
            <h3 class="box-title">Thông tin bản đồ theo địa bàn</h3>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="all-map-content">
                <div class="fix-form-map">
                    <div class="form-map">
                        <div class="row">
                            <div class="col-md-3">
                                <select onchange="selectQuanHuyen(this)" class="selectRG" id="drQuanHuyen">
                                    <option value="0">--- Quận/Huyện ---</option>
                                </select>
                            </div>
                            <div class="col-md-3">
                                <select onchange="selectWard(this)" class="selectRG" id="drPhuongXa">
                                    <option value="0">--- Phường/Xã ---</option>
                                </select>
                            </div>
                            <div class="col-md-4">
                                <asp:DropDownList ID="drLoai" runat="server" CssClass="selectRG">
                                    <asp:ListItem Value="1">Quy mô lao động</asp:ListItem>
                                    <asp:ListItem Value="1">Tỷ lệ thất nghiệp</asp:ListItem>
                                    <asp:ListItem Value="1">Quy mô doanh nghiệp</asp:ListItem>
                                    <asp:ListItem Value="1">Tỷ lệ tình trạng có việc làm</asp:ListItem>
                                    <asp:ListItem Value="1">Quy mô lực lượng lao động</asp:ListItem>
                                    <asp:ListItem Value="1">Quy mô dân số</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-1">
                                <button type="button" class="btn btn-primary">Tìm kiếm</button>
                            </div>
                        </div>
                    </div>
                </div>
                <%--<div class="fix-form-map">
                            <div class="form-map">
                                <div class="row">
                                    <div class="col-auto form-label">
                                        Tỉnh/TP:
                                    </div>
                                    <div class="col-auto">
                                        <select onchange="selectCity(this)" class="form-select form-control-sm" id="cityId">
                                            <option>Đang tải ...</option>
                                        </select>
                                    </div>

                                    <div class="col-auto form-label">
                                        Phường/Xã:
                                    </div>
                                    <div class="col-auto">
                                        <select onchange="selectWard(this)" class="form-select form-control-sm" id="wardId">
                                            <option>Đang tải ...</option>
                                        </select>
                                    </div>
                                </div>

                            </div>
                        </div>--%>

                <div style="width: 100%; height: 800px;" id="map"></div>
            </div>
            <div class="clr clUp"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
    </div>

</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
    </div>
</div>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <asp:TextBox ID="Map_MaTinh" runat="server" CssClass="Map_MaTinh none" />
        <asp:TextBox ID="Map_TenTinh" runat="server" CssClass="Map_TenTinh none" />
        <asp:TextBox ID="Map_Lat" runat="server" CssClass="Map_Lat none" />
        <asp:TextBox ID="Map_Lng" runat="server" CssClass="Map_Lng none" />
        <asp:TextBox ID="Map_Zoom" runat="server" CssClass="Map_Zoom none" />
        <asp:TextBox ID="Map_MaxBounds" runat="server" CssClass="Map_MaxBounds none" />
    </ContentTemplate>
</asp:UpdatePanel>

<script src="/Portals/_default/leaflet/leaflet-src.js"></script>
<script src="/Portals/_default/leaflet/Control.FullScreen.js"></script>
<script>
    // Nế chọn tỉnh/TP mà xã null thì sẽ hiển thị border tất cả các xã
    // nếu chỉ chọn xã sẽ tô xã chỉ xã đó vẫn có border
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
    this.initQuanHuyen();
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
                                Tỉnh TP: <strong>`+ e.city?.name + `</strong><br>
                                Thông tin: `+ e.ward?.name + `
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
                        setPolylineHover(wardId,1);
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
        else {
            strProp =
                `
                    <div>
                            Tỉnh TP: <strong>`+ e.city?.name + `</strong><br>
                            Xã/phường: `+ e.ward?.name + `
                    </div>
                `;
            var newMarker = new L.marker(e.latlng, {
                icon: L.divIcon({
                    iconSize: new L.Point(16, 16),
                    className: "icon-xa maker-wardId-" + e.ward.id
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
            polyline.wardId = e.ward.id;
            newMarker.wardId = e.ward.id;
            markers.addLayer(newMarker);
            polylines.addLayer(polyline);
        }

        ////var newMarker = new L.marker(e.latlng).addTo(map)
        ////    .bindPopup(strProp);

        // var popup = L.popup()
        //     .setLatLng(latlng)
        //     .setContent('<p>Hello world!<br />This is a nice popup.</p>')
        //     .openOn(map);
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
            //this.addPolygon(cities[i]);
            if (this.cities[i].wards != null) {
                var wards = this.cities[i].wards;
                for (var y = 0; y < wards.length; y++) {
                    this.addMarker({ latlng: { lat: wards[y].lat, lng: wards[y].lng }, type: 1, city: this.cities[i], name: wards[y].name, ward: wards[y] });
                }
            }
        }

        this.map.addLayer(this.markers);
        this.map.addLayer(this.polylines);
    }

    //function selectWard(e) {
    //    var wardId = $("#wardId").val();
    //    this.currentWard = this.currentCity?.wards.find(x => x.id == wardId);

    //    if (this.currentWard != null) {
    //        this.setView(this.currentWard.lat, this.currentWard.lng, this.currentWard.zoom);
    //    }
    //}

    //function selectCity(e) {
    //    var cityId = $("#cityId").val();
    //    this.currentCity = this.cities.find(x => x.id == cityId);
    //    if (this.currentCity) {
    //        // Gen Xã
    //        this.genWards();
    //        this.setCurrentView();
    //    }
    //    else {
    //        alert("Chưa cấu hình tọa độ cho Tỉnh/TP này")
    //    }
    //}

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

    function initQuanHuyen() {
        $.ajax({
            type: 'POST',
            url: '/API/map/common.asmx/Get_RegionalQHPX',
            data: { MaHuyen: 0 },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 2) {
                        var str = "";
                        for (i = 0; i < res.data.length; ++i) {
                            str += "<option value=" + res.data[i].regional_ID + ">" + res.data[i].regional_Name + "</option>";
                        }
                        $("#drQuanHuyen").append(str);
                        return;
                    }
                    else
                        return;
                }, vrtimeout);
            }
        });
    }

    function selectQuanHuyen(e) {
        retunwaiting();
        var cityId = $("#drQuanHuyen").val();
        if (cityId != "0") {
            $.ajax({
                type: 'POST',
                url: '/API/map/common.asmx/Get_RegionalQHPX',
                data: { MaHuyen: cityId },
                success: function (res) {
                    setTimeout(function () {
                        if (res.status == 2) {
                            var str = "";
                            str += "<option value=0>--- Phường Xã ---</option>";
                            for (i = 0; i < res.data.length; ++i) {
                                str += "<option value=" + res.data[i].regional_ID + ">" + res.data[i].regional_Name + "</option>";
                            }
                            $("#drPhuongXa").html(str);
                            removewaiting();
                            return;
                        }
                        else {
                            removewaiting();
                            return;
                        }


                    }, vrtimeout);
                }
            });
        }
        else {
            var str = "";
            str += "<option value=0>--- Phường Xã ---</option>";
            $("#drPhuongXa").html(str);
            removewaiting();
        }


        this.currentWard = this.currentCity?.wards.find(x => x.districtId == cityId);

        if (this.currentWard != null) {
            this.setView(this.currentWard.lat, this.currentWard.lng, this.currentWard.zoom);
            $(".maker-wardId-" + cityId).click();
        }
        setPolylineWeightQH(cityId);
    }

    function addPolygon(city) {
        if (city.wards != undefined && city.wards != null) {
            for (var i = 0; i < city.wards.length; i++) {
                //var polyline = L.polygon(reFormatData(city.wards[i].points), { color: city.wards[i].color, fillColor: city.wards[i].border_color, weight: 3, opacity: 0.5, fillOpacity: 0.1 }).addTo(map).bindPopup("<div>Quận/Huyện: " + city.wards[i].name + "</div>");;
                var polyline = L.polygon(reFormatData(city.wards[i].points), { color: city.wards[i].color, fillColor: city.wards[i].border_color, weight: 3, opacity: 0.5, fillOpacity: 0.1 }).addTo(map);;
            }
        }
    }

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

    //function genWards() {
    //    var str = "<option value=''>Chọn</option>";
    //    if (this.currentCity.wards != null) {
    //        for (var i = 0; i < this.currentCity.wards.length; i++) {
    //            str += "<option value=" + currentCity.wards[i].id + ">" + currentCity.wards[i].name + "</option>";
    //        }
    //    }
    //    $("#wardId").html(str);
    //}

    function GetDataLayers() {
        $.ajax({
            type: 'POST',
            url: '/API/map/common.asmx/Get_LopBanDo_List_Search_By',
            data: { targetGroup: 1 },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 2) {
                        var _item = {};
                        for (i = 0; i < res.data.length; ++i) {
                            _item = {};
                            _item.id = res.data[i].id;
                            _item.districtId = res.data[i].maHuyen;
                            _item.wardId = res.data[i].maXa;
                            _item.lat = res.data[i].viDo;
                            _item.lng = res.data[i].kinhDo;
                            _item.zoom = 12;
                            _item.name = res.data[i].tenLop;
                            _item.color = res.data[i].thuocTinh;
                            //_item.border_color = "#444";
                            _item.border_color = res.data[i].thuocTinh;
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
                        return;
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
