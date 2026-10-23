<%@ Control Language="vb" CodeFile="MapCompanyView.ascx.vb" Inherits="Modules.MapCompanyView.View" AutoEventWireup="false" Explicit="True" %>

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

    .icon-xa {
        background-color: #0f5132;
        border-radius: 50px;
        border: 2px solid #43dd48;
    }

    .title-map {
        padding: 20px 0;
        font-weight: bold;
    }

    #search-box {
        padding: 10px;
    }

    #grid-view {
        padding: 0 10px;
    }

    .icon-map {
        width: 20px;
        vertical-align: middle !important;
    }

        .icon-map i {
            font-size: 20px;
        }

    .station-list table tbody {
        height: 500px;
        overflow-y: auto;
        width: 100%;
        display: inline-block;
    }

        .station-list table tbody tr, .station-list table tbody tr td {
            width: 100%;cursor:pointer;
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
                <div class="col-md-3" style="padding: 0;">
                    <div class="text-center text-uppercase bg-primary text-bg-primary title-map" style="color: #fff;">Danh sách doanh nghiệp</div>
                    <div class="px-3" id="search-box">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Quận/Huyện</label>
                            <select onchange="selectCity()" class="selectRG" id="drQuanHuyen">
                                <option value="0">--- Quận/Huyện ---</option>
                            </select>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputEmail1">Từ khóa</label>
                            <input type="email" class="form-control" id="keyword" aria-describedby="emailHelp" placeholder="Tìm kiếm tên doanh nghiệp ...">
                        </div>
                        <div class="mb-2">
                            <button type="button" onclick="selectCity()" class="btn btn-block btn-primary w-100" id="btn-search-station">Tìm kiếm</button>
                        </div>
                        <div class="px-3 mb-2">
                            <h6 class="text-end"><i>Tìm thấy <span id="count-com" class="text-success fw-bold">0</span> công ty</i></h6>
                        </div>
                    </div>
                    <div id="grid-view">
                        <div class="station-list">
                            <table class="table table-striped">
                                <tbody id="table-compaly">
                                    
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <div class="col-md-9">
                    <div style="width: 100%; height: 800px;" id="map"></div>
                </div>
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
    var iconSettings = {
        mapIconUrl: '<svg version="1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 149 178"><path fill="{mapIconColor}" stroke="#FFF" stroke-width="6" stroke-miterlimit="10" d="M126 23l-6-6A69 69 0 0 0 74 1a69 69 0 0 0-51 22A70 70 0 0 0 1 74c0 21 7 38 22 52l43 47c6 6 11 6 16 0l48-51c12-13 18-29 18-48 0-20-8-37-22-51z"/><circle fill="{mapIconColorInnerCircle}" cx="74" cy="75" r="61"/><circle fill="#FFF" cx="74" cy="75" r="{pinInnerCircleRadius}"/></svg>',
        mapIconColor: '#cc756b',
        mapIconColorInnerCircle: '#fff',
        pinInnerCircleRadius: 48
    };
    // Nế chọn tỉnh/TP mà xã null thì sẽ hiển thị border tất cả các xã
    // nếu chỉ chọn xã sẽ tô xã chỉ xã đó vẫn có border
    var vrtimeout = 2000;
    var dataMap = [];
    var markers = new L.FeatureGroup();
    var map;
    // Cấu hình backend để thay đổi được link map
    var pathAPI = 'https://tile.thunderforest.com/atlas/{z}/{x}/{y}.png?apikey=4bb0d1f946264840adc87b746159a513';
    var vietNamMarkers = [];
    this.initQuanHuyen();
    this.GetDataLayers();
    //this.initCity();

    // Hover icon normal state
    var divIcon;

    function setClassDivIcon(i) {
        divIcon = L.divIcon({
            className: "leaflet-data-marker maker-company-" + i,
            html: L.Util.template(iconSettings.mapIconUrl, iconSettings),
            iconAnchor: [12, 32],
            iconSize: [25, 30],
            popupAnchor: [0, -28]
        });
    }

    // icon active state
    divIconActive = L.divIcon({
        className: "leaflet-data-marker",
        html: L.Util.template(iconSettings.mapIconUrl, iconSettings),
        iconAnchor: [18, 42],
        iconSize: [36, 42],
        popupAnchor: [0, -30]
    });

    markerArray = [];
    iMarker = -1;

    function setActiveIcon(marker) {
        marker.setIcon(divIconActive);
    };
    //End Hover

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

    //function selectQuanHuyen(e) {
    //    var cityId = $("#drQuanHuyen").val();
    //    this.currentWard = this.currentCity?.wards.find(x => x.districtId == cityId);

    //}

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


    function GetDataLayers() {
        $.ajax({
            type: 'POST',
            url: '/API/map/common.asmx/Map_List_Search_ByDoanhNghiep',
            data: { targetGroup: 1 },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 2) {
                        var _item = {};
                        for (i = 0; i < res.data.length; ++i) {
                            _item = {};
                            _item.id = res.data[i].id;
                            _item.maHuyen = res.data[i].maHuyen;
                            _item.maXa = res.data[i].maXa;
                            _item.lat = res.data[i].viDo;
                            _item.lng = res.data[i].kinhDo;
                            _item.tenDoanhNghiep = res.data[i].tenDoanhNghiep;
                            _item.email = res.data[i].email;
                            _item.hotline = res.data[i].hotline;
                            _item.diaChi = res.data[i].diaChi;
                            dataMap.push(_item);
                        }
                        initMap();
                        return;
                    }
                    else
                        return;
                }, vrtimeout);
            }
        });
    }

    function selectCity() {
        initCompany();
    }

    function initCompany() {
        var str = "";
        var newCompanys = dataMap;
        var cityId = $("#drQuanHuyen").val();
        var key = $("#keyword").val();

        if (cityId > 0) {
            newCompanys = newCompanys.filter(x => x.maHuyen == cityId);
        }

        if (key != null && key != '') {
            newCompanys = newCompanys.filter(x => x.tenDoanhNghiep.toLowerCase().lastIndexOf(key.toLowerCase()) >= 0 || x.diaChi.toLowerCase().lastIndexOf(key.toLowerCase()) >= 0);
        }

        for (var i = 0; i < newCompanys.length; i++) {
            str += `
            <tr onClick='selectCompany(`+ newCompanys[i].id + `)'>
                <td class="px-3">
                    <div><b>`+ newCompanys[i].tenDoanhNghiep + `</b></div>
                    <div>`+ newCompanys[i].diaChi + `</div>
                </td>
                <td class="icon-map"><i class="fa fa-map-marker text-primary" aria-hidden="true"></i></td>
            </tr>
            `;
        }
        $("#table-compaly").html(str);
        $("#count-com").html(newCompanys.length);
    }

    function selectCompany(cId) {
        $(".maker-company-" + cId).click();
    }


    function initMap() {
        this.map = L.map('map', {
            center: [$('.Map_Lat').val(), $('.Map_Lng').val()], // Tọa độ mặc định, ví dụ Hà Nội
            zoom: 10,
            minZoom: $('.Map_Zoom').val(),
            maxBounds: JSON.parse($('.Map_MaxBounds').val()),
            layers: [
                L.tileLayer(pathAPI, {
                    attribution: ''
                })
            ]
        });

        this.bindHoangSaTruongSa();

        for (i = 0; i < this.dataMap.length; i++) {
            this.addMarker({ latlng: { lat: dataMap[i].lat, lng: dataMap[i].lng }, company: dataMap[i], name: dataMap[i].name, item: i });
        }

        this.map.addLayer(this.markers);

        initCompany();
    }

    function addMarker(e) {
        var strProp = "";
        var latlng = e.latlng;
        this.setClassDivIcon(e.company.id)
        strProp = `<div><strong>` + e.company?.tenDoanhNghiep + `</strong></div>
        <div>Hotline: `+ e.company.hotline + `</div>
        <div>Địa chỉ: `+ e.company.diaChi + `</div>
        `;

        var marker = L.marker(latlng, {
            icon: divIcon,
            id: e.company.id,
            class: 'maker-company-' + e.company.id
        }).bindPopup(strProp);

        markers.addLayer(marker);

        marker.on('mouseover', function (latlng) {
            divIcon.options.className = "leaflet-data-marker maker-company-" + this.options.id;
            if (iMarker == e.item) return;
            setTimeout(setActiveIcon, 10, this);
            //if (iMarker >= 0) markerArray[iMarker].setIcon(divIcon);
            iMarker = e.item;
            this.openPopup();
        });

        marker.on('mouseout', function (latlng) {
            this.setIcon(divIcon);
            iMarker = -1;
            this.closePopup();
        });
    }
</script>
