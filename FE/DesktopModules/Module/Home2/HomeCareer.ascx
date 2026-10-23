<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeCareer.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeCareer" %>

<section class="sptb">
    <div class="container">
        <div class="section-title center-block text-center">
            <h1>NHÓM VIỆC LÀM</h1>
            <p>Các việc làm phổ biến được phân chia theo từng nhóm, từng ngành cụ thể...</p>
        </div>
        <div class="item-all-cat center-block text-center education-categories">
            <div class="row">
                 <asp:Literal ID="litBus" runat="server"></asp:Literal>
            </div>
            <div class="mt-4"><a href="/viec-lam" title="Xem thêm việc làm" class="btn btn-primary btn-category"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a> </div>
        </div>
    </div>
</section>
