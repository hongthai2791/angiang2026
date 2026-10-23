<%@ Control Language="vb" CodeFile="HomeMap.ascx.vb" Inherits="Modules.HomeMap.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeMapOne.ascx" TagPrefix="uc1" TagName="HomeMapOne" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeMapTwo.ascx" TagPrefix="uc1" TagName="HomeMapTwo" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeMapThree.ascx" TagPrefix="uc1" TagName="HomeMapThree" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeMapFour.ascx" TagPrefix="uc1" TagName="HomeMapFour" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeMapFive.ascx" TagPrefix="uc1" TagName="HomeMapFive" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeMapSix.ascx" TagPrefix="uc1" TagName="HomeMapSix" %>
<%@ Register Src="~/DesktopModules/Module/HOME_MAP/HomeMapSeven.ascx" TagPrefix="uc1" TagName="HomeMapSeven" %>







<style>
    .bannerqc{
        max-height:500px
    }
</style>
<link href="/Portals/_default/leaflet/leaflet.css" rel="stylesheet" />
<link rel="stylesheet" href="/Portals/_default/leaflet/Control.FullScreen.css" />

<uc1:HomeMapOne runat="server" ID="HomeMapOne" Visible="false"  />

<div class="banner-one">
 <asp:Literal ID="litBannerOne" runat="server"></asp:Literal>
    </div>
<uc1:HomeMapTwo runat="server" ID="HomeMapTwo"  Visible="false"/>
<div class="banner-two">
 <asp:Literal ID="litBannerTwo" runat="server"></asp:Literal>
    </div>
<uc1:HomeMapThree runat="server" ID="HomeMapThree" Visible="false" />
<div class="banner-three">
 <asp:Literal ID="litBannerThree" runat="server"></asp:Literal>
    </div>
<uc1:HomeMapFour runat="server" ID="HomeMapFour"  Visible="false"/>
<div class="banner-four">
 <asp:Literal ID="litBannerFour" runat="server"></asp:Literal>
    </div>
<uc1:HomeMapFive runat="server" ID="HomeMapFive" Visible="false" />
<div class="banner-five">
 <asp:Literal ID="litBannerFive" runat="server"></asp:Literal>
    </div>
<uc1:HomeMapSix runat="server" ID="HomeMapSix" Visible="false" />
<div class="banner-six">
 <asp:Literal ID="litBannerSix" runat="server"></asp:Literal>
    </div>
<uc1:HomeMapSeven runat="server" ID="HomeMapSeven" Visible="false" />
<div class="banner-seven">
 <asp:Literal ID="litBannerSeven" runat="server"></asp:Literal>
    </div>
