<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeBusiness.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeBusiness" %>

<div class="business-box bg-white">
    <div class=" container bg-main pd10 mgt10" style="box-shadow:0 0 0;">
        <div class="text-center">
            <a href="/nha-tuyen-dung"><h2 class="section-title mb-10">Doanh nghiệp hàng đầu</h2></a>
            <p class="font-lg color-text-paragraph-2">Tìm kiếm những nhà tuyển dụng hàng đầu mà bạn quan tâm.</p>
        </div>
        <asp:Literal ID="litBus" runat="server"></asp:Literal>

        <div class="link-readmore">
            <a href="/nha-tuyen-dung"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a>
        </div>
    </div>
</div>
