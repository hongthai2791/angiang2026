<%@ Control Language="vb" CodeFile="MapTuyenDungView.ascx.vb" Inherits="Modules.MapTuyenDungView.View" AutoEventWireup="false" Explicit="True" %>

<link href="/Portals/_default/leaflet/leaflet.css" rel="stylesheet" />
<link rel="stylesheet" href="/Portals/_default/leaflet/Control.FullScreen.css" />
<div class="box box-info">
    <div class="box-body">
        <div class="main-body">
            <div class="all-map-content">
                <div class="col-md-3" style="padding: 0;">
                    <div class="text-center text-uppercase bg-primary text-bg-primary title-map" style="color: #fff;">Danh sách tin tuyển dụng</div>
                    <div class="px-3" id="search-box">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Phường/Xã</label>
                            <select onchange="selectCity()" class="selectRG mt10" id="drQuanHuyen">
                                <option value="0">--- Phường/Xã ---</option>
                            </select>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputEmail1">Từ khóa</label>
                            <input type="email" class="form-control mt10" id="keyword" aria-describedby="emailHelp" placeholder="Nhập tiêu đề tin để tìm kiếm ...">
                        </div>
                        <div class="mb-2">
                            <button type="button" onclick="selectCity()" class="btn btn-block btn-primary w-100" id="btn-search-station">Tìm kiếm</button>
                        </div>
                        <div class="px-3 mb-2 pdt10">
                            <h6 class="text-end"><i>Tìm thấy <span id="count-com" class="text-success fw-bold">0</span> tin tuyển dụng</i></h6>
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
<script type="text/javascript" src="/js/base64.js?v=6.0.0"></script>

<script src="/Portals/_default/leaflet/leaflet-src.js"></script>
<script src="/Portals/_default/leaflet/Control.FullScreen.js"></script>
<script>
    var iconSettings = {
        //mapIconUrl: '<svg xmlns="http://www.w3.org/2000/svg" height="48" width="48" viewBox="0 0 48 48"><g><path id="path1" transform="rotate(0,24,24) translate(15.9562503099442,11) scale(0.8125,0.8125)  " fill="#002EBB" d="M4.7000001,23.900024C4.899997,24.200012 5.2000001,24.600006 5.399997,24.900024 4.2999985,25.5 3.599998,26.400024 3.599998,27.300018 3.599998,29.200012 6.4999993,30.800018 9.799998,30.800018 13.099996,30.800018 15.999997,29.200012 15.999997,27.300018 15.999997,26.400024 15.300001,25.5 14.199995,24.900024 14.399999,24.600006 14.699995,24.300018 14.899999,23.900024 16.300001,24.800018 17.199995,25.900024 17.199995,27.300018 17.199995,29.900024 13.899999,32 9.799998,32 5.7000001,32 2.3999975,29.900024 2.3999977,27.300018 2.3999975,26 3.2999988,24.800018 4.7000001,23.900024z M9.799998,3.2000122C6.8999965,3.2000122 4.4999993,5.6000061 4.4999993,8.5 4.4999993,11.400024 6.8999965,13.800018 9.799998,13.800018 12.799997,13.800018 15.099996,11.400024 15.099996,8.5 15.199995,5.6000061 12.799997,3.2000122 9.799998,3.2000122z M9.8999965,0C15.300001,0 19.799999,4.4000244 19.799999,9.9000244 19.799999,15.300018 9.8999965,27.400024 9.8999965,27.400024 9.8999965,27.400024 2.3439225E-07,15.300018 0,9.9000244 2.3439225E-07,4.4000244 4.399997,0 9.8999965,0z" /></g></svg>',
        mapIconUrl: '<img src="<%=EPORTAL.flReg.WebConfig("WorkDomain")%>/image/map/tintuyendungmap.png?v=1.1"  height="48" width="48"/>',
        mapIconColor: '#FF3704E7',
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
        iconSize: [30, 42],
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
        var searchKey = Base64.encode($("#keyword").val());
        var quanHuyen=$("#drQuanHuyen").val()
        $.ajax({
            type: 'POST',
            url: '/API/map/common.asmx/MAP_DATA_WORK_List_Search',
            data: { quanHuyen: quanHuyen , searchKey: searchKey },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 2) {
                        var _item = {};
                        for (i = 0; i < res.data.length; ++i) {
                            _item = {};
                            _item.id = res.data[i].id;
                            _item.maHuyen = res.data[i].quanHuyen;
                            _item.maXa = res.data[i].xaPhuong;
                            _item.lat = res.data[i].lat;
                            _item.lng = res.data[i].lng;
                            _item.title = res.data[i].title;
                            _item.mucLuong = res.data[i].mucLuong;
                            _item.tenDoanhNghiep = res.data[i].tenDoanhNghiep;
                            _item.kinhNghiem = res.data[i].kinhNghiem;
                            _item.url = res.data[i].toUrl;
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
        var cityId = $("#drQuanHuyen").val();
        var key = $("#keyword").val();
        var dataMapSearch = [];
        this.markers.clearLayers();
        if (cityId > 0) {
            dataMapSearch = dataMap.filter(x => x.maHuyen == cityId);
        };

        if (key != null && key != '') {
            dataMapSearch = dataMap.filter(x => x.title.toLowerCase().lastIndexOf(key.toLowerCase()) >= 0 );
        };

        if (dataMapSearch.length > 0) {
            for (i = 0; i < dataMapSearch.length; i++) {
                this.addMarker({ latlng: { lat: dataMapSearch[i].lat, lng: dataMapSearch[i].lng }, company: dataMapSearch[i], name: dataMapSearch[i].name, item: i });
            }
        }
        if (cityId == "0" && dataMapSearch.length == 0) {
            for (i = 0; i < this.dataMap.length; i++) {
                this.addMarker({ latlng: { lat: dataMap[i].lat, lng: dataMap[i].lng }, company: dataMap[i], name: dataMap[i].name, item: i });
            }
        };
        this.map.addLayer(this.markers);
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
            newCompanys = newCompanys.filter(x => x.title.toLowerCase().lastIndexOf(key.toLowerCase()) >= 0 );
        }

        for (var i = 0; i < newCompanys.length; i++) {
            str += `
            <tr onClick='selectCompany(`+ newCompanys[i].id + `)'>
                <td class="px-3">
                    <div><b>`+ newCompanys[i].title + `</b></div>
                    <div>`+ newCompanys[i].tenDoanhNghiep + `</div>
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
        strProp = `<div><strong>` + e.company?.title + `</strong></div>
        <div>`+ e.company.tenDoanhNghiep + `</div>
        <div>Mức lương: `+ e.company.mucLuong + `</div>
        <div>Kinh nghiệm: `+ e.company.kinhNghiem + `</div>
        <div><a target='_blank' href=<%=EPORTAL.flReg.WebConfig("WorkDomain")%>`+ e.company.url +`>Xem chi tiết </a></div>
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

        //marker.on('mouseout', function (latlng) {
        //    this.setIcon(divIcon);
        //    iMarker = -1;
       //     this.closePopup();
       // });
    }
</script>