<script src="/Portals/_default/leaflet/leaflet-src.js"></script>
<script src="/Portals/_default/leaflet/Control.FullScreen.js"></script>
<script src="/portals/_default/resource/owlcarousel/owl.carousel.min.js?v=5.0.0.9"></script>
<script>
    var vrtimeout = 2000;
    var cities = [];
    var currentCity;
    var currentWard;
    //var makers = [];
    var markersOne = new L.FeatureGroup();
    var markersTwo = new L.FeatureGroup();
    var markersThree = new L.FeatureGroup();
    var markersFour = new L.FeatureGroup();
    var markersFive = new L.FeatureGroup();
    var markersSix = new L.FeatureGroup();
    var markersSeven = new L.FeatureGroup();
    var polylinesOne = new L.FeatureGroup();
    var polylinesTwo = new L.FeatureGroup();
    var polylinesThree = new L.FeatureGroup();
    var polylinesFour = new L.FeatureGroup();
    var polylinesFive = new L.FeatureGroup();
    var polylinesSix = new L.FeatureGroup();
    var polylinesSeven = new L.FeatureGroup();
    var map;

    // Cấu hình backend để thay đổi được link map
    var pathAPI = 'https://tile.thunderforest.com/atlas/{z}/{x}/{y}.png?apikey=4bb0d1f946264840adc87b746159a513';
    var vietNamMarkers = [];

    function setCurrentView() {
        this.map.setView({ lat: currentCity.lat, lng: currentCity.lng }, currentCity.zoom);
        this.map.setMaxBounds(currentCity.maxBounds);
    }

    function setView(lat, lng, zoom) {
        this.map.setView({ lat: lat, lng: lng }, zoom);
    }


    function addPolygon(city) {
        if (city.wards != undefined && city.wards != null) {
            for (var i = 0; i < city.wards.length; i++) {
                //var polyline = L.polygon(reFormatData(city.wards[i].points), { color: city.wards[i].color, fillColor: city.wards[i].border_color, weight: 3, opacity: 0.5, fillOpacity: 0.1 }).addTo(map).bindPopup("<div>Quận/Huyện: " + city.wards[i].name + "</div>");;
                var polyline = L.polygon(reFormatData(city.wards[i].points), { color: city.wards[i].color, fillColor: city.wards[i].border_color, weight: 0.5, opacity: 0.5, fillOpacity: 0.1 }).addTo(map);;
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

    var osbOne = $('#owl-HomeBannerOne'); osbOne.owlCarousel({ autoplay: true, autoplayTimeout: 4500, nav: false, loop: true, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-HomeBannerOne').click(function () { osbOne.trigger('prev.owl.carousel'); }); $('#next-HomeBannerOne').click(function () { osbOne.trigger('next.owl.carousel'); });
    var osbTwo = $('#owl-HomeBannerTwo'); osbTwo.owlCarousel({ autoplay: true, autoplayTimeout: 4500, nav: false, loop: true, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-HomeBannerTwo').click(function () { osbTwo.trigger('prev.owl.carousel'); }); $('#next-HomeBannerTwo').click(function () { osbTwo.trigger('next.owl.carousel'); });
    var osbThree = $('#owl-HomeBannerThree'); osbThree.owlCarousel({ autoplay: true, autoplayTimeout: 4500, nav: false, loop: true, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-HomeBannerThree').click(function () { osbThree.trigger('prev.owl.carousel'); }); $('#next-HomeBannerThree').click(function () { osbThree.trigger('next.owl.carousel'); });
    var osbFour = $('#owl-HomeBannerFour'); osbFour.owlCarousel({ autoplay: true, autoplayTimeout: 4500, nav: false, loop: true, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-HomeBannerFour').click(function () { osbFour.trigger('prev.owl.carousel'); }); $('#next-HomeBannerFour').click(function () { osbFour.trigger('next.owl.carousel'); });
    var osbFive = $('#owl-HomeBannerFive'); osbFive.owlCarousel({ autoplay: true, autoplayTimeout: 4500, nav: false, loop: true, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-HomeBannerFive').click(function () { osbFive.trigger('prev.owl.carousel'); }); $('#next-HomeBannerFive').click(function () { osbFive.trigger('next.owl.carousel'); });
    var osbSix = $('#owl-HomeBannerSix'); osbSix.owlCarousel({ autoplay: true, autoplayTimeout: 4500, nav: false, loop: true, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-HomeBannerSix').click(function () { osbSix.trigger('prev.owl.carousel'); }); $('#next-HomeBannerSix').click(function () { osbSix.trigger('next.owl.carousel'); });
    var osbSeven = $('#owl-HomeBannerSeven'); osbSeven.owlCarousel({ autoplay: true, autoplayTimeout: 4500, nav: false, loop: true, dots: false, pagination: false, responsive: { 0: { items: 1 }, 600: { items: 1 }, 1000: { items: 1 } } }); $('#prev-HomeBannerSeven').click(function () { osbSeven.trigger('prev.owl.carousel'); }); $('#next-HomeBannerSeven').click(function () { osbSeven.trigger('next.owl.carousel'); });

</script>
