<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeSlider.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeSlider" %>
<%--<%@ Register Src="~/DesktopModules/Module/Home/SearchAdv.ascx" TagPrefix="uc1" TagName="SearchAdv" %>--%>

<div class="bg-background2 cover-image sptb-3 pb-14" data-image-src="http://file2.vieclamnamdinh.gov.vn/data/0/images/2023/11/21/host/slide3.png" style="background: url('http://file2.vieclamnamdinh.gov.vn/data/0/images/2023/11/21/host/slide3.png') center center;">
    <div class="header-text mb-0">
        <div class="container">
            <div class="text-center text-white mb-7">
                <h1 class="mb-1">Trung Tâm Dịch Vụ Việc Làm Nam Định</h1>
                <p>Một thực tế đã được chứng minh từ lâu là người đọc sẽ bị phân tâm bởi thứ có thể đọc được.</p>
            </div>
        </div>
    </div>
    <div class="header-slider-img">
        <div class="container">
            <asp:Literal ID="litSlide" runat="server" />
        </div>
    </div>
</div>
