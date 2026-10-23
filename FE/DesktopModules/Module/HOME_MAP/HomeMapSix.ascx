<%@ Control Language="vb" CodeFile="HomeMapSix.ascx.vb" Inherits="Modules.HomeMapSix.View" AutoEventWireup="false" Explicit="True" %>


<div class="box box-info">

    <div class="box-body" style="margin-top: 15px !important">
        <div class="main-body">
            <div class="all-map-content">
                <div class="fix-form-map">
                    <div class="form-map header-map-six">
                        BẢN ĐỒ KHÔNG HOẠT ĐỘNG KINH TẾ
                    </div>
                </div>
                <div style="width: 100%; height: 500px;" id="mapSix"></div>
            </div>
            <div class="clr clUp"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
    </div>

</div>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <asp:TextBox ID="Map_MaTinh" runat="server" CssClass="Map_MaTinh hidden" />
        <asp:TextBox ID="Map_TenTinh" runat="server" CssClass="Map_TenTinh hidden" />
        <asp:TextBox ID="Map_Lat" runat="server" CssClass="Map_Lat hidden" />
        <asp:TextBox ID="Map_Lng" runat="server" CssClass="Map_Lng hidden" />
        <asp:TextBox ID="Map_Zoom" runat="server" CssClass="Map_Zoom hidden" />
        <asp:TextBox ID="Map_MaxBounds" runat="server" CssClass="Map_MaxBounds hidden" />
    </ContentTemplate>
</asp:UpdatePanel>
<script>
    var dataMapSix = [];
     var vrtimeoutSix = 2000;
    function initMapSix() {
        this.map = L.map('mapSix', {
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
            this.addMarkerSix({ latlng: { lat: cities[i].lat, lng: cities[i].lng }, type: 0, city: cities[i], name: cities[i].name });
            this.addPolygon(cities[i]);
            if (this.cities[i].wards != null) {
                var wards = this.cities[i].wards;
                for (var y = 0; y < wards.length; y++) {
                    this.addMarkerSix({ latlng: { lat: wards[y].lat, lng: wards[y].lng }, type: wards[y].kieu, city: this.cities[i], name: wards[y].name, ward: wards[y] });
                }
            }
        }
        this.map.addLayer(this.markersSix);
        this.map.addLayer(this.polylinesSix);
    }
    this.GetDataLayersSix();
    function GetDataLayersSix() {
        const dayBC = new Date();
        let _namBC = dayBC.getFullYear();
        $.ajax({
            type: 'POST',
            url: '/API/map/common.asmx/HOME_MAP_DATA_ListData_By_List',
            data: { maHuyen: 0, maXa: 0, maThon: 0, tarCode: "KHDKT01.01", color: "#2d816b", namBC: _namBC },
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
                            _item.soLieu = res.data[i].soLieu;
                            _item.kieu = res.data[i].kieu;
                            try {
                                _item.points = JSON.parse(res.data[i].ghiChu);
                            } catch (err) {
                                _item.points = "";
                            }
                            dataMapSix.push(_item);
                        }
                        initCitySix();
                        return;
                    }
                    else{
                         initCitySix();
                         return;
                    }
                }, vrtimeoutSix);
            }
        });
    }

    function addMarkerSix(e) {
        var strProp = "";
        if (e.type == 0) {
            strProp =
                `
     <div>
             Tỉnh TP: <strong>`+ e.city?.name + `</strong>
     </div>
 `;
        }
        else {
            strProp =
                `
          <div>
                Đơn vị HC: <strong>`+ e.ward.tenQuan + `</strong><br>
                Chỉ tiêu: <strong>Không hoạt động kinh tế</strong><br>
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
                    setViewSix(e.ward.lat, e.ward.lng, e.ward.zoom, e);
                });

            var polyline = L.polygon(reFormatData(e.ward.points), { color: e.ward.color, fillColor: e.ward.border_color, weight: 0, opacity: 0.5, fillOpacity: 0.1 })
                .on('click', function (data) {
                    setViewSix(e.ward.lat, e.ward.lng, e.ward.zoom, e);
                });
            polyline.on('mouseover', function (e) {
                var wardId = e.sourceTarget.districtId;
                for (const [key, value] of Object.entries(markersSix["_layers"])) {
                    if (value.districtId == wardId) {
                        setPolylineHoverSix(wardId, 1);
                        value.openPopup()
                        break;
                    }
                }
            });
            polyline.districtId = e.ward.districtId;
            newMarker.districtId = e.ward.districtId;
            markersSix.addLayer(newMarker);
            polylinesSix.addLayer(polyline);
        }

    }
    function initCitySix() {
        this.cities = [];
        this.cities.push({
            id: $('.Map_MaTinh').val(), name: $('.Map_TenTinh').val(), maxBounds: JSON.parse($('.Map_MaxBounds').val()), lat: $('.Map_Lat').val(), lng: $('.Map_Lng').val(), isDefault: true, zoom: $('.Map_Zoom').val(),
            wards: dataMapSix
        });
        // , Phải init get từ database về trước các danh mục và full tất cả data mới gọi hàm initMap, khi đó mình chỉ thao tác trên data có sẵn ko cần phải gọi về server
        //this.initSelectCities();
        this.currentCity = this.cities.find(x => x.isDefault);
        if (this.currentCity) {
            this.initMapSix();
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

    function setPolylineWeightSix(wardId) {
        if (polylinesSix) {
            for (var key in polylinesSix._layers) {
                if (polylinesSix._layers.hasOwnProperty(key)) {
                    if (polylinesSix._layers[key].wardId == wardId) {
                        polylinesSix._layers[key].setStyle({ weight: 5, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else {
                        polylinesSix._layers[key].setStyle({ weight: 0, opacity: 0, fillOpacity: 0 });
                    }
                }
            }
        }
    }


    function setViewSix(lat, lng, zoom, e) {
        this.map.setViewSix({ lat: lat, lng: lng }, zoom);

        if (e != undefined && e != null) {
            if (e.type == 0) {

            }
            else if (e.type == 1) {
                $(".maker-wardId-" + e.ward?.districtId).click();
                setPolylineWeightQHSix(e.ward?.districtId);
            }
            else {
                $(".maker-wardId-" + e.ward?.id).click();
                setPolylineWeightSix(e.ward?.id);
            }
        }
    }
    function setPolylineHoverSix(wardId, type) {
        if (polylinesSix) {
            for (var key in polylinesSix._layers) {
                if (polylinesSix._layers.hasOwnProperty(key)) {
                    if (wardId == 0) {
                        polylinesSix._layers[key].setStyle({ weight: 1, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else if ((polylinesSix._layers[key].districtId == wardId & type == 1) || (polylinesSix._layers[key].wardId == wardId & type == 2)) {
                        polylinesSix._layers[key].setStyle({ weight: 2, opacity: 0.5, fillOpacity: 0.6 });
                    }
                    else {
                        polylinesSix._layers[key].setStyle({ weight: 0, opacity: 0.5, fillOpacity: 0.1 });
                    }
                }
            }
        }
    }

    function setPolylineWeightSix(wardId) {
        if (polylinesSix) {
            for (var key in polylinesSix._layers) {
                if (polylinesSix._layers.hasOwnProperty(key)) {
                    if (wardId == 0) {
                        polylinesSix._layers[key].setStyle({ weight: 1, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    if (polylinesSix._layers[key].wardId == wardId) {
                        polylinesSix._layers[key].setStyle({ weight: 5, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else {
                        polylinesSix._layers[key].setStyle({ weight: 0, opacity: 0, fillOpacity: 0 });
                    }
                }
            }
        }
    }
    function setPolylineWeightQHSix(wardId) {
        if (polylinesSix) {
            for (var key in polylinesSix._layers) {
                if (polylinesSix._layers.hasOwnProperty(key)) {
                    if (wardId == 0) {
                        polylinesSix._layers[key].setStyle({ weight: 1, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else if (polylinesSix._layers[key].districtId == wardId) {
                        polylinesSix._layers[key].setStyle({ weight: 2, opacity: 0.5, fillOpacity: 0.1 });
                    }
                    else {
                        polylinesSix._layers[key].setStyle({ weight: 0, opacity: 0, fillOpacity: 0 });
                    }
                }
            }
        }
    }

</script>
